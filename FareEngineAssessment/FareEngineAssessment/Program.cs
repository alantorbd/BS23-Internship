using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareEngineAssessment
{

    public enum TripStatus { Pending, Paid, Failed }
    public interface IPromotion
    {
        decimal ApplyDiscount(decimal currentFare);
    }
    public interface IPaymentService
    {
        bool ProcessPayment(string passengerId, decimal amount);
    }
    public abstract class Vehicle
    {
        public string LicensePlate { get; private set; }
        public decimal BaseFare { get; private set; }

        protected Vehicle(string licensePlate, decimal baseFare)
        {
            LicensePlate = licensePlate;
            BaseFare = baseFare;
        }
        public abstract decimal PerKmRate { get; }
        public abstract decimal PerMinuteRate { get; }
        public virtual decimal CalculateTripFare(decimal distanceKms, int durationMinutes)
        {
            return BaseFare + (distanceKms * PerKmRate) + (durationMinutes * PerMinuteRate);
        }
    }

    public class StandardCar : Vehicle 
    {
        public override decimal PerKmRate => 15.0m;
        public override decimal PerMinuteRate => 2.0m;
        public StandardCar(string licensePlate) : base(licensePlate, 50.0m) { }

    }

    public class LuxurySedan: Vehicle
    {
        public decimal FlatLuxuryTax { get; private set; } = 100m;
        public override decimal PerKmRate => 30m;
        public override decimal PerMinuteRate => 5m;
        public LuxurySedan(string licensePlate) : base(licensePlate, 150m) { }
        public override decimal CalculateTripFare(decimal distanceKms, int durationMinutes)
        {
            return base.CalculateTripFare(distanceKms, durationMinutes) + FlatLuxuryTax;
        }

    }

    public class PercentageDiscount : IPromotion
    {
        private readonly decimal _percentage;
        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal currentFare)
        {
            return (currentFare -  (currentFare *  _percentage / 100m));
        }
    }

    public class FlatAmountDiscount : IPromotion
    {
        private readonly decimal _discountAmount;
        public FlatAmountDiscount(decimal discountAmount)
        {
            _discountAmount = discountAmount;
        }
        public decimal ApplyDiscount(decimal currentFare)
        {
            return (currentFare - _discountAmount);
        }
    }

    public class CreditCardPaymentService : IPaymentService
    {
        public bool ProcessPayment(string passengerId, decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} for Passenger: {passengerId}...");
            return true;
        }
    }

    public class Passenger
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public Passenger(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class  InvalidTripException : Exception
    {
        public InvalidTripException(string message): base(message) { }
    }

    public class Trip
    {
        public Vehicle AssignedVehicle { get; private set; }
        public Passenger TripPassenger { get; private set; }
        public decimal DistanceKms { get; private set; }
        public int DurationMinutes { get; private set; }
        public TripStatus Status { get; private set; }
        public IPromotion Promotion { get; private set; }

        public Trip(Vehicle vehicle, Passenger passenger, decimal distanceKms, int durationMinutes, IPromotion promotion = null)
        {
            if (vehicle == null)
                throw new InvalidTripException("A vehicle must be assigned.");
            if (distanceKms < 0)
                throw new ArgumentException("Distance cannot be negative.");
            if (durationMinutes <= 0)
                throw new ArgumentException("Duration must be greater than zero.");

            AssignedVehicle = vehicle;
            TripPassenger = passenger;
            DistanceKms = distanceKms;
            DurationMinutes = durationMinutes;
            Promotion = promotion;
            Status = TripStatus.Pending;
        }

        public decimal CalculateFinalFare()
        {
            
            decimal fare = AssignedVehicle.CalculateTripFare(DistanceKms, DurationMinutes);

            if (Promotion != null)
            {
                fare = Promotion.ApplyDiscount(fare);
            }

            
            if (fare < AssignedVehicle.BaseFare)
            {
                fare = AssignedVehicle.BaseFare;
            }

            return fare;
        }
        public void CompleteTrip(IPaymentService paymentService)
        {
            decimal finalFare = CalculateFinalFare();
            bool isSuccess = paymentService.ProcessPayment(TripPassenger.Id, finalFare);
            Status = isSuccess ? TripStatus.Paid : TripStatus.Failed;

            Console.WriteLine($"Trip Status: {Status}\n");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var passenger = new Passenger("P-001", "Abdullah");
            var paymentService = new CreditCardPaymentService();
            try
            {
                Vehicle standardCar = new StandardCar("ABC-123");
                IPromotion tenPercentOff = new PercentageDiscount(10);
                var trip1 = new Trip(standardCar, passenger, 10m, 20, tenPercentOff);
                Console.WriteLine($"Trip 1 Final Fare: {trip1.CalculateFinalFare():C}");
                trip1.CompleteTrip(paymentService);

                
                Console.WriteLine("Testing Validation:");
                var trip2 = new Trip(standardCar, passenger, -5m, 10);
                trip2.CompleteTrip(paymentService);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

        }
    }


}

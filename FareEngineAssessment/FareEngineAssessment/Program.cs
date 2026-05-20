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

    public class Trip
    {
        // Candidate to implement domain logic, calculations, and abstraction 

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Candidate should write a small test suite here to demonstrate 
            // their code works under various test cases (Standard vs Luxury, with/

        }
    }


}

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
        public StandardCar(string licensePlate) : base(licensePlate, 50.0m) { }
        public override decimal PerKmRate => 15.0m;
        public override decimal PerMinuteRate => 2.0m;

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

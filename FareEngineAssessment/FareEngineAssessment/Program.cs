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
        // Candidate to implement properties and encapsulation
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

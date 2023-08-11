using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumberCleanCode
{
    //outside of any methods.
    enum Status { Active = 1, Inactive = 2 }    //making it clear that they represent different states of some entity.
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int number1 = 5;
            int number2 = 10;

            int amount1 = 5;
            double amount2= 5;


            // Set the initial status
            //Status userStatus = Status.Active;
            Status userStatus = Status.Inactive;// Changing status to Inactive


            if (userStatus == Status.Active)
            {

                Console.WriteLine("User is active.");
                //ConfirmStatus(true);
            }
            else if (userStatus == Status.Inactive)
            {
                Console.WriteLine("User is inactive.");
                //ConfirmStatus(false);
            }
            
                Console.WriteLine("-------------------------------------------");

            //number = number1 + 10; // Instead of this:
            number = number1 + number2;// Use a constant:
            Console.WriteLine("example for Use a constant: sum of numbers: " + number);
            Console.WriteLine("-------------------------------------------");


            Console.WriteLine("sum of "+ amount1+ " and " + amount2 + " = "+ CalculateSum(amount1, amount2));

        }
        static double CalculateSum(int amount1, double amount2)//Use a parameter: instad of--> int CalculateSum(int amount) return amount* 0.1;}
        {
            return amount1 + amount2;

        }

    }
}
//Use Constants
//Enumerations:
//Configurable Values
//Method or Function Parameters
//Comments and Documentation
//Use Meaningful Variable Names
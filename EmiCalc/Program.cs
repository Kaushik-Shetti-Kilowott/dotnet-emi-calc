// See https://aka.ms/new-console-template for more information
using System;
namespace EmiCalc
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            double p, i, n, t, emi;
            var sp=new EmiCalculator();
            try
            {
               
                Console.WriteLine("Enter the principle:");
                p = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine($"Principlal is {p}");
                Console.WriteLine("Enter the interest rate");
                i = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the loan duration");
                t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the monthly compounding");
                n = Convert.ToDouble(Console.ReadLine());
                emi = sp.CalculateEmi(p, i, t, n);
                Console.WriteLine("Monthly EMI is =" + Math.Round(emi, 2) + " INR");
                //Console.WriteLine("Monthly EMI is =" + emi + " INR");

            }
            catch (FormatException e)
            {
                
                Console.WriteLine("Enter valid integer");
            }
            finally
            {
                Console.WriteLine("Program executed perfectly");

            }
         
        }
    }
}


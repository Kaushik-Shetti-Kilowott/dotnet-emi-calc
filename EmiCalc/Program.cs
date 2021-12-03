﻿// See https://aka.ms/new-console-template for more information
using System;
namespace EmiCalc
{
    internal class Program
    {
        internal class EmiCalc
        {
            public double EmiCalculator(double p, double i, double t, double n)
            {
                double emi;
                emi = p * Math.Pow((1 + i / n), (t * n));
                return (emi) / 24;
            }
        }
            static void Main(string[] args)
        {
            var sp=new EmiCalc();
            double p, i, n, t, emi;
            Console.WriteLine("Enter the principle:");
            p = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Principlal is {p}");
            Console.WriteLine("Enter the interest rate");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the loan duration");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the monthly compounding");
            n = Convert.ToDouble(Console.ReadLine());
            //emi = emi_calculator(p, i, n, t);
            emi = sp.EmiCalculator(p, i, t, n);
            Console.WriteLine("Monthly EMI is =" +Math.Round(emi,2) + " INR");

         }
    }
}


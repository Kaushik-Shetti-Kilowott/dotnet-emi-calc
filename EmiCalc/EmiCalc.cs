﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmiCalc
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
}

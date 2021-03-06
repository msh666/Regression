﻿using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearRegression;
using System;
using System.Linq;

namespace Regression
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearRegression lr = new LinearRegression();
            PolynominalRegression pl = new PolynominalRegression();
            Multiple ml = new Multiple();
            FileProcessing fp = new FileProcessing();
            Exponential exp = new Exponential();
            Pokazatelnaya pk = new Pokazatelnaya();
            Logarifmic lg = new Logarifmic();
            Hyperbolic hp = new Hyperbolic();
            

            fp.InputName = "input.csv";
            fp.OutputName = "output.csv";

            double order;
            double[][] data = fp.ReadFromFile(out order);
            double[] xdata = data[0];
            double[] ydata = data[1];

            double[][] varLin = new double[2][];
            varLin[0] = xdata;
            varLin[1] = ydata;
            double[] linear = lr.Calculate(varLin);

            fp.Write(linear, "Linear Regression");

            double[][] varPol = new double[2][];
            varPol[0] = xdata;
            varPol[1] = ydata;
            pl.Order = order;
            double[] polyniminal = pl.Calculate(varPol);

            fp.Write(polyniminal, "Polynominal Regression");

            double[][] varMult = new double[data.Length - 2][];
            for(int i = 0; i < varMult.Length; i++)
            {
                varMult[i] = data[i + 2];
            }
            double[] multiple = ml.Calculate(varMult);

            fp.Write(multiple, "Multiple Regression");

            double[] exponential = exp.Calculate(varLin);
            fp.Write(exponential, "Exponential Regression");

            double[] pokaz = pk.Calculate(varLin);
            fp.Write(pokaz, "Pokazatelnaya Regression");

            double[] log = lg.Calculate(varLin);
            fp.Write(log, "Logarifmic Regression");

            double[] hyp = hp.Calculate(varLin);
            fp.Write(hyp, "Hyperbolic Regression");
        }
    }
}

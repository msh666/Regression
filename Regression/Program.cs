using MathNet.Numerics;
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

            fp.InputName = "input.csv";
            fp.OutputName = "output.csv";

            double order;
            double[][] data = fp.ReadFromFile(out order);
            double[] xdata = data[0];
            double[] ydata = data[1];

            double[][] var = new double[2][];
            var[0] = xdata;
            var[1] = ydata;
            double[] linear = lr.Calculate(var);

            fp.Write(linear, "Linear Regression");

            double[][] varPol = new double[3][];
            varPol[0] = xdata;
            varPol[1] = ydata;
            varPol[2] = new double[] { order };
            double[] polyniminal = pl.Calculate(varPol);

            fp.Write(polyniminal, "Polynominal Regression");

            double[][] varMult = new double[data.Length - 2][];
            for(int i = 0; i < varMult.Length; i++)
            {
                varMult[i] = data[i + 2];
            }
            double[] multiple = ml.Calculate(varMult);

            fp.Write(multiple, "Multiple Regression");
        }
    }
}

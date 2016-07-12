using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    class PolynominalRegression : ICalculate
    {
        public double[] Calculate(double[][] var)
        {
           double[] polynominal = Fit.Polynomial(var[0], var[1], Convert.ToInt32(var[2].First())); // polynomial of order 2
           return polynominal;
        }
    }
}

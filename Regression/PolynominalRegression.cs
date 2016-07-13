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
        private double order;

        public double Order
        {
            get { return order; }
            set { order = value; }
        }
            
        public double[] Calculate(double[][] var)
        {
           double[] polynominal = Fit.Polynomial(var[0], var[1], Convert.ToInt32(order)); // polynomial of order 2
           return polynominal;
        }
    }
}

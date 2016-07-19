using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace Regression
{
    class Exponential : ICalculate
    {
        public double[] Calculate(double[][] varLin)
        {
            var y_hat = varLin[1].Select(r => Math.Log(r)).ToArray();
            Tuple<double, double> exponent = Fit.Line(varLin[0], y_hat);
            double a = Math.Exp(exponent.Item1);
            double b = exponent.Item2;
            double[] exp = new double[] {a, b};
            return exp;
        }
    }
}

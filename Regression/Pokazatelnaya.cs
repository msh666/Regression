using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    class Pokazatelnaya : ICalculate
    {
        public double[] Calculate(double[][] varLin)
        {
            var y_hat = varLin[1].Select(r => Math.Log(r)).ToArray();
            Tuple<double, double> exponent = Fit.Line(varLin[0], y_hat);
            double a = Math.Exp(exponent.Item1);
            double b = Math.Exp(exponent.Item2);
            double[] pok = new double[] { a, b };
            return pok;
        }

    }
}

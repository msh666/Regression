using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace Regression
{
    class Logarifmic : ICalculate
    {
        public double[] Calculate(double[][] varLin)
        {
            var lnx = varLin[0].Select(r => Math.Log(r)).ToArray();
            Tuple<double, double> logarifm = Fit.Line(lnx, varLin[1]);
            double a = logarifm.Item1;
            double b = logarifm.Item2;
            double[] log = new double[] { a, b };
            return log;
        }
    }
}

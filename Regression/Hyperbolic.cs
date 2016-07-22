using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    class Hyperbolic : ICalculate
    {
        public double[] Calculate(double[][] varLin)
        {
            var powx = varLin[0].Select(r => Math.Pow(r,-1)).ToArray();
            Tuple<double, double> hyperbol = Fit.Line(powx, varLin[1]);
            double a = hyperbol.Item1;
            double b = hyperbol.Item2;
            double[] hyp = new double[] { a, b };
            return hyp;
        }
    }
}

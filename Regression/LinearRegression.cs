using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    class LinearRegression : ICalculate
    {
        public double[] Calculate(double[][] varLin)
        {
            Tuple<double, double> linear = Fit.Line(varLin[0], varLin[1]);
            double intercept = linear.Item1; // == 10; intercept
            double slope = linear.Item2; // == 0.5; slope

            //double determination = GoodnessOfFit.RSquared(var[1].Select(x => intercept + slope * x), var[2]);
            double[] lin = new double[] { intercept, slope };
            return lin;
        }
    }
}

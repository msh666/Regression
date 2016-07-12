using MathNet.Numerics;
using MathNet.Numerics.LinearRegression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    class Multiple : ICalculate
    {
        public double[] Calculate(double[][] var)
        {
            double[] multiple = Fit.MultiDim(
                new[] { var[0], var[1],var[2] },
                var[3],
                intercept: true);        
            return multiple;
        }
    }
}

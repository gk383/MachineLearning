using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningMethods.DistanceCalculators
{
    public class ManhattanDistance : IDistanceCalculator
    {
        public double GetDistance(List<double> a, List<double> b)
        {
            if (a.Count != b.Count)
            {
                throw new ArgumentException();
            }
            double result = 0;
            for (int i = 0; i < a.Count; i++)
            {
                result += Math.Abs((a[i] - b[i]));
            }          
            return result;
        }
    }
}

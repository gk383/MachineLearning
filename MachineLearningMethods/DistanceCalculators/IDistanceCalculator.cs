using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningMethods.DistanceCalculators
{
    public interface IDistanceCalculator
    {
        Double GetDistance(List<double> a, List<double> b);
    }
}

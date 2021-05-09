using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningMethods.Entities
{
    public class KnnCheckSuccesRateResult
    {
        public int TestDataCount { get; set; }
        public int CorrectPredictionCount { get; set; }
        public int WrongPredictionCount { get; set; }
        public double SuccessRate { get; set; }
    }
}

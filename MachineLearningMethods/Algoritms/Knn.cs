using MachineLearningMethods.DistanceCalculators;
using MachineLearningMethods.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace MachineLearningMethods.Algoritms
{
    public class Knn<TDataSet>
        where TDataSet : new()
    {
        IDistanceCalculator _distanceCalculator;
        public Knn(IDistanceCalculator distanceCalculator)
        {
            _distanceCalculator = distanceCalculator;
        }
        public TDataSet PredictInput(List<TDataSet> dataSet, string labelColumName, TDataSet dataToPredict, int k)

        {
            // find a(dataToPredict) point without label colum
            List<Double> a = new List<double>();
            foreach (PropertyInfo property in dataToPredict.GetType().GetProperties())
            {
                if (property.Name != labelColumName)
                {
                    a.Add(Convert.ToDouble(property.GetValue(dataToPredict)));
                }
            }

            //Find b(dataset) without label
            Dictionary<Int32, Double> resultDictionary = new Dictionary<int, double>();
            int rowIndex = 0;           
            foreach (TDataSet row in dataSet)
            {
                int ColumNum = 0;

                List<Double> b = new List<double>();
                foreach (PropertyInfo property in row.GetType().GetProperties())
                {                   

                    if (property.Name != labelColumName)
                    {
                        b.Add(Convert.ToDouble(property.GetValue(row)));

                    }
                }
               
                // Get distance a to b
                double distance = _distanceCalculator.GetDistance(a, b);
                
                resultDictionary.Add(rowIndex, distance);
                rowIndex++;
            }
            //Order distance and take K
            resultDictionary = resultDictionary.OrderBy(x => x.Value).Take(k).ToDictionary(x => x.Key, x => x.Value);

            // Calculate label count in K
            List<TDataSet> result = new List<TDataSet>();
            object SelectedLabel;
            Dictionary<object, int> labelCount = new Dictionary<object, int>();
            foreach (var item in resultDictionary)
            {
                result.Add(dataSet[item.Key]);
                var _label = dataSet[item.Key].GetType().GetProperties()
                     .Where(l => l.Name == labelColumName).FirstOrDefault()
                     .GetValue(dataSet[item.Key]);
                if (labelCount.ContainsKey(_label))
                {
                    labelCount[_label] = labelCount[_label] + 1;
                }
                else
                {
                    labelCount.Add(_label, 1);
                }

            }

            //Orderby key count to take max label value
            labelCount = labelCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            //Prepare return result;
            TDataSet returnResult = new TDataSet();
            foreach (PropertyInfo property in returnResult.GetType().GetProperties())
            {
                if (property.Name == labelColumName)
                {
                    property.SetValue(
                     returnResult,
                     labelCount.Keys.FirstOrDefault()
                     );

                }
                else
                {
                    property.SetValue(
                    returnResult,
                    dataToPredict.GetType()
                    .GetProperties()
                    .Where(l => l.Name == property.Name)
                    .FirstOrDefault()
                    .GetValue(dataToPredict)
                    );
                }
                
            }

            //returnResult.GetType().GetProperties().Where(l => l.Name == labelColumName).FirstOrDefault()
            //    .SetValue(dataToPredict, labelCount.Keys.FirstOrDefault());

            return returnResult;
        }
        public KnnCheckSuccesRateResult CheckSuccesRate(List<TDataSet> dataSet, string labelColumName, int k, byte testDatePercent, bool shuffleDataSet)
        {
            //Shuffle dataset
            if (shuffleDataSet)
            {
                Shuffle<TDataSet>(dataSet);
            }
            
            //Split test data
            int ItemCountInTestData = (dataSet.Count * testDatePercent) / 100;
            List<TDataSet> testDataSet = dataSet.Take(ItemCountInTestData).ToList();
            List<TDataSet> learnDataSet = dataSet.Skip(ItemCountInTestData).ToList();

            //Calculate corrent and wrong predictions
            int correctPrediction = 0;
            int wrongPrediction = 0;
            foreach (var item in testDataSet)
            {
                var realResult = item.GetType().GetProperties()
                  .Where(l => l.Name == labelColumName).FirstOrDefault()
                  .GetValue(item);
                
                TDataSet result = PredictInput(learnDataSet, labelColumName, item, k);
                
                var prediction = result.GetType().GetProperties()
                  .Where(l => l.Name == labelColumName).FirstOrDefault()
                  .GetValue(result);
                if (prediction.Equals(realResult))
                {
                    correctPrediction++;
                }
                else
                {
                    wrongPrediction++;
                }
            }
            //Find success rate %
            KnnCheckSuccesRateResult returnResult = new KnnCheckSuccesRateResult();
            returnResult.TestDataCount = testDataSet.Count;
            returnResult.CorrectPredictionCount = correctPrediction;
            returnResult.WrongPredictionCount = wrongPrediction;
            returnResult.SuccessRate = (((double)correctPrediction / (double)testDataSet.Count) * (double)100);
            return returnResult;
        }
        private void Shuffle<T>(List<T> list)
        {
            //for (int i = 0; i < (list.Count/2); i += 2)
            //{
            //    int k = (list.Count - 1) - i;
            //    T value = list[k];
            //    list[k] = list[i];
            //    list[i] = value;
            //}
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}

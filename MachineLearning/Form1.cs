using MachineLearningMethods.Algoritms;
using MachineLearningMethods.DistanceCalculators;
using MachineLearningMethods.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string dataFile = @"c:\keytours\Keytours7FixedDestination.json";
        private List<InsuranceData> _dataSet;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<string> dsCalculator = new List<string>();
            dsCalculator.Add("Euclid");
            dsCalculator.Add("Manhattan");

            cbCalculator.DataSource = dsCalculator;

            txtAge.Text = "25";
            txtGender.Text = "0";
            txtLat.Text = "25.00";
            txtLong.Text = "30.00";
            txtTourPrice.Text = "1500";
            txtTourDays.Text = "10";

            using (StreamReader file = File.OpenText(dataFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                _dataSet =
                    (List<InsuranceData>)serializer.Deserialize(file, typeof(List<InsuranceData>));
            }
        }
        private void btnSuccessRate_Click(object sender, EventArgs e)
        {


            pnlRates.Visible = false;

            //Select distance calculator
            IDistanceCalculator distanceCalculator;

            if (cbCalculator.SelectedValue.ToString() == "Euclid")
            {
                distanceCalculator = new EuclideanDistance();
            }
            else if (cbCalculator.SelectedValue.ToString() == "Manhattan")
            {
                distanceCalculator = new ManhattanDistance();
            }
            else
            {
                distanceCalculator = new EuclideanDistance();
            }

            int k = Convert.ToInt32(txtKValue.Text);
            byte testPercennt = Convert.ToByte(txtTestDataPer.Text);
            bool isShuffle = chkShuffle.Checked;

            Knn<InsuranceData> Knn = new Knn<InsuranceData>(distanceCalculator);

            //Test the data
            KnnCheckSuccesRateResult result =
                Knn.CheckSuccesRate(_dataSet.ToList(), "HasInsurance", k, testPercennt, isShuffle);


            lblTestCount.Text = result.TestDataCount.ToString();
            lblCorrectCount.Text = result.CorrectPredictionCount.ToString();
            lblWrongCount.Text = result.WrongPredictionCount.ToString();
            lblSuccessRate.Text = result.SuccessRate.ToString("00") + "%";

            pnlRates.Visible = true;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            InsuranceData _testData =
                new InsuranceData
                {
                    Age = Convert.ToInt32(txtAge.Text),
                    Gender = Convert.ToInt32(txtGender.Text),
                    HasInsurance = false,
                    Latitude = Convert.ToDouble(txtLat.Text),
                    Longitude = Convert.ToDouble(txtLat.Text),
                    TourPrice = Convert.ToDouble(txtTourPrice.Text),
                    TourDays = Convert.ToInt32(txtTourDays.Text)
                };

            //Select distance calculator
            IDistanceCalculator distanceCalculator;

            if (cbCalculator.SelectedValue.ToString() == "Euclid")
            {
                distanceCalculator = new EuclideanDistance();
            }
            else if (cbCalculator.SelectedValue.ToString() == "Manhattan")
            {
                distanceCalculator = new ManhattanDistance();
            }
            else
            {
                distanceCalculator = new EuclideanDistance();
            }

            int k = Convert.ToInt32(txtKValue.Text);
            byte testPercennt = Convert.ToByte(txtTestDataPer.Text);
            bool isShuffle = chkShuffle.Checked;

            Knn<InsuranceData> Knn = new Knn<InsuranceData>(distanceCalculator);

            InsuranceData result = Knn.PredictInput(_dataSet, "HasInsurance", _testData, k);

            if (result.HasInsurance)
            {
                txtPrediction.Text = (result.Gender == 0 ? "He" : "She") + " will buy insurance";
            }
            else
            {
                txtPrediction.Text = (result.Gender == 0 ? "He" : "She") + " won't buy insurance";
            }
        }
    }
    public class InsuranceData
    {
        public int Gender { get; set; }
        public int Age { get; set; }
        public double TourPrice { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double TourDays { get; set; }
        public bool HasInsurance { get; set; }
    }

}

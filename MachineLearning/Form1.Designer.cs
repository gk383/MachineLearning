namespace MachineLearning
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnSuccessRate = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtTourPrice = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtTourDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblWrongCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSuccessRate = new System.Windows.Forms.Label();
            this.lblTestCount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCalculator = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKValue = new System.Windows.Forms.TextBox();
            this.txtTestDataPer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chkShuffle = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrediction = new System.Windows.Forms.Label();
            this.pnlRates = new System.Windows.Forms.Panel();
            this.pnlRates.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(686, 312);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 24);
            this.btnPredict.TabIndex = 0;
            this.btnPredict.Text = "Predict Input";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnSuccessRate
            // 
            this.btnSuccessRate.Location = new System.Drawing.Point(309, 173);
            this.btnSuccessRate.Name = "btnSuccessRate";
            this.btnSuccessRate.Size = new System.Drawing.Size(127, 24);
            this.btnSuccessRate.TabIndex = 1;
            this.btnSuccessRate.Text = "Find Succes Rate";
            this.btnSuccessRate.UseVisualStyleBackColor = true;
            this.btnSuccessRate.Click += new System.EventHandler(this.btnSuccessRate_Click);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(40, 315);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(148, 315);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 3;
            // 
            // txtTourPrice
            // 
            this.txtTourPrice.Location = new System.Drawing.Point(256, 315);
            this.txtTourPrice.Name = "txtTourPrice";
            this.txtTourPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTourPrice.TabIndex = 4;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(364, 315);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 20);
            this.txtLat.TabIndex = 5;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(472, 315);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 20);
            this.txtLong.TabIndex = 6;
            // 
            // txtTourDays
            // 
            this.txtTourDays.Location = new System.Drawing.Point(580, 315);
            this.txtTourDays.Name = "txtTourDays";
            this.txtTourDays.Size = new System.Drawing.Size(100, 20);
            this.txtTourDays.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gender (0-M 1-F)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tour price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Latitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Longitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tour days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(489, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Prediction of travel insurance purchase with K-NN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Correct prediction";
            // 
            // lblCorrectCount
            // 
            this.lblCorrectCount.AutoSize = true;
            this.lblCorrectCount.Location = new System.Drawing.Point(141, 23);
            this.lblCorrectCount.Name = "lblCorrectCount";
            this.lblCorrectCount.Size = new System.Drawing.Size(13, 13);
            this.lblCorrectCount.TabIndex = 16;
            this.lblCorrectCount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Wrong prediction";
            // 
            // lblWrongCount
            // 
            this.lblWrongCount.AutoSize = true;
            this.lblWrongCount.Location = new System.Drawing.Point(296, 23);
            this.lblWrongCount.Name = "lblWrongCount";
            this.lblWrongCount.Size = new System.Drawing.Size(13, 13);
            this.lblWrongCount.TabIndex = 18;
            this.lblWrongCount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(432, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Success rate";
            // 
            // lblSuccessRate
            // 
            this.lblSuccessRate.AutoSize = true;
            this.lblSuccessRate.Location = new System.Drawing.Point(432, 23);
            this.lblSuccessRate.Name = "lblSuccessRate";
            this.lblSuccessRate.Size = new System.Drawing.Size(21, 13);
            this.lblSuccessRate.TabIndex = 20;
            this.lblSuccessRate.Text = "0%";
            // 
            // lblTestCount
            // 
            this.lblTestCount.AutoSize = true;
            this.lblTestCount.Location = new System.Drawing.Point(1, 23);
            this.lblTestCount.Name = "lblTestCount";
            this.lblTestCount.Size = new System.Drawing.Size(13, 13);
            this.lblTestCount.TabIndex = 22;
            this.lblTestCount.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Test data count";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(157, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Distance calcualtor";
            // 
            // cbCalculator
            // 
            this.cbCalculator.FormattingEnabled = true;
            this.cbCalculator.Location = new System.Drawing.Point(160, 130);
            this.cbCalculator.Name = "cbCalculator";
            this.cbCalculator.Size = new System.Drawing.Size(121, 21);
            this.cbCalculator.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(303, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "K value";
            // 
            // txtKValue
            // 
            this.txtKValue.Location = new System.Drawing.Point(306, 130);
            this.txtKValue.Name = "txtKValue";
            this.txtKValue.Size = new System.Drawing.Size(100, 20);
            this.txtKValue.TabIndex = 26;
            this.txtKValue.Text = "1";
            // 
            // txtTestDataPer
            // 
            this.txtTestDataPer.Location = new System.Drawing.Point(431, 130);
            this.txtTestDataPer.Name = "txtTestDataPer";
            this.txtTestDataPer.Size = new System.Drawing.Size(100, 20);
            this.txtTestDataPer.TabIndex = 28;
            this.txtTestDataPer.Text = "30";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(428, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Test data %";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(553, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Shuffle data";
            // 
            // chkShuffle
            // 
            this.chkShuffle.AutoSize = true;
            this.chkShuffle.Checked = true;
            this.chkShuffle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShuffle.Location = new System.Drawing.Point(556, 130);
            this.chkShuffle.Name = "chkShuffle";
            this.chkShuffle.Size = new System.Drawing.Size(15, 14);
            this.chkShuffle.TabIndex = 30;
            this.chkShuffle.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(321, 359);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Prediction for input";
            // 
            // txtPrediction
            // 
            this.txtPrediction.AutoSize = true;
            this.txtPrediction.ForeColor = System.Drawing.Color.Red;
            this.txtPrediction.Location = new System.Drawing.Point(321, 386);
            this.txtPrediction.Name = "txtPrediction";
            this.txtPrediction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrediction.Size = new System.Drawing.Size(10, 13);
            this.txtPrediction.TabIndex = 32;
            this.txtPrediction.Text = "-";
            // 
            // pnlRates
            // 
            this.pnlRates.Controls.Add(this.label12);
            this.pnlRates.Controls.Add(this.label8);
            this.pnlRates.Controls.Add(this.lblCorrectCount);
            this.pnlRates.Controls.Add(this.label10);
            this.pnlRates.Controls.Add(this.lblWrongCount);
            this.pnlRates.Controls.Add(this.lblSuccessRate);
            this.pnlRates.Controls.Add(this.label15);
            this.pnlRates.Controls.Add(this.lblTestCount);
            this.pnlRates.Location = new System.Drawing.Point(112, 221);
            this.pnlRates.Name = "pnlRates";
            this.pnlRates.Size = new System.Drawing.Size(517, 40);
            this.pnlRates.TabIndex = 34;
            this.pnlRates.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 420);
            this.Controls.Add(this.pnlRates);
            this.Controls.Add(this.txtPrediction);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chkShuffle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTestDataPer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtKValue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbCalculator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTourDays);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtTourPrice);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.btnSuccessRate);
            this.Controls.Add(this.btnPredict);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlRates.ResumeLayout(false);
            this.pnlRates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnSuccessRate;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtTourPrice;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtTourDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblWrongCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSuccessRate;
        private System.Windows.Forms.Label lblTestCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCalculator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKValue;
        private System.Windows.Forms.TextBox txtTestDataPer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkShuffle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txtPrediction;
        private System.Windows.Forms.Panel pnlRates;
    }
}


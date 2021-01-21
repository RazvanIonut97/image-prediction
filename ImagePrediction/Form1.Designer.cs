
namespace ImagePrediction
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnShowHist = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.imagineOriginala = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImagineMatriceEroare = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.showErrorMatrixBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveDecoded = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnLoadEncoded = new System.Windows.Forms.Button();
            this.ImaginePredictie = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.histogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadImage = new System.Windows.Forms.OpenFileDialog();
            this.loadEncoded = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagineOriginala)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagineMatriceEroare)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImaginePredictie)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btnStore);
            this.groupBox1.Controls.Add(this.btnPredict);
            this.groupBox1.Controls.Add(this.btnLoadImg);
            this.groupBox1.Controls.Add(this.imagineOriginala);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encode";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnShowHist);
            this.groupBox5.Controls.Add(this.checkedListBox1);
            this.groupBox5.Controls.Add(this.checkedListBox2);
            this.groupBox5.Location = new System.Drawing.Point(6, 317);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 187);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Settings";
            // 
            // btnShowHist
            // 
            this.btnShowHist.Location = new System.Drawing.Point(138, 74);
            this.btnShowHist.Name = "btnShowHist";
            this.btnShowHist.Size = new System.Drawing.Size(106, 23);
            this.btnShowHist.TabIndex = 7;
            this.btnShowHist.Text = "Show Histogram";
            this.btnShowHist.UseVisualStyleBackColor = true;
            this.btnShowHist.Click += new System.EventHandler(this.btnShowHist_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "128",
            "A",
            "B",
            "C",
            "A+B-C",
            "A+(B-C)/2",
            "B+(A-C)/2",
            "(A+B)/2",
            "jpegLS"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(95, 139);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Original",
            "Error prediction",
            "Decoded"});
            this.checkedListBox2.Location = new System.Drawing.Point(138, 19);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(108, 49);
            this.checkedListBox2.TabIndex = 5;
            this.checkedListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox2_ItemCheck);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(187, 280);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 3;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(97, 281);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Location = new System.Drawing.Point(6, 281);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImg.TabIndex = 1;
            this.btnLoadImg.Text = "Load Image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // imagineOriginala
            // 
            this.imagineOriginala.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagineOriginala.Location = new System.Drawing.Point(6, 19);
            this.imagineOriginala.Name = "imagineOriginala";
            this.imagineOriginala.Size = new System.Drawing.Size(256, 256);
            this.imagineOriginala.TabIndex = 0;
            this.imagineOriginala.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImagineMatriceEroare);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.showErrorMatrixBtn);
            this.groupBox2.Location = new System.Drawing.Point(292, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Error Matrix";
            // 
            // ImagineMatriceEroare
            // 
            this.ImagineMatriceEroare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImagineMatriceEroare.Location = new System.Drawing.Point(6, 18);
            this.ImagineMatriceEroare.Name = "ImagineMatriceEroare";
            this.ImagineMatriceEroare.Size = new System.Drawing.Size(256, 256);
            this.ImagineMatriceEroare.TabIndex = 9;
            this.ImagineMatriceEroare.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(187, 282);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // showErrorMatrixBtn
            // 
            this.showErrorMatrixBtn.Location = new System.Drawing.Point(54, 280);
            this.showErrorMatrixBtn.Name = "showErrorMatrixBtn";
            this.showErrorMatrixBtn.Size = new System.Drawing.Size(104, 23);
            this.showErrorMatrixBtn.TabIndex = 7;
            this.showErrorMatrixBtn.Text = "Show Error Matrix";
            this.showErrorMatrixBtn.UseVisualStyleBackColor = true;
            this.showErrorMatrixBtn.Click += new System.EventHandler(this.showErrorMatrixBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveDecoded);
            this.groupBox3.Controls.Add(this.btnDecode);
            this.groupBox3.Controls.Add(this.btnLoadEncoded);
            this.groupBox3.Controls.Add(this.ImaginePredictie);
            this.groupBox3.Location = new System.Drawing.Point(575, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 311);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prediction Matrix";
            // 
            // btnSaveDecoded
            // 
            this.btnSaveDecoded.Location = new System.Drawing.Point(182, 282);
            this.btnSaveDecoded.Name = "btnSaveDecoded";
            this.btnSaveDecoded.Size = new System.Drawing.Size(88, 23);
            this.btnSaveDecoded.TabIndex = 7;
            this.btnSaveDecoded.Text = "Save Decoded";
            this.btnSaveDecoded.UseVisualStyleBackColor = true;
            this.btnSaveDecoded.Click += new System.EventHandler(this.btnSaveDecoded_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(100, 280);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 6;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnLoadEncoded
            // 
            this.btnLoadEncoded.Location = new System.Drawing.Point(7, 280);
            this.btnLoadEncoded.Name = "btnLoadEncoded";
            this.btnLoadEncoded.Size = new System.Drawing.Size(86, 23);
            this.btnLoadEncoded.TabIndex = 5;
            this.btnLoadEncoded.Text = "Load Encoded";
            this.btnLoadEncoded.UseVisualStyleBackColor = true;
            this.btnLoadEncoded.Click += new System.EventHandler(this.btnLoadEncoded_Click);
            // 
            // ImaginePredictie
            // 
            this.ImaginePredictie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImaginePredictie.Location = new System.Drawing.Point(6, 19);
            this.ImaginePredictie.Name = "ImaginePredictie";
            this.ImaginePredictie.Size = new System.Drawing.Size(256, 256);
            this.ImaginePredictie.TabIndex = 4;
            this.ImaginePredictie.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.histogramChart);
            this.groupBox4.Location = new System.Drawing.Point(291, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(560, 193);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Histogram";
            // 
            // histogramChart
            // 
            chartArea1.Name = "ChartArea1";
            this.histogramChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histogramChart.Legends.Add(legend1);
            this.histogramChart.Location = new System.Drawing.Point(7, 19);
            this.histogramChart.Name = "histogramChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Histogram";
            this.histogramChart.Series.Add(series1);
            this.histogramChart.Size = new System.Drawing.Size(548, 168);
            this.histogramChart.TabIndex = 0;
            this.histogramChart.Text = "Histograma";
            title1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Name = "Title1";
            title1.Text = "Intensity";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "Title2";
            title2.Text = "Frequnecy";
            this.histogramChart.Titles.Add(title1);
            this.histogramChart.Titles.Add(title2);
            // 
            // loadImage
            // 
            this.loadImage.FileName = "openFileDialog1";
            this.loadImage.Filter = "Files|*.bmp;";
            // 
            // loadEncoded
            // 
            this.loadEncoded.FileName = "openFileDialog1";
            this.loadEncoded.Filter = "Files|*.pre;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 538);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Image Predictor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagineOriginala)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagineMatriceEroare)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImaginePredictie)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imagineOriginala;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox ImaginePredictie;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button btnShowHist;
        private System.Windows.Forms.Button showErrorMatrixBtn;
        private System.Windows.Forms.Button btnSaveDecoded;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnLoadEncoded;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.OpenFileDialog loadImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramChart;
        private System.Windows.Forms.PictureBox ImagineMatriceEroare;
        private System.Windows.Forms.OpenFileDialog loadEncoded;
    }
}


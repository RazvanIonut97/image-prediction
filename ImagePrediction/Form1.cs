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

namespace ImagePrediction
{
    public partial class Form1 : Form
    {
        Bitmap bitmapObj;
        Predictor p= new Predictor();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);
        }
        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox2.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox2.SetItemChecked(ix, false);
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            DialogResult d = loadImage.ShowDialog();
            if (d == DialogResult.OK)
            {
                bitmapObj = new Bitmap(loadImage.FileName);
                imagineOriginala.Image = bitmapObj;
                //---------------------------------
                p.Bmp = bitmapObj;
                //---------------------------------
            }
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                string a = checkedListBox1.SelectedItem.ToString();
                p.Metoda = checkedListBox1.Items.IndexOf(a);

                p.MatriceOriginala = p.CalculeazaMatriceOriginala();

                p.MatriceDePredictie = p.CalculeazaMatriceDePredictie();

                p.MatriceDeEroare = p.CalculeazaMatriceDeEroare();

                ImaginePredictie.Image = p.ReturnBitmap(p.MatriceDePredictie);
              
            }
        }

        private void showErrorMatrixBtn_Click(object sender, EventArgs e)
        {
 
           ImagineMatriceEroare.Image = p.ReturnBitmap(p.MatriceNormalizata);
        }

        private void btnShowHist_Click(object sender, EventArgs e)
        {
            histogramChart.Series[0].Points.Clear();
            if (checkedListBox2.CheckedItems.Count != 0)
            {
                string a = checkedListBox2.SelectedItem.ToString();
                int caz= checkedListBox2.Items.IndexOf(a);
                int[,] matrix = new int[256, 256];
                switch (caz)
                {
                    case 0:
                        matrix = p.MatriceOriginala;
                        break;
                    case 1:
                        matrix = p.MatriceDeEroare;
                        break;
                    case 2:
                        matrix = p.MatriceDePredictie;
                        break;
                }
                
                Dictionary<int, int> H = new Dictionary<int, int>();
                for (int i = 0; i < 256; i++)
                {
                    for (int j = 0; j < 256; j++)
                    {
                        int valoarePixel = matrix[i, j];
                        if (H.ContainsKey(valoarePixel))
                        {
                            H[valoarePixel] += 1;
                        }
                        else
                        {
                            H.Add(valoarePixel, 1);
                        }
                    }
                }
                foreach(KeyValuePair<int,int> item in H)
                {
                    histogramChart.Series[0].Points.AddXY(item.Key,item.Value);
                }
                
            }

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            var fisier = File.ReadAllBytes(loadImage.FileName);
            for (int i = 0; i < 1078; i++)
            {
                p.MetaData[i] = fisier[i];
            }
            p.MetaData[1078] = Convert.ToByte(p.Metoda);

            FileStream fisierCodat = new FileStream(loadImage.FileName + p.Metoda.ToString() + ".pre", FileMode.Create);
            for (int i = 0; i < 1079; i++)
            {
                fisierCodat.WriteByte(p.MetaData[i]);
            }

            byte[] metadata = new byte[73728];
            for(int i = 0; i < 73728;i++) {
                fisierCodat.WriteByte(p.MatricePeBiti[i]);
            }
            fisierCodat.Flush();
            
        }

        private void btnLoadEncoded_Click(object sender, EventArgs e)
        {
            DialogResult d = loadEncoded.ShowDialog();
            if (d == DialogResult.OK)
            {
                p.Fisier = File.ReadAllBytes(loadEncoded.FileName);
                p.ExtrageMetaData(p.Fisier);
                p.ExtrageMetoda(p.Fisier);
                p.ExtrageMatriceDeEroare(p.Fisier);
                
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            p.Decodeaza();
            imagineOriginala.Image = p.ReturnBitmap(p.MatriceOriginala);
            ImaginePredictie.Image = p.ReturnBitmap(p.MatriceDePredictie);
        }


        private void btnSaveDecoded_Click(object sender, EventArgs e)
        {

            FileStream fisierDecodat = new FileStream(loadEncoded.FileName+".bmp", FileMode.Create);
            for (int i = 0; i < 1078; i++)
            {
                fisierDecodat.WriteByte(p.MetaData[i]);
            }
            for(int i = 0; i < 256; i++)
            {
                for(int j = 0; j < 256; j++)
                {
                    fisierDecodat.WriteByte(Convert.ToByte(p.MatriceOriginala[i, j]));
                }
            }
            fisierDecodat.Flush();
        }
    }
}

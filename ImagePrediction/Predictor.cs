using System;
using System.Collections.Generic;
using System.Drawing;



namespace ImagePrediction
{
    internal class Predictor
    {
        Bitmap bmp;
        int metoda;
        int[,] matriceOriginala = new int[256,256];
        int[,] matriceDeEroare= new int[256,256];
        int[,] matriceNormalizata = new int[256, 256];
        int[,] matriceDePredictie=new int[256,256];
        byte[] metaData=new byte[1079];
        byte[] matricePeBiti = new byte[73728];
        byte[] fisier;


        public Bitmap Bmp { get => bmp; set => bmp = value; }
        public int Metoda { get=>metoda; set=>metoda=value; }
        public byte[] MetaData { get => metaData; set => metaData = value; }
        public int[,] MatriceDePredictie { get => matriceDePredictie; set => matriceDePredictie = value; }
        public int[,] MatriceDeEroare { get => matriceDeEroare; set => matriceDeEroare = value; }
        public int[,] MatriceOriginala { get => matriceOriginala; set => matriceOriginala = value; }
        public int[,] MatriceNormalizata { get => matriceNormalizata; set => matriceNormalizata = value; }
        public byte[] MatricePeBiti { get => matricePeBiti; set => matricePeBiti = value; }
        public byte[] Fisier { get => fisier; set => fisier = value; }
        public Bitmap ReturnBitmap(int[,] matrix)
        {
            Bitmap b = new Bitmap(256, 256);
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    int culoare;
                    culoare = matrix[i, j];
                    b.SetPixel(i, j, Color.FromArgb(culoare, culoare, culoare));
                }
            }
            return b;
        }
        internal int[,] CalculeazaMatriceDePredictie()
        {
            int[,] matrix = new int[256, 256];
            matrix[0, 0] = 128;
            if (metoda == 0) {
                for (int i = 1; i < 256; i++)
                {
                    matrix[i, 0] = 128;
                    matrix[0, i] = 128;
                }
            }
            else
            {
                for (int i = 1; i < 256; i++)
                {
                    matrix[i, 0] = matriceOriginala[i - 1, 0];
                    matrix[0, i] = matriceOriginala[0, i - 1];
                }
            }
            for (int i = 1; i < 256; i++)
            {
                for (int j = 1; j < 256; j++)
                {
                    int A = MatriceOriginala[i, j - 1];
                    int B = MatriceOriginala[i - 1, j];
                    int C = MatriceOriginala[i - 1, j - 1];
                    int valoarePixel=0;
                    
                    switch (metoda)
                    {
                        case 0:
                            valoarePixel = 128; //128
                            break;
                        case 1:
                            valoarePixel = A;
                            break;
                        case 2:
                            valoarePixel = B;
                            break;
                        case 3:
                            valoarePixel = C;
                            break;
                        case 4:
                            valoarePixel = A + B - C;
                            break;
                        case 5:
                            valoarePixel = A + (B - C) / 2;
                            break;
                        case 6:
                            valoarePixel = B + (A - C) / 2;
                            break;
                        case 7:
                            valoarePixel = (A + B) / 2;
                            break;
                        case 8:
                            if (C >= Min(A, B)) 
                            {
                                valoarePixel = Max(A, B);                             
                            } 
                            else if(C <= Max(A, B))
                            {
                                valoarePixel = Min(A, B);
                            }
                            else 
                            { 
                                valoarePixel = A + B - C;
                            }
                            break;
                           
                    }
                    if (valoarePixel > 255) valoarePixel = 255;
                    if (valoarePixel <0) valoarePixel = 0;

                    matrix[i, j] = valoarePixel;
                }
            }
            return matrix;
        }       
        internal int[,] CalculeazaMatriceOriginala()
        {
            int[,] matrix = new int[256,256];
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    matrix[i, j] = bmp.GetPixel(i, j).R;
                }
            }
            return matrix;
        }
        internal int[,] CalculeazaMatriceDeEroare()
        {
            int[,] matrix = new int[256, 256];
           
            for (int i=0;i<256;i++) 
            {
                for (int j=0;j<256;j++) 
                {
                    matrix[i, j] = matriceOriginala[i, j] - matriceDePredictie[i, j];
                }
            }
     
            CalculeazaMatriceaDeEroaareNormalizata(matrix);
            MatricePeBiti = CalculeazaMatricePeBiti(matrix);
           
           
            return matrix;
        }

        private void CalculeazaMatriceaDeEroaareNormalizata(int[,] matrix)
        {
            int[,] matrix2 = new int[256, 256];
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    if (matrix[i, j] > 256) { matrix2[i, j] = 256; }
                    else if (matrix[i, j] < 0) { matrix2[i, j] = 0; }
                    else matrix2[i, j] = matrix[i, j];

                }
            }
            MatriceNormalizata = matrix2;
        }
        private byte[] CalculeazaMatricePeBiti(int[,] matrix)
        {
            string buffer = "";
            byte[] matrixB= new byte[73728];
            List<int> lista = new List<int>();
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    int val = matrix[i, j];
                    if (val < 0)
                    {
                        buffer += "1";
                        val *= -1;
                    }
                    else { buffer += "0"; }
                    buffer += Convert.ToString(val, 2).PadLeft(8, '0');
                    while (buffer.Length >= 8)
                    {
                        lista.Add(Convert.ToInt32(buffer.Substring(0, 8),2));
                        buffer = buffer.Substring(8);
                    }
                }
            }
           
            for(int i=0;i< 73728; i++)
            {
                matrixB[i] = Convert.ToByte(lista[i]);
            }
            Console.WriteLine(lista.Count);
            return matrixB;
        }
        private int Max(int a, int b)
        {
            if (a >= b) { return a; } else { return b; };
        }
        private int Min(int a, int b)
        {
            if (a <= b) { return a; } else { return b; };
        }
        //------------------------------------DECODARE
        internal void ExtrageMetaData(byte[] fisier)
        {
            
            for(int i = 0; i < 1078; i++)
            {
                metaData[i] = fisier[i];
            }
        }
        internal void ExtrageMetoda(byte[] fisier)
        {
            metoda = fisier[1078];
        }
        internal void  ExtrageMatriceDeEroare(byte[] fisier)
        {
            string buffer = "";
            List<int> lista = new List<int>();
            for(int i = 1079; i < fisier.Length; i++)
            {
                buffer += Convert.ToString(fisier[i],2).PadLeft(8,'0');
                while (buffer.Length >= 9)
                {
                    if (buffer[0] == '0')
                    {
                        lista.Add(Convert.ToInt32(buffer.Substring(1, 8), 2));
                        buffer = buffer.Substring(9);
                    }
                    else if (buffer[0] == '1')
                    {
                        lista.Add(-1*(Convert.ToInt32(buffer.Substring(1, 8), 2)));
                        buffer = buffer.Substring(9);
                    }
                }
            }

            for(int i = 0; i < lista.Count; i++)
            {
                matriceDeEroare[i / 256, i % 256] = lista[i];
            }
            CalculeazaMatriceaDeEroaareNormalizata(matriceDeEroare);
        }
        internal void Decodeaza()
        {
            MatriceDePredictie[0, 0] = 128;
            matriceOriginala[0, 0] = matriceDeEroare[0, 0] + matriceDePredictie[0, 0];
            if (metoda == 0)
            {
                for (int i = 1; i < 256; i++)
                {
                    MatriceDePredictie[0, i] = 128;
                    MatriceDePredictie[i, 0] = 128;
                    matriceOriginala[i, 0] = matriceDeEroare[i, 0] + matriceDePredictie[i, 0];
                    matriceOriginala[0, i] = matriceDeEroare[0, i] + matriceDePredictie[0, i];
                }
            }
            else
            {
                for (int i = 1; i < 256; i++)
                {
                    MatriceDePredictie[0, i] = matriceOriginala[0, i - 1];
                    MatriceDePredictie[i, 0] = matriceOriginala[i - 1, 0];
                    matriceOriginala[i, 0] = matriceDeEroare[i, 0] + matriceDePredictie[i, 0];
                    matriceOriginala[0, i] = matriceDeEroare[0, i] + matriceDePredictie[0, i];
                }
            }
            for (int i = 1; i < 256; i++)
            {
                for (int j = 1; j < 256; j++)
                {
                    int A = MatriceOriginala[i, j - 1];
                    int B = MatriceOriginala[i - 1, j];
                    int C = MatriceOriginala[i - 1, j - 1];
                    int valoarePixel = 0;

                    switch (metoda)
                    {
                        case 0:
                            valoarePixel = 128; //128
                            break;
                        case 1:
                            valoarePixel = A;
                            break;
                        case 2:
                            valoarePixel = B;
                            break;
                        case 3:
                            valoarePixel = C;
                            break;
                        case 4:
                            valoarePixel = A + B - C;
                            break;
                        case 5:
                            valoarePixel = A + (B - C) / 2;
                            break;
                        case 6:
                            valoarePixel = B + (A - C) / 2;
                            break;
                        case 7:
                            valoarePixel = (A + B) / 2;
                            break;
                        case 8:
                            if (C >= Min(A, B))
                            {
                                valoarePixel = Max(A, B);
                            }
                            else if (C <= Max(A, B))
                            {
                                valoarePixel = Min(A, B);
                            }
                            else
                            {
                                valoarePixel = A + B - C;
                            }
                            break;

                    }
                    if (valoarePixel > 255) valoarePixel = 255;
                    if (valoarePixel < 0) valoarePixel = 0;

                    matriceDePredictie[i, j] = valoarePixel; 
                   
                    matriceOriginala[i, j] = matriceDeEroare[i, j] + matriceDePredictie[i, j];
                }
            }
        }

    }
}
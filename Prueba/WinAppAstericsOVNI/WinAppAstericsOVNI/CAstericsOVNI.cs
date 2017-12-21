using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAstericsOVNI
{
    class CAstericsOVNI
    {
        private String mBlancs, mAsterics, mTotal;
        private float mFilas;
        public CAstericsOVNI()
        {
            mBlancs = ""; mAsterics = ""; mTotal = "";
        }
        public void ReadData(TextBox txtNum)
        {
            mFilas = float.Parse(txtNum.Text);

        }
        public void writeOVNI(ListBox listAsterics)
        {
            int j, i, k;
            int auxiliar=(int)mFilas-1;
            int contBlancs=0, resta=0,a;
            do{
                contBlancs += (int)Math.Pow(2, auxiliar) - (int)Math.Pow(2, auxiliar-1);
                auxiliar--;
            } while (auxiliar>0);
            mBlancs = ""; mAsterics = ""; mTotal = "";
            listAsterics.Items.Clear();
            //parte superior
            for (j = 1; j <= mFilas; j++)
            {
                mBlancs = ""; mAsterics = ""; mTotal = "";
                for (i = 0; i < contBlancs; i++)
                {
                    mBlancs  = mBlancs +" ";
                }
                contBlancs = contBlancs - (int)Math.Pow(2, resta);
                resta++;
                for (k = 0; k < (int)Math.Pow(2,j); k++)
                {
                    mAsterics += "*";
                }
                a = (int)Math.Pow(2, j);
                mTotal = mBlancs + mAsterics;
                listAsterics.Items.Add(mTotal);
            }
            //parte inferior
            
            auxiliar = (int)mFilas - 1;
            contBlancs = 0;
            contBlancs += (int)Math.Pow(2, auxiliar) - (int)Math.Pow(2, auxiliar - 1);
            resta = 1;
            for (j = (int)mFilas-1 ; j > 0; j--)
            {
                mBlancs = ""; mAsterics = ""; mTotal = "";
                for (i = 0; i < contBlancs; i++)
                {
                    mBlancs = mBlancs + " ";
                }
                
                for (k = 0; k < (int)Math.Pow(2, j); k++)
                {
                    mAsterics += "*";
                }
                
                contBlancs = contBlancs + (int)Math.Pow(2, resta);
                resta--;
                mTotal = mBlancs + mAsterics;
                listAsterics.Items.Add(mTotal);
            }
        }
    }
}

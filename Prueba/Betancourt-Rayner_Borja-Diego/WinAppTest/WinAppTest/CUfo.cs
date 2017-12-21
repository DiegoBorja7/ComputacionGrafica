using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppTest
{
    class CUfo
    {
        private int mNum, mRow;
        private String mBlanks, mAsterics, mTotalString;

        public CUfo()
        {
            mBlanks = ""; mAsterics = ""; mTotalString = "";
        }

        public void InitializeData(TextBox txtNum, ListBox lstFigure)
        {
            mNum = 0;
            mRow = 0;
            txtNum.Clear();
            txtNum.Focus();
            lstFigure.Items.Clear();
        }

        public void ReadData(TextBox txtNum)
        {
            try
            {
                mNum = int.Parse(txtNum.Text);
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GraphAstericsUfo(ListBox lstFigure)
        {
            if (mNum >= 2 && mNum <= 6)
            {
                lstFigure.Items.Clear();
                int i, k;
                int auxiliar = (int)mNum - 1;
                int contBlanks = 0, resta = 0, a;
                do
                {
                    contBlanks += (int)Math.Pow(2, auxiliar) - (int)Math.Pow(2, auxiliar - 1);
                    auxiliar--;
                } while (auxiliar > 0);
                mBlanks = ""; mAsterics = ""; mTotalString = "";
                lstFigure.Items.Clear();

                for (mRow = 1; mRow <= mNum; mRow++)
                {
                    mBlanks = ""; mAsterics = ""; mTotalString = "";
                    for (i = 0; i < contBlanks; i++)
                    {
                        mBlanks += " ";
                    }
                    contBlanks = contBlanks - (int)Math.Pow(2, resta);
                    resta++;
                    for (k = 0; k < (int)Math.Pow(2, mRow); k++)
                    {
                        mAsterics += "*";
                    }
                    a = (int)Math.Pow(2, mRow);
                    mTotalString = mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
                auxiliar = (int)mNum - 1;
                contBlanks = 0;
                contBlanks += (int)Math.Pow(2, auxiliar) - (int)Math.Pow(2, auxiliar - 1);
                resta = 1;
                for (mRow = (int)mNum - 1; mRow > 0; mRow--)
                {
                    mBlanks = ""; mAsterics = ""; mTotalString = "";
                    for (i = 0; i < contBlanks; i++)
                    {
                        mBlanks+= " ";
                    }

                    for (k = 0; k < (int)Math.Pow(2, mRow); k++)
                    {
                        mAsterics += "*";
                    }

                    contBlanks = contBlanks + (int)Math.Pow(2, resta);
                    resta--;
                    mTotalString = mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
            }
            else
            {
                MessageBox.Show("Ingrese numero entre 2 y 6!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

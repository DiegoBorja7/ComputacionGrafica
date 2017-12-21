using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WinAppTest
{
    class CFibonacci
    {
        private long mF1;
        private long mF2;
        private long mF3;
        private long mNum, mNT, mSum;
        public CFibonacci()
        {
            mNum = 0; mNT = 0; mF1 = 1; mF2 = 1; mF3 = 0; mSum = 0;
        }
        public void InitializeData(TextBox txtNum, TextBox txtNT, TextBox txtSum)
        {
            mNum = 0; mNT = 0; mF1 = 1; mF2 = 1; mF3 = 0; mSum = 0;
            txtNum.Text = ""; txtSum.Text = ""; txtNT.Text = "";
        }

        public void ReadData(TextBox txtNum)
        {
            try
            {
                mNum = long.Parse(txtNum.Text);
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de los datos!", "Error en el ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (mNum < 1)
            {
                MessageBox.Show("Ingrese un entero mayor a 0!", "Error en el ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mSum = 0;
                mNT = 0;
            }
        }

        public void PrintData(TextBox txtNT, TextBox txtSum)
        {
            txtNT.Text = mNT.ToString();
            txtSum.Text = mSum.ToString();
        }

        public void Fibonacci()
        {
            long i, acum = 0; mSum = 0; mF1 = 1; mF2 = 1; mF3 = 0;
            switch (mNum)
            {
                case 1:
                    mNT = mF1;
                    mSum = mF1;
                break;
                case 2:
                    mNT = mF2;
                    mSum = mF1 + mF2;
                break;
                default:
                    for (i = 3; i <= mNum; i++)
                    {
                        acum += (mF1 );
                        mF3 = mF1 + mF2;
                        mF1 = mF2;
                        mF2 = mF3;
                    }
                    acum += (mF1+mF3);
                    mNT = mF3;
                    mSum = acum;
                break;
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace WinAppSeries
{
    class CSerie
    {
        //Datos Miembro - atributos de la clase
        private float mNum;     //Numero de terminos de la serie
        private float mX;       //Variable independiente
        private float mResult;  //Variable para el resultado

        //Funciones miembro - Metodos de la clase
        public CSerie ()
        {
           mNum=0.0f; mX=0.0f;
        }
        public void InitializeData(TextBox txtNum,
                                   TextBox txtResult)
        {
            mNum = 0.0f; mX = 0.0f; mResult= 0.0f;
            txtNum.Clear();
            txtResult.Clear();
            txtNum.Focus();
        }
        public void InitializeData(TextBox txtNum,
                                   TextBox txtX,
                                   TextBox txtResult)
        {
            mNum = 0.0f; mX = 0.0f; mResult = 0.0f;
            txtNum.Clear();
            txtX.Clear();
            txtResult.Clear();
            txtNum.Focus();
        }
        public void ReadData(TextBox txtNum)
        {
            mNum = float.Parse(txtNum.Text);
        }
        public void ReadData(TextBox txtNum, TextBox txtX)
        {
            mNum = long.Parse(txtNum.Text);
            mX = long.Parse(txtX.Text);
        }

        public void PrintData(TextBox txtResult)
        {
            txtResult.Text = String.Format("{0:0.00}", mResult);
        }
        public void Sum1()
        {
            long i; float sum = 0.0f;
            for (i = 1; i <= mNum; i++)
            {
                sum = sum + i;
            }
            mResult = sum;
        }
        public void Factorial()
        {
            long i; float prod = 1.0f;
            for (i = 1; i <= mNum; i++)
            {
                prod = prod * i;
            }
            mResult = prod;
        }

        public float Factorial(long n)
        {
            long i; float prod = 1.0f;
            for (i = 1; i <= n; i++)
            {
                prod = prod * i;
            }
            return (prod);
        }

        public void SerieNumE()
        {
            long i; float sum = 0.0f;
            for (i = 0; i <= mNum - 1; i++)
            {
                sum = sum + (float)Math.Pow(mX, i) / Factorial(i);
            }
            mResult = sum;
        }

        public void SerieSin()
        {
            long i; float sum = 0.0f;

            mX = ConversionGradesToRadians();

            for (i = 1; i <= mNum; i++)
            {
                sum = sum + ((float)Math.Pow(-1.0, i + 1) * (float)Math.Pow(mX, 2 * i - 1)) /
                      Factorial(2 * i - 1);
            }
            mResult = sum;
        }

        private float ConversionGradesToRadians()
        {
            return (mX * (float)Math.PI / 180);
        }

    }
}

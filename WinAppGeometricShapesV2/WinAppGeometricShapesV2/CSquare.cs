using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricShapesV2
{
    class CSquare
    {
        //Datos Miembro - atributos de la clase
        private float mSide;
        private float mPerimeter, mArea;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        //Constructor por defecto o sin parametros
        public CSquare()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funciones miembro - Metodos de la clase
        public void InitializeData(TextBox txtSide,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtSide.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSide.Focus();
            picCanvas.Refresh();
        }
        public Boolean ReadData(TextBox txtSide)
        {
            Boolean flag;
            try
            {
                mSide = float.Parse(txtSide.Text);
                if (mSide <= 0)
                {
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSide.Clear();
                    txtSide.Focus();
                    flag = false;
                }
                else
                    flag = true;
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSide.Clear();
                txtSide.Focus();
                flag = false;
            }

            return flag;
        }
        public void CalculateArea()
        {
            mArea = mSide * mSide;
        }
        public void CalculatePerimeter()
        {
            mPerimeter = mSide * 4;
        }
        public void PrintData(TextBox txtPerimeter,
                              TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void DrawShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 4);

            mGraph.DrawRectangle(mPen, 7, 7, mSide * SF, mSide * SF);
        }
    }
}

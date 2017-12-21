using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class CEquilateralTriangle
    {
        // Datos miembro - Atributos.
        private float mSide;
        private float mPerimeter, mArea;
        private float mAngle;
        private float mHigh;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mPA, mPB, mPC;

        public CEquilateralTriangle()
        {
            mSide = 0.0f; mAngle = 0.0f; mHigh = 0.0f;
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

        // Función que permite leer el lado del heptágono.
        public Boolean ReadData(TextBox txtSide,
                                TextBox txtPerimeter,
                                TextBox txtArea,
                                PictureBox picCanvas)
        {
            Boolean flag;
            try
            {
                mSide = float.Parse(txtSide.Text);
                flag = true;
                if (mSide < 0)
                {
                    InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }
            catch
            {
                InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }
        // Función que permite calcular el perímetro y area del Triangulo.
        public void PerimeterTriangle()
        {
            mPerimeter = 3 * mSide;
        }
        public float ConvertGradesToRadians(float a)
        {
            return (a * (float)Math.PI / 180);
        }
        public void AreaTriangle()
        {
            mAngle = ConvertGradesToRadians(60f);
            mHigh = mSide * (float)Math.Sin(mAngle);
            mArea = mSide * mHigh / 2;
        }

        // Función que permite imprimir el perímetro y el área del Triangulo.
        public void PrintData(TextBox txtSideA,
                              TextBox txtPerimeter,
                              TextBox txtArea)
        {
            txtSideA.Text = String.Format("{0:0.00}", mSide);
            txtPerimeter.Text = String.Format("{0:0.00}", mPerimeter);
            txtArea.Text = String.Format("{0:0.00}", mArea);
        }
        // Función que permite dibujar el Triangulo.
        private void CalculateVertex()
        {
            mPA.X = (mSide/2) * SF; mPA.Y = 0.0f * SF;
            mPB.X = mSide* SF; mPB.Y = mHigh * SF;
            mPC.X = 0.0f * SF; mPC.Y = mHigh * SF;
        }

        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 3);
            picCanvas.Refresh();

            CalculateVertex();
            mGraph.DrawLine(mPen, mPA, mPB);
            mGraph.DrawLine(mPen, mPB, mPC);
            mGraph.DrawLine(mPen, mPA, mPC);
        }
    }
}

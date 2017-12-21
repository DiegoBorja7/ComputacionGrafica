using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class CSquare
    {
        // Datos miembro - Atributos.
        private float mSide;
        private float mPerimeter, mArea;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mPA, mPB, mPC,mPD;

        public CSquare()
        {
            mSide=0.0f; mPerimeter = 0.0f; mArea=0.0f;
        }

        //Funciones miembro - Metodos de la clase
        public void InitializeData(TextBox txtSide,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
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
        // Función que permite calcular el perímetro y area del Cuadrado.
        public void PerimeterTriangle()
        {
            mPerimeter = 4 * mSide;
        }
        public void AreaTriangle()
        {
            mArea = (float)Math.Pow(mSide, 2);
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
            mPA.X = 0.0f * SF; mPA.Y = 0.0f * SF;
            mPB.X = mSide * SF; mPB.Y = 0.0f * SF;
            mPC.X = mSide * SF; mPC.Y = mSide * SF;
            mPD.X = 0.0f * SF; mPD.Y = mSide * SF;
        }

        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 3);
            picCanvas.Refresh();

            CalculateVertex();
            mGraph.DrawLine(mPen, mPA, mPB);
            mGraph.DrawLine(mPen, mPB, mPC);
            mGraph.DrawLine(mPen, mPC, mPD);
            mGraph.DrawLine(mPen, mPD, mPA);
        }
    }
}

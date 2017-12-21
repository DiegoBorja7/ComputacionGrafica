using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class CPentagon
    {
        // Datos miembro - Atributos.
        private float mL;
        private float mPerimeter, mArea;
        private float mAngle;
        private float mApothem, mA, mB, mC, mD;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mP1, mP2, mP3, mP4, mP5;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public CPentagon()
        {
            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mA = 0.0f; mB = 0.0f; mC = 0.0f; mD = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        // Función que permite leer el lado del pentágono.
        public Boolean ReadData(TextBox txtSide,
                                TextBox txtPerimeter,
                                TextBox txtArea,
                                PictureBox picCanvas)
        {
            Boolean flag;
            try
            {
                mL = float.Parse(txtSide.Text);
                flag = true;
                if (mL < 0)
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
        // Función que permite calcular el perímetro del pentágono.
        public void PerimeterPentagon()
        {
            mPerimeter = 5 * mL;
        }
        public float ConvertGradesToRadians(float a)
        {
            return (a * (float)Math.PI / 180);
        }
        public void ApothemPentagon()
        {
            mAngle = 36.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mApothem = mL / 2 / (float)Math.Tan(mAngle);
        }
        // Función que permite calcular el área del pentágono.
        public void AreaPentagon()
        {
            mArea = mPerimeter * mApothem / 2.0f;
        }
        // Función que permite imprimir el perímetro y el área del pentágono.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = mPerimeter.ToString();
            txtPerimeter.Text = mArea.ToString();
        }
        // Función que permite inicializar los datos y controles que operan en 
        // la GUI del hexágono.
        public void InitializeData(TextBox txtSide,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            txtSide.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            // Mantiene el cursor titilando en una caja de texto.
            txtSide.Focus();

            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mA = 0.0f; mB = 0.0f; mC = 0.0f; mD = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            picCanvas.Refresh();
        }
        // Función que permite graficar un triángulo en base a los valores de los tres 
        // vértices representados por tres puntos en un plano.
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 3);

            mAngle = 54.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mB = mL * (float)Math.Sin(mAngle);

            mAngle = 36.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mA = mL * (float)Math.Sin(mAngle);

            mAngle = 72.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mD = mL * (float)Math.Sin(mAngle);

            mAngle = 18.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mC = mL * (float)Math.Sin(mAngle);

            mP1.X = mB; mP1.Y = 0;
            mP2.X = 2 * mB; mP2.Y = mA;
            mP3.X = mC + mL; mP3.Y = mA + mD;
            mP4.X = mC; mP4.Y = mA + mD;
            mP5.X = 0; mP5.Y = mA;


            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP3.X * SF, mP3.Y * SF, mP4.X * SF, mP4.Y * SF);
            mGraph.DrawLine(mPen, mP4.X * SF, mP4.Y * SF, mP5.X * SF, mP5.Y * SF);
            mGraph.DrawLine(mPen, mP5.X * SF, mP5.Y * SF, mP1.X * SF, mP1.Y * SF);
        }
    }
}

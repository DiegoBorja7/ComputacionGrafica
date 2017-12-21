using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class CHeptagon
    {
        // Datos miembro - Atributos.
        private float mL;
        private float mPerimeter, mArea;
        private float mAngle;
        private float mApothem, mA, mB, mC, mD, mE, mF;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mP1, mP2, mP3, mP4, mP5, mP6, mP7;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public CHeptagon()
        {
            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mA = 0.0f; mB = 0.0f; mC = 0.0f; mD = 0.0f;
            mE = 0.0f; mF = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
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
        // Función que permite calcular el perímetro del heptágono.
        public void PerimeterHeptagon()
        {
            mPerimeter = 7 * mL;
        }
        public float ConvertGradesToRadians(float a)
        {
            return (a * (float)Math.PI / 180);
        }
        public void ApothemHeptagon()
        {
            mAngle = 25.71f;
            mAngle = ConvertGradesToRadians(mAngle);
            mApothem = mL / 2 / (float)Math.Tan(mAngle);
        }
        // Función que permite calcular el área del heptágono.
        public void AreaHeptagon()
        {
            mArea = mPerimeter * mApothem / 2.0f;
        }
        // Función que permite imprimir el perímetro y el área del heptágono.
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
            mE = 0.0f; mF = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            picCanvas.Refresh();
        }
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 3);
            picCanvas.Refresh();

            mAngle = 12.86f;
            mAngle = ConvertGradesToRadians(mAngle);
            mA = mL * (float)Math.Sin(mAngle);

            mAngle = 25.71f;
            mAngle = ConvertGradesToRadians(mAngle);
            mB = mL * (float)Math.Sin(mAngle);

            mAngle = 25.71f;
            mAngle = ConvertGradesToRadians(mAngle);
            mC = mL * (float)Math.Cos(mAngle);

            mAngle = 12.86f;
            mAngle = ConvertGradesToRadians(mAngle);
            mD = mL * (float)Math.Cos(mAngle);

            mAngle = 51.43f;
            mAngle = ConvertGradesToRadians(mAngle);
            mE = mL * (float)Math.Sin(mAngle);

            mAngle = 51.43f;
            mAngle = ConvertGradesToRadians(mAngle);
            mF = mL * (float)Math.Cos(mAngle);

            mP1.X = mA + mC; mP1.Y = 0; mP2.X = mA + 2 * mC; mP2.Y = mB;
            mP3.X = 2 * mF + mL; mP3.Y = mB + mD; mP4.X = mF + mL; mP4.Y = mB + mD + mE;
            mP5.X = mF; mP5.Y = mB + mD + mE; mP6.X = 0; mP6.Y = mB + mD; mP7.X = mA; mP7.Y = mB;

            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP3.X * SF, mP3.Y * SF, mP4.X * SF, mP4.Y * SF);
            mGraph.DrawLine(mPen, mP4.X * SF, mP4.Y * SF, mP5.X * SF, mP5.Y * SF);
            mGraph.DrawLine(mPen, mP5.X * SF, mP5.Y * SF, mP6.X * SF, mP6.Y * SF);
            mGraph.DrawLine(mPen, mP6.X * SF, mP6.Y * SF, mP7.X * SF, mP7.Y * SF);
            mGraph.DrawLine(mPen, mP7.X * SF, mP7.Y * SF, mP1.X * SF, mP1.Y * SF);
        }
    }
}

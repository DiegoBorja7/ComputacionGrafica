using System;
using System.Drawing;
using System.Windows.Forms;


namespace WinAppRegularPolygons
{
    class CDodecagon
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
        private PointF mP1, mP2, mP3, mP4, mP5, mP6, mP7, mP8, mP9, mP10, mP11, mP12;
        public CDodecagon()
        {
            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mA = 0.0f; mB = 0.0f;

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
        public void PerimeterDodecagon()
        {
            mPerimeter = 12 * mL;
        }
        public float ConvertGradesToRadians(float a)
        {
            return (a * (float)Math.PI / 180);
        }
        public void ApothemDodecagon()
        {
            mAngle = 72.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mApothem = mL / 2 / (float)Math.Tan(mAngle);
        }
        // Función que permite calcular el área del heptágono.
        public void AreaDodecagon()
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
            txtSide.Focus();

            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mA = 0.0f; mB = 0.0f; mC = 0.0f; mD = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            picCanvas.Refresh();
        }
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 3);
            picCanvas.Refresh();

            mAngle = 30f;
            mAngle = ConvertGradesToRadians(mAngle);
            mA = mL * (float)Math.Cos(mAngle);

            mAngle = 60f;
            mAngle = ConvertGradesToRadians(mAngle);
            mB = mL * (float)Math.Cos(mAngle);

            mAngle = 30f;
            mAngle = ConvertGradesToRadians(mAngle);
            mC = mL * (float)Math.Sin(mAngle);

            mAngle = 60f;
            mAngle = ConvertGradesToRadians(mAngle);
            mD = mL * (float)Math.Sin(mAngle);

            mP1.X = 0; mP1.Y = mC + mD; mP2.X = mB; mP2.Y = mC;
            mP3.X = mA + mB; mP3.Y = 0; mP4.X = mA + mB + mL; mP4.Y = 0;
            mP5.X = 2 * mA + mB + mL; mP5.Y = mC; mP6.X = 2 * mA + 2 * mB + mL; mP6.Y = mC + mD;
            mP7.X = 2 * mA + 2 * mB + mL; mP7.Y = mC + mD + mL; mP8.X = 2 * mA + mB + mL; mP8.Y = mC + 2 * mD + mL;
            mP9.X = mA + mB + mL; mP9.Y = 2 * mC + 2 * mD + mL; mP10.X = mA + mB; mP10.Y = 2 * mC + 2 * mD + mL;
            mP11.X = mB; mP11.Y = mC + 2 * mD + mL;
            mP12.X = 0; mP12.Y = mL + mC + mD;

            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP3.X * SF, mP3.Y * SF, mP4.X * SF, mP4.Y * SF);
            mGraph.DrawLine(mPen, mP4.X * SF, mP4.Y * SF, mP5.X * SF, mP5.Y * SF);
            mGraph.DrawLine(mPen, mP5.X * SF, mP5.Y * SF, mP6.X * SF, mP6.Y * SF);
            mGraph.DrawLine(mPen, mP6.X * SF, mP6.Y * SF, mP7.X * SF, mP7.Y * SF);
            mGraph.DrawLine(mPen, mP7.X * SF, mP7.Y * SF, mP8.X * SF, mP8.Y * SF);
            mGraph.DrawLine(mPen, mP8.X * SF, mP8.Y * SF, mP9.X * SF, mP9.Y * SF);
            mGraph.DrawLine(mPen, mP9.X * SF, mP9.Y * SF, mP10.X * SF, mP10.Y * SF);
            mGraph.DrawLine(mPen, mP10.X * SF, mP10.Y * SF, mP11.X * SF, mP11.Y * SF);
            mGraph.DrawLine(mPen, mP11.X * SF, mP11.Y * SF, mP12.X * SF, mP12.Y * SF);
            mGraph.DrawLine(mPen, mP12.X * SF, mP12.Y * SF, mP1.X * SF, mP1.Y * SF);
        }
    }
}

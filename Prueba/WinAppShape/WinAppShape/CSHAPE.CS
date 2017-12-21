using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppShape
{
    class CShape
    {
        // Datos miembro - Atributos.
        private float mL;
        private float mPerimeter, mArea;
        private float mAngle;
        private float mApothem, mB;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private Pen mPen1;
        private Pen mPen2;
        private float SF = 20;
        private PointF mP1, mP2, mP3, mP4, mP5, mP6;
        private PointF mA, mb, mC, mD, mE, mF;

       // Constructor por defecto.
        public CShape()
        {
            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mB = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        public void InitializeData(TextBox txtSide,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mB = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtSide.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSide.Focus();
            picCanvas.Refresh();
        }

        // Función que permite leer el lado del hexágono.
        public Boolean ReadData(TextBox txtSide)
        {
            Boolean Flag;
            try
            {
                mL = float.Parse(txtSide.Text);
                if (mL <= 0)
                {
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSide.Clear();
                    txtSide.Focus();
                    Flag = false;
                }
                else
                    Flag = true;
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSide.Clear();
                txtSide.Focus();
                Flag = false;
            }

            return Flag;
        }

        // Función que permite calcular el perímetro del hexágono.
        public void PerimeterHexagon()
        {
            mPerimeter = 6 * mL;
        }

        public float ConvertGradesToRadians(float a)
        {
            return (a * (float)Math.PI / 180);
        }
        public void ApothemHexagon()
        {
            mAngle = 30.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mApothem = mL * (float)Math.Cos(mAngle);
        }
        // Función que permite calcular el área del hexágono.
        public void AreaHexagon()
        {
            mArea = mPerimeter * mApothem / 2.0f;
        }
        // Función que permite imprimir el perímetro y el área del hexágono.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = String.Format("{0:##.00}", mPerimeter);
            txtArea.Text = String.Format("{0:##.00}", mArea);
        }
        // Función que permite graficar un triángulo en base a los valores de los tres 
        // vértices representados por tres puntos en un plano.
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            mAngle = 60.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mB = mL * (float)Math.Cos(mAngle);

            mA.X = mB * SF; mA.Y = 0;
            mb.X = ((mB + mL) * SF); mb.Y = 0;
            mC.X = ((2 * mB) + mL) * SF; mC.Y = mApothem * SF;
            mD.X = (mB + mL) * SF; mD.Y = 2 * mApothem * SF;
            mE.X = mB * SF; mE.Y = 2 * mApothem * SF;
            mF.X = 0.0f * SF; mF.Y = mApothem * SF;


            mGraph.DrawLine(mPen, mA, mC);
            mGraph.DrawLine(mPen, mC, mE);
            mGraph.DrawLine(mPen, mE, mA);

            mGraph.DrawLine(mPen, mF, mb);
            mGraph.DrawLine(mPen, mb, mD);
            mGraph.DrawLine(mPen, mD, mF);

            //
            mA.X = (mB + (mL / 4)) * SF; mA.Y = (mApothem / 2) * SF;
            mE.X = (mB + (mL / 4)) * SF; mE.Y = ((2 * mApothem) - (mApothem / 2)) * SF;
            mC.X = ((mB + mL)) * SF; mC.Y = (mApothem) * SF;

            mb.X = ((mB + ((mL * 3) / 4)) * SF); mb.Y = (mApothem / 2) * SF;
            mD.X = ((mB + ((mL * 3) / 4)) * SF); mD.Y = ((2 * mApothem) - (mApothem / 2)) * SF;
            mF.X = mB * SF; mF.Y = (mApothem) * SF;

            mPen1 = new Pen(Color.BlueViolet, 3);
            // picCanvas.Refresh();

            mGraph.DrawLine(mPen1, mF, mb);
            mGraph.DrawLine(mPen1, mb, mD);
            mGraph.DrawLine(mPen1, mD, mF);


            mGraph.DrawLine(mPen1, mA, mC);
            mGraph.DrawLine(mPen1, mC, mE);
            mGraph.DrawLine(mPen1, mE, mA);
            
            mPen2=new Pen(Color.Aquamarine,3);
            //SF = 10;

            mA.X = (mB + (mL / 4) + (mL / 8)) * SF; mA.Y = ((mApothem / 4)*3) * SF;
            mE.X = (mB + (mL / 4) + (mL / 8)) * SF; mE.Y = (mApothem + (mApothem / 4)) * SF;
            mC.X = (mB + (mL / 4) + (mL / 8) + (mL / 8) + (mL / 8) + (mL / 8)) * SF; mC.Y = (mApothem) * SF;

            mb.X = (mB + (mL / 4) + (mL / 8) + (mL / 8) + (mL / 8)) * SF; mb.Y = ((mApothem / 4) * 3) * SF;
            mD.X = (mB + (mL / 4) + (mL / 8) + (mL / 8) + (mL / 8)) * SF; mD.Y = (mApothem+(mApothem / 4)) * SF;
            mF.X = (mB + (mL / 4)) * SF; mF.Y = (mApothem) * SF;

            mGraph.DrawLine(mPen2, mF, mb);
            mGraph.DrawLine(mPen2, mb, mD);
            mGraph.DrawLine(mPen2, mD, mF);
            mGraph.DrawLine(mPen2, mA, mC);
            mGraph.DrawLine(mPen2, mC, mE);
            mGraph.DrawLine(mPen2, mE, mA);
           


        }
    }
}

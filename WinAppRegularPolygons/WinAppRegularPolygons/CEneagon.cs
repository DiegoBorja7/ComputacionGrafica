using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class CEneagon
    {
        //Datos Miembro - atributos de la clase
        private float mSide;
        private float mPerimeter, mArea;
        private float mApothem, mAngle;
        private float mX, mX1, mY, mY1, mX2, mX3, mY2, mY3;
        private float mA1, mA2, mA3, mA4; // datos miembro de los angulos

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;
        private PointF mPA, mPB, mPC, mPD, mPE, mPF, mPG, mPH, mPI;

        //Constructor por defecto o sin parametros
        public CEneagon()
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f; mApothem = 0.0f; mAngle = 0.0f;
        }
        //Funciones miembro - Metodos de la clase
        public void InitializeData(TextBox txtSide,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            mAngle = 0.0f; mApothem = 0.0f;
            txtSide.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSide.Focus();
            picCanvas.Refresh();
        }
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
        public void PerimeterEneagon()
        {
            mPerimeter = 9.0f * mSide;
        }
        public float GradesToRadians(float a)
        {
            return a * (float)Math.PI / 180;
        }
        public void AreaEneagono()
        {
            mAngle = 40.0f;
            mAngle = GradesToRadians(mAngle);
            mApothem = mSide / (2 * (float)Math.Tan(mAngle / 2.0f));
            mArea = mPerimeter * mApothem / 2;
        }
        
        
        public void PrintData(TextBox txtSide,TextBox txtPerimeter, TextBox txtArea)
        {
            txtSide.Text = String.Format("{0:0.00}", mSide);
            txtPerimeter.Text = String.Format("{0:0.00}", mPerimeter);
            txtArea.Text = String.Format("{0:0.00}", mArea);
        }

        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 3);
            mA1 = GradesToRadians(20.0f);
            mA2 = GradesToRadians(60.0f);
            mA3 = GradesToRadians(40.0f);
            mA4 = GradesToRadians(10.0f);

            mY = mSide * (float)Math.Sin(mA3);
            mX = mSide * (float)Math.Cos(mA3);

            mX1 = mSide * (float)Math.Sin(mA4);
            mY1 = mSide * (float)Math.Cos(mA4);

            mY2 = mSide * (float)Math.Sin(mA2);
            mX2 = mSide * (float)Math.Cos(mA2);

            mY3 = mSide * (float)Math.Sin(mA1);
            mX3 = mSide * (float)Math.Cos(mA1);

            mPA.X = (mX1 + mX) * SF;                    mPA.Y = 0.0f * SF;
            mPB.X = (mX1 + mX + mSide) * SF;            mPB.Y = 0.0f * SF;
            mPC.X = (2 * mX + mX1 + mSide) *SF;         mPC.Y = mY * SF;
            mPD.X = (2 * mX1 + 2 * mX + mSide) * SF;    mPD.Y = (mY + mY1) * SF;
            mPE.X = (2 * mX3 + mX2) * SF;               mPE.Y = (mY + mY1 + mY2) * SF;
            mPF.X = (mX2 + mX3)*SF;                     mPF.Y = (mY1 + mY + mY2 + mY3) * SF;
            mPG.X = mX2 * SF;                           mPG.Y = (mY + mY1 + mY2) * SF;
            mPH.X = 0.0f * SF;                          mPH.Y = (mY + mY1) * SF;
            mPI.X = mX1 * SF;                           mPI.Y = mY * SF;

            mGraph.DrawLine(mPen, mPA, mPB);
            mGraph.DrawLine(mPen, mPB, mPC);
            mGraph.DrawLine(mPen, mPC, mPD);
            mGraph.DrawLine(mPen, mPD, mPE);
            mGraph.DrawLine(mPen, mPE, mPF);
            mGraph.DrawLine(mPen, mPF, mPG);
            mGraph.DrawLine(mPen, mPG, mPH);
            mGraph.DrawLine(mPen, mPH, mPI);
            mGraph.DrawLine(mPen, mPI, mPA);
        }

    }
}

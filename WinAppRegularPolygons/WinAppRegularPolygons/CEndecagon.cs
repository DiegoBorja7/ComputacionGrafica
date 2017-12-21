using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class CEndecagon
    {
        //Datos Miembro - atributos de la clase
        private float mSide, mArea, mPerimeter, mApothem, mAngle;
        private float mX, mX1, mX2, mX3, mX4, mY, mY1, mY2, mY3, mY4;
        private float mA1, mA2, mA3, mA4, mA5; // datos miembro de los angulos

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mPA, mPB, mPC, mPD, mPE, mPF, mPG, mPH, mPI, mPJ, mPK;
        
        //Constructor por defecto o sin parametros
        public CEndecagon()
        {
            mSide = 0.0f; mArea = 0.0f; mPerimeter = 0.0f; mApothem = 0.0f; mAngle = 0.0f;
        }
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
        public float GradesToRadians(float a)
        {
            return a * (float)Math.PI / 180;
        }
        public void PerimeterEndecagon()
        {
            mPerimeter = mSide * 11;
        }
        public void AreaEndecagono()
        {
            mAngle = 32.72f;
            mAngle = GradesToRadians(mAngle);
            mApothem = mSide / (2 * (float)Math.Tan(mAngle / 2.0f));
            mArea = mPerimeter * mApothem / 2;

        }
        public void PrintData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea)
        {
            txtSide.Text = String.Format("{0:0.00}", mSide);
            txtPerimeter.Text = String.Format("{0:0.00}", mPerimeter);
            txtArea.Text = String.Format("{0:0.00}", mArea);
        }
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 3);

            mA1 = 8.4f;
            mA1 = GradesToRadians(mA1);
            mA2 = 41.2f;
            mA2 = GradesToRadians(mA2);
            mA3 = 74.0f;
            mA3 = GradesToRadians(mA3);
            mA4 = 65.6f;
            mA4 = GradesToRadians(mA4);
            mA5 = 32.8f;
            mA5 = GradesToRadians(mA5);

            mX = mSide * (float)Math.Sin(mA1);
            mX1 = mSide * (float)Math.Sin(mA2);
            mX2 = mSide * (float)Math.Sin(mA3);
            mX3 = mSide * (float)Math.Cos(mA4);
            mX4 = mSide * (float)Math.Cos(mA5);

            mY = mSide * (float)Math.Cos(mA3);
            mY1 = mSide * (float)Math.Cos(mA2);
            mY2 = mSide * (float)Math.Cos(mA1);
            mY3 = mSide * (float)Math.Sin(mA4);
            mY4 = mSide * (float)Math.Sin(mA5);

            mPA.X = (mX + mX1 + mX2);      mPA.Y = 0.0f;
            mPB.X = (mPA.X + mX2);         mPB.Y = mY;
            mPC.X = (mPB.X + mX1);         mPC.Y = (mY + mY1);
            mPD.X = (mPC.X + mX);          mPD.Y = (mPC.Y + mY2);
            mPE.X = (mPD.X - mX3);         mPE.Y = (mPD.Y + mY3) ;
            mPF.X = (mPE.X - mX4);         mPF.Y = (mPE.Y + mY4) ;
            mPG.X = (mPF.X - mSide);       mPG.Y = mPF.Y ;
            mPH.X = mX3;                   mPH.Y = mPE.Y ;
            mPI.X = 0.0f;                  mPI.Y = mPD.Y ;
            mPJ.X = mX;                    mPJ.Y = mPC.Y;
            mPK.X = mX + mX1;              mPK.Y = mPB.Y;

            mPA.X *= SF;       mPA.Y *= SF;
            mPB.X *= SF;       mPB.Y *= SF;
            mPC.X *= SF;       mPC.Y *= SF;
            mPD.X *= SF;       mPD.Y *= SF;
            mPE.X *= SF;       mPE.Y *= SF;
            mPF.X *= SF;       mPF.Y *= SF;
            mPG.X *= SF;       mPG.Y *= SF;
            mPH.X *= SF;       mPH.Y *= SF;
            mPI.X *= SF;       mPI.Y *= SF;
            mPJ.X *= SF;       mPJ.Y *= SF;
            mPK.X *= SF;       mPK.Y *= SF;
            

            mGraph.DrawLine(mPen, mPA, mPB);
            mGraph.DrawLine(mPen, mPB, mPC);
            mGraph.DrawLine(mPen, mPC, mPD);
            mGraph.DrawLine(mPen, mPD, mPE);
            mGraph.DrawLine(mPen, mPE, mPF);
            mGraph.DrawLine(mPen, mPF, mPG);
            mGraph.DrawLine(mPen, mPG, mPH);
            mGraph.DrawLine(mPen, mPH, mPI);
            mGraph.DrawLine(mPen, mPI, mPJ);
            mGraph.DrawLine(mPen, mPJ, mPK);
            mGraph.DrawLine(mPen, mPK, mPA);
        }
    }
}

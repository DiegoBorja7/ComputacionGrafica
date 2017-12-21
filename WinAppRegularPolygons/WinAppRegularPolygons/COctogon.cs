using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class COctogon
    {
        //Datos Miembro - atributos de la clase
        private float mSideA;
        private float mPerimeter, mArea;
        private float mApothem,mSegmentB, mAngle1,mAngle2;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;
        private PointF mPA, mPB, mPC,mPD, mPE, mPF,mPG,mPH;

        //Constructor por defecto o sin parametros
        public COctogon()
        {
            mSideA = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Funciones miembro - Metodos de la clase
        public void InitializeData(TextBox txtSideA,
                                   TextBox txtPerimeter,
                                   TextBox txtArea)
        {
            mSideA = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtSideA.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSideA.Focus();
        }
        public void InitializeData(TextBox txtSideA,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mSideA = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtSideA.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSideA.Focus();
            picCanvas.Refresh();
        }
        public Boolean ReadData(TextBox txtSideA, 
                                TextBox txtPerimeter,
                                TextBox txtArea,
                                PictureBox picCanvas)
        {
            Boolean flag;
            try
            {
                mSideA = float.Parse(txtSideA.Text);
                flag = true;
                if (mSideA < 0)
                {
                    InitializeData(txtSideA, txtPerimeter, txtArea, picCanvas);
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
            }
            catch
            {
                InitializeData(txtSideA,txtPerimeter, txtArea, picCanvas);
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            return flag;
        }
        public void PerimeterOctogon()
        {
            mPerimeter = 8*mSideA;
        }
        public void AreaOctogon()
        {
            mAngle1=45.0f*(float)Math.PI/180.0f;
            mAngle2 = (mAngle1 / 2.0f) * (float)Math.PI / 180.0f;
            mApothem = mSideA / (2.0f * (float)Math.Tan(mAngle2));
            mArea = (mPerimeter*mApothem)/2.0f;
        }
        public void PrintData(TextBox txtSideA,
                              TextBox txtPerimeter,
                              TextBox txtArea)
        {
            txtSideA.Text = String.Format("{0:0.00}", mSideA);
            txtPerimeter.Text = String.Format("{0:0.00}", mPerimeter);
            txtArea.Text = String.Format("{0:0.00}", mArea);
        }
        private void CalculateVertex()
        {
            mSegmentB=mSideA*(float)Math.Cos(mAngle1);

            mPA.X=mSegmentB* SF; mPA.Y=0.0f* SF;
            mPB.X=(mSegmentB+mSideA)* SF; mPB.Y=0.0f* SF;
            mPC.X = (2.0f * mSegmentB + mSideA) * SF; mPC.Y = mSegmentB * SF;
            mPD.X = (2.0f * mSegmentB + mSideA) * SF; mPD.Y = (mSegmentB + mSideA) * SF;
            mPE.X=(mSegmentB + mSideA)* SF; mPE.Y=(2.0f * mSegmentB + mSideA)* SF;
            mPF.X = mSegmentB * SF; mPF.Y = (2.0f * mSegmentB + mSideA) * SF;
            mPG.X = 0.0f * SF; mPG.Y = (mSegmentB + mSideA) * SF;
            mPH.X = 0.0f * SF; mPH.Y = mSegmentB * SF;

        }
        public void DrawShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 4);

            CalculateVertex();
            //Dibujar las lineas con respectos a los puntos obtenidos mPA,mPB,mPC,mPD,mPE,mPF
            /*mGraph.DrawLine(mPen, mPA.X * SF, mPA.Y * SF, mPB.X * SF, mPB.Y * SF);
            mGraph.DrawLine(mPen, mPA.X * SF, mPA.Y * SF, mPC.X * SF, mPC.Y * SF);
            mGraph.DrawLine(mPen, mPB.X * SF, mPB.Y * SF, mPD.X * SF, mPD.Y * SF);
            mGraph.DrawLine(mPen, mPC.X * SF, mPC.Y * SF, mPE.X * SF, mPE.Y * SF);
            mGraph.DrawLine(mPen, mPD.X * SF, mPD.Y * SF, mPF.X * SF, mPF.Y * SF);
            mGraph.DrawLine(mPen, mPE.X * SF, mPE.Y * SF, mPF.X * SF, mPF.Y * SF);*/
            mGraph.DrawLine(mPen,mPA,mPB);
            mGraph.DrawLine(mPen,mPA,mPH);
            mGraph.DrawLine(mPen,mPB,mPC);
            mGraph.DrawLine(mPen,mPH,mPG);
            mGraph.DrawLine(mPen,mPC,mPD);
            mGraph.DrawLine(mPen,mPG,mPF);
            mGraph.DrawLine(mPen, mPD, mPE);
            mGraph.DrawLine(mPen, mPF, mPE);
            
        }
    }
}

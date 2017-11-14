using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricShapesV2
{
    class CTriangle
    {
        //Datos Miembro - atributos de la clase
        private float mSideA, mSideB, mSideC;
        private float mPerimeter, mSemiPerimeter, mArea;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;
        private PointF mPA, mPB, mPC;
        private float mAngleA;

        //Constructor por defecto o sin parametros
        public CTriangle()
        {
            mSideA = 0.0f; mSideB = 0.0f; mSideC = 0.0f;
            mPerimeter = 0.0f; mSemiPerimeter = 0.0f; mArea = 0.0f;
        }

        //Funciones miembro - Metodos de la clase
        public void InitializeData(TextBox txtSideA,
                                TextBox txtSideB,
                                TextBox txtSideC,
                                TextBox txtPerimeter,
                                TextBox txtArea)
        {
            mSideA = 0.0f; mSideB = 0.0f; mSideC = 0.0f;
            mPerimeter = 0.0f; mSemiPerimeter = 0.0f; mArea = 0.0f;
            txtSideA.Clear();
            txtSideB.Clear();
            txtSideC.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSideA.Focus();
        }
        public void InitializeData(TextBox txtSideA,
                                   TextBox txtSideB,
                                   TextBox txtSideC,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mSideA = 0.0f; mSideB = 0.0f; mSideC = 0.0f;
            mPerimeter = 0.0f; mSemiPerimeter = 0.0f; mArea = 0.0f;
            txtSideA.Clear();
            txtSideB.Clear();
            txtSideC.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSideA.Focus();
            picCanvas.Refresh();
        }
        public Boolean ReadData(TextBox txtSideA,
                                TextBox txtSideB,
                                TextBox txtSideC, 
                                TextBox txtPerimeter,
                                TextBox txtArea,
                                PictureBox picCanvas)
        {
            Boolean flag;
            try
            {
                mSideA = float.Parse(txtSideA.Text);
                mSideB = float.Parse(txtSideB.Text);
                mSideC = float.Parse(txtSideC.Text);
                flag = true;
            }
            catch
            {
                InitializeData(txtSideA, txtSideB, txtSideC, txtPerimeter, txtArea, picCanvas);
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            return flag;
        }
        public void PerimeterTriangle()
        {
            mPerimeter = mSideA + mSideB + mSideC;
            mSemiPerimeter = mPerimeter / 2;
        }
        public void AreaTriangle()
        {
            //Formula de Heron
            mArea = (float)Math.Sqrt((mSemiPerimeter * (mSemiPerimeter - mSideA) * (mSemiPerimeter - mSideB) * (mSemiPerimeter - mSideC)));
        }
        public void ExistenceTheorem(TextBox txtSideA,
                                     TextBox txtSideB,
                                     TextBox txtSideC,
                                     TextBox txtPerimeter,
                                     TextBox txtArea)
        {
            if (mSideA + mSideB > mSideC && mSideA + mSideC > mSideB && mSideB + mSideC > mSideA)
            {
                AreaTriangle();
                PrintData(txtSideA, txtSideB, txtSideC, txtPerimeter, txtArea);

            }
            else
            {
                InitializeData(txtSideA, txtSideB, txtSideC, txtPerimeter, txtArea);
                MessageBox.Show("No cumple con el teorema de la existencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void PrintData(TextBox txtSideA,
                              TextBox txtSideB,
                              TextBox txtSideC,
                              TextBox txtPerimeter,
                              TextBox txtArea)
        {
            txtSideA.Text = String.Format("{0:##.00}", mSideA);
            txtSideB.Text = String.Format("{0:##.00}", mSideB);
            txtSideC.Text = String.Format("{0:##.00}", mSideC);
            txtPerimeter.Text = String.Format("{0:##.00}", mPerimeter);
            txtArea.Text = String.Format("{0:##.00}", mArea);
        }
        //Calcular el valor del angulo A mediante la ley de Cosenos (cos(A)=(b^2+c^2-a^2)/2*b*c)
        private void CalculateAngleA()
        {
            mAngleA = (float)Math.Acos((mSideB * mSideB + mSideC * mSideC - mSideA * mSideA) / (2 * mSideB * mSideC));
        }
        private void CalculateVertexC()
        {
            mPA.X = 0.0f;   mPA.Y = 0.0f;
            mPB.X = mSideC; mPB.Y = 0.0f;

            CalculateAngleA();
            //Calculamos los puntos x,y del vertice C
            mPC.X = mSideB * (float)Math.Cos(mAngleA);
            mPC.Y = mSideB * (float)Math.Sin(mAngleA);

        }
        public void DrawShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 4);

            CalculateVertexC();
            //Dibujar las lineas con respectos a los puntos obtenidos mPA,mPB,mPC
            mGraph.DrawLine(mPen, mPA.X * SF, mPA.Y * SF, mPB.X * SF, mPB.Y * SF);
            mGraph.DrawLine(mPen, mPA.X * SF, mPA.Y * SF, mPC.X * SF, mPC.Y * SF);
            mGraph.DrawLine(mPen, mPC.X * SF, mPC.Y * SF, mPB.X * SF, mPB.Y * SF);
            
        }
    }
}

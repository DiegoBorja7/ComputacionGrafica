using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricShapesV2
{
    class CRectangle
    {
        //Datos Miembro - atributos de la clase
        private float mWidth, mLong;
        private float mPerimeter, mArea;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        //Constructor por defecto o sin parametros
        public CRectangle()
        {
            mWidth = 0.0f; mLong = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Funciones miembro - Metodos de la clase
        public void InitializeData(TextBox txtWidht,
                                   TextBox txtLong,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            mWidth = 0.0f; mLong = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtWidht.Clear();
            txtLong.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtWidht.Focus();
            picCanvas.Refresh();
        }
        public Boolean ReadData(TextBox txtWidht,
                                TextBox txtLong)
        {
            Boolean Flag;
            try
            {
                mWidth = float.Parse(txtWidht.Text);
                mLong = float.Parse(txtLong.Text);
                if (mWidth <= 0 || mLong <= 0)
                {
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWidht.Clear();
                    txtLong.Clear();
                    txtWidht.Focus();
                    Flag = false;
                }
                else
                    Flag = true;
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWidht.Clear();
                txtLong.Clear();
                txtWidht.Focus();
                Flag = false;
            }
            return Flag;

        }
        public void PerimeterRectangle()
        {
            mPerimeter = 2 * mWidth + 2 * mLong;
        }

        public void AreaRectangle()
        {
            mArea = mWidth * mLong;
        }
        public void PrintData(TextBox txtPerimeter,
                              TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void DrawShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine, 4);

            mGraph.DrawRectangle(mPen,7,7, mWidth*SF, mLong*SF);
        }
    }
}

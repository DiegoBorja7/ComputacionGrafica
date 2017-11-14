using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricShapesV2
{
    class CCircle
    {
        //Datos Miembro - atributos de la clase
        private float mRadius;
        private float mPerimeter, mArea;

        //Objeto que activa el modo grafico de windows
        private Graphics mGraph; 
        private const float SF = 20; //SF ->Scale Factory (Constante) para manejar un Zoom In y un Zoom Out del dibujo
        private Pen mPen;//Un objeto de tipo pluma (lapiz, esfero,marcador) para dibujar en el lienzo


        //Constructor por defecto o sin parametros
        public CCircle ()
        {
            mRadius = 0.0f; 
            mPerimeter = 0.0f; 
            mArea = 0.0f;
        }

        //Funciones miembro - Metodos de la clase
        public void InitializeData(TextBox txtArea,
                                    TextBox txtPerimeter,
                                    TextBox txtRadius)
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtArea.Text = " ";
            txtPerimeter.Text = " ";
            txtRadius.Text = "";
            txtRadius.Focus();
        }
        public void InitializeData(TextBox txtArea,
                                   TextBox txtPerimeter,
                                   TextBox txtRadius,
                                   PictureBox picCanvas)
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtArea.Text = " ";
            txtPerimeter.Text = " ";
            txtRadius.Text = "";
            txtRadius.Focus();
            picCanvas.Refresh();
        }
        public Boolean ReadData(TextBox txtRadius)
        {
            Boolean Flag;
            try
            {
                mRadius = float.Parse(txtRadius.Text);
                if(mRadius<=0)
                {
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRadius.Clear();
                    txtRadius.Focus();
                    Flag = false;
                }
                else
                    Flag = true;

            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos !","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtRadius.Clear();
                txtRadius.Focus();
                Flag = false;
            }

            return Flag;
        }

        public void PerimeterCircle()
        {
            mPerimeter = 2 *(float)Math.PI *mRadius;
        }

        public void AreaCircle()
        {
            mArea = (float)Math.PI * (float)Math.Pow(mRadius, 2);
        }

        public void PrintData(TextBox txtArea,
                               TextBox txtPerimeter)
        {
            txtPerimeter.Text = String.Format("{0:##.##}", mPerimeter);
            txtArea.Text = String.Format("{0:##.##}", mArea);            
        }      
        public void DrawShape (PictureBox picCanvas)
        {
            //asignar al objeto mGraph la funcionalidad de crear graficos del picCanvas
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Aquamarine,4);

            //Graficar un circulo en funcion de una elipse
            mGraph.DrawEllipse(mPen, 7, 7, 2 * mRadius * SF, 2 * mRadius * SF);
            
        }
    }

}

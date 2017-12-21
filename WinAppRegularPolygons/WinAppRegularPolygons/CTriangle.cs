using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class CTriangle
    {
        // Datos miembro - Atributos.
        private float mL;
        private float mPerimeter, mArea;
        private float mAngle;
        private float mHeight;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mP1, mP2, mP3;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public CTriangle()
        {
            mL = 0.0f; mAngle = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        // Función que permite leer el lado del triángulo.
        public void ReadData(TextBox txtSide)
        {
            mL = float.Parse(txtSide.Text);
        }
        // Función que permite calcular el perímetro del triángulo.
        public void PerimeterTriangle()
        {
            mPerimeter = 3 * mL;
        }
        public float ConvertGradesToRadians(float a)
        {
            return (a * (float)Math.PI / 180);
        }
        public void HeightTriangle()
        {
            mAngle = 60.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mHeight = mL * (float)Math.Sin(mAngle);    
        }
        // Función que permite calcular el área del triángulo.
        public void AreaTriangle()
        {
            mArea = ((float)Math.Pow(mL, 2)* (float)Math.Sin(mAngle))/2.0f;
        }
        // Función que permite imprimir el perímetro y el área del triángulo.
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

            mL = 0.0f; mAngle = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            picCanvas.Refresh();
        }
        // Función que permite graficar un triángulo en base a los valores de los tres 
        // vértices representados por tres puntos en un plano.
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 3);
        
            mP1.X = 0; mP1.Y = 0; mP2.X = mL; mP2.Y = 0;
            mP3.X = mL/2; mP3.Y = mHeight; 


            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
          
        }
    }
}

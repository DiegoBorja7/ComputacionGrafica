using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    class COctagon
    {
        // Datos miembro - Atributos.
        private float mL;
        private float mPerimeter, mArea;
        private float mAngle;
        private float mApothem, mB;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mP1, mP2, mP3, mP4, mP5, mP6, mP7, mP8;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public COctagon()
        {
            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mB = 0.0f;           
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        // Función que permite leer el lado del octágono.
        public void ReadData(TextBox txtSide)
        {
            mL = float.Parse(txtSide.Text);
        }
        // Función que permite calcular el perímetro del octágono.
        public void PerimeterOctagon()
        {
            mPerimeter = 8 * mL;
        }
        public float ConvertGradesToRadians(float a)
        {
            return (a * (float)Math.PI / 180);
        }
        public void ApothemOctagon()
        {
            mAngle = 22.5f;
            mAngle = ConvertGradesToRadians(mAngle);
            mApothem = mL / 2 / (float)Math.Tan(mAngle);
        }
        // Función que permite calcular el área del octágono.
        public void AreaOctagon()
        {
            mArea = mPerimeter * mApothem / 2.0f;
        }
        // Función que permite imprimir el perímetro y el área del octágono.
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

            mL = 0.0f; mAngle = 0.0f; mApothem = 0.0f; mB = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            picCanvas.Refresh();
        }
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Teal, 3);

            mAngle = 45.0f;
            mAngle = ConvertGradesToRadians(mAngle);
            mB = mL * (float)Math.Sin(mAngle);

            mP1.X = mB; mP1.Y = 0; mP2.X = mB + mL ; mP2.Y = 0;
            mP3.X = 0; mP3.Y = mB; mP4.X = 2 * mB + mL; mP4.Y = mB;
            mP5.X = 0; mP5.Y = mB + mL; mP6.X = 2 * mB + mL; mP6.Y = mB + mL;
            mP7.X = mB; mP7.Y = 2 * mB + mL; mP8.X = mB + mL; mP8.Y = 2 * mB + mL;

            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP4.X * SF, mP4.Y * SF);
            mGraph.DrawLine(mPen, mP4.X * SF, mP4.Y * SF, mP6.X * SF, mP6.Y * SF);
            mGraph.DrawLine(mPen, mP6.X * SF, mP6.Y * SF, mP8.X * SF, mP8.Y * SF);
            mGraph.DrawLine(mPen, mP8.X * SF, mP8.Y * SF, mP7.X * SF, mP7.Y * SF);
            mGraph.DrawLine(mPen, mP7.X * SF, mP7.Y * SF, mP5.X * SF, mP5.Y * SF);
            mGraph.DrawLine(mPen, mP5.X * SF, mP5.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP3.X * SF, mP3.Y * SF, mP1.X * SF, mP1.Y * SF);
        }
    }
}

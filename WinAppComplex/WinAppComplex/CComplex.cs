using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppComplex
{
    class CComplex
    {
        //Datos miembro - Atributos.
        private float mReal;
        private float mImag;
        private float mDiagonal;
        private float mAngle;
        private const float SF = 20;
        private Pen mPen;
        private Graphics mGraph;

        //Funciones miembro - Métodos.

        //Propiedades - Descriptores de acceso (setters y getters).
        
        //Función dual - Permite recibir valores y retornar valores.
        public float REAL
        {
            get { return mReal; }
            set { mReal = value; }
        }

        public float IMAG
        {
            get { return mImag; }
            set { mImag = value; }
        }

        //Constructores.

        //Constructor por defecto - sin parámetros.
        public CComplex()
        {
            mReal = 0.0f; mImag = 0.0f;
        }

        //Constructor - con parámetros.
        public CComplex(float real, float imag)
        {
            mReal = real; mImag = imag;
        }

        //Función de lectura de datos.
        public void ReadData(NumericUpDown nudRealVector, NumericUpDown nudImagVector)
        {
            mReal = (float)(nudRealVector.Value);
            mImag = (float)(nudImagVector.Value);
        }

        //Función de impresión de datos.
        public void PrintData(TextBox txtReal, TextBox txtImag)
        {
            txtReal.Text = mReal.ToString();
            txtImag.Text = mImag.ToString()+" i";
        }
        public void CalculateDiagonal(TextBox txtDiagonal)
        {
            mDiagonal =(float)Math.Sqrt(Math.Pow(mReal,2)+ Math.Pow(mImag, 2));
            txtDiagonal.Text = String.Format("{0:0.00}", mDiagonal);
        }
        public void CalculateAngle(TextBox txtAngle)
        {
            mAngle = (float)(Math.Abs(Math.Atan(mImag / mReal)) * 180 / Math.PI);
            txtAngle.Text = String.Format("{0:0.00}", mAngle) + " º";
        }
        //Función para sumar 2 complejos.
        public CComplex Addition(CComplex U, CComplex V)
        {
            CComplex Temp = new CComplex();
            Temp.mReal=U.mReal+V.mReal;
            Temp.mImag=U.mImag+V.mImag;
            return Temp;
        }

        //Función para restar 2 complejos.
        public CComplex Substraction(CComplex U, CComplex V)
        {
            CComplex Temp = new CComplex();
            Temp.mReal = U.mReal - V.mReal;
            Temp.mImag = U.mImag - V.mImag;
            return Temp;
        }

        //Función para multiplicar 2 complejos.
        public CComplex Multiplication(CComplex U, CComplex V)
        {
            CComplex Temp = new CComplex();
            Temp.mReal = (U.mReal * V.mReal) + (U.mImag * V.mImag)*-1;
            Temp.mImag = (U.mReal * V.mImag) + (V.mReal * U.mImag);
            return Temp;
        }

        //Función para dividir 2 complejos.
        public CComplex Division(CComplex U, CComplex V)
        {
            CComplex Temp = new CComplex();
            Temp.mReal = (U.mReal / V.mReal);
            Temp.mImag = (U.mImag / V.mImag);
            return Temp;
        }

        //Función para graficar los ejes coordenados.
        public void GraphAxis(PictureBox picCanvas)
        {
            mPen = new Pen(Color.Black, 3);
            mGraph = picCanvas.CreateGraphics();
            //Eje horizontal.
            mGraph.DrawLine(mPen, 0, 150, 400, 150);
            //Eje vertical.
            mGraph.DrawLine(mPen, 200, 0, 200, 300);
        }

        //Función para convertir CComplex a par ordenado.
        public PointF VectorToPointF(CComplex V)
        {
            return new PointF ((float)V.REAL * SF + 200, -(1)*(float)V.IMAG * SF + 150);
        }

        public PointF VectorToPointF0X(CComplex V)
        {
            return new PointF((float)V.REAL * SF + 200, 150);
        }

        //Función para graficar 1 vector desde el origen.
        public void DrawVector(CComplex V, Color color,PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            PointF origin = VectorToPointF(new CComplex(0, 0));
            PointF end = VectorToPointF(V);
            mGraph.DrawLine(new Pen(new SolidBrush(color), 2), origin, end);
        }

        //Función para graficar lineas y terminar los vectores.
        public void DrawVector(CComplex U, CComplex V, Color color, PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            PointF origin = VectorToPointF(U);
            PointF end = VectorToPointF0X(V);
            mGraph.DrawLine(new Pen(new SolidBrush(color), 2), origin, end);
        }
    }
}

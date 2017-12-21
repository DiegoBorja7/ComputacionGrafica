using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppComplex
{
    public partial class frmComplex : Form
    {
        //Datos miembro - (Composición Múltiple).
        private CComplex A = new CComplex();
        private CComplex B = new CComplex();
        private CComplex R = new CComplex();

        public frmComplex()
        {
            InitializeComponent();
        }
        private void btnAddition_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXVectorA, nudYVectorA);
            B.ReadData(nudXVectorB, nudYVectorB);
            R = R.Addition(A, B);
            R.PrintData(txtXVectorR, txtYVectorR);
            //Limpiar el lienzo.
            picCanvas.Refresh();
            //Graficar los ejes coordenados.
            R.GraphAxis(picCanvas);
            //Vector A.
            R.DrawVector(A, Color.Red, picCanvas);
            R.DrawVector(A, A, Color.Red, picCanvas);
            //Vector B.
            R.DrawVector(B, Color.Blue, picCanvas);
            R.DrawVector(B, B, Color.Blue, picCanvas);
            //Vector R.
            R.DrawVector(R, Color.Green, picCanvas);
            R.DrawVector(R, R, Color.Green, picCanvas);
            R.CalculateDiagonal(txtDiagonal);
            R.CalculateAngle(txtAngle);
        }
        
        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXVectorA, nudYVectorA);
            B.ReadData(nudXVectorB, nudYVectorB);
            R = R.Substraction(A, B);
            R.PrintData(txtXVectorR, txtYVectorR);
            //Limpiar el lienzo.
            picCanvas.Refresh();
            //Graficar los ejes coordenados.
            R.GraphAxis(picCanvas);
            //Vector A.
            R.DrawVector(A, Color.Red, picCanvas);
            R.DrawVector(A, A, Color.Red, picCanvas);
            //Vector B.
            R.DrawVector(B, Color.Blue, picCanvas);
            R.DrawVector(B, B, Color.Blue, picCanvas);
            //Vector R.
            R.DrawVector(R, Color.Green, picCanvas);
            R.DrawVector(R, R, Color.Green, picCanvas);
            R.CalculateDiagonal(txtDiagonal);
            R.CalculateAngle(txtAngle);
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXVectorA, nudYVectorA);
            B.ReadData(nudXVectorB, nudYVectorB);
            R = R.Multiplication(A, B);
            R.PrintData(txtXVectorR, txtYVectorR);
            //Limpiar el lienzo.
            picCanvas.Refresh();
            //Graficar los ejes coordenados.
            R.GraphAxis(picCanvas);
            //Vector A.
            R.DrawVector(A, Color.Red, picCanvas);
            R.DrawVector(A, A, Color.Red, picCanvas);
            //Vector B.
            R.DrawVector(B, Color.Blue, picCanvas);
            R.DrawVector(B, B, Color.Blue, picCanvas);
            //Vector R.
            R.DrawVector(R, Color.Green, picCanvas);
            R.DrawVector(R, R, Color.Green, picCanvas);
            R.CalculateDiagonal(txtDiagonal);
            R.CalculateAngle(txtAngle);
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
           
            A.ReadData(nudXVectorA, nudYVectorA);
            B.ReadData(nudXVectorB, nudYVectorB);
            if(nudXVectorB.Value==0 || nudYVectorB.Value == 0)
            { 
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            R = R.Division(A, B);
            R.PrintData(txtXVectorR, txtYVectorR);
            //Limpiar el lienzo.
            picCanvas.Refresh();
            //Graficar los ejes coordenados.
            R.GraphAxis(picCanvas);
            //Vector A.
            R.DrawVector(A, Color.Red, picCanvas);
            R.DrawVector(A, A, Color.Red, picCanvas);
            //Vector B.
            R.DrawVector(B, Color.Blue, picCanvas);
            R.DrawVector(B, B, Color.Blue, picCanvas);
            //Vector R.
            R.DrawVector(R, Color.Green, picCanvas);
            R.DrawVector(R, R, Color.Green, picCanvas);
            R.CalculateDiagonal(txtDiagonal);
            R.CalculateAngle(txtAngle);
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

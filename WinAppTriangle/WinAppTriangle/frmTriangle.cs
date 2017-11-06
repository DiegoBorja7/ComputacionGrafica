using System;
using System.Windows.Forms;

namespace WinAppTriangle
{
    public partial class frmTriangle : Form
    {
        //Datos Miembro - atributos de la clase
        private float mSideA, mSideB, mSideC;
        private float mPerimeter, mSemiPerimeter,mArea;

        public frmTriangle()
        {
            InitializeComponent();
            CenterToScreen();
            this.InitializeData();
        }
        //Funciones miembro - Metodos de la claseç
        private void InitializeData()
        {
            mSideA = 0.0f;
            mSideB = 0.0f;
            mSideC = 0.0f;
            txtSideA.Clear();
            txtSideB.Text = "";
            txtSideC.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtSideA.Focus();
        }
        private void ReadData()
        {
            try
            {
                mSideA = float.Parse(txtSideA.Text);
                mSideB = float.Parse(txtSideB.Text);
                mSideC = float.Parse(txtSideC.Text);
            }
            catch
            {
                InitializeData();
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }     
        private void PerimeterTriangle()
        {
            mPerimeter = mSideA + mSideB + mSideC;
            mSemiPerimeter = mPerimeter / 2;
        } 
        private void AreaTriangle()
        {
            //Formula de Heron
            mArea = (float)Math.Sqrt((mSemiPerimeter * (mSemiPerimeter - mSideA) * (mSemiPerimeter - mSideB) * (mSemiPerimeter - mSideC)));
        }
        private void ExistenceTheorem()
        {
           if (mSideA + mSideB > mSideC && mSideA + mSideC > mSideB && mSideB + mSideC > mSideA)
           {
                AreaTriangle();
                PrintData();
            }
           else
           {
                InitializeData();
                MessageBox.Show("No cumple con el teorema de la existencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }               
        }
        private void PrintData()
        {
            txtSideA.Text= String.Format("{0:##.00}", mSideA);
            txtSideB.Text = String.Format("{0:##.00}", mSideB);
            txtSideC.Text = String.Format("{0:##.00}", mSideC);
            txtPerimeter.Text = String.Format("{0:##.00}", mPerimeter);
            txtArea.Text= String.Format("{0:##.00}", mArea);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            PerimeterTriangle();
            ExistenceTheorem();            
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

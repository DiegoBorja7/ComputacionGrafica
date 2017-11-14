using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppGeometricShapesV1
{
    public partial class frmTriangle : Form
    {
        //Datos Miembro - atributos de la clase
        private float mSideA, mSideB, mSideC;
        private float mPerimeter, mSemiPerimeter, mArea;

        //Constructor de la clase
        public frmTriangle()
        {
            InitializeComponent();
            InitializeData();
        }

        //Funciones miembro - Metodos de la clase
        private void InitializeData()
        {
            txtSideA.Clear();
            txtSideB.Clear();
            txtSideC.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSideA.Focus();
        }
        private Boolean ReadData()
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
                InitializeData();
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            return flag;
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
        public void PrintData()
        {
            txtSideA.Text = String.Format("{0:0.00}", mSideA);
            txtSideB.Text = String.Format("{0:0.00}", mSideB);
            txtSideC.Text = String.Format("{0:0.00}", mSideC);
            txtPerimeter.Text = String.Format("{0:##.00}", mPerimeter);
            txtArea.Text = String.Format("{0:##.00}", mArea);
        }
        private void frmTriangle_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag = ReadData();
            if (flag)
            {
                PerimeterTriangle();
                ExistenceTheorem();
            }
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

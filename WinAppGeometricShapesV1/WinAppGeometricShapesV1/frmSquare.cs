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
    public partial class frmSquare : Form
    {
        //Datos Miembro - atributos de la clase
        private float mSide;
        private float mPerimeter, mArea;

        //Constructor de la clase
        public frmSquare()
        {
            InitializeComponent();
            InitializeData();
        }

        //Funciones miembro - Metodos de la clase
        private void InitializeData()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtSide.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtSide.Focus();
        }
        private Boolean ReadData()
        {
            Boolean flag;
            try
            {
                mSide = float.Parse(txtSide.Text);
                if (mSide <= 0)
                {
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSide.Clear();
                    txtSide.Focus();
                    flag = false;
                }
                else
                    flag = true;
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSide.Clear();
                txtSide.Focus();
                flag = false;
            }

            return flag;
        }
        private void CalculateArea()
        {
            mArea = mSide * mSide;
        }
        private void CalculatePerimeter()
        {
            mPerimeter = mSide * 4;
        }
        private void PrintData()
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        private void frmSquare_Load(object sender, EventArgs e)
        {
            InitializeData();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ReadData();
            if (Flag)
            {
                CalculatePerimeter();
                CalculateArea();
                PrintData();
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

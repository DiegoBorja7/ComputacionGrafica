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
    public partial class frmCircle : Form
    {
        //Datos Miembro - atributos de la clase
        private float mRadius;
        private float mPerimeter, mArea;

        //Constructor de la clase
        public frmCircle()
        {
            InitializeComponent();
            InitializeData();
        }

        //Funciones miembro - Metodos de la clase
        private void InitializeData()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtArea.Text = " ";
            txtPerimeter.Text = " ";
            txtRadius.Text = "";
            txtRadius.Focus();
        }
        private Boolean ReadData()
        {
            Boolean Flag;
            try
            {
                mRadius = float.Parse(txtRadius.Text);
                if (mRadius <= 0)
                {
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InitializeData();
                    Flag = false;
                }
                else
                    Flag = true;

            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InitializeData();
                Flag = false;
            }

            return Flag;
        }
        public void PerimeterCircle()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        public void AreaCircle()
        {
            mArea = (float)Math.PI * (float)Math.Pow(mRadius, 2);
        }

        public void PrintData()
        {
            txtPerimeter.Text = String.Format("{0:##.##}", mPerimeter);
            txtArea.Text = String.Format("{0:##.##}", mArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ReadData();
            if(Flag)
            {
                PerimeterCircle();
                AreaCircle();
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

        private void frmCircle_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

    }
}

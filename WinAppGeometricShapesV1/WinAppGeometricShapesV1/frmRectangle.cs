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
    public partial class frmRectangle : Form
    {
        //Datos Miembro - atributos de la clase
        private float mWidth, mLong;
        private float mPerimeter, mArea;
        
        //Constructor de la clase
        public frmRectangle()
        {
            InitializeComponent();
            InitializeData();
        }

        //Funciones miembro - Metodos de la clase
        private void InitializeData()
        {
            mWidth = 0.0f; mLong = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtWidth.Clear();
            txtLong.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtWidth.Focus();
        }
        private Boolean ReadData()
        {
            Boolean Flag;
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                mLong = float.Parse(txtLong.Text);
                if (mWidth <= 0 || mLong <= 0)
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
                txtWidth.Clear();
                txtLong.Clear();
                txtWidth.Focus();
                Flag = false;
            }
            return Flag;

        }
        private void PerimeterRectangle()
        {
            mPerimeter = 2 * mWidth + 2 * mLong;
        }

        private void AreaRectangle()
        {
            mArea = mWidth * mLong;
        }
        private void PrintData()
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ReadData();
            if (Flag)
            {
                PerimeterRectangle();
                AreaRectangle();
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

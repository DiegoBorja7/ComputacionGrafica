using System;
using System.Windows.Forms;

namespace WinAppSquare2
{
    public partial class frmSquare : Form
    {
        private float mArea;
        private float mPerimeter,mSide;
        public frmSquare()
        {
            CenterToScreen();
            InitializeComponent();
            InitializeData();
        }
        //Funciones miembro - Métodos de la clase.        
        private Boolean ReadData()//Funcion de lectura
        {
            Boolean flag;
            try
            {
                mSide = float.Parse(txtSide.Text);
                if (mSide <= 0)
                {
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InitializeData();
                    flag = false;
                }
                else
                    flag = true;
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InitializeData();
                flag = false;
            }

            return flag;
        }
        private void calculateArea()
        {
            mArea = mSide * mSide;
        }
        private void calculatePerimeter()
        {
            mPerimeter = mSide * 4;
        }
        private void InitializeData()
        {
            txtSide.Focus();
            mSide = 0.0f; mArea = 0.0f; mPerimeter = 0.0f;
            txtSide.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
        }
        private void printData()
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag=ReadData();
            if (flag)
            {
                calculateArea();
                calculatePerimeter();
                printData();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void Square_Load(object sender, EventArgs e)
        {
            InitializeData();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
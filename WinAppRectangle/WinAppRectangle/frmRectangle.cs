using System;
using System.Windows.Forms;

namespace WinAppRectangle
{
    public partial class frmRectangle : Form
    {
        //Datos miembro ' Atributos de la clase.
        private float mWidth,mLong;
        private float mPerimeter, mArea;
        
        //constructor de la clase
        public frmRectangle()
        {
            CenterToScreen();
            InitializeComponent();
            InitializeData();
        }
       
        //Funciones miembro - Métodos de la clase.
        //Funcion de lectura
        private Boolean ReadData()
        {
            Boolean flag;
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                mLong = float.Parse(txtLong.Text);
                if(mLong <= 0 || mWidth <= 0)
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

        
        private void InitializeData()
        {
            txtWidth.Focus();
            mWidth = 0.0f; mLong = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtWidth.Text = ""; txtLong.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

    
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag=ReadData();
            if (flag)
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

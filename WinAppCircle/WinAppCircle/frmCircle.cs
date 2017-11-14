using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCircle
{
    public partial class frmCircle : Form
    {
        //Datos Miembro - atributos de la clase
        private float mRadius;
        private float mPerimeter, mArea;

        //Constructor de la clase ((sirve para inicializar componentes,datos u objeto de una clase))
        public frmCircle()
        {
            InitializeComponent();
            this.InitializeData();
        }

        //Funciones miembro - Metodos de la clase
        private void ReadData()
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                InitializeData();
                MessageBox.Show("Error en el ingreso de datos !","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void PerimeterCircle()
        {
            mPerimeter = 2 *(float)Math.PI *mRadius;
        }

        private void AreaCircle()
        {
            mArea = (float)Math.PI * (float)Math.Pow(mRadius, 2);
        }

        private void PrintData()
        {
            txtPerimeter.Text = String.Format("{0:##.##}", mPerimeter);
            txtArea.Text = String.Format("{0:##.##}", mArea);            
        }

        private void InitializeData()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtArea.Text = " ";
            txtPerimeter.Text = " ";
            txtRadius.Text="";
            txtRadius.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this representa el formulario
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            PerimeterCircle();
            AreaCircle();
            PrintData();
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}

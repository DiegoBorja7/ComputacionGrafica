using System;
using System.Windows.Forms;

namespace WinAppGeometricShapesV2
{
    public partial class frmCircle : Form
    {
        //Composicion -> incluyendo un objeto de tipo CCircle en el formulario frmCircle
        private CCircle ObjCircle = new CCircle();

        public frmCircle()
        {
            InitializeComponent();
            ObjCircle.InitializeData(txtArea, txtPerimeter, txtRadius, picCanvas);
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {
            ObjCircle.InitializeData(txtArea, txtPerimeter, txtRadius);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag=ObjCircle.ReadData(txtRadius);
            if(Flag)
            {
                ObjCircle.PerimeterCircle();
                ObjCircle.AreaCircle();
                ObjCircle.PrintData(txtArea, txtPerimeter);
                ObjCircle.DrawShape(picCanvas);
            }            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCircle.InitializeData(txtArea, txtPerimeter, txtRadius,picCanvas);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace WinAppGeometricShapesV2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            frmCircle ObjForm = new frmCircle();
            ObjForm.ShowDialog();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            frmRectangle ObjForm = new frmRectangle();
            ObjForm.ShowDialog();
        }
        

        private void btnSquare_Click(object sender, EventArgs e)
        {
            frmSquare ObjForm = new frmSquare();
            ObjForm.ShowDialog();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            frmTriangle ObjForm = new frmTriangle();
            ObjForm.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

using System;
using System.Windows.Forms;

namespace WinAppSeries
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void btnSucesion1_Click(object sender, EventArgs e)
        {
            frmSucesion1 ObjForm = new frmSucesion1();
            ObjForm.ShowDialog();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            frmFactorial ObjForm = new frmFactorial();
            ObjForm.ShowDialog();
        }

        private void btnSerieNumE_Click(object sender, EventArgs e)
        {
            frmSerieNumE ObjForm = new frmSerieNumE();
            ObjForm.ShowDialog();
        }

        private void btnSerieSin_Click(object sender, EventArgs e)
        {
            frmSerieSin ObjForm = new frmSerieSin();
            ObjForm.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

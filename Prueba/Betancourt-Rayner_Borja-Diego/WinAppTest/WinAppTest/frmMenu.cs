using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTest
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUfo ObjUfo = new frmUfo();
            ObjUfo.Show();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFibonacci ObjFibonacci = new frmFibonacci();
            ObjFibonacci.Show();
        }

        private void btnShape_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShape ObjShape = new frmShape();
            ObjShape.Show();
        }
    }
}

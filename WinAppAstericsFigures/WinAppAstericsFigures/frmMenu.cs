using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAstericsFigures
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            frmAstericsTriangle ObjForm = new frmAstericsTriangle();
            ObjForm.ShowDialog();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            frmAstericsSquare ObjForm = new frmAstericsSquare();
            ObjForm.ShowDialog();
        }

        private void btnRombus_Click(object sender, EventArgs e)
        {
            frmAstericsRombus ObjForm = new frmAstericsRombus();
            ObjForm.ShowDialog();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            frmAstericsRecatangle ObjForm = new frmAstericsRecatangle();
            ObjForm.ShowDialog();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            frmAstericsCircle ObjForm = new frmAstericsCircle();
            ObjForm.ShowDialog();
        }

        private void btnChessboard_Click(object sender, EventArgs e)
        {
            frmAstericsChessboard ObjForm = new frmAstericsChessboard();
            ObjForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

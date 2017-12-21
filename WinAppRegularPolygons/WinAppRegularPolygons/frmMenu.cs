using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRegularPolygons
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

        private void btnEquilateralTraingle_Click(object sender, EventArgs e)
        {
            frmEquilateralTriangle ObjForm = new frmEquilateralTriangle();
            ObjForm.ShowDialog();

        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            frmSquare ObjForm = new frmSquare();
            ObjForm.ShowDialog();
        }

        private void btnPentagon_Click(object sender, EventArgs e)
        {
            frmPentagon ObjForm = new frmPentagon();
            ObjForm.ShowDialog();
        }

        private void btnHexagon_Click(object sender, EventArgs e)
        {
            frmHexagon ObjForm = new frmHexagon();
            ObjForm.ShowDialog();
        }

        private void btnHeptagon_Click(object sender, EventArgs e)
        {
            frmHeptagon ObjForm = new frmHeptagon();
            ObjForm.ShowDialog();
        }

        private void btnOctogon_Click(object sender, EventArgs e)
        {
            frmOctogon ObjForm = new frmOctogon();
            ObjForm.ShowDialog();
        }

        private void btnEneagon_Click(object sender, EventArgs e)
        {
            frmEneagon ObjForm = new frmEneagon();
            ObjForm.ShowDialog();
        }

        private void btnDecagon_Click(object sender, EventArgs e)
        {
            frmDecagon ObjForm = new frmDecagon();
            ObjForm.ShowDialog();
        }

        private void btnEndecagon_Click(object sender, EventArgs e)
        {
            frmEndecagon ObjForm = new frmEndecagon();
            ObjForm.ShowDialog();
        }

        private void btnDodecagon_Click(object sender, EventArgs e)
        {
            frmDodecagon ObjForm = new frmDodecagon();
            ObjForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

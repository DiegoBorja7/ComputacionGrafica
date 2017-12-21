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
    public partial class frmUfo : Form
    {
        CUfo ObjUfo=new CUfo();
        public frmUfo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu ObjMenu = new frmMenu();
            ObjMenu.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjUfo.InitializeData(txtNum, lstFigure);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjUfo.ReadData(txtNum);
            ObjUfo.GraphAstericsUfo(lstFigure);
        }
    }
}

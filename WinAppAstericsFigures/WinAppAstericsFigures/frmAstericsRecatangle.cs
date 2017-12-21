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
    public partial class frmAstericsRecatangle : Form
    {
        private CAstericsFigure ObjAstericsRectangle = new CAstericsFigure();
        public frmAstericsRecatangle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ObjAstericsRectangle.ReadData(txtA,txtB);
            if (Flag)
            {
                ObjAstericsRectangle.GraphAstericsRectangle(lstFigure);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjAstericsRectangle.InitializeData(txtA, txtB, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

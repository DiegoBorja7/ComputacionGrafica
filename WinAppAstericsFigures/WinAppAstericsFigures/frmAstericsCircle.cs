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
    public partial class frmAstericsCircle : Form
    {
        private CAstericsFigure ObjAstericsCircle = new CAstericsFigure();
        public frmAstericsCircle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ObjAstericsCircle.ReadData(txtNum);
            if (Flag)
            {
                ObjAstericsCircle.GraphAstericsCircle(lstFigure);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjAstericsCircle.InitializeData(txtNum, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

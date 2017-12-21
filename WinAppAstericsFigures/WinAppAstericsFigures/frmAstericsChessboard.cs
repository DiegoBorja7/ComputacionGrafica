using System;
using System.Windows.Forms;
namespace WinAppAstericsFigures
{
    public partial class frmAstericsChessboard : Form
    {
        private CAstericsFigure ObjAstericsChessboard = new CAstericsFigure();
        public frmAstericsChessboard()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ObjAstericsChessboard.ReadData(txtNum);
            if (Flag)
            {
                ObjAstericsChessboard.GraphAstericsChessBoard(lstFigure);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjAstericsChessboard.InitializeData(txtNum, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

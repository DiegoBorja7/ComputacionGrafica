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
    public partial class frmFibonacci : Form
    {
        CFibonacci ObjFibonacci = new CFibonacci();
        public frmFibonacci()
        {
            InitializeComponent();
            ObjFibonacci.InitializeData(txtNum, txtNT, txtSum);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu ObjMenu = new frmMenu();
            ObjMenu.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjFibonacci.InitializeData(txtNum, txtNT, txtSum);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjFibonacci.ReadData(txtNum);
            ObjFibonacci.Fibonacci();
            ObjFibonacci.PrintData(txtNT, txtSum);
        }
    }
}

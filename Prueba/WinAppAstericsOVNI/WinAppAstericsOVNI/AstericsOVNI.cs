using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppAstericsOVNI
{
    public partial class grbOVNI : Form
    {
        private CAstericsOVNI ObjOVNI= new CAstericsOVNI();

        public grbOVNI()
        {
            InitializeComponent();
        }

        private void grbOVNI_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            ObjOVNI.ReadData(txtN);
            ObjOVNI.writeOVNI(listAsterics);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listAsterics.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

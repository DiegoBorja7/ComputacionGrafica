using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMessages
{
    public partial class frmMessages : Form
    {
        public frmMessages()
        {
            InitializeComponent();
        }

        private void btnMessage1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos al C Sharp", "MENSAJE DE CONTROL", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
        }

        private void btnMessage2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos al C Sharp", "MENSAJE DE CONTROL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btnMessage3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos al C Sharp", "MENSAJE DE CONTROL", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void btnMessage4_Click(object sender, EventArgs e)
        {
            //cerrar un unico formulario
            Close();
        }

        private void frmMessages_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo...");
        }  
    }
}

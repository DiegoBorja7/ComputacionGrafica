namespace WinAppMessages
{
    partial class frmMessages
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbMessages = new System.Windows.Forms.GroupBox();
            this.btnMessage4 = new System.Windows.Forms.Button();
            this.btnMessage3 = new System.Windows.Forms.Button();
            this.btnMessage1 = new System.Windows.Forms.Button();
            this.btnMessage2 = new System.Windows.Forms.Button();
            this.grbMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMessages
            // 
            this.grbMessages.Controls.Add(this.btnMessage4);
            this.grbMessages.Controls.Add(this.btnMessage3);
            this.grbMessages.Controls.Add(this.btnMessage1);
            this.grbMessages.Controls.Add(this.btnMessage2);
            this.grbMessages.Location = new System.Drawing.Point(12, 2);
            this.grbMessages.Name = "grbMessages";
            this.grbMessages.Size = new System.Drawing.Size(271, 247);
            this.grbMessages.TabIndex = 0;
            this.grbMessages.TabStop = false;
            // 
            // btnMessage4
            // 
            this.btnMessage4.Location = new System.Drawing.Point(25, 183);
            this.btnMessage4.Name = "btnMessage4";
            this.btnMessage4.Size = new System.Drawing.Size(235, 49);
            this.btnMessage4.TabIndex = 3;
            this.btnMessage4.Text = "Salir";
            this.btnMessage4.UseVisualStyleBackColor = true;
            this.btnMessage4.Click += new System.EventHandler(this.btnMessage4_Click);
            // 
            // btnMessage3
            // 
            this.btnMessage3.Location = new System.Drawing.Point(25, 128);
            this.btnMessage3.Name = "btnMessage3";
            this.btnMessage3.Size = new System.Drawing.Size(235, 49);
            this.btnMessage3.TabIndex = 2;
            this.btnMessage3.Text = "Mostrar Mensaje 3";
            this.btnMessage3.UseVisualStyleBackColor = true;
            this.btnMessage3.Click += new System.EventHandler(this.btnMessage3_Click);
            // 
            // btnMessage1
            // 
            this.btnMessage1.Location = new System.Drawing.Point(25, 19);
            this.btnMessage1.Name = "btnMessage1";
            this.btnMessage1.Size = new System.Drawing.Size(235, 49);
            this.btnMessage1.TabIndex = 0;
            this.btnMessage1.Text = "Mostrar Mensaje 1";
            this.btnMessage1.UseVisualStyleBackColor = true;
            this.btnMessage1.Click += new System.EventHandler(this.btnMessage1_Click);
            // 
            // btnMessage2
            // 
            this.btnMessage2.Location = new System.Drawing.Point(25, 73);
            this.btnMessage2.Name = "btnMessage2";
            this.btnMessage2.Size = new System.Drawing.Size(235, 49);
            this.btnMessage2.TabIndex = 1;
            this.btnMessage2.Text = "Mostrar Mensaje 2";
            this.btnMessage2.UseVisualStyleBackColor = true;
            this.btnMessage2.Click += new System.EventHandler(this.btnMessage2_Click);
            // 
            // frmMessages
            // 
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(301, 266);
            this.Controls.Add(this.grbMessages);
            this.Name = "frmMessages";
            this.Text = "Manejo de Mensajes";
            this.grbMessages.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox grbMessages;
        private System.Windows.Forms.Button btnMessage4;
        private System.Windows.Forms.Button btnMessage3;
        private System.Windows.Forms.Button btnMessage1;
        private System.Windows.Forms.Button btnMessage2;
    }
}


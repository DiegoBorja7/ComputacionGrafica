namespace WinAppSeries
{
    partial class frmMenu
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
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.btnSerieSin = new System.Windows.Forms.Button();
            this.btnSerieNumE = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnSum1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.btnExit);
            this.grbMenu.Controls.Add(this.btnSerieSin);
            this.grbMenu.Controls.Add(this.btnSerieNumE);
            this.grbMenu.Controls.Add(this.btnFactorial);
            this.grbMenu.Controls.Add(this.btnSum1);
            this.grbMenu.Location = new System.Drawing.Point(12, 12);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(266, 237);
            this.grbMenu.TabIndex = 0;
            this.grbMenu.TabStop = false;
            // 
            // btnSerieSin
            // 
            this.btnSerieSin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerieSin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSerieSin.Location = new System.Drawing.Point(21, 136);
            this.btnSerieSin.Name = "btnSerieSin";
            this.btnSerieSin.Size = new System.Drawing.Size(226, 33);
            this.btnSerieSin.TabIndex = 3;
            this.btnSerieSin.Text = "f(x) = Sen(x)";
            this.btnSerieSin.UseVisualStyleBackColor = true;
            this.btnSerieSin.Click += new System.EventHandler(this.btnSerieSin_Click);
            // 
            // btnSerieNumE
            // 
            this.btnSerieNumE.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerieNumE.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSerieNumE.Location = new System.Drawing.Point(21, 97);
            this.btnSerieNumE.Name = "btnSerieNumE";
            this.btnSerieNumE.Size = new System.Drawing.Size(226, 33);
            this.btnSerieNumE.TabIndex = 2;
            this.btnSerieNumE.Text = "f(x) = e^x";
            this.btnSerieNumE.UseVisualStyleBackColor = true;
            this.btnSerieNumE.Click += new System.EventHandler(this.btnSerieNumE_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFactorial.Location = new System.Drawing.Point(21, 58);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(226, 33);
            this.btnFactorial.TabIndex = 1;
            this.btnFactorial.Text = "n! =1 x 2 x 3 x 4....x n";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnSum1
            // 
            this.btnSum1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSum1.Location = new System.Drawing.Point(21, 19);
            this.btnSum1.Name = "btnSum1";
            this.btnSum1.Size = new System.Drawing.Size(226, 33);
            this.btnSum1.TabIndex = 0;
            this.btnSum1.Text = "S(n)=1+2+3+4.....+ n";
            this.btnSum1.UseVisualStyleBackColor = true;
            this.btnSum1.Click += new System.EventHandler(this.btnSucesion1_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(21, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 42);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Salir / Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.Controls.Add(this.grbMenu);
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.grbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button btnSerieSin;
        private System.Windows.Forms.Button btnSerieNumE;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnSum1;
        private System.Windows.Forms.Button btnExit;
    }
}


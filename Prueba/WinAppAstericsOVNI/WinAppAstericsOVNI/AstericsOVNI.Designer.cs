namespace WinAppAstericsOVNI
{
    partial class grbOVNI
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
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.grbListBox = new System.Windows.Forms.GroupBox();
            this.listAsterics = new System.Windows.Forms.ListBox();
            this.grbInputs.SuspendLayout();
            this.grbButtons.SuspendLayout();
            this.grbListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtN);
            this.grbInputs.Controls.Add(this.label1);
            this.grbInputs.Location = new System.Drawing.Point(0, 0);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(382, 100);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(159, 38);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese (n)";
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnExit);
            this.grbButtons.Controls.Add(this.btnReset);
            this.grbButtons.Controls.Add(this.btnWrite);
            this.grbButtons.Location = new System.Drawing.Point(0, 106);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(382, 100);
            this.grbButtons.TabIndex = 1;
            this.grbButtons.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(245, 40);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(125, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(13, 40);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Escribir";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // grbListBox
            // 
            this.grbListBox.Controls.Add(this.listAsterics);
            this.grbListBox.Location = new System.Drawing.Point(0, 213);
            this.grbListBox.Name = "grbListBox";
            this.grbListBox.Size = new System.Drawing.Size(382, 257);
            this.grbListBox.TabIndex = 2;
            this.grbListBox.TabStop = false;
            // 
            // listAsterics
            // 
            this.listAsterics.FormattingEnabled = true;
            this.listAsterics.Location = new System.Drawing.Point(13, 20);
            this.listAsterics.Name = "listAsterics";
            this.listAsterics.Size = new System.Drawing.Size(353, 225);
            this.listAsterics.TabIndex = 0;
            // 
            // grbOVNI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 468);
            this.Controls.Add(this.grbListBox);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.grbInputs);
            this.Name = "grbOVNI";
            this.Text = "OVNI";
            this.Load += new System.EventHandler(this.grbOVNI_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbButtons.ResumeLayout(false);
            this.grbListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.GroupBox grbListBox;
        private System.Windows.Forms.ListBox listAsterics;
    }
}


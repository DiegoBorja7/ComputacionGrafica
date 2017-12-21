namespace WinAppTest
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
            this.btnShape = new System.Windows.Forms.Button();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.btnUfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShape
            // 
            this.btnShape.Location = new System.Drawing.Point(81, 34);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(157, 36);
            this.btnShape.TabIndex = 0;
            this.btnShape.Text = "Figura";
            this.btnShape.UseVisualStyleBackColor = true;
            this.btnShape.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Location = new System.Drawing.Point(81, 97);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(157, 36);
            this.btnFibonacci.TabIndex = 1;
            this.btnFibonacci.Text = "Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // btnUfo
            // 
            this.btnUfo.Location = new System.Drawing.Point(81, 154);
            this.btnUfo.Name = "btnUfo";
            this.btnUfo.Size = new System.Drawing.Size(157, 36);
            this.btnUfo.TabIndex = 2;
            this.btnUfo.Text = "Ovni";
            this.btnUfo.UseVisualStyleBackColor = true;
            this.btnUfo.Click += new System.EventHandler(this.btnUfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(81, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 289);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUfo);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.btnShape);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShape;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Button btnUfo;
        private System.Windows.Forms.Button btnExit;
    }
}


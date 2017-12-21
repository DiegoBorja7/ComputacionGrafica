namespace WinAppAstericsFigures
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRombus = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnChessboard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.grbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(11, 6);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(226, 39);
            this.btnTriangle.TabIndex = 0;
            this.btnTriangle.Text = "Triangulo";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(11, 56);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(226, 39);
            this.btnSquare.TabIndex = 1;
            this.btnSquare.Text = "Cuadrado";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRombus
            // 
            this.btnRombus.Location = new System.Drawing.Point(11, 105);
            this.btnRombus.Name = "btnRombus";
            this.btnRombus.Size = new System.Drawing.Size(226, 39);
            this.btnRombus.TabIndex = 2;
            this.btnRombus.Text = "Rombo";
            this.btnRombus.UseVisualStyleBackColor = true;
            this.btnRombus.Click += new System.EventHandler(this.btnRombus_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(11, 152);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(226, 39);
            this.btnRectangle.TabIndex = 3;
            this.btnRectangle.Text = "Rectangulo";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(11, 197);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(226, 39);
            this.btnCircle.TabIndex = 4;
            this.btnCircle.Text = "Circulo";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnChessboard
            // 
            this.btnChessboard.Location = new System.Drawing.Point(11, 244);
            this.btnChessboard.Name = "btnChessboard";
            this.btnChessboard.Size = new System.Drawing.Size(226, 39);
            this.btnChessboard.TabIndex = 6;
            this.btnChessboard.Text = "Tablero de Ajedrez";
            this.btnChessboard.UseVisualStyleBackColor = true;
            this.btnChessboard.Click += new System.EventHandler(this.btnChessboard_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(11, 291);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(226, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir / Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbMenu
            // 
            this.grbMenu.Controls.Add(this.btnExit);
            this.grbMenu.Controls.Add(this.btnChessboard);
            this.grbMenu.Controls.Add(this.btnCircle);
            this.grbMenu.Controls.Add(this.btnRectangle);
            this.grbMenu.Controls.Add(this.btnRombus);
            this.grbMenu.Controls.Add(this.btnSquare);
            this.grbMenu.Controls.Add(this.btnTriangle);
            this.grbMenu.Location = new System.Drawing.Point(19, 6);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(245, 344);
            this.grbMenu.TabIndex = 8;
            this.grbMenu.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 358);
            this.Controls.Add(this.grbMenu);
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRombus;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnChessboard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbMenu;
    }
}
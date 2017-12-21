namespace WinAppComplex
{
    partial class frmComplex
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
            this.grbOperations = new System.Windows.Forms.GroupBox();
            this.txtYVectorR = new System.Windows.Forms.TextBox();
            this.txtXVectorR = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.txtDiagonal = new System.Windows.Forms.TextBox();
            this.lblDiagonal = new System.Windows.Forms.Label();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.lblVectorR = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.nudYVectorB = new System.Windows.Forms.NumericUpDown();
            this.nudXVectorB = new System.Windows.Forms.NumericUpDown();
            this.nudYVectorA = new System.Windows.Forms.NumericUpDown();
            this.nudXVectorA = new System.Windows.Forms.NumericUpDown();
            this.lblVectorB = new System.Windows.Forms.Label();
            this.lblVectorA = new System.Windows.Forms.Label();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorA)).BeginInit();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOperations
            // 
            this.grbOperations.Controls.Add(this.btnExit);
            this.grbOperations.Controls.Add(this.txtYVectorR);
            this.grbOperations.Controls.Add(this.txtXVectorR);
            this.grbOperations.Controls.Add(this.txtAngle);
            this.grbOperations.Controls.Add(this.lblAngle);
            this.grbOperations.Controls.Add(this.txtDiagonal);
            this.grbOperations.Controls.Add(this.lblDiagonal);
            this.grbOperations.Controls.Add(this.btnDivision);
            this.grbOperations.Controls.Add(this.btnMultiplication);
            this.grbOperations.Controls.Add(this.btnSubstraction);
            this.grbOperations.Controls.Add(this.btnAddition);
            this.grbOperations.Controls.Add(this.lblVectorR);
            this.grbOperations.Controls.Add(this.lblY);
            this.grbOperations.Controls.Add(this.lblX);
            this.grbOperations.Controls.Add(this.lblSeparator);
            this.grbOperations.Controls.Add(this.nudYVectorB);
            this.grbOperations.Controls.Add(this.nudXVectorB);
            this.grbOperations.Controls.Add(this.nudYVectorA);
            this.grbOperations.Controls.Add(this.nudXVectorA);
            this.grbOperations.Controls.Add(this.lblVectorB);
            this.grbOperations.Controls.Add(this.lblVectorA);
            this.grbOperations.Location = new System.Drawing.Point(471, 14);
            this.grbOperations.Name = "grbOperations";
            this.grbOperations.Size = new System.Drawing.Size(241, 325);
            this.grbOperations.TabIndex = 3;
            this.grbOperations.TabStop = false;
            this.grbOperations.Text = "Operaciones";
            // 
            // txtYVectorR
            // 
            this.txtYVectorR.BackColor = System.Drawing.SystemColors.Control;
            this.txtYVectorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYVectorR.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtYVectorR.Location = new System.Drawing.Point(155, 140);
            this.txtYVectorR.Name = "txtYVectorR";
            this.txtYVectorR.ReadOnly = true;
            this.txtYVectorR.Size = new System.Drawing.Size(38, 21);
            this.txtYVectorR.TabIndex = 25;
            // 
            // txtXVectorR
            // 
            this.txtXVectorR.BackColor = System.Drawing.SystemColors.Control;
            this.txtXVectorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXVectorR.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtXVectorR.Location = new System.Drawing.Point(97, 140);
            this.txtXVectorR.Name = "txtXVectorR";
            this.txtXVectorR.ReadOnly = true;
            this.txtXVectorR.Size = new System.Drawing.Size(38, 21);
            this.txtXVectorR.TabIndex = 24;
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(78, 203);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(115, 20);
            this.txtAngle.TabIndex = 23;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(20, 206);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(43, 13);
            this.lblAngle.TabIndex = 22;
            this.lblAngle.Text = "Angulo:";
            // 
            // txtDiagonal
            // 
            this.txtDiagonal.Location = new System.Drawing.Point(78, 178);
            this.txtDiagonal.Name = "txtDiagonal";
            this.txtDiagonal.Size = new System.Drawing.Size(115, 20);
            this.txtDiagonal.TabIndex = 21;
            // 
            // lblDiagonal
            // 
            this.lblDiagonal.AutoSize = true;
            this.lblDiagonal.Location = new System.Drawing.Point(20, 181);
            this.lblDiagonal.Name = "lblDiagonal";
            this.lblDiagonal.Size = new System.Drawing.Size(52, 13);
            this.lblDiagonal.TabIndex = 20;
            this.lblDiagonal.Text = "Diagonal:";
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(207, 100);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(23, 20);
            this.btnDivision.TabIndex = 8;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.Location = new System.Drawing.Point(207, 78);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(23, 20);
            this.btnMultiplication.TabIndex = 7;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstraction.Location = new System.Drawing.Point(207, 55);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(23, 20);
            this.btnSubstraction.TabIndex = 6;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = true;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.Location = new System.Drawing.Point(207, 32);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(23, 20);
            this.btnAddition.TabIndex = 5;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // lblVectorR
            // 
            this.lblVectorR.AutoSize = true;
            this.lblVectorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectorR.ForeColor = System.Drawing.Color.Green;
            this.lblVectorR.Location = new System.Drawing.Point(0, 143);
            this.lblVectorR.Name = "lblVectorR";
            this.lblVectorR.Size = new System.Drawing.Size(93, 16);
            this.lblVectorR.TabIndex = 11;
            this.lblVectorR.Text = "Complejo R:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(135, 16);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(81, 16);
            this.lblY.TabIndex = 10;
            this.lblY.Text = "Imaginaria";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(94, 16);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(41, 16);
            this.lblX.TabIndex = 9;
            this.lblX.Text = "Real";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(20, 110);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(181, 13);
            this.lblSeparator.TabIndex = 8;
            this.lblSeparator.Text = "_____________________________";
            // 
            // nudYVectorB
            // 
            this.nudYVectorB.Location = new System.Drawing.Point(158, 83);
            this.nudYVectorB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudYVectorB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudYVectorB.Name = "nudYVectorB";
            this.nudYVectorB.Size = new System.Drawing.Size(39, 20);
            this.nudYVectorB.TabIndex = 4;
            // 
            // nudXVectorB
            // 
            this.nudXVectorB.Location = new System.Drawing.Point(97, 83);
            this.nudXVectorB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudXVectorB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudXVectorB.Name = "nudXVectorB";
            this.nudXVectorB.Size = new System.Drawing.Size(39, 20);
            this.nudXVectorB.TabIndex = 3;
            // 
            // nudYVectorA
            // 
            this.nudYVectorA.Location = new System.Drawing.Point(158, 48);
            this.nudYVectorA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudYVectorA.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudYVectorA.Name = "nudYVectorA";
            this.nudYVectorA.Size = new System.Drawing.Size(39, 20);
            this.nudYVectorA.TabIndex = 2;
            // 
            // nudXVectorA
            // 
            this.nudXVectorA.Location = new System.Drawing.Point(97, 48);
            this.nudXVectorA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudXVectorA.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudXVectorA.Name = "nudXVectorA";
            this.nudXVectorA.Size = new System.Drawing.Size(39, 20);
            this.nudXVectorA.TabIndex = 1;
            // 
            // lblVectorB
            // 
            this.lblVectorB.AutoSize = true;
            this.lblVectorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectorB.ForeColor = System.Drawing.Color.Blue;
            this.lblVectorB.Location = new System.Drawing.Point(0, 85);
            this.lblVectorB.Name = "lblVectorB";
            this.lblVectorB.Size = new System.Drawing.Size(92, 16);
            this.lblVectorB.TabIndex = 1;
            this.lblVectorB.Text = "Complejo B:";
            // 
            // lblVectorA
            // 
            this.lblVectorA.AutoSize = true;
            this.lblVectorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVectorA.ForeColor = System.Drawing.Color.Red;
            this.lblVectorA.Location = new System.Drawing.Point(0, 52);
            this.lblVectorA.Name = "lblVectorA";
            this.lblVectorA.Size = new System.Drawing.Size(92, 16);
            this.lblVectorA.TabIndex = 0;
            this.lblVectorA.Text = "Complejo A:";
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(12, 12);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(448, 327);
            this.grbCanvas.TabIndex = 2;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(22, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(400, 300);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(29, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 42);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Salir / Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // frmComplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 351);
            this.Controls.Add(this.grbOperations);
            this.Controls.Add(this.grbCanvas);
            this.Name = "frmComplex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones con Complejos";
            this.grbOperations.ResumeLayout(false);
            this.grbOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorA)).EndInit();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOperations;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Label lblVectorR;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.NumericUpDown nudYVectorB;
        private System.Windows.Forms.NumericUpDown nudXVectorB;
        private System.Windows.Forms.NumericUpDown nudYVectorA;
        private System.Windows.Forms.NumericUpDown nudXVectorA;
        private System.Windows.Forms.Label lblVectorB;
        private System.Windows.Forms.Label lblVectorA;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.TextBox txtDiagonal;
        private System.Windows.Forms.Label lblDiagonal;
        private System.Windows.Forms.TextBox txtYVectorR;
        private System.Windows.Forms.TextBox txtXVectorR;
        private System.Windows.Forms.Button btnExit;
    }
}


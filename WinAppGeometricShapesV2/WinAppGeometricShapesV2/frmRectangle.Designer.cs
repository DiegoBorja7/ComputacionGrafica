﻿namespace WinAppGeometricShapesV2
{
    partial class frmRectangle
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
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.lblSide2 = new System.Windows.Forms.Label();
            this.lblSide1 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOuputs = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOuputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.lblSide2);
            this.grbInputs.Controls.Add(this.lblSide1);
            this.grbInputs.Controls.Add(this.txtLong);
            this.grbInputs.Controls.Add(this.txtWidth);
            this.grbInputs.Location = new System.Drawing.Point(11, 9);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(261, 82);
            this.grbInputs.TabIndex = 3;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Lados";
            // 
            // lblSide2
            // 
            this.lblSide2.AutoSize = true;
            this.lblSide2.Location = new System.Drawing.Point(38, 51);
            this.lblSide2.Name = "lblSide2";
            this.lblSide2.Size = new System.Drawing.Size(37, 13);
            this.lblSide2.TabIndex = 3;
            this.lblSide2.Text = "Altura:";
            // 
            // lblSide1
            // 
            this.lblSide1.AutoSize = true;
            this.lblSide1.Location = new System.Drawing.Point(38, 22);
            this.lblSide1.Name = "lblSide1";
            this.lblSide1.Size = new System.Drawing.Size(41, 13);
            this.lblSide1.TabIndex = 2;
            this.lblSide1.Text = "Ancho:";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(138, 48);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(108, 20);
            this.txtLong.TabIndex = 1;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(138, 19);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(108, 20);
            this.txtWidth.TabIndex = 0;
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(10, 97);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(261, 49);
            this.grbProcess.TabIndex = 4;
            this.grbProcess.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(180, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(99, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(18, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbOuputs
            // 
            this.grbOuputs.Controls.Add(this.lblArea);
            this.grbOuputs.Controls.Add(this.lblPerimeter);
            this.grbOuputs.Controls.Add(this.txtArea);
            this.grbOuputs.Controls.Add(this.txtPerimeter);
            this.grbOuputs.Location = new System.Drawing.Point(11, 152);
            this.grbOuputs.Name = "grbOuputs";
            this.grbOuputs.Size = new System.Drawing.Size(261, 94);
            this.grbOuputs.TabIndex = 5;
            this.grbOuputs.TabStop = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(38, 59);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(35, 26);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(57, 13);
            this.lblPerimeter.TabIndex = 5;
            this.lblPerimeter.Text = "Perimetro: ";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.SystemColors.Control;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtArea.Location = new System.Drawing.Point(146, 54);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 21);
            this.txtArea.TabIndex = 4;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.BackColor = System.Drawing.SystemColors.Control;
            this.txtPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimeter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPerimeter.Location = new System.Drawing.Point(146, 19);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(100, 21);
            this.txtPerimeter.TabIndex = 3;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(18, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(300, 200);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbCanvas
            // 
            this.grbCanvas.BackColor = System.Drawing.Color.SeaShell;
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(280, 11);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(335, 237);
            this.grbCanvas.TabIndex = 7;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Dibujo";
            // 
            // frmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(627, 261);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbInputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbOuputs);
            this.Name = "frmRectangle";
            this.Text = "Rectangulo";
            this.Load += new System.EventHandler(this.frmRectangle_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOuputs.ResumeLayout(false);
            this.grbOuputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbCanvas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.Label lblSide2;
        private System.Windows.Forms.Label lblSide1;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOuputs;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbCanvas;
    }
}
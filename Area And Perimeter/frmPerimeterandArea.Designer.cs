namespace Area_And_Perimeter
{
    partial class frmPerimeterandArea
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLengthInput = new System.Windows.Forms.TextBox();
            this.txtWidthInput = new System.Windows.Forms.TextBox();
            this.txtAreaCalculate = new System.Windows.Forms.TextBox();
            this.txtPerimeterCalculate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perimeter :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(18, 152);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 26);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(205, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 24);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLengthInput
            // 
            this.txtLengthInput.Location = new System.Drawing.Point(95, 28);
            this.txtLengthInput.Name = "txtLengthInput";
            this.txtLengthInput.Size = new System.Drawing.Size(90, 20);
            this.txtLengthInput.TabIndex = 0;
            this.txtLengthInput.TextChanged += new System.EventHandler(this.lengthAndWidth_TextChanged);
            // 
            // txtWidthInput
            // 
            this.txtWidthInput.Location = new System.Drawing.Point(95, 54);
            this.txtWidthInput.Name = "txtWidthInput";
            this.txtWidthInput.Size = new System.Drawing.Size(93, 20);
            this.txtWidthInput.TabIndex = 1;
            this.txtWidthInput.TextChanged += new System.EventHandler(this.lengthAndWidth_TextChanged);
            // 
            // txtAreaCalculate
            // 
            this.txtAreaCalculate.Location = new System.Drawing.Point(95, 85);
            this.txtAreaCalculate.Name = "txtAreaCalculate";
            this.txtAreaCalculate.ReadOnly = true;
            this.txtAreaCalculate.Size = new System.Drawing.Size(113, 20);
            this.txtAreaCalculate.TabIndex = 5;
            // 
            // txtPerimeterCalculate
            // 
            this.txtPerimeterCalculate.Location = new System.Drawing.Point(95, 115);
            this.txtPerimeterCalculate.Name = "txtPerimeterCalculate";
            this.txtPerimeterCalculate.ReadOnly = true;
            this.txtPerimeterCalculate.Size = new System.Drawing.Size(113, 20);
            this.txtPerimeterCalculate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Project 4.1 Momo Johnson";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(115, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 26);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmPerimeterandArea
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 185);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPerimeterCalculate);
            this.Controls.Add(this.txtAreaCalculate);
            this.Controls.Add(this.txtWidthInput);
            this.Controls.Add(this.txtLengthInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPerimeterandArea";
            this.Text = "Area And Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtLengthInput;
        private System.Windows.Forms.TextBox txtWidthInput;
        private System.Windows.Forms.TextBox txtAreaCalculate;
        private System.Windows.Forms.TextBox txtPerimeterCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
    }
}


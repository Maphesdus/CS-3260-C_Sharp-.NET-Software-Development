namespace Lab_03_AHA
{
    partial class Form1
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
            this.Calculate = new System.Windows.Forms.Button();
            this.Lbl_RealNumbers = new System.Windows.Forms.Label();
            this.Lbl_ImaginaryNumbers = new System.Windows.Forms.Label();
            this.Lbl_plusSign1 = new System.Windows.Forms.Label();
            this.Lbl_plusSign2 = new System.Windows.Forms.Label();
            this.Lbl_plusSign3 = new System.Windows.Forms.Label();
            this.Lbl_horizontalLine = new System.Windows.Forms.Label();
            this.Lbl_i1 = new System.Windows.Forms.Label();
            this.Lbl_i2 = new System.Windows.Forms.Label();
            this.Lbl_i3 = new System.Windows.Forms.Label();
            this.Lbl_Add = new System.Windows.Forms.Label();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.Tb_Real1 = new System.Windows.Forms.TextBox();
            this.Tb_Real2 = new System.Windows.Forms.TextBox();
            this.Tb_Imaginary1 = new System.Windows.Forms.TextBox();
            this.Tb_Imaginary2 = new System.Windows.Forms.TextBox();
            this.Tb_Real3 = new System.Windows.Forms.TextBox();
            this.Tb_Imaginary3 = new System.Windows.Forms.TextBox();
            this.Btn_RunTests = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(194, 242);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(112, 35);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Lbl_RealNumbers
            // 
            this.Lbl_RealNumbers.AutoSize = true;
            this.Lbl_RealNumbers.Location = new System.Drawing.Point(63, 58);
            this.Lbl_RealNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_RealNumbers.Name = "Lbl_RealNumbers";
            this.Lbl_RealNumbers.Size = new System.Drawing.Size(114, 20);
            this.Lbl_RealNumbers.TabIndex = 7;
            this.Lbl_RealNumbers.Text = "Real Numbers:";
            // 
            // Lbl_ImaginaryNumbers
            // 
            this.Lbl_ImaginaryNumbers.AutoSize = true;
            this.Lbl_ImaginaryNumbers.Location = new System.Drawing.Point(276, 58);
            this.Lbl_ImaginaryNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ImaginaryNumbers.Name = "Lbl_ImaginaryNumbers";
            this.Lbl_ImaginaryNumbers.Size = new System.Drawing.Size(150, 20);
            this.Lbl_ImaginaryNumbers.TabIndex = 8;
            this.Lbl_ImaginaryNumbers.Text = "Imaginary Numbers:";
            // 
            // Lbl_plusSign1
            // 
            this.Lbl_plusSign1.AutoSize = true;
            this.Lbl_plusSign1.Location = new System.Drawing.Point(238, 88);
            this.Lbl_plusSign1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_plusSign1.Name = "Lbl_plusSign1";
            this.Lbl_plusSign1.Size = new System.Drawing.Size(18, 20);
            this.Lbl_plusSign1.TabIndex = 9;
            this.Lbl_plusSign1.Text = "+";
            // 
            // Lbl_plusSign2
            // 
            this.Lbl_plusSign2.AutoSize = true;
            this.Lbl_plusSign2.Location = new System.Drawing.Point(238, 128);
            this.Lbl_plusSign2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_plusSign2.Name = "Lbl_plusSign2";
            this.Lbl_plusSign2.Size = new System.Drawing.Size(18, 20);
            this.Lbl_plusSign2.TabIndex = 10;
            this.Lbl_plusSign2.Text = "+";
            // 
            // Lbl_plusSign3
            // 
            this.Lbl_plusSign3.AutoSize = true;
            this.Lbl_plusSign3.Location = new System.Drawing.Point(238, 205);
            this.Lbl_plusSign3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_plusSign3.Name = "Lbl_plusSign3";
            this.Lbl_plusSign3.Size = new System.Drawing.Size(18, 20);
            this.Lbl_plusSign3.TabIndex = 11;
            this.Lbl_plusSign3.Text = "+";
            // 
            // Lbl_horizontalLine
            // 
            this.Lbl_horizontalLine.AutoSize = true;
            this.Lbl_horizontalLine.Location = new System.Drawing.Point(18, 162);
            this.Lbl_horizontalLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_horizontalLine.Name = "Lbl_horizontalLine";
            this.Lbl_horizontalLine.Size = new System.Drawing.Size(494, 20);
            this.Lbl_horizontalLine.TabIndex = 12;
            this.Lbl_horizontalLine.Text = "---------------------------------------------------------------------------------" +
    "----------------";
            // 
            // Lbl_i1
            // 
            this.Lbl_i1.AutoSize = true;
            this.Lbl_i1.Location = new System.Drawing.Point(441, 88);
            this.Lbl_i1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_i1.Name = "Lbl_i1";
            this.Lbl_i1.Size = new System.Drawing.Size(12, 20);
            this.Lbl_i1.TabIndex = 13;
            this.Lbl_i1.Text = "i";
            // 
            // Lbl_i2
            // 
            this.Lbl_i2.AutoSize = true;
            this.Lbl_i2.Location = new System.Drawing.Point(441, 129);
            this.Lbl_i2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_i2.Name = "Lbl_i2";
            this.Lbl_i2.Size = new System.Drawing.Size(12, 20);
            this.Lbl_i2.TabIndex = 14;
            this.Lbl_i2.Text = "i";
            // 
            // Lbl_i3
            // 
            this.Lbl_i3.AutoSize = true;
            this.Lbl_i3.Location = new System.Drawing.Point(441, 200);
            this.Lbl_i3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_i3.Name = "Lbl_i3";
            this.Lbl_i3.Size = new System.Drawing.Size(12, 20);
            this.Lbl_i3.TabIndex = 15;
            this.Lbl_i3.Text = "i";
            // 
            // Lbl_Add
            // 
            this.Lbl_Add.AutoSize = true;
            this.Lbl_Add.Location = new System.Drawing.Point(474, 162);
            this.Lbl_Add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Add.Name = "Lbl_Add";
            this.Lbl_Add.Size = new System.Drawing.Size(38, 20);
            this.Lbl_Add.TabIndex = 16;
            this.Lbl_Add.Text = "Add";
            this.Lbl_Add.Click += new System.EventHandler(this.Lbl_Add_Click);
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(522, 58);
            this.richTextBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(217, 239);
            this.richTextBox7.TabIndex = 17;
            this.richTextBox7.Text = "";
            // 
            // Tb_Real1
            // 
            this.Tb_Real1.Location = new System.Drawing.Point(68, 83);
            this.Tb_Real1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_Real1.Name = "Tb_Real1";
            this.Tb_Real1.Size = new System.Drawing.Size(148, 26);
            this.Tb_Real1.TabIndex = 18;
            this.Tb_Real1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Tb_Real2
            // 
            this.Tb_Real2.Location = new System.Drawing.Point(68, 123);
            this.Tb_Real2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_Real2.Name = "Tb_Real2";
            this.Tb_Real2.Size = new System.Drawing.Size(148, 26);
            this.Tb_Real2.TabIndex = 19;
            // 
            // Tb_Imaginary1
            // 
            this.Tb_Imaginary1.Location = new System.Drawing.Point(282, 88);
            this.Tb_Imaginary1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_Imaginary1.Name = "Tb_Imaginary1";
            this.Tb_Imaginary1.Size = new System.Drawing.Size(148, 26);
            this.Tb_Imaginary1.TabIndex = 20;
            this.Tb_Imaginary1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Tb_Imaginary2
            // 
            this.Tb_Imaginary2.Location = new System.Drawing.Point(282, 129);
            this.Tb_Imaginary2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_Imaginary2.Name = "Tb_Imaginary2";
            this.Tb_Imaginary2.Size = new System.Drawing.Size(148, 26);
            this.Tb_Imaginary2.TabIndex = 21;
            // 
            // Tb_Real3
            // 
            this.Tb_Real3.Location = new System.Drawing.Point(68, 202);
            this.Tb_Real3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_Real3.Name = "Tb_Real3";
            this.Tb_Real3.ReadOnly = true;
            this.Tb_Real3.Size = new System.Drawing.Size(148, 26);
            this.Tb_Real3.TabIndex = 22;
            // 
            // Tb_Imaginary3
            // 
            this.Tb_Imaginary3.Location = new System.Drawing.Point(282, 202);
            this.Tb_Imaginary3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_Imaginary3.Name = "Tb_Imaginary3";
            this.Tb_Imaginary3.ReadOnly = true;
            this.Tb_Imaginary3.Size = new System.Drawing.Size(148, 26);
            this.Tb_Imaginary3.TabIndex = 23;
            // 
            // Btn_RunTests
            // 
            this.Btn_RunTests.Location = new System.Drawing.Point(572, 309);
            this.Btn_RunTests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_RunTests.Name = "Btn_RunTests";
            this.Btn_RunTests.Size = new System.Drawing.Size(112, 35);
            this.Btn_RunTests.TabIndex = 24;
            this.Btn_RunTests.Text = "Run Tests";
            this.Btn_RunTests.UseVisualStyleBackColor = true;
            this.Btn_RunTests.Click += new System.EventHandler(this.Btn_RunTests_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(342, 382);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(112, 35);
            this.Btn_Exit.TabIndex = 25;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 431);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_RunTests);
            this.Controls.Add(this.Tb_Imaginary3);
            this.Controls.Add(this.Tb_Real3);
            this.Controls.Add(this.Tb_Imaginary2);
            this.Controls.Add(this.Tb_Imaginary1);
            this.Controls.Add(this.Tb_Real2);
            this.Controls.Add(this.Tb_Real1);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.Lbl_Add);
            this.Controls.Add(this.Lbl_i3);
            this.Controls.Add(this.Lbl_i2);
            this.Controls.Add(this.Lbl_i1);
            this.Controls.Add(this.Lbl_horizontalLine);
            this.Controls.Add(this.Lbl_plusSign3);
            this.Controls.Add(this.Lbl_plusSign2);
            this.Controls.Add(this.Lbl_plusSign1);
            this.Controls.Add(this.Lbl_ImaginaryNumbers);
            this.Controls.Add(this.Lbl_RealNumbers);
            this.Controls.Add(this.Calculate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Lab #3: Complex Arithmetic Calculator  -- Adam Armstrong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Lbl_RealNumbers;
        private System.Windows.Forms.Label Lbl_ImaginaryNumbers;
        private System.Windows.Forms.Label Lbl_plusSign1;
        private System.Windows.Forms.Label Lbl_plusSign2;
        private System.Windows.Forms.Label Lbl_plusSign3;
        private System.Windows.Forms.Label Lbl_horizontalLine;
        private System.Windows.Forms.Label Lbl_i1;
        private System.Windows.Forms.Label Lbl_i2;
        private System.Windows.Forms.Label Lbl_i3;
        private System.Windows.Forms.Label Lbl_Add;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.TextBox Tb_Real1;
        private System.Windows.Forms.TextBox Tb_Real2;
        private System.Windows.Forms.TextBox Tb_Imaginary1;
        private System.Windows.Forms.TextBox Tb_Imaginary2;
        private System.Windows.Forms.TextBox Tb_Real3;
        private System.Windows.Forms.TextBox Tb_Imaginary3;
        private System.Windows.Forms.Button Btn_RunTests;
        private System.Windows.Forms.Button Btn_Exit;
    }
}


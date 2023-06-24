namespace calculator_windows_form
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn7 = new Button();
            grpcalc = new GroupBox();
            txtdisplay = new TextBox();
            btndot = new Button();
            btnequal = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btnzero = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnplus = new Button();
            btndivision = new Button();
            btnmodulo = new Button();
            btnmultiply = new Button();
            btnminus = new Button();
            btn9 = new Button();
            btn8 = new Button();
            grpcalc.SuspendLayout();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.Location = new Point(35, 209);
            btn7.Name = "btn7";
            btn7.Size = new Size(83, 62);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // grpcalc
            // 
            grpcalc.BackColor = SystemColors.GradientActiveCaption;
            grpcalc.Controls.Add(txtdisplay);
            grpcalc.Controls.Add(btndot);
            grpcalc.Controls.Add(btnequal);
            grpcalc.Controls.Add(btn3);
            grpcalc.Controls.Add(btn2);
            grpcalc.Controls.Add(btnzero);
            grpcalc.Controls.Add(btn1);
            grpcalc.Controls.Add(btn6);
            grpcalc.Controls.Add(btn5);
            grpcalc.Controls.Add(btn4);
            grpcalc.Controls.Add(btnplus);
            grpcalc.Controls.Add(btndivision);
            grpcalc.Controls.Add(btnmodulo);
            grpcalc.Controls.Add(btnmultiply);
            grpcalc.Controls.Add(btnminus);
            grpcalc.Controls.Add(btn9);
            grpcalc.Controls.Add(btn8);
            grpcalc.Controls.Add(btn7);
            grpcalc.Location = new Point(221, 55);
            grpcalc.Name = "grpcalc";
            grpcalc.Size = new Size(488, 617);
            grpcalc.TabIndex = 2;
            grpcalc.TabStop = false;
            grpcalc.Text = "Calculator";
            grpcalc.Enter += grpcalc_Enter;
            // 
            // txtdisplay
            // 
            txtdisplay.Location = new Point(35, 56);
            txtdisplay.Name = "txtdisplay";
            txtdisplay.Size = new Size(407, 27);
            txtdisplay.TabIndex = 3;
            txtdisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btndot
            // 
            btndot.Location = new Point(255, 473);
            btndot.Name = "btndot";
            btndot.Size = new Size(83, 71);
            btndot.TabIndex = 17;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            // 
            // btnequal
            // 
            btnequal.Location = new Point(359, 386);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(83, 158);
            btnequal.TabIndex = 16;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(255, 386);
            btn3.Name = "btn3";
            btn3.Size = new Size(83, 65);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(147, 386);
            btn2.Name = "btn2";
            btn2.Size = new Size(83, 65);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btnzero
            // 
            btnzero.Location = new Point(35, 473);
            btnzero.Name = "btnzero";
            btnzero.Size = new Size(195, 71);
            btnzero.TabIndex = 12;
            btnzero.Text = "0";
            btnzero.UseVisualStyleBackColor = true;
            btnzero.Click += btnzero_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(35, 386);
            btn1.Name = "btn1";
            btn1.Size = new Size(83, 65);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(255, 296);
            btn6.Name = "btn6";
            btn6.Size = new Size(83, 65);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(147, 296);
            btn5.Name = "btn5";
            btn5.Size = new Size(83, 65);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(35, 296);
            btn4.Name = "btn4";
            btn4.Size = new Size(83, 65);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnplus
            // 
            btnplus.Location = new Point(359, 209);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(83, 152);
            btnplus.TabIndex = 8;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            // 
            // btndivision
            // 
            btndivision.Location = new Point(147, 117);
            btndivision.Name = "btndivision";
            btndivision.Size = new Size(83, 62);
            btndivision.TabIndex = 7;
            btndivision.Text = "/";
            btndivision.UseVisualStyleBackColor = true;
            // 
            // btnmodulo
            // 
            btnmodulo.Location = new Point(35, 117);
            btnmodulo.Name = "btnmodulo";
            btnmodulo.Size = new Size(83, 62);
            btnmodulo.TabIndex = 6;
            btnmodulo.Text = "%";
            btnmodulo.UseVisualStyleBackColor = true;
            // 
            // btnmultiply
            // 
            btnmultiply.Location = new Point(255, 117);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(83, 62);
            btnmultiply.TabIndex = 5;
            btnmultiply.Text = "*";
            btnmultiply.UseVisualStyleBackColor = true;
            // 
            // btnminus
            // 
            btnminus.Location = new Point(359, 117);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(83, 62);
            btnminus.TabIndex = 4;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(255, 209);
            btn9.Name = "btn9";
            btn9.Size = new Size(83, 62);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(147, 209);
            btn8.Name = "btn8";
            btn8.Size = new Size(83, 62);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 684);
            Controls.Add(grpcalc);
            Name = "Calculator";
            Text = "Form1";
            grpcalc.ResumeLayout(false);
            grpcalc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn7;
        private ComboBox comboBox1;
        private GroupBox grpcalc;
        private Button btnequal;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnzero;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnplus;
        private Button btndivision;
        private Button btnmodulo;
        private Button btnmultiply;
        private Button btnminus;
        private Button btn9;
        private Button btn8;
        private Button btndot;
        private TextBox txtdisplay;
    }
}
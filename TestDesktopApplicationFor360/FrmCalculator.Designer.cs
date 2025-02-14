namespace TestDesktopApplicationFor360
{
    partial class FrmCalculator
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
            btnCalculate = new Button();
            label1 = new Label();
            txtVal1 = new TextBox();
            txtVal2 = new TextBox();
            label2 = new Label();
            btnDivision = new Button();
            btnSubtract = new Button();
            btnMulti = new Button();
            label3 = new Label();
            label4 = new Label();
            resultBox = new TextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(52, 179);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Addition";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnAddition_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 53);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 1;
            label1.Text = "Please Input First Number :";
            // 
            // txtVal1
            // 
            txtVal1.Location = new Point(253, 43);
            txtVal1.Name = "txtVal1";
            txtVal1.Size = new Size(100, 23);
            txtVal1.TabIndex = 2;
            txtVal1.Click += txtVal1_Click;
            // 
            // txtVal2
            // 
            txtVal2.Location = new Point(253, 103);
            txtVal2.Name = "txtVal2";
            txtVal2.Size = new Size(100, 23);
            txtVal2.TabIndex = 3;
            txtVal2.Click += txtVal2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 106);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 4;
            label2.Text = "Please Input Second Number :";
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(365, 179);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(75, 23);
            btnDivision.TabIndex = 5;
            btnDivision.Text = "Division";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(146, 179);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(90, 23);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "Subtraction";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(253, 179);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(100, 23);
            btnMulti.TabIndex = 5;
            btnMulti.Text = "Multiplication";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 148);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 1;
            label3.Text = "Choose your Operation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(97, 212);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 1;
            label4.Text = "Result";
            // 
            // resultBox
            // 
            resultBox.BackColor = SystemColors.Control;
            resultBox.BorderStyle = BorderStyle.FixedSingle;
            resultBox.Enabled = false;
            resultBox.Font = new Font("Segoe UI", 12F);
            resultBox.Location = new Point(194, 212);
            resultBox.Name = "resultBox";
            resultBox.ReadOnly = true;
            resultBox.Size = new Size(100, 29);
            resultBox.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(325, 214);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 25);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 272);
            Controls.Add(btnClear);
            Controls.Add(btnMulti);
            Controls.Add(btnSubtract);
            Controls.Add(btnDivision);
            Controls.Add(label2);
            Controls.Add(resultBox);
            Controls.Add(txtVal2);
            Controls.Add(txtVal1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Name = "FrmCalculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label label1;
        private TextBox txtVal1;
        private TextBox txtVal2;
        private Label label2;
        private Button btnDivision;
        private Button btnSubtract;
        private Button btnMulti;
        private Label label3;
        private Label label4;
        private TextBox resultBox;
        private Button btnClear;
    }
}
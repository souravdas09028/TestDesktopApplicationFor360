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
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(318, 196);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(86, 31);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 71);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 1;
            label1.Text = "Please Input First Number :";
            // 
            // txtVal1
            // 
            txtVal1.Location = new Point(289, 57);
            txtVal1.Margin = new Padding(3, 4, 3, 4);
            txtVal1.Name = "txtVal1";
            txtVal1.Size = new Size(114, 27);
            txtVal1.TabIndex = 2;
            // 
            // txtVal2
            // 
            txtVal2.Location = new Point(289, 137);
            txtVal2.Margin = new Padding(3, 4, 3, 4);
            txtVal2.Name = "txtVal2";
            txtVal2.Size = new Size(114, 27);
            txtVal2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 144);
            label2.Name = "label2";
            label2.Size = new Size(207, 20);
            label2.TabIndex = 4;
            label2.Text = "Please Input Second Number :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 27);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 110);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 6;
            label3.Text = "Please input Oparation :";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 346);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtVal2);
            Controls.Add(txtVal1);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox textBox1;
        private Label label3;
    }
}
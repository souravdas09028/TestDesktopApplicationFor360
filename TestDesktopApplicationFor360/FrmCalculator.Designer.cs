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
            label3 = new Label();
            txtOperator = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(314, 220);
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
            label1.Location = new Point(60, 75);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 1;
            label1.Text = "Please Input First Number :";
            // 
            // txtVal1
            // 
            txtVal1.Location = new Point(286, 68);
            txtVal1.Margin = new Padding(3, 4, 3, 4);
            txtVal1.Name = "txtVal1";
            txtVal1.Size = new Size(114, 27);
            txtVal1.TabIndex = 2;
            // 
            // txtVal2
            // 
            txtVal2.Location = new Point(286, 167);
            txtVal2.Margin = new Padding(3, 4, 3, 4);
            txtVal2.Name = "txtVal2";
            txtVal2.Size = new Size(114, 27);
            txtVal2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 174);
            label2.Name = "label2";
            label2.Size = new Size(207, 20);
            label2.TabIndex = 4;
            label2.Text = "Please Input Second Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 122);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 5;
            label3.Text = "Please Input Operator :";
            label3.Click += label3_Click;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(286, 115);
            txtOperator.Margin = new Padding(3, 4, 3, 4);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(114, 27);
            txtOperator.TabIndex = 2;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 264);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtVal2);
            Controls.Add(txtOperator);
            Controls.Add(txtVal1);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCalculator";
            Text = "Calculator";
            Load += FrmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label label1;
        private TextBox txtVal1;
        private TextBox txtVal2;
        private Label label2;
        private Label label3;
        private TextBox txtOperator;
    }
}
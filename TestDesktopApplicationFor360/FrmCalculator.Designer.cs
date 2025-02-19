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
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(278, 147);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
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
            // 
            // txtVal2
            // 
            txtVal2.Location = new Point(253, 103);
            txtVal2.Name = "txtVal2";
            txtVal2.Size = new Size(100, 23);
            txtVal2.TabIndex = 3;
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
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 198);
            Controls.Add(label2);
            Controls.Add(txtVal2);
            Controls.Add(txtVal1);
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
    }
}
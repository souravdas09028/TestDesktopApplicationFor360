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
            labelEnterNum = new Label();
            txtNumInput = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMulti = new Button();
            btnDivision = new Button();
            btnClear = new Button();
            btnCalculation = new Button();
            label1 = new Label();
            resultBox = new TextBox();
            label2 = new Label();
            btnHistory = new Button();
            btnSqrRoot = new Button();
            SuspendLayout();
            // 
            // labelEnterNum
            // 
            labelEnterNum.AutoSize = true;
            labelEnterNum.Location = new Point(3, 18);
            labelEnterNum.Name = "labelEnterNum";
            labelEnterNum.Size = new Size(81, 15);
            labelEnterNum.TabIndex = 0;
            labelEnterNum.Text = "Enter Number";
            // 
            // txtNumInput
            // 
            txtNumInput.Location = new Point(83, 15);
            txtNumInput.Name = "txtNumInput";
            txtNumInput.Size = new Size(142, 23);
            txtNumInput.TabIndex = 1;
            txtNumInput.Click += txtNumInput_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10F);
            btnAdd.Location = new Point(74, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(26, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 10F);
            btnSubtract.Location = new Point(106, 47);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(26, 23);
            btnSubtract.TabIndex = 2;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 10F);
            btnMulti.Location = new Point(138, 47);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(26, 23);
            btnMulti.TabIndex = 2;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Segoe UI", 10F);
            btnDivision.Location = new Point(170, 47);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(26, 23);
            btnDivision.TabIndex = 2;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(231, 15);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(26, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculation
            // 
            btnCalculation.Location = new Point(231, 48);
            btnCalculation.Name = "btnCalculation";
            btnCalculation.Size = new Size(26, 23);
            btnCalculation.TabIndex = 4;
            btnCalculation.Text = "=";
            btnCalculation.UseVisualStyleBackColor = true;
            btnCalculation.Click += btnCalculation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 83);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Result";
            // 
            // resultBox
            // 
            resultBox.BackColor = SystemColors.ScrollBar;
            resultBox.BorderStyle = BorderStyle.FixedSingle;
            resultBox.Enabled = false;
            resultBox.Location = new Point(74, 83);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(151, 23);
            resultBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Operator";
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(231, 83);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(26, 23);
            btnHistory.TabIndex = 8;
            btnHistory.Text = "H";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnSqrRoot
            // 
            btnSqrRoot.Location = new Point(202, 47);
            btnSqrRoot.Name = "btnSqrRoot";
            btnSqrRoot.Size = new Size(26, 23);
            btnSqrRoot.TabIndex = 9;
            btnSqrRoot.Text = "√";
            btnSqrRoot.UseVisualStyleBackColor = true;
            btnSqrRoot.Click += btnSqrRoot_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 123);
            Controls.Add(btnSqrRoot);
            Controls.Add(btnHistory);
            Controls.Add(label2);
            Controls.Add(resultBox);
            Controls.Add(label1);
            Controls.Add(btnCalculation);
            Controls.Add(btnClear);
            Controls.Add(btnDivision);
            Controls.Add(btnMulti);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtNumInput);
            Controls.Add(labelEnterNum);
            Name = "FrmCalculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEnterNum;
        private TextBox txtNumInput;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMulti;
        private Button btnDivision;
        private Button btnClear;
        private Button btnCalculation;
        private Label label1;
        private TextBox resultBox;
        private Label label2;
        private Button btnHistory;
        private Button btnSqrRoot;
    }
}
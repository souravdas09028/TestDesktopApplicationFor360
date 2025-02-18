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
            txtVal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnC = new Button();
            btnAdd = new Button();
            btnSubt = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnRoot = new Button();
            btnSq = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(97, 274);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(117, 50);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtVal
            // 
            txtVal.Location = new Point(29, 13);
            txtVal.Margin = new Padding(3, 4, 3, 4);
            txtVal.Multiline = true;
            txtVal.Name = "txtVal";
            txtVal.Size = new Size(322, 35);
            txtVal.TabIndex = 2;
            txtVal.TextChanged += txtVal_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(29, 78);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(98, 78);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(164, 78);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(29, 144);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(98, 144);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 3;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(164, 144);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 3;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(29, 209);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(98, 209);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(164, 209);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(29, 274);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 50);
            btn0.TabIndex = 3;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(301, 78);
            btnC.Name = "btnC";
            btnC.Size = new Size(50, 50);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(233, 78);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 50);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnSubt
            // 
            btnSubt.Location = new Point(233, 144);
            btnSubt.Name = "btnSubt";
            btnSubt.Size = new Size(50, 50);
            btnSubt.TabIndex = 3;
            btnSubt.Text = "-";
            btnSubt.UseVisualStyleBackColor = true;
            btnSubt.Click += btnSubt_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(233, 209);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(50, 50);
            btnMult.TabIndex = 3;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(233, 274);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(50, 50);
            btnDiv.TabIndex = 3;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnRoot
            // 
            btnRoot.Location = new Point(301, 144);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(50, 50);
            btnRoot.TabIndex = 3;
            btnRoot.Text = "√";
            btnRoot.UseVisualStyleBackColor = true;
            btnRoot.Click += btnRoot_Click;
            // 
            // btnSq
            // 
            btnSq.Location = new Point(301, 209);
            btnSq.Name = "btnSq";
            btnSq.Size = new Size(50, 50);
            btnSq.TabIndex = 3;
            btnSq.Text = "²";
            btnSq.UseVisualStyleBackColor = true;
            btnSq.Click += btnSq_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 356);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSubt);
            Controls.Add(btnAdd);
            Controls.Add(btnSq);
            Controls.Add(btnRoot);
            Controls.Add(btnC);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtVal);
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
    
        private TextBox txtVal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnC;
        private Button btnAdd;
        private Button btnSubt;
        private Button btnMult;
        private Button btnDiv;
        private Button btnRoot;
        private Button btnSq;
    }
}
namespace calculate_letter_grade
{
    partial class CalculateLetterGrade
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
            label1 = new Label();
            txtNumbericGrade = new TextBox();
            txtLetterGrade = new TextBox();
            label2 = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Numeric Grade";
            // 
            // txtNumbericGrade
            // 
            txtNumbericGrade.Location = new Point(149, 37);
            txtNumbericGrade.Name = "txtNumbericGrade";
            txtNumbericGrade.Size = new Size(124, 23);
            txtNumbericGrade.TabIndex = 1;
            // 
            // txtLetterGrade
            // 
            txtLetterGrade.Location = new Point(149, 95);
            txtLetterGrade.Name = "txtLetterGrade";
            txtLetterGrade.Size = new Size(124, 23);
            txtLetterGrade.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Location = new Point(30, 103);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Letter Grade";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(24, 182);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(93, 48);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "&Calculate letter grade";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(180, 182);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 48);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(285, 272);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(txtLetterGrade);
            Controls.Add(txtNumbericGrade);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculate Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumbericGrade;
        private TextBox txtLetterGrade;
        private Label label2;
        private Button btnCalculate;
        private Button btnExit;
    }
}

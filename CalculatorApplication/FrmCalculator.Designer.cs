namespace CalculatorApplication
{
    partial class FrmCalculator
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
            label2 = new Label();
            label3 = new Label();
            TextBoxInput1 = new TextBox();
            TextBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            lblDisplayTotal = new Label();
            panel1 = new Panel();
            btnEqual = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 30);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter first number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 92);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter second number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 131);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Answer:";
            // 
            // TextBoxInput1
            // 
            TextBoxInput1.Location = new Point(132, 30);
            TextBoxInput1.Name = "TextBoxInput1";
            TextBoxInput1.Size = new Size(100, 23);
            TextBoxInput1.TabIndex = 3;
            // 
            // TextBoxInput2
            // 
            TextBoxInput2.Location = new Point(132, 92);
            TextBoxInput2.Name = "TextBoxInput2";
            TextBoxInput2.Size = new Size(100, 23);
            TextBoxInput2.TabIndex = 4;
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(158, 61);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(47, 23);
            cbOperator.TabIndex = 5;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(77, 131);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(74, 15);
            lblDisplayTotal.TabIndex = 6;
            lblDisplayTotal.Text = "AnswerLabel";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEqual);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblDisplayTotal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbOperator);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TextBoxInput2);
            panel1.Controls.Add(TextBoxInput1);
            panel1.Location = new Point(267, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 245);
            panel1.TabIndex = 7;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(78, 215);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(85, 23);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "CALCULATE";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(77, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(122, 10);
            panel2.TabIndex = 7;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmCalculator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextBoxInput1;
        private TextBox TextBoxInput2;
        private ComboBox cbOperator;
        private Label lblDisplayTotal;
        private Panel panel1;
        private Button btnEqual;
        private Panel panel2;
    }
}

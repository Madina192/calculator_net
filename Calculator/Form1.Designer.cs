namespace Calculator
{
    partial class Form1
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(52, 323);
            button1.Name = "button1";
            button1.Size = new Size(73, 67);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += add;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(517, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(52, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(517, 31);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 6;
            label1.Text = "First number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 158);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 7;
            label2.Text = "Second number";
            // 
            // button5
            // 
            button5.Location = new Point(348, 323);
            button5.Name = "button5";
            button5.Size = new Size(73, 67);
            button5.TabIndex = 8;
            button5.Text = "*";
            button5.UseVisualStyleBackColor = true;
            button5.Click += multiply;
            // 
            // button6
            // 
            button6.Location = new Point(198, 323);
            button6.Name = "button6";
            button6.Size = new Size(73, 67);
            button6.TabIndex = 9;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            button6.Click += subtract;
            // 
            // button7
            // 
            button7.Location = new Point(496, 323);
            button7.Name = "button7";
            button7.Size = new Size(73, 67);
            button7.TabIndex = 10;
            button7.Text = "/";
            button7.UseVisualStyleBackColor = true;
            button7.Click += divide;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 436);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 11;
            label3.Text = "Result";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(52, 482);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(517, 31);
            textBox3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 604);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label3;
        private TextBox textBox3;
    }
}
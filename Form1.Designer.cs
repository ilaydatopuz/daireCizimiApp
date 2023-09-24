namespace daireÇizimiApp
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
            label1 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 52);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter the radius";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(97, 111);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(351, 195);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(346, 52);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}
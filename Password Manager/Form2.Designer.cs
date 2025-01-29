namespace Password_Manager
{
    partial class Form2
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
            label1 = new Label();
            button4 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 65);
            label1.TabIndex = 0;
            label1.Text = "Welcome ";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(7, 406);
            button4.Name = "button4";
            button4.Size = new Size(175, 32);
            button4.TabIndex = 1;
            button4.Text = "Retrieve Passwords";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(705, 407);
            button1.Name = "button1";
            button1.Size = new Size(96, 44);
            button1.TabIndex = 2;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(201, 38);
            label2.TabIndex = 3;
            label2.Text = "Add Password";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 31);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 184);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 6;
            label3.Text = "Add Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 237);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 7;
            label4.Text = "Add Password";
            // 
            // button2
            // 
            button2.Location = new Point(192, 268);
            button2.Name = "button2";
            button2.Size = new Size(88, 32);
            button2.TabIndex = 8;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Passwords";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}
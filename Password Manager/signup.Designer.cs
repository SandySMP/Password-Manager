namespace Password_Manager
{
    partial class signup
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
            label2 = new Label();
            label3 = new Label();
            txtusername = new TextBox();
            textpassword = new TextBox();
            textconfirmpassword = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 185);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 224);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 257);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            label3.Click += label3_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(286, 185);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(197, 27);
            txtusername.TabIndex = 3;
            txtusername.TextChanged += textBox1_TextChanged;
            // 
            // textpassword
            // 
            textpassword.Location = new Point(286, 217);
            textpassword.Name = "textpassword";
            textpassword.Size = new Size(197, 27);
            textpassword.TabIndex = 4;
            // 
            // textconfirmpassword
            // 
            textconfirmpassword.Location = new Point(286, 250);
            textconfirmpassword.Name = "textconfirmpassword";
            textconfirmpassword.Size = new Size(197, 27);
            textconfirmpassword.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            label5.Location = new Point(215, 20);
            label5.Name = "label5";
            label5.Size = new Size(195, 54);
            label5.TabIndex = 6;
            label5.Text = "Sign Up";
            label5.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(286, 299);
            button1.Name = "button1";
            button1.Size = new Size(82, 29);
            button1.TabIndex = 7;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(385, 299);
            button2.Name = "button2";
            button2.Size = new Size(82, 29);
            button2.TabIndex = 8;
            button2.Text = "Log in";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(290, 279);
            label4.Name = "label4";
            label4.Size = new Size(176, 20);
            label4.TabIndex = 9;
            label4.Text = "Passwords need to match";
            label4.Click += label4_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(546, 421);
            button3.Name = "button3";
            button3.Size = new Size(79, 29);
            button3.TabIndex = 10;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 450);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textconfirmpassword);
            Controls.Add(textpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signup";
            Text = "signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusername;
        private TextBox textpassword;
        private TextBox textconfirmpassword;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label4;
        private Button button3;
    }
}
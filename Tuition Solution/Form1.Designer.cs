namespace Tuition_Solution
{
    partial class Form1
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
            checkBox1 = new CheckBox();
            passbox = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            userbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(255, 328);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 36);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // passbox
            // 
            passbox.Location = new Point(193, 226);
            passbox.Multiline = true;
            passbox.Name = "passbox";
            passbox.Size = new Size(198, 45);
            passbox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Jun_12__2025__01_49_43_AM;
            pictureBox1.Location = new Point(486, -46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 645);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(7, 21);
            label3.Name = "label3";
            label3.Size = new Size(375, 45);
            label3.TabIndex = 17;
            label3.Text = "Welcome Back :)";
            // 
            // linkLabel2
            // 
            linkLabel2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Green;
            linkLabel2.Location = new Point(39, 510);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(343, 50);
            linkLabel2.TabIndex = 16;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create a New Account ?";
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(-20, 329);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(211, 36);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password ?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(80, 418);
            button1.Name = "button1";
            button1.Size = new Size(223, 50);
            button1.TabIndex = 14;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // userbox
            // 
            userbox.Location = new Point(193, 137);
            userbox.Multiline = true;
            userbox.Name = "userbox";
            userbox.Size = new Size(198, 42);
            userbox.TabIndex = 12;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(-20, 229);
            label2.Name = "label2";
            label2.Size = new Size(170, 42);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(-20, 137);
            label1.Name = "label1";
            label1.Size = new Size(170, 42);
            label1.TabIndex = 10;
            label1.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 664);
            Controls.Add(checkBox1);
            Controls.Add(passbox);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(userbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private TextBox passbox;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox userbox;
        private Label label2;
        private Label label1;
    }
}
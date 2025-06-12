namespace Tuition_Solution
{
    partial class Login
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
            userbox = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            passbox = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(37, 183);
            label1.Name = "label1";
            label1.Size = new Size(170, 42);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(37, 275);
            label2.Name = "label2";
            label2.Size = new Size(170, 42);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // userbox
            // 
            userbox.Location = new Point(250, 183);
            userbox.Multiline = true;
            userbox.Name = "userbox";
            userbox.Size = new Size(198, 42);
            userbox.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(137, 464);
            button1.Name = "button1";
            button1.Size = new Size(223, 50);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(37, 375);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(211, 36);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password ?";
            // 
            // linkLabel2
            // 
            linkLabel2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Green;
            linkLabel2.Location = new Point(96, 556);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(343, 50);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create a New Account ?";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(64, 67);
            label3.Name = "label3";
            label3.Size = new Size(375, 45);
            label3.TabIndex = 7;
            label3.Text = "Welcome Back :)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Jun_12__2025__01_49_43_AM;
            pictureBox1.Location = new Point(543, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 645);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // passbox
            // 
            passbox.Location = new Point(250, 272);
            passbox.Multiline = true;
            passbox.Name = "passbox";
            passbox.Size = new Size(198, 45);
            passbox.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(312, 374);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 36);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1018, 644);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userbox;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox passbox;
        private CheckBox checkBox1;
    }
}

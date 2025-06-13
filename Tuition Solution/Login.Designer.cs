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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            userbox = new TextBox();
            passbox = new TextBox();
            button2 = new Button();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            radioButton1 = new RadioButton();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(153, 136);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(153, 216);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // userbox
            // 
            userbox.Location = new Point(265, 133);
            userbox.Margin = new Padding(2);
            userbox.Multiline = true;
            userbox.Name = "userbox";
            userbox.Size = new Size(206, 34);
            userbox.TabIndex = 2;
            // 
            // passbox
            // 
            passbox.Location = new Point(265, 213);
            passbox.Margin = new Padding(2);
            passbox.Multiline = true;
            passbox.Name = "passbox";
            passbox.Size = new Size(206, 36);
            passbox.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(212, 316);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(122, 35);
            button2.TabIndex = 5;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += login_bt_click;
            // 
            // linkLabel2
            // 
            linkLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Green;
            linkLabel2.Location = new Point(216, 386);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(255, 52);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create a Account";
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(192, 0, 0);
            linkLabel1.Location = new Point(153, 275);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(255, 52);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(348, 280);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(146, 25);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Show Password";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(175, 77);
            label3.Name = "label3";
            label3.Size = new Size(188, 32);
            label3.TabIndex = 10;
            label3.Text = "Welcome Back ;)";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(625, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(354, 517);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(393, 11);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 34);
            textBox1.TabIndex = 13;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 520);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(radioButton1);
            Controls.Add(linkLabel1);
            Controls.Add(linkLabel2);
            Controls.Add(button2);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userbox;
        private TextBox passbox;
        private Button button2;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private RadioButton radioButton1;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox textBox1;
    }
}

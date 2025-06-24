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
            button2 = new Button();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            show_pass = new CheckBox();
            textBox1 = new TextBox();
            login_panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            login_panel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(36, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(36, 160);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // userbox
            // 
            userbox.BackColor = Color.WhiteSmoke;
            userbox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userbox.Location = new Point(148, 77);
            userbox.Margin = new Padding(2);
            userbox.Multiline = true;
            userbox.Name = "userbox";
            userbox.Size = new Size(206, 34);
            userbox.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(124, 262);
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
            linkLabel2.Location = new Point(113, 317);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(255, 52);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create a Account";
            linkLabel2.Click += create_click;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(192, 0, 0);
            linkLabel1.Location = new Point(36, 219);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(255, 52);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            linkLabel1.Click += forgot_click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(58, 21);
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
            // show_pass
            // 
            show_pass.AutoSize = true;
            show_pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            show_pass.ForeColor = Color.White;
            show_pass.Location = new Point(207, 219);
            show_pass.Name = "show_pass";
            show_pass.Size = new Size(147, 25);
            show_pass.TabIndex = 13;
            show_pass.Text = "Show Password";
            show_pass.UseVisualStyleBackColor = true;
            show_pass.CheckedChanged += show_pass_click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(148, 151);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 34);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += passbox_click;
            // 
            // login_panel
            // 
            login_panel.BackColor = Color.FromArgb(40, 42, 52);
            login_panel.Controls.Add(label3);
            login_panel.Controls.Add(textBox1);
            login_panel.Controls.Add(label1);
            login_panel.Controls.Add(show_pass);
            login_panel.Controls.Add(label2);
            login_panel.Controls.Add(userbox);
            login_panel.Controls.Add(button2);
            login_panel.Controls.Add(linkLabel1);
            login_panel.Controls.Add(linkLabel2);
            login_panel.Location = new Point(97, 62);
            login_panel.Name = "login_panel";
            login_panel.Size = new Size(396, 402);
            login_panel.TabIndex = 15;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(981, 520);
            Controls.Add(login_panel);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            login_panel.ResumeLayout(false);
            login_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userbox;
        private Button button2;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label3;
        private PictureBox pictureBox2;
        private CheckBox show_pass;
        private TextBox textBox1;
        private Panel login_panel;
    }
}

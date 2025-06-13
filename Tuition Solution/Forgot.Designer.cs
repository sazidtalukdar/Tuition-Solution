namespace Tuition_Solution
{
    partial class Forgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot));
            fbox1 = new TextBox();
            fbox2 = new TextBox();
            fbox3 = new TextBox();
            search = new Button();
            regester = new Button();
            label1 = new Label();
            welcome = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fbox1
            // 
            fbox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fbox1.Location = new Point(227, 147);
            fbox1.Multiline = true;
            fbox1.Name = "fbox1";
            fbox1.Size = new Size(260, 37);
            fbox1.TabIndex = 0;
            // 
            // fbox2
            // 
            fbox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fbox2.Location = new Point(227, 206);
            fbox2.Multiline = true;
            fbox2.Name = "fbox2";
            fbox2.Size = new Size(260, 38);
            fbox2.TabIndex = 1;
            // 
            // fbox3
            // 
            fbox3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fbox3.Location = new Point(227, 270);
            fbox3.Multiline = true;
            fbox3.Name = "fbox3";
            fbox3.Size = new Size(260, 37);
            fbox3.TabIndex = 2;
            // 
            // search
            // 
            search.BackColor = Color.Blue;
            search.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.ForeColor = Color.White;
            search.Location = new Point(298, 260);
            search.Name = "search";
            search.Size = new Size(121, 41);
            search.TabIndex = 3;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // regester
            // 
            regester.BackColor = Color.FromArgb(192, 0, 0);
            regester.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            regester.ForeColor = Color.White;
            regester.Location = new Point(298, 342);
            regester.Name = "regester";
            regester.Size = new Size(121, 39);
            regester.TabIndex = 4;
            regester.Text = "Submit";
            regester.UseVisualStyleBackColor = false;
            regester.Click += register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 162);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 5;
            label1.Text = "Input Phone Number";
            // 
            // welcome
            // 
            welcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome.ForeColor = Color.Red;
            welcome.Location = new Point(77, 66);
            welcome.Name = "welcome";
            welcome.Size = new Size(342, 42);
            welcome.TabIndex = 6;
            welcome.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(627, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 517);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(33, 159);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 8;
            label3.Text = "Otp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(33, 219);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(33, 276);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 10;
            label5.Text = "Confirm Password";
            // 
            // linkLabel2
            // 
            linkLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Green;
            linkLabel2.Location = new Point(258, 422);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(255, 52);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Back to Login";
            linkLabel2.Click += back_login_click;
            // 
            // Forgot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 520);
            Controls.Add(linkLabel2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(welcome);
            Controls.Add(label1);
            Controls.Add(regester);
            Controls.Add(search);
            Controls.Add(fbox3);
            Controls.Add(fbox2);
            Controls.Add(fbox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "Forgot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot";
            Load += Forgot_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fbox1;
        private TextBox fbox2;
        private TextBox fbox3;
        private Button search;
        private Button regester;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label welcome;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel2;
    }
}
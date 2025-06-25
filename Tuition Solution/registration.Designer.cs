namespace Tuition_Solution
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            pictureBox1 = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            gender = new GroupBox();
            gender_male = new RadioButton();
            gender_female = new RadioButton();
            usernamebox = new TextBox();
            return_bt = new LinkLabel();
            label8 = new Label();
            singup_bt = new Button();
            confirmpassbox = new TextBox();
            label7 = new Label();
            passbox = new TextBox();
            label6 = new Label();
            phonebox = new TextBox();
            label4 = new Label();
            nmaebox = new TextBox();
            label3 = new Label();
            role_teacher = new RadioButton();
            role_student = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            gender.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 517);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label9.Location = new Point(59, 164);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 21;
            label9.Text = "Username :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255, 255);
            panel1.Controls.Add(gender);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(usernamebox);
            panel1.Controls.Add(return_bt);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(singup_bt);
            panel1.Controls.Add(confirmpassbox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(passbox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(phonebox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(nmaebox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(role_teacher);
            panel1.Controls.Add(role_student);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 7.8F);
            panel1.Location = new Point(428, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 516);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // gender
            // 
            gender.Controls.Add(gender_male);
            gender.Controls.Add(gender_female);
            gender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender.Location = new Point(61, 277);
            gender.Name = "gender";
            gender.Size = new Size(375, 40);
            gender.TabIndex = 22;
            gender.TabStop = false;
            gender.Text = "Gender";
            // 
            // gender_male
            // 
            gender_male.AutoSize = true;
            gender_male.BackColor = Color.Transparent;
            gender_male.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            gender_male.Location = new Point(116, 16);
            gender_male.Margin = new Padding(2);
            gender_male.Name = "gender_male";
            gender_male.Size = new Size(61, 24);
            gender_male.TabIndex = 9;
            gender_male.TabStop = true;
            gender_male.Text = "Male";
            gender_male.UseVisualStyleBackColor = false;
            // 
            // gender_female
            // 
            gender_female.AutoSize = true;
            gender_female.BackColor = Color.Transparent;
            gender_female.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            gender_female.Location = new Point(216, 16);
            gender_female.Margin = new Padding(2);
            gender_female.Name = "gender_female";
            gender_female.Size = new Size(76, 24);
            gender_female.TabIndex = 10;
            gender_female.TabStop = true;
            gender_female.Text = "Female";
            gender_female.UseVisualStyleBackColor = false;
            // 
            // usernamebox
            // 
            usernamebox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            usernamebox.Location = new Point(66, 186);
            usernamebox.Margin = new Padding(2);
            usernamebox.Multiline = true;
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(370, 30);
            usernamebox.TabIndex = 20;
            // 
            // return_bt
            // 
            return_bt.AutoSize = true;
            return_bt.BackColor = Color.Transparent;
            return_bt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            return_bt.LinkColor = Color.FromArgb(28, 127, 168);
            return_bt.Location = new Point(234, 491);
            return_bt.Name = "return_bt";
            return_bt.Size = new Size(58, 15);
            return_bt.TabIndex = 19;
            return_bt.TabStop = true;
            return_bt.Text = "Click here";
            return_bt.Click += returnbt_click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(73, 488);
            label8.Name = "label8";
            label8.Size = new Size(165, 19);
            label8.TabIndex = 18;
            label8.Text = "Already have an account?";
            // 
            // singup_bt
            // 
            singup_bt.BackColor = Color.FromArgb(28, 127, 168);
            singup_bt.Font = new Font("Segoe UI", 10.2F);
            singup_bt.ForeColor = SystemColors.ButtonHighlight;
            singup_bt.Location = new Point(66, 453);
            singup_bt.Name = "singup_bt";
            singup_bt.Size = new Size(370, 32);
            singup_bt.TabIndex = 17;
            singup_bt.Text = "Sign Up";
            singup_bt.UseVisualStyleBackColor = false;
            singup_bt.Click += singup_Click;
            // 
            // confirmpassbox
            // 
            confirmpassbox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            confirmpassbox.Location = new Point(66, 413);
            confirmpassbox.Margin = new Padding(2);
            confirmpassbox.Multiline = true;
            confirmpassbox.Name = "confirmpassbox";
            confirmpassbox.PasswordChar = '*';
            confirmpassbox.Size = new Size(370, 30);
            confirmpassbox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label7.Location = new Point(59, 394);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(140, 20);
            label7.TabIndex = 14;
            label7.Text = "Confirm Password :";
            // 
            // passbox
            // 
            passbox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            passbox.Location = new Point(66, 339);
            passbox.Margin = new Padding(2);
            passbox.Multiline = true;
            passbox.Name = "passbox";
            passbox.PasswordChar = '*';
            passbox.Size = new Size(370, 30);
            passbox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label6.Location = new Point(59, 320);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 11;
            label6.Text = "Password :";
            // 
            // phonebox
            // 
            phonebox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            phonebox.Location = new Point(66, 240);
            phonebox.Margin = new Padding(2);
            phonebox.Multiline = true;
            phonebox.Name = "phonebox";
            phonebox.Size = new Size(370, 30);
            phonebox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(59, 218);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 6;
            label4.Text = "Phone Number :";
            // 
            // nmaebox
            // 
            nmaebox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            nmaebox.Location = new Point(66, 129);
            nmaebox.Margin = new Padding(2);
            nmaebox.Multiline = true;
            nmaebox.Name = "nmaebox";
            nmaebox.Size = new Size(370, 30);
            nmaebox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(59, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Full Name :";
            // 
            // role_teacher
            // 
            role_teacher.AutoSize = true;
            role_teacher.BackColor = Color.Transparent;
            role_teacher.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            role_teacher.Location = new Point(194, 84);
            role_teacher.Margin = new Padding(2);
            role_teacher.Name = "role_teacher";
            role_teacher.Size = new Size(93, 24);
            role_teacher.TabIndex = 3;
            role_teacher.TabStop = true;
            role_teacher.Text = "STUDENT";
            role_teacher.UseVisualStyleBackColor = false;
            // 
            // role_student
            // 
            role_student.AutoSize = true;
            role_student.BackColor = Color.Transparent;
            role_student.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            role_student.Location = new Point(94, 84);
            role_student.Margin = new Padding(2);
            role_student.Name = "role_student";
            role_student.Size = new Size(90, 24);
            role_student.TabIndex = 2;
            role_student.TabStop = true;
            role_student.Text = "TEACHER";
            role_student.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Registering AS :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(2, 136, 209);
            label1.Location = new Point(141, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(981, 520);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registration";
            FormClosed += registration_FormClosed;
            Load += registration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gender.ResumeLayout(false);
            gender.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label9;
        private Panel panel1;
        private TextBox usernamebox;
        private LinkLabel return_bt;
        private Label label8;
        private Button singup_bt;
        private TextBox confirmpassbox;
        private Label label7;
        private TextBox passbox;
        private Label label6;
        private RadioButton gender_female;
        private RadioButton gender_male;
        private Label label5;
        private TextBox phonebox;
        private Label label4;
        private TextBox nmaebox;
        private Label label3;
        private RadioButton role_teacher;
        private RadioButton role_student;
        private Label label2;
        private Label label1;
        private GroupBox gender;
    }
}
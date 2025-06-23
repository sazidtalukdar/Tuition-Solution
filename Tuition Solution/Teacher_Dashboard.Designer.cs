namespace Tuition_Solution
{
    partial class Teacher_Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label6 = new Label();
            qualification_box_user = new RichTextBox();
            allocation = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            namebox_user = new RichTextBox();
            update = new Button();
            delete_account = new LinkLabel();
            logout = new Button();
            change_pass = new LinkLabel();
            addressbox_user = new RichTextBox();
            emailbox_user = new RichTextBox();
            phonebox_user = new RichTextBox();
            panel1 = new Panel();
            subject_box = new RichTextBox();
            label7 = new Label();
            time_student = new RichTextBox();
            salary_for_teacher = new RichTextBox();
            name_teacher = new RichTextBox();
            name_l = new Label();
            label1 = new Label();
            address_teacher = new RichTextBox();
            searchbox = new RichTextBox();
            accept_bt = new Button();
            adress_l = new Label();
            salary = new Label();
            phone_teacher = new RichTextBox();
            phone_l = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Location = new Point(289, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.Size = new Size(835, 267);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(qualification_box_user);
            panel3.Controls.Add(allocation);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(namebox_user);
            panel3.Controls.Add(update);
            panel3.Controls.Add(delete_account);
            panel3.Controls.Add(logout);
            panel3.Controls.Add(change_pass);
            panel3.Controls.Add(addressbox_user);
            panel3.Controls.Add(emailbox_user);
            panel3.Controls.Add(phonebox_user);
            panel3.Location = new Point(2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 517);
            panel3.TabIndex = 12;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(50, 275);
            label6.Name = "label6";
            label6.Size = new Size(137, 23);
            label6.TabIndex = 26;
            label6.Text = "Qualification";
            // 
            // qualification_box_user
            // 
            qualification_box_user.BackColor = Color.FromArgb(236, 240, 241);
            qualification_box_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            qualification_box_user.Location = new Point(15, 303);
            qualification_box_user.Name = "qualification_box_user";
            qualification_box_user.Size = new Size(225, 32);
            qualification_box_user.TabIndex = 25;
            qualification_box_user.Text = "";
            // 
            // allocation
            // 
            allocation.BackColor = Color.FromArgb(236, 240, 241);
            allocation.FlatAppearance.BorderSize = 0;
            allocation.FlatAppearance.MouseDownBackColor = Color.Transparent;
            allocation.FlatAppearance.MouseOverBackColor = Color.Transparent;
            allocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allocation.ForeColor = Color.Blue;
            allocation.Location = new Point(0, 391);
            allocation.Name = "allocation";
            allocation.Size = new Size(251, 47);
            allocation.TabIndex = 24;
            allocation.Text = "Allocations";
            allocation.UseVisualStyleBackColor = false;
            allocation.Click += allocatin_bt_click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(50, 211);
            label5.Name = "label5";
            label5.Size = new Size(137, 23);
            label5.TabIndex = 23;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 148);
            label4.Name = "label4";
            label4.Size = new Size(137, 23);
            label4.TabIndex = 22;
            label4.Text = "Email Address";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 88);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 21;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 21);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // namebox_user
            // 
            namebox_user.BackColor = Color.FromArgb(236, 240, 241);
            namebox_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            namebox_user.Location = new Point(15, 49);
            namebox_user.Name = "namebox_user";
            namebox_user.Size = new Size(225, 32);
            namebox_user.TabIndex = 19;
            namebox_user.Text = "";
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(236, 240, 241);
            update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.ForeColor = Color.Blue;
            update.Location = new Point(0, 350);
            update.Name = "update";
            update.Size = new Size(251, 45);
            update.TabIndex = 11;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_bt_Click;
            // 
            // delete_account
            // 
            delete_account.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_account.ForeColor = Color.Brown;
            delete_account.Location = new Point(128, 482);
            delete_account.Name = "delete_account";
            delete_account.Size = new Size(108, 23);
            delete_account.TabIndex = 16;
            delete_account.TabStop = true;
            delete_account.Text = "Delete Account";
            delete_account.Click += delete_account_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.FromArgb(236, 240, 241);
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Red;
            logout.Location = new Point(0, 433);
            logout.Name = "logout";
            logout.Size = new Size(251, 45);
            logout.TabIndex = 14;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_bt_click;
            // 
            // change_pass
            // 
            change_pass.Location = new Point(3, 484);
            change_pass.Name = "change_pass";
            change_pass.Size = new Size(126, 23);
            change_pass.TabIndex = 15;
            change_pass.TabStop = true;
            change_pass.Text = "Change Password";
            change_pass.Click += change_pass_Click;
            // 
            // addressbox_user
            // 
            addressbox_user.BackColor = Color.FromArgb(236, 240, 241);
            addressbox_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addressbox_user.Location = new Point(15, 240);
            addressbox_user.Name = "addressbox_user";
            addressbox_user.Size = new Size(225, 32);
            addressbox_user.TabIndex = 13;
            addressbox_user.Text = "";
            // 
            // emailbox_user
            // 
            emailbox_user.BackColor = Color.FromArgb(236, 240, 241);
            emailbox_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            emailbox_user.Location = new Point(15, 175);
            emailbox_user.Name = "emailbox_user";
            emailbox_user.Size = new Size(225, 32);
            emailbox_user.TabIndex = 12;
            emailbox_user.Text = "";
            // 
            // phonebox_user
            // 
            phonebox_user.BackColor = Color.FromArgb(236, 240, 241);
            phonebox_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            phonebox_user.Location = new Point(15, 110);
            phonebox_user.Name = "phonebox_user";
            phonebox_user.Size = new Size(225, 32);
            phonebox_user.TabIndex = 11;
            phonebox_user.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 227, 194);
            panel1.Controls.Add(subject_box);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(time_student);
            panel1.Controls.Add(salary_for_teacher);
            panel1.Controls.Add(name_teacher);
            panel1.Controls.Add(name_l);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(address_teacher);
            panel1.Controls.Add(searchbox);
            panel1.Controls.Add(accept_bt);
            panel1.Controls.Add(adress_l);
            panel1.Controls.Add(salary);
            panel1.Controls.Add(phone_teacher);
            panel1.Controls.Add(phone_l);
            panel1.Location = new Point(289, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 203);
            panel1.TabIndex = 15;
            // 
            // subject_box
            // 
            subject_box.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subject_box.Location = new Point(395, 99);
            subject_box.Name = "subject_box";
            subject_box.Size = new Size(163, 35);
            subject_box.TabIndex = 32;
            subject_box.Text = "";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(317, 102);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 31;
            label7.Text = "Subject";
            // 
            // time_student
            // 
            time_student.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            time_student.Location = new Point(406, 25);
            time_student.Name = "time_student";
            time_student.Size = new Size(167, 32);
            time_student.TabIndex = 16;
            time_student.Text = "";
            // 
            // salary_for_teacher
            // 
            salary_for_teacher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salary_for_teacher.Location = new Point(658, 25);
            salary_for_teacher.Name = "salary_for_teacher";
            salary_for_teacher.Size = new Size(167, 32);
            salary_for_teacher.TabIndex = 17;
            salary_for_teacher.Text = "";
            // 
            // name_teacher
            // 
            name_teacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_teacher.Location = new Point(77, 6);
            name_teacher.Name = "name_teacher";
            name_teacher.Size = new Size(222, 32);
            name_teacher.TabIndex = 29;
            name_teacher.Text = "";
            // 
            // name_l
            // 
            name_l.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_l.ForeColor = Color.White;
            name_l.Location = new Point(12, 11);
            name_l.Name = "name_l";
            name_l.Size = new Size(87, 23);
            name_l.TabIndex = 28;
            name_l.Text = "Name";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(353, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 18;
            label1.Text = "Time Duration";
            // 
            // address_teacher
            // 
            address_teacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address_teacher.Location = new Point(77, 137);
            address_teacher.Name = "address_teacher";
            address_teacher.Size = new Size(222, 32);
            address_teacher.TabIndex = 24;
            address_teacher.Text = "";
            // 
            // searchbox
            // 
            searchbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchbox.Location = new Point(658, 102);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(167, 32);
            searchbox.TabIndex = 22;
            searchbox.Text = "";
            searchbox.TextChanged += search_bt_Click;
            // 
            // accept_bt
            // 
            accept_bt.BackColor = Color.Blue;
            accept_bt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accept_bt.ForeColor = Color.White;
            accept_bt.Location = new Point(658, 153);
            accept_bt.Name = "accept_bt";
            accept_bt.Size = new Size(102, 37);
            accept_bt.TabIndex = 21;
            accept_bt.Text = "Accept";
            accept_bt.UseVisualStyleBackColor = false;
            accept_bt.Click += accept_bt_Click;
            // 
            // adress_l
            // 
            adress_l.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            adress_l.ForeColor = Color.White;
            adress_l.Location = new Point(17, 138);
            adress_l.Name = "adress_l";
            adress_l.Size = new Size(87, 23);
            adress_l.TabIndex = 25;
            adress_l.Text = "Address";
            // 
            // salary
            // 
            salary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salary.ForeColor = Color.Black;
            salary.Location = new Point(599, 29);
            salary.Name = "salary";
            salary.Size = new Size(87, 23);
            salary.TabIndex = 19;
            salary.Text = "Salary";
            // 
            // phone_teacher
            // 
            phone_teacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone_teacher.Location = new Point(61, 74);
            phone_teacher.Name = "phone_teacher";
            phone_teacher.Size = new Size(203, 32);
            phone_teacher.TabIndex = 22;
            phone_teacher.Text = "";
            // 
            // phone_l
            // 
            phone_l.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            phone_l.ForeColor = Color.White;
            phone_l.Location = new Point(34, 48);
            phone_l.Name = "phone_l";
            phone_l.Size = new Size(69, 23);
            phone_l.TabIndex = 26;
            phone_l.Text = "Phone";
            // 
            // Teacher_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 521);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Name = "Teacher_Dashboard";
            Text = "Teacher_Dashboard";
            Load += Teacher_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel3;
        private Button allocation;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox namebox_user;
        private Button update;
        private LinkLabel delete_account;
        private Button logout;
        private LinkLabel change_pass;
        private RichTextBox addressbox_user;
        private RichTextBox emailbox_user;
        private RichTextBox phonebox_user;
        private Label full_name;
        private Panel panel1;
        private RichTextBox name_teacher;
        private Label name_l;
        private RichTextBox address_teacher;
        private RichTextBox qualification_teacher;
        private Label adress_l;
        private RichTextBox phone_teacher;
        private Label qualification_l;
        private Label phone_l;
        private RichTextBox time_student;
        private RichTextBox salary_for_teacher;
        private DateTimePicker dateTimePicker;
        private Label label1;
        private RichTextBox searchbox;
        private Button accept_bt;
        private Label salary;
        private ComboBox selest_subject;
        private Label label6;
        private RichTextBox qualification_box_user;
        private Label label7;
        private RichTextBox subject_box;
    }
}
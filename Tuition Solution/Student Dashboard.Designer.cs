namespace Tuition_Solution
{
    partial class Student_Dashboard
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
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
            bindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            time_student = new RichTextBox();
            salary_for_teacher = new RichTextBox();
            name_teacher = new RichTextBox();
            dateTimePicker = new DateTimePicker();
            name_l = new Label();
            label1 = new Label();
            address_teacher = new RichTextBox();
            searchbox = new RichTextBox();
            qualification_teacher = new RichTextBox();
            request_bt = new Button();
            adress_l = new Label();
            salary = new Label();
            phone_teacher = new RichTextBox();
            selest_subject = new ComboBox();
            qualification_l = new Label();
            phone_l = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(284, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 267);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(835, 261);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
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
            panel3.Location = new Point(1, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 514);
            panel3.TabIndex = 2;
            // 
            // allocation
            // 
            allocation.BackColor = Color.FromArgb(236, 240, 241);
            allocation.FlatAppearance.BorderSize = 0;
            allocation.FlatAppearance.MouseDownBackColor = Color.Transparent;
            allocation.FlatAppearance.MouseOverBackColor = Color.Transparent;
            allocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allocation.ForeColor = Color.Blue;
            allocation.Location = new Point(0, 337);
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
            update.Location = new Point(0, 296);
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
            delete_account.Location = new Point(128, 428);
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
            logout.Location = new Point(0, 379);
            logout.Name = "logout";
            logout.Size = new Size(251, 45);
            logout.TabIndex = 14;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_bt_click;
            // 
            // change_pass
            // 
            change_pass.Location = new Point(3, 430);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(74, 144, 226);
            panel2.Controls.Add(time_student);
            panel2.Controls.Add(salary_for_teacher);
            panel2.Controls.Add(name_teacher);
            panel2.Controls.Add(dateTimePicker);
            panel2.Controls.Add(name_l);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(address_teacher);
            panel2.Controls.Add(searchbox);
            panel2.Controls.Add(qualification_teacher);
            panel2.Controls.Add(request_bt);
            panel2.Controls.Add(adress_l);
            panel2.Controls.Add(salary);
            panel2.Controls.Add(phone_teacher);
            panel2.Controls.Add(selest_subject);
            panel2.Controls.Add(qualification_l);
            panel2.Controls.Add(phone_l);
            panel2.Location = new Point(288, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(835, 203);
            panel2.TabIndex = 16;
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
            salary_for_teacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salary_for_teacher.Location = new Point(658, 25);
            salary_for_teacher.Name = "salary_for_teacher";
            salary_for_teacher.Size = new Size(167, 32);
            salary_for_teacher.TabIndex = 17;
            salary_for_teacher.Text = "";
            // 
            // name_teacher
            // 
            name_teacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            name_teacher.Location = new Point(77, 6);
            name_teacher.Name = "name_teacher";
            name_teacher.Size = new Size(222, 32);
            name_teacher.TabIndex = 29;
            name_teacher.Text = "";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker.Location = new Point(332, 107);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 29);
            dateTimePicker.TabIndex = 23;
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
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            address_teacher.Location = new Point(87, 159);
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
            // 
            // qualification_teacher
            // 
            qualification_teacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qualification_teacher.Location = new Point(27, 121);
            qualification_teacher.Name = "qualification_teacher";
            qualification_teacher.Size = new Size(203, 32);
            qualification_teacher.TabIndex = 23;
            qualification_teacher.Text = "";
            // 
            // request_bt
            // 
            request_bt.BackColor = Color.Blue;
            request_bt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            request_bt.ForeColor = Color.White;
            request_bt.Location = new Point(658, 153);
            request_bt.Name = "request_bt";
            request_bt.Size = new Size(102, 37);
            request_bt.TabIndex = 21;
            request_bt.Text = "Request";
            request_bt.UseVisualStyleBackColor = false;
            request_bt.Click += request_bt_Click;
            // 
            // adress_l
            // 
            adress_l.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            adress_l.ForeColor = Color.White;
            adress_l.Location = new Point(27, 160);
            adress_l.Name = "adress_l";
            adress_l.Size = new Size(87, 23);
            adress_l.TabIndex = 25;
            adress_l.Text = "Address";
            // 
            // salary
            // 
            salary.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salary.ForeColor = Color.Black;
            salary.Location = new Point(604, 29);
            salary.Name = "salary";
            salary.Size = new Size(87, 23);
            salary.TabIndex = 19;
            salary.Text = "Salary";
            // 
            // phone_teacher
            // 
            phone_teacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            phone_teacher.Location = new Point(54, 60);
            phone_teacher.Name = "phone_teacher";
            phone_teacher.Size = new Size(203, 32);
            phone_teacher.TabIndex = 22;
            phone_teacher.Text = "";
            // 
            // selest_subject
            // 
            selest_subject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selest_subject.FormattingEnabled = true;
            selest_subject.Location = new Point(353, 68);
            selest_subject.Name = "selest_subject";
            selest_subject.Size = new Size(96, 29);
            selest_subject.TabIndex = 20;
            selest_subject.Tag = "";
            selest_subject.Text = "Subjects";
            // 
            // qualification_l
            // 
            qualification_l.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            qualification_l.ForeColor = Color.White;
            qualification_l.Location = new Point(27, 95);
            qualification_l.Name = "qualification_l";
            qualification_l.Size = new Size(87, 23);
            qualification_l.TabIndex = 27;
            qualification_l.Text = "Qualification";
            // 
            // phone_l
            // 
            phone_l.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            phone_l.ForeColor = Color.White;
            phone_l.Location = new Point(27, 34);
            phone_l.Name = "phone_l";
            phone_l.Size = new Size(69, 23);
            phone_l.TabIndex = 26;
            phone_l.Text = "Phone";
            // 
            // Student_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1127, 521);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Student_Dashboard";
            Text = "Student_Dashboard";
            Load += Student_Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private RichTextBox phonebox_user;
        private BindingSource bindingSource1;
        private RichTextBox addressbox_user;
        private RichTextBox emailbox_user;
        private LinkLabel delete_account;
        private LinkLabel change_pass;
        private Button logout;
        private Button update;
        private DataGridView dataGridView1;
        private RichTextBox namebox_user;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button allocation;
        private Panel panel2;
        private RichTextBox time_student;
        private RichTextBox salary_for_teacher;
        private RichTextBox name_teacher;
        private DateTimePicker dateTimePicker;
        private Label name_l;
        private Label label1;
        private RichTextBox address_teacher;
        private RichTextBox searchbox;
        private RichTextBox qualification_teacher;
        private Button request_bt;
        private Label adress_l;
        private Label salary;
        private RichTextBox phone_teacher;
        private ComboBox selest_subject;
        private Label qualification_l;
        private Label phone_l;
    }
}
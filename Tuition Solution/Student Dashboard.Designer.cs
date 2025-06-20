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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            full_name = new Label();
            qualification_l = new Label();
            phone_l = new Label();
            time_student = new RichTextBox();
            salary_for_teacher = new RichTextBox();
            label1 = new Label();
            salary = new Label();
            selest_subject = new ComboBox();
            request_bt = new Button();
            searchbox = new RichTextBox();
            bindingSource1 = new BindingSource(components);
            dateTimePicker = new DateTimePicker();
            phone_teacher = new RichTextBox();
            qualification_teacher = new RichTextBox();
            address_teacher = new RichTextBox();
            adress_l = new Label();
            panel4 = new Panel();
            name_teacher = new RichTextBox();
            name_l = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(284, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 291);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Size = new Size(835, 285);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(47, 225, 237);
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
            panel3.Location = new Point(1, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 458);
            panel3.TabIndex = 2;
            // 
            // allocation
            // 
            allocation.BackColor = Color.FromArgb(47, 225, 237);
            allocation.FlatAppearance.BorderSize = 0;
            allocation.FlatAppearance.MouseDownBackColor = Color.Transparent;
            allocation.FlatAppearance.MouseOverBackColor = Color.Transparent;
            allocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allocation.ForeColor = Color.Blue;
            allocation.Location = new Point(0, 380);
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
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(50, 211);
            label5.Name = "label5";
            label5.Size = new Size(137, 23);
            label5.TabIndex = 23;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(50, 148);
            label4.Name = "label4";
            label4.Size = new Size(137, 23);
            label4.TabIndex = 22;
            label4.Text = "Email Address";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(50, 88);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 21;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(50, 21);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // namebox_user
            // 
            namebox_user.BackColor = Color.FromArgb(47, 225, 237);
            namebox_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            namebox_user.Location = new Point(15, 49);
            namebox_user.Name = "namebox_user";
            namebox_user.Size = new Size(225, 32);
            namebox_user.TabIndex = 19;
            namebox_user.Text = "";
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(47, 225, 237);
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
            logout.BackColor = Color.FromArgb(47, 225, 237);
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Red;
            logout.Location = new Point(0, 338);
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
            // 
            // addressbox_user
            // 
            addressbox_user.BackColor = Color.FromArgb(47, 225, 237);
            addressbox_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addressbox_user.Location = new Point(15, 240);
            addressbox_user.Name = "addressbox_user";
            addressbox_user.Size = new Size(225, 32);
            addressbox_user.TabIndex = 13;
            addressbox_user.Text = "";
            // 
            // emailbox_user
            // 
            emailbox_user.BackColor = Color.FromArgb(47, 225, 237);
            emailbox_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            emailbox_user.Location = new Point(15, 175);
            emailbox_user.Name = "emailbox_user";
            emailbox_user.Size = new Size(225, 32);
            emailbox_user.TabIndex = 12;
            emailbox_user.Text = "";
            // 
            // phonebox_user
            // 
            phonebox_user.BackColor = Color.FromArgb(47, 225, 237);
            phonebox_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            phonebox_user.Location = new Point(15, 110);
            phonebox_user.Name = "phonebox_user";
            phonebox_user.Size = new Size(225, 32);
            phonebox_user.TabIndex = 11;
            phonebox_user.Text = "";
            // 
            // full_name
            // 
            full_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            full_name.ForeColor = Color.Red;
            full_name.Location = new Point(9, 9);
            full_name.Name = "full_name";
            full_name.Size = new Size(258, 23);
            full_name.TabIndex = 11;
            full_name.Text = "None";
            // 
            // qualification_l
            // 
            qualification_l.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            qualification_l.ForeColor = Color.White;
            qualification_l.Location = new Point(26, 91);
            qualification_l.Name = "qualification_l";
            qualification_l.Size = new Size(87, 23);
            qualification_l.TabIndex = 18;
            qualification_l.Text = "Qualification";
            qualification_l.Click += qualification_l_Click;
            // 
            // phone_l
            // 
            phone_l.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            phone_l.ForeColor = Color.White;
            phone_l.Location = new Point(26, 30);
            phone_l.Name = "phone_l";
            phone_l.Size = new Size(69, 23);
            phone_l.TabIndex = 17;
            phone_l.Text = "Phone";
            phone_l.Click += phone_l_Click;
            // 
            // time_student
            // 
            time_student.Location = new Point(87, 17);
            time_student.Name = "time_student";
            time_student.Size = new Size(167, 32);
            time_student.TabIndex = 3;
            time_student.Text = "";
            // 
            // salary_for_teacher
            // 
            salary_for_teacher.Location = new Point(339, 17);
            salary_for_teacher.Name = "salary_for_teacher";
            salary_for_teacher.Size = new Size(167, 32);
            salary_for_teacher.TabIndex = 4;
            salary_for_teacher.Text = "";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(34, 21);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 5;
            label1.Text = "Time Duration";
            // 
            // salary
            // 
            salary.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salary.ForeColor = Color.Black;
            salary.Location = new Point(285, 21);
            salary.Name = "salary";
            salary.Size = new Size(87, 23);
            salary.TabIndex = 6;
            salary.Text = "Salary";
            // 
            // selest_subject
            // 
            selest_subject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selest_subject.FormattingEnabled = true;
            selest_subject.Location = new Point(34, 60);
            selest_subject.Name = "selest_subject";
            selest_subject.Size = new Size(96, 29);
            selest_subject.TabIndex = 7;
            selest_subject.Tag = "";
            selest_subject.Text = "Subjects";
            // 
            // request_bt
            // 
            request_bt.BackColor = Color.Blue;
            request_bt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            request_bt.ForeColor = Color.White;
            request_bt.Location = new Point(339, 145);
            request_bt.Name = "request_bt";
            request_bt.Size = new Size(102, 37);
            request_bt.TabIndex = 8;
            request_bt.Text = "Request";
            request_bt.UseVisualStyleBackColor = false;
            request_bt.Click += request_bt_Click;
            // 
            // searchbox
            // 
            searchbox.Location = new Point(339, 94);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(167, 32);
            searchbox.TabIndex = 9;
            searchbox.Text = "";
            searchbox.TextChanged += search_bt_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker.Location = new Point(13, 99);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 29);
            dateTimePicker.TabIndex = 10;
            // 
            // phone_teacher
            // 
            phone_teacher.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            phone_teacher.Location = new Point(53, 56);
            phone_teacher.Name = "phone_teacher";
            phone_teacher.Size = new Size(203, 32);
            phone_teacher.TabIndex = 13;
            phone_teacher.Text = "";
            // 
            // qualification_teacher
            // 
            qualification_teacher.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            qualification_teacher.Location = new Point(26, 117);
            qualification_teacher.Name = "qualification_teacher";
            qualification_teacher.Size = new Size(203, 32);
            qualification_teacher.TabIndex = 14;
            qualification_teacher.Text = "";
            // 
            // address_teacher
            // 
            address_teacher.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            address_teacher.Location = new Point(86, 155);
            address_teacher.Name = "address_teacher";
            address_teacher.Size = new Size(222, 32);
            address_teacher.TabIndex = 15;
            address_teacher.Text = "";
            // 
            // adress_l
            // 
            adress_l.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            adress_l.ForeColor = Color.White;
            adress_l.Location = new Point(26, 156);
            adress_l.Name = "adress_l";
            adress_l.Size = new Size(87, 23);
            adress_l.TabIndex = 16;
            adress_l.Text = "Address";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(7, 18, 230);
            panel4.Controls.Add(name_teacher);
            panel4.Controls.Add(name_l);
            panel4.Controls.Add(address_teacher);
            panel4.Controls.Add(qualification_teacher);
            panel4.Controls.Add(adress_l);
            panel4.Controls.Add(phone_teacher);
            panel4.Controls.Add(qualification_l);
            panel4.Controls.Add(phone_l);
            panel4.Location = new Point(273, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(322, 192);
            panel4.TabIndex = 19;
            // 
            // name_teacher
            // 
            name_teacher.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            name_teacher.Location = new Point(76, 0);
            name_teacher.Name = "name_teacher";
            name_teacher.Size = new Size(222, 32);
            name_teacher.TabIndex = 21;
            name_teacher.Text = "";
            // 
            // name_l
            // 
            name_l.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_l.ForeColor = Color.White;
            name_l.Location = new Point(11, 7);
            name_l.Name = "name_l";
            name_l.Size = new Size(87, 23);
            name_l.TabIndex = 20;
            name_l.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(6, 140, 30);
            panel2.Controls.Add(time_student);
            panel2.Controls.Add(salary_for_teacher);
            panel2.Controls.Add(dateTimePicker);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(searchbox);
            panel2.Controls.Add(request_bt);
            panel2.Controls.Add(salary);
            panel2.Controls.Add(selest_subject);
            panel2.Location = new Point(601, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 192);
            panel2.TabIndex = 20;
            // 
            // Student_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1127, 521);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(full_name);
            Name = "Student_Dashboard";
            Text = "Student_Dashboard";
            Load += Student_Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private RichTextBox time_student;
        private RichTextBox salary_for_teacher;
        private Label label1;
        private RichTextBox phonebox_user;
        private Label salary;
        private ComboBox selest_subject;
        private Button request_bt;
        private RichTextBox searchbox;
        private BindingSource bindingSource1;
        private DateTimePicker dateTimePicker;
        private RichTextBox addressbox_user;
        private RichTextBox emailbox_user;
        private LinkLabel delete_account;
        private LinkLabel change_pass;
        private Button logout;
        private Button update;
        private DataGridView dataGridView1;
        private Label full_name;
        private RichTextBox phone_teacher;
        private Label qualification_l;
        private Label phone_l;
        private RichTextBox qualification_teacher;
        private RichTextBox address_teacher;
        private Label adress_l;
        private RichTextBox namebox_user;
        private Panel panel4;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button allocation;
        private RichTextBox name_teacher;
        private Label name_l;
    }
}
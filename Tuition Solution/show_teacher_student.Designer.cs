namespace Tuition_Solution
{
    partial class show_teacher_student
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            namebox = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Back = new Guna.UI2.WinForms.Guna2Button();
            delete = new Guna.UI2.WinForms.Guna2Button();
            activate = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // namebox
            // 
            namebox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namebox.ForeColor = Color.FromArgb(255, 128, 128);
            namebox.Location = new Point(35, 30);
            namebox.Name = "namebox";
            namebox.Size = new Size(404, 83);
            namebox.TabIndex = 8;
            namebox.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 42, 52);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(35, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 218);
            panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(60, 63, 81);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(575, 180);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Back
            // 
            Back.CustomizableEdges = customizableEdges1;
            Back.DisabledState.BorderColor = Color.DarkGray;
            Back.DisabledState.CustomBorderColor = Color.DarkGray;
            Back.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Back.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Back.FillColor = Color.FromArgb(40, 42, 52);
            Back.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Back.ForeColor = Color.White;
            Back.Location = new Point(498, 93);
            Back.Name = "Back";
            Back.PressedColor = Color.FromArgb(40, 42, 52);
            Back.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Back.Size = new Size(152, 45);
            Back.TabIndex = 10;
            Back.Text = "Back";
            Back.Click += back_bt;
            // 
            // delete
            // 
            delete.CustomizableEdges = customizableEdges3;
            delete.DisabledState.BorderColor = Color.DarkGray;
            delete.DisabledState.CustomBorderColor = Color.DarkGray;
            delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            delete.FillColor = Color.FromArgb(40, 42, 52);
            delete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            delete.ForeColor = Color.White;
            delete.Location = new Point(498, 42);
            delete.Name = "delete";
            delete.PressedColor = Color.FromArgb(40, 42, 52);
            delete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            delete.Size = new Size(152, 45);
            delete.TabIndex = 11;
            delete.Text = "Delete Users";
            delete.Click += delete_bt;
            // 
            // activate
            // 
            activate.CustomizableEdges = customizableEdges5;
            activate.DisabledState.BorderColor = Color.DarkGray;
            activate.DisabledState.CustomBorderColor = Color.DarkGray;
            activate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            activate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            activate.FillColor = Color.FromArgb(40, 42, 52);
            activate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            activate.ForeColor = Color.White;
            activate.Location = new Point(498, 42);
            activate.Name = "activate";
            activate.PressedColor = Color.FromArgb(40, 42, 52);
            activate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            activate.Size = new Size(152, 45);
            activate.TabIndex = 12;
            activate.Text = "Activate";
            activate.Click += activate_Click;
            // 
            // show_teacher_student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(685, 406);
            Controls.Add(activate);
            Controls.Add(delete);
            Controls.Add(Back);
            Controls.Add(namebox);
            Controls.Add(panel1);
            Name = "show_teacher_student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "show_teacher_student";
            FormClosed += show_teacher_student_FormClosed;
            Load += show_teacher_student_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label namebox;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button Back;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button activate;
    }
}
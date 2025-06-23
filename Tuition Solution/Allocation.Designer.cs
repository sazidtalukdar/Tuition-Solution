namespace Tuition_Solution
{
    partial class Allocation
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Back = new Button();
            namebox = new Label();
            delete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(36, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 218);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(575, 180);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Back
            // 
            Back.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.Blue;
            Back.Location = new Point(535, 90);
            Back.Name = "Back";
            Back.Size = new Size(116, 35);
            Back.TabIndex = 3;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += back_bt_Click;
            // 
            // namebox
            // 
            namebox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namebox.ForeColor = Color.FromArgb(255, 128, 128);
            namebox.Location = new Point(36, 29);
            namebox.Name = "namebox";
            namebox.Size = new Size(404, 83);
            namebox.TabIndex = 4;
            namebox.Text = "label1";
            // 
            // delete
            // 
            delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete.ForeColor = Color.Red;
            delete.Location = new Point(535, 49);
            delete.Name = "delete";
            delete.Size = new Size(116, 35);
            delete.TabIndex = 5;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Allocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 406);
            Controls.Add(delete);
            Controls.Add(namebox);
            Controls.Add(Back);
            Controls.Add(panel1);
            Name = "Allocation";
            Text = "Allocation";
            Load += Allocation_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button Back;
        private Label namebox;
        private Button delete;
    }
}
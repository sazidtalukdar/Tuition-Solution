namespace Tuition_Solution
{
    partial class Change_Pass
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
            pass = new RichTextBox();
            Submit = new Button();
            confirmpass = new RichTextBox();
            Back = new Button();
            namebox = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // pass
            // 
            pass.Location = new Point(162, 121);
            pass.Name = "pass";
            pass.Size = new Size(265, 32);
            pass.TabIndex = 0;
            pass.Text = "";
            // 
            // Submit
            // 
            Submit.BackColor = Color.FromArgb(0, 192, 0);
            Submit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Submit.ForeColor = Color.White;
            Submit.Location = new Point(177, 249);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 38);
            Submit.TabIndex = 1;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += submit_bt_Click;
            // 
            // confirmpass
            // 
            confirmpass.Location = new Point(162, 197);
            confirmpass.Name = "confirmpass";
            confirmpass.Size = new Size(265, 32);
            confirmpass.TabIndex = 2;
            confirmpass.Text = "";
            // 
            // Back
            // 
            Back.BackColor = Color.Blue;
            Back.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Back.ForeColor = Color.White;
            Back.Location = new Point(315, 249);
            Back.Name = "Back";
            Back.Size = new Size(91, 38);
            Back.TabIndex = 3;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += back_bt_Click;
            // 
            // namebox
            // 
            namebox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namebox.ForeColor = Color.FromArgb(0, 192, 0);
            namebox.Location = new Point(28, 18);
            namebox.Name = "namebox";
            namebox.Size = new Size(332, 68);
            namebox.TabIndex = 4;
            namebox.Text = "label1";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(162, 86);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(162, 162);
            label3.Name = "label3";
            label3.Size = new Size(163, 32);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password";
            // 
            // Change_Pass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(618, 369);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(namebox);
            Controls.Add(Back);
            Controls.Add(confirmpass);
            Controls.Add(Submit);
            Controls.Add(pass);
            Name = "Change_Pass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change_Pass";
            Load += Change_Pass_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox pass;
        private Button Submit;
        private RichTextBox confirmpass;
        private Button Back;
        private Label namebox;
        private Label label2;
        private Label label3;
    }
}
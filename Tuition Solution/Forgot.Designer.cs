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
            fbox1 = new TextBox();
            fbox2 = new TextBox();
            fbox3 = new TextBox();
            search = new Button();
            regester = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // fbox1
            // 
            fbox1.Location = new Point(288, 134);
            fbox1.Multiline = true;
            fbox1.Name = "fbox1";
            fbox1.Size = new Size(260, 23);
            fbox1.TabIndex = 0;
            // 
            // fbox2
            // 
            fbox2.Location = new Point(288, 189);
            fbox2.Multiline = true;
            fbox2.Name = "fbox2";
            fbox2.Size = new Size(260, 23);
            fbox2.TabIndex = 1;
            // 
            // fbox3
            // 
            fbox3.Location = new Point(288, 243);
            fbox3.Multiline = true;
            fbox3.Name = "fbox3";
            fbox3.Size = new Size(260, 23);
            fbox3.TabIndex = 2;
            // 
            // search
            // 
            search.Location = new Point(367, 218);
            search.Name = "search";
            search.Size = new Size(103, 41);
            search.TabIndex = 3;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // regester
            // 
            regester.Location = new Point(367, 281);
            regester.Name = "regester";
            regester.Size = new Size(103, 39);
            regester.TabIndex = 4;
            regester.Text = "Register";
            regester.UseVisualStyleBackColor = true;
            regester.Click += register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 160);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 5;
            label1.Text = "Input Phone Number";
            // 
            // Forgot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(regester);
            Controls.Add(search);
            Controls.Add(fbox3);
            Controls.Add(fbox2);
            Controls.Add(fbox1);
            Name = "Forgot";
            Text = "Forgot";
            Load += Forgot_Load_1;
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
    }
}
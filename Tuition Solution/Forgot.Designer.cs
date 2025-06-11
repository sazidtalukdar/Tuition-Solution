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
            label2 = new Label();
            submit = new Button();
            search = new Button();
            fbox3 = new TextBox();
            fbox2 = new TextBox();
            textBox1 = new TextBox();
            register = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 137);
            label2.Name = "label2";
            label2.Size = new Size(341, 38);
            label2.TabIndex = 13;
            label2.Text = "Input your Phone Number";
            // 
            // submit
            // 
            submit.Location = new Point(339, 291);
            submit.Name = "submit";
            submit.Size = new Size(103, 38);
            submit.TabIndex = 12;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_click;
            // 
            // search
            // 
            search.Font = new Font("Microsoft Sans Serif", 8.25F);
            search.Location = new Point(339, 226);
            search.Name = "search";
            search.Size = new Size(103, 38);
            search.TabIndex = 11;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // fbox3
            // 
            fbox3.Location = new Point(230, 244);
            fbox3.Multiline = true;
            fbox3.Name = "fbox3";
            fbox3.Size = new Size(309, 32);
            fbox3.TabIndex = 10;
            // 
            // fbox2
            // 
            fbox2.Location = new Point(230, 178);
            fbox2.Multiline = true;
            fbox2.Name = "fbox2";
            fbox2.Size = new Size(309, 32);
            fbox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 117);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 32);
            textBox1.TabIndex = 8;
            // 
            // register
            // 
            register.Location = new Point(339, 291);
            register.Name = "register";
            register.Size = new Size(103, 38);
            register.TabIndex = 14;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += regester_Click;
            // 
            // Forgot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(register);
            Controls.Add(label2);
            Controls.Add(submit);
            Controls.Add(search);
            Controls.Add(fbox3);
            Controls.Add(fbox2);
            Controls.Add(textBox1);
            Name = "Forgot";
            Text = "Form1";
            Load += fbox1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button submit;
        private Button search;
        private TextBox fbox3;
        private TextBox fbox2;
        private TextBox textBox1;
        private Button register;
    }
}
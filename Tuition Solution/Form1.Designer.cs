namespace Tuition_Solution
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userbox = new TextBox();
            passbox = new TextBox();
            loginbt = new Button();
            singupbt = new Button();
            forgotpass = new LinkLabel();
            SuspendLayout();
            // 
            // userbox
            // 
            userbox.Location = new Point(232, 130);
            userbox.Name = "userbox";
            userbox.Size = new Size(285, 23);
            userbox.TabIndex = 0;
            // 
            // passbox
            // 
            passbox.Location = new Point(232, 194);
            passbox.Name = "passbox";
            passbox.Size = new Size(285, 23);
            passbox.TabIndex = 1;
            // 
            // loginbt
            // 
            loginbt.Location = new Point(232, 252);
            loginbt.Name = "loginbt";
            loginbt.Size = new Size(101, 39);
            loginbt.TabIndex = 2;
            loginbt.Text = "Login";
            loginbt.UseVisualStyleBackColor = true;
            // 
            // singupbt
            // 
            singupbt.Location = new Point(416, 252);
            singupbt.Name = "singupbt";
            singupbt.Size = new Size(101, 39);
            singupbt.TabIndex = 3;
            singupbt.Text = "Singup";
            singupbt.UseVisualStyleBackColor = true;
            // 
            // forgotpass
            // 
            forgotpass.Location = new Point(334, 327);
            forgotpass.Name = "forgotpass";
            forgotpass.Size = new Size(183, 21);
            forgotpass.TabIndex = 4;
            forgotpass.TabStop = true;
            forgotpass.Text = "Forgot Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(forgotpass);
            Controls.Add(singupbt);
            Controls.Add(loginbt);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userbox;
        private TextBox passbox;
        private Button loginbt;
        private Button singupbt;
        private LinkLabel forgotpass;
    }
}

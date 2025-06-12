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
            label1 = new Label();
            label2 = new Label();
            userbox = new TextBox();
            passbox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 83);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 128);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // userbox
            // 
            userbox.Location = new Point(298, 68);
            userbox.Margin = new Padding(2);
            userbox.Name = "userbox";
            userbox.Size = new Size(140, 23);
            userbox.TabIndex = 2;
            // 
            // passbox
            // 
            passbox.Location = new Point(298, 128);
            passbox.Margin = new Padding(2);
            passbox.Name = "passbox";
            passbox.Size = new Size(140, 23);
            passbox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(122, 251);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(134, 34);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(305, 176);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(170, 109);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(523, 193);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(170, 109);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(122, 354);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(170, 109);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 495);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userbox;
        private TextBox passbox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}

namespace Bai1Nhan
{
    partial class Form1
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
            chkNho = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F);
            label1.Location = new Point(166, 111);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(166, 144);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Font = new Font("Times New Roman", 12.75F);
            chkNho.Location = new Point(166, 180);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(86, 23);
            chkNho.TabIndex = 2;
            chkNho.Text = "Ghi  nhớ";
            chkNho.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12.75F);
            button1.Location = new Point(166, 232);
            button1.Name = "button1";
            button1.Size = new Size(115, 36);
            button1.TabIndex = 3;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12.75F);
            button2.Location = new Point(296, 232);
            button2.Name = "button2";
            button2.Size = new Size(115, 36);
            button2.TabIndex = 4;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12.75F);
            button3.Location = new Point(432, 232);
            button3.Name = "button3";
            button3.Size = new Size(115, 36);
            button3.TabIndex = 5;
            button3.Text = "Dừng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(255, 192, 192);
            txtUser.Location = new Point(307, 109);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(240, 23);
            txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(255, 192, 255);
            txtPass.Location = new Point(307, 142);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(240, 23);
            txtPass.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkNho);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox chkNho;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtUser;
        private TextBox txtPass;
    }
}

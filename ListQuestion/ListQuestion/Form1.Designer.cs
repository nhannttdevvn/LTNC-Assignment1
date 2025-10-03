namespace ListQuestion
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
            components = new System.ComponentModel.Container();
            lbl_Time = new Label();
            lbl_Status = new Label();
            bt_lam_bai = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            rad4 = new RadioButton();
            rad3 = new RadioButton();
            rad2 = new RadioButton();
            rad1 = new RadioButton();
            lblQuestion = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.Location = new Point(316, 62);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(128, 20);
            lbl_Time.TabIndex = 0;
            lbl_Time.Text = "Thời gian làm bài:";
            // 
            // lbl_Status
            // 
            lbl_Status.AutoSize = true;
            lbl_Status.Location = new Point(316, 109);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size(176, 20);
            lbl_Status.TabIndex = 1;
            lbl_Status.Text = "Bạn chưa chọn câu trả lời";
            // 
            // bt_lam_bai
            // 
            bt_lam_bai.Location = new Point(910, 379);
            bt_lam_bai.Name = "bt_lam_bai";
            bt_lam_bai.Size = new Size(94, 29);
            bt_lam_bai.TabIndex = 4;
            bt_lam_bai.Text = "Làm bài";
            bt_lam_bai.UseVisualStyleBackColor = true;
            bt_lam_bai.Click += bt_lam_bai_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad4);
            groupBox1.Controls.Add(rad3);
            groupBox1.Controls.Add(rad2);
            groupBox1.Controls.Add(rad1);
            groupBox1.Controls.Add(lblQuestion);
            groupBox1.Location = new Point(602, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 279);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Câu hỏi";
            // 
            // rad4
            // 
            rad4.AutoSize = true;
            rad4.Location = new Point(43, 206);
            rad4.Name = "rad4";
            rad4.Size = new Size(38, 24);
            rad4.TabIndex = 13;
            rad4.TabStop = true;
            rad4.Text = "4";
            rad4.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            rad3.AutoSize = true;
            rad3.Location = new Point(43, 161);
            rad3.Name = "rad3";
            rad3.Size = new Size(38, 24);
            rad3.TabIndex = 12;
            rad3.TabStop = true;
            rad3.Text = "3";
            rad3.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(43, 120);
            rad2.Name = "rad2";
            rad2.Size = new Size(38, 24);
            rad2.TabIndex = 11;
            rad2.TabStop = true;
            rad2.Text = "2";
            rad2.UseVisualStyleBackColor = true;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(43, 81);
            rad1.Name = "rad1";
            rad1.Size = new Size(38, 24);
            rad1.TabIndex = 10;
            rad1.TabStop = true;
            rad1.Text = "1";
            rad1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(22, 38);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(121, 20);
            lblQuestion.TabIndex = 9;
            lblQuestion.Text = "Câu hỏi : 1+1 = ?";
            lblQuestion.Click += lblQuestion_Click;
            // 
            // button1
            // 
            button1.Location = new Point(891, 439);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 10;
            button1.Text = "Tắt ứng dụng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(731, 379);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Trước đó";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1065, 379);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Kế tiếp";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 617);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(bt_lam_bai);
            Controls.Add(lbl_Status);
            Controls.Add(lbl_Time);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Time;
        private Label lbl_Status;
        private Button bt_lam_bai;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private RadioButton rad4;
        private RadioButton rad3;
        private RadioButton rad2;
        private RadioButton rad1;
        private Label lblQuestion;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

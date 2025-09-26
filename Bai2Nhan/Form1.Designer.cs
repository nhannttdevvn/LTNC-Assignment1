namespace Bai2Nhan
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
            txtHoTen = new TextBox();
            txtKQ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            rad1 = new RadioButton();
            rad2 = new RadioButton();
            btnKQ = new Button();
            btnXoa = new Button();
            btnDung = new Button();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 12F);
            txtHoTen.Location = new Point(250, 75);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(235, 26);
            txtHoTen.TabIndex = 0;
            txtHoTen.TextChanged += textBox1_TextChanged;
            // 
            // txtKQ
            // 
            txtKQ.Font = new Font("Times New Roman", 12F);
            txtKQ.Location = new Point(250, 238);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(235, 26);
            txtKQ.TabIndex = 1;
            txtKQ.TextChanged += txtKQ_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 78);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 2;
            label1.Text = "Nhập họ và tên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(121, 120);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 3;
            label2.Text = "Chọn kiểu chữ";
            label2.Click += label2_Click;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Font = new Font("Times New Roman", 12F);
            rad1.Location = new Point(143, 163);
            rad1.Name = "rad1";
            rad1.Size = new Size(96, 23);
            rad1.TabIndex = 4;
            rad1.TabStop = true;
            rad1.Text = "chữ thường";
            rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Font = new Font("Times New Roman", 12F);
            rad2.Location = new Point(143, 197);
            rad2.Name = "rad2";
            rad2.Size = new Size(120, 23);
            rad2.TabIndex = 5;
            rad2.TabStop = true;
            rad2.Text = "CHỮ IN HOA";
            rad2.UseVisualStyleBackColor = true;
            rad2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // btnKQ
            // 
            btnKQ.Font = new Font("Times New Roman", 12F);
            btnKQ.Location = new Point(146, 237);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(75, 28);
            btnKQ.TabIndex = 6;
            btnKQ.Text = "Kết quả";
            btnKQ.UseVisualStyleBackColor = true;
            btnKQ.Click += btnKQ_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F);
            btnXoa.Location = new Point(436, 151);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(71, 46);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button3_Click;
            // 
            // btnDung
            // 
            btnDung.Font = new Font("Times New Roman", 12F);
            btnDung.Location = new Point(146, 271);
            btnDung.Name = "btnDung";
            btnDung.Size = new Size(75, 42);
            btnDung.TabIndex = 9;
            btnDung.Text = "Dừng";
            btnDung.UseVisualStyleBackColor = true;
            btnDung.Click += btnDung_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDung);
            Controls.Add(btnXoa);
            Controls.Add(btnKQ);
            Controls.Add(rad2);
            Controls.Add(rad1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKQ);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtKQ;
        private Label label1;
        private Label label2;
        private RadioButton rad1;
        private RadioButton rad2;
        private Button btnKQ;
        private Button btnXoa;
        private Button btnDung;
    }
}

namespace bai4Nhan
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
            label3 = new Label();
            label4 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            txtKQ = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 111);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Số 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 141);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Số 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 179);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Phép tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 257);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Kết quả";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(279, 108);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(414, 23);
            txtSo1.TabIndex = 4;
            txtSo1.Text = "1";
            txtSo1.TextChanged += txtSo1_TextChanged;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(279, 138);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(414, 23);
            txtSo2.TabIndex = 5;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(279, 257);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(289, 23);
            txtKQ.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(213, 211);
            radioButton1.Name = "radioButton1";
            radioButton1.RightToLeft = RightToLeft.No;
            radioButton1.Size = new Size(54, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cộng";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(328, 211);
            radioButton2.Name = "radioButton2";
            radioButton2.RightToLeft = RightToLeft.No;
            radioButton2.Size = new Size(42, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Trừ";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(474, 211);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(54, 19);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Nhân";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(599, 211);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(49, 19);
            radioButton4.TabIndex = 10;
            radioButton4.TabStop = true;
            radioButton4.Text = "Chia";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtKQ);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private TextBox txtKQ;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}

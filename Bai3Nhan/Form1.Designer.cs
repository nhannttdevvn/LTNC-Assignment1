namespace Bai3Nhan
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            txtSo = new TextBox();
            listTinh = new ListBox();
            cboSo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 51);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 51);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 1;
            label2.Text = "Danh sách các ước số";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(352, 106);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 2;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(352, 299);
            button2.Name = "button2";
            button2.Size = new Size(94, 44);
            button2.TabIndex = 3;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(463, 299);
            button3.Name = "button3";
            button3.Size = new Size(224, 44);
            button3.TabIndex = 4;
            button3.Text = "Số lượng các ước số nguyên tố";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(463, 238);
            button4.Name = "button4";
            button4.Size = new Size(224, 44);
            button4.TabIndex = 5;
            button4.Text = "Số lượng các ước số chẵn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(463, 180);
            button5.Name = "button5";
            button5.Size = new Size(224, 44);
            button5.TabIndex = 6;
            button5.Text = "Tổng các ước số";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtSo
            // 
            txtSo.Location = new Point(233, 118);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(100, 23);
            txtSo.TabIndex = 7;
            // 
            // listTinh
            // 
            listTinh.FormattingEnabled = true;
            listTinh.ItemHeight = 15;
            listTinh.Location = new Point(488, 69);
            listTinh.Name = "listTinh";
            listTinh.Size = new Size(199, 94);
            listTinh.TabIndex = 8;
            listTinh.SelectedIndexChanged += listTinh_SelectedIndexChanged;
            // 
            // cboSo
            // 
            cboSo.FormattingEnabled = true;
            cboSo.Location = new Point(233, 171);
            cboSo.Name = "cboSo";
            cboSo.Size = new Size(213, 23);
            cboSo.TabIndex = 9;
            cboSo.SelectedIndexChanged += cboSo_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboSo);
            Controls.Add(listTinh);
            Controls.Add(txtSo);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox txtSo;
        private ListBox listTinh;
        private ComboBox cboSo;
    }
}

namespace btexam
{
  public partial class Form1 : Form
  {
    private int remainingSeconds = 30;
    private bool isStarted = false;

    public Form1()
    {
      InitializeComponent();
      button1.Click += button1_Click;
      timerqe.Tick += timerqe_Tick;

      checkBox1.Enabled = false;
      checkBox2.Enabled = false;
      checkBox3.Enabled = false;
      checkBox4.Enabled = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!isStarted)
      {
        button1.Text = "Kết thúc";
        remainingSeconds = 30;
        UpdateTimeLabel();
        timerqe.Start();
        isStarted = true;
        label3.Text = "Kết quả";

        // Enable checkboxes when started
        checkBox1.Enabled = true;
        checkBox2.Enabled = true;
        checkBox3.Enabled = true;
        checkBox4.Enabled = true;
      }
      else
      {
        timerqe.Stop();
        if (checkBox3.Checked)
        {
          label3.Text = "Chính xác!";
        }
        else
        {
          label3.Text = "Sai!";
        }
        button1.Enabled = false;

        // Optionally disable checkboxes after finish
        checkBox1.Enabled = false;
        checkBox2.Enabled = false;
        checkBox3.Enabled = false;
        checkBox4.Enabled = false;
      }
    }
    private void timerqe_Tick(object sender, EventArgs e)
    {
      if (remainingSeconds > 0)
      {
        remainingSeconds--;
        UpdateTimeLabel();
      }
      else
      {
        timerqe.Stop();
        label2.Text = "Thời gian: 00:00";

      }
    }

    private void UpdateTimeLabel()
    {
      int minutes = remainingSeconds / 60;
      int seconds = remainingSeconds % 60;
      label2.Text = $"Thời gian: {minutes:D2}:{seconds:D2}";
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
  }
}
namespace btexam
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
      groupBox1 = new GroupBox();
      checkBox4 = new CheckBox();
      checkBox3 = new CheckBox();
      checkBox2 = new CheckBox();
      checkBox1 = new CheckBox();
      label1 = new Label();
      button1 = new Button();
      label2 = new Label();
      timerqe = new System.Windows.Forms.Timer(components);
      label3 = new Label();
      groupBox1.SuspendLayout();
      SuspendLayout();
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(checkBox4);
      groupBox1.Controls.Add(checkBox3);
      groupBox1.Controls.Add(checkBox2);
      groupBox1.Controls.Add(checkBox1);
      groupBox1.Controls.Add(label1);
      groupBox1.Location = new Point(163, 12);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(552, 213);
      groupBox1.TabIndex = 0;
      groupBox1.TabStop = false;
      groupBox1.Text = "Nhóm Câu Hỏi";
      groupBox1.Enter += groupBox1_Enter;
      // 
      // checkBox4
      // 
      checkBox4.AutoSize = true;
      checkBox4.Location = new Point(38, 158);
      checkBox4.Name = "checkBox4";
      checkBox4.Size = new Size(62, 24);
      checkBox4.TabIndex = 4;
      checkBox4.Text = "NTTN";
      checkBox4.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      checkBox3.AutoSize = true;
      checkBox3.Location = new Point(38, 128);
      checkBox3.Name = "checkBox3";
      checkBox3.Size = new Size(121, 24);
      checkBox3.TabIndex = 3;
      checkBox3.Text = "Ai cx hỏng có";
      checkBox3.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      checkBox2.AutoSize = true;
      checkBox2.Location = new Point(38, 98);
      checkBox2.Name = "checkBox2";
      checkBox2.Size = new Size(94, 24);
      checkBox2.TabIndex = 2;
      checkBox2.Text = "Nâu có ai";
      checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox1
      // 
      checkBox1.AutoSize = true;
      checkBox1.Location = new Point(38, 68);
      checkBox1.Name = "checkBox1";
      checkBox1.Size = new Size(76, 24);
      checkBox1.TabIndex = 1;
      checkBox1.Text = "Sá bau";
      checkBox1.UseVisualStyleBackColor = true;
      // 
      // label1
      //
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
      label1.Location = new Point(22, 34);
      label1.Name = "label1";
      label1.Size = new Size(340, 31);
      label1.TabIndex = 0;
      label1.Text = "Ai đẹp trai hơn Nguyễn Thị Thanh Nhàn  ?";
      // 
      // button1
      // 
      button1.BackColor = SystemColors.MenuHighlight;
      button1.ForeColor = SystemColors.ButtonHighlight;
      button1.Location = new Point(22, 196);
      button1.Name = "button1";
      button1.Size = new Size(124, 29);
      button1.TabIndex = 0;
      button1.Text = "Bắt đầu";
      button1.UseVisualStyleBackColor = false;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
      label2.Location = new Point(7, 22);
      label2.Name = "label2";
      label2.Size = new Size(150, 28);
      label2.TabIndex = 5;
      label2.Text = "Thời gian: 00:00";
      // 
      // timerqe
      // 
      timerqe.Interval = 1000;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
      label3.ForeColor = Color.Coral;
      label3.Location = new Point(40, 104);
      label3.Name = "label3";
      label3.Size = new Size(85, 28);
      label3.TabIndex = 5;
      label3.Text = "Kết quả";
      label3.Click += label3_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(730, 246);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(button1);
      Controls.Add(groupBox1);
      Name = "Form1";
      Text = "Form1";
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private GroupBox groupBox1;
    private Button button1;
    private Label label1;
    private CheckBox checkBox4;
    private CheckBox checkBox3;
    private CheckBox checkBox2;
    private CheckBox checkBox1;
    private Label label2;
    private System.Windows.Forms.Timer timerqe;
    private Label label3;
  }
}

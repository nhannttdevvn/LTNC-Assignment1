namespace BaiTapBuoi3
{
  public partial class Form1 : Form
  {
    private int seconds = 0;
    private int minutes = 0;
    private int duration = 5;

    private RadioButton rad1;
    private RadioButton rad2;
    private RadioButton rad3;
    private RadioButton rad4;

    public Form1()
    {
      InitializeComponent();
    }

    private void bt_lam_bai_Click(object sender, EventArgs e)
    {
      if (bt_lam_bai.Text == "Làm bài")
      {
        CreateQuestion();
        timer1.Interval = 1000;
        timer1.Start();
        bt_lam_bai.Text = "Nộp bài";
        lbl_Time.Text = $"Thời gian còn lại: {5 - minutes} phút {60 - seconds} giây.";
        lbl_Time.Visible = true;
      }
      else
      {
        SubmitExam();
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      seconds++;
      if (seconds == 60)
      {
        minutes++;
        seconds = 0;
      }

      if (minutes == 5)
      {
        timer1.Stop();
        MessageBox.Show("Hết thời gian làm bài!", "Thông báo");
        SubmitExam();
        this.Close();
      }
      lbl_Time.Text = $"Thời gian còn lại: {5 - minutes} phút {60 - seconds} giây.";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      lbl_Time.Visible = false;
    }
//frombaithi.cs
  public void ReadQuestion()
    {
      //doc cau hoi tu file text
      List<Question> lq = new List<Question>();
      for (int i = 1; i <= 5; i++)
      {

        Question q = new Question();
        q.Title = "Câu hỏi thứ " + i.ToString();
        q.Text = "Nội dung câu hỏi thứ " + i.ToString();
        q.Anwser1 = "Đáp án 1" + 1;
        q.Anwser2 = "Đáp án 2" + 1;
        q.Anwser3 = "Đáp án 3" + 1;
        q.Anwser4 = "Đáp án 4" + 1;
        q.Result = "Đáp án" + i.ToString();
        lq.Add(q); // lq laf listquestion
      }
  }
    private void CreateQuestion()
    {
      ReadQuestion();
      //bước 1 tạo groupbox
      for (int cau = 1; cau <= lq.Count; cau++)
      {
        GroupBox gb = new GroupBox();
      gb.Name = $"Cau{cau}";
      gb.Size = new Size(445, 305);
        if (cau == 1)
        {
          gb.Location = new Point(54, 60);
        }
        else
        {
          grdPre = (GroupBox)this.Control.Find($"Cau{cau-1}"), f
          gb.Location = new Point(45,grdPre.Location.Y+grdPre.Height+10 );
        }

        for (int i = 1; i <= 4; i++)
        {
          RadioButton rd = new RadioButton();
          rd.Name - $"rdo{cau}_{i}";
          rd.Location = new Point(30, 30 + 20 * (i - 1));
          rd.Font = new Font(Font.);
          gb.Controls.Add(rd);
      }
      }
      
      gb.Anchor = AnchorStyles;


      GroupBox n = new GroupBox();
      n.Name = "grbCau2";
      n.Text = "Câu 2: Câu hỏi thứ hai?";
      n.Size = new Size(grbCau1.Width, grbCau1.Height);
      n.Location = new Point(grbCau1.Location.X, grbCau1.Location.Y + grbCau1.Height + 10);
      this.Controls.Add(n);

      rad1 = new RadioButton();
      rad1.Name = "rdAnswer1";
      rad1.Text = "Đáp án 1";
      rad1.Location = new Point(10, 20);
      n.Controls.Add(rad1);

      rad2 = new RadioButton();
      rad2.Name = "rdAnswer2";
      rad2.Text = "Đáp án 2";
      rad2.Location = new Point(10, 50);
      n.Controls.Add(rad2);

      rad3 = new RadioButton();
      rad3.Name = "rdAnswer3";
      rad3.Text = "Đáp án 3";
      rad3.Location = new Point(10, 80);
      n.Controls.Add(rad3);

      rad4 = new RadioButton();
      rad4.Name = "rdAnswer4";
      rad4.Text = "Đáp án 4";
      rad4.Location = new Point(10, 110);
      n.Controls.Add(rad4);

      Button btnSubmit = new Button();
      btnSubmit.Name = "btnSubmit";
      btnSubmit.Text = "Nộp bài";
      btnSubmit.Size = new Size(100, 30);
      btnSubmit.Location = new Point(n.Width - btnSubmit.Width - 10, n.Height - btnSubmit.Height - 10);
      btnSubmit.Click += (s, e) => SubmitExam();
      n.Controls.Add(btnSubmit);
    }

    private void SubmitExam()
    {
      timer1.Stop();
      timer1.Enabled = false;
      bt_lam_bai.Enabled = false;

      if (rad1 != null && rad1.Checked)
      {
        MessageBox.Show("Chúc mừng bạn đã trả lời đúng!");
      }
      else
      {
        MessageBox.Show("Chúc bạn may mắn lần sau!");
      }
    }
  }
}
//name radiobox: rdAnswer1, rdAnswer2, rdAnswer3, rdAnswer4
//dock button: bottom, right
// anchor: bottom, right ( cho bám trên và phải )

//class Question{
//  public string Text{get; set;}
//  public List<string> Answers{get; set;}
//  public int CorrectAnswerIndex{get; set;}
//}           


//Question.cs
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;   
//using WinFormExample.Entity;
namespace WinFormExample.Entity
{
  public class Question
  {
    public string Text { get; set; }
    public string Title { get; set; }
    public string Anwser1 { get; set; }
    public string Anwser2 { get; set; }
    public string Anwser3 { get; set; }
    public string Anwser4 { get; set; }
    public string Result { get; set; }
  }
}


formbaithi.cs
void CreateQuestion

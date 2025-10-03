using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ListQuestion
{
    public partial class Form1 : Form
    {
        // ====== BIẾN ======
        int durationMinutes = 5;   // thời gian làm bài (phút)
        int elapsedSeconds = 0;    // đã làm được bao nhiêu giây

        private List<Question> lq = new List<Question>();   // danh sách câu hỏi
        private int currentIndex = 0;                       // câu hiện tại
        private List<int> SelectedAnswer = new List<int>(); // lưu đáp án người chọn

        public Form1()
        {
            InitializeComponent();
        }

        // Form mở lên
        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = "C:\\c#\\ListQuestion\\questions.txt";
            LoadQuestions(filePath);

            // Tắt chọn đáp án khi chưa bắt đầu
            EnableAnswers(false);

            // Hiển thị thời gian ban đầu
            lbl_Time.Text = "Đã làm: 00:00 | Còn lại: " + FormatMMSS(durationMinutes * 60);
            lbl_Status.Text = "Bạn chưa chọn câu trả lời.";

            // Gắn sự kiện cho radio
            rad1.CheckedChanged += Answer_CheckedChanged;
            rad2.CheckedChanged += Answer_CheckedChanged;
            rad3.CheckedChanged += Answer_CheckedChanged;
            rad4.CheckedChanged += Answer_CheckedChanged;

            // Timer chạy mỗi 1 giây
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            if (lq.Count > 0) ShowQuestion(0);
        }

        // ====== TIMER ======
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            UpdateTimeLabel();

            if (elapsedSeconds >= durationMinutes * 60)
            {
                SubmitExam(false);
            }
        }

        // ====== LOAD CÂU HỎI ======
        private void LoadQuestions(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Không tìm thấy file câu hỏi!");
                return;
            }

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');
                if (parts.Length == 6)
                {
                    lq.Add(new Question
                    {
                        Title = parts[0],
                        Answer1 = parts[1],
                        Answer2 = parts[2],
                        Answer3 = parts[3],
                        Answer4 = parts[4],
                        CorrectAnswer = int.Parse(parts[5])
                    });
                    SelectedAnswer.Add(0);
                }
            }
        }

        // ====== HIỂN THỊ CÂU HỎI ======
        private void ShowQuestion(int index)
        {
            if (index < 0 || index >= lq.Count) return;

            var q = lq[index];
            lblQuestion.Text = $"Câu {index + 1}/{lq.Count}: {q.Title}";
            rad1.Text = q.Answer1;
            rad2.Text = q.Answer2;
            rad3.Text = q.Answer3;
            rad4.Text = q.Answer4;

            // load lại lựa chọn trước đó
            rad1.Checked = (SelectedAnswer[index] == 1);
            rad2.Checked = (SelectedAnswer[index] == 2);
            rad3.Checked = (SelectedAnswer[index] == 3);
            rad4.Checked = (SelectedAnswer[index] == 4);
        }

        // ====== EVENT CHỌN ĐÁP ÁN ======
        private void Answer_CheckedChanged(object sender, EventArgs e)
        {
            int selected = GetSelectedIndex();
            if (selected == 0)
                lbl_Status.Text = "Bạn chưa chọn câu trả lời.";
            else
            {
                lbl_Status.Text = "Bạn đang chọn " + selected + "/4.";
                SelectedAnswer[currentIndex] = selected;
            }
        }

        // ====== HÀM PHỤ ======
        void EnableAnswers(bool on)
        {
            rad1.Enabled = on;
            rad2.Enabled = on;
            rad3.Enabled = on;
            rad4.Enabled = on;
        }

        int GetSelectedIndex()
        {
            if (rad1.Checked) return 1;
            if (rad2.Checked) return 2;
            if (rad3.Checked) return 3;
            if (rad4.Checked) return 4;
            return 0;
        }

        void UpdateTimeLabel()
        {
            int total = durationMinutes * 60;
            int remain = Math.Max(0, total - elapsedSeconds);
            lbl_Time.Text = "Đã làm: " + FormatMMSS(elapsedSeconds) + " | Còn lại: " + FormatMMSS(remain);
        }

        string FormatMMSS(int sec)
        {
            int m = sec / 60;
            int s = sec % 60;
            return m.ToString("D2") + ":" + s.ToString("D2");
        }

        // ====== NỘP BÀI ======
        void SubmitExam(bool manual)
        {
            timer1.Stop();
            EnableAnswers(false);
            bt_lam_bai.Text = "Làm bài";

            int correct = 0;
            for (int i = 0; i < lq.Count; i++)
            {
                if (SelectedAnswer[i] == lq[i].CorrectAnswer)
                    correct++;
            }

            string msg = $"Bạn làm đúng {correct}/{lq.Count} câu.\n" +
                         $"Thời gian đã làm: {FormatMMSS(elapsedSeconds)}";

            MessageBox.Show(msg, manual ? "Nộp bài" : "Hết giờ - Tự động nộp");
        }

        // ====== BUTTON ======
        private void bt_lam_bai_Click(object sender, EventArgs e)
        {
            if (bt_lam_bai.Text == "Làm bài")
            {
                elapsedSeconds = 0;
                for (int i = 0; i < SelectedAnswer.Count; i++) SelectedAnswer[i] = 0;
                rad1.Checked = rad2.Checked = rad3.Checked = rad4.Checked = false;
                lbl_Status.Text = "Bạn chưa chọn câu trả lời.";
                UpdateTimeLabel();

                EnableAnswers(true);
                timer1.Start();
                bt_lam_bai.Text = "Nộp bài";
                currentIndex = 0;
                ShowQuestion(currentIndex);
            }
            else
            {
                SubmitExam(true);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < lq.Count - 1)
            {
                currentIndex++;
                ShowQuestion(currentIndex);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowQuestion(currentIndex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentIndex < lq.Count - 1)
            {
                currentIndex++;
                ShowQuestion(currentIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (currentIndex > 0)
            {
                currentIndex--;
                ShowQuestion(currentIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

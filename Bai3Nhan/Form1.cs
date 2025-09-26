namespace Bai3Nhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool IsPrime(int so)
        {
            if (so < 2) return false;

            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                    return false;
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtSo.Text, out number))
            {
                cboSo.Items.Add(number);
            }
            else
            {
                MessageBox.Show("Giá trị nhập vào không phải là số hợp lệ!");
            }
        }

        private void listTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int so = int.Parse(txtSo.Text);
            for (int i = 1; i <= so; i++)
            {
                if ((so % i) == 0)
                {
                    listTinh.Items.Add(i);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int so = int.Parse(cboSo.Text);
            int sum = 0;
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    sum += i;
                }
            }
            MessageBox.Show("Tổng các ước của " + so + " là: " + sum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int so = int.Parse(cboSo.Text);
            int count = 0;
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    count++;
                }
            }
            MessageBox.Show("Số các ước của " + so + " là: " + count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int so = int.Parse(cboSo.Text);
            int count = 0;
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    if (IsPrime(i))
                    {
                        count++;
                    }
                }
            }
            MessageBox.Show("Số các số nguyên tố của " + so + " là: " + count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

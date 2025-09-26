namespace bai4Nhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtSo1.Text);
            int num2 = int.Parse(txtSo2.Text);
            int result = num1 + num2;
            txtKQ.Text = result.ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtSo1.Text);
            int num2 = int.Parse(txtSo2.Text);
            int result = num1 - num2;
            txtKQ.Text = result.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtSo1.Text);
            int num2 = int.Parse(txtSo2.Text);
            int result = num1 * num2;
            txtKQ.Text = result.ToString();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtSo1.Text);
            int num2 = int.Parse(txtSo2.Text);
            double result = num1 / num2;
            txtKQ.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

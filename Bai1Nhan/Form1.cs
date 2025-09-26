namespace Bai1Nhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là:";
            thongbao += this.txtUser.Text;
            thongbao += "\nMật khẩu là:";
            thongbao += this.txtPass.Text;

            if(this.chkNho.Checked == true)
            {
                thongbao += "\nGhi nhớ đăng nhập";
            }
            else
            {
                thongbao += "\nKhông ghi nhớ đăng nhập";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "";
            this.txtPass.Text = "";
            this.txtUser.Focus();

        }
    }
}

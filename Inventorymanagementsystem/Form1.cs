using System;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Inventorymanagementsystem
{
    public partial class Form1 : Form
    {
        static public string username;//用戶名，用於保存

        static public string userpassword;//密碼，用於保存
        public Form1()
        {
            InitializeComponent();
            passwordtextBox.PasswordChar = '*';
        }
        private bool pdyj()

        {

            //用if来判斷textbox的内容

            if (nametextBox.Text == "")

                return false;

            if (passwordtextBox.Text == "")

                return false;

            return true;

        }
        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (!pdyj())

            {
                MessageBox.Show("請輸入您的帳號密碼");
                return;
            }

            string oleCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\..\\logindata.accdb";



            OleDbConnection conn = new OleDbConnection(oleCon);

            conn.Open();
            //資料庫查詢語句
            string Access = "select username,userpassword from logindata where username='" + this.nametextBox.Text + "'and userpassword='" + this.passwordtextBox.Text + "'";//select

            OleDbCommand cmd = new OleDbCommand(Access, conn);
            OleDbDataReader hyw = cmd.ExecuteReader();

            if (hyw.Read())

            {
                //判斷

                username = nametextBox.Text;

                userpassword = passwordtextBox.Text;

                //一但连接成功了就跳messegebox

                MessageBox.Show("登入成功！");

                Form f2 = new main();//產生Form2的物件，才可以使用它所提供的Method

                this.Hide();

                f2.ShowDialog();

                this.Dispose();

            }

            else

            {

                //錯誤訊息，判斷條件不成立

                wronglabel.Text = "帳號密碼有誤!!!!";
                nametextBox.Text = "";
                passwordtextBox.Text = "";

            }
        }
    }
}
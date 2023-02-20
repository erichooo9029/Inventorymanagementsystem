using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Inventorymanagementsystem
{
    public partial class loginchange : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\..\\logindata.accdb");
        public loginchange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form f2 = new main();

            this.Hide();

            f2.ShowDialog();

            this.Dispose();
        }

        private void logindataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.logindataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.logindataDataSet);

        }
        private void loginchange_Load(object sender, EventArgs e)
        {
            this.logindataTableAdapter.Fill(this.logindataDataSet.logindata);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into logindata values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("帳號新增成功");
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  logindata set userpassword='" + textBox2.Text + "' where username='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("密碼成功更改");
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from logindata";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewlogin.DataSource = dt;
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

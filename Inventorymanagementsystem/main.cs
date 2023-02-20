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
    public partial class main : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\..\\final.accdb");/**/
        int count = 0;
        public main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into 進貨資訊 values ('" + textBox1.Text+"','"+textBox2.Text+ "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("成功紀錄");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from 進貨資訊";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from 進貨資訊 where id='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("成功刪除");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  進貨資訊 set remainingamount='" +textBox6.Text+ "' where id='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("成功更改");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)/**/
        {
            count=0;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from 進貨資訊 where id='" + textBox1.Text + "' or companyname='" + textBox2.Text + "' or productname='" + textBox3.Text + "' or Purchasedate='" + textBox4.Text + "' or productamount='" + textBox5.Text + "' or remainingamount='" + textBox6.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            if (count == 0)
            {
                MessageBox.Show("無法查到該紀錄,請再確認輸入之資料是否有誤");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f3 = new loginchange();


            f3.ShowDialog();
            this.Hide();
            this.Dispose();
        }
    }
}

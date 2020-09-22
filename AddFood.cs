using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nikadoResturant
{
    public partial class AddFood : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\nikadoResturant\NikadoResturant.mdf;Integrated Security=True");
        public AddFood()
        {
            InitializeComponent();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_dd();
            fill_dg();
        }

        public void fill_dd()
        {
            comboBox1.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CategoryTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["category"].ToString());
            }
        }

        public void fill_dg()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from FoodTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into FoodTable values ('"+textBox1.Text+"','"+comboBox1.SelectedItem.ToString()+"')";
            cmd.ExecuteNonQuery();

            textBox1.Text = "";
            fill_dg();
            MessageBox.Show("Record Inserted Successfuly! ");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            comboBox2.Items.Clear();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from CategoryTable";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                comboBox2.Items.Add(dr2["category"].ToString());
            }

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from FoodTable where id=" + i + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox2.Text = dr["food_item"].ToString();
                comboBox2.SelectedItem= dr["category"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            MessageBox.Show("Update Successfully !");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update FoodTable set food_item='" + textBox2.Text + "',category='"+comboBox2.SelectedItem.ToString()+"' where id="+i+"";
            cmd.ExecuteNonQuery();
            panel2.Visible = false;
            fill_dg();
        }
    }
}

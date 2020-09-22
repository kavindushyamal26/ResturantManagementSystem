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
    public partial class Purchase_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\nikadoResturant\NikadoResturant.mdf;Integrated Security=True");
        public Purchase_info()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purchase_info_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_product_name();
            fill_supplier_name();
        }

        public void fill_product_name()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from FoodTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Food_item"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from FoodTable where food_item='"+comboBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                label3.Text = dr["category"].ToString();
            }
        }

        public void fill_supplier_name()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DealersTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["dealer_name"].ToString());
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox4.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from stock where product_name='"+comboBox1.Text+"'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            i = Convert.ToInt32(dt1.Rows.Count.ToString());

            if (i == 0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into PurchaseTable values ('" + comboBox1.Text + "','" + textBox3.Text + "','" + label3.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.ToString("DD-MM-YYYY") + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + dateTimePicker2.Value.ToString("DD-MM-YYYY") + "') ";
                cmd.ExecuteNonQuery();

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into stock values ('" + comboBox1.Text + "','" + textBox3.Text + "','" + label3.Text + "') ";
                cmd3.ExecuteNonQuery();
            }

            else
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "insert into PurchaseTable values ('" + comboBox1.Text + "','" + textBox3.Text + "','" + label3.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.ToString("DD-MM-YYYY") + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + dateTimePicker2.Value.ToString("DD-MM-YYYY") + "') ";
                cmd2.ExecuteNonQuery();

                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "update stock set product_qty=product_qty+"+textBox3.Text+" where product_name='"+comboBox1.Text+"' ";
                cmd4.ExecuteNonQuery();
            }

            MessageBox.Show("Record Entered Successfully !");
        }
    }
}

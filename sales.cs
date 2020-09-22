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
    public partial class sales : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\nikadoResturant\NikadoResturant.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        int total;

        public sales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sales_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dt.Clear();
            dt.Columns.Add("product");
            dt.Columns.Add("price");
            dt.Columns.Add("qty");
            dt.Columns.Add("total");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock where product_name like('"+textBox3.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["product_name"].ToString());
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex + 1;                    
                }
                if (e.KeyCode == Keys.Up)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex - 1;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    textBox1.Text = listBox1.SelectedItem.ToString();
                    listBox1.Visible = false;
                    textBox2.Focus();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from PurchaseTable where product_name='" + textBox1.Text + "' order by id desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                textBox2.Text = dr["product_price"].ToString();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text));
            }
            catch(Exception ex)
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stock = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from stock where product_name='" + textBox1.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                stock =Convert.ToInt32(dr1["product_qty"].ToString());
            }
            if (Convert.ToInt32(textBox3.Text) > stock)
            {
                MessageBox.Show("This much value is not available!");
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["product"] = textBox1.Text;
                dr["price"] = textBox2.Text;
                dr["qty"] = textBox3.Text;
                dr["total"] = textBox4.Text;
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;

                total = total + Convert.ToInt32(dr["total"].ToString());

                label10.Text = total.ToString();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                total = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString()));
                foreach (DataRow dr1 in dt.Rows)
                {
                    total = total + Convert.ToInt32(dr1["total"].ToString());
                    label10.Text = total.ToString();
                }
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string orderid=" ";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into Order_User values('"+comboBox1.Text+"','"+comboBox2.Text+"','"+dateTimePicker1.Value.ToString("dd/mm/yyyy")+"')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from Order_User order by id desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                orderid = dr2["id"].ToString();
            }

            foreach (DataRow dr in dt.Rows)
            {
                int qty = 0;
                string pname = "";

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into Order_Item values('" + orderid.ToString() + "','" + dr["product"].ToString() + "','" + dr["price"].ToString() + "','" + dr["qty"].ToString() + "','" + dr["total"].ToString() + "')";
                cmd3.ExecuteNonQuery();

                qty=Convert.ToInt32(dr["qty"].ToString());
                pname = dr["product"].ToString();

                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "update stock set product_qty=product_qty-"+ qty +" where product_name='"+pname.ToString()+"'";
                cmd6.ExecuteNonQuery();
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label10.Text = "";
            dt.Clear();
            dataGridView1.DataSource = dt;
            MessageBox.Show("Record Entered Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string orderid = " ";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into Order_User values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Value.ToString("dd/mm/yyyy") + "')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from Order_User order by id desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                orderid = dr2["id"].ToString();
            }

            foreach (DataRow dr in dt.Rows)
            {
                int qty = 0;
                string pname = "";

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into Order_Item values('" + orderid.ToString() + "','" + dr["product"].ToString() + "','" + dr["price"].ToString() + "','" + dr["qty"].ToString() + "','" + dr["total"].ToString() + "')";
                cmd3.ExecuteNonQuery();

                qty = Convert.ToInt32(dr["qty"].ToString());
                pname = dr["product"].ToString();

                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "update stock set product_qty=product_qty-" + qty + " where product_name='" + pname.ToString() + "'";
                cmd6.ExecuteNonQuery();
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label10.Text = "";
            dt.Clear();
            dataGridView1.DataSource = dt;

            generate_bill gb = new generate_bill();
            gb.get_value(Convert.ToInt32(orderid.ToString()));
            gb.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

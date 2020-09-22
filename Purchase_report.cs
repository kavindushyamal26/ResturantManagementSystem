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
    public partial class Purchase_report : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\nikadoResturant\NikadoResturant.mdf;Integrated Security=True");
        String query = "";
        public Purchase_report()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PurchaseTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            foreach (DataRow dr in dt.Rows)
            {
                i = i + Convert.ToInt32(dr["product_total"].ToString());
            }
            label3.Text = i.ToString();
            query = "select * from PurchaseTable";
        }

        private void Purchase_report_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startdate;
            string enddate;

            startdate = dateTimePicker1.Value.ToString("dd/mm/yyyy");
            enddate = dateTimePicker2.Value.ToString("dd/mm/yyyy");
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PurchaseTable where purchase_date>='"+startdate.ToString()+"' AND purchase_date<='"+enddate.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            foreach (DataRow dr in dt.Rows)
            {
                i = i + Convert.ToInt32(dr["product_total"].ToString());
            }
            label3.Text = i.ToString();
            query = "select * from PurchaseTable where purchase_date>='" + startdate.ToString() + "' AND purchase_date<='" + enddate.ToString() + "'";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            generate_purchase_report gpr = new generate_purchase_report();
            gpr.get_value(query.ToString());
            gpr.Show();
        }
    }
}

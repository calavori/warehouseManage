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
namespace warehouse
{
    public partial class sources : Form
    {
        public sources()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DV7BHAI\SQLEXPRESS;Initial Catalog=kho;Integrated Security=True");
        class ConnectionString
        {
            public static string connectionString = (@"Data Source=DESKTOP-DV7BHAI\SQLEXPRESS;Initial Catalog=kho;Integrated Security=True");
        }
        DataSet Getlist()
        {
            DataSet data = new DataSet();
            string query = "Select * from Sources";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            dgvlist.DataSource = Getlist().Tables[0];
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Sources ON Insert into Sources(s_id,s_name,s_phone,s_adress) values(N'" + txtid.Text + "',N'" + txtname.Text + "',N'" + txtphone.Text + "', N'"+ txtaddress.Text +"')", con);
                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {


                if (ex.Message.Contains("Cannot insert duplicate key in object"))
                {
                    SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Sources ON Update Sources set s_name =N'" + txtname.Text + "', s_phone =N'"+ txtphone.Text+"', s_adress =N'"+ txtaddress.Text +"' where s_id ='" + txtid.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    dgvlist.DataSource = Getlist().Tables[0];
                }
                else
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete  from Sources where s_id='" + txtid.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

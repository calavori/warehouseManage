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
    public partial class Kho : Form
    {
        public Kho()
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
            string query = "Select * from warehouse";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
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

                SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT warehouse ON Insert into warehouse(w_id,w_adress) values(N'" + txtid.Text + "',N'" + txtaddress.Text + "')", con);
                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {


                if (ex.Message.Contains("Cannot insert duplicate key in object"))
                {
                    SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT warehouse ON Update warehouse set w_adress ='" + txtaddress.Text + "' where w_id ='"+txtid.Text+"'", con);
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
            SqlCommand cmd = new SqlCommand("delete from warehouse where w_id='" + txtid.Text + "'and w_adress ='" + txtaddress.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dgvlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

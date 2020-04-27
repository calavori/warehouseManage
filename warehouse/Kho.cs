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
            dgvlist.DataSource = getList().Tables[0];
        }
  
        DataSet getList()
        {
            DataSet data = new DataSet();
            string query = "Select * from warehouse";
            using (Connection.conn)
            {
                Connection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.conn);
                adapter.Fill(data);
                Connection.CloseConnection();
            }
            return data;
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            dgvlist.DataSource = getList().Tables[0];
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            try
            {
                if (txtid.Text == "")
                {
                    SqlCommand cmd = new SqlCommand("Insert into warehouse values ('" + txtaddress.Text + "')", Connection.conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Update warehouse set address ='" + txtaddress.Text + "' where id ='" + txtid.Text + "'", Connection.conn);
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.CloseConnection();
                dgvlist.DataSource = getList().Tables[0];
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            SqlCommand cmd = new SqlCommand("delete from warehouse where id='" + txtid.Text + "'and address ='" + txtaddress.Text + "'", Connection.conn);
            cmd.ExecuteNonQuery();
            Connection.CloseConnection();
            dgvlist.DataSource = getList().Tables[0];
        }

        private void dgvlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvlist.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtaddress.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}

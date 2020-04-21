using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse
{
    public partial class ImportDetail : Form
    {
        private string i_id;

        public ImportDetail(string i_id)
        {
            InitializeComponent();
            this.i_id = i_id;
            dgvlist.DataSource = getList().Tables[0];
        }

        DataSet getList()
        {
            DataSet data = new DataSet();
            string query = "Select p_id, quanity from import_detail where i_id=" + i_id.ToString();
            using (Connection.conn)
            {
                Connection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.conn);
                adapter.Fill(data);
                Connection.CloseConnection();
            }
            return data;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            dgvlist.DataSource = this.getList().Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            try
            {

                string str = "Insert into import_detail values (@i_id, @p_id, @quanity)";
                Connection.OpenConnection();
                SqlCommand com = new SqlCommand(str, Connection.conn);

                SqlParameter p1 = new SqlParameter("@i_id", SqlDbType.VarChar);
                p1.Value = i_id;
                SqlParameter p2 = new SqlParameter("@p_id", SqlDbType.VarChar);
                p2.Value = txtPId.Text;
                SqlParameter p3 = new SqlParameter("@quanity", SqlDbType.VarChar);
                p3.Value = txtQuanity.Text;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {


                if (ex.Message.Contains("Cannot insert duplicate key in object"))
                {
                    string str = "Update Import_detail set quanity=@quanity where i_id=@i_id and p_id=@p_id";
                    Connection.OpenConnection();
                    SqlCommand com = new SqlCommand(str, Connection.conn);

                    SqlParameter p1 = new SqlParameter("@quanity", SqlDbType.VarChar);
                    p1.Value = txtQuanity.Text;
                    SqlParameter p2 = new SqlParameter("@i_id", SqlDbType.VarChar);
                    p2.Value = i_id;
                    SqlParameter p3 = new SqlParameter("@p_id", SqlDbType.VarChar);
                    p3.Value = txtPId.Text;

                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);
                    com.Parameters.Add(p3);
                    com.ExecuteNonQuery();
                }
                else
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.CloseConnection();
                dgvlist.DataSource = this.getList().Tables[0];
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "delete from Import_detail where i_id=@i_id and p_id = @p_id ";
                Connection.OpenConnection();
                SqlCommand com = new SqlCommand(str, Connection.conn);

                SqlParameter p1 = new SqlParameter("@i_id", SqlDbType.VarChar);
                p1.Value = this.i_id;
                SqlParameter p2 = new SqlParameter("@p_id", SqlDbType.VarChar);
                p2.Value = txtPId.Text;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.CloseConnection();
                dgvlist.DataSource = this.getList().Tables[0];
            }
        }

        private void dgvlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvlist.Rows[e.RowIndex];
                txtPId.Text = row.Cells[0].Value.ToString();
                txtQuanity.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}

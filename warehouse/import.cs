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
    public partial class import : Form
    {
        public import()
        {
            InitializeComponent();
            dgvlist.DataSource = getList().Tables[0];
            txtDate.Text = DateTime.Now.ToString("yyyy/M/d");
        }

        DataSet getList()
        {
            DataSet data = new DataSet();
            string query = "Select * from import";
            using (Connection.conn)
            {
                Connection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.conn);
                adapter.Fill(data);
                Connection.CloseConnection();
            }
            return data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            try
            {
                if (txtIId.Text == "")
                {

                    string str = "Insert into import values (@w_id, @s_id, @date)";
                    Connection.OpenConnection();
                    SqlCommand com = new SqlCommand(str, Connection.conn);

                    SqlParameter p1 = new SqlParameter("@w_id", SqlDbType.VarChar);
                    p1.Value = txtWId.Text;
                    SqlParameter p2 = new SqlParameter("@s_id", SqlDbType.VarChar);
                    p2.Value = txtSId.Text;
                    SqlParameter p3 = new SqlParameter("@date", SqlDbType.Date);
                    p3.Value = txtDate.Text;

                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);
                    com.Parameters.Add(p3);
                    com.ExecuteNonQuery();

                    string query = "Select max(id) from import";
                    using (Connection.conn)
                    {
                        SqlCommand cmd = new SqlCommand(query, Connection.conn);
                        int i_id = (Int32)cmd.ExecuteScalar();

                        ImportDetail importDetail = new ImportDetail(i_id.ToString());
                        importDetail.ShowDialog();
                    }

                }
                else
                {
                    string str = "Update Import set w_id=@w_id, s_id=@s_id, date=@date where id=@i_id";
                    Connection.OpenConnection();
                    SqlCommand com = new SqlCommand(str, Connection.conn);

                    SqlParameter p1 = new SqlParameter("@w_id", SqlDbType.VarChar);
                    p1.Value = txtWId.Text;
                    SqlParameter p2 = new SqlParameter("@s_id", SqlDbType.VarChar);
                    p2.Value = txtSId.Text;
                    SqlParameter p3 = new SqlParameter("@date", SqlDbType.Date);
                    p3.Value = txtDate.Text;
                    SqlParameter p4 = new SqlParameter("@i_id", SqlDbType.VarChar);
                    p4.Value = txtIId.Text;

                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);
                    com.Parameters.Add(p3);
                    com.Parameters.Add(p4);
                    com.ExecuteNonQuery();
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



        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "delete from Import where id=@i_id";
                Connection.OpenConnection();
                SqlCommand com = new SqlCommand(str, Connection.conn);

                SqlParameter p1 = new SqlParameter("@i_id", SqlDbType.VarChar);
                p1.Value = txtIId.Text;

                com.Parameters.Add(p1);
                com.ExecuteNonQuery();
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (txtIId.Text != "")
            {
                ImportDetail importDetail = new ImportDetail(txtIId.Text);
                importDetail.ShowDialog();
            }
        }



        private void dgvlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvlist.Rows[e.RowIndex];
                txtIId.Text = row.Cells[0].Value.ToString();
                txtWId.Text = row.Cells[1].Value.ToString();
                txtSId.Text = row.Cells[2].Value.ToString();
                txtDate.Text = row.Cells[3].Value.ToString();
            }
        }

    }
}
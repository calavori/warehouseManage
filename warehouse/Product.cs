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
    public partial class Product : Form
    {

        bool editMode = false;
        int c_id;

        public Product()
        {
            InitializeComponent();
            dgvList.DataSource = GetList().Tables[0];
            LoadCategoryName();

        }

        DataSet GetList()
        {
            DataSet d = new DataSet();
            string query = "Select product.id, product.c_id, product.name,categories.name from product inner join categories on product.c_id=categories.id";
            using (Connection.conn)
            {
                Connection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.conn);
                adapter.Fill(d);
                Connection.CloseConnection();
            }
            return d;
        }

        void LoadCategoryName() 
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "select * from categories";
                Connection.OpenConnection();
                SqlCommand com = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = com.ExecuteReader();

                DataColumn dc1 = new DataColumn("id");
                DataColumn dc2 = new DataColumn("name");
                dt.Columns.Add(dc1);
                dt.Columns.Add(dc2);

                while (dr.Read())
                {
                    dt.Rows.Add(Convert.ToInt32(dr[0]), dr[1].ToString());

                }

                cboCategory.DataSource = dt;
                cboCategory.ValueMember = "id";
                cboCategory.DisplayMember = "name";

                Connection.CloseConnection();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void ResetFields(bool status)
        {
            txtID.Clear();
            txtName.Clear();
            cboCategory.SelectedIndex = -1;
            btnSave.Enabled = status;
            btnDelete.Enabled = status;
            btnCancel.Enabled = status;
            btnAdd.Enabled = !status;
            txtName.Focus();
            editMode = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetFields(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFields(false);
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ResetFields(true);
                DataGridViewRow row = new DataGridViewRow();
                row = dgvList.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value.ToString();

                c_id = Convert.ToInt32(row.Cells[1].Value);

                txtName.Text = row.Cells[2].Value.ToString();

                int cboIndex = cboCategory.FindString(row.Cells[3].Value.ToString());
                cboCategory.SelectedIndex = cboIndex;

                editMode = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                try
                {
                    string strUpdate = "update product set c_id=@cid, name=@name where id=@id";
                    Connection.OpenConnection();
                    SqlCommand com = new SqlCommand(strUpdate, Connection.conn);

                    SqlParameter p1 = new SqlParameter("@cid", SqlDbType.Int);
                    p1.Value = c_id;

                    SqlParameter p2 = new SqlParameter("@name", SqlDbType.NVarChar);
                    p2.Value = txtName.Text;

                    SqlParameter p3 = new SqlParameter("@id", SqlDbType.Int);
                    p3.Value = txtID.Text;

                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);
                    com.Parameters.Add(p3);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Edit Successful");
                    Connection.CloseConnection();
                    ResetFields(false);
                    dgvList.DataSource = GetList().Tables[0];

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                try
                {
                    string strInsert = "Insert into product Values(@c_id, @name)";
                    Connection.OpenConnection();
                    SqlCommand com = new SqlCommand(strInsert, Connection.conn);

                    SqlParameter p1 = new SqlParameter("@c_id", SqlDbType.Int);
                    p1.Value = c_id;

                    SqlParameter p2 = new SqlParameter("@name", SqlDbType.NVarChar);
                    p2.Value = txtName.Text;

                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Add Successful");
                    Connection.CloseConnection();
                    ResetFields(false);
                    dgvList.DataSource = GetList().Tables[0];

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cid = "";
            DataRowView drv = (DataRowView)cboCategory.SelectedItem;
            if (drv != null)
            {
                cid = drv["id"].ToString(); 
                c_id = Convert.ToInt32(cid);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                try
                {
                    string strDelete = "delete from product where id=@id";
                    Connection.OpenConnection();
                    SqlCommand com = new SqlCommand(strDelete, Connection.conn);

                    SqlParameter p1 = new SqlParameter("@id", SqlDbType.Int);
                    p1.Value = txtID.Text;


                    com.Parameters.Add(p1);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Delete Successful");
                    Connection.CloseConnection();
                    ResetFields(false);
                    dgvList.DataSource = GetList().Tables[0];

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                ResetFields(false);
            }
        }
    }
}

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
    public partial class Category : Form
    {
        bool editMode = false;

        public Category()
        {
            InitializeComponent();
            dgvList.DataSource = GetList().Tables[0];
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }
        DataSet GetList()
        {
            DataSet d = new DataSet();
            string query = "Select * from categories";
            using (Connection.conn)
            {
                Connection.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection.conn);
                adapter.Fill(d);
                Connection.CloseConnection();
            }
            return d;
        }

        void ResetFields(bool status)
        {
            txtID.Clear();
            txtName.Clear();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                try
                {
                    string strUpdate = "update categories set name=@Name where id=@id";
                    Connection.OpenConnection();
                    SqlCommand com = new SqlCommand(strUpdate, Connection.conn);

                    SqlParameter p1 = new SqlParameter("@name", SqlDbType.NVarChar);
                    p1.Value = txtName.Text;

                    SqlParameter p2 = new SqlParameter("@id", SqlDbType.Int);
                    p2.Value = txtID.Text;

                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Edit Successful");
                    Connection.CloseConnection();
                    ResetFields(false);
                    dgvList.DataSource = GetList().Tables[0];

                }
                catch (Exception Ex) {
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                try
                {
                    string strInsert = "Insert into categories Values(@name)";
                    Connection.OpenConnection();
                    SqlCommand com = new SqlCommand(strInsert, Connection.conn);

                    SqlParameter p1 = new SqlParameter("@name", SqlDbType.NVarChar);
                    p1.Value = txtName.Text;

                    com.Parameters.Add(p1);
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

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ResetFields(true);
                DataGridViewRow row = new DataGridViewRow();
                row = dgvList.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                editMode = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                try
                {
                    string strDelete = "delete from categories where id=@id";
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

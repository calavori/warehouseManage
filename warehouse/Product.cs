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
            catch (Exception)
            {

            }

        }

    }
}

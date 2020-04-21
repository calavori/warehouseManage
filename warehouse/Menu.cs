using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            Kho kho = new Kho();
            kho.Show();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            sources s = new sources();
            s.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            import i = new import();
            i.Show();
        }
    }
}

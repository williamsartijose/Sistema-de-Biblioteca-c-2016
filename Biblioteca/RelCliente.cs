using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class RelCliente : Form
    {
        public RelCliente()
        {
            InitializeComponent();
        }

        private void RelCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BIBLIOTECADataSet.Cliente' table. You can move, or remove it, as needed.
            this.ClienteTableAdapter.Fill(this.BIBLIOTECADataSet.Cliente);

            this.reportViewer1.RefreshReport();
            
        }
    }
}

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
    public partial class RelItem : Form
    {
        public RelItem()
        {
            InitializeComponent();
        }

        private void RelItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BIBLIOTECADataSet.Itens_Locacao' table. You can move, or remove it, as needed.
            this.Itens_LocacaoTableAdapter.Fill(this.BIBLIOTECADataSet.Itens_Locacao);

            this.reportViewer1.RefreshReport();
        }
    }
}

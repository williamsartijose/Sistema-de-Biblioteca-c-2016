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
    public partial class RelLivro : Form
    {
        public RelLivro()
        {
            InitializeComponent();
        }

        private void RelLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BIBLIOTECADataSet.Livro' table. You can move, or remove it, as needed.
            this.LivroTableAdapter.Fill(this.BIBLIOTECADataSet.Livro);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class frmFuncionario : Form
    {
        Camadas.BLL.Funcionario bllfunc= new Camadas.BLL.Funcionario();
        List<Camadas.MODEL.Funcionario> listFunc = new List<Camadas.MODEL.Funcionario>();
       Funcionario funcionario = new Funcionario();



        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            rdbTodos.Checked = true;
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblTexto.Text = "";
            txtBusc.Visible = true;
            txtBusc.Focus();
        }

        private void btnBusc_Click(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();// camando os parametros da dal
            if (rdbTodos.Checked == true)
                listFunc = bllfunc.Select();
            else if (rdbCod.Checked == true)
                listFunc = bllfunc.SelectById(Convert.ToInt32(txtBusc.Text));
            else if (rdbNome.Checked == true)
                listFunc = bllfunc.SelectByNome(txtBusc.Text);
            dtgvFuncionario.DataSource = "";
            dtgvFuncionario.DataSource = listFunc;
        }

        private void rdbCod_CheckedChanged(object sender, EventArgs e)
        {
            lblTexto.Text = "Informe o Codigo: ";
            txtBusc.Visible = true;
            txtBusc.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblTexto.Text = "Informe o Nome: ";
            txtBusc.Visible = true;
            txtBusc.Focus(); 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

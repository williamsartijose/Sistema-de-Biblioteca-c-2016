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
    public partial class frmBuscar : Form
    {
        Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
        List<Camadas.MODEL.Cliente> listCli = new List<Camadas.MODEL.Cliente>();
        Cliente cliente = new Cliente();




        public frmBuscar()
        {
            InitializeComponent();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {

          lblTexto.Text = "";
          txtBusc.Visible = true;
          txtBusc.Focus();
        }

        private void btnBusc_Click_1(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();// camando os parametros da dal
            if (rdbTodos.Checked == true)
                listCli = dalCli.Select();
             else if (rdbCod.Checked == true)
                listCli = dalCli.SelectById(Convert.ToInt32(txtBusc.Text));
            else if (rdbNome.Checked == true)
                listCli = dalCli.SelectByNome(txtBusc.Text);
            dtgvCliente.DataSource = "";
            dtgvCliente.DataSource = listCli;
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

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            dtgvCliente.DataSource = bllCliente.Select();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Camadas;

namespace Biblioteca
{
    public partial class Cliente : Form
    {
        private char OP = 'X';

        public List<Camadas.MODEL.Cliente> lstcli { get; set; }
            

            

        public Cliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.buscacep.correios.com.br/");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            
            OP = 'I';
            habilitaCampos(true);
            txtNome.Focus();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            dtgvCliente.DataSource = bllCliente.Select();

            habilitaCampos(false);

        }

        private void habilitaCampos(bool status)
        {
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;


            txtId.Enabled = false;
            txtNome.Enabled = status;
            txtEnd.Enabled = status;
            txtCidade.Enabled = status;
            txtEstado.Enabled = status;
            txtAniversario.Enabled = status;
            txtCpf.Enabled = status;
            txtNumero.Enabled = status;
            txtBairro.Enabled = status;
            dtgvCliente.Enabled = !status;

            if (OP != 'E')
            {
                txtId.Text = "-1";
                txtNome.Text = "";
                txtAniversario.Text = "";
                txtCpf.Text = "";
                txtEnd.Text = string.Empty; 
                txtBairro.Text = "";
                txtNumero.Text = "";
                txtCidade.Text = "";
                txtEstado.Text = "";


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) > 0)// se txt id  op = e  habilitar campos verdadeiro 
            {
                OP = 'E';
                habilitaCampos(true);
                txtNome.Focus();
            }
            else MessageBox.Show("Não há registro Selecionado ..... ");
        }


        /// botão remover 
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) > 0) // se id for  maior que 0 
            {
                Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
                Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();

                cliente.id = Convert.ToInt32(txtId.Text);
                DialogResult result;
                result = MessageBox.Show("Deseja Remover o cliente Selecionado???",
                                          "Remover Cliente??",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question,
                                          MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    bllCliente.Delete(cliente);
                    MessageBox.Show("Cliente Removido com Sucesso.. :)");
                }
                else MessageBox.Show("Não confirmada Remoção de Cliente...", "Remover?");


                dtgvCliente.DataSource = bllCliente.Select(); //atualizar lista de registro
                habilitaCampos(false);
            }
            else MessageBox.Show("Não há registros Selecionados", "Remover?");


        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();

            //preencher o objeto cliente com os dados do formulario
            cliente.id = Convert.ToInt32(txtId.Text);
            cliente.nome = txtNome.Text;
            cliente.aniversario = Convert.ToDateTime(txtAniversario.Text);
            cliente.cpf = Convert.ToString(txtCpf.Text); //erro
            cliente.endereco = txtEnd.Text;
            cliente.bairro = txtBairro.Text;
            cliente.numero = Convert.ToInt32(txtNumero.Text);
            cliente.cidade = txtCidade.Text;
            cliente.estado = txtEstado.Text;
           
            
            string msg;
            if (OP == 'I')
                msg = "Deseja Confirmar Inserção dos Dados?";
            else msg = "Deseja Confirmar Alteração dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (resp == DialogResult.OK)
            {
                if (OP == 'I')
                    bllCliente.Insert(cliente);
                else bllCliente.Update(cliente);
            }

            dtgvCliente.DataSource = bllCliente.Select();

            OP = 'X';
            habilitaCampos(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OP = 'X';
            habilitaCampos(false);

        }
  
           

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar  busc = new frmBuscar();
            busc.ShowDialog();
           dtgvCliente.DataSource = lstcli;
        }

        private void dtgvCliente_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvCliente.SelectedRows.Count > 0)
            {

                txtId.Text = dtgvCliente.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dtgvCliente.SelectedRows[0].Cells["nome"].Value.ToString();
                txtAniversario.Text = dtgvCliente.SelectedRows[0].Cells["aniversario"].Value.ToString();
                txtCpf.Text = dtgvCliente.SelectedRows[0].Cells["cpf"].Value.ToString();
                txtEnd.Text = dtgvCliente.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtBairro.Text = dtgvCliente.SelectedRows[0].Cells["bairro"].Value.ToString();
                txtNumero.Text = dtgvCliente.SelectedRows[0].Cells["numero"].Value.ToString();
                txtCidade.Text = dtgvCliente.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtEstado.Text = dtgvCliente.SelectedRows[0].Cells["estado"].Value.ToString();

            }
        }
    }
}

        


        
    


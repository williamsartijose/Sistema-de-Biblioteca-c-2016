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
    public partial class Livro : Form
    {
        private char OP = 'X';
        public List<Camadas.MODEL.Livro> lstLiv { get; set; }

        public Livro()
        {
            InitializeComponent();

        }
        private void Livro_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Livro bllLivro = new Camadas.BLL.Livro();
            dtgvLivro.DataSource = bllLivro.Select();

            habilitaCampos(false);
        }

        private void habilitaCampos(bool status)
        {
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;

            txtIdLiv.Enabled = false;
            txtTitulo.Enabled = status;
            txtEdicao.Enabled = status;
         
            txtGen.Enabled = status;
            txtQuan.Enabled = status;
            txtAutor.Enabled = status;
            dtgvLivro.Enabled = !status;

            if (OP != 'E')
            {
                txtIdLiv.Text = "-1";
                txtTitulo.Text = "";
                txtEdicao.Text = string.Empty;
                
                txtGen.Text = "";
                txtQuan.Text = "";
                txtAutor.Text = "";
                dtgvLivro.Text = "";
            }
        }



        private void btnInserir_Click(object sender, EventArgs e)
        {
            OP = 'I';
            habilitaCampos(true);
            txtTitulo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdLiv.Text) > 0)
            {
                OP = 'E';
                habilitaCampos(true);
                txtTitulo.Focus();
            }
            else MessageBox.Show("Não há registro Selecionado");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdLiv.Text) > 0)
            {
                Camadas.MODEL.Livro livro = new Camadas.MODEL.Livro();
                Camadas.BLL.Livro bllLivro = new Camadas.BLL.Livro();

                livro.id= Convert.ToInt32(txtIdLiv.Text);
                DialogResult result;
                result = MessageBox.Show("Deseja Remover o Livro  Selecionado?",
                                          "Remover Livro ?",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question,
                                          MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    bllLivro.Delete(livro);
                    MessageBox.Show("Livro Removido com Sucesso :) ");
                }
                else MessageBox.Show("Não confirmada Remoção de Livro...", "Remover");


                dtgvLivro.DataSource = bllLivro.Select();
                habilitaCampos(false);
            }
            else MessageBox.Show("Não há registros Selecionados", "Remover");


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Livro livro = new Camadas.MODEL.Livro();
            Camadas.BLL.Livro bllLivro = new Camadas.BLL.Livro();



            livro.id = Convert.ToInt32(txtIdLiv.Text);
            livro.titulo = txtTitulo.Text;
            livro.edicao = Convert.ToInt32(txtEdicao.Text);
            livro.genero = Convert.ToString(txtGen.Text);
            livro.quantidade = Convert.ToInt32(txtQuan.Text);
            livro.autor = txtAutor.Text;




            string msg;
            if (OP == 'I')
                msg = "Deseja Confirmar Inserção dos Dados?";
            else msg = "Deseja Confirmar Alteração dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (resp == DialogResult.OK)
            {
                if (OP == 'I')
                    bllLivro.Insert(livro);
                else bllLivro.Update(livro);
            }

            dtgvLivro.DataSource = bllLivro.Select();

            OP = 'X';
            habilitaCampos(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OP = 'X';
            habilitaCampos(false);
        }

        private void dtgvLivro_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvLivro.SelectedRows.Count > 0)
            {
                txtIdLiv.Text = dtgvLivro.SelectedRows[0].Cells["id_livro"].Value.ToString();
                txtTitulo.Text = dtgvLivro.SelectedRows[0].Cells["titulo"].Value.ToString();
                txtEdicao.Text = dtgvLivro.SelectedRows[0].Cells["edicao"].Value.ToString();
                txtGen.Text = dtgvLivro.SelectedRows[0].Cells["genero"].Value.ToString();
                txtQuan.Text = dtgvLivro.SelectedRows[0].Cells["quantidade"].Value.ToString();
                txtAutor.Text = dtgvLivro.SelectedRows[0].Cells["autor"].Value.ToString();
                //txtAutor.Text = dtgvLivro.SelectedRows[0].Cells["autor"].Value.ToString();
          
                
            }


        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
              Camadas.BLL.Livro bllLivro = new Camadas.BLL.Livro();
            List<Camadas.MODEL.Livro> lstLivro = new List<Camadas.MODEL.Livro>();

            if (rdbTodos.Checked)
               lstLivro = bllLivro.Select();
            else if (txtBusca.Text != string.Empty)//       recebe vazi
            {
                if (rdbCodigo.Checked)
                    lstLivro = bllLivro.SelectById(Convert.ToInt32(txtBusca.Text));
                else if (rdbNome.Checked)
                    lstLivro = bllLivro.SelectByNome(txtBusca.Text); 
            }
            else MessageBox.Show("Não foi Informado Valor de Pesquisa");

            dtgvLivro.DataSource = lstLivro; 
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblBusca.Visible = false;
            txtBusca.Visible = false; 
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            lblBusca.Text = "Informe o Codigo: ";
            txtBusca.Text = "";
            lblBusca.Visible = true;
            txtBusca.Visible = true;
            txtBusca.Focus(); 
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblBusca.Text = "Informe o Nome: ";
            txtBusca.Text = "";
            lblBusca.Visible = true;
            txtBusca.Visible = true;
            txtBusca.Focus(); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlBusca.Visible = !pnlBusca.Visible;
        }
        }

       


        }


    


        
        

       

       
        
    


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
    public partial class Funcionario : Form
    {
        private char OP = 'X'; 

        public Funcionario()
        {
            InitializeComponent();
        }

        public List<Camadas.MODEL.Funcionario> lstFuncionario{ get; set; }
        

        private void Funcionario_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Funcionario bllFuncionario = new Camadas.BLL.Funcionario();
            dtgvFuncionario.DataSource = bllFuncionario.Select();

            habilitaCampos(false); 
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            OP = 'I';
            habilitaCampos(true);
            txtNome.Focus();
        }


        private void habilitaCampos(bool status)
        {
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;


            txtIdFun.Enabled = false;
            txtNome.Enabled = status;

           
            txtPerfil.Enabled = status;
            dtgvFuncionario.Enabled = !status;

            if (OP != 'E')
            {
                txtIdFun.Text = "-1";
                txtNome.Text = "";
                txtPerfil.Text = "";
               

            }
        }

      private void dtgvFuncionario_DoubleClick(object sender, EventArgs e)
        {
            
            if (dtgvFuncionario.SelectedRows.Count > 0)
            {
                txtIdFun.Text = dtgvFuncionario.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dtgvFuncionario.SelectedRows[0].Cells["nome"].Value.ToString();
                txtPerfil.Text = dtgvFuncionario.SelectedRows[0].Cells["Perfil"].Value.ToString();                    
            }
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            Camadas.MODEL.Funcionario funcionario = new Camadas.MODEL.Funcionario();
            Camadas.BLL.Funcionario bllFuncionario = new Camadas.BLL.Funcionario();
           
            //preencher o objeto Funcionarios com os dados do formulario
            funcionario.id = Convert.ToInt32(txtIdFun.Text);
            funcionario.nome = txtNome.Text;
            funcionario.perfil = txtPerfil.Text;
           
            string msg;
            if (OP == 'I')
                msg = "Deseja Confirmar Inserção dos Dados?";
            else msg = "Deseja Confirmar Alteração dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1); 
            
            if (resp == DialogResult.OK)
            {
                if (OP == 'I')
                    bllFuncionario.Insert(funcionario);
                else bllFuncionario.Update(funcionario);  
            }

            dtgvFuncionario.DataSource = bllFuncionario.Select(); 

            OP = 'X';
            habilitaCampos(false);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdFun.Text) > 0)
            {
                OP = 'E';
                habilitaCampos(true);
                txtNome.Focus();
            }
            else MessageBox.Show("Não há registro Selecionado");
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
             if (Convert.ToInt32(txtIdFun.Text) > 0)
            {
               
                Camadas.MODEL.Funcionario Funcionario = new Camadas.MODEL.Funcionario();
                Camadas.BLL.Funcionario bllFuncionario = new Camadas.BLL.Funcionario();

                Funcionario.id = Convert.ToInt32(txtIdFun.Text);
                DialogResult result;
                result = MessageBox.Show("Deseja Remover o funcionario Selecionado?",
                                          "Remover Funcionario", 
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question, 
                                          MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    bllFuncionario.Delete(Funcionario);
                    MessageBox.Show("Funcionario Removido com Sucesso...");
                }
                else MessageBox.Show("Não confirmada Remoção de Funcionario...","Remover");


                dtgvFuncionario.DataSource = bllFuncionario.Select(); //atualizar lista de registro
                habilitaCampos(false);
            }
            else MessageBox.Show("Não há registros Selecionados", "Remover"); 

           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OP = 'X';
            habilitaCampos(false);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
        }
        

        
    







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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();//data
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();//horas

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Livro live = new Livro();
            live.Show();

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscar busc = new frmBuscar ();
            busc.Show();

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.Show();
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFuncionario fun = new frmFuncionario();
            fun.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void livroToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Locacao loc = new Locacao();
            loc.Show();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Relatorio rel = new Relatorio();
            rel.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre frm = new Sobre();
            frm.Show();
        }
    }
}

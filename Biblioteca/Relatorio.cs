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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelCliente cliente = new RelCliente();
            cliente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RelLivro livro = new RelLivro();
            livro.Show();
            
            
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RelLocacao loca = new RelLocacao();
            loca.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RelItem iten = new RelItem();
            iten.Show();
        }
    }
}

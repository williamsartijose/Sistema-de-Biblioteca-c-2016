﻿using System;
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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtLog.Text == "william") && (txtSenha.Text == "1234"))// se 1 text e o 2 for menssagem correta 
            {
                Menu men = new Menu();// chama o formulario prncipal
                men.Show();
                this.Visible = false;
            }
            else{
                MessageBox.Show("Senha ou Login Inválido ...");
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txt_Nome.Text;
            p.Funcionalidade = txt_Func.Text;
            p.Validade = txt_Valid.Text;
            p.Origem = txt_Origem.Text;
            p.Quantidade = txt_Quant.Text;
            p.Marca = txt_Marca.Text;
            p.FaixaEtaria = txt_Faixa.Text;
            p.Descricao = txt_Desc.Text;
            p.Localizacao = txt_Local.Text;
            p.Textura = txt_Textura.Text;

            Console.WriteLine(p.Nome);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Func_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

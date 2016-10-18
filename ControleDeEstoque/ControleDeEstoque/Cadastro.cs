using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=lp2;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connString);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.Connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            List<Produto> produto = new List<Produto>();

            if (reader.HasRows)
            {
                while (reader.Read())
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

                    p.Nome = reader.GetString;
                    p.Funcionalidade = reader.GetString;
                    p.Validade = reader.GetString;
                    p.Origem = reader.GetString;
                    p.Quantidade = reader.GetString;
                    p.Marca = reader.GetString;
                    p.FaixaEtaria = reader.GetString;
                    p.Descricao = reader.GetString;
                    p.Localizacao = reader.GetString;
                    p.Textura = reader.GetString;
                }
            }

            MessageBox.Show(p.Nome +" cadastrado com sucesso!");


        }

    }
}

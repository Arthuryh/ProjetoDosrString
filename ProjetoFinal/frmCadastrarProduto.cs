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

namespace ProjetoFinal
{
    public partial class frmCadastrarProduto : Form
    {
        int codBarras, qtd;
        string nomeProduto;
        decimal preco;

        MySqlConnection conexao = new MySqlConnection();
        MySqlCommand comando = new MySqlCommand();

        string conexao_sql = Properties.Settings.Default.endBanco;

        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comand = new MySqlCommand("cadProd");

                conexao.ConnectionString = conexao_sql;

                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.Connection = conexao;
                conexao.Open();

                comand.Parameters.Add("@nomeProd", MySqlDbType.VarChar).Value = txtNome.Text;
                comand.Parameters.Add("@qtdProd", MySqlDbType.Int32).Value = Convert.ToInt32(txtQtd.Text);
                comand.Parameters.Add("@precoProd", MySqlDbType.Decimal).Value = Convert.ToDecimal(txtPreco.Text);

                comand.ExecuteNonQuery();


                lblMensagem.Text = "Cadastrado com sucesso";
                lblMensagem.ForeColor = Color.Green;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);

            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

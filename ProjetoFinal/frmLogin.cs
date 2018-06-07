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
    public partial class frmLogin : Form
    {
        MySqlConnection conexao = new MySqlConnection();
        MySqlCommand comando = new MySqlCommand();

        string conexao_sql = Properties.Settings.Default.endBanco;

        public string usuario, senha;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRejeitar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAceitar_Click(object sender, EventArgs e)
        {
            tabControl.Enabled = true;
            painelConteudo1.Visible = false;
            painelBotoes.Visible = false;
            painelConteudo2.Visible = true;
            painelConteudo2.Enabled = true;
            painelConteudo2.BringToFront();
            tabControl.SelectedIndex = 1;
        }

        private void lblRecuperaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Mensagem = "Digite o Email.";
            string Titulo = "Recuperar Senha";
            string nome, email;
            string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Mensagem, Titulo, "", 450, 450);

            if (Resultado.Length == 0 || Resultado.Length < 6)
            {
                MessageBox.Show("Digite um email válido!", "Email incorreto!", MessageBoxButtons.OK);
            }

            else
            {
                try
                {
                    conexao.ConnectionString = conexao_sql;

                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "select nome,email from tb_usuario where email = @email";
                    comando.Connection = conexao;

                    comando.Parameters.Add("@email", MySqlDbType.VarChar).Value = Resultado;

                    conexao.Open();
                    MySqlDataReader dr = comando.ExecuteReader();

                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            Program.nome = Convert.ToString(dr["nome"]);
                            Program.email = Convert.ToString(dr["email"]);
                        }

                        frmRecuperarSenha recuperar = new frmRecuperarSenha();
                        recuperar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email não encontrado!", "Email incorreto!", MessageBoxButtons.OK);
                    }

                }

                catch (Exception er)
                {
                    throw er;
                }

                finally
                {
                    conexao.Close();
                    comando.Parameters.Clear();
                    Resultado = Microsoft.VisualBasic.Interaction.InputBox(Mensagem, Titulo, "", 450, 450);
                }
            }
        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsu.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Campos vazios, Insira os dados!", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsu.Focus();
            }

            else
            {
                try
                {
                    conexao.ConnectionString = conexao_sql;

                    MySqlCommand comand = new MySqlCommand("Login");
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    comand.Connection = conexao;

                    comand.Parameters.Add("@Usu", MySqlDbType.VarChar).Value = txtUsu.Text;
                    comand.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = txtSenha.Text;

                    conexao.Open();
                    MySqlDataReader dr = comand.ExecuteReader();

                    if (dr.HasRows == true)
                    {
                        if (dr.Read())
                        {
                            Program.nome = Convert.ToString(dr["nome"]);

                        }

                        frmMenu menu = new frmMenu();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Não cadastrado");
                        conexao.Close();
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show("" + erro);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Termos de Uso";
            painelConteudo2.BringToFront();
            painelConteudo2.Enabled = true;
            painelBotoes.Visible = false;
            tabControl.SelectedIndex = 1;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                this.Text = "Termos de Uso";
                this.AcceptButton = BtnAceitar;
                painelConteudo2.Visible = false;
                painelConteudo2.Enabled = false;
                painelConteudo2.SendToBack();
                painelConteudo1.Visible = true;
                painelConteudo1.Enabled = true;
                painelConteudo1.BringToFront();
                painelBotoes.Visible = true;
                painelBotoes.Enabled = true;
                tabControl.Enabled = false;
            }
            else
            {
                this.Text = "Login";
                this.AcceptButton = btnEntrar;
                painelConteudo2.Visible = Enabled;
                painelConteudo2.Enabled = Enabled;
                painelConteudo2.BringToFront();
                painelConteudo1.Visible = false;
                painelConteudo1.Enabled = false;
                painelConteudo1.SendToBack();
                painelBotoes.Visible = false;
                painelBotoes.Enabled = false;
            }
        }
    }
}

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
    public partial class frmRecuperarSenha : Form
    {
        MySqlConnection conexao = null;
        MySqlCommand comando = new MySqlCommand();
        //MySqlDataReader dr = new MySqlDataReader();
        string conexao_sql = Properties.Settings.Default.endBanco;

        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }

        private void verificaAsenha()
        {
            if(txtSenha.Text != txtConfirmaSenha.Text)
            {
                MessageBox.Show("Senhas não coincidem", "Erro nas senhas", MessageBoxButtons.OK);
            }

            else
            {
                try
                {
                    conexao = new MySqlConnection(conexao_sql);
                    MySqlCommand sql = new MySqlCommand("update tb_usuario set senha=@Senha where email=@Email")
                    {
                        Connection = conexao
                    };
                    sql.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = txtConfirmaSenha.Text;
                    //sql.Parameters.Add("@Email", MySqlDbType.VarChar).Value = ;
                    conexao.Open();
                    sql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    conexao.Close();
                }
            }
        }

        private void frmRecuperarSenha_Load(object sender, EventArgs e)
        {
            //lblNome.Text = Program.nome;
        }
    }
}

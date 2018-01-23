using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CTP
{
    public partial class frmLogin : Form
    {
        public string usuario;
        
        public frmLogin()
        {

            InitializeComponent();
        }

        
        
        #region Botão Logar
        private void btnLogar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Length > 0 && txtSenha.Text.Length > 0)
            {
                usuarioInformation usu = new usuarioInformation();
                usu.usu_Nome = txtUsuario.Text;
                usu.usu_Senha = txtSenha.Text;

                SqlConnection con = new SqlConnection();
                try
                {
                    // conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //commamd
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select count(nome) from cadusuario WHERE nome = @usu_nome and senha = @usu_senha";

                    //parametros
                    cmd.Parameters.AddWithValue("@usu_nome", usu.usu_Nome);
                    cmd.Parameters.AddWithValue("@usu_senha", usu.usu_Senha);

                    
                    //Abriel conexao
                    con.Open();

                    int resultado;
                    resultado = Convert.ToInt32(cmd.ExecuteScalar());

                    //verificar Resuldado
                    if (resultado == 1)
                    {
                        
                        this.Visible = false;
                        //MessageBox.Show("Logado com Sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPrincipal principal = new frmPrincipal();
                        principal.nome = usu.usu_Nome;
                        principal.Show();


                    }
                    else
                    {
                        throw new Exception("USUÁRIO/SENHA INVÁLIDO");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO CONTATE O ADMINISTRADOR DO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txtUsuario.Focus();
                    txtSenha.Clear();
                    txtUsuario.Clear();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS PARA FAZER O LOGIN", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        #endregion

        #region Botão Limpa Tela
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtUsuario.Clear();
            this.Close();
        }
        #endregion

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        
        }

        #region APERTAR ENTER
        //Apertar enter para logar
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtUsuario.Text.Length > 0 && txtSenha.Text.Length > 0)
                {
                    usuarioInformation usu = new usuarioInformation();
                    usu.usu_Nome = txtUsuario.Text;
                    usu.usu_Senha = txtSenha.Text;

                    SqlConnection con = new SqlConnection();
                    try
                    {
                        // conexão
                        con.ConnectionString = Dados.conexaoBancoDados;

                        //commamd
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select count(nome) from cadusuario WHERE nome = @usu_nome and senha = @usu_senha";

                        //parametros
                        cmd.Parameters.AddWithValue("@usu_nome", usu.usu_Nome);
                        cmd.Parameters.AddWithValue("@usu_senha", usu.usu_Senha);


                        //Abriel conexao
                        con.Open();

                        int resultado;
                        resultado = Convert.ToInt32(cmd.ExecuteScalar());

                        //verificar Resuldado
                        if (resultado == 1)
                        {

                            this.Visible = false;
                            //MessageBox.Show("Logado com Sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmPrincipal principal = new frmPrincipal();
                            principal.nome = usu.usu_Nome;
                            principal.Show();


                        }
                        else
                        {
                            throw new Exception("USUÁRIO/SENHA INVÁLIDO");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO CONTATE O ADMINISTRADOR DO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        txtUsuario.Focus();
                        txtSenha.Clear();
                        txtUsuario.Clear();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("PREENCHA OS CAMPOS PARA FAZER O LOGIN", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            #endregion

        }
    }
}

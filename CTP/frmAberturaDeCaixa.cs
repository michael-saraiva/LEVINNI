using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CTP;

namespace LEVINNI
{
    public partial class frmAberturaDeCaixa : Form
    {
        public string operador;
        decimal dinheiro;
        public Button bt;
        public Label status;

        public frmAberturaDeCaixa()
        {
            InitializeComponent();
        }

        #region Load
        private void frmAberturaDeCaixa_Load(object sender, EventArgs e)
        {
            lblOperador.Text = operador;
            if (txtValorInicial.Text == "")
            {
                txtValorInicial.Text = "0,00";
            }
        }
        #endregion

        private void txtValorInicial_Validated(object sender, EventArgs e)
        {
            // verificar se espaço ou vazio
            if ((txtValorInicial.Text != "") && (txtValorInicial.Text != " "))
            {
                txtValorInicial.Text = txtValorInicial.Text.Replace("R$", "");
                dinheiro = Convert.ToDecimal(txtValorInicial.Text);
                txtValorInicial.Text = string.Format("{0:C}", dinheiro);
            }
        }

        #region Botão Finalizar
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            fechamentoInformation fch = new fechamentoInformation();
            fch.Dinheiro = dinheiro;
            fch.Data = dtpCadastroCaixa.Value;
            fch.Operador = lblOperador.Text;
            fch.Descricao = txtDescricao.Text;
            fch.Tipo = 'A';

            SqlConnection con = new SqlConnection();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //command responsável por buscar resultador
                SqlCommand cmdAbrirCaixa = new SqlCommand();
                cmdAbrirCaixa.Connection = con;
                cmdAbrirCaixa.CommandType = CommandType.Text;
                cmdAbrirCaixa.CommandText = "insert into movimentacao (dinheiro, datadocadastro, operador, descricao, tipo) values (@dinheiro, @datadocadastro, @operador, @descricao, @tipo)";
                cmdAbrirCaixa.Parameters.AddWithValue("@dinheiro", fch.Dinheiro);
                cmdAbrirCaixa.Parameters.AddWithValue("@datadocadastro", fch.Data);
                cmdAbrirCaixa.Parameters.AddWithValue("@operador", fch.Operador);
                cmdAbrirCaixa.Parameters.AddWithValue("@descricao", fch.Descricao);
                cmdAbrirCaixa.Parameters.AddWithValue("@tipo", fch.Tipo);

                con.Open();
                cmdAbrirCaixa.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }

            MessageBox.Show("CAIXA ABERTO", "MENSAGEM");
            
            bt.Enabled = false;
            status.Text = "CAIXA ABERTO";
            
            this.Close();
            

        }
        #endregion

        #region Botao Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

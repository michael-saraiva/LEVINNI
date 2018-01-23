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
    public partial class frmFechamentoCaixa : Form
    {
        decimal dinheiro, credito, debito, cheque, total, iniciou, final, prazo, entrada, recebimento, dinCaixa;
        public string operador;
        public Button bt;
        public Label status;

        public frmFechamentoCaixa()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txt_valorTotal.Clear();
            txtCheque.Clear();
            txtCredito.Clear();
            txtDebito.Clear();
            txtDescricao.Clear();
            txtFechou.Clear();
            txtIniciou.Clear();
            txtTotal.Clear();
            txtPrazo.Clear();
            txtDinheiro.Clear();
            txtEntrada.Clear();
            txtRecebimento.Clear();
            
        }

        #region Botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            LimpaTela();
            this.Close();
        }
        #endregion

        #region Botão Finalizar
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            fechamentoInformation fec = new fechamentoInformation();
            fec.Dinheiro = Convert.ToDecimal(txt_valorTotal.Text);
            fec.Credito = Convert.ToDecimal(txtCredito.Text);
            fec.Debito = Convert.ToDecimal(txtDebito.Text);
            fec.Cheque = Convert.ToDecimal(txtCheque.Text);
            fec.Inicial = Convert.ToDecimal(txtIniciou.Text);
            fec.Final = Convert.ToDecimal(txtFechou.Text);
            fec.Prazo = Convert.ToDecimal(txtPrazo.Text);
            fec.DinCaixa = Convert.ToDecimal(txtDinheiro.Text);
            fec.Entrada = Convert.ToDecimal(txtEntrada.Text);
            fec.Recebimento = Convert.ToDecimal(txtRecebimento.Text);
            fec.Total = total;
            fec.Operador = lblOperador.Text;
            fec.Descricao = txtDescricao.Text;
            fec.Tipo = 'F';
            fec.Data = Convert.ToDateTime(dtpCadastroCaixa.Text);

            SqlConnection con = new SqlConnection();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //command responsável por buscar resultador
                SqlCommand cmdFechar = new SqlCommand();
                cmdFechar.Connection = con;
                cmdFechar.CommandType = CommandType.Text;
                cmdFechar.CommandText = "insert into movimentacao (dinheiro, credito, debito, cheque, inicial, final, total, operador, descricao, tipo, datadocadastro, prazo, dinCaixa, entrada, recebimento) values (@dinheiro, @credito, @debito, @cheque, @inicial, @final, @total, @operador, @descricao, @tipo, @datadocadastro, @prazo, @dinCaixa, @entrada, @recebimento)";
                cmdFechar.Parameters.AddWithValue("@dinheiro", fec.Dinheiro);
                cmdFechar.Parameters.AddWithValue("@credito", fec.Credito);
                cmdFechar.Parameters.AddWithValue("@debito", fec.Debito);
                cmdFechar.Parameters.AddWithValue("@cheque", fec.Cheque);
                cmdFechar.Parameters.AddWithValue("@inicial", fec.Inicial);
                cmdFechar.Parameters.AddWithValue("@final", fec.Final);
                cmdFechar.Parameters.AddWithValue("@total", fec.Total);
                cmdFechar.Parameters.AddWithValue("@operador", fec.Operador);
                cmdFechar.Parameters.AddWithValue("@descricao", fec.Descricao);
                cmdFechar.Parameters.AddWithValue("@tipo", fec.Tipo);
                cmdFechar.Parameters.AddWithValue("@datadocadastro", fec.Data);
                cmdFechar.Parameters.AddWithValue("@prazo", fec.Prazo);
                cmdFechar.Parameters.AddWithValue("@dinCaixa", fec.DinCaixa);
                cmdFechar.Parameters.AddWithValue("@entrada", fec.Entrada);
                cmdFechar.Parameters.AddWithValue("@recebimento", fec.Recebimento);
                
                con.Open();

                cmdFechar.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }

            MessageBox.Show("CAIXA FECHADO COM SUCESSO","MENSAGEM");
            LimpaTela();

            bt.Enabled = false;
            status.Text = "CAIXA FECHADO";

            this.Close();
        }
        #endregion

        #region Verifica se esta zerado os campos de valores e coloca cifrao

        private void txt_valorTotal_Validated(object sender, EventArgs e)
        {
            // verificar se espaço ou vazio
            if ((txt_valorTotal.Text != "") && (txt_valorTotal.Text != " "))
            {
                txt_valorTotal.Text = txt_valorTotal.Text.Replace("R$", "");
                dinheiro = Convert.ToDecimal(txt_valorTotal.Text);
                txt_valorTotal.Text = string.Format("{0:C}", dinheiro);
            }
        }

        private void txtCredito_Validated(object sender, EventArgs e)
        {
            // verificar se espaço ou vazio
            if ((txtCredito.Text != "") && (txtCredito.Text != " "))
            {
                txtCredito.Text = txtCredito.Text.Replace("R$", "");
                credito = Convert.ToDecimal(txtCredito.Text);
                txtCredito.Text = string.Format("{0:C}", credito);
            }
        }

        private void txtDebito_Validated(object sender, EventArgs e)
        {
            // verificar se espaço ou vazio
            if ((txtDebito.Text != "") && (txtDebito.Text != " "))
            {
                txtDebito.Text = txtDebito.Text.Replace("R$", "");
                debito = Convert.ToDecimal(txtDebito.Text);
                txtDebito.Text = string.Format("{0:C}", debito);
            }
        }

        private void txtCheque_Validated(object sender, EventArgs e)
        {
            // verificar se espaço ou vazio
            if ((txtCheque.Text != "") && (txtCheque.Text != " "))
            {
                txtCheque.Text = txtCheque.Text.Replace("R$", "");
                cheque = Convert.ToDecimal(txtCheque.Text);
                txtCheque.Text = string.Format("{0:C}", cheque);
            }
        }

        private void txtTotal_Validated(object sender, EventArgs e)
        {
            // verificar se espaço ou vazio
            if ((txtTotal.Text != "") && (txtTotal.Text != " "))
            {
                txtTotal.Text = txtTotal.Text.Replace("R$", "");
                total = Convert.ToDecimal(txtTotal.Text);
                txtTotal.Text = string.Format("{0:C}", total);
            }
        }
        #endregion

        #region Load
        private void frmFechamentoCaixa_Load(object sender, EventArgs e)
        {
            lblOperador.Text = operador;

            SqlConnection con = new SqlConnection();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //command responsável por buscar resultador
                SqlCommand cmdDinheiro = new SqlCommand();
                cmdDinheiro.Connection = con;
                cmdDinheiro.CommandType = CommandType.Text;
                cmdDinheiro.CommandText = "select sum(preco) from baixa where datab = @data and condicao = 'Á VISTA'";
                cmdDinheiro.Parameters.AddWithValue("@data", dtpCadastroCaixa.Text);

                SqlCommand cmdCredito = new SqlCommand();
                cmdCredito.Connection = con;
                cmdCredito.CommandType = CommandType.Text;
                cmdCredito.CommandText = "select sum(preco) from baixa where datab = @data and condicao = 'CARTÃO DE CRÉDITO'";
                cmdCredito.Parameters.AddWithValue("@data", dtpCadastroCaixa.Text);

                SqlCommand cmdDebito = new SqlCommand();
                cmdDebito.Connection = con;
                cmdDebito.CommandType = CommandType.Text;
                cmdDebito.CommandText = "select sum(preco) from baixa where datab = @data and condicao = 'CARTÃO DE DÉBITO'";
                cmdDebito.Parameters.AddWithValue("@data", dtpCadastroCaixa.Text);

                SqlCommand cmdCheque = new SqlCommand();
                cmdCheque.Connection = con;
                cmdCheque.CommandType = CommandType.Text;
                cmdCheque.CommandText = "select sum(preco) from baixa where datab = @data and condicao = 'CHEQUE'";
                cmdCheque.Parameters.AddWithValue("@data", dtpCadastroCaixa.Text);

                SqlCommand cmdPrazo = new SqlCommand();
                cmdPrazo.Connection = con;
                cmdPrazo.CommandType = CommandType.Text;
                cmdPrazo.CommandText = "select sum(preco) from baixa where datab = @data and condicao = 'PRAZO'";
                cmdPrazo.Parameters.AddWithValue("@data", dtpCadastroCaixa.Text);

                SqlCommand cmdTotal = new SqlCommand();
                cmdTotal.Connection = con;
                cmdTotal.CommandType = CommandType.Text;
                cmdTotal.CommandText = "select sum(preco) from baixa where datab = @data";
                cmdTotal.Parameters.AddWithValue("@data", dtpCadastroCaixa.Text);

                SqlCommand cmdIniciou = new SqlCommand();
                cmdIniciou.Connection = con;
                cmdIniciou.CommandType = CommandType.Text;
                cmdIniciou.CommandText = "select dinheiro from movimentacao where tipo = 'A' and datadocadastro = @data";
                cmdIniciou.Parameters.AddWithValue("@data", dtpCadastroCaixa.Text);

                /*SqlCommand cmdDin = new SqlCommand();
                cmdDin.Connection = con;
                cmdDin.CommandType = CommandType.Text;
                cmdDin.CommandText = "select dinheiro from movimentacao where tipo = 'A' and datadocadastro = @data";
                cmdDin.Parameters.AddWithValue("@data", dtpCadastroCaixa.Text);*/

                SqlCommand cmdEnt = new SqlCommand();
                cmdEnt.Connection = con;
                cmdEnt.CommandType = CommandType.Text;
                cmdEnt.CommandText = "select sum(entrada) from baixa where datab = @data";
                cmdEnt.Parameters.AddWithValue("@data", dtpCadastroCaixa.Text);

                SqlCommand cmdRec = new SqlCommand();
                cmdRec.Connection = con;
                cmdRec.CommandType = CommandType.Text;
                cmdRec.CommandText = "select sum(recebido) from recebimento where datapagamento = @data";
                cmdRec.Parameters.AddWithValue("@data", dtpCadastroCaixa.Text);


                con.Open();

                txt_valorTotal.Text = Convert.ToString(cmdDinheiro.ExecuteScalar());
                txtCredito.Text = Convert.ToString(cmdCredito.ExecuteScalar());
                txtDebito.Text = Convert.ToString(cmdDebito.ExecuteScalar());
                txtCheque.Text = Convert.ToString(cmdCheque.ExecuteScalar());
                txtTotal.Text = Convert.ToString(cmdTotal.ExecuteScalar());
                txtIniciou.Text = Convert.ToString(cmdIniciou.ExecuteScalar());
                txtPrazo.Text = Convert.ToString(cmdPrazo.ExecuteScalar());
                //txtDinheiro.Text = Convert.ToString(cmdDin.ExecuteScalar());
                txtEntrada.Text = Convert.ToString(cmdEnt.ExecuteScalar());
                txtRecebimento.Text = Convert.ToString(cmdRec.ExecuteScalar());                
                

                if (txtTotal.Text == "")
                {
                    txtTotal.Text = "0,00";
                }
                if (txtEntrada.Text == "")
                {
                    txtEntrada.Text = "0,00";
                }
                if (txtRecebimento.Text == "")
                {
                    txtRecebimento.Text = "0,00";
                }
                if (txtIniciou.Text == "")
                {
                    txtIniciou.Text = "0,00";
                }
                if (txt_valorTotal.Text == "")
                {
                    txt_valorTotal.Text = "0,00";
                }

                entrada = Convert.ToDecimal(txtEntrada.Text);
                recebimento = Convert.ToDecimal(txtRecebimento.Text);

                total = Convert.ToDecimal(txtTotal.Text);
                iniciou = Convert.ToDecimal(txtIniciou.Text);

                final = total + iniciou;
                txtFechou.Text = Convert.ToString(final);

                dinCaixa = entrada + recebimento + Convert.ToDecimal(txt_valorTotal.Text);
                txtDinheiro.Text = Convert.ToString(dinCaixa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }

            if (txt_valorTotal.Text == "")
            {
                txt_valorTotal.Text = "0,00";                 
            }

            if (txtCredito.Text == "")
            {
                txtCredito.Text = "0,00";
            }

            if (txtDebito.Text == "")
            {
                txtDebito.Text = "0,00";
            }

            if (txtCheque.Text == "")
            {
                txtCheque.Text = "0,00";
            }

            if (txtPrazo.Text == "")
            {
                txtPrazo.Text = "0,00";
            }

            if (txtDinheiro.Text == "")
            {
                txtDinheiro.Text = "0,00";
            }

            if (txtEntrada.Text == "")
            {
                txtEntrada.Text = "0,00";
            }

            if (txtRecebimento.Text == "")
            {
                txtRecebimento.Text = "0,00";
            }
            
        }
        #endregion

        private void txtPrazo_Validated(object sender, EventArgs e)
        {
            // verificar se espaço ou vazio
            if ((txtPrazo.Text != "") && (txtPrazo.Text != " "))
            {
                txtPrazo.Text = txtPrazo.Text.Replace("R$", "");
                prazo = Convert.ToDecimal(txtPrazo.Text);
                txtPrazo.Text = string.Format("{0:C}", prazo);
            }
        }

        private void txtRecebimento_Validated(object sender, EventArgs e)
        {
            // verificar se espaço ou vazio
            if ((txtRecebimento.Text != "") && (txtRecebimento.Text != " "))
            {
                txtRecebimento.Text = txtRecebimento.Text.Replace("R$", "");
                recebimento = Convert.ToDecimal(txtRecebimento.Text);
                txtRecebimento.Text = string.Format("{0:C}", total);
            }
        }

        private void txtEntrada_Validated(object sender, EventArgs e)
        {
            // verificar se espaço ou vazio
            if ((txtEntrada.Text != "") && (txtEntrada.Text != " "))
            {
                txtEntrada.Text = txtEntrada.Text.Replace("R$", "");
                entrada = Convert.ToDecimal(txtEntrada.Text);
                txtEntrada.Text = string.Format("{0:C}", total);
            }
        }

        private void txtDinheiro_Validated(object sender, EventArgs e)
        {
            // verificar se espaço ou vazio
            if ((txtDinheiro.Text != "") && (txtDinheiro.Text != " "))
            {
                txtDinheiro.Text = txtDinheiro.Text.Replace("R$", "");
                dinCaixa = Convert.ToDecimal(txtDinheiro.Text);
                txtDinheiro.Text = string.Format("{0:C}", total);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CTP;
using System.Data.SqlClient;

namespace LEVINNI
{
    public partial class frmReceber : Form
    {
        decimal pagou;

        public frmReceber()
        {
            InitializeComponent();
        }

        #region Botão Pesquisa Duplicata
        private void btnPesqduplicata_Click(object sender, EventArgs e)
        {
            frmPesquisaRecebimento r = new frmPesquisaRecebimento();
            r.ShowDialog();

            txtCodigo.Text = r.codigo;
            cbbCliente.Text = r.cliente;
            txtCodCliente.Text = r.codigocliente;
            txtFicha.Text = r.ficha;
            txtParcela.Text = r.parcela;
            txtValor.Text = r.valor;
            dtpVencimento.Text = r.datavencimento;
            
            //Recebe o Valor Pago pelo cliente na Duplicata
            if (r.valorPago.Length == 0)
            {
                r.valorPago =  "0,00";
            }
            
            pagou = Convert.ToDecimal(r.valorPago);            

            if (r.valorEmAberto.Length == 0)
            {
                r.valorEmAberto = r.valor;
                txtValoremaberto.Text = r.valorEmAberto;
            }
            else
            {
                txtValoremaberto.Text = r.valorEmAberto;
            }

        }
        #endregion

        #region Botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA CANCELAR ?", "CANCELAMENTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
            {
                this.Close();
            }
        }
        #endregion

        #region Botão Finalizar
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtFicha.Text.Length == 0)
            {
                MessageBox.Show("SELECIONE A DUPLICATA", "ATENÇÃO");
            }
            else
            {

                decimal valorP = 0, valorA = 0, valor = 0, recebido = 0;

                recebimentoinformation rec = new recebimentoinformation();
                rec.Cr_codigo = Convert.ToInt32(txtCodigo.Text);

                if (txtValorpago.TextLength > 0)
                {


                    valorP = Convert.ToDecimal(txtValorpago.Text);
                    valorA = Convert.ToDecimal(txtValoremaberto.Text);
                    valor = Convert.ToDecimal(txtValor.Text);

                    // Coluna recebido recebe o valor do campo txtValorPago
                    recebido = Convert.ToDecimal(txtValorpago.Text);
                    rec.Cr_recebido = recebido;

                    rec.Cr_codigocliente = Convert.ToInt32(txtCodCliente.Text);

                    if (valorP > valorA)
                    {
                        MessageBox.Show("VALOR PAGO MAIOR QUE A DUPLICATA", "ATENÇÃO");
                    }
                    else
                    {
                        // Se valor pago for igual ao valor em aberto tabela valor em aberto recebe 0,00 e duplicata é baixada como SIM (S)
                        if (valorP == valorA)
                        {
                            rec.Cr_valor_EmAberto = Convert.ToDecimal(0.00);
                            rec.Cr_baixado = 'S';
                            rec.Cr_valorPago = valorP + pagou;
                        }

                        // Se valor pago for menor que o valor em aberto 
                        else if (valorP < valorA)
                        {
                            rec.Cr_valor_EmAberto = valorA - valorP;
                            rec.Cr_baixado = 'P';
                            rec.Cr_valorPago = valorP + pagou;
                        }

                        rec.Cr_datapagamento = Convert.ToDateTime(dtpPagamento.Text);

                        SqlConnection con = new SqlConnection();
                        try
                        {
                            //conexão
                            con.ConnectionString = Dados.conexaoBancoDados;

                            /*
                            //command Select devedor
                            SqlCommand cmdS = new SqlCommand();
                            cmdS.Connection = con;
                            cmdS.CommandType = CommandType.Text;
                            cmdS.CommandText = "update contasareceber set  baixado = @rec_baixado, valorPago = @rec_valorPago where codigo = @rec_codigo";*/

                            //command
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update contasareceber set  baixado = @rec_baixado, valorPago = @rec_valorPago, valorEmAberto = @rec_valorEmAberto where codigo = @rec_codigo";

                            //Parametros
                            cmd.Parameters.AddWithValue("@rec_codigo", rec.Cr_codigo);
                            cmd.Parameters.AddWithValue("@rec_baixado", rec.Cr_baixado);
                            cmd.Parameters.AddWithValue("@rec_valorPago", rec.Cr_valorPago);
                            cmd.Parameters.AddWithValue("@rec_valorEmAberto", rec.Cr_valor_EmAberto);

                            //buscar valor ja pago
                            //int codigoProduto = Convert.ToInt32(cmdbusca.ExecuteScalar());

                            //command Recebimento
                            SqlCommand cmdR = new SqlCommand();
                            cmdR.Connection = con;
                            cmdR.CommandType = CommandType.Text;
                            cmdR.CommandText = "insert into recebimento (codigo_contasareceber, valorPago, valorEmAberto, datapagamento, recebido) values (@rec_codigo_contasareceber, @rec_valorPago, @rec_valorEmAberto, @rec_datapagamento, @rec_recebido)";

                            //Parametros Recebimento
                            cmdR.Parameters.AddWithValue("@rec_codigo_contasareceber", rec.Cr_codigo);
                            cmdR.Parameters.AddWithValue("@rec_datapagamento", rec.Cr_datapagamento);
                            cmdR.Parameters.AddWithValue("@rec_valorPago", rec.Cr_valorPago);
                            cmdR.Parameters.AddWithValue("@rec_valorEmAberto", rec.Cr_valor_EmAberto);
                            cmdR.Parameters.AddWithValue("@rec_recebido", rec.Cr_recebido);

                            /* o Limite de Credito de determinado cliente */
                            SqlCommand limite = new SqlCommand();
                            limite.Connection = con;
                            limite.CommandType = CommandType.Text;
                            limite.CommandText = "update cadcliente set credito = credito + @preco where codigo = @cli_cod";
                            limite.Parameters.AddWithValue("@cli_cod", rec.Cr_codigocliente);
                            limite.Parameters.AddWithValue("@preco", rec.Cr_valorPago);

                            //Abrir conexão
                            con.Open();

                            //Executar Query
                            cmd.ExecuteNonQuery();
                            cmdR.ExecuteNonQuery();

                            //executar a query do Limite
                            limite.ExecuteNonQuery();

                            MessageBox.Show("RECEBIMENTO CONCLUÍDO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaTela();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERRO CONTATE O ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("DIGITE UM VALOR PARA FAZER O RECEBIMENTO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Método Limpa Tela
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtCodCliente.Clear();
            txtFicha.Clear();
            txtParcela.Clear();
            txtValor.Clear();
            txtValoremaberto.Clear();
            txtValorpago.Clear();
            dtpPagamento.ResetText();
            dtpVencimento.ResetText();
            cbbCliente.ResetText();
        }
        #endregion
    }
}

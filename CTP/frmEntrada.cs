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
    public partial class frmEntrada : Form
    {
        string co;
        decimal total = 0;
        public frmEntrada()
        {
            InitializeComponent();
        }
        #region Inserir
        private void btninserir_Click(object sender, EventArgs e)
        {
            if (txtnome.TextLength == 0)
            {
                MessageBox.Show("SELECIONE O PRODUTO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (txtestoque.Text.Length == 0)
                {
                    MessageBox.Show("A QUANTIDADE NÃO PODE SER IGUAL A 0", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    con.Open();



                    //verificar se tem o produto no estoque
                    if (txtcodigopro.TextLength > 0)
                    {
                        //preparar a ListView para inserção dos produtos
                        ListViewItem item = new ListViewItem(txtcodigopro.Text);
                        int quantidade = Convert.ToInt32(txtestoque.Text);

                        if (quantidade > 0)
                        {

                            //adicionar subitem no ListView
                            item.SubItems.Add(Convert.ToString(txtnome.Text));
                            item.SubItems.Add(Convert.ToString(txtmarca.Text));
                            item.SubItems.Add(Convert.ToString(quantidade));
                            item.SubItems.Add(Convert.ToString(txtValor.Text));
                            item.SubItems.Add(Convert.ToString(txtPrecoVenda.Text));

                            //colocar objetos na ListView
                            this.listaentrada.Items.Add(item);

                            // fazer somar a lista e passar para o banco txttotal

                            total += Convert.ToDecimal(txtValor.Text) * Convert.ToInt32(txtestoque.Text);
                            txtTotal.Text = Convert.ToString(total);

                        }
                        else
                        {
                            throw new Exception("A QUANTIDADE NÃO PODE SER IGUAL A 0");
                        }
                    }
                    else
                    {
                        throw new Exception("SELECIONE O PRODUTO");
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    txtcodigopro.Clear();
                    txtFornecedor.Clear();
                    txtmarca.Clear();
                    txtnome.Clear();
                    txtValor.Clear();
                    txtestoque.Clear();
                    txtPrecoVenda.Clear();
                    txtnome.Focus();
                    con.Close();
                }
            }

        }

        #endregion

        #region Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto pro = new frmPesquisaProduto();
            pro.ShowDialog();
            txtcodigopro.Text = pro.codigo;
            txtnome.Text = pro.descricao;
            txtmarca.Text = pro.marca;
            txtFornecedor.Text = pro.fornecedor;
            pro.Close();
        }
        #endregion

        #region Botão Excluir
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (listaentrada.SelectedItems.Count != 0)
            {

                
                decimal prod_preco = Convert.ToDecimal(listaentrada.FocusedItem.SubItems[4].Text);
                int prod_quant =  Convert.ToInt32(listaentrada.FocusedItem.SubItems[3].Text);
                total = total - (prod_preco * prod_quant);
                txtTotal.Text = Convert.ToString(total);
                listaentrada.Items.RemoveAt(Convert.ToInt32(listaentrada.SelectedIndices[0].ToString()));
                
            }
            else
            {
                MessageBox.Show("SELECIONE O PRODUTO PARA REMOVER", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        #endregion

        #region Load
        private void frmEntrada_Load(object sender, EventArgs e)
        {
            limpatela();

            listaentrada.View = System.Windows.Forms.View.Details;
            listaentrada.FullRowSelect = true;
            listaentrada.Columns.Add("CÓDIGO", 68, HorizontalAlignment.Center);
            listaentrada.Columns.Add("DESCRIÇÃO", 191, HorizontalAlignment.Left);
            listaentrada.Columns.Add("MARCA", 191, HorizontalAlignment.Left);
            listaentrada.Columns.Add("QUANTIDADE", 90, HorizontalAlignment.Left);
            listaentrada.Columns.Add("PR COMPRA", 90, HorizontalAlignment.Left);
            listaentrada.Columns.Add("PR VENDA", 90, HorizontalAlignment.Left);
        }
        #endregion

        #region Metodo Limpa tela
        public void limpatela()
        {
            txtcodigo.Clear();
            txtcodigopro.Clear();
            datacadastro.ResetText();
            txtestoque.Clear();
            txtmarca.Clear();
            txtnome.Clear();
            listaentrada.Items.Clear();
            txtNFe.Clear();
            txtFornecedor.Clear();
            txtValor.Clear();
            txtTotal.Clear();
            txtPrecoVenda.Clear();
        }
        #endregion

        #region Botão Limpa Tela
        private void btnlimpatela_Click(object sender, EventArgs e)
        {
            if (txtcodigopro.Text.Length > 0 || listaentrada.Items.Count > 0)
            {
                if (MessageBox.Show("DESEJA CANCELAR A ENTRADA?", "MENSAGEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    limpatela();
                    total = 0;
                }
            }

        }
        #endregion

        #region Botão Finalizar
        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                entradainformation en = new entradainformation();

                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;
                // Abrir conexão
                con.Open();


                if (listaentrada.Items.Count > 0)
                {
                    foreach (ListViewItem item in listaentrada.Items)
                    {
                        string codigoProduto = Convert.ToString(item.SubItems[0].Text);
                        string descricaoProduto = Convert.ToString(item.SubItems[1].Text);
                        string marcaProduto = Convert.ToString(item.SubItems[2].Text);
                        string quantidadeProduto = Convert.ToString(item.SubItems[3].Text);
                        string valorProduto = Convert.ToString(item.SubItems[4].Text);
                        string valorVenda = Convert.ToString(item.SubItems[5].Text);

                        en.Data = datacadastro.Value;
                        en.Produto_codigo = Convert.ToInt32(codigoProduto);
                        en.Quantidade = Convert.ToInt32(quantidadeProduto);

                        if (txtNFe.Text.Length == 0)
                        {
                            txtNFe.Text = "000000000000";
                        }
                        en.Nota = txtNFe.Text;
                        en.Valor = Convert.ToDecimal(valorProduto);
                        en.Total = Convert.ToDecimal(txtTotal.Text);
                        en.ValorVenda = Convert.ToDecimal(valorVenda);

                        //command
                        SqlCommand cmde = new SqlCommand();
                        cmde.Connection = con;
                        cmde.CommandType = CommandType.Text;
                        cmde.CommandText = "insert into entrada(data, produto_codigo, quantidade, nota, valor, total, precoCompra) values (@data, @produto_codigo, @quantidade, @nota, @valor, @total, @prVenda) select SCOPE_IDENTITY()";



                        //cmde.Parameters.AddWithValue("@codigo", en.Codigo);
                        cmde.Parameters.AddWithValue("@data", en.Data);
                        cmde.Parameters.AddWithValue("@produto_codigo", en.Produto_codigo);
                        cmde.Parameters.AddWithValue("@quantidade", en.Quantidade);
                        cmde.Parameters.AddWithValue("@nota", en.Nota);
                        cmde.Parameters.AddWithValue("@valor", en.Valor);
                        cmde.Parameters.AddWithValue("@total", en.Total);
                        cmde.Parameters.AddWithValue("@prVenda", en.ValorVenda);

                        int ven_cod = Convert.ToInt32(cmde.ExecuteScalar());
                        en.Codigo = ven_cod;

                        //parametros

                        ProdutoInformation usu = new ProdutoInformation();
                        usu.Pr_codigo = Convert.ToInt32(codigoProduto);
                        usu.Pr_quantidade = Convert.ToInt32(quantidadeProduto);
                        usu.Pr_marca = marcaProduto;
                        usu.Pr_descricao = descricaoProduto;
                        usu.Pr_precoVenda = Convert.ToDecimal(valorVenda);
                        usu.Pr_preco = Convert.ToDecimal(valorProduto);

                        // command
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update Produto set quantidade = quantidade + @quantidade, precoVenda = @precoVenda, preco = @preco where descricao = @prod_nome";

                        //parametros
                        cmd.Parameters.AddWithValue("@quantidade", usu.Pr_quantidade);
                        cmd.Parameters.AddWithValue("@prod_nome", usu.Pr_descricao);
                        cmd.Parameters.AddWithValue("@precoVenda", usu.Pr_precoVenda);
                        cmd.Parameters.AddWithValue("@preco", usu.Pr_preco);

                        //executar query

                        cmd.ExecuteNonQuery();
                        co = Convert.ToString(en.Codigo);

                        cmd.Parameters.RemoveAt("@quantidade");
                        cmd.Parameters.RemoveAt("@prod_nome");
                        cmd.Parameters.RemoveAt("@precoVenda");
                        cmd.Parameters.RemoveAt("@preco");
                    }

                    MessageBox.Show("ENTRADA EFETUADA COM SUCESSO" + " " + "CODIGO" + " " + co + " ", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpatela();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO CONTATE O ADMINISTRADOR DO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Botão Retornar
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (listaentrada.Items.Count > 0)
            {
                MessageBox.Show("CANCELE A ENTRADA PARA RETORNAR AO MENU PRINCIPAL", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (MessageBox.Show("DESEJA RETORNAR AO MENU ?", "MENSAGEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
            {
                this.Close();
            }
        }
        #endregion

        private void txtestoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using LEVINNI;
using System.Drawing.Printing;
namespace CTP
{
    public partial class frmOrcamento : Form
    {
        public string vendedor;
        int i = 0, pages = 0;
        decimal tot, resultadolim, sub, impTotal;
        int liberado = 0, clique = 0, alturaFinal = 0;
        int saldoEtq = 0;

        //IMPRESSORA
        int impVenda = 0;
        string impVendedor, impCliente, impCondicao, impSub, impDescV, impDescP, impEntrada, impData, impParcela, impPrazo;

        public frmOrcamento()
        {
            InitializeComponent();
        }

        #region Váriaveis Globais
        public string co;
        decimal preco, total;
        public string p;
        decimal descontoP = 0;
        decimal entrada = 0;
        decimal descontoV = 0;
        #endregion

        #region Load
        private void frmOrcamento_Load(object sender, EventArgs e)
        {
            //Passar o nome do usuario logado para o caixa / vendedor
            lblVendedorVenda.Text = vendedor;

            cbbCliente.Enabled = true;
            cbbCliente.DataSource = PesquisaCliente();
            cbbCliente.ValueMember = "codigo";
            cbbCliente.DisplayMember = "nome";

            cbbCliente.SelectedIndex = -1;

            cbbProduto.DataSource = PesquisaProduto();
            cbbProduto.ValueMember = "codigo";
            cbbProduto.DisplayMember = "descricao";

            cbbProduto.SelectedIndex = -1;

            listavenda.View = System.Windows.Forms.View.Details;
            listavenda.FullRowSelect = true;

            listavenda.Columns.Add("PRODUTO", 210, HorizontalAlignment.Left);
            listavenda.Columns.Add("CODIGO", 70, HorizontalAlignment.Center);
            listavenda.Columns.Add("QTDE", 70, HorizontalAlignment.Left);
            listavenda.Columns.Add("TOTAL", 70, HorizontalAlignment.Left);

            txtParcela.Enabled = false;
            dtpVencimento.Enabled = false;
            txtIntervalo.Enabled = false;

            SqlConnection con = new SqlConnection();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //command responsável por buscar resultador
                SqlCommand cmdConsulta = new SqlCommand();
                cmdConsulta.Connection = con;
                cmdConsulta.CommandType = CommandType.Text;
                cmdConsulta.CommandText = "select count(codigo) from movimentacao where tipo = 'A' and datadocadastro = @data";
                cmdConsulta.Parameters.AddWithValue("@data", dtpdata.Text);

                //command responsável por buscar resultador fechado
                SqlCommand cmdConsulta2 = new SqlCommand();
                cmdConsulta2.Connection = con;
                cmdConsulta2.CommandType = CommandType.Text;
                cmdConsulta2.CommandText = "select count(codigo) from movimentacao where tipo = 'F' and datadocadastro = @data";
                cmdConsulta2.Parameters.AddWithValue("@data", dtpdata.Text);

                con.Open();

                int i = Convert.ToInt32(cmdConsulta.ExecuteScalar());
                int j = Convert.ToInt32(cmdConsulta2.ExecuteScalar());

                if (i == 1 && j == 1)
                {
                    MessageBox.Show("CAIXA JÁ FOI ABERTO E FECHADO", "MENSAGEM");
                    btnAbrirCaixa.Enabled = false;
                    btnFechamento.Enabled = false;
                    lblStatus.Text = "CAIXA FECHADO";
                }

                else if (i == 1 && j == 0)
                {
                    MessageBox.Show("CAIXA JÁ ESTÁ ABERTO", "MENSAGEM");
                    btnAbrirCaixa.Enabled = false;
                    lblStatus.Text = "CAIXA ABERTO";
                }
                else if (i == 0 && j == 0)
                {
                    MessageBox.Show("ABRIR O CAIXA", "MENSAGEM");
                    btnAbrirCaixa.Enabled = true;
                    lblStatus.Text = "ABRIR O CAIXA";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Botão Pesquisa Cliente
        private void button1_Click(object sender, EventArgs e)
        {
            PesquisaCliente pro = new PesquisaCliente();
            pro.ShowDialog();
            //txtcodigo.Text = pro.codigo;
            cbbCliente.Text = pro.nome;
            //txtCredito.Text = pro.credito;
            pro.Close();

        }
        #endregion

        #region Metodo Pesquisa Cliente
        public DataTable PesquisaCliente()
        {

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //dataadpter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = "select codigo, nome, credito from cadcliente where tipo = 'cliente' and statuscliente = 'Ativo' ";

                //preencher datatable

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Metodo Pesquisa Produto
        public DataTable PesquisaProduto()
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //dataadpter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = "select codigo, descricao, precoVenda from produto";

                //preencher datatable

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Botão Pesquisa Produto
        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto pqp = new frmPesquisaProduto();
            pqp.ShowDialog();

            cbbProduto.Text = pqp.descricao;
            preco = Convert.ToDecimal(pqp.preco);
            txtPreco.Text = Convert.ToString(preco);


            pqp.Close();
        }
        #endregion

        #region Botão Adcionar
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "CAIXA ABERTO")
            {
                if (cbbCliente.Text.Length > 0 && cbbCondicao.Text.Length > 0)
                {
                    if (cbbProduto.Text.Length > 0)
                    {

                        cbbCliente.Enabled = false;


                        SqlConnection con = new SqlConnection();
                        try
                        {
                            //conexão
                            con.ConnectionString = Dados.conexaoBancoDados;

                            //captura informa o Produto
                            estoqueinformation pdv = new estoqueinformation();
                            pdv.Produto_codigo = (int)cbbProduto.SelectedValue;

                            //captura informa o Cliente
                            clienteInformation cliv = new clienteInformation();
                            cliv.Cl_codigo = (int)cbbCliente.SelectedValue;

                            /*command responsável por buscar
                             * a quantidade em estoque do determinado produto */
                            SqlCommand cmdquant = new SqlCommand();
                            cmdquant.Connection = con;
                            cmdquant.CommandType = CommandType.Text;
                            cmdquant.CommandText = "select quantidade from produto where codigo = @prd_cod";
                            cmdquant.Parameters.AddWithValue("@prd_cod", pdv.Produto_codigo);



                            /*command responsável por buscar
                             * a quantidade em estoque do determinado produto
                            SqlCommand cmdpreco = new SqlCommand();
                            cmdpreco.Connection = con;
                            cmdpreco.CommandType = CommandType.Text;
                            cmdpreco.CommandText = "select preco from produto where codigo = @prd_cod";
                            cmdpreco.Parameters.AddWithValue("@prd_cod", pdv.Produto_codigo);*/

                            /*command responsável por buscar
                             * o Limite de Credito de determinado cliente */
                            /*SqlCommand cmdlim = new SqlCommand();
                            cmdlim.Connection = con;
                            cmdlim.CommandType = CommandType.Text;
                            cmdlim.CommandText = "select credito from cadcliente where codigo = @cli_cod";
                            cmdlim.Parameters.AddWithValue("@cli_cod", cliv.Cl_codigo);*/

                            con.Open();

                            //Executar query com obtenção de quantidade em estoque
                            //decimal resultadolim = Convert.ToDecimal(cmdlim.ExecuteScalar());
                            int resultado = Convert.ToInt32(cmdquant.ExecuteScalar());
                            //txtPreco.Text = Convert.ToString(cmdpreco.ExecuteScalar());


                            //verificar se tem o produto no estoque
                            if (resultado > 0)
                            {
                                //preparar a ListView para inserção dos produtos
                                ListViewItem item = new ListViewItem(cbbProduto.Text);
                                int quantidade = Convert.ToInt32(txtquantidade.Text);

                                if (quantidade <= resultado)
                                {
                                    if ((quantidade * Convert.ToDecimal(txtPreco.Text)) > 0)
                                    {

                                        //adicionar subitem no ListView
                                        item.SubItems.Add(Convert.ToString(pdv.Produto_codigo));
                                        item.SubItems.Add(Convert.ToString(quantidade));
                                        item.SubItems.Add(Convert.ToString(quantidade * Convert.ToDecimal(txtPreco.Text)));
                                        item.SubItems.Add(Convert.ToString(btnremover));
                                        //colocar objetos na ListView
                                        this.listavenda.Items.Add(item);

                                        //baixa em estoque do produto selecionado
                                        SqlCommand cmdBaixa = new SqlCommand();
                                        cmdBaixa.Connection = con;
                                        cmdBaixa.CommandType = CommandType.Text;
                                        cmdBaixa.CommandText = "update produto set quantidade = quantidade - @quantidade where codigo = @cod_baixa";

                                        //parametro
                                        cmdBaixa.Parameters.AddWithValue("@cod_baixa", pdv.Produto_codigo);
                                        cmdBaixa.Parameters.AddWithValue("@quantidade", quantidade);


                                        txtSubT.Text = Convert.ToString((quantidade * Convert.ToDecimal(txtPreco.Text)) + Convert.ToDecimal(txtSubT.Text));

                                        txtTotal.Text = Convert.ToString((quantidade * Convert.ToDecimal(txtPreco.Text)) + Convert.ToDecimal(txtTotal.Text));
                                        total = Convert.ToDecimal(txtTotal.Text);

                                        //resultadolim = resultadolim - total;
                                        /* o Limite de Credito de determinado cliente */


                                        pdv.Preco = Convert.ToDecimal(txtTotal.Text);

                                        /*SqlCommand limite = new SqlCommand();
                                        limite.Connection = con;
                                        limite.CommandType = CommandType.Text;
                                        limite.CommandText = "update cadcliente set credito = credito - @preco where codigo = @cli_cod";
                                        limite.Parameters.AddWithValue("@cli_cod", cliv.Cl_codigo);
                                        limite.Parameters.AddWithValue("@preco", pdv.Preco);*/


                                        //executar a query
                                        cmdBaixa.ExecuteNonQuery();
                                        //limite.ExecuteNonQuery();


                                    }

                                    else
                                    {
                                        MessageBox.Show("TOTAL DO PRODUTO ESTÁ ZERADO");
                                    }
                                }

                                else
                                {
                                    throw new Exception("PRODUTO SEM SALDO NO ESTOQUE");
                                }
                            }
                            else
                            {
                                throw new Exception("PRODUTO SEM SALDO NO ESTOQUE");
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        finally
                        {


                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("SELECIONE UM PRODUTO PARA ADICIONAR", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("VERIFIQUE SE OS CAMPOS: CLIENTE E CONDIÇÃO ESTÃO PREENCHIDOS", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("ABRA O CAIXA PARA REALIZAR O PEDIDO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Botão Finalizar
        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            if ((txtEntrada.Text == "0" || txtEntrada.Text == "0,00") && (txtDescontoPorcentagem.Text == "0") && (txtDescontoValor.Text == "0" || txtDescontoValor.Text == "0,00"))
            {
                if (txtTotal.Text == txtSubT.Text)
                {
                    liberado = 1;
                }
            }
            else if ((txtEntrada.Text != "0" && txtEntrada.Text != "0,00") || (txtDescontoPorcentagem.Text != "0") || (txtDescontoValor.Text != "0" && txtDescontoValor.Text != "0,00"))
            {
                if (txtTotal.Text != txtSubT.Text)
                {
                    liberado = 1;
                }

            }

            if ((cbbCondicao.Text == "PRAZO" || cbbCondicao.Text == "CHEQUE") && (txtIntervalo.Text == "0" || txtIntervalo.Text == "" || txtIntervalo.Text == " "))
            {
                liberado = 0;
            }
            else
            {
                liberado = 1;
            }

            if (liberado == 1)
            {
                tot = Convert.ToDecimal(txtTotal.Text);

                if (tot > resultadolim)
                {
                    MessageBox.Show("LIMITE DE CRÉDITO EXCEDIDO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Abrindo comando de conexao com o SQL - Banco de Dados
                    SqlConnection con = new SqlConnection();

                    //conexão com o Banco de Dados
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //Instanciando as classes para passar para o Bando de Dados
                    baixainformation ven = new baixainformation();
                    contasinformation cre = new contasinformation();

                    //Inicio da Gravação da venda no Banco de Dados
                    try
                    {
                        //Verifica se a listview contem um item e inicia
                        if (listavenda.Items.Count > 0)
                        {
                            //Gravar Baixa - Parametros                    
                            ven.Data = dtpdata.Value;
                            ven.Nome = cbbCliente.Text;
                            ven.Cadcliente_codigo = (int)cbbCliente.SelectedValue;
                            ven.NomeArquivo = txtNomeArquivo.Text;
                            ven.Preco = Convert.ToDecimal(txtTotal.Text);
                            ven.Condicao = cbbCondicao.Text;
                            ven.Operador = lblVendedorVenda.Text;

                            if (ven.Preco > 0)
                            {
                                if (txtDescontoPorcentagem.Text.Length == 0)
                                {
                                    txtDescontoPorcentagem.Text = "0";
                                }
                                ven.DescontoP = Convert.ToDecimal(txtDescontoPorcentagem.Text);

                                if (txtDescontoValor.Text.Length == 0)
                                {
                                    txtDescontoValor.Text = "0,00";
                                }
                                ven.DescontoV = Convert.ToDecimal(txtDescontoValor.Text);

                                if (txtEntrada.Text.Length == 0)
                                {
                                    txtEntrada.Text = "0,00";
                                }
                                ven.Entrada = Convert.ToDecimal(txtEntrada.Text);

                                ven.Subtotal = Convert.ToDecimal(txtSubT.Text);

                                //Gravar Contas a Receber - Parametros                      
                                cre.Cr_codigocliente = (int)cbbCliente.SelectedValue;
                                cre.Cr_datacadastro = Convert.ToDateTime(dtpdata.Text);
                                cre.Cr_baixado = 'N';
                                cre.Cr_especie = cbbCondicao.Text;
                                int p = Convert.ToInt32(txtParcela.Text);
                                //cre.Cr_valor = Convert.ToDecimal(txtTotal.Text) / p;
                                int intervalo = Convert.ToInt32(txtIntervalo.Text);
                                cre.Cr_prazo = intervalo;

                                //command
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "insert into baixa(datab, nome, quantidade, cadcliente_codigo, oscodigo, nomearquivo, preco, descontoP, descontoV, entrada, subtotal, condicao, operador) values (@Data, @Nome, @Quantidade, @Cadcliente_codigo, @OsCodigo, @NomeArquivo, @preco, @descontoP, @descontoV, @entrada, @subtotal, @condicao, @operador) select SCOPE_IDENTITY()";

                                //parametros vendas
                                cmd.Parameters.AddWithValue("@data", ven.Data);
                                cmd.Parameters.AddWithValue("@nome", ven.Nome);
                                cmd.Parameters.AddWithValue("@quantidade", ven.Quantidade);
                                cmd.Parameters.AddWithValue("@cadcliente_codigo", ven.Cadcliente_codigo);
                                cmd.Parameters.AddWithValue("@oscodigo", ven.OsCodigo);
                                cmd.Parameters.AddWithValue("@nomearquivo", ven.NomeArquivo);
                                cmd.Parameters.AddWithValue("@preco", ven.Preco);
                                cmd.Parameters.AddWithValue("@descontoP", ven.DescontoP);
                                cmd.Parameters.AddWithValue("@descontoV", ven.DescontoV);
                                cmd.Parameters.AddWithValue("@entrada", ven.Entrada);
                                cmd.Parameters.AddWithValue("@subtotal", ven.Subtotal);
                                cmd.Parameters.AddWithValue("@condicao", ven.Condicao);
                                cmd.Parameters.AddWithValue("@operador", ven.Operador);


                                // Abrir conexão com o Banco de Dados
                                con.Open();

                                // Executar query com ExecuteScalar para obter o SCOPE_IDENTITY
                                int ven_cod = Convert.ToInt32(cmd.ExecuteScalar());

                                // Identificar produtos da venda
                                estoqueinformation pdv = new estoqueinformation();
                                pdv.Baixa_codigo = ven_cod;
                                txtcodigo.Text = Convert.ToString(pdv.Baixa_codigo);
                                cre.Cr_ficha = ven_cod;

                                // CONDICAO PARA IMPRIMIR ---------------------------------------------
                                impVenda = ven_cod;
                                impCliente = cbbCliente.Text;
                                impVendedor = lblVendedorVenda.Text;
                                impCondicao = cbbCondicao.Text;


                                // Comando para buscar o codigo do produto
                                SqlCommand cmdbusca = new SqlCommand();
                                cmdbusca.Connection = con;
                                cmdbusca.CommandType = CommandType.Text;
                                cmdbusca.CommandText = "select codigo from produto where descricao = @prod_nome";


                                // Comando para dar baixa nos produtos baixados no estoque
                                SqlCommand cmdinsert = new SqlCommand();
                                cmdinsert.Connection = con;
                                cmdinsert.CommandType = CommandType.Text;
                                cmdinsert.CommandText = " insert into estoque(baixa_codigo, produto_codigo, estoque_qtd, preco) values (@baixa_codigo, @produto_codigo, @estoque_qtd, @preco)";

                                cre.Cr_valor = Math.Round((Convert.ToDecimal(txtTotal.Text) / p), 2);

                                decimal saldo = Convert.ToDecimal(txtTotal.Text);                                

                                if (txtIntervalo.Text != "0")
                                {
                                    //Parcelas
                                    while (p != 0)
                                    {
                                        DateTime vencimento = new DateTime();
                                        vencimento = Convert.ToDateTime(dtpVencimento.Text);

                                        switch (p)
                                        {
                                            case 1:
                                                cre.Cr_parcela = Convert.ToChar("A");
                                                cre.Cr_datavencimento = vencimento;
                                                cre.Cr_valor = saldo;
                                                break;
                                            case 2:
                                                cre.Cr_parcela = Convert.ToChar("B");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo);
                                                break;
                                            case 3:
                                                cre.Cr_parcela = Convert.ToChar("C");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo * (p-1));
                                                break;
                                            case 4:
                                                cre.Cr_parcela = Convert.ToChar("D");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo * (p - 1));
                                                break;
                                            case 5:
                                                cre.Cr_parcela = Convert.ToChar("E");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo * (p - 1));
                                                break;
                                            case 6:
                                                cre.Cr_parcela = Convert.ToChar("F");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo * (p - 1));
                                                break;
                                            case 7:
                                                cre.Cr_parcela = Convert.ToChar("G");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo * (p - 1));
                                                break;
                                            case 8:
                                                cre.Cr_parcela = Convert.ToChar("H");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo * (p - 1));
                                                break;
                                            case 9:
                                                cre.Cr_parcela = Convert.ToChar("I");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo * (p - 1));
                                                break;
                                            case 10:
                                                cre.Cr_parcela = Convert.ToChar("J");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo * (p - 1));
                                                break;
                                            case 11:
                                                cre.Cr_parcela = Convert.ToChar("K");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo * (p - 1));
                                                break;
                                            case 12:
                                                cre.Cr_parcela = Convert.ToChar("L");
                                                cre.Cr_datavencimento = vencimento.AddDays(intervalo * (p - 1));
                                                break;
                                        }
                                        try
                                        {
                                            //command
                                            SqlCommand cmdcr = new SqlCommand();
                                            cmdcr.Connection = con;
                                            cmdcr.CommandType = CommandType.Text;
                                            cmdcr.CommandText = "insert into contasareceber (ficha, codigocliente, valor, parcela, datacadastro, datavencimento, baixado, especie, prazo) values (@cr_ficha, @cr_codigocliente, @cr_valor, @cr_parcela, @cr_datacadastro, @cr_datavencimento, @cr_baixado, @cr_especie, @cr_prazo)";

                                            //parametros
                                            //cmd.Parameters.AddWithValue("@cliente_codigo", usu.Cl_codigo);
                                            //cre.Cr_codigo = Convert.ToInt32(txtcodigo.Text);
                                            cmdcr.Parameters.AddWithValue("@cr_ficha", cre.Cr_ficha);
                                            cmdcr.Parameters.AddWithValue("@cr_codigocliente", cre.Cr_codigocliente);
                                            cmdcr.Parameters.AddWithValue("@cr_valor", cre.Cr_valor);
                                            cmdcr.Parameters.AddWithValue("@cr_parcela", cre.Cr_parcela);
                                            cmdcr.Parameters.AddWithValue("@cr_datacadastro", cre.Cr_datacadastro);
                                            cmdcr.Parameters.AddWithValue("@cr_datavencimento", cre.Cr_datavencimento);
                                            cmdcr.Parameters.AddWithValue("@cr_baixado", cre.Cr_baixado);
                                            cmdcr.Parameters.AddWithValue("@cr_especie", cre.Cr_especie);
                                            cmdcr.Parameters.AddWithValue("@cr_prazo", cre.Cr_prazo);

                                            /*Comando para dar baixa nos produtos baixados no estoque
                                            SqlCommand cmdrec = new SqlCommand();
                                            cmdrec.Connection = con;
                                            cmdrec.CommandType = CommandType.Text;
                                            cmdrec.CommandText = " insert into recebimento(codigo_contasareceber) values (@rec_codigo)";

                                            cmdrec.Parameters.AddWithValue("", );*/

                                            cmdcr.ExecuteNonQuery();

                                            p--;
                                            saldo = saldo - cre.Cr_valor;

                                            /*limpando parametros teste 03 10 2017
                                            cmdcr.Parameters.RemoveAt("@cr_ficha");
                                            cmdcr.Parameters.RemoveAt("@cr_codigocliente");
                                            cmdcr.Parameters.RemoveAt("@cr_valor");
                                            cmdcr.Parameters.RemoveAt("@cr_parcela");
                                            cmdcr.Parameters.RemoveAt("@cr_datacadastro");
                                            cmdcr.Parameters.RemoveAt("@cr_datavencimento");
                                            cmdcr.Parameters.RemoveAt("@cr_baixado");
                                            cmdcr.Parameters.RemoveAt("@cr_especie");
                                            cmdcr.Parameters.RemoveAt("@cr_prazo");*/

                                        }

                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK);
                                        }
                                    }
                                }

                                //percorrer a ListView
                                foreach (ListViewItem item in listavenda.Items)
                                {

                                    /// dhfjdhasjfhjsdkjfksdjkfjsdkijfk
                                    string valor = Convert.ToString(item.SubItems[2].Text);
                                    pdv.Estoque_qtd = valor;

                                    string real = Convert.ToString(item.SubItems[3].Text);
                                    pdv.Preco = Convert.ToDecimal(real);

                                    //capturar o nome do produto
                                    cmdbusca.Parameters.AddWithValue("@prod_nome", item.Text);


                                    //buscar o codigo do produto
                                    int codigoProduto = Convert.ToInt32(cmdbusca.ExecuteScalar());

                                    //passar o parametro para Insert 
                                    cmdinsert.Parameters.AddWithValue("@baixa_codigo", pdv.Baixa_codigo);
                                    cmdinsert.Parameters.AddWithValue("@produto_codigo", codigoProduto);
                                    cmdinsert.Parameters.AddWithValue("@estoque_qtd", pdv.Estoque_qtd);
                                    cmdinsert.Parameters.AddWithValue("@preco", pdv.Preco);

                                    //executar a query da Produto Estoque
                                    cmdinsert.ExecuteNonQuery();

                                    co = Convert.ToString(pdv.Baixa_codigo);

                                    //limpar os parametros                           

                                    ////////////////////////////////////////////////
                                    cmdbusca.Parameters.RemoveAt("@prod_nome");

                                    /////////////////////////////////////////////////
                                    cmdinsert.Parameters.RemoveAt("@estoque_qtd");
                                    cmdinsert.Parameters.RemoveAt("@baixa_codigo");
                                    cmdinsert.Parameters.RemoveAt("@produto_codigo");
                                    cmdinsert.Parameters.RemoveAt("@preco");
                                }

                                if (cbbCondicao.Text == "CHEQUE" || cbbCondicao.Text == "PRAZO")
                                {
                                    sub = Convert.ToDecimal(txtTotal.Text);

                                    /* o Limite de Credito de determinado cliente */
                                    resultadolim = resultadolim - sub;

                                    SqlCommand limite = new SqlCommand();
                                    limite.Connection = con;
                                    limite.CommandType = CommandType.Text;
                                    limite.CommandText = "update cadcliente set credito = credito - @preco where codigo = @cli_cod";
                                    limite.Parameters.AddWithValue("@cli_cod", ven.Cadcliente_codigo);
                                    limite.Parameters.AddWithValue("@preco", sub);

                                    //executar a query do Limite
                                    limite.ExecuteNonQuery();
                                }

                                MessageBox.Show("VENDA EFETUADA COM SUCESSO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtcancelar.Enabled = true;

                                // IMPRESSAO
                                impEntrada = txtEntrada.Text;
                                impDescV = txtDescontoValor.Text;
                                impDescP = txtDescontoPorcentagem.Text;
                                impSub = txtSubT.Text;
                                impTotal = Convert.ToDecimal(txtTotal.Text);
                                impPrazo = txtIntervalo.Text;
                                impParcela = txtParcela.Text;
                                impData = dtpVencimento.Text;

                                if (MessageBox.Show("DESEJA IMPRIMIR O DOCUMENTO ?", "MENSAGEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                                {
                                    /*int margeIn = CentToPol(3);
                                    printDocument1.DefaultPageSettings.Margins = new Margins(margeIn, margeIn, margeIn, margeIn);

                                    int larguraIn = CentToPol(21);
                                    int alturaIn = CentToPol(29.7);

                                    PaperSize paperSize = new PaperSize("MeuTipo", larguraIn, alturaIn);

                                    printDocument1.DefaultPageSettings.PaperSize = paperSize;
                                    printDocument1.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;

                                    printDialog1.Document = printDocument1;*/
                                    printPreviewDialog1.ShowDialog();

                                }
                                else
                                {
                                    listavenda.Items.Clear();
                                }

                                LimpaTela();
                            }
                            else
                            {
                                MessageBox.Show("VENDA ESTÁ NEGATIVA", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else
                        {
                            MessageBox.Show("PREENCHA TODOS OS CAMPOS", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO CONTATE O ADMINISTRADOR DO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Limpa lista de produtos
                        listavenda.Items.Clear();

                        liberado = 0;

                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("VERIFIQUE SE FOI CONCEDIDO O DESCONTO\nVERIFIQUE SE O PRAZO ESTÁ ZERADO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int CentToPol(double p)
        {
            return (int)Math.Round(p / 0.393701 * 100, MidpointRounding.AwayFromZero);
        }
        #endregion

        #region Botão Remover
        private void btnremover_Click(object sender, EventArgs e)
        {
            if (listavenda.SelectedItems.Count != 0)
            {
                ProdutoInformation prod = new ProdutoInformation();
                prod.Pr_descricao = listavenda.SelectedItems[0].Text;
                int quantidade = int.Parse(listavenda.FocusedItem.SubItems[2].Text);

                clienteInformation cliente = new clienteInformation();
                cliente.Cl_nome = cbbCliente.Text;
                cliente.Credito = Convert.ToDecimal(txtTotal.Text);

                SqlConnection con = new SqlConnection();
                try
                {
                    //conexão
                    con.ConnectionString = Dados.conexaoBancoDados;

                    //command extorno para estoque
                    SqlCommand cmdexterno = new SqlCommand();
                    cmdexterno.Connection = con;
                    cmdexterno.CommandType = CommandType.Text;
                    cmdexterno.CommandText = "update produto set quantidade = quantidade + @quantidade where descricao = @prod_nome";

                    //Command para retornar os valores de crédito
                    SqlCommand cmdcredito = new SqlCommand();
                    cmdcredito.Connection = con;
                    cmdcredito.CommandType = CommandType.Text;
                    cmdcredito.CommandText = "update cadcliente set credito = credito + @credito where nome = @nome";


                    //parametros
                    cmdcredito.Parameters.AddWithValue("@nome", cliente.Cl_nome);
                    cmdcredito.Parameters.AddWithValue("@credito", cliente.Credito);
                    cmdexterno.Parameters.AddWithValue("@prod_nome", prod.Pr_descricao);
                    cmdexterno.Parameters.AddWithValue("@quantidade", quantidade);

                    //abrir conexão
                    con.Open();

                    //executa a query de extorno
                    cmdexterno.ExecuteNonQuery();
                    cmdcredito.ExecuteNonQuery();

                    //remover valor do produto no total da venda
                    decimal prod_preco = Convert.ToDecimal(listavenda.FocusedItem.SubItems[3].Text);
                    decimal ven_total = Convert.ToDecimal(txtTotal.Text);

                    txtTotal.Text = Convert.ToString(ven_total - prod_preco);
                    txtSubT.Text = Convert.ToString(ven_total - prod_preco);

                    //remover o filme da listviw
                    listavenda.Items.RemoveAt(Convert.ToInt32(listavenda.SelectedIndices[0].ToString()));

                    if (listavenda.Items.Count == 0)
                    {
                        txtSubT.Text = "0,00";
                        txtTotal.Text = "0,00";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("SELECIONE O PRODUTO PARA REMOVER ", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        #endregion

        #region Botão Retornar
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (cbbCliente.Text.Length == 0)
            {
                if (MessageBox.Show("DESEJA RETORNAR AO MENU ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("REMOVA TODOS OS ITEMS DA VENDA E CANCELE O PEDIDO PARA VOLTAR AO MENU PRINCIPAL", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReimpressão_Click(object sender, EventArgs e)
        {
            frmReempressaoDeDocumento Re = new frmReempressaoDeDocumento();
            Re.ShowDialog();
        }
        #endregion

        #region LimpaTela
        private void LimpaTela()
        {
            //listavenda.Items.Clear();
            txtNomeArquivo.Clear();
            //txtOsCodigo.Clear();
            cbbCliente.SelectedIndex = -1;
            cbbProduto.SelectedIndex = -1;
            txtTotal.Text = "0,00";
            txtPreco.Text = "0,00";
            cbbCliente.Enabled = true;
            txtquantidade.Text = "1";
            txtIntervalo.Text = "0";
            dtpVencimento.ResetText();
            txtParcela.Value = 1;
            cbbCondicao.SelectedIndex = -1;
            txtParcela.Enabled = false;
            dtpVencimento.Enabled = false;
            txtIntervalo.Enabled = false;
            txtDescontoPorcentagem.Text = "0";
            txtDescontoValor.Text = "0,00";
            txtEntrada.Text = "0,00";
            txtSubT.Text = "0,00";
            txtIntervalo.Text = "0";
            entrada = 0;
            descontoP = 0;
            descontoV = 0;
        }
        #endregion

        #region BotãoLimpa tela
        private void txtcancelar_Click(object sender, EventArgs e)
        {

            if (listavenda.Items.Count > 0)
            {
                MessageBox.Show("REMOVA TODOS OS ITEMS DA LISTA PARA CANCELAR O PEDIDO", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cbbCliente.ResetText();
                LimpaTela();
                //listavenda.Clear();

            }

        }
        #endregion

        #region Seleciona cliente

        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteInformation cliente = new clienteInformation();
            cliente.Cl_nome = cbbCliente.Text;


            SqlConnection con = new SqlConnection();
            try
            {

                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //Command para retornar os valores de crédito
                SqlCommand cmdcredito = new SqlCommand();
                cmdcredito.Connection = con;
                cmdcredito.CommandType = CommandType.Text;
                cmdcredito.CommandText = "select credito from cadcliente where nome = @nome";

                //parametros
                cmdcredito.Parameters.AddWithValue("@nome", cliente.Cl_nome);


                //abrir conexão
                con.Open();

                //executa a query de extorno
                cmdcredito.ExecuteNonQuery();

                resultadolim = Convert.ToDecimal(cmdcredito.ExecuteScalar());
                txtCredito.Text = Convert.ToString(resultadolim);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Seleciona Produto Preco
        private void cbbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoInformation produto = new ProdutoInformation();
            produto.Pr_descricao = cbbProduto.Text;

            SqlConnection con = new SqlConnection();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //Command para retornar os valores de crédito
                SqlCommand cmdcredito = new SqlCommand();
                cmdcredito.Connection = con;
                cmdcredito.CommandType = CommandType.Text;
                cmdcredito.CommandText = "select precoVenda from produto where descricao = @nome";

                //Command para retornar os valores de crédito
                SqlCommand cmdcredito1 = new SqlCommand();
                cmdcredito1.Connection = con;
                cmdcredito1.CommandType = CommandType.Text;
                cmdcredito1.CommandText = "select quantidade from produto where descricao = @nome";

                //parametros
                cmdcredito.Parameters.AddWithValue("@nome", produto.Pr_descricao);
                cmdcredito1.Parameters.AddWithValue("@nome", produto.Pr_descricao);


                //abrir conexão
                con.Open();

                //executa a query de extorno
                cmdcredito.ExecuteNonQuery();
                cmdcredito1.ExecuteNonQuery();

                decimal resultadolim = Convert.ToDecimal(cmdcredito.ExecuteScalar());
                txtPreco.Text = Convert.ToString(resultadolim);
                saldoEtq = Convert.ToInt32(cmdcredito1.ExecuteScalar());
                txtSaldoEtq.Text = Convert.ToString(saldoEtq);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Tipo de venda Ativa ou Desativa número de parcelas
        private void cbbCondicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCondicao.SelectedIndex == 0 || cbbCondicao.SelectedIndex == 1 || cbbCondicao.SelectedIndex == 2)
            {
                txtParcela.Enabled = false;
                dtpVencimento.Enabled = false;
                txtIntervalo.Enabled = false;
                txtIntervalo.Text = "0";
            }
            else
            {
                txtParcela.Enabled = true;
                dtpVencimento.Enabled = true;
                txtIntervalo.Enabled = true;
                txtIntervalo.Text = "1";
            }
        }
        #endregion

        /*private void updateTax()
        {
            entrada = Convert.ToDecimal(txtEntrada.Text);
            this.txtEntrada.Text = txtEntrada.Text;
            updateTotal();
        }

        private void updateTotal()
        {
            this.txtTotal.Text = Convert.ToString(entrada);
        }*/

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            //updateTax();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSubT.Text.Length > 0 && listavenda.Items.Count > 0)
            {
                total = Convert.ToDecimal(txtSubT.Text);

                if (txtDescontoValor.TextLength == 0)
                {
                    txtDescontoValor.Text = "0,00";
                    descontoV = 0;
                }
                else
                {
                    descontoV = Convert.ToDecimal(txtDescontoValor.Text);

                }

                if (txtDescontoPorcentagem.TextLength == 0)
                {
                    txtDescontoPorcentagem.Text = "0";
                    descontoP = 0;
                }
                else
                {
                    descontoP = Convert.ToDecimal(txtDescontoPorcentagem.Text);

                }
                //Entra valor zero
                if (txtEntrada.TextLength == 0)
                {
                    txtEntrada.Text = "0,00";
                    entrada = 0;
                }
                else
                {
                    entrada = Convert.ToDecimal(txtEntrada.Text);
                }

                if (entrada >= 0 && descontoV >= 0 && descontoP >= 0)
                {
                    if (entrada > 0)
                    {
                        txtTotal.Text = Convert.ToString(total - entrada);
                    }

                    else if (entrada == 0)
                    {
                        txtTotal.Text = txtSubT.Text;
                    }

                    if (descontoP > 0 && descontoV == 0)
                    {

                        txtTotal.Text = Convert.ToString(total - (((descontoP / 100) * total) + entrada));

                    }
                    else if (descontoP == 0 && descontoV == 0 && entrada == 0)
                    {
                        txtTotal.Text = txtSubT.Text;
                    }


                    if (descontoP == 0 && descontoV > 0)
                    {

                        txtTotal.Text = Convert.ToString(total - (descontoP + descontoV + entrada));

                    }
                    else if (descontoV == 0 && descontoP == 0 && entrada == 0)
                    {
                        txtTotal.Text = txtSubT.Text;
                    }

                    if (descontoP > 0 && descontoV > 0)
                    {

                        MessageBox.Show("PERMITIDO DESCONTO EM VALOR OU PERCENTUAL", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    clique = 1;
                }
            }
        }

        #region Botão Fechar Caixa
        private void btnFechamento_Click(object sender, EventArgs e)
        {
            frmFechamentoCaixa fch = new frmFechamentoCaixa();
            fch.operador = vendedor;
            fch.bt = btnFechamento;
            fch.status = lblStatus;
            fch.ShowDialog();

        }
        #endregion

        #region Abrir caixa
        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            frmAberturaDeCaixa abr = new frmAberturaDeCaixa();
            abr.operador = vendedor;
            abr.bt = btnAbrirCaixa;
            abr.status = lblStatus;
            abr.ShowDialog();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txtDescontoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtDescontoValor.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

                //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDescontoPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtDescontoPorcentagem.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

                //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtEntrada.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

                //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnRecebimento_Click(object sender, EventArgs e)
        {
            frmReceber rec = new frmReceber();
            rec.ShowDialog();
        }

        #region Form do Visualizador de Impressão iniciar Maximizado
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region Folha de Impressão Configuração da Página que vai ser imprensa
        public void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            Font fonte = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            Font fonte2 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);

            e.Graphics.DrawString("LEVINA CARNEIRO", fonte2, Brushes.Black, 20, 10);
            e.Graphics.DrawString("DOS SANTOS", fonte2, Brushes.Black, 30, 20);
            e.Graphics.DrawString("COMPROVANTE INTERNO - SEM VALOR FISCAL", fonte2, Brushes.Black, 250, 10);
            e.Graphics.DrawString("DATA: " + DateTime.Now, fonte2, Brushes.Black, 550, 10);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fonte2, Brushes.Black, 20, 30);

            e.Graphics.DrawString("NÚMERO: ", fonte, Brushes.Black, 20, 40);
            e.Graphics.DrawString(Convert.ToString(impVenda), fonte2, Brushes.Black, 90, 40);

            e.Graphics.DrawString("CLIENTE: ", fonte, Brushes.Black, 200, 40);
            e.Graphics.DrawString(impCliente, fonte2, Brushes.Black, 350, 40);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fonte2, Brushes.Black, 20, 60);

            e.Graphics.DrawString("VENDEDOR(A): ", fonte, Brushes.Black, 20, 80);
            e.Graphics.DrawString(impVendedor, fonte2, Brushes.Black, 120, 80);

            e.Graphics.DrawString("CONDIÇÃO: ", fonte, Brushes.Black, 200, 80);
            e.Graphics.DrawString(impCondicao, fonte2, Brushes.Black, 350, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fonte2, Brushes.Black, 20, 100);
            e.Graphics.DrawString("PRODUTOS", fonte, Brushes.Black, 20, 110);
            e.Graphics.DrawString("QTD", fonte, Brushes.Black, 320, 110);
            e.Graphics.DrawString("R$", fonte, Brushes.Black, 540, 110);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fonte2, Brushes.Black, 20, 120);

            int altura = 130;

            //Verifica quantos items foi vendido e imprimi na folha
            for (int i = 0; i < listavenda.Items.Count; i++)
            {
                e.Graphics.DrawString(listavenda.Items[i].SubItems[0].Text, fonte2, Brushes.Black, 20, altura);
                e.Graphics.DrawString(listavenda.Items[i].SubItems[2].Text, fonte2, Brushes.Black, 320, altura);
                e.Graphics.DrawString(listavenda.Items[i].SubItems[3].Text, fonte2, Brushes.Black, 540, altura);
                altura = altura + 10;
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fonte2, Brushes.Black, 20, altura + 20);

            altura += 30;

            e.Graphics.DrawString("ENTRADA: ", fonte, Brushes.Black, 20, altura);
            e.Graphics.DrawString("DESC.VALOR: ", fonte, Brushes.Black, 250, altura);
            e.Graphics.DrawString("DESC.PERCENTUAL: ", fonte, Brushes.Black, 500, altura);
            altura += 10;
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fonte2, Brushes.Black, 20, altura);
            altura += 20;
            e.Graphics.DrawString("R$ " + impEntrada, fonte2, Brushes.Black, 20, altura);
            e.Graphics.DrawString("R$ " + impDescV, fonte2, Brushes.Black, 250, altura);
            e.Graphics.DrawString("% " + impDescP, fonte2, Brushes.Black, 500, altura);
            altura += 20;
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fonte2, Brushes.Black, 20, altura);

            altura += 20;
            e.Graphics.DrawString("SUBTOTAL: ", fonte, Brushes.Black, 20, altura);
            e.Graphics.DrawString("TOTAL: ", fonte, Brushes.Black, 250, altura);
            altura += 20;

            e.Graphics.DrawString("R$ " + impSub, fonte2, Brushes.Black, 20, altura);
            e.Graphics.DrawString("R$ " + impTotal, fonte2, Brushes.Black, 250, altura);
            altura += 20;
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fonte2, Brushes.Black, 20, altura);
            altura += 20;

            e.Graphics.DrawString("VENCIMENTO: ", fonte, Brushes.Black, 20, altura);
            altura += 20;

            /*-------*/
            decimal to;
            int pa; 
            decimal saldo;
            
            int intervalo = Convert.ToInt32(impPrazo);
            pa = Convert.ToInt32(impParcela); 
           
            to = Math.Round((Convert.ToDecimal(txtTotal.Text) / pa), 2);
            saldo = Convert.ToDecimal(txtTotal.Text);
            
            if (txtIntervalo.Text != "0")
            {
                //Parcelas
                while (pa != 0)
                {
                    DateTime vencimento = new DateTime();
                    vencimento = Convert.ToDateTime(dtpVencimento.Text);

                    switch (pa)
                    {
                        case 1:
                            e.Graphics.DrawString(vencimento.ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(saldo.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 2:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 3:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * (pa-1)).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 4:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * (pa - 1)).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 5:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * (pa - 1)).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 6:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * (pa - 1)).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 7:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * (pa - 1)).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 8:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * (pa - 1)).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 9:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * (pa - 1)).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 10:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * (pa - 1)).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 11:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * (pa - 1)).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 12:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * (pa - 1)).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                    }

                    pa--;
                    saldo = saldo - to;
                    altura = altura + 20;
                }
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fonte2, Brushes.Black, 20, 1090);
            e.Graphics.DrawString("SCION TECHNOLOGY® - www.sciontech.com.br", fonte2, Brushes.Black, 20, 1110);
        }
        #endregion        

      
    }
}
   
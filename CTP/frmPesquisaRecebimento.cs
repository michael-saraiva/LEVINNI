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
    public partial class frmPesquisaRecebimento : Form
    {

        public frmPesquisaRecebimento()
        {
            InitializeComponent();
        }

        public string codigo, ficha, codigocliente, cliente, parcela, valor, datavencimento, valorEmAberto, valorPago;

        private void frmPesquisaRecebimento_Load(object sender, EventArgs e)
        {
            dtgPesquisaRecebimento.DataSource = AtualizaGridCliente(txtfiltroFicha.Text);
            dtgPesquisaRecebimento.DataSource = AtualizaGridFicha(txtfiltroCliente.Text);
            

            // cabeçalho datagrid
            dtgPesquisaRecebimento.Columns[0].HeaderText = "CODIGO";
            dtgPesquisaRecebimento.Columns[1].HeaderText = "FICHA";
            dtgPesquisaRecebimento.Columns[2].HeaderText = "COD.CLIENTE";
            dtgPesquisaRecebimento.Columns[3].HeaderText = "CLIENTE";
            dtgPesquisaRecebimento.Columns[4].HeaderText = "PARCELA";
            dtgPesquisaRecebimento.Columns[5].HeaderText = "VALOR";
            dtgPesquisaRecebimento.Columns[6].HeaderText = "ESPECIE";
            dtgPesquisaRecebimento.Columns[7].HeaderText = "VENCIMENTO";
            dtgPesquisaRecebimento.Columns[8].HeaderText = "PRAZO";
            dtgPesquisaRecebimento.Columns[9].HeaderText = "BAIXADO";
            dtgPesquisaRecebimento.Columns[10].HeaderText = "À PAGAR";
            dtgPesquisaRecebimento.Columns[11].HeaderText = "RECEBIDO";

            //largura das colucas
            dtgPesquisaRecebimento.Columns[0].Width = 60;
            dtgPesquisaRecebimento.Columns[1].Width = 80;
            dtgPesquisaRecebimento.Columns[2].Width = 90;
            dtgPesquisaRecebimento.Columns[3].Width = 220;
            dtgPesquisaRecebimento.Columns[4].Width = 100;
            dtgPesquisaRecebimento.Columns[5].Width = 80;
            dtgPesquisaRecebimento.Columns[6].Width = 150;
            dtgPesquisaRecebimento.Columns[7].Width = 90;
            dtgPesquisaRecebimento.Columns[8].Width = 65;
            dtgPesquisaRecebimento.Columns[9].Width = 65;
            dtgPesquisaRecebimento.Columns[10].Width = 80;
            dtgPesquisaRecebimento.Columns[11].Width = 70;

            //permissões da datagrid
            dtgPesquisaRecebimento.ReadOnly = true;
            dtgPesquisaRecebimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPesquisaRecebimento.AllowUserToAddRows = false;
            dtgPesquisaRecebimento.AllowUserToDeleteRows = false;
            dtgPesquisaRecebimento.AllowUserToResizeColumns = false;
            dtgPesquisaRecebimento.AllowUserToResizeRows = false;
        }

        public DataTable AtualizaGridCliente(string filtro)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                // data adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "SELECT r.codigo, r.ficha, r.codigocliente, c.nome, r. parcela, r.valor, r.especie, r.datavencimento, r.prazo, r.baixado, r.valorEmAberto, r.valorPago FROM contasareceber as r INNER JOIN cadcliente as c ON codigocliente = c.codigo WHERE r.baixado != 's'";

                }
                else
                {
                    da.SelectCommand.CommandText = "SELECT r.codigo, r.ficha, r.codigocliente, c.nome, r. parcela, r.valor, r.especie, r.datavencimento, r.prazo, r.baixado, r.valorEmAberto, r.valorPago FROM contasareceber as r INNER JOIN cadcliente as c ON codigocliente = c.codigo WHERE c.nome like '%' + @prod_nome + '%' and r.baixado != 's' order by r.ficha, r.datavencimento";
                    
                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_nome", filtro);
                    
                }

                //Executar Query
                da.Fill(dt);

                //retorno do método
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        private void txtfiltroCliente_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaRecebimento.DataSource = AtualizaGridCliente(txtfiltroCliente.Text);
        }

        public DataTable AtualizaGridFicha(string filtro)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                // data adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (filtro.Length == 0)
                {
                    da.SelectCommand.CommandText = "SELECT r.codigo, r.ficha, r.codigocliente, c.nome, r. parcela, r.valor, r.especie, r.datavencimento, r.prazo, r.baixado, r.valorEmAberto, r.valorPago FROM contasareceber as r INNER JOIN cadcliente as c ON codigocliente = c.codigo WHERE r.baixado != 's'";

                }
                else
                {
                    da.SelectCommand.CommandText = "SELECT r.codigo, r.ficha, r.codigocliente, c.nome, r. parcela, r.valor, r.especie, r.datavencimento, r.prazo, r.baixado, r.valorEmAberto, r.valorPago FROM contasareceber as r INNER JOIN cadcliente as c ON codigocliente = c.codigo WHERE r.ficha like '%' + @prod_ficha + '%' and r.baixado != 's' order by r.ficha, r.datavencimento";

                    // Parametros
                    da.SelectCommand.Parameters.AddWithValue("@prod_ficha", filtro);

                }

                //Executar Query
                da.Fill(dt);

                //retorno do método
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        private void txtfiltroFicha_TextChanged(object sender, EventArgs e)
        {
            dtgPesquisaRecebimento.DataSource = AtualizaGridFicha(txtfiltroFicha.Text);
        }

        private void dtgPesquisaRecebimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dtgPesquisaRecebimento[0, dtgPesquisaRecebimento.CurrentRow.Index].Value.ToString();
            ficha = dtgPesquisaRecebimento[1, dtgPesquisaRecebimento.CurrentRow.Index].Value.ToString();
            codigocliente = dtgPesquisaRecebimento[2, dtgPesquisaRecebimento.CurrentRow.Index].Value.ToString();
            cliente = dtgPesquisaRecebimento[3, dtgPesquisaRecebimento.CurrentRow.Index].Value.ToString();
            parcela = dtgPesquisaRecebimento[4, dtgPesquisaRecebimento.CurrentRow.Index].Value.ToString(); 
            valor = dtgPesquisaRecebimento[5, dtgPesquisaRecebimento.CurrentRow.Index].Value.ToString();
            datavencimento = dtgPesquisaRecebimento[7, dtgPesquisaRecebimento.CurrentRow.Index].Value.ToString();
            valorEmAberto = dtgPesquisaRecebimento[10, dtgPesquisaRecebimento.CurrentRow.Index].Value.ToString();
            valorPago = dtgPesquisaRecebimento[11, dtgPesquisaRecebimento.CurrentRow.Index].Value.ToString();

            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            valorPago = "";
            valorEmAberto = "";
            valor = "";
            this.Close();
        }
    }
}

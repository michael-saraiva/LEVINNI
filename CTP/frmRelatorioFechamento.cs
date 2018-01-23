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
    public partial class frmRelatorioFechamento : Form
    {
        public frmRelatorioFechamento()
        {
            InitializeComponent();
        }

        decimal preco = 0;
        decimal quantidade = 0;
        decimal total = 0;

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string dataform = datavendas.Text;
            string dataform2 = dataVendas2.Text;
            dgvconsulta.DataSource = cons(dataform);
            dgvconsulta.DataSource = cons(dataform2);

            //atualiza grid
            dgvconsulta.Columns[0].HeaderText = "OPERADOR";
            dgvconsulta.Columns[0].Width = 60;
            dgvconsulta.Columns[1].HeaderText = "Á VISTA";
            dgvconsulta.Columns[1].Width = 80;
            dgvconsulta.Columns[2].HeaderText = "DÉBITO";
            dgvconsulta.Columns[2].Width = 90;
            dgvconsulta.Columns[3].HeaderText = "CRÉDITO";
            dgvconsulta.Columns[3].Width = 100;
            dgvconsulta.Columns[4].HeaderText = "CHEQUE";
            dgvconsulta.Columns[4].Width = 100;
            dgvconsulta.Columns[5].HeaderText = "ENTRADA";
            dgvconsulta.Columns[5].Width = 100;
            dgvconsulta.Columns[6].HeaderText = "PRAZO";
            dgvconsulta.Columns[6].Width = 100;
            dgvconsulta.Columns[7].HeaderText = "INICIAL";
            dgvconsulta.Columns[7].Width = 100;
            dgvconsulta.Columns[8].HeaderText = "TOTAL";
            dgvconsulta.Columns[8].Width = 100;
            dgvconsulta.Columns[9].HeaderText = "FINAL";
            dgvconsulta.Columns[9].Width = 100;
            dgvconsulta.Columns[10].HeaderText = "TIPO";
            dgvconsulta.Columns[10].Width = 80;
            dgvconsulta.Columns[11].HeaderText = "DATA";
            dgvconsulta.Columns[11].Width = 120;

            //Permisão da data Grid
            dgvconsulta.ReadOnly = true;
            dgvconsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvconsulta.AllowDrop = false;
            dgvconsulta.AllowUserToAddRows = false;
            dgvconsulta.AllowUserToDeleteRows = false;
            dgvconsulta.AllowUserToOrderColumns = false;
            dgvconsulta.AllowUserToResizeColumns = true;
            dgvconsulta.AllowUserToResizeRows = false;


            /*for (int i = 0; i < dgvconsulta.Rows.Count; i++)
            {
                preco = Convert.ToDecimal(dgvconsulta.Rows[i].Cells[8].Value);
                total = total + preco;
                //TbxReceita.Text = Convert.ToString(Decimal.Round(total));
                TbxReceita.Text = total.ToString("C");
            }*/

            btnPesquisar.Enabled = false;
        }

        private void frmRelatorioFechamento_Load(object sender, EventArgs e)
        {
            cbbCliente.SelectedIndex = -1;

            /*TbxReceita.Text = "0,00";
            total = Convert.ToDecimal(TbxReceita.Text);*/
        }

        #region Lista Venda
        public System.Data.DataTable cons(string data)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                //conexão
                con.ConnectionString = Dados.conexaoBancoDados;

                //command
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandType = CommandType.Text;

                if (cbbCliente.Text == "")
                {
                    da.SelectCommand.CommandText = "select operador, dinheiro, debito, credito, cheque, entrada, prazo, inicial, total, final, tipo, datadocadastro from movimentacao where datadocadastro >= @ven_data and datadocadastro <= @ven_data2";

                }

                else if (cbbCliente.Text.Length > 0)
                {
                    da.SelectCommand.CommandText = "select operador, dinheiro, debito, credito, cheque, entrada, prazo, inicial, total, final, tipo, datadocadastro from movimentacao where datadocadastro >= @ven_data and datadocadastro <= @ven_data2 and tipo = @c_codigo";
                }

                //parametros
                da.SelectCommand.Parameters.AddWithValue("@ven_data", datavendas.Text);
                da.SelectCommand.Parameters.AddWithValue("@ven_data2", dataVendas2.Text);
                da.SelectCommand.Parameters.AddWithValue("@c_codigo", cbbCliente.Text);


                //executar query
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAGEM", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("EXPORTAR PARA EXCEL ?", "MENSAGEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
            {
                if (dgvconsulta.Rows.Count == 0)
                {
                    MessageBox.Show("NÃO A DADOS PARA EXPORTAR", "ATENÇÃO");
                }
                else
                {
                    SaveFileDialog salvar = new SaveFileDialog(); // novo

                    Microsoft.Office.Interop.Excel.Application App; // Aplicação Excel
                    Microsoft.Office.Interop.Excel.Workbook WorkBook; // Pasta
                    Microsoft.Office.Interop.Excel.Worksheet WorkSheet; // Planilha
                    object misValue = System.Reflection.Missing.Value;

                    App = new Microsoft.Office.Interop.Excel.Application();
                    WorkBook = App.Workbooks.Add(misValue);
                    WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
                    int i = 0;
                    int j = 0;

                    /* passa as celulas do DataGridView para a Pasta do Excel
                    for (i = 0; i <= dgvconsulta.RowCount - 1; i++)
                    {
                

                        for (j = 0; j <= dgvconsulta.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dgvconsulta[j, i];
                            WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                        }
                    }*/

                    // passa as celulas do DataGridView para a Pasta do Excel
                    for (j = 0; j < dgvconsulta.ColumnCount; j++)
                    {
                        WorkSheet.Cells[1, j + 1] = dgvconsulta.Columns[j].HeaderText;
                    }
                    for (i = 1; i <= dgvconsulta.RowCount; i++)
                    {
                        for (j = 0; j < dgvconsulta.ColumnCount; j++)
                        {
                            DataGridViewCell cell = dgvconsulta[j, i - 1];
                            WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                        }
                    }

                    // define algumas propriedades da caixa salvar
                    salvar.Title = "Exportar para Excel";
                    salvar.Filter = "Arquivo do Excel *.xls | *.xls";
                    //salvar.ShowDialog(); // mostra

                    // salva o arquivo

                    if (salvar.ShowDialog(this) == DialogResult.OK)
                    {
                        WorkBook.SaveAs(salvar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                   Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                        WorkBook.Close(true, misValue, misValue);
                        App.Quit(); // encerra o excel

                        MessageBox.Show("EXPORTADO COM SUCESSO PARA EXCEL", "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        WorkBook.Close(false, misValue, misValue);
                        App.Quit(); // encerra o excel                
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            datavendas.ResetText();
            dataVendas2.ResetText();
            btnPesquisar.Enabled = true;
            dgvconsulta.Columns.Clear();
            cbbCliente.ResetText();
        }
    }
}

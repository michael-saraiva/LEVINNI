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
using System.Collections;

namespace LEVINNI
{
    public partial class frmReempressaoDeDocumento : Form
    {
        public frmReempressaoDeDocumento()
        {
            InitializeComponent();
        }

        int impVenda = 0;
        string impCliente = "", impVendedor = "", impCondicao = "", impProdutos = "", impEntrada = "", impDescV = "", impDescP = "", impSub = "", impTotal = "";

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ArrayList al = new ArrayList();
                    

        private void btnReempremir_Click(object sender, EventArgs e)
        {
            baixainformation x = new baixainformation();
            x.Codigo = Convert.ToInt32(txtNumVenda.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Dados.conexaoBancoDados;

            //command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select codigo from baixa where codigo = @NumVenda";

            //command
            SqlCommand cmdC = new SqlCommand();
            cmdC.Connection = con;
            cmdC.CommandType = CommandType.Text;
            cmdC.CommandText = "select nome from baixa where codigo = @NumVenda";

            //command
            SqlCommand cmdV = new SqlCommand();
            cmdV.Connection = con;
            cmdV.CommandType = CommandType.Text;
            cmdV.CommandText = "select operador from baixa where codigo = @NumVenda";

            //command
            SqlCommand cmdCD = new SqlCommand();
            cmdCD.Connection = con;
            cmdCD.CommandType = CommandType.Text;
            cmdCD.CommandText = "select condicao from baixa where codigo = @NumVenda";

            //command
            SqlCommand cmdE = new SqlCommand();
            cmdE.Connection = con;
            cmdE.CommandType = CommandType.Text;
            cmdE.CommandText = "select entrada from baixa where codigo = @NumVenda";

            //command
            SqlCommand cmdDV = new SqlCommand();
            cmdDV.Connection = con;
            cmdDV.CommandType = CommandType.Text;
            cmdDV.CommandText = "select descontoV from baixa where codigo = @NumVenda";

            //command
            SqlCommand cmdDP = new SqlCommand();
            cmdDP.Connection = con;
            cmdDP.CommandType = CommandType.Text;
            cmdDP.CommandText = "select descontoP from baixa where codigo = @NumVenda";

            //command
            SqlCommand cmdSB = new SqlCommand();
            cmdSB.Connection = con;
            cmdSB.CommandType = CommandType.Text;
            cmdSB.CommandText = "select subtotal from baixa where codigo = @NumVenda";

            //command
            SqlCommand cmdTO = new SqlCommand();
            cmdTO.Connection = con;
            cmdTO.CommandType = CommandType.Text;
            cmdTO.CommandText = "select preco from baixa where codigo = @NumVenda";

            /*command
            SqlCommand cmdP = new SqlCommand();
            cmdP.Connection = con;
            cmdP.CommandType = CommandType.Text;
            cmdP.CommandText = "select p.descricao, e.estoque_qtd from baixa as b inner join Estoque as e on b.codigo = e.baixa_codigo inner join produto as p on e.produto_codigo = p.codigo where e.baixa_codigo = @NumVenda";            
             */
          
            //parametros
            cmd.Parameters.AddWithValue("@NumVenda", x.Codigo);
            cmdC.Parameters.AddWithValue("@NumVenda", x.Codigo);
            cmdV.Parameters.AddWithValue("@NumVenda", x.Codigo);
            cmdCD.Parameters.AddWithValue("@NumVenda", x.Codigo);
            cmdE.Parameters.AddWithValue("@NumVenda", x.Codigo);
            cmdDV.Parameters.AddWithValue("@NumVenda", x.Codigo);
            cmdDP.Parameters.AddWithValue("@NumVenda", x.Codigo);
            cmdSB.Parameters.AddWithValue("@NumVenda", x.Codigo);
            cmdTO.Parameters.AddWithValue("@NumVenda", x.Codigo);

            // Abrir conexão com o Banco de Dados
            con.Open();
            

            //executar query
            cmd.ExecuteNonQuery();
            cmdC.ExecuteNonQuery();
            cmdV.ExecuteNonQuery();
            cmdCD.ExecuteNonQuery();
            cmdE.ExecuteNonQuery();
            cmdDP.ExecuteNonQuery();
            cmdDV.ExecuteNonQuery();
            cmdSB.ExecuteNonQuery();
            cmdTO.ExecuteNonQuery();

            if (cmd.ExecuteScalar() == null)
            {
                MessageBox.Show("DOCUMENTO NÃO ENCONTRADO", "ATENÇÃO");
            }
            else
            {
                impVenda = Convert.ToInt32(cmd.ExecuteScalar());
                impCliente = Convert.ToString(cmdC.ExecuteScalar());
                impVendedor = Convert.ToString(cmdV.ExecuteScalar());
                impCondicao = Convert.ToString(cmdCD.ExecuteScalar());
                impEntrada = Convert.ToString(cmdE.ExecuteScalar());
                impDescV = Convert.ToString(cmdDV.ExecuteScalar());
                impDescP = Convert.ToString(cmdDP.ExecuteScalar());
                impSub = Convert.ToString(cmdSB.ExecuteScalar());
                impTotal = Convert.ToString(cmdTO.ExecuteScalar());
                
                if (MessageBox.Show("DESEJA IMPRIMIR O DOCUMENTO: Nº" + " " + txtNumVenda.Text, "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    printPreviewDialog1.ShowDialog();
                }
            }
            con.Close();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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

            baixainformation x = new baixainformation();
            x.Codigo = Convert.ToInt32(txtNumVenda.Text);

            // Conexão
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Dados.conexaoBancoDados;

            // Command
            SqlCommand cmdP = new SqlCommand();
            cmdP.Connection = con;
            cmdP.CommandType = CommandType.Text;
            cmdP.CommandText = "select p.descricao, e.estoque_qtd, e.preco from baixa as b inner join Estoque as e on b.codigo = e.baixa_codigo inner join produto as p on e.produto_codigo = p.codigo where e.baixa_codigo = @NumVenda";

            // Command
            SqlCommand cmdPAR = new SqlCommand();
            cmdPAR.Connection = con;
            cmdPAR.CommandType = CommandType.Text;
            cmdPAR.CommandText = "select c.datavencimento, c.valor from contasareceber as c where c.ficha = @NumVenda";

            cmdP.Parameters.AddWithValue("@NumVenda", x.Codigo);
            cmdPAR.Parameters.AddWithValue("@NumVenda", x.Codigo);

            // Abrir conexão
            con.Open();
            
            // Produtos
            SqlDataReader dr = cmdP.ExecuteReader();

            while (dr.Read())
            {
                object[] values = new object[dr.FieldCount];
                dr.GetValues(values);
                al.Add(values);
                
                e.Graphics.DrawString(values[0].ToString(), fonte2, Brushes.Black, 20, altura);
                e.Graphics.DrawString(values[1].ToString(), fonte2, Brushes.Black, 320, altura);
                e.Graphics.DrawString(values[2].ToString(), fonte2, Brushes.Black, 540, altura);
                altura += 10;
            }

            dr.Dispose();

            //Verifica quantos items foi vendido e imprimi na folha
            /*for (int i = 0; i < listavenda.Items.Count; i++)
            {
                e.Graphics.DrawString(listavenda.Items[i].SubItems[0].Text, fonte2, Brushes.Black, 20, altura);
                e.Graphics.DrawString(listavenda.Items[i].SubItems[2].Text, fonte2, Brushes.Black, 320, altura);
                e.Graphics.DrawString(listavenda.Items[i].SubItems[3].Text, fonte2, Brushes.Black, 540, altura);
                altura = altura + 10;
            }*/
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

            // Vencimentos
            SqlDataReader parc = cmdPAR.ExecuteReader();

            while (parc.Read())
            {
                object[] values = new object[parc.FieldCount];
                parc.GetValues(values);
                al.Add(values);

                DateTime data;
                data = Convert.ToDateTime(values[0].ToString());
                e.Graphics.DrawString(data.ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                e.Graphics.DrawString("R$ " + values[1].ToString(), fonte2, Brushes.Black, 100, altura);
                altura += 20;
            }

            
            /*decimal to;
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
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * pa).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 4:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * pa).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 5:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * pa).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 6:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * pa).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 7:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * pa).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 8:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * pa).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 9:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * pa).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 10:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * pa).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 11:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * pa).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                        case 12:
                            e.Graphics.DrawString(vencimento.AddDays(intervalo * pa).ToShortDateString(), fonte2, Brushes.Black, 20, altura);
                            e.Graphics.DrawString(to.ToString("C"), fonte2, Brushes.Black, 100, altura);
                            break;
                    }

                    pa--;
                    saldo = saldo - to;
                    altura = altura + 20;
                }
            }*/

            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fonte2, Brushes.Black, 20, 1090);
            e.Graphics.DrawString("SCION TECHNOLOGY® - www.sciontech.com.br", fonte2, Brushes.Black, 20, 1110);
        }
    }
}

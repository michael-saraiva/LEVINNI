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
    public partial class frmCancelamento : Form
    {
        int canVenda = 0;
        public string operador;

        public frmCancelamento()
        {            
            InitializeComponent();          
    }

        #region Botão Cancelar Documento
        private void btnCancelarDocumento_Click(object sender, EventArgs e)
        {
            
            if (txtNumeroDocumento.Text.Length > 0 && txtMotivo.Text.Length > 0)
            {
                baixainformation x = new baixainformation();
                x.Codigo = Convert.ToInt32(txtNumeroDocumento.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Dados.conexaoBancoDados;

                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select codigo from baixa where codigo = @NumVenda";

                //parametros
                cmd.Parameters.AddWithValue("@NumVenda", x.Codigo);

                // Abrir conexão com o Banco de Dados
                con.Open();

                //executar query
                cmd.ExecuteNonQuery();

                if (cmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("DOCUMENTO NÃO ENCONTRADO", "ATENÇÃO");
                }

                else if (cmd.ExecuteScalar() != null)
                {
                    cancelamentoInformation z = new cancelamentoInformation();
                    z.Documento = Convert.ToInt32(txtNumeroDocumento.Text);

                    //SqlConnection cone = new SqlConnection();
                    //cone.ConnectionString = Dados.conexaoBancoDados;

                    //command
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = con;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "select documento from cancelamento where documento = @cancelamento";

                    //parametros
                    comm.Parameters.AddWithValue("@cancelamento", z.Documento);

                    // Abrir conexão com o Banco de Dados
                    //con.Open();

                    //executar query
                    comm.ExecuteNonQuery();

                    if (comm.ExecuteScalar() == null)
                    {
                        canVenda = Convert.ToInt32(cmd.ExecuteScalar());

                        if (MessageBox.Show("DESEJA CANCELAR O DOCUMENTO: Nº" + " " + canVenda, "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                        {
                            cancelamentoInformation can = new cancelamentoInformation();
                            can.Documento = canVenda;
                            can.Data = System.DateTime.Now;
                            can.Motivo = txtMotivo.Text;
                            can.Operador = operador;

                            //command
                            SqlCommand cmdC = new SqlCommand();
                            cmdC.Connection = con;
                            cmdC.CommandType = CommandType.Text;
                            cmdC.CommandText = "insert into cancelamento (documento, operador, data, motivo) values (@documento, @operador, @data, @motivo)";

                            //PARAMETROS alterar
                            cmdC.Parameters.AddWithValue("@documento", can.Documento);
                            cmdC.Parameters.AddWithValue("@operador", can.Operador);
                            cmdC.Parameters.AddWithValue("@data", can.Data);
                            cmdC.Parameters.AddWithValue("@motivo", can.Motivo);

                            //command
                            SqlCommand cmdUP = new SqlCommand();
                            cmdUP.Connection = con;
                            cmdUP.CommandType = CommandType.Text;
                            cmdUP.CommandText = "update baixa set cancelado = 'S' where codigo = @UPdocumento";

                            //PARAMETROS alterar baixa
                            cmdUP.Parameters.AddWithValue("@UPdocumento", can.Documento);

                            //Executar Query
                            cmdC.ExecuteNonQuery();
                            cmdUP.ExecuteNonQuery();

                            MessageBox.Show("CANCELADO COM SUCESSO!", "ATENÇÃO");
                        }
                    }
                    else
                    {
                        MessageBox.Show("DOCUMENTO JÁ CANCELADO!", "ATENÇÃO");
                    }
                }
                else
                {
                    MessageBox.Show("ERRO", "ATENÇÃO");

                }
            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS!", "ATENÇÃO");

            }
            
        }
        #endregion

        #region Load
        private void frmCancelamento_Load(object sender, EventArgs e)
        {            
        }
        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA RETORNAR AO MENU ?", "MENSAGEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
            {
                this.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CTP;

namespace LEVINNI
{
    public partial class frmFinanceiro : Form
    {
        public frmFinanceiro()
        {
            InitializeComponent();
        }

        #region Botão Confirma
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (rdbCadastro.Checked)
            {
                frmContasaReceber frmContasaReceber = new frmContasaReceber();
                frmContasaReceber.ShowDialog();                
            }
            else if(rdbRecebimento.Checked)
            {
                frmReceber recebimento = new frmReceber();
                recebimento.ShowDialog();                
            }
            else
            {
                MessageBox.Show("ESCOLHA UMA OPÇÃO","ATENÇÃO");
            }
            this.Close();
        }
        #endregion
    }
}

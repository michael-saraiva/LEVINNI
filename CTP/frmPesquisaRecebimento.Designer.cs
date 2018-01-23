namespace LEVINNI
{
    partial class frmPesquisaRecebimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgPesquisaRecebimento = new System.Windows.Forms.DataGridView();
            this.txtfiltroFicha = new System.Windows.Forms.TextBox();
            this.txtfiltroCliente = new System.Windows.Forms.TextBox();
            this.lblFicha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaRecebimento)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPesquisaRecebimento
            // 
            this.dtgPesquisaRecebimento.BackgroundColor = System.Drawing.Color.White;
            this.dtgPesquisaRecebimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisaRecebimento.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgPesquisaRecebimento.Location = new System.Drawing.Point(12, 64);
            this.dtgPesquisaRecebimento.Name = "dtgPesquisaRecebimento";
            this.dtgPesquisaRecebimento.Size = new System.Drawing.Size(1150, 397);
            this.dtgPesquisaRecebimento.TabIndex = 0;
            this.dtgPesquisaRecebimento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisaRecebimento_CellClick);
            // 
            // txtfiltroFicha
            // 
            this.txtfiltroFicha.Location = new System.Drawing.Point(73, 6);
            this.txtfiltroFicha.Name = "txtfiltroFicha";
            this.txtfiltroFicha.Size = new System.Drawing.Size(86, 20);
            this.txtfiltroFicha.TabIndex = 1;
            this.txtfiltroFicha.TextChanged += new System.EventHandler(this.txtfiltroFicha_TextChanged);
            // 
            // txtfiltroCliente
            // 
            this.txtfiltroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfiltroCliente.Location = new System.Drawing.Point(73, 32);
            this.txtfiltroCliente.Name = "txtfiltroCliente";
            this.txtfiltroCliente.Size = new System.Drawing.Size(245, 20);
            this.txtfiltroCliente.TabIndex = 2;
            this.txtfiltroCliente.TextChanged += new System.EventHandler(this.txtfiltroCliente_TextChanged);
            // 
            // lblFicha
            // 
            this.lblFicha.AutoSize = true;
            this.lblFicha.Location = new System.Drawing.Point(12, 9);
            this.lblFicha.Name = "lblFicha";
            this.lblFicha.Size = new System.Drawing.Size(41, 13);
            this.lblFicha.TabIndex = 3;
            this.lblFicha.Text = "&FICHA:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 35);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "&CLIENTE:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(348, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 46);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&VOLTAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPesquisaRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 471);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFicha);
            this.Controls.Add(this.txtfiltroCliente);
            this.Controls.Add(this.txtfiltroFicha);
            this.Controls.Add(this.dtgPesquisaRecebimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaRecebimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUPLICATAS";
            this.Load += new System.EventHandler(this.frmPesquisaRecebimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaRecebimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPesquisaRecebimento;
        private System.Windows.Forms.TextBox txtfiltroFicha;
        private System.Windows.Forms.TextBox txtfiltroCliente;
        private System.Windows.Forms.Label lblFicha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnCancelar;
    }
}
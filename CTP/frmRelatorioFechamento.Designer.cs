namespace LEVINNI
{
    partial class frmRelatorioFechamento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.datavendas = new System.Windows.Forms.DateTimePicker();
            this.lbldata = new System.Windows.Forms.Label();
            this.dataVendas2 = new System.Windows.Forms.DateTimePicker();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.datavendas);
            this.panel1.Controls.Add(this.lbldata);
            this.panel1.Controls.Add(this.dataVendas2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 85);
            this.panel1.TabIndex = 65;
            // 
            // datavendas
            // 
            this.datavendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datavendas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datavendas.Location = new System.Drawing.Point(56, 17);
            this.datavendas.Name = "datavendas";
            this.datavendas.Size = new System.Drawing.Size(110, 20);
            this.datavendas.TabIndex = 28;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(6, 36);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(44, 13);
            this.lbldata.TabIndex = 27;
            this.lbldata.Text = "DATA:";
            // 
            // dataVendas2
            // 
            this.dataVendas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVendas2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVendas2.Location = new System.Drawing.Point(56, 46);
            this.dataVendas2.Name = "dataVendas2";
            this.dataVendas2.Size = new System.Drawing.Size(110, 20);
            this.dataVendas2.TabIndex = 33;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(414, 148);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 23);
            this.btnVoltar.TabIndex = 64;
            this.btnVoltar.Text = "&VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(280, 148);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(86, 23);
            this.btnExportarExcel.TabIndex = 61;
            this.btnExportarExcel.Text = "&EXCEL";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(146, 148);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 23);
            this.btnLimpar.TabIndex = 60;
            this.btnLimpar.Text = "&CANCELAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(12, 177);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(988, 203);
            this.dgvconsulta.TabIndex = 59;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(12, 148);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(86, 23);
            this.btnPesquisar.TabIndex = 58;
            this.btnPesquisar.Text = "&PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbbCliente
            // 
            this.cbbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Items.AddRange(new object[] {
            "A",
            "F"});
            this.cbbCliente.Location = new System.Drawing.Point(50, 104);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(63, 21);
            this.cbbCliente.TabIndex = 57;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(9, 107);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(35, 13);
            this.lblCliente.TabIndex = 56;
            this.lblCliente.Text = "TIPO:";
            // 
            // frmRelatorioFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 396);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvconsulta);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbbCliente);
            this.Controls.Add(this.lblCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRelatorioFechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO CAIXA";
            this.Load += new System.EventHandler(this.frmRelatorioFechamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datavendas;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.DateTimePicker dataVendas2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label lblCliente;

    }
}
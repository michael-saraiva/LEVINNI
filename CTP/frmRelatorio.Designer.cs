﻿namespace CTP
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.datavendas = new System.Windows.Forms.DateTimePicker();
            this.lbldata = new System.Windows.Forms.Label();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataVendas2 = new System.Windows.Forms.DateTimePicker();
            this.cbbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.TbxReceita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(12, 161);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(86, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "&PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(12, 194);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(1187, 300);
            this.dgvconsulta.TabIndex = 5;
            // 
            // datavendas
            // 
            this.datavendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datavendas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datavendas.Location = new System.Drawing.Point(53, 13);
            this.datavendas.Name = "datavendas";
            this.datavendas.Size = new System.Drawing.Size(110, 20);
            this.datavendas.TabIndex = 7;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(3, 30);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(44, 13);
            this.lbldata.TabIndex = 6;
            this.lbldata.Text = "DATA:";
            // 
            // cbbCliente
            // 
            this.cbbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(86, 101);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(232, 21);
            this.cbbCliente.TabIndex = 23;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(16, 104);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 13);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LEVINNI.Properties.Resources.LUPA;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(333, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataVendas2
            // 
            this.dataVendas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVendas2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVendas2.Location = new System.Drawing.Point(53, 42);
            this.dataVendas2.Name = "dataVendas2";
            this.dataVendas2.Size = new System.Drawing.Size(110, 20);
            this.dataVendas2.TabIndex = 26;
            // 
            // cbbProduto
            // 
            this.cbbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbProduto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbProduto.FormattingEnabled = true;
            this.cbbProduto.Location = new System.Drawing.Point(86, 129);
            this.cbbProduto.Name = "cbbProduto";
            this.cbbProduto.Size = new System.Drawing.Size(232, 21);
            this.cbbProduto.TabIndex = 29;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(16, 132);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(64, 13);
            this.lblProduto.TabIndex = 28;
            this.lblProduto.Text = "PRODUTO:";
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackgroundImage = global::LEVINNI.Properties.Resources.LUPA;
            this.btnPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(333, 129);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(28, 23);
            this.btnPesquisarProduto.TabIndex = 27;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // TbxReceita
            // 
            this.TbxReceita.Location = new System.Drawing.Point(592, 168);
            this.TbxReceita.Name = "TbxReceita";
            this.TbxReceita.Size = new System.Drawing.Size(100, 20);
            this.TbxReceita.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "TOTAL:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(133, 161);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 23);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "&CANCELAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(254, 161);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(86, 23);
            this.btnExportarExcel.TabIndex = 34;
            this.btnExportarExcel.Text = "&EXCEL";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.datavendas);
            this.panel1.Controls.Add(this.dataVendas2);
            this.panel1.Controls.Add(this.lbldata);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 77);
            this.panel1.TabIndex = 35;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(375, 161);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 23);
            this.btnVoltar.TabIndex = 36;
            this.btnVoltar.Text = "&VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 506);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxReceita);
            this.Controls.Add(this.cbbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.cbbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvconsulta);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DE VENDAS";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.DateTimePicker datavendas;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dataVendas2;
        private System.Windows.Forms.ComboBox cbbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.TextBox TbxReceita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
    }
}
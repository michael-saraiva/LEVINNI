namespace CTP
{
    partial class frmOrcamento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamento));
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.cbbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.listavenda = new System.Windows.Forms.ListView();
            this.txtcancelar = new System.Windows.Forms.Button();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.txtquantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParcela = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVendedorVenda = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.lblCondicao = new System.Windows.Forms.Label();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbCondicao = new System.Windows.Forms.ComboBox();
            this.lblDescontoValor = new System.Windows.Forms.Label();
            this.txtDescontoValor = new System.Windows.Forms.TextBox();
            this.txtDescontoPorcentagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtSubT = new System.Windows.Forms.TextBox();
            this.btnFechamento = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.btnRecebimento = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.txtSaldoEtq = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReimpressão = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(8, 13);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(67, 16);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // cbbCliente
            // 
            this.cbbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(101, 5);
            this.cbbCliente.MaxLength = 49;
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(226, 28);
            this.cbbCliente.TabIndex = 1;
            this.cbbCliente.SelectedIndexChanged += new System.EventHandler(this.cbbCliente_SelectedIndexChanged);
            // 
            // cbbProduto
            // 
            this.cbbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProduto.FormattingEnabled = true;
            this.cbbProduto.Location = new System.Drawing.Point(118, 69);
            this.cbbProduto.Name = "cbbProduto";
            this.cbbProduto.Size = new System.Drawing.Size(278, 32);
            this.cbbProduto.TabIndex = 6;
            this.cbbProduto.SelectedIndexChanged += new System.EventHandler(this.cbbProduto_SelectedIndexChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(12, 77);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(79, 16);
            this.lblProduto.TabIndex = 5;
            this.lblProduto.Text = "PRODUTO:";
            // 
            // listavenda
            // 
            this.listavenda.BackColor = System.Drawing.Color.White;
            this.listavenda.FullRowSelect = true;
            this.listavenda.Location = new System.Drawing.Point(15, 270);
            this.listavenda.Name = "listavenda";
            this.listavenda.Size = new System.Drawing.Size(424, 146);
            this.listavenda.TabIndex = 24;
            this.listavenda.UseCompatibleStateImageBehavior = false;
            // 
            // txtcancelar
            // 
            this.txtcancelar.BackColor = System.Drawing.Color.Firebrick;
            this.txtcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcancelar.ForeColor = System.Drawing.Color.White;
            this.txtcancelar.Location = new System.Drawing.Point(17, 227);
            this.txtcancelar.Name = "txtcancelar";
            this.txtcancelar.Size = new System.Drawing.Size(265, 36);
            this.txtcancelar.TabIndex = 16;
            this.txtcancelar.Text = "&CANCELAR";
            this.txtcancelar.UseVisualStyleBackColor = false;
            this.txtcancelar.Click += new System.EventHandler(this.txtcancelar_Click);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.ForeColor = System.Drawing.Color.White;
            this.btnfinalizar.Location = new System.Drawing.Point(17, 154);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(265, 67);
            this.btnfinalizar.TabIndex = 15;
            this.btnfinalizar.Text = "&FINALIZAR";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.Firebrick;
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.ForeColor = System.Drawing.Color.White;
            this.btnremover.Location = new System.Drawing.Point(340, 224);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(98, 38);
            this.btnremover.TabIndex = 10;
            this.btnremover.Text = "REMOVER";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnadicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionar.ForeColor = System.Drawing.Color.White;
            this.btnadicionar.Location = new System.Drawing.Point(15, 224);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(319, 38);
            this.btnadicionar.TabIndex = 9;
            this.btnadicionar.Text = "ADICIONAR PRODUTO";
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // txtquantidade
            // 
            this.txtquantidade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtquantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidade.Location = new System.Drawing.Point(118, 143);
            this.txtquantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(320, 29);
            this.txtquantidade.TabIndex = 7;
            this.txtquantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantidade.ThousandsSeparator = true;
            this.txtquantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "QUANTIDADE:";
            // 
            // dtpdata
            // 
            this.dtpdata.Enabled = false;
            this.dtpdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdata.Location = new System.Drawing.Point(845, 12);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(131, 26);
            this.dtpdata.TabIndex = 31;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(118, 481);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(76, 20);
            this.txtcodigo.TabIndex = 33;
            this.txtcodigo.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(997, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(89, 26);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = "VOLTAR";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNomeArquivo.Location = new System.Drawing.Point(12, 456);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(103, 15);
            this.lblNomeArquivo.TabIndex = 35;
            this.lblNomeArquivo.Text = "Nome do Arquivo";
            this.lblNomeArquivo.Visible = false;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(118, 455);
            this.txtNomeArquivo.MaxLength = 49;
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(189, 20);
            this.txtNomeArquivo.TabIndex = 39;
            this.txtNomeArquivo.Visible = false;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCredito.ForeColor = System.Drawing.Color.White;
            this.lblCredito.Location = new System.Drawing.Point(3, 10);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(86, 15);
            this.lblCredito.TabIndex = 40;
            this.lblCredito.Text = "LIM. CRÉDITO:";
            // 
            // txtCredito
            // 
            this.txtCredito.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCredito.Enabled = false;
            this.txtCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.Location = new System.Drawing.Point(102, 5);
            this.txtCredito.MaxLength = 9;
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(207, 26);
            this.txtCredito.TabIndex = 41;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(17, 104);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(265, 44);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(13, 77);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(195, 24);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "TOTAL DO PEDIDO";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(118, 182);
            this.txtPreco.MaxLength = 49;
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(320, 29);
            this.txtPreco.TabIndex = 8;
            this.txtPreco.Text = "0,00";
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(12, 192);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(58, 16);
            this.lblPreco.TabIndex = 44;
            this.lblPreco.Text = "PREÇO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "PARCELAS:";
            // 
            // txtParcela
            // 
            this.txtParcela.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtParcela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcela.Location = new System.Drawing.Point(128, 38);
            this.txtParcela.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtParcela.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(238, 26);
            this.txtParcela.TabIndex = 3;
            this.txtParcela.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblVendedorVenda);
            this.panel1.Controls.Add(this.cbbCliente);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblVendedor);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(457, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 72);
            this.panel1.TabIndex = 48;
            // 
            // lblVendedorVenda
            // 
            this.lblVendedorVenda.AutoSize = true;
            this.lblVendedorVenda.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorVenda.ForeColor = System.Drawing.Color.White;
            this.lblVendedorVenda.Location = new System.Drawing.Point(103, 36);
            this.lblVendedorVenda.Name = "lblVendedorVenda";
            this.lblVendedorVenda.Size = new System.Drawing.Size(0, 27);
            this.lblVendedorVenda.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LEVINNI.Properties.Resources.LUPA;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(333, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 28);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.White;
            this.lblVendedor.Location = new System.Drawing.Point(9, 42);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(88, 16);
            this.lblVendedor.TabIndex = 6;
            this.lblVendedor.Text = "VENDEDOR:";
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervalo.Location = new System.Drawing.Point(320, 72);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(46, 26);
            this.txtIntervalo.TabIndex = 5;
            this.txtIntervalo.Text = "0";
            this.txtIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalo.Location = new System.Drawing.Point(257, 78);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(57, 16);
            this.lblIntervalo.TabIndex = 165;
            this.lblIntervalo.Text = "PRAZO:";
            // 
            // lblCondicao
            // 
            this.lblCondicao.AutoSize = true;
            this.lblCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicao.Location = new System.Drawing.Point(7, 13);
            this.lblCondicao.Name = "lblCondicao";
            this.lblCondicao.Size = new System.Drawing.Size(94, 16);
            this.lblCondicao.TabIndex = 50;
            this.lblCondicao.Text = "COND. PGTO:";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(128, 72);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(118, 26);
            this.dtpVencimento.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 163;
            this.label8.Text = "1º VENCIMENTO:";
            // 
            // cbbCondicao
            // 
            this.cbbCondicao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbCondicao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCondicao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCondicao.FormattingEnabled = true;
            this.cbbCondicao.Items.AddRange(new object[] {
            "Á VISTA",
            "CARTÃO DE DÉBITO",
            "CARTÃO DE CRÉDITO",
            "CHEQUE",
            "PRAZO"});
            this.cbbCondicao.Location = new System.Drawing.Point(128, 4);
            this.cbbCondicao.Name = "cbbCondicao";
            this.cbbCondicao.Size = new System.Drawing.Size(238, 28);
            this.cbbCondicao.TabIndex = 2;
            this.cbbCondicao.SelectedIndexChanged += new System.EventHandler(this.cbbCondicao_SelectedIndexChanged);
            // 
            // lblDescontoValor
            // 
            this.lblDescontoValor.AutoSize = true;
            this.lblDescontoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoValor.Location = new System.Drawing.Point(10, 147);
            this.lblDescontoValor.Name = "lblDescontoValor";
            this.lblDescontoValor.Size = new System.Drawing.Size(84, 16);
            this.lblDescontoValor.TabIndex = 50;
            this.lblDescontoValor.Text = "DESCONTO";
            // 
            // txtDescontoValor
            // 
            this.txtDescontoValor.BackColor = System.Drawing.Color.White;
            this.txtDescontoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescontoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoValor.Location = new System.Drawing.Point(128, 142);
            this.txtDescontoValor.Name = "txtDescontoValor";
            this.txtDescontoValor.Size = new System.Drawing.Size(84, 26);
            this.txtDescontoValor.TabIndex = 12;
            this.txtDescontoValor.Text = "0,00";
            this.txtDescontoValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescontoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontoValor_KeyPress);
            // 
            // txtDescontoPorcentagem
            // 
            this.txtDescontoPorcentagem.BackColor = System.Drawing.Color.White;
            this.txtDescontoPorcentagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescontoPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoPorcentagem.Location = new System.Drawing.Point(260, 142);
            this.txtDescontoPorcentagem.MaxLength = 5;
            this.txtDescontoPorcentagem.Name = "txtDescontoPorcentagem";
            this.txtDescontoPorcentagem.Size = new System.Drawing.Size(52, 26);
            this.txtDescontoPorcentagem.TabIndex = 13;
            this.txtDescontoPorcentagem.Text = "0";
            this.txtDescontoPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescontoPorcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontoPorcentagem_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "ENTRADA";
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.Color.White;
            this.txtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(128, 107);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(84, 26);
            this.txtEntrada.TabIndex = 11;
            this.txtEntrada.Text = "0,00";
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            this.txtEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntrada_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(10, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "CALCULAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal.Location = new System.Drawing.Point(13, 13);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(106, 20);
            this.lblSubTotal.TabIndex = 59;
            this.lblSubTotal.Text = "SUB TOTAL";
            // 
            // txtSubT
            // 
            this.txtSubT.BackColor = System.Drawing.Color.White;
            this.txtSubT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubT.Enabled = false;
            this.txtSubT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubT.Location = new System.Drawing.Point(17, 36);
            this.txtSubT.Name = "txtSubT";
            this.txtSubT.ReadOnly = true;
            this.txtSubT.Size = new System.Drawing.Size(149, 29);
            this.txtSubT.TabIndex = 18;
            this.txtSubT.Text = "0,00";
            this.txtSubT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFechamento
            // 
            this.btnFechamento.BackColor = System.Drawing.Color.Firebrick;
            this.btnFechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechamento.ForeColor = System.Drawing.Color.White;
            this.btnFechamento.Location = new System.Drawing.Point(340, 8);
            this.btnFechamento.Name = "btnFechamento";
            this.btnFechamento.Size = new System.Drawing.Size(99, 40);
            this.btnFechamento.TabIndex = 61;
            this.btnFechamento.Text = "FECHAR CAIXA";
            this.btnFechamento.UseVisualStyleBackColor = false;
            this.btnFechamento.Click += new System.EventHandler(this.btnFechamento_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaixa.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(244, 8);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(90, 40);
            this.btnAbrirCaixa.TabIndex = 62;
            this.btnAbrirCaixa.Text = "ABRIR CAIXA";
            this.btnAbrirCaixa.UseVisualStyleBackColor = false;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(11, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(108, 24);
            this.lblStatus.TabIndex = 63;
            this.lblStatus.Text = "STATUS...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.btnAbrirCaixa);
            this.panel2.Controls.Add(this.btnFechamento);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.dtpdata);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 60);
            this.panel2.TabIndex = 166;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(1173, 17);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 20);
            this.lblHora.TabIndex = 172;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(457, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 45);
            this.panel3.TabIndex = 167;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(48, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(289, 24);
            this.label10.TabIndex = 169;
            this.label10.Text = "CONDIÇÃO DE PAGAMENTO";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblCondicao);
            this.panel4.Controls.Add(this.txtParcela);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtIntervalo);
            this.panel4.Controls.Add(this.cbbCondicao);
            this.panel4.Controls.Add(this.lblIntervalo);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.txtEntrada);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dtpVencimento);
            this.panel4.Controls.Add(this.lblDescontoValor);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtDescontoValor);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtDescontoPorcentagem);
            this.panel4.Location = new System.Drawing.Point(457, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 225);
            this.panel4.TabIndex = 168;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.lblSubTotal);
            this.panel5.Controls.Add(this.txtSubT);
            this.panel5.Controls.Add(this.lblTotal);
            this.panel5.Controls.Add(this.txtTotal);
            this.panel5.Controls.Add(this.btnfinalizar);
            this.panel5.Controls.Add(this.txtcancelar);
            this.panel5.Location = new System.Drawing.Point(845, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(312, 266);
            this.panel5.TabIndex = 169;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 602);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1264, 139);
            this.panel6.TabIndex = 170;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(579, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 42);
            this.label7.TabIndex = 0;
            this.label7.Text = "LEVINNI";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackgroundImage = global::LEVINNI.Properties.Resources.LUPA;
            this.btnPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(402, 68);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(36, 33);
            this.btnPesquisarProduto.TabIndex = 4;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // btnRecebimento
            // 
            this.btnRecebimento.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecebimento.ForeColor = System.Drawing.Color.White;
            this.btnRecebimento.Location = new System.Drawing.Point(845, 107);
            this.btnRecebimento.Name = "btnRecebimento";
            this.btnRecebimento.Size = new System.Drawing.Size(312, 36);
            this.btnRecebimento.TabIndex = 166;
            this.btnRecebimento.Text = "RECEBIMENTO";
            this.btnRecebimento.UseVisualStyleBackColor = false;
            this.btnRecebimento.Click += new System.EventHandler(this.btnRecebimento_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.Controls.Add(this.lblCredito);
            this.panel7.Controls.Add(this.txtCredito);
            this.panel7.Location = new System.Drawing.Point(845, 68);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(312, 34);
            this.panel7.TabIndex = 171;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // txtSaldoEtq
            // 
            this.txtSaldoEtq.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSaldoEtq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoEtq.Enabled = false;
            this.txtSaldoEtq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoEtq.Location = new System.Drawing.Point(118, 107);
            this.txtSaldoEtq.MaxLength = 49;
            this.txtSaldoEtq.Multiline = true;
            this.txtSaldoEtq.Name = "txtSaldoEtq";
            this.txtSaldoEtq.Size = new System.Drawing.Size(54, 29);
            this.txtSaldoEtq.TabIndex = 172;
            this.txtSaldoEtq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 173;
            this.label9.Text = "ESTOQUE:";
            // 
            // btnReimpressão
            // 
            this.btnReimpressão.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReimpressão.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimpressão.ForeColor = System.Drawing.Color.White;
            this.btnReimpressão.Location = new System.Drawing.Point(1163, 150);
            this.btnReimpressão.Name = "btnReimpressão";
            this.btnReimpressão.Size = new System.Drawing.Size(101, 40);
            this.btnReimpressão.TabIndex = 173;
            this.btnReimpressão.Text = "REIMPRIMIR";
            this.btnReimpressão.UseVisualStyleBackColor = false;
            this.btnReimpressão.Click += new System.EventHandler(this.btnReimpressão_Click);
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btnReimpressão);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSaldoEtq);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnRecebimento);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.listavenda);
            this.Controls.Add(this.cbbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnPesquisarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAIXA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtquantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.ComboBox cbbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.ListView listavenda;
        private System.Windows.Forms.Button txtcancelar;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.NumericUpDown txtquantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtParcela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVendedorVenda;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cbbCondicao;
        private System.Windows.Forms.Label lblCondicao;
        private System.Windows.Forms.Label lblDescontoValor;
        private System.Windows.Forms.TextBox txtDescontoValor;
        private System.Windows.Forms.TextBox txtDescontoPorcentagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtSubT;
        private System.Windows.Forms.Button btnFechamento;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRecebimento;
        private System.Windows.Forms.Panel panel7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox txtSaldoEtq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReimpressão;
    }
}
namespace CTP
{
    partial class frmEntrada
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
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.listaentrada = new System.Windows.Forms.ListView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtcodigopro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datacadastro = new System.Windows.Forms.DateTimePicker();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.lblestoque = new System.Windows.Forms.Label();
            this.lbldatacadastro = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpatela = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtNFe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.Location = new System.Drawing.Point(284, 409);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(86, 38);
            this.btnfinalizar.TabIndex = 8;
            this.btnfinalizar.Text = "&FINALIZAR";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // listaentrada
            // 
            this.listaentrada.BackColor = System.Drawing.Color.White;
            this.listaentrada.FullRowSelect = true;
            this.listaentrada.Location = new System.Drawing.Point(22, 152);
            this.listaentrada.Name = "listaentrada";
            this.listaentrada.Size = new System.Drawing.Size(722, 248);
            this.listaentrada.TabIndex = 119;
            this.listaentrada.UseCompatibleStateImageBehavior = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.BackgroundImage = global::LEVINNI.Properties.Resources.LUPA;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Crimson;
            this.btnPesquisar.Location = new System.Drawing.Point(583, 47);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(27, 20);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Tag = "2";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtcodigopro
            // 
            this.txtcodigopro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigopro.Enabled = false;
            this.txtcodigopro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigopro.Location = new System.Drawing.Point(129, 47);
            this.txtcodigopro.Name = "txtcodigopro";
            this.txtcodigopro.Size = new System.Drawing.Size(53, 20);
            this.txtcodigopro.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 117;
            this.label1.Text = "PRODUTO:";
            // 
            // datacadastro
            // 
            this.datacadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datacadastro.Enabled = false;
            this.datacadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datacadastro.Location = new System.Drawing.Point(514, 6);
            this.datacadastro.Name = "datacadastro";
            this.datacadastro.Size = new System.Drawing.Size(96, 20);
            this.datacadastro.TabIndex = 116;
            // 
            // txtestoque
            // 
            this.txtestoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestoque.Location = new System.Drawing.Point(129, 126);
            this.txtestoque.MaxLength = 7;
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.Size = new System.Drawing.Size(55, 20);
            this.txtestoque.TabIndex = 2;
            this.txtestoque.Tag = "3";
            this.txtestoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtestoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtestoque_KeyPress);
            // 
            // lblestoque
            // 
            this.lblestoque.AutoSize = true;
            this.lblestoque.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestoque.Location = new System.Drawing.Point(18, 129);
            this.lblestoque.Name = "lblestoque";
            this.lblestoque.Size = new System.Drawing.Size(99, 14);
            this.lblestoque.TabIndex = 115;
            this.lblestoque.Text = "QUANTIDADE:";
            // 
            // lbldatacadastro
            // 
            this.lbldatacadastro.AutoSize = true;
            this.lbldatacadastro.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatacadastro.Location = new System.Drawing.Point(369, 9);
            this.lbldatacadastro.Name = "lbldatacadastro";
            this.lbldatacadastro.Size = new System.Drawing.Size(139, 14);
            this.lbldatacadastro.TabIndex = 114;
            this.lbldatacadastro.Tag = "";
            this.lbldatacadastro.Text = "DATA DA ENTRADA:";
            // 
            // txtmarca
            // 
            this.txtmarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmarca.Enabled = false;
            this.txtmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(129, 73);
            this.txtmarca.MaxLength = 49;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(481, 20);
            this.txtmarca.TabIndex = 105;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(58, 76);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(59, 14);
            this.lblmarca.TabIndex = 113;
            this.lblmarca.Text = "MARCA:";
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Enabled = false;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(188, 47);
            this.txtnome.MaxLength = 29;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(389, 20);
            this.txtnome.TabIndex = 104;
            // 
            // txtcodigo
            // 
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(648, 6);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(96, 20);
            this.txtcodigo.TabIndex = 102;
            this.txtcodigo.Visible = false;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.Control;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.Color.Crimson;
            this.btnvoltar.Location = new System.Drawing.Point(412, 409);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(81, 38);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "&VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpatela
            // 
            this.btnlimpatela.BackColor = System.Drawing.SystemColors.Control;
            this.btnlimpatela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpatela.Location = new System.Drawing.Point(200, 409);
            this.btnlimpatela.Name = "btnlimpatela";
            this.btnlimpatela.Size = new System.Drawing.Size(78, 38);
            this.btnlimpatela.TabIndex = 7;
            this.btnlimpatela.Text = "&CANCELAR";
            this.btnlimpatela.UseVisualStyleBackColor = false;
            this.btnlimpatela.Click += new System.EventHandler(this.btnlimpatela_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(109, 409);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(85, 38);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "&REMOVER";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btninserir
            // 
            this.btninserir.BackColor = System.Drawing.SystemColors.Control;
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(21, 409);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(81, 38);
            this.btninserir.TabIndex = 5;
            this.btninserir.Text = "&INSERIR";
            this.btninserir.UseVisualStyleBackColor = false;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 122;
            this.label2.Text = "FORNECEDOR:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(129, 100);
            this.txtFornecedor.MaxLength = 29;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(481, 20);
            this.txtFornecedor.TabIndex = 123;
            // 
            // txtNFe
            // 
            this.txtNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFe.Location = new System.Drawing.Point(129, 6);
            this.txtNFe.MaxLength = 12;
            this.txtNFe.Name = "txtNFe";
            this.txtNFe.Size = new System.Drawing.Size(90, 20);
            this.txtNFe.TabIndex = 0;
            this.txtNFe.Tag = "1";
            this.txtNFe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 14);
            this.label3.TabIndex = 125;
            this.label3.Text = "DOCUMENTO:";
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(310, 126);
            this.txtValor.MaxLength = 1000000;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(55, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.Tag = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 14);
            this.label4.TabIndex = 127;
            this.label4.Text = "PREÇO COMPRA:";
            // 
            // txtTotal
            // 
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(656, 406);
            this.txtTotal.MaxLength = 1000000;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(88, 22);
            this.txtTotal.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 129;
            this.label5.Text = "TOTAL COMPRA:";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(490, 126);
            this.txtPrecoVenda.MaxLength = 1000000;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(55, 20);
            this.txtPrecoVenda.TabIndex = 4;
            this.txtPrecoVenda.Tag = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 14);
            this.label6.TabIndex = 131;
            this.label6.Text = "PREÇO VENDA:";
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 534);
            this.ControlBox = false;
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNFe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.listaentrada);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtcodigopro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datacadastro);
            this.Controls.Add(this.txtestoque);
            this.Controls.Add(this.lblestoque);
            this.Controls.Add(this.lbldatacadastro);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpatela);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btninserir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENTRADA DE PRODUTOS";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.ListView listaentrada;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtcodigopro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datacadastro;
        private System.Windows.Forms.TextBox txtestoque;
        private System.Windows.Forms.Label lblestoque;
        private System.Windows.Forms.Label lbldatacadastro;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpatela;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtNFe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label6;
    }
}
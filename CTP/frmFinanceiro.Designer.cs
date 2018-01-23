namespace LEVINNI
{
    partial class frmFinanceiro
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
            this.rdbCadastro = new System.Windows.Forms.RadioButton();
            this.rdbRecebimento = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbCadastro
            // 
            this.rdbCadastro.AutoSize = true;
            this.rdbCadastro.Location = new System.Drawing.Point(12, 57);
            this.rdbCadastro.Name = "rdbCadastro";
            this.rdbCadastro.Size = new System.Drawing.Size(153, 17);
            this.rdbCadastro.TabIndex = 0;
            this.rdbCadastro.TabStop = true;
            this.rdbCadastro.Text = "&CADASTRO / CONSULTA";
            this.rdbCadastro.UseVisualStyleBackColor = true;
            // 
            // rdbRecebimento
            // 
            this.rdbRecebimento.AutoSize = true;
            this.rdbRecebimento.Location = new System.Drawing.Point(187, 57);
            this.rdbRecebimento.Name = "rdbRecebimento";
            this.rdbRecebimento.Size = new System.Drawing.Size(76, 17);
            this.rdbRecebimento.TabIndex = 1;
            this.rdbRecebimento.TabStop = true;
            this.rdbRecebimento.Text = "&RECEBER";
            this.rdbRecebimento.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(84, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "FINANCEIRO";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(88, 99);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(115, 23);
            this.btnConfirma.TabIndex = 3;
            this.btnConfirma.Text = "&CONFIRMAR";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // frmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rdbRecebimento);
            this.Controls.Add(this.rdbCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 173);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 173);
            this.Name = "frmFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCadastro;
        private System.Windows.Forms.RadioButton rdbRecebimento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConfirma;
    }
}
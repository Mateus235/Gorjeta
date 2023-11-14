
namespace gorjeta
{
    partial class FrmCalGorjeta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalGorjeta));
            this.gpbCalculandoGorjeta = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCalcularGorjeta = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValorDaConta = new System.Windows.Forms.TextBox();
            this.txtValorDaGorjeta = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorDaGorjeta = new System.Windows.Forms.Label();
            this.lblQualidadeDoServiço = new System.Windows.Forms.Label();
            this.lblValorDaConta = new System.Windows.Forms.Label();
            this.lblCalcularGorjeta = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.ltbUsado = new System.Windows.Forms.ListBox();
            this.gpbCalculandoGorjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCalculandoGorjeta
            // 
            this.gpbCalculandoGorjeta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gpbCalculandoGorjeta.Controls.Add(this.comboBox1);
            this.gpbCalculandoGorjeta.Controls.Add(this.btnCalcularGorjeta);
            this.gpbCalculandoGorjeta.Controls.Add(this.txtTotal);
            this.gpbCalculandoGorjeta.Controls.Add(this.txtValorDaConta);
            this.gpbCalculandoGorjeta.Controls.Add(this.txtValorDaGorjeta);
            this.gpbCalculandoGorjeta.Controls.Add(this.lblValorTotal);
            this.gpbCalculandoGorjeta.Controls.Add(this.lblValorDaGorjeta);
            this.gpbCalculandoGorjeta.Controls.Add(this.lblQualidadeDoServiço);
            this.gpbCalculandoGorjeta.Controls.Add(this.lblValorDaConta);
            this.gpbCalculandoGorjeta.Controls.Add(this.lblCalcularGorjeta);
            this.gpbCalculandoGorjeta.Location = new System.Drawing.Point(179, 40);
            this.gpbCalculandoGorjeta.Name = "gpbCalculandoGorjeta";
            this.gpbCalculandoGorjeta.Size = new System.Drawing.Size(320, 360);
            this.gpbCalculandoGorjeta.TabIndex = 0;
            this.gpbCalculandoGorjeta.TabStop = false;
            this.gpbCalculandoGorjeta.Text = "Calculando";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnCalcularGorjeta
            // 
            this.btnCalcularGorjeta.BackColor = System.Drawing.Color.Green;
            this.btnCalcularGorjeta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalcularGorjeta.Location = new System.Drawing.Point(9, 160);
            this.btnCalcularGorjeta.Name = "btnCalcularGorjeta";
            this.btnCalcularGorjeta.Size = new System.Drawing.Size(281, 42);
            this.btnCalcularGorjeta.TabIndex = 2;
            this.btnCalcularGorjeta.Text = "Calcular Gorjeta";
            this.btnCalcularGorjeta.UseVisualStyleBackColor = false;
            this.btnCalcularGorjeta.Click += new System.EventHandler(this.btnCalcularGorjeta_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(8, 303);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(284, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // txtValorDaConta
            // 
            this.txtValorDaConta.Location = new System.Drawing.Point(9, 75);
            this.txtValorDaConta.Name = "txtValorDaConta";
            this.txtValorDaConta.Size = new System.Drawing.Size(283, 20);
            this.txtValorDaConta.TabIndex = 0;
            // 
            // txtValorDaGorjeta
            // 
            this.txtValorDaGorjeta.Location = new System.Drawing.Point(8, 236);
            this.txtValorDaGorjeta.Name = "txtValorDaGorjeta";
            this.txtValorDaGorjeta.Size = new System.Drawing.Size(284, 20);
            this.txtValorDaGorjeta.TabIndex = 3;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(6, 269);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(83, 18);
            this.lblValorTotal.TabIndex = 4;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblValorDaGorjeta
            // 
            this.lblValorDaGorjeta.AutoSize = true;
            this.lblValorDaGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaGorjeta.Location = new System.Drawing.Point(6, 205);
            this.lblValorDaGorjeta.Name = "lblValorDaGorjeta";
            this.lblValorDaGorjeta.Size = new System.Drawing.Size(119, 18);
            this.lblValorDaGorjeta.TabIndex = 3;
            this.lblValorDaGorjeta.Text = "Valor da Gorjeta:";
            // 
            // lblQualidadeDoServiço
            // 
            this.lblQualidadeDoServiço.AutoSize = true;
            this.lblQualidadeDoServiço.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualidadeDoServiço.Location = new System.Drawing.Point(6, 113);
            this.lblQualidadeDoServiço.Name = "lblQualidadeDoServiço";
            this.lblQualidadeDoServiço.Size = new System.Drawing.Size(151, 18);
            this.lblQualidadeDoServiço.TabIndex = 2;
            this.lblQualidadeDoServiço.Text = "Qualidade do serviço:";
            // 
            // lblValorDaConta
            // 
            this.lblValorDaConta.AutoSize = true;
            this.lblValorDaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaConta.Location = new System.Drawing.Point(6, 54);
            this.lblValorDaConta.Name = "lblValorDaConta";
            this.lblValorDaConta.Size = new System.Drawing.Size(110, 18);
            this.lblValorDaConta.TabIndex = 1;
            this.lblValorDaConta.Text = "Valor da Conta:";
            // 
            // lblCalcularGorjeta
            // 
            this.lblCalcularGorjeta.AccessibleDescription = "";
            this.lblCalcularGorjeta.AccessibleName = "";
            this.lblCalcularGorjeta.AutoSize = true;
            this.lblCalcularGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcularGorjeta.Location = new System.Drawing.Point(54, 16);
            this.lblCalcularGorjeta.Name = "lblCalcularGorjeta";
            this.lblCalcularGorjeta.Size = new System.Drawing.Size(199, 24);
            this.lblCalcularGorjeta.TabIndex = 0;
            this.lblCalcularGorjeta.Text = "Calculadora de gorjeta";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(289, 406);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 31);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(179, 406);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 31);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(399, 406);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 31);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(632, 458);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 105);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // ltbUsado
            // 
            this.ltbUsado.FormattingEnabled = true;
            this.ltbUsado.Location = new System.Drawing.Point(-1, 442);
            this.ltbUsado.Name = "ltbUsado";
            this.ltbUsado.Size = new System.Drawing.Size(242, 121);
            this.ltbUsado.TabIndex = 7;
            this.ltbUsado.SelectedIndexChanged += new System.EventHandler(this.ltbUsado_SelectedIndexChanged);
            // 
            // FrmCalGorjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ltbUsado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.gpbCalculandoGorjeta);
            this.Name = "FrmCalGorjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalcularGorjeta";
            this.gpbCalculandoGorjeta.ResumeLayout(false);
            this.gpbCalculandoGorjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCalculandoGorjeta;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorDaGorjeta;
        private System.Windows.Forms.Label lblQualidadeDoServiço;
        private System.Windows.Forms.Label lblValorDaConta;
        private System.Windows.Forms.Label lblCalcularGorjeta;
        private System.Windows.Forms.TextBox txtValorDaGorjeta;
        private System.Windows.Forms.Button btnCalcularGorjeta;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValorDaConta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox ltbUsado;
    }
}


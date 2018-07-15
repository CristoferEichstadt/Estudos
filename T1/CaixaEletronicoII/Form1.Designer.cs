namespace CaixaEletronicoII
{
    partial class Form1
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
            this.textBoxTitular = new System.Windows.Forms.TextBox();
            this.labelTitular = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.textBoxNumeroConta = new System.Windows.Forms.TextBox();
            this.labelNumeroConta = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxContas = new System.Windows.Forms.ComboBox();
            this.labelEscolherConta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTransferencia = new System.Windows.Forms.ComboBox();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitular
            // 
            this.textBoxTitular.BackColor = System.Drawing.Color.Black;
            this.textBoxTitular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitular.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitular.ForeColor = System.Drawing.Color.Aqua;
            this.textBoxTitular.HideSelection = false;
            this.textBoxTitular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxTitular.Location = new System.Drawing.Point(64, 125);
            this.textBoxTitular.MaxLength = 20;
            this.textBoxTitular.Name = "textBoxTitular";
            this.textBoxTitular.ReadOnly = true;
            this.textBoxTitular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTitular.Size = new System.Drawing.Size(324, 20);
            this.textBoxTitular.TabIndex = 0;
            this.textBoxTitular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTitular
            // 
            this.labelTitular.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.labelTitular.Location = new System.Drawing.Point(60, 106);
            this.labelTitular.Name = "labelTitular";
            this.labelTitular.Size = new System.Drawing.Size(328, 16);
            this.labelTitular.TabIndex = 1;
            this.labelTitular.Text = "Titular";
            this.labelTitular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saldo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.BackColor = System.Drawing.Color.Black;
            this.textBoxSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSaldo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaldo.ForeColor = System.Drawing.Color.Aqua;
            this.textBoxSaldo.HideSelection = false;
            this.textBoxSaldo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxSaldo.Location = new System.Drawing.Point(102, 187);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.ReadOnly = true;
            this.textBoxSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSaldo.Size = new System.Drawing.Size(286, 20);
            this.textBoxSaldo.TabIndex = 3;
            this.textBoxSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNumeroConta
            // 
            this.textBoxNumeroConta.BackColor = System.Drawing.Color.Black;
            this.textBoxNumeroConta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumeroConta.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroConta.ForeColor = System.Drawing.Color.Aqua;
            this.textBoxNumeroConta.HideSelection = false;
            this.textBoxNumeroConta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxNumeroConta.Location = new System.Drawing.Point(64, 252);
            this.textBoxNumeroConta.Name = "textBoxNumeroConta";
            this.textBoxNumeroConta.ReadOnly = true;
            this.textBoxNumeroConta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxNumeroConta.Size = new System.Drawing.Size(324, 20);
            this.textBoxNumeroConta.TabIndex = 5;
            this.textBoxNumeroConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNumeroConta
            // 
            this.labelNumeroConta.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.labelNumeroConta.Location = new System.Drawing.Point(61, 226);
            this.labelNumeroConta.Name = "labelNumeroConta";
            this.labelNumeroConta.Size = new System.Drawing.Size(324, 23);
            this.labelNumeroConta.TabIndex = 4;
            this.labelNumeroConta.Text = "Número";
            this.labelNumeroConta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxValor
            // 
            this.textBoxValor.BackColor = System.Drawing.Color.Black;
            this.textBoxValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValor.Font = new System.Drawing.Font("Georgia", 12.2F, System.Drawing.FontStyle.Bold);
            this.textBoxValor.ForeColor = System.Drawing.Color.Aqua;
            this.textBoxValor.Location = new System.Drawing.Point(102, 319);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxValor.Size = new System.Drawing.Size(286, 24);
            this.textBoxValor.TabIndex = 6;
            // 
            // labelValor
            // 
            this.labelValor.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.labelValor.Location = new System.Drawing.Point(64, 293);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(324, 23);
            this.labelValor.TabIndex = 7;
            this.labelValor.Text = "Digite o valor:";
            this.labelValor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.BackColor = System.Drawing.Color.Black;
            this.buttonDepositar.FlatAppearance.BorderSize = 0;
            this.buttonDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepositar.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.buttonDepositar.ForeColor = System.Drawing.Color.Aqua;
            this.buttonDepositar.Location = new System.Drawing.Point(63, 429);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(156, 30);
            this.buttonDepositar.TabIndex = 8;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = false;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // buttonSacar
            // 
            this.buttonSacar.BackColor = System.Drawing.Color.Black;
            this.buttonSacar.FlatAppearance.BorderSize = 0;
            this.buttonSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSacar.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.buttonSacar.ForeColor = System.Drawing.Color.Aqua;
            this.buttonSacar.Location = new System.Drawing.Point(233, 429);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(155, 30);
            this.buttonSacar.TabIndex = 9;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = false;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(60, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "  R$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(60, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "  R$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxContas
            // 
            this.comboBoxContas.BackColor = System.Drawing.Color.Black;
            this.comboBoxContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxContas.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold);
            this.comboBoxContas.ForeColor = System.Drawing.Color.Aqua;
            this.comboBoxContas.Location = new System.Drawing.Point(63, 62);
            this.comboBoxContas.Name = "comboBoxContas";
            this.comboBoxContas.Size = new System.Drawing.Size(325, 28);
            this.comboBoxContas.TabIndex = 15;
            this.comboBoxContas.SelectedIndexChanged += new System.EventHandler(this.comboBoxContas_SelectedIndexChanged);
            // 
            // labelEscolherConta
            // 
            this.labelEscolherConta.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.labelEscolherConta.Location = new System.Drawing.Point(60, 43);
            this.labelEscolherConta.Name = "labelEscolherConta";
            this.labelEscolherConta.Size = new System.Drawing.Size(328, 16);
            this.labelEscolherConta.TabIndex = 16;
            this.labelEscolherConta.Text = "Escolha a conta";
            this.labelEscolherConta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(60, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Destino de transferência";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // comboBoxTransferencia
            // 
            this.comboBoxTransferencia.BackColor = System.Drawing.Color.Black;
            this.comboBoxTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTransferencia.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold);
            this.comboBoxTransferencia.ForeColor = System.Drawing.Color.Aqua;
            this.comboBoxTransferencia.FormattingEnabled = true;
            this.comboBoxTransferencia.Location = new System.Drawing.Point(63, 380);
            this.comboBoxTransferencia.Name = "comboBoxTransferencia";
            this.comboBoxTransferencia.Size = new System.Drawing.Size(325, 28);
            this.comboBoxTransferencia.TabIndex = 17;
            this.comboBoxTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransferencia_SelectedIndexChanged);
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.BackColor = System.Drawing.Color.Black;
            this.buttonTransferir.FlatAppearance.BorderSize = 0;
            this.buttonTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransferir.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.buttonTransferir.ForeColor = System.Drawing.Color.Aqua;
            this.buttonTransferir.Location = new System.Drawing.Point(63, 476);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(325, 30);
            this.buttonTransferir.TabIndex = 19;
            this.buttonTransferir.Text = "Transferir";
            this.buttonTransferir.UseVisualStyleBackColor = false;
            this.buttonTransferir.Click += new System.EventHandler(this.buttonTransferir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 561);
            this.Controls.Add(this.buttonTransferir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTransferencia);
            this.Controls.Add(this.labelEscolherConta);
            this.Controls.Add(this.comboBoxContas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSacar);
            this.Controls.Add(this.buttonDepositar);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxNumeroConta);
            this.Controls.Add(this.labelNumeroConta);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitular);
            this.Controls.Add(this.textBoxTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitular;
        private System.Windows.Forms.Label labelTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.TextBox textBoxNumeroConta;
        private System.Windows.Forms.Label labelNumeroConta;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxContas;
        private System.Windows.Forms.Label labelEscolherConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTransferencia;
        private System.Windows.Forms.Button buttonTransferir;
    }
}


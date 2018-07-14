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
            this.textBoxTitular.Location = new System.Drawing.Point(64, 56);
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
            this.labelTitular.Location = new System.Drawing.Point(60, 37);
            this.labelTitular.Name = "labelTitular";
            this.labelTitular.Size = new System.Drawing.Size(328, 16);
            this.labelTitular.TabIndex = 1;
            this.labelTitular.Text = "Titular da Conta";
            this.labelTitular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saldo da Conta";
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
            this.textBoxSaldo.Location = new System.Drawing.Point(64, 123);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.ReadOnly = true;
            this.textBoxSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSaldo.Size = new System.Drawing.Size(324, 20);
            this.textBoxSaldo.TabIndex = 3;
            this.textBoxSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNumeroConta
            // 
            this.textBoxNumeroConta.BackColor = System.Drawing.Color.Black;
            this.textBoxNumeroConta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumeroConta.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroConta.ForeColor = System.Drawing.Color.Aqua;
            this.textBoxNumeroConta.HideSelection = false;
            this.textBoxNumeroConta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxNumeroConta.Location = new System.Drawing.Point(64, 193);
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
            this.labelNumeroConta.Location = new System.Drawing.Point(61, 167);
            this.labelNumeroConta.Name = "labelNumeroConta";
            this.labelNumeroConta.Size = new System.Drawing.Size(324, 23);
            this.labelNumeroConta.TabIndex = 4;
            this.labelNumeroConta.Text = "Número da Conta";
            this.labelNumeroConta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxValor
            // 
            this.textBoxValor.BackColor = System.Drawing.Color.Black;
            this.textBoxValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValor.Font = new System.Drawing.Font("Georgia", 12.2F, System.Drawing.FontStyle.Bold);
            this.textBoxValor.ForeColor = System.Drawing.Color.Aqua;
            this.textBoxValor.Location = new System.Drawing.Point(64, 265);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(324, 24);
            this.textBoxValor.TabIndex = 6;
            // 
            // labelValor
            // 
            this.labelValor.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.labelValor.Location = new System.Drawing.Point(64, 239);
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
            this.buttonDepositar.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.buttonDepositar.ForeColor = System.Drawing.Color.Aqua;
            this.buttonDepositar.Location = new System.Drawing.Point(64, 319);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(155, 30);
            this.buttonDepositar.TabIndex = 8;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = false;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // buttonSacar
            // 
            this.buttonSacar.BackColor = System.Drawing.Color.Black;
            this.buttonSacar.FlatAppearance.BorderSize = 0;
            this.buttonSacar.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.buttonSacar.ForeColor = System.Drawing.Color.Aqua;
            this.buttonSacar.Location = new System.Drawing.Point(233, 319);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(155, 30);
            this.buttonSacar.TabIndex = 9;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = false;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
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
    }
}


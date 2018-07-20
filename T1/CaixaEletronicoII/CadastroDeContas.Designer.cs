namespace Benner.CaixaEletronicoII
{
    partial class CadastroDeContas
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
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.textBoxEnderecoCliente = new System.Windows.Forms.TextBox();
            this.labelCadastroDeContas = new System.Windows.Forms.Label();
            this.labelDigiteNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEnderecoCliente = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(64, 152);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(275, 20);
            this.textBoxNomeCliente.TabIndex = 0;
            // 
            // textBoxEnderecoCliente
            // 
            this.textBoxEnderecoCliente.Location = new System.Drawing.Point(64, 203);
            this.textBoxEnderecoCliente.Name = "textBoxEnderecoCliente";
            this.textBoxEnderecoCliente.Size = new System.Drawing.Size(275, 20);
            this.textBoxEnderecoCliente.TabIndex = 3;
            // 
            // labelCadastroDeContas
            // 
            this.labelCadastroDeContas.AutoSize = true;
            this.labelCadastroDeContas.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroDeContas.Location = new System.Drawing.Point(57, 34);
            this.labelCadastroDeContas.Name = "labelCadastroDeContas";
            this.labelCadastroDeContas.Size = new System.Drawing.Size(282, 39);
            this.labelCadastroDeContas.TabIndex = 4;
            this.labelCadastroDeContas.Text = "Cadastro da conta";
            this.labelCadastroDeContas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDigiteNome
            // 
            this.labelDigiteNome.AutoSize = true;
            this.labelDigiteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigiteNome.Location = new System.Drawing.Point(61, 133);
            this.labelDigiteNome.Name = "labelDigiteNome";
            this.labelDigiteNome.Size = new System.Drawing.Size(45, 16);
            this.labelDigiteNome.TabIndex = 5;
            this.labelDigiteNome.Text = "Titular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preencha as informações abaixo para efetuar o cadastro:";
            // 
            // labelEnderecoCliente
            // 
            this.labelEnderecoCliente.AutoSize = true;
            this.labelEnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnderecoCliente.Location = new System.Drawing.Point(61, 184);
            this.labelEnderecoCliente.Name = "labelEnderecoCliente";
            this.labelEnderecoCliente.Size = new System.Drawing.Size(56, 16);
            this.labelEnderecoCliente.TabIndex = 9;
            this.labelEnderecoCliente.Text = "Número";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.Black;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.buttonCadastrar.ForeColor = System.Drawing.Color.Aqua;
            this.buttonCadastrar.Location = new System.Drawing.Point(291, 315);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(102, 24);
            this.buttonCadastrar.TabIndex = 11;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.BackColor = System.Drawing.Color.Black;
            this.buttonLimparCampos.FlatAppearance.BorderSize = 0;
            this.buttonLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimparCampos.Font = new System.Drawing.Font("Georgia", 8.2F, System.Drawing.FontStyle.Bold);
            this.buttonLimparCampos.ForeColor = System.Drawing.Color.Aqua;
            this.buttonLimparCampos.Location = new System.Drawing.Point(170, 315);
            this.buttonLimparCampos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(117, 24);
            this.buttonLimparCampos.TabIndex = 12;
            this.buttonLimparCampos.Text = "Limpar campos";
            this.buttonLimparCampos.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Idade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 13;
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.labelEnderecoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDigiteNome);
            this.Controls.Add(this.labelCadastroDeContas);
            this.Controls.Add(this.textBoxEnderecoCliente);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Name = "CadastroDeContas";
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.CadastroDeContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox textBoxEnderecoCliente;
        private System.Windows.Forms.Label labelCadastroDeContas;
        private System.Windows.Forms.Label labelDigiteNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEnderecoCliente;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimparCampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
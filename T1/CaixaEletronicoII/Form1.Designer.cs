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
            this.SuspendLayout();
            // 
            // textBoxTitular
            // 
            this.textBoxTitular.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            this.labelTitular.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
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
    }
}


namespace CodigoVinculacaoSAT
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.gpbCNPJDesenvolvedor = new System.Windows.Forms.GroupBox();
            this.txtCNPJSofolha = new System.Windows.Forms.MaskedTextBox();
            this.gpbCNPJCliente = new System.Windows.Forms.GroupBox();
            this.txtCNPJCliente = new System.Windows.Forms.MaskedTextBox();
            this.gpbCodigoVinculacao = new System.Windows.Forms.GroupBox();
            this.txtCodigoVinculacao = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerarCodigo = new System.Windows.Forms.Button();
            this.gpbCNPJDesenvolvedor.SuspendLayout();
            this.gpbCNPJCliente.SuspendLayout();
            this.gpbCodigoVinculacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCNPJDesenvolvedor
            // 
            this.gpbCNPJDesenvolvedor.Controls.Add(this.txtCNPJSofolha);
            this.gpbCNPJDesenvolvedor.Location = new System.Drawing.Point(5, 146);
            this.gpbCNPJDesenvolvedor.Name = "gpbCNPJDesenvolvedor";
            this.gpbCNPJDesenvolvedor.Size = new System.Drawing.Size(155, 47);
            this.gpbCNPJDesenvolvedor.TabIndex = 0;
            this.gpbCNPJDesenvolvedor.TabStop = false;
            this.gpbCNPJDesenvolvedor.Text = "CNPJ Desenvolvedor";
            // 
            // txtCNPJSofolha
            // 
            this.txtCNPJSofolha.Location = new System.Drawing.Point(16, 19);
            this.txtCNPJSofolha.Mask = "99\\.999\\.999/9999-99";
            this.txtCNPJSofolha.Name = "txtCNPJSofolha";
            this.txtCNPJSofolha.Size = new System.Drawing.Size(123, 20);
            this.txtCNPJSofolha.TabIndex = 5;
            this.txtCNPJSofolha.Leave += new System.EventHandler(this.txtCNPJSofolha_Leave);
            // 
            // gpbCNPJCliente
            // 
            this.gpbCNPJCliente.Controls.Add(this.txtCNPJCliente);
            this.gpbCNPJCliente.Location = new System.Drawing.Point(171, 146);
            this.gpbCNPJCliente.Name = "gpbCNPJCliente";
            this.gpbCNPJCliente.Size = new System.Drawing.Size(155, 47);
            this.gpbCNPJCliente.TabIndex = 1;
            this.gpbCNPJCliente.TabStop = false;
            this.gpbCNPJCliente.Text = "CNPJ Cliente";
            // 
            // txtCNPJCliente
            // 
            this.txtCNPJCliente.Location = new System.Drawing.Point(16, 19);
            this.txtCNPJCliente.Mask = "99\\.999\\.999/9999-99";
            this.txtCNPJCliente.Name = "txtCNPJCliente";
            this.txtCNPJCliente.Size = new System.Drawing.Size(123, 20);
            this.txtCNPJCliente.TabIndex = 6;
            this.txtCNPJCliente.Leave += new System.EventHandler(this.txtCNPJCliente_Leave);
            // 
            // gpbCodigoVinculacao
            // 
            this.gpbCodigoVinculacao.Controls.Add(this.txtCodigoVinculacao);
            this.gpbCodigoVinculacao.Location = new System.Drawing.Point(5, 203);
            this.gpbCodigoVinculacao.Name = "gpbCodigoVinculacao";
            this.gpbCodigoVinculacao.Size = new System.Drawing.Size(490, 119);
            this.gpbCodigoVinculacao.TabIndex = 3;
            this.gpbCodigoVinculacao.TabStop = false;
            this.gpbCodigoVinculacao.Text = "Código Vinculação (Base 64)";
            // 
            // txtCodigoVinculacao
            // 
            this.txtCodigoVinculacao.Location = new System.Drawing.Point(8, 17);
            this.txtCodigoVinculacao.Multiline = true;
            this.txtCodigoVinculacao.Name = "txtCodigoVinculacao";
            this.txtCodigoVinculacao.Size = new System.Drawing.Size(474, 95);
            this.txtCodigoVinculacao.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::CodigoVinculacaoSAT.Properties.Resources.sofolha02;
            this.pictureBox1.Image = global::CodigoVinculacaoSAT.Properties.Resources.sofolha02;
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerarCodigo
            // 
            this.btnGerarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGerarCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarCodigo.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarCodigo.Image")));
            this.btnGerarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarCodigo.Location = new System.Drawing.Point(337, 153);
            this.btnGerarCodigo.Name = "btnGerarCodigo";
            this.btnGerarCodigo.Size = new System.Drawing.Size(156, 38);
            this.btnGerarCodigo.TabIndex = 2;
            this.btnGerarCodigo.Text = "&Gerar Código Vinculação";
            this.btnGerarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarCodigo.UseVisualStyleBackColor = true;
            this.btnGerarCodigo.Click += new System.EventHandler(this.btnGerarCodigo_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbCodigoVinculacao);
            this.Controls.Add(this.btnGerarCodigo);
            this.Controls.Add(this.gpbCNPJCliente);
            this.Controls.Add(this.gpbCNPJDesenvolvedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Código de Vinculação - SAT";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPrincipal_KeyPress);
            this.gpbCNPJDesenvolvedor.ResumeLayout(false);
            this.gpbCNPJDesenvolvedor.PerformLayout();
            this.gpbCNPJCliente.ResumeLayout(false);
            this.gpbCNPJCliente.PerformLayout();
            this.gpbCodigoVinculacao.ResumeLayout(false);
            this.gpbCodigoVinculacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCNPJDesenvolvedor;
        private System.Windows.Forms.GroupBox gpbCNPJCliente;
        private System.Windows.Forms.Button btnGerarCodigo;
        private System.Windows.Forms.GroupBox gpbCodigoVinculacao;
        private System.Windows.Forms.TextBox txtCodigoVinculacao;
        private System.Windows.Forms.MaskedTextBox txtCNPJSofolha;
        private System.Windows.Forms.MaskedTextBox txtCNPJCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace FittSistema.View
{
    partial class FrmRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecibo));
            this.maskValor = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPagador = new System.Windows.Forms.TextBox();
            this.lblBuscarTurma = new System.Windows.Forms.Label();
            this.btnBuscarPagador = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.txtAssinatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // maskValor
            // 
            this.maskValor.Location = new System.Drawing.Point(542, 152);
            this.maskValor.Mask = "$000,00";
            this.maskValor.Name = "maskValor";
            this.maskValor.Size = new System.Drawing.Size(67, 20);
            this.maskValor.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 28);
            this.label6.TabIndex = 72;
            this.label6.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.label5.Location = new System.Drawing.Point(283, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 70;
            this.label5.Text = "Assinatura:";
            // 
            // maskDataVencimento
            // 
            this.maskDataVencimento.Location = new System.Drawing.Point(323, 152);
            this.maskDataVencimento.Mask = "00/00/0000";
            this.maskDataVencimento.Name = "maskDataVencimento";
            this.maskDataVencimento.Size = new System.Drawing.Size(80, 20);
            this.maskDataVencimento.TabIndex = 67;
            this.maskDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.label3.Location = new System.Drawing.Point(179, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Data do Pagamento:";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DeepPink;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(708, 343);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 27);
            this.btnOK.TabIndex = 63;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 40);
            this.label2.TabIndex = 62;
            this.label2.Text = "Recibo";
            // 
            // txtPagador
            // 
            this.txtPagador.Location = new System.Drawing.Point(296, 33);
            this.txtPagador.Name = "txtPagador";
            this.txtPagador.Size = new System.Drawing.Size(195, 20);
            this.txtPagador.TabIndex = 58;
            // 
            // lblBuscarTurma
            // 
            this.lblBuscarTurma.AutoSize = true;
            this.lblBuscarTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarTurma.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.lblBuscarTurma.Location = new System.Drawing.Point(182, 29);
            this.lblBuscarTurma.Name = "lblBuscarTurma";
            this.lblBuscarTurma.Size = new System.Drawing.Size(108, 24);
            this.lblBuscarTurma.TabIndex = 57;
            this.lblBuscarTurma.Text = "Buscar Pagador:";
            // 
            // btnBuscarPagador
            // 
            this.btnBuscarPagador.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPagador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPagador.BackgroundImage")));
            this.btnBuscarPagador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPagador.FlatAppearance.BorderSize = 0;
            this.btnBuscarPagador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPagador.Location = new System.Drawing.Point(496, 33);
            this.btnBuscarPagador.Name = "btnBuscarPagador";
            this.btnBuscarPagador.Size = new System.Drawing.Size(32, 20);
            this.btnBuscarPagador.TabIndex = 61;
            this.btnBuscarPagador.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 305);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 65);
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharTela.BackgroundImage")));
            this.btnFecharTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharTela.FlatAppearance.BorderSize = 0;
            this.btnFecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTela.Location = new System.Drawing.Point(752, 0);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(45, 36);
            this.btnFecharTela.TabIndex = 59;
            this.btnFecharTela.UseVisualStyleBackColor = true;
            // 
            // txtAssinatura
            // 
            this.txtAssinatura.Location = new System.Drawing.Point(364, 265);
            this.txtAssinatura.Name = "txtAssinatura";
            this.txtAssinatura.Size = new System.Drawing.Size(195, 20);
            this.txtAssinatura.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.label4.Location = new System.Drawing.Point(283, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 76;
            this.label4.Text = "Assinatura:";
            // 
            // FrmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAssinatura);
            this.Controls.Add(this.maskValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskDataVencimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarPagador);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFecharTela);
            this.Controls.Add(this.txtPagador);
            this.Controls.Add(this.lblBuscarTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecibo";
            this.Text = "FrmRecibo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskDataVencimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarPagador;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.TextBox txtPagador;
        private System.Windows.Forms.Label lblBuscarTurma;
        private System.Windows.Forms.TextBox txtAssinatura;
        private System.Windows.Forms.Label label4;
    }
}
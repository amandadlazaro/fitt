namespace FittSistema.View
{
    partial class FrmPagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBuscarTurma = new System.Windows.Forms.Label();
            this.txtFrequencia = new System.Windows.Forms.TextBox();
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskValorEstimado = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskDesconto = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskValor = new System.Windows.Forms.MaskedTextBox();
            this.maskMulta = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPagamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarTurma
            // 
            this.lblBuscarTurma.AutoSize = true;
            this.lblBuscarTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarTurma.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.lblBuscarTurma.Location = new System.Drawing.Point(173, 32);
            this.lblBuscarTurma.Name = "lblBuscarTurma";
            this.lblBuscarTurma.Size = new System.Drawing.Size(90, 24);
            this.lblBuscarTurma.TabIndex = 4;
            this.lblBuscarTurma.Text = "Buscar Aluno:";
            // 
            // txtFrequencia
            // 
            this.txtFrequencia.Location = new System.Drawing.Point(287, 38);
            this.txtFrequencia.Name = "txtFrequencia";
            this.txtFrequencia.Size = new System.Drawing.Size(195, 20);
            this.txtFrequencia.TabIndex = 5;
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharTela.BackgroundImage")));
            this.btnFecharTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharTela.FlatAppearance.BorderSize = 0;
            this.btnFecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTela.Location = new System.Drawing.Point(700, 0);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(45, 36);
            this.btnFecharTela.TabIndex = 14;
            this.btnFecharTela.UseVisualStyleBackColor = true;
            this.btnFecharTela.Click += new System.EventHandler(this.btnFecharTela_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 65);
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAluno.BackgroundImage")));
            this.btnBuscarAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarAluno.FlatAppearance.BorderSize = 0;
            this.btnBuscarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAluno.Location = new System.Drawing.Point(485, 38);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(32, 20);
            this.btnBuscarAluno.TabIndex = 38;
            this.btnBuscarAluno.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(-1, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 40);
            this.label2.TabIndex = 41;
            this.label2.Text = "Pagamentos";
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProfessor.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProfessor.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(627, 331);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(80, 27);
            this.btnCadastrarProfessor.TabIndex = 44;
            this.btnCadastrarProfessor.Text = "Cadastrar";
            this.btnCadastrarProfessor.UseVisualStyleBackColor = false;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.label1.Location = new System.Drawing.Point(90, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Forma de Pagamento:";
            // 
            // cmbForma
            // 
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Location = new System.Drawing.Point(233, 119);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(133, 21);
            this.cmbForma.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.label3.Location = new System.Drawing.Point(397, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Data de Vencimento:";
            // 
            // maskDataVencimento
            // 
            this.maskDataVencimento.Location = new System.Drawing.Point(541, 120);
            this.maskDataVencimento.Mask = "00/00/0000";
            this.maskDataVencimento.Name = "maskDataVencimento";
            this.maskDataVencimento.Size = new System.Drawing.Size(80, 20);
            this.maskDataVencimento.TabIndex = 50;
            this.maskDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.label4.Location = new System.Drawing.Point(90, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "Valor Estimado:";
            // 
            // maskValorEstimado
            // 
            this.maskValorEstimado.Location = new System.Drawing.Point(233, 187);
            this.maskValorEstimado.Mask = "$000,00";
            this.maskValorEstimado.Name = "maskValorEstimado";
            this.maskValorEstimado.Size = new System.Drawing.Size(100, 20);
            this.maskValorEstimado.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.label5.Location = new System.Drawing.Point(397, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Desconto Adicional:";
            // 
            // maskDesconto
            // 
            this.maskDesconto.Location = new System.Drawing.Point(541, 189);
            this.maskDesconto.Mask = "$000,00";
            this.maskDesconto.Name = "maskDesconto";
            this.maskDesconto.Size = new System.Drawing.Size(80, 20);
            this.maskDesconto.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 28);
            this.label6.TabIndex = 55;
            this.label6.Text = "Valor Final:";
            // 
            // maskValor
            // 
            this.maskValor.Location = new System.Drawing.Point(541, 247);
            this.maskValor.Mask = "$000,00";
            this.maskValor.Name = "maskValor";
            this.maskValor.Size = new System.Drawing.Size(80, 20);
            this.maskValor.TabIndex = 56;
            // 
            // maskMulta
            // 
            this.maskMulta.Location = new System.Drawing.Point(234, 245);
            this.maskMulta.Mask = "$000,00";
            this.maskMulta.Name = "maskMulta";
            this.maskMulta.Size = new System.Drawing.Size(99, 20);
            this.maskMulta.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.label7.Location = new System.Drawing.Point(90, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "Multa:";
            // 
            // dgvPagamento
            // 
            this.dgvPagamento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamento.GridColor = System.Drawing.Color.LightCoral;
            this.dgvPagamento.Location = new System.Drawing.Point(-4, 92);
            this.dgvPagamento.Name = "dgvPagamento";
            this.dgvPagamento.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagamento.Size = new System.Drawing.Size(749, 203);
            this.dgvPagamento.TabIndex = 71;
            this.dgvPagamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamento_CellDoubleClick);
            // 
            // FrmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.dgvPagamento);
            this.Controls.Add(this.maskMulta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskDesconto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskValorEstimado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskDataVencimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbForma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarProfessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFecharTela);
            this.Controls.Add(this.txtFrequencia);
            this.Controls.Add(this.lblBuscarTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.FrmPagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarTurma;
        private System.Windows.Forms.TextBox txtFrequencia;
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskDataVencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskValorEstimado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskDesconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskValor;
        private System.Windows.Forms.MaskedTextBox maskMulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPagamento;
    }
}
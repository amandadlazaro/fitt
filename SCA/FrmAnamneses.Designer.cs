﻿namespace FittSistema.View
{
    partial class FrmAnamneses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnamneses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscarAnamnese = new System.Windows.Forms.Button();
            this.btnFecharForm = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnExcluirAnamnese = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQP = new System.Windows.Forms.Label();
            this.txtQP = new System.Windows.Forms.TextBox();
            this.lblHM = new System.Windows.Forms.Label();
            this.txtHM = new System.Windows.Forms.TextBox();
            this.lblEsporte = new System.Windows.Forms.Label();
            this.txtEsporte = new System.Windows.Forms.TextBox();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.lblHumor = new System.Windows.Forms.Label();
            this.txtHumor = new System.Windows.Forms.TextBox();
            this.lblDor = new System.Windows.Forms.Label();
            this.txtDor = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblMedicacao = new System.Windows.Forms.Label();
            this.txtMedicacao = new System.Windows.Forms.TextBox();
            this.lblPatologias = new System.Windows.Forms.Label();
            this.txtPatologias = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grpAlunos = new System.Windows.Forms.DataGridView();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtAnamnese = new System.Windows.Forms.TextBox();
            this.dtpDataAnamnese = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBusca.Location = new System.Drawing.Point(164, 48);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(401, 27);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.Text = "Buscar por Aluno";
            this.txtBusca.Enter += new System.EventHandler(this.txtBusca_Enter);
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            this.txtBusca.Leave += new System.EventHandler(this.txtBusca_Leave);
            // 
            // btnBuscarAnamnese
            // 
            this.btnBuscarAnamnese.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAnamnese.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAnamnese.BackgroundImage")));
            this.btnBuscarAnamnese.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarAnamnese.FlatAppearance.BorderSize = 0;
            this.btnBuscarAnamnese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAnamnese.Location = new System.Drawing.Point(571, 51);
            this.btnBuscarAnamnese.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscarAnamnese.Name = "btnBuscarAnamnese";
            this.btnBuscarAnamnese.Size = new System.Drawing.Size(32, 20);
            this.btnBuscarAnamnese.TabIndex = 2;
            this.btnBuscarAnamnese.UseVisualStyleBackColor = false;
            this.btnBuscarAnamnese.Click += new System.EventHandler(this.btnBuscarAnamnese_Click);
            // 
            // btnFecharForm
            // 
            this.btnFecharForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharForm.BackgroundImage")));
            this.btnFecharForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharForm.FlatAppearance.BorderSize = 0;
            this.btnFecharForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharForm.Location = new System.Drawing.Point(698, -1);
            this.btnFecharForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFecharForm.Name = "btnFecharForm";
            this.btnFecharForm.Size = new System.Drawing.Size(44, 36);
            this.btnFecharForm.TabIndex = 11;
            this.btnFecharForm.UseVisualStyleBackColor = true;
            this.btnFecharForm.Click += new System.EventHandler(this.btnFecharForm_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 317);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 65);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // btnExcluirAnamnese
            // 
            this.btnExcluirAnamnese.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirAnamnese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAnamnese.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAnamnese.ForeColor = System.Drawing.Color.DeepPink;
            this.btnExcluirAnamnese.Location = new System.Drawing.Point(559, 348);
            this.btnExcluirAnamnese.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExcluirAnamnese.Name = "btnExcluirAnamnese";
            this.btnExcluirAnamnese.Size = new System.Drawing.Size(80, 27);
            this.btnExcluirAnamnese.TabIndex = 38;
            this.btnExcluirAnamnese.Text = "Excluir";
            this.btnExcluirAnamnese.UseVisualStyleBackColor = false;
            this.btnExcluirAnamnese.Visible = false;
            this.btnExcluirAnamnese.Click += new System.EventHandler(this.btnExcluirAnamese_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "Anamneses";
            // 
            // lblQP
            // 
            this.lblQP.AutoSize = true;
            this.lblQP.BackColor = System.Drawing.Color.Transparent;
            this.lblQP.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblQP.Location = new System.Drawing.Point(54, 95);
            this.lblQP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQP.Name = "lblQP";
            this.lblQP.Size = new System.Drawing.Size(107, 25);
            this.lblQP.TabIndex = 40;
            this.lblQP.Text = "Queixa Principal";
            // 
            // txtQP
            // 
            this.txtQP.Location = new System.Drawing.Point(164, 97);
            this.txtQP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQP.Name = "txtQP";
            this.txtQP.Size = new System.Drawing.Size(528, 20);
            this.txtQP.TabIndex = 41;
            // 
            // lblHM
            // 
            this.lblHM.BackColor = System.Drawing.Color.Transparent;
            this.lblHM.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblHM.Location = new System.Drawing.Point(54, 130);
            this.lblHM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHM.Name = "lblHM";
            this.lblHM.Size = new System.Drawing.Size(157, 29);
            this.lblHM.TabIndex = 42;
            this.lblHM.Text = "Hábitos e Manipulações";
            // 
            // txtHM
            // 
            this.txtHM.Location = new System.Drawing.Point(203, 133);
            this.txtHM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHM.Name = "txtHM";
            this.txtHM.Size = new System.Drawing.Size(489, 20);
            this.txtHM.TabIndex = 43;
            // 
            // lblEsporte
            // 
            this.lblEsporte.AutoSize = true;
            this.lblEsporte.BackColor = System.Drawing.Color.Transparent;
            this.lblEsporte.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsporte.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblEsporte.Location = new System.Drawing.Point(54, 162);
            this.lblEsporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEsporte.Name = "lblEsporte";
            this.lblEsporte.Size = new System.Drawing.Size(58, 25);
            this.lblEsporte.TabIndex = 44;
            this.lblEsporte.Text = "Esporte";
            // 
            // txtEsporte
            // 
            this.txtEsporte.Location = new System.Drawing.Point(118, 167);
            this.txtEsporte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEsporte.Name = "txtEsporte";
            this.txtEsporte.Size = new System.Drawing.Size(118, 20);
            this.txtEsporte.TabIndex = 45;
            // 
            // lblPosicao
            // 
            this.lblPosicao.BackColor = System.Drawing.Color.Transparent;
            this.lblPosicao.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicao.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPosicao.Location = new System.Drawing.Point(266, 162);
            this.lblPosicao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(126, 27);
            this.lblPosicao.TabIndex = 46;
            this.lblPosicao.Text = "Posição de Dormir";
            // 
            // txtPosicao
            // 
            this.txtPosicao.Location = new System.Drawing.Point(388, 167);
            this.txtPosicao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(304, 20);
            this.txtPosicao.TabIndex = 47;
            // 
            // lblHumor
            // 
            this.lblHumor.AutoSize = true;
            this.lblHumor.BackColor = System.Drawing.Color.Transparent;
            this.lblHumor.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblHumor.Location = new System.Drawing.Point(54, 262);
            this.lblHumor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHumor.Name = "lblHumor";
            this.lblHumor.Size = new System.Drawing.Size(52, 25);
            this.lblHumor.TabIndex = 48;
            this.lblHumor.Text = "Humor";
            // 
            // txtHumor
            // 
            this.txtHumor.Location = new System.Drawing.Point(103, 267);
            this.txtHumor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHumor.Name = "txtHumor";
            this.txtHumor.Size = new System.Drawing.Size(196, 20);
            this.txtHumor.TabIndex = 49;
            // 
            // lblDor
            // 
            this.lblDor.AutoSize = true;
            this.lblDor.BackColor = System.Drawing.Color.Transparent;
            this.lblDor.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDor.Location = new System.Drawing.Point(54, 194);
            this.lblDor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDor.Name = "lblDor";
            this.lblDor.Size = new System.Drawing.Size(34, 25);
            this.lblDor.TabIndex = 50;
            this.lblDor.Text = "Dor";
            // 
            // txtDor
            // 
            this.txtDor.Location = new System.Drawing.Point(94, 201);
            this.txtDor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDor.Name = "txtDor";
            this.txtDor.Size = new System.Drawing.Size(142, 20);
            this.txtDor.TabIndex = 51;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDescricao.Location = new System.Drawing.Point(266, 196);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(116, 30);
            this.lblDescricao.TabIndex = 52;
            this.lblDescricao.Text = "Descrição da Dor";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(388, 201);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(304, 20);
            this.txtDescricao.TabIndex = 53;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.BackColor = System.Drawing.Color.Transparent;
            this.lblDiagnostico.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDiagnostico.Location = new System.Drawing.Point(312, 227);
            this.lblDiagnostico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(151, 28);
            this.lblDiagnostico.TabIndex = 54;
            this.lblDiagnostico.Text = "Diagnóstico do Médico";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(456, 234);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(236, 20);
            this.txtDiagnostico.TabIndex = 55;
            // 
            // lblMedicacao
            // 
            this.lblMedicacao.AutoSize = true;
            this.lblMedicacao.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicacao.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicacao.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblMedicacao.Location = new System.Drawing.Point(54, 227);
            this.lblMedicacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicacao.Name = "lblMedicacao";
            this.lblMedicacao.Size = new System.Drawing.Size(74, 25);
            this.lblMedicacao.TabIndex = 56;
            this.lblMedicacao.Text = "Medicação";
            // 
            // txtMedicacao
            // 
            this.txtMedicacao.Location = new System.Drawing.Point(134, 232);
            this.txtMedicacao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMedicacao.Name = "txtMedicacao";
            this.txtMedicacao.Size = new System.Drawing.Size(165, 20);
            this.txtMedicacao.TabIndex = 57;
            // 
            // lblPatologias
            // 
            this.lblPatologias.AutoSize = true;
            this.lblPatologias.BackColor = System.Drawing.Color.Transparent;
            this.lblPatologias.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatologias.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPatologias.Location = new System.Drawing.Point(312, 262);
            this.lblPatologias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatologias.Name = "lblPatologias";
            this.lblPatologias.Size = new System.Drawing.Size(73, 25);
            this.lblPatologias.TabIndex = 58;
            this.lblPatologias.Text = "Patologias";
            // 
            // txtPatologias
            // 
            this.txtPatologias.Location = new System.Drawing.Point(388, 267);
            this.txtPatologias.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPatologias.Name = "txtPatologias";
            this.txtPatologias.Size = new System.Drawing.Size(304, 20);
            this.txtPatologias.TabIndex = 59;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DeepPink;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(644, 348);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 27);
            this.btnSalvar.TabIndex = 60;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(0, -1);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(38, 36);
            this.btnVoltar.TabIndex = 72;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // grpAlunos
            // 
            this.grpAlunos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grpAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpAlunos.GridColor = System.Drawing.Color.LightCoral;
            this.grpAlunos.Location = new System.Drawing.Point(0, 92);
            this.grpAlunos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpAlunos.Name = "grpAlunos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grpAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grpAlunos.Size = new System.Drawing.Size(750, 203);
            this.grpAlunos.TabIndex = 71;
            this.grpAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpAlunos_CellDoubleClick);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(222, 317);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 73;
            this.txtMatricula.Visible = false;
            // 
            // txtAnamnese
            // 
            this.txtAnamnese.Location = new System.Drawing.Point(118, 317);
            this.txtAnamnese.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAnamnese.Name = "txtAnamnese";
            this.txtAnamnese.Size = new System.Drawing.Size(100, 20);
            this.txtAnamnese.TabIndex = 74;
            this.txtAnamnese.Visible = false;
            // 
            // dtpDataAnamnese
            // 
            this.dtpDataAnamnese.Location = new System.Drawing.Point(326, 317);
            this.dtpDataAnamnese.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpDataAnamnese.Name = "dtpDataAnamnese";
            this.dtpDataAnamnese.Size = new System.Drawing.Size(200, 20);
            this.dtpDataAnamnese.TabIndex = 76;
            this.dtpDataAnamnese.Value = new System.DateTime(2018, 11, 10, 1, 28, 22, 0);
            this.dtpDataAnamnese.Visible = false;
            // 
            // FrmAnamneses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.dtpDataAnamnese);
            this.Controls.Add(this.txtAnamnese);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grpAlunos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPatologias);
            this.Controls.Add(this.lblPatologias);
            this.Controls.Add(this.txtMedicacao);
            this.Controls.Add(this.lblMedicacao);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDor);
            this.Controls.Add(this.lblDor);
            this.Controls.Add(this.txtHumor);
            this.Controls.Add(this.lblHumor);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.txtEsporte);
            this.Controls.Add(this.lblEsporte);
            this.Controls.Add(this.txtHM);
            this.Controls.Add(this.lblHM);
            this.Controls.Add(this.txtQP);
            this.Controls.Add(this.lblQP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirAnamnese);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFecharForm);
            this.Controls.Add(this.btnBuscarAnamnese);
            this.Controls.Add(this.txtBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(164, 48);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmAnamneses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anamneses";
            this.Load += new System.EventHandler(this.FrmAnamneses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBuscarAnamnese;
        private System.Windows.Forms.Button btnFecharForm;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnExcluirAnamnese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQP;
        private System.Windows.Forms.TextBox txtQP;
        private System.Windows.Forms.Label lblHM;
        private System.Windows.Forms.TextBox txtHM;
        private System.Windows.Forms.Label lblEsporte;
        private System.Windows.Forms.TextBox txtEsporte;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.Label lblHumor;
        private System.Windows.Forms.TextBox txtHumor;
        private System.Windows.Forms.Label lblDor;
        private System.Windows.Forms.TextBox txtDor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblMedicacao;
        private System.Windows.Forms.TextBox txtMedicacao;
        private System.Windows.Forms.Label lblPatologias;
        private System.Windows.Forms.TextBox txtPatologias;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView grpAlunos;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtAnamnese;
        private System.Windows.Forms.DateTimePicker dtpDataAnamnese;
    }
}
namespace FittSistema.View
{
    partial class FrmMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatricula));
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirProfessor = new System.Windows.Forms.Button();
            this.btnEditarProfessor = new System.Windows.Forms.Button();
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.rbMensal = new System.Windows.Forms.RadioButton();
            this.lblMensal = new System.Windows.Forms.Label();
            this.rbTrimestral = new System.Windows.Forms.RadioButton();
            this.label2lblTrimestral = new System.Windows.Forms.Label();
            this.rbSemestral = new System.Windows.Forms.RadioButton();
            this.lblSemestral = new System.Windows.Forms.Label();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.lblAnual = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.maskDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.maskDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.lblAulas = new System.Windows.Forms.Label();
            this.rbUmaAula = new System.Windows.Forms.RadioButton();
            this.lblUmaAula = new System.Windows.Forms.Label();
            this.rbDuasAulas = new System.Windows.Forms.RadioButton();
            this.lblDuasAulas = new System.Windows.Forms.Label();
            this.rbTresAulas = new System.Windows.Forms.RadioButton();
            this.lblTresAulas = new System.Windows.Forms.Label();
            this.cmbDiasdaSemana1 = new System.Windows.Forms.ComboBox();
            this.lblDiasSemana = new System.Windows.Forms.Label();
            this.cmbDiasdaSemana2 = new System.Windows.Forms.ComboBox();
            this.cmbDiasdaSemana3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHorariosTurma3 = new System.Windows.Forms.ComboBox();
            this.cmbHorariosTurma2 = new System.Windows.Forms.ComboBox();
            this.cmbHorariosTurma1 = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharTela.BackgroundImage")));
            this.btnFecharTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharTela.FlatAppearance.BorderSize = 0;
            this.btnFecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTela.Location = new System.Drawing.Point(698, 0);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(45, 36);
            this.btnFecharTela.TabIndex = 25;
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
            this.pictureBox3.Location = new System.Drawing.Point(12, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 65);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(-1, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 40);
            this.label1.TabIndex = 40;
            this.label1.Text = "Matrícula";
            // 
            // btnExcluirProfessor
            // 
            this.btnExcluirProfessor.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirProfessor.Enabled = false;
            this.btnExcluirProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProfessor.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProfessor.ForeColor = System.Drawing.Color.DeepPink;
            this.btnExcluirProfessor.Location = new System.Drawing.Point(651, 339);
            this.btnExcluirProfessor.Name = "btnExcluirProfessor";
            this.btnExcluirProfessor.Size = new System.Drawing.Size(80, 27);
            this.btnExcluirProfessor.TabIndex = 43;
            this.btnExcluirProfessor.Text = "Excluir";
            this.btnExcluirProfessor.UseVisualStyleBackColor = false;
            this.btnExcluirProfessor.Visible = false;
            // 
            // btnEditarProfessor
            // 
            this.btnEditarProfessor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarProfessor.Enabled = false;
            this.btnEditarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProfessor.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProfessor.ForeColor = System.Drawing.Color.DeepPink;
            this.btnEditarProfessor.Location = new System.Drawing.Point(557, 339);
            this.btnEditarProfessor.Name = "btnEditarProfessor";
            this.btnEditarProfessor.Size = new System.Drawing.Size(80, 27);
            this.btnEditarProfessor.TabIndex = 42;
            this.btnEditarProfessor.Text = "Editar";
            this.btnEditarProfessor.UseVisualStyleBackColor = false;
            this.btnEditarProfessor.Visible = false;
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarProfessor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarProfessor.BackgroundImage")));
            this.btnCadastrarProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrarProfessor.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProfessor.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProfessor.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(696, 330);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(35, 36);
            this.btnCadastrarProfessor.TabIndex = 52;
            this.btnCadastrarProfessor.UseVisualStyleBackColor = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTipo.Location = new System.Drawing.Point(75, 80);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(46, 28);
            this.lblTipo.TabIndex = 67;
            this.lblTipo.Text = "Tipo:";
            // 
            // rbMensal
            // 
            this.rbMensal.AutoCheck = false;
            this.rbMensal.AutoSize = true;
            this.rbMensal.BackColor = System.Drawing.Color.Transparent;
            this.rbMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMensal.ForeColor = System.Drawing.Color.DeepPink;
            this.rbMensal.Location = new System.Drawing.Point(162, 89);
            this.rbMensal.Name = "rbMensal";
            this.rbMensal.Size = new System.Drawing.Size(13, 12);
            this.rbMensal.TabIndex = 68;
            this.rbMensal.UseVisualStyleBackColor = false;
            // 
            // lblMensal
            // 
            this.lblMensal.AutoSize = true;
            this.lblMensal.BackColor = System.Drawing.Color.Transparent;
            this.lblMensal.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblMensal.Location = new System.Drawing.Point(181, 81);
            this.lblMensal.Name = "lblMensal";
            this.lblMensal.Size = new System.Drawing.Size(53, 25);
            this.lblMensal.TabIndex = 69;
            this.lblMensal.Text = "Mensal";
            // 
            // rbTrimestral
            // 
            this.rbTrimestral.AutoCheck = false;
            this.rbTrimestral.AutoSize = true;
            this.rbTrimestral.BackColor = System.Drawing.Color.Transparent;
            this.rbTrimestral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbTrimestral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTrimestral.ForeColor = System.Drawing.Color.DeepPink;
            this.rbTrimestral.Location = new System.Drawing.Point(287, 89);
            this.rbTrimestral.Name = "rbTrimestral";
            this.rbTrimestral.Size = new System.Drawing.Size(13, 12);
            this.rbTrimestral.TabIndex = 70;
            this.rbTrimestral.UseVisualStyleBackColor = false;
            // 
            // label2lblTrimestral
            // 
            this.label2lblTrimestral.AutoSize = true;
            this.label2lblTrimestral.BackColor = System.Drawing.Color.Transparent;
            this.label2lblTrimestral.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2lblTrimestral.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2lblTrimestral.Location = new System.Drawing.Point(306, 81);
            this.label2lblTrimestral.Name = "label2lblTrimestral";
            this.label2lblTrimestral.Size = new System.Drawing.Size(72, 25);
            this.label2lblTrimestral.TabIndex = 71;
            this.label2lblTrimestral.Text = "Trimestral";
            // 
            // rbSemestral
            // 
            this.rbSemestral.AutoCheck = false;
            this.rbSemestral.AutoSize = true;
            this.rbSemestral.BackColor = System.Drawing.Color.Transparent;
            this.rbSemestral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSemestral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSemestral.ForeColor = System.Drawing.Color.DeepPink;
            this.rbSemestral.Location = new System.Drawing.Point(432, 90);
            this.rbSemestral.Name = "rbSemestral";
            this.rbSemestral.Size = new System.Drawing.Size(13, 12);
            this.rbSemestral.TabIndex = 72;
            this.rbSemestral.UseVisualStyleBackColor = false;
            // 
            // lblSemestral
            // 
            this.lblSemestral.AutoSize = true;
            this.lblSemestral.BackColor = System.Drawing.Color.Transparent;
            this.lblSemestral.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestral.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblSemestral.Location = new System.Drawing.Point(451, 81);
            this.lblSemestral.Name = "lblSemestral";
            this.lblSemestral.Size = new System.Drawing.Size(73, 25);
            this.lblSemestral.TabIndex = 73;
            this.lblSemestral.Text = "Semestral";
            // 
            // rbAnual
            // 
            this.rbAnual.AutoCheck = false;
            this.rbAnual.AutoSize = true;
            this.rbAnual.BackColor = System.Drawing.Color.Transparent;
            this.rbAnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnual.ForeColor = System.Drawing.Color.DeepPink;
            this.rbAnual.Location = new System.Drawing.Point(595, 91);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(13, 12);
            this.rbAnual.TabIndex = 74;
            this.rbAnual.UseVisualStyleBackColor = false;
            // 
            // lblAnual
            // 
            this.lblAnual.AutoSize = true;
            this.lblAnual.BackColor = System.Drawing.Color.Transparent;
            this.lblAnual.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnual.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblAnual.Location = new System.Drawing.Point(614, 83);
            this.lblAnual.Name = "lblAnual";
            this.lblAnual.Size = new System.Drawing.Size(44, 25);
            this.lblAnual.TabIndex = 75;
            this.lblAnual.Text = "Anual";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblDataInicial.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDataInicial.Location = new System.Drawing.Point(75, 123);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(97, 28);
            this.lblDataInicial.TabIndex = 76;
            this.lblDataInicial.Text = "Data Inicial:";
            // 
            // maskDataInicial
            // 
            this.maskDataInicial.Location = new System.Drawing.Point(187, 132);
            this.maskDataInicial.Mask = "00/00/0000";
            this.maskDataInicial.Name = "maskDataInicial";
            this.maskDataInicial.Size = new System.Drawing.Size(80, 20);
            this.maskDataInicial.TabIndex = 77;
            this.maskDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblDataFinal.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDataFinal.Location = new System.Drawing.Point(326, 123);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(87, 28);
            this.lblDataFinal.TabIndex = 78;
            this.lblDataFinal.Text = "Data Final:";
            // 
            // maskDataFinal
            // 
            this.maskDataFinal.Location = new System.Drawing.Point(428, 132);
            this.maskDataFinal.Mask = "00/00/0000";
            this.maskDataFinal.Name = "maskDataFinal";
            this.maskDataFinal.Size = new System.Drawing.Size(80, 20);
            this.maskDataFinal.TabIndex = 79;
            this.maskDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.BackColor = System.Drawing.Color.Transparent;
            this.lblAulas.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAulas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblAulas.Location = new System.Drawing.Point(77, 168);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(57, 28);
            this.lblAulas.TabIndex = 80;
            this.lblAulas.Text = "Aulas:";
            // 
            // rbUmaAula
            // 
            this.rbUmaAula.AutoCheck = false;
            this.rbUmaAula.AutoSize = true;
            this.rbUmaAula.BackColor = System.Drawing.Color.Transparent;
            this.rbUmaAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbUmaAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUmaAula.ForeColor = System.Drawing.Color.DeepPink;
            this.rbUmaAula.Location = new System.Drawing.Point(164, 179);
            this.rbUmaAula.Name = "rbUmaAula";
            this.rbUmaAula.Size = new System.Drawing.Size(13, 12);
            this.rbUmaAula.TabIndex = 81;
            this.rbUmaAula.UseVisualStyleBackColor = false;
            // 
            // lblUmaAula
            // 
            this.lblUmaAula.AutoSize = true;
            this.lblUmaAula.BackColor = System.Drawing.Color.Transparent;
            this.lblUmaAula.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmaAula.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblUmaAula.Location = new System.Drawing.Point(187, 171);
            this.lblUmaAula.Name = "lblUmaAula";
            this.lblUmaAula.Size = new System.Drawing.Size(15, 25);
            this.lblUmaAula.TabIndex = 82;
            this.lblUmaAula.Text = "1";
            // 
            // rbDuasAulas
            // 
            this.rbDuasAulas.AutoCheck = false;
            this.rbDuasAulas.AutoSize = true;
            this.rbDuasAulas.BackColor = System.Drawing.Color.Transparent;
            this.rbDuasAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDuasAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDuasAulas.ForeColor = System.Drawing.Color.DeepPink;
            this.rbDuasAulas.Location = new System.Drawing.Point(289, 179);
            this.rbDuasAulas.Name = "rbDuasAulas";
            this.rbDuasAulas.Size = new System.Drawing.Size(13, 12);
            this.rbDuasAulas.TabIndex = 83;
            this.rbDuasAulas.UseVisualStyleBackColor = false;
            // 
            // lblDuasAulas
            // 
            this.lblDuasAulas.AutoSize = true;
            this.lblDuasAulas.BackColor = System.Drawing.Color.Transparent;
            this.lblDuasAulas.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuasAulas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDuasAulas.Location = new System.Drawing.Point(308, 171);
            this.lblDuasAulas.Name = "lblDuasAulas";
            this.lblDuasAulas.Size = new System.Drawing.Size(21, 25);
            this.lblDuasAulas.TabIndex = 84;
            this.lblDuasAulas.Text = "2";
            // 
            // rbTresAulas
            // 
            this.rbTresAulas.AutoCheck = false;
            this.rbTresAulas.AutoSize = true;
            this.rbTresAulas.BackColor = System.Drawing.Color.Transparent;
            this.rbTresAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbTresAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTresAulas.ForeColor = System.Drawing.Color.DeepPink;
            this.rbTresAulas.Location = new System.Drawing.Point(434, 179);
            this.rbTresAulas.Name = "rbTresAulas";
            this.rbTresAulas.Size = new System.Drawing.Size(13, 12);
            this.rbTresAulas.TabIndex = 85;
            this.rbTresAulas.UseVisualStyleBackColor = false;
            // 
            // lblTresAulas
            // 
            this.lblTresAulas.AutoSize = true;
            this.lblTresAulas.BackColor = System.Drawing.Color.Transparent;
            this.lblTresAulas.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTresAulas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTresAulas.Location = new System.Drawing.Point(453, 170);
            this.lblTresAulas.Name = "lblTresAulas";
            this.lblTresAulas.Size = new System.Drawing.Size(21, 25);
            this.lblTresAulas.TabIndex = 86;
            this.lblTresAulas.Text = "3";
            // 
            // cmbDiasdaSemana1
            // 
            this.cmbDiasdaSemana1.FormattingEnabled = true;
            this.cmbDiasdaSemana1.Location = new System.Drawing.Point(164, 236);
            this.cmbDiasdaSemana1.Name = "cmbDiasdaSemana1";
            this.cmbDiasdaSemana1.Size = new System.Drawing.Size(121, 21);
            this.cmbDiasdaSemana1.TabIndex = 87;
            // 
            // lblDiasSemana
            // 
            this.lblDiasSemana.AutoSize = true;
            this.lblDiasSemana.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasSemana.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasSemana.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDiasSemana.Location = new System.Drawing.Point(159, 205);
            this.lblDiasSemana.Name = "lblDiasSemana";
            this.lblDiasSemana.Size = new System.Drawing.Size(136, 28);
            this.lblDiasSemana.TabIndex = 88;
            this.lblDiasSemana.Text = "Dias da Semana:";
            // 
            // cmbDiasdaSemana2
            // 
            this.cmbDiasdaSemana2.FormattingEnabled = true;
            this.cmbDiasdaSemana2.Location = new System.Drawing.Point(164, 263);
            this.cmbDiasdaSemana2.Name = "cmbDiasdaSemana2";
            this.cmbDiasdaSemana2.Size = new System.Drawing.Size(121, 21);
            this.cmbDiasdaSemana2.TabIndex = 89;
            // 
            // cmbDiasdaSemana3
            // 
            this.cmbDiasdaSemana3.FormattingEnabled = true;
            this.cmbDiasdaSemana3.Location = new System.Drawing.Point(164, 290);
            this.cmbDiasdaSemana3.Name = "cmbDiasdaSemana3";
            this.cmbDiasdaSemana3.Size = new System.Drawing.Size(121, 21);
            this.cmbDiasdaSemana3.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(338, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 91;
            this.label2.Text = "Horários/Turmas:";
            // 
            // cmbHorariosTurma3
            // 
            this.cmbHorariosTurma3.FormattingEnabled = true;
            this.cmbHorariosTurma3.Location = new System.Drawing.Point(353, 290);
            this.cmbHorariosTurma3.Name = "cmbHorariosTurma3";
            this.cmbHorariosTurma3.Size = new System.Drawing.Size(121, 21);
            this.cmbHorariosTurma3.TabIndex = 94;
            // 
            // cmbHorariosTurma2
            // 
            this.cmbHorariosTurma2.FormattingEnabled = true;
            this.cmbHorariosTurma2.Location = new System.Drawing.Point(353, 263);
            this.cmbHorariosTurma2.Name = "cmbHorariosTurma2";
            this.cmbHorariosTurma2.Size = new System.Drawing.Size(121, 21);
            this.cmbHorariosTurma2.TabIndex = 93;
            // 
            // cmbHorariosTurma1
            // 
            this.cmbHorariosTurma1.FormattingEnabled = true;
            this.cmbHorariosTurma1.Location = new System.Drawing.Point(353, 236);
            this.cmbHorariosTurma1.Name = "cmbHorariosTurma1";
            this.cmbHorariosTurma1.Size = new System.Drawing.Size(121, 21);
            this.cmbHorariosTurma1.TabIndex = 92;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DeepPink;
            this.btnOk.Enabled = false;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(651, 339);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 27);
            this.btnOk.TabIndex = 95;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(228, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 96;
            this.label3.Text = "Valor Mensal:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(351, 339);
            this.maskedTextBox2.Mask = "$000,00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(62, 20);
            this.maskedTextBox2.TabIndex = 99;
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbHorariosTurma3);
            this.Controls.Add(this.cmbHorariosTurma2);
            this.Controls.Add(this.cmbHorariosTurma1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDiasdaSemana3);
            this.Controls.Add(this.cmbDiasdaSemana2);
            this.Controls.Add(this.lblDiasSemana);
            this.Controls.Add(this.cmbDiasdaSemana1);
            this.Controls.Add(this.lblTresAulas);
            this.Controls.Add(this.rbTresAulas);
            this.Controls.Add(this.lblDuasAulas);
            this.Controls.Add(this.rbDuasAulas);
            this.Controls.Add(this.lblUmaAula);
            this.Controls.Add(this.rbUmaAula);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.maskDataFinal);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.maskDataInicial);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.lblAnual);
            this.Controls.Add(this.rbAnual);
            this.Controls.Add(this.lblSemestral);
            this.Controls.Add(this.rbSemestral);
            this.Controls.Add(this.label2lblTrimestral);
            this.Controls.Add(this.rbTrimestral);
            this.Controls.Add(this.lblMensal);
            this.Controls.Add(this.rbMensal);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnCadastrarProfessor);
            this.Controls.Add(this.btnExcluirProfessor);
            this.Controls.Add(this.btnEditarProfessor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFecharTela);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirProfessor;
        private System.Windows.Forms.Button btnEditarProfessor;
        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.RadioButton rbMensal;
        private System.Windows.Forms.Label lblMensal;
        private System.Windows.Forms.RadioButton rbTrimestral;
        private System.Windows.Forms.Label label2lblTrimestral;
        private System.Windows.Forms.RadioButton rbSemestral;
        private System.Windows.Forms.Label lblSemestral;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.Label lblAnual;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.MaskedTextBox maskDataInicial;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.MaskedTextBox maskDataFinal;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.RadioButton rbUmaAula;
        private System.Windows.Forms.Label lblUmaAula;
        private System.Windows.Forms.RadioButton rbDuasAulas;
        private System.Windows.Forms.Label lblDuasAulas;
        private System.Windows.Forms.RadioButton rbTresAulas;
        private System.Windows.Forms.Label lblTresAulas;
        private System.Windows.Forms.ComboBox cmbDiasdaSemana1;
        private System.Windows.Forms.Label lblDiasSemana;
        private System.Windows.Forms.ComboBox cmbDiasdaSemana2;
        private System.Windows.Forms.ComboBox cmbDiasdaSemana3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHorariosTurma3;
        private System.Windows.Forms.ComboBox cmbHorariosTurma2;
        private System.Windows.Forms.ComboBox cmbHorariosTurma1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}
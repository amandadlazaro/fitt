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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.rbMensal = new System.Windows.Forms.RadioButton();
            this.rbTrimestral = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.rbSemestral = new System.Windows.Forms.RadioButton();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.rbAula3 = new System.Windows.Forms.RadioButton();
            this.rbAula2 = new System.Windows.Forms.RadioButton();
            this.rbAula1 = new System.Windows.Forms.RadioButton();
            this.panelTipo = new System.Windows.Forms.Panel();
            this.panelAulas = new System.Windows.Forms.Panel();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblAulas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblValorMensal = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblHoraTurma = new System.Windows.Forms.Label();
            this.cmbTurma1 = new System.Windows.Forms.ComboBox();
            this.cmbSemana1 = new System.Windows.Forms.ComboBox();
            this.cmbSemana2 = new System.Windows.Forms.ComboBox();
            this.cmbTurma2 = new System.Windows.Forms.ComboBox();
            this.cmbSemana3 = new System.Windows.Forms.ComboBox();
            this.cmbTurma3 = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.maskCel = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtValorMensal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskDataInicial = new System.Windows.Forms.DateTimePicker();
            this.maskDataFinal = new System.Windows.Forms.DateTimePicker();
            this.maskDataNasc = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelTipo.SuspendLayout();
            this.panelAulas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharTela.BackgroundImage")));
            this.btnFecharTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharTela.FlatAppearance.BorderSize = 0;
            this.btnFecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTela.Location = new System.Drawing.Point(713, 4);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(25, 25);
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
            this.pictureBox3.Location = new System.Drawing.Point(0, 308);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 73);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F);
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "MATRÍCULA";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(652, 350);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 31);
            this.btnExcluir.TabIndex = 42;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblNome.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(91, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 24);
            this.lblNome.TabIndex = 96;
            this.lblNome.Text = "Nome";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblSexo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblSexo.Location = new System.Drawing.Point(237, 251);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 24);
            this.lblSexo.TabIndex = 98;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblEndereco.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblEndereco.Location = new System.Drawing.Point(93, 203);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(65, 24);
            this.lblEndereco.TabIndex = 101;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNasc.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblDataNasc.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDataNasc.Location = new System.Drawing.Point(91, 103);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(138, 25);
            this.lblDataNasc.TabIndex = 101;
            this.lblDataNasc.Text = "Data de Nascimento";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblCPF.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblCPF.Location = new System.Drawing.Point(93, 252);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(32, 24);
            this.lblCPF.TabIndex = 102;
            this.lblCPF.Text = "CPF";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblCelular.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblCelular.Location = new System.Drawing.Point(234, 104);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(51, 24);
            this.lblCelular.TabIndex = 102;
            this.lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblEmail.Location = new System.Drawing.Point(91, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 24);
            this.lblEmail.TabIndex = 102;
            this.lblEmail.Text = "Email";
            // 
            // rbMensal
            // 
            this.rbMensal.AutoSize = true;
            this.rbMensal.Checked = true;
            this.rbMensal.Font = new System.Drawing.Font("Agency FB", 15F);
            this.rbMensal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbMensal.Location = new System.Drawing.Point(7, 0);
            this.rbMensal.Name = "rbMensal";
            this.rbMensal.Size = new System.Drawing.Size(68, 28);
            this.rbMensal.TabIndex = 141;
            this.rbMensal.TabStop = true;
            this.rbMensal.Text = "Mensal";
            this.rbMensal.UseVisualStyleBackColor = true;
            this.rbMensal.CheckedChanged += new System.EventHandler(this.Tipos_CheckedChanged);
            // 
            // rbTrimestral
            // 
            this.rbTrimestral.AutoSize = true;
            this.rbTrimestral.Font = new System.Drawing.Font("Agency FB", 15F);
            this.rbTrimestral.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbTrimestral.Location = new System.Drawing.Point(7, 23);
            this.rbTrimestral.Name = "rbTrimestral";
            this.rbTrimestral.Size = new System.Drawing.Size(87, 28);
            this.rbTrimestral.TabIndex = 143;
            this.rbTrimestral.Text = "Trimestral";
            this.rbTrimestral.UseVisualStyleBackColor = true;
            this.rbTrimestral.CheckedChanged += new System.EventHandler(this.Tipos_CheckedChanged);
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Font = new System.Drawing.Font("Agency FB", 15F);
            this.rbAnual.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbAnual.Location = new System.Drawing.Point(7, 73);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(59, 28);
            this.rbAnual.TabIndex = 142;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            this.rbAnual.CheckedChanged += new System.EventHandler(this.Tipos_CheckedChanged);
            // 
            // rbSemestral
            // 
            this.rbSemestral.AutoSize = true;
            this.rbSemestral.Font = new System.Drawing.Font("Agency FB", 15F);
            this.rbSemestral.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbSemestral.Location = new System.Drawing.Point(7, 49);
            this.rbSemestral.Name = "rbSemestral";
            this.rbSemestral.Size = new System.Drawing.Size(82, 28);
            this.rbSemestral.TabIndex = 144;
            this.rbSemestral.Text = "Semestal";
            this.rbSemestral.UseVisualStyleBackColor = true;
            this.rbSemestral.CheckedChanged += new System.EventHandler(this.Tipos_CheckedChanged);
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblDataFinal.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblDataFinal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDataFinal.Location = new System.Drawing.Point(399, 163);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(66, 24);
            this.lblDataFinal.TabIndex = 107;
            this.lblDataFinal.Text = "Data Final";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblDataInicial.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblDataInicial.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDataInicial.Location = new System.Drawing.Point(395, 130);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(73, 24);
            this.lblDataInicial.TabIndex = 108;
            this.lblDataInicial.Text = "Data Inicial";
            // 
            // rbAula3
            // 
            this.rbAula3.AutoSize = true;
            this.rbAula3.Font = new System.Drawing.Font("Agency FB", 15F);
            this.rbAula3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbAula3.Location = new System.Drawing.Point(119, 3);
            this.rbAula3.Name = "rbAula3";
            this.rbAula3.Size = new System.Drawing.Size(36, 28);
            this.rbAula3.TabIndex = 138;
            this.rbAula3.Text = "3";
            this.rbAula3.UseVisualStyleBackColor = true;
            this.rbAula3.CheckedChanged += new System.EventHandler(this.rbAula3_CheckedChanged);
            // 
            // rbAula2
            // 
            this.rbAula2.AutoSize = true;
            this.rbAula2.Font = new System.Drawing.Font("Agency FB", 15F);
            this.rbAula2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbAula2.Location = new System.Drawing.Point(65, 3);
            this.rbAula2.Name = "rbAula2";
            this.rbAula2.Size = new System.Drawing.Size(36, 28);
            this.rbAula2.TabIndex = 137;
            this.rbAula2.Text = "2";
            this.rbAula2.UseVisualStyleBackColor = true;
            this.rbAula2.CheckedChanged += new System.EventHandler(this.rbAula2_CheckedChanged);
            // 
            // rbAula1
            // 
            this.rbAula1.AutoSize = true;
            this.rbAula1.Checked = true;
            this.rbAula1.Font = new System.Drawing.Font("Agency FB", 15F);
            this.rbAula1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rbAula1.Location = new System.Drawing.Point(14, 3);
            this.rbAula1.Name = "rbAula1";
            this.rbAula1.Size = new System.Drawing.Size(31, 28);
            this.rbAula1.TabIndex = 136;
            this.rbAula1.TabStop = true;
            this.rbAula1.Text = "1";
            this.rbAula1.UseVisualStyleBackColor = true;
            this.rbAula1.CheckedChanged += new System.EventHandler(this.rbAula1_CheckedChanged);
            // 
            // panelTipo
            // 
            this.panelTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTipo.Controls.Add(this.rbMensal);
            this.panelTipo.Controls.Add(this.rbTrimestral);
            this.panelTipo.Controls.Add(this.rbAnual);
            this.panelTipo.Controls.Add(this.rbSemestral);
            this.panelTipo.Location = new System.Drawing.Point(584, 80);
            this.panelTipo.Name = "panelTipo";
            this.panelTipo.Size = new System.Drawing.Size(98, 106);
            this.panelTipo.TabIndex = 112;
            // 
            // panelAulas
            // 
            this.panelAulas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAulas.Controls.Add(this.rbAula1);
            this.panelAulas.Controls.Add(this.rbAula2);
            this.panelAulas.Controls.Add(this.rbAula3);
            this.panelAulas.Location = new System.Drawing.Point(403, 80);
            this.panelAulas.Name = "panelAulas";
            this.panelAulas.Size = new System.Drawing.Size(171, 31);
            this.panelAulas.TabIndex = 113;
            // 
            // cmbSexo
            // 
            this.cmbSexo.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(240, 277);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(108, 22);
            this.cmbSexo.TabIndex = 135;
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.BackColor = System.Drawing.Color.Transparent;
            this.lblAulas.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblAulas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblAulas.Location = new System.Drawing.Point(399, 53);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(116, 24);
            this.lblAulas.TabIndex = 117;
            this.lblAulas.Text = "Aulas por Semana";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTipo.Location = new System.Drawing.Point(580, 53);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 24);
            this.lblTipo.TabIndex = 118;
            this.lblTipo.Text = "Tipo";
            // 
            // lblValorMensal
            // 
            this.lblValorMensal.AutoSize = true;
            this.lblValorMensal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorMensal.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblValorMensal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblValorMensal.Location = new System.Drawing.Point(305, 339);
            this.lblValorMensal.Name = "lblValorMensal";
            this.lblValorMensal.Size = new System.Drawing.Size(84, 24);
            this.lblValorMensal.TabIndex = 119;
            this.lblValorMensal.Text = "Valor Mensal";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaSemana.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblDiaSemana.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDiaSemana.Location = new System.Drawing.Point(398, 203);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(104, 24);
            this.lblDiaSemana.TabIndex = 121;
            this.lblDiaSemana.Text = "Dias da Semana";
            // 
            // lblHoraTurma
            // 
            this.lblHoraTurma.AutoSize = true;
            this.lblHoraTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraTurma.Font = new System.Drawing.Font("Agency FB", 15F);
            this.lblHoraTurma.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblHoraTurma.Location = new System.Drawing.Point(519, 201);
            this.lblHoraTurma.Name = "lblHoraTurma";
            this.lblHoraTurma.Size = new System.Drawing.Size(90, 24);
            this.lblHoraTurma.TabIndex = 122;
            this.lblHoraTurma.Text = "Hora/Turmas";
            // 
            // cmbTurma1
            // 
            this.cmbTurma1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurma1.FormattingEnabled = true;
            this.cmbTurma1.Location = new System.Drawing.Point(512, 228);
            this.cmbTurma1.Name = "cmbTurma1";
            this.cmbTurma1.Size = new System.Drawing.Size(100, 22);
            this.cmbTurma1.TabIndex = 146;
            // 
            // cmbSemana1
            // 
            this.cmbSemana1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemana1.FormattingEnabled = true;
            this.cmbSemana1.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta"});
            this.cmbSemana1.Location = new System.Drawing.Point(399, 230);
            this.cmbSemana1.Name = "cmbSemana1";
            this.cmbSemana1.Size = new System.Drawing.Size(100, 22);
            this.cmbSemana1.TabIndex = 145;
            this.cmbSemana1.SelectedIndexChanged += new System.EventHandler(this.cmbSemana1_SelectedIndexChanged);
            // 
            // cmbSemana2
            // 
            this.cmbSemana2.Enabled = false;
            this.cmbSemana2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemana2.FormattingEnabled = true;
            this.cmbSemana2.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta"});
            this.cmbSemana2.Location = new System.Drawing.Point(399, 257);
            this.cmbSemana2.Name = "cmbSemana2";
            this.cmbSemana2.Size = new System.Drawing.Size(100, 22);
            this.cmbSemana2.TabIndex = 147;
            this.cmbSemana2.SelectedIndexChanged += new System.EventHandler(this.cmbSemana2_SelectedIndexChanged);
            // 
            // cmbTurma2
            // 
            this.cmbTurma2.Enabled = false;
            this.cmbTurma2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurma2.FormattingEnabled = true;
            this.cmbTurma2.Location = new System.Drawing.Point(512, 256);
            this.cmbTurma2.Name = "cmbTurma2";
            this.cmbTurma2.Size = new System.Drawing.Size(100, 22);
            this.cmbTurma2.TabIndex = 148;
            // 
            // cmbSemana3
            // 
            this.cmbSemana3.Enabled = false;
            this.cmbSemana3.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemana3.FormattingEnabled = true;
            this.cmbSemana3.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta"});
            this.cmbSemana3.Location = new System.Drawing.Point(399, 284);
            this.cmbSemana3.Name = "cmbSemana3";
            this.cmbSemana3.Size = new System.Drawing.Size(100, 22);
            this.cmbSemana3.TabIndex = 149;
            this.cmbSemana3.SelectedIndexChanged += new System.EventHandler(this.cmbSemana3_SelectedIndexChanged);
            // 
            // cmbTurma3
            // 
            this.cmbTurma3.Enabled = false;
            this.cmbTurma3.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurma3.FormattingEnabled = true;
            this.cmbTurma3.Location = new System.Drawing.Point(512, 284);
            this.cmbTurma3.Name = "cmbTurma3";
            this.cmbTurma3.Size = new System.Drawing.Size(100, 22);
            this.cmbTurma3.TabIndex = 150;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(95, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 22);
            this.txtNome.TabIndex = 129;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiltrarLetraMaiuscula);
            // 
            // maskCel
            // 
            this.maskCel.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCel.Location = new System.Drawing.Point(238, 131);
            this.maskCel.Mask = "(99)0000-0000";
            this.maskCel.Name = "maskCel";
            this.maskCel.Size = new System.Drawing.Size(108, 22);
            this.maskCel.TabIndex = 131;
            this.maskCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(95, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 22);
            this.txtEmail.TabIndex = 132;
            // 
            // maskCPF
            // 
            this.maskCPF.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCPF.Location = new System.Drawing.Point(95, 279);
            this.maskCPF.Mask = "999.999.999-99";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(115, 22);
            this.maskCPF.TabIndex = 134;
            this.maskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(95, 230);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(251, 22);
            this.txtEndereco.TabIndex = 133;
            // 
            // txtValorMensal
            // 
            this.txtValorMensal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorMensal.Font = new System.Drawing.Font("Agency FB", 15F);
            this.txtValorMensal.Location = new System.Drawing.Point(421, 339);
            this.txtValorMensal.Name = "txtValorMensal";
            this.txtValorMensal.Size = new System.Drawing.Size(94, 24);
            this.txtValorMensal.TabIndex = 151;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(395, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 152;
            this.label2.Text = "R$";
            // 
            // maskDataInicial
            // 
            this.maskDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.maskDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.maskDataInicial.Location = new System.Drawing.Point(474, 133);
            this.maskDataInicial.Name = "maskDataInicial";
            this.maskDataInicial.Size = new System.Drawing.Size(100, 21);
            this.maskDataInicial.TabIndex = 154;
            // 
            // maskDataFinal
            // 
            this.maskDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.maskDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.maskDataFinal.Location = new System.Drawing.Point(474, 166);
            this.maskDataFinal.Name = "maskDataFinal";
            this.maskDataFinal.Size = new System.Drawing.Size(100, 21);
            this.maskDataFinal.TabIndex = 155;
            // 
            // maskDataNasc
            // 
            this.maskDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.maskDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.maskDataNasc.Location = new System.Drawing.Point(95, 130);
            this.maskDataNasc.Name = "maskDataNasc";
            this.maskDataNasc.Size = new System.Drawing.Size(100, 21);
            this.maskDataNasc.TabIndex = 156;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Font = new System.Drawing.Font("Agency FB", 15F);
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.Location = new System.Drawing.Point(250, 49);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(96, 28);
            this.cbStatus.TabIndex = 157;
            this.cbStatus.Text = "Matriculado";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCadastrar.Location = new System.Drawing.Point(652, 350);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 31);
            this.btnCadastrar.TabIndex = 158;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnSalvar.ForeColor = System.Drawing.Color.DeepPink;
            this.btnSalvar.Location = new System.Drawing.Point(566, 350);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 31);
            this.btnSalvar.TabIndex = 159;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(0, -2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 38);
            this.btnVoltar.TabIndex = 160;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.maskDataNasc);
            this.Controls.Add(this.maskDataFinal);
            this.Controls.Add(this.maskDataInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorMensal);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.maskCel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbTurma3);
            this.Controls.Add(this.cmbSemana3);
            this.Controls.Add(this.cmbTurma2);
            this.Controls.Add(this.cmbSemana2);
            this.Controls.Add(this.cmbSemana1);
            this.Controls.Add(this.cmbTurma1);
            this.Controls.Add(this.lblHoraTurma);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.lblValorMensal);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.panelAulas);
            this.Controls.Add(this.panelTipo);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFecharTela);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelTipo.ResumeLayout(false);
            this.panelTipo.PerformLayout();
            this.panelAulas.ResumeLayout(false);
            this.panelAulas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RadioButton rbMensal;
        private System.Windows.Forms.RadioButton rbTrimestral;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.RadioButton rbSemestral;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.RadioButton rbAula3;
        private System.Windows.Forms.RadioButton rbAula2;
        private System.Windows.Forms.RadioButton rbAula1;
        private System.Windows.Forms.Panel panelTipo;
        private System.Windows.Forms.Panel panelAulas;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblValorMensal;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblHoraTurma;
        private System.Windows.Forms.ComboBox cmbTurma1;
        private System.Windows.Forms.ComboBox cmbSemana1;
        private System.Windows.Forms.ComboBox cmbSemana2;
        private System.Windows.Forms.ComboBox cmbTurma2;
        private System.Windows.Forms.ComboBox cmbSemana3;
        private System.Windows.Forms.ComboBox cmbTurma3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox maskCel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtValorMensal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker maskDataInicial;
        private System.Windows.Forms.DateTimePicker maskDataFinal;
        private System.Windows.Forms.DateTimePicker maskDataNasc;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
    }
}
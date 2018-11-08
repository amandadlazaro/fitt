namespace FittSistema.View
{
    partial class FrmTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbDiaSemana = new System.Windows.Forms.ComboBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.tabSemanas = new System.Windows.Forms.TabControl();
            this.Segunda = new System.Windows.Forms.TabPage();
            this.grpSegunda = new System.Windows.Forms.DataGridView();
            this.tabTerca = new System.Windows.Forms.TabPage();
            this.grpTerca = new System.Windows.Forms.DataGridView();
            this.tabQuarta = new System.Windows.Forms.TabPage();
            this.grpQuarta = new System.Windows.Forms.DataGridView();
            this.tabQuinta = new System.Windows.Forms.TabPage();
            this.grpQuinta = new System.Windows.Forms.DataGridView();
            this.tabSexta = new System.Windows.Forms.TabPage();
            this.grpSexta = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabSemanas.SuspendLayout();
            this.Segunda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSegunda)).BeginInit();
            this.tabTerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTerca)).BeginInit();
            this.tabQuarta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuarta)).BeginInit();
            this.tabQuinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuinta)).BeginInit();
            this.tabSexta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSexta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharTela.BackgroundImage")));
            this.btnFecharTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharTela.FlatAppearance.BorderSize = 0;
            this.btnFecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTela.Location = new System.Drawing.Point(698, -1);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(45, 36);
            this.btnFecharTela.TabIndex = 12;
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
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCadastrar.Location = new System.Drawing.Point(651, 338);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 27);
            this.btnCadastrar.TabIndex = 47;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(-1, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 40);
            this.label2.TabIndex = 50;
            this.label2.Text = "Turmas";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.BackColor = System.Drawing.Color.Transparent;
            this.lblProfessor.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblProfessor.Location = new System.Drawing.Point(114, 105);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(74, 25);
            this.lblProfessor.TabIndex = 52;
            this.lblProfessor.Text = "Professor:";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(214, 109);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(369, 21);
            this.cmbProfessor.TabIndex = 53;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaSemana.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDiaSemana.Location = new System.Drawing.Point(119, 149);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(63, 50);
            this.lblDiaSemana.TabIndex = 54;
            this.lblDiaSemana.Text = "Dia da\r\nSemana:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblHorario.Location = new System.Drawing.Point(119, 226);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(60, 25);
            this.lblHorario.TabIndex = 56;
            this.lblHorario.Text = "Horário:";
            // 
            // cmbDiaSemana
            // 
            this.cmbDiaSemana.FormattingEnabled = true;
            this.cmbDiaSemana.Location = new System.Drawing.Point(214, 168);
            this.cmbDiaSemana.Name = "cmbDiaSemana";
            this.cmbDiaSemana.Size = new System.Drawing.Size(369, 21);
            this.cmbDiaSemana.TabIndex = 57;
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(214, 228);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(369, 21);
            this.cmbHorario.TabIndex = 58;
            // 
            // tabSemanas
            // 
            this.tabSemanas.Controls.Add(this.Segunda);
            this.tabSemanas.Controls.Add(this.tabTerca);
            this.tabSemanas.Controls.Add(this.tabQuarta);
            this.tabSemanas.Controls.Add(this.tabQuinta);
            this.tabSemanas.Controls.Add(this.tabSexta);
            this.tabSemanas.Location = new System.Drawing.Point(88, 87);
            this.tabSemanas.Name = "tabSemanas";
            this.tabSemanas.SelectedIndex = 0;
            this.tabSemanas.Size = new System.Drawing.Size(589, 198);
            this.tabSemanas.TabIndex = 59;
            // 
            // Segunda
            // 
            this.Segunda.Controls.Add(this.grpSegunda);
            this.Segunda.Location = new System.Drawing.Point(4, 22);
            this.Segunda.Name = "Segunda";
            this.Segunda.Padding = new System.Windows.Forms.Padding(3);
            this.Segunda.Size = new System.Drawing.Size(581, 172);
            this.Segunda.TabIndex = 0;
            this.Segunda.Text = "Segunda";
            this.Segunda.UseVisualStyleBackColor = true;
            // 
            // grpSegunda
            // 
            this.grpSegunda.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grpSegunda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpSegunda.GridColor = System.Drawing.Color.LightCoral;
            this.grpSegunda.Location = new System.Drawing.Point(58, 24);
            this.grpSegunda.Name = "grpSegunda";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grpSegunda.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grpSegunda.Size = new System.Drawing.Size(486, 139);
            this.grpSegunda.TabIndex = 72;
            this.grpSegunda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpSegunda_CellDoubleClick_1);
            // 
            // tabTerca
            // 
            this.tabTerca.Controls.Add(this.grpTerca);
            this.tabTerca.Location = new System.Drawing.Point(4, 22);
            this.tabTerca.Name = "tabTerca";
            this.tabTerca.Padding = new System.Windows.Forms.Padding(3);
            this.tabTerca.Size = new System.Drawing.Size(581, 172);
            this.tabTerca.TabIndex = 1;
            this.tabTerca.Text = "Terça";
            this.tabTerca.UseVisualStyleBackColor = true;
            // 
            // grpTerca
            // 
            this.grpTerca.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grpTerca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpTerca.GridColor = System.Drawing.Color.LightCoral;
            this.grpTerca.Location = new System.Drawing.Point(58, 24);
            this.grpTerca.Name = "grpTerca";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grpTerca.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grpTerca.Size = new System.Drawing.Size(486, 139);
            this.grpTerca.TabIndex = 71;
            this.grpTerca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpTerca_CellDoubleClick);
            // 
            // tabQuarta
            // 
            this.tabQuarta.Controls.Add(this.grpQuarta);
            this.tabQuarta.Location = new System.Drawing.Point(4, 22);
            this.tabQuarta.Name = "tabQuarta";
            this.tabQuarta.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuarta.Size = new System.Drawing.Size(581, 172);
            this.tabQuarta.TabIndex = 2;
            this.tabQuarta.Text = "Quarta";
            this.tabQuarta.UseVisualStyleBackColor = true;
            // 
            // grpQuarta
            // 
            this.grpQuarta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grpQuarta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpQuarta.GridColor = System.Drawing.Color.LightCoral;
            this.grpQuarta.Location = new System.Drawing.Point(58, 24);
            this.grpQuarta.Name = "grpQuarta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grpQuarta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grpQuarta.Size = new System.Drawing.Size(486, 139);
            this.grpQuarta.TabIndex = 71;
            this.grpQuarta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpQuarta_CellDoubleClick);
            // 
            // tabQuinta
            // 
            this.tabQuinta.Controls.Add(this.grpQuinta);
            this.tabQuinta.Location = new System.Drawing.Point(4, 22);
            this.tabQuinta.Name = "tabQuinta";
            this.tabQuinta.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuinta.Size = new System.Drawing.Size(581, 172);
            this.tabQuinta.TabIndex = 3;
            this.tabQuinta.Text = "Quinta";
            this.tabQuinta.UseVisualStyleBackColor = true;
            // 
            // grpQuinta
            // 
            this.grpQuinta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grpQuinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpQuinta.GridColor = System.Drawing.Color.LightCoral;
            this.grpQuinta.Location = new System.Drawing.Point(58, 24);
            this.grpQuinta.Name = "grpQuinta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grpQuinta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grpQuinta.Size = new System.Drawing.Size(486, 139);
            this.grpQuinta.TabIndex = 71;
            this.grpQuinta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpQuinta_CellDoubleClick);
            // 
            // tabSexta
            // 
            this.tabSexta.Controls.Add(this.grpSexta);
            this.tabSexta.Location = new System.Drawing.Point(4, 22);
            this.tabSexta.Name = "tabSexta";
            this.tabSexta.Padding = new System.Windows.Forms.Padding(3);
            this.tabSexta.Size = new System.Drawing.Size(581, 172);
            this.tabSexta.TabIndex = 4;
            this.tabSexta.Text = "Sexta";
            this.tabSexta.UseVisualStyleBackColor = true;
            // 
            // grpSexta
            // 
            this.grpSexta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grpSexta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpSexta.GridColor = System.Drawing.Color.LightCoral;
            this.grpSexta.Location = new System.Drawing.Point(58, 24);
            this.grpSexta.Name = "grpSexta";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grpSexta.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grpSexta.Size = new System.Drawing.Size(486, 139);
            this.grpSexta.TabIndex = 71;
            this.grpSexta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpSexta_CellDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.DeepPink;
            this.btnExcluir.Location = new System.Drawing.Point(651, 338);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 27);
            this.btnExcluir.TabIndex = 61;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.DeepPink;
            this.btnEditar.Location = new System.Drawing.Point(556, 338);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 27);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(12, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 63;
            this.txtId.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(665, -1);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(38, 36);
            this.btnVoltar.TabIndex = 64;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.tabSemanas);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.cmbDiaSemana);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.cmbProfessor);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFecharTela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turma";
            this.Load += new System.EventHandler(this.FrmTurma_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabSemanas.ResumeLayout(false);
            this.Segunda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSegunda)).EndInit();
            this.tabTerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpTerca)).EndInit();
            this.tabQuarta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpQuarta)).EndInit();
            this.tabQuinta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpQuinta)).EndInit();
            this.tabSexta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSexta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cmbDiaSemana;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.TabControl tabSemanas;
        private System.Windows.Forms.TabPage Segunda;
        private System.Windows.Forms.TabPage tabTerca;
        private System.Windows.Forms.TabPage tabQuarta;
        private System.Windows.Forms.TabPage tabQuinta;
        private System.Windows.Forms.TabPage tabSexta;
        private System.Windows.Forms.DataGridView grpTerca;
        private System.Windows.Forms.DataGridView grpQuarta;
        private System.Windows.Forms.DataGridView grpQuinta;
        private System.Windows.Forms.DataGridView grpSexta;
        private System.Windows.Forms.DataGridView grpSegunda;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Button btnVoltar;
    }
}
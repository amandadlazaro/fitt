﻿namespace FittSistema.View
{
    partial class FrmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.txtAdministrador = new System.Windows.Forms.TextBox();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.btnCadastrarAdministrador = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.grpAdministrador = new System.Windows.Forms.DataGridView();
            this.btnEditarAdministrador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grpAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdministrador
            // 
            this.txtAdministrador.Location = new System.Drawing.Point(3, 87);
            this.txtAdministrador.Name = "txtAdministrador";
            this.txtAdministrador.Size = new System.Drawing.Size(482, 20);
            this.txtAdministrador.TabIndex = 83;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.ForeColor = System.Drawing.Color.DeepPink;
            this.lblAdministrador.Location = new System.Drawing.Point(-4, 31);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(217, 37);
            this.lblAdministrador.TabIndex = 79;
            this.lblAdministrador.Text = "Administrador";
            // 
            // btnCadastrarAdministrador
            // 
            this.btnCadastrarAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrarAdministrador.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAdministrador.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCadastrarAdministrador.Location = new System.Drawing.Point(632, 346);
            this.btnCadastrarAdministrador.Name = "btnCadastrarAdministrador";
            this.btnCadastrarAdministrador.Size = new System.Drawing.Size(56, 43);
            this.btnCadastrarAdministrador.TabIndex = 75;
            this.btnCadastrarAdministrador.UseVisualStyleBackColor = false;
            this.btnCadastrarAdministrador.Click += new System.EventHandler(this.btnCadastrarAdministrador_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(47, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 86;
            this.label6.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 20);
            this.txtEmail.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(116, 199);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(384, 20);
            this.txtSenha.TabIndex = 87;
            // 
            // grpAdministrador
            // 
            this.grpAdministrador.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grpAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpAdministrador.Location = new System.Drawing.Point(-5, 113);
            this.grpAdministrador.Name = "grpAdministrador";
            this.grpAdministrador.Size = new System.Drawing.Size(732, 178);
            this.grpAdministrador.TabIndex = 89;
            this.grpAdministrador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpAdministrador_CellClick);
            this.grpAdministrador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpAdministrador_CellDoubleClick);
            // 
            // btnEditarAdministrador
            // 
            this.btnEditarAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAdministrador.ForeColor = System.Drawing.Color.DeepPink;
            this.btnEditarAdministrador.Location = new System.Drawing.Point(608, 354);
            this.btnEditarAdministrador.Name = "btnEditarAdministrador";
            this.btnEditarAdministrador.Size = new System.Drawing.Size(119, 27);
            this.btnEditarAdministrador.TabIndex = 90;
            this.btnEditarAdministrador.Text = "Salvar alterações";
            this.btnEditarAdministrador.UseVisualStyleBackColor = false;
            this.btnEditarAdministrador.Visible = false;
            this.btnEditarAdministrador.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 73);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.Transparent;
            this.btnBusca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBusca.BackgroundImage")));
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Location = new System.Drawing.Point(491, 86);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(32, 20);
            this.btnBusca.TabIndex = 94;
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharTela.BackgroundImage")));
            this.btnFecharTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharTela.FlatAppearance.BorderSize = 0;
            this.btnFecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTela.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFecharTela.Location = new System.Drawing.Point(692, 0);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(45, 36);
            this.btnFecharTela.TabIndex = 92;
            this.btnFecharTela.UseVisualStyleBackColor = true;
            this.btnFecharTela.Click += new System.EventHandler(this.btnFecharTela_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(649, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(38, 36);
            this.btnVoltar.TabIndex = 93;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFecharTela);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEditarAdministrador);
            this.Controls.Add(this.grpAdministrador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdministrador);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.btnCadastrarAdministrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrador";
            this.Text = "FrmAdministrador";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAdministrador;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Button btnCadastrarAdministrador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.DataGridView grpAdministrador;
        private System.Windows.Forms.Button btnEditarAdministrador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.Button btnVoltar;
    }
}
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEditarAdministrador = new System.Windows.Forms.Button();
            this.grpAdministrador = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFecharForm = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrarAdministrador = new System.Windows.Forms.Button();
            this.btnExcluirAdm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grpAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Agency FB", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(116, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 86;
            this.label6.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(169, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 25);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(117, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 88;
            this.label1.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtSenha.Location = new System.Drawing.Point(169, 197);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(384, 25);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // btnEditarAdministrador
            // 
            this.btnEditarAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAdministrador.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnEditarAdministrador.ForeColor = System.Drawing.Color.DeepPink;
            this.btnEditarAdministrador.Location = new System.Drawing.Point(566, 350);
            this.btnEditarAdministrador.Name = "btnEditarAdministrador";
            this.btnEditarAdministrador.Size = new System.Drawing.Size(80, 31);
            this.btnEditarAdministrador.TabIndex = 4;
            this.btnEditarAdministrador.Text = "Salvar";
            this.btnEditarAdministrador.UseVisualStyleBackColor = false;
            this.btnEditarAdministrador.Visible = false;
            this.btnEditarAdministrador.Click += new System.EventHandler(this.btnEditarAdministrador_Click);
            // 
            // grpAdministrador
            // 
            this.grpAdministrador.AllowUserToAddRows = false;
            this.grpAdministrador.AllowUserToDeleteRows = false;
            this.grpAdministrador.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grpAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grpAdministrador.Location = new System.Drawing.Point(0, 92);
            this.grpAdministrador.Name = "grpAdministrador";
            this.grpAdministrador.ReadOnly = true;
            this.grpAdministrador.Size = new System.Drawing.Size(750, 203);
            this.grpAdministrador.TabIndex = 89;
            this.grpAdministrador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grpAdministrador_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(43, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 42);
            this.label2.TabIndex = 97;
            this.label2.Text = "ADMINISTRADOR";
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
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 73);
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            // 
            // btnFecharForm
            // 
            this.btnFecharForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharForm.BackgroundImage")));
            this.btnFecharForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharForm.FlatAppearance.BorderSize = 0;
            this.btnFecharForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharForm.Location = new System.Drawing.Point(713, 4);
            this.btnFecharForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFecharForm.Name = "btnFecharForm";
            this.btnFecharForm.Size = new System.Drawing.Size(25, 25);
            this.btnFecharForm.TabIndex = 6;
            this.btnFecharForm.UseVisualStyleBackColor = true;
            this.btnFecharForm.Click += new System.EventHandler(this.btnFecharTela_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(0, -2);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 38);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // btnCadastrarAdministrador
            // 
            this.btnCadastrarAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAdministrador.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnCadastrarAdministrador.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCadastrarAdministrador.Location = new System.Drawing.Point(652, 350);
            this.btnCadastrarAdministrador.Name = "btnCadastrarAdministrador";
            this.btnCadastrarAdministrador.Size = new System.Drawing.Size(80, 31);
            this.btnCadastrarAdministrador.TabIndex = 3;
            this.btnCadastrarAdministrador.Text = "Cadastrar";
            this.btnCadastrarAdministrador.UseVisualStyleBackColor = false;
            this.btnCadastrarAdministrador.Click += new System.EventHandler(this.btnCadastrarAdministrador_Click);
            // 
            // btnExcluirAdm
            // 
            this.btnExcluirAdm.BackColor = System.Drawing.Color.DeepPink;
            this.btnExcluirAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAdm.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnExcluirAdm.ForeColor = System.Drawing.Color.White;
            this.btnExcluirAdm.Location = new System.Drawing.Point(652, 350);
            this.btnExcluirAdm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExcluirAdm.Name = "btnExcluirAdm";
            this.btnExcluirAdm.Size = new System.Drawing.Size(80, 31);
            this.btnExcluirAdm.TabIndex = 102;
            this.btnExcluirAdm.Text = "Excluir";
            this.btnExcluirAdm.UseVisualStyleBackColor = false;
            this.btnExcluirAdm.Visible = false;
            this.btnExcluirAdm.Click += new System.EventHandler(this.btnExcluirAdm_Click);
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.btnExcluirAdm);
            this.Controls.Add(this.btnCadastrarAdministrador);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFecharForm);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditarAdministrador);
            this.Controls.Add(this.grpAdministrador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrador";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEditarAdministrador;
        private System.Windows.Forms.DataGridView grpAdministrador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFecharForm;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrarAdministrador;
        private System.Windows.Forms.Button btnExcluirAdm;
    }
}
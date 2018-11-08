namespace FittSistema.View
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnTurma = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnFecharPgm = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.Color.White;
            this.btnAlunos.CausesValidation = false;
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunos.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.ForeColor = System.Drawing.Color.DeepPink;
            this.btnAlunos.Location = new System.Drawing.Point(141, 80);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(122, 83);
            this.btnAlunos.TabIndex = 2;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunosMatriculados_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurma.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurma.ForeColor = System.Drawing.Color.DeepPink;
            this.btnTurma.Location = new System.Drawing.Point(307, 80);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(122, 83);
            this.btnTurma.TabIndex = 4;
            this.btnTurma.Text = "Turma";
            this.btnTurma.UseVisualStyleBackColor = true;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessor.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.Color.DeepPink;
            this.btnProfessor.Location = new System.Drawing.Point(402, 208);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(122, 83);
            this.btnProfessor.TabIndex = 5;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.Color.DeepPink;
            this.btnPagamento.Location = new System.Drawing.Point(465, 80);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(122, 83);
            this.btnPagamento.TabIndex = 7;
            this.btnPagamento.Text = "Pagamentos";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnFecharPgm
            // 
            this.btnFecharPgm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharPgm.BackgroundImage")));
            this.btnFecharPgm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharPgm.FlatAppearance.BorderSize = 0;
            this.btnFecharPgm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharPgm.Location = new System.Drawing.Point(700, 0);
            this.btnFecharPgm.Name = "btnFecharPgm";
            this.btnFecharPgm.Size = new System.Drawing.Size(45, 36);
            this.btnFecharPgm.TabIndex = 10;
            this.btnFecharPgm.UseVisualStyleBackColor = true;
            this.btnFecharPgm.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 74);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.DeepPink;
            this.btnAdmin.Location = new System.Drawing.Point(223, 208);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(122, 83);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFecharPgm);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.btnTurma);
            this.Controls.Add(this.btnAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnFecharPgm;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAdmin;
    }
}
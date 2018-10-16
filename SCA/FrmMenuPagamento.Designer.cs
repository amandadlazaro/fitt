namespace FittSistema.View
{
    partial class FrmMenuPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPagamento));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnFecharPgm = new System.Windows.Forms.Button();
            this.btnBoletos = new System.Windows.Forms.Button();
            this.btnRecibos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 302);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 74);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(1, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(38, 36);
            this.btnLogOut.TabIndex = 39;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnFecharPgm
            // 
            this.btnFecharPgm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharPgm.BackgroundImage")));
            this.btnFecharPgm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharPgm.FlatAppearance.BorderSize = 0;
            this.btnFecharPgm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharPgm.Location = new System.Drawing.Point(755, 0);
            this.btnFecharPgm.Name = "btnFecharPgm";
            this.btnFecharPgm.Size = new System.Drawing.Size(45, 36);
            this.btnFecharPgm.TabIndex = 38;
            this.btnFecharPgm.UseVisualStyleBackColor = true;
            // 
            // btnBoletos
            // 
            this.btnBoletos.BackColor = System.Drawing.Color.White;
            this.btnBoletos.CausesValidation = false;
            this.btnBoletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoletos.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletos.ForeColor = System.Drawing.Color.DeepPink;
            this.btnBoletos.Location = new System.Drawing.Point(182, 131);
            this.btnBoletos.Name = "btnBoletos";
            this.btnBoletos.Size = new System.Drawing.Size(182, 104);
            this.btnBoletos.TabIndex = 37;
            this.btnBoletos.Text = "BOLETOS";
            this.btnBoletos.UseVisualStyleBackColor = false;
            // 
            // btnRecibos
            // 
            this.btnRecibos.BackColor = System.Drawing.Color.White;
            this.btnRecibos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibos.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibos.ForeColor = System.Drawing.Color.DeepPink;
            this.btnRecibos.Location = new System.Drawing.Point(417, 131);
            this.btnRecibos.Name = "btnRecibos";
            this.btnRecibos.Size = new System.Drawing.Size(182, 104);
            this.btnRecibos.TabIndex = 36;
            this.btnRecibos.Text = "RECIBOS";
            this.btnRecibos.UseVisualStyleBackColor = false;
            // 
            // FrmMenuPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnFecharPgm);
            this.Controls.Add(this.btnBoletos);
            this.Controls.Add(this.btnRecibos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPagamento";
            this.Text = "FrmMenuPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnFecharPgm;
        private System.Windows.Forms.Button btnBoletos;
        private System.Windows.Forms.Button btnRecibos;
    }
}
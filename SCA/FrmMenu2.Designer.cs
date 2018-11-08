namespace FittSistema.View
{
    partial class FrmMenu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu2));
            this.btnAnamnese = new System.Windows.Forms.Button();
            this.btnFecharPgm = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnamnese
            // 
            this.btnAnamnese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnamnese.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnamnese.ForeColor = System.Drawing.Color.DeepPink;
            this.btnAnamnese.Location = new System.Drawing.Point(300, 141);
            this.btnAnamnese.Name = "btnAnamnese";
            this.btnAnamnese.Size = new System.Drawing.Size(122, 83);
            this.btnAnamnese.TabIndex = 4;
            this.btnAnamnese.Text = "Anamnese";
            this.btnAnamnese.UseVisualStyleBackColor = true;
            this.btnAnamnese.Click += new System.EventHandler(this.btnTurma_Click);
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
            // FrmMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnFecharPgm);
            this.Controls.Add(this.btnAnamnese);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmMenu2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAnamnese;
        private System.Windows.Forms.Button btnFecharPgm;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
namespace ÁREA_NUTRICIONAL_HOSPITAL_SAN_ISIDRO_PEREIRA
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.txtBxUsuario = new System.Windows.Forms.TextBox();
            this.txtBxContraseña = new System.Windows.Forms.TextBox();
            this.bttnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pctrBxHospital = new System.Windows.Forms.PictureBox();
            this.pnlfondohs = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lnkLblOlvidoContraseña = new System.Windows.Forms.LinkLabel();
            this.pctrBxcerrar = new System.Windows.Forms.PictureBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxHospital)).BeginInit();
            this.pnlfondohs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxUsuario
            // 
            this.txtBxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtBxUsuario.Location = new System.Drawing.Point(474, 93);
            this.txtBxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxUsuario.Name = "txtBxUsuario";
            this.txtBxUsuario.Size = new System.Drawing.Size(278, 37);
            this.txtBxUsuario.TabIndex = 2;
            // 
            // txtBxContraseña
            // 
            this.txtBxContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtBxContraseña.Location = new System.Drawing.Point(474, 145);
            this.txtBxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxContraseña.Name = "txtBxContraseña";
            this.txtBxContraseña.Size = new System.Drawing.Size(278, 37);
            this.txtBxContraseña.TabIndex = 3;
            this.txtBxContraseña.UseSystemPasswordChar = true;
            // 
            // bttnIngresar
            // 
            this.bttnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bttnIngresar.FlatAppearance.BorderSize = 0;
            this.bttnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bttnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnIngresar.ForeColor = System.Drawing.Color.LightGray;
            this.bttnIngresar.Location = new System.Drawing.Point(273, 222);
            this.bttnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnIngresar.Name = "bttnIngresar";
            this.bttnIngresar.Size = new System.Drawing.Size(479, 36);
            this.bttnIngresar.TabIndex = 4;
            this.bttnIngresar.Text = "ACCEDER";
            this.bttnIngresar.UseVisualStyleBackColor = false;
            this.bttnIngresar.Click += new System.EventHandler(this.bttnIngresar_Click);
            // 
            // 
            // pctrBxHospital
            // 
            this.pctrBxHospital.BackColor = System.Drawing.Color.Transparent;
            this.pctrBxHospital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctrBxHospital.Image = ((System.Drawing.Image)(resources.GetObject("pctrBxHospital.Image")));
            this.pctrBxHospital.Location = new System.Drawing.Point(39, 86);
            this.pctrBxHospital.Name = "pctrBxHospital";
            this.pctrBxHospital.Size = new System.Drawing.Size(151, 138);
            this.pctrBxHospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxHospital.TabIndex = 8;
            this.pctrBxHospital.TabStop = false;
            // 
            // pnlfondohs
            // 
            this.pnlfondohs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlfondohs.BackgroundImage")));
            this.pnlfondohs.Controls.Add(this.pctrBxHospital);
            this.pnlfondohs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlfondohs.Location = new System.Drawing.Point(0, 0);
            this.pnlfondohs.Name = "pnlfondohs";
            this.pnlfondohs.Size = new System.Drawing.Size(250, 330);
            this.pnlfondohs.TabIndex = 9;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.ForeColor = System.Drawing.Color.Gray;
            this.lbltitulo.Location = new System.Drawing.Point(437, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(151, 49);
            this.lbltitulo.TabIndex = 10;
            this.lbltitulo.Text = "LOGIN";
            // 
            // lnkLblOlvidoContraseña
            // 
            this.lnkLblOlvidoContraseña.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lnkLblOlvidoContraseña.AutoSize = true;
            this.lnkLblOlvidoContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkLblOlvidoContraseña.LinkColor = System.Drawing.Color.DimGray;
            this.lnkLblOlvidoContraseña.Location = new System.Drawing.Point(353, 279);
            this.lnkLblOlvidoContraseña.Name = "lnkLblOlvidoContraseña";
            this.lnkLblOlvidoContraseña.Size = new System.Drawing.Size(325, 30);
            this.lnkLblOlvidoContraseña.TabIndex = 11;
            this.lnkLblOlvidoContraseña.TabStop = true;
            this.lnkLblOlvidoContraseña.Text = "Haz olvidado contraseña?";
            this.lnkLblOlvidoContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblOlvidoContraseña_LinkClicked);
            // 
            // pctrBxcerrar
            // 
            this.pctrBxcerrar.Image = ((System.Drawing.Image)(resources.GetObject("pctrBxcerrar.Image")));
            this.pctrBxcerrar.Location = new System.Drawing.Point(747, 12);
            this.pctrBxcerrar.Name = "pctrBxcerrar";
            this.pctrBxcerrar.Size = new System.Drawing.Size(15, 15);
            this.pctrBxcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxcerrar.TabIndex = 12;
            this.pctrBxcerrar.TabStop = false;
            this.pctrBxcerrar.Click += new System.EventHandler(this.pctrBxcerrar_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblusuario.ForeColor = System.Drawing.Color.Gray;
            this.lblusuario.Location = new System.Drawing.Point(293, 95);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(116, 30);
            this.lblusuario.TabIndex = 13;
            this.lblusuario.Text = "USUARIO";
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcontra.ForeColor = System.Drawing.Color.Gray;
            this.lblcontra.Location = new System.Drawing.Point(273, 145);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(175, 30);
            this.lblcontra.TabIndex = 14;
            this.lblcontra.Text = "CONTRASEÑA";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 330);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.pctrBxcerrar);
            this.Controls.Add(this.lnkLblOlvidoContraseña);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.pnlfondohs);
            this.Controls.Add(this.bttnIngresar);
            this.Controls.Add(this.txtBxContraseña);
            this.Controls.Add(this.txtBxUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxHospital)).EndInit();
            this.pnlfondohs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtBxUsuario;
        private TextBox txtBxContraseña;
        private Button bttnIngresar;
        private Label label1;
        private PictureBox pctrBxHospital;
        private Panel pnlfondohs;
        private Label lbltitulo;
        private LinkLabel lnkLblOlvidoContraseña;
        private PictureBox pctrBxcerrar;
        private Label lblusuario;
        private Label lblcontra;
    }
}
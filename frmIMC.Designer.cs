namespace ÁREA_NUTRICIONAL_HOSPITAL_SAN_ISIDRO_PEREIRA
{
    partial class frmIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIMC));
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.txtBxPeso = new System.Windows.Forms.TextBox();
            this.txtBxEstatura = new System.Windows.Forms.TextBox();
            this.bttncalcular = new System.Windows.Forms.Button();
            this.bttnsalir = new System.Windows.Forms.Button();
            this.lblnutricion = new System.Windows.Forms.Label();
            this.lblimc = new System.Windows.Forms.Label();
            this.lstBxNutricion = new System.Windows.Forms.ListBox();
            this.lstBxIMC = new System.Windows.Forms.ListBox();
            this.bttnregresar = new System.Windows.Forms.Button();
            this.pnlfondohs = new System.Windows.Forms.Panel();
            this.pctrBxHospital = new System.Windows.Forms.PictureBox();
            this.pnlfondo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pnlfondohs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxHospital)).BeginInit();
            this.pnlfondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.ForeColor = System.Drawing.Color.White;
            this.lblPeso.Location = new System.Drawing.Point(327, 204);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(169, 30);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Ingresar Peso";
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.ForeColor = System.Drawing.Color.White;
            this.lblEstatura.Location = new System.Drawing.Point(322, 276);
            this.lblEstatura.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(206, 30);
            this.lblEstatura.TabIndex = 1;
            this.lblEstatura.Text = "Ingresar Estatura";
            // 
            // txtBxPeso
            // 
            this.txtBxPeso.BackColor = System.Drawing.Color.LightGray;
            this.txtBxPeso.ForeColor = System.Drawing.Color.Black;
            this.txtBxPeso.Location = new System.Drawing.Point(564, 201);
            this.txtBxPeso.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBxPeso.Name = "txtBxPeso";
            this.txtBxPeso.Size = new System.Drawing.Size(215, 37);
            this.txtBxPeso.TabIndex = 2;
            this.txtBxPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxPeso_KeyPress);
            // 
            // txtBxEstatura
            // 
            this.txtBxEstatura.BackColor = System.Drawing.Color.LightGray;
            this.txtBxEstatura.Location = new System.Drawing.Point(564, 273);
            this.txtBxEstatura.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBxEstatura.Name = "txtBxEstatura";
            this.txtBxEstatura.Size = new System.Drawing.Size(215, 37);
            this.txtBxEstatura.TabIndex = 3;
            this.txtBxEstatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxEstatura_KeyPress);
            // 
            // bttncalcular
            // 
            this.bttncalcular.BackColor = System.Drawing.Color.DarkCyan;
            this.bttncalcular.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttncalcular.ForeColor = System.Drawing.Color.White;
            this.bttncalcular.Location = new System.Drawing.Point(856, 217);
            this.bttncalcular.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bttncalcular.Name = "bttncalcular";
            this.bttncalcular.Size = new System.Drawing.Size(189, 74);
            this.bttncalcular.TabIndex = 4;
            this.bttncalcular.Text = "Calcular";
            this.bttncalcular.UseVisualStyleBackColor = false;
            this.bttncalcular.Click += new System.EventHandler(this.bttncalcular_Click);
            // 
            // bttnsalir
            // 
            this.bttnsalir.BackColor = System.Drawing.Color.DarkCyan;
            this.bttnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnsalir.FlatAppearance.BorderSize = 0;
            this.bttnsalir.ForeColor = System.Drawing.Color.White;
            this.bttnsalir.Location = new System.Drawing.Point(1220, 606);
            this.bttnsalir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bttnsalir.Name = "bttnsalir";
            this.bttnsalir.Size = new System.Drawing.Size(165, 43);
            this.bttnsalir.TabIndex = 5;
            this.bttnsalir.Text = "Salir";
            this.bttnsalir.UseVisualStyleBackColor = false;
            this.bttnsalir.Click += new System.EventHandler(this.bttnsalir_Click);
            // 
            // lblnutricion
            // 
            this.lblnutricion.AutoSize = true;
            this.lblnutricion.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnutricion.ForeColor = System.Drawing.Color.White;
            this.lblnutricion.Location = new System.Drawing.Point(500, 413);
            this.lblnutricion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblnutricion.Name = "lblnutricion";
            this.lblnutricion.Size = new System.Drawing.Size(263, 34);
            this.lblnutricion.TabIndex = 6;
            this.lblnutricion.Text = "Estado Nutricional";
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblimc.ForeColor = System.Drawing.Color.White;
            this.lblimc.Location = new System.Drawing.Point(1107, 413);
            this.lblimc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(69, 34);
            this.lblimc.TabIndex = 8;
            this.lblimc.Text = "IMC";
            // 
            // lstBxNutricion
            // 
            this.lstBxNutricion.BackColor = System.Drawing.Color.Gray;
            this.lstBxNutricion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBxNutricion.ForeColor = System.Drawing.Color.White;
            this.lstBxNutricion.FormattingEnabled = true;
            this.lstBxNutricion.ItemHeight = 30;
            this.lstBxNutricion.Location = new System.Drawing.Point(454, 458);
            this.lstBxNutricion.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lstBxNutricion.Name = "lstBxNutricion";
            this.lstBxNutricion.Size = new System.Drawing.Size(360, 90);
            this.lstBxNutricion.TabIndex = 9;
            // 
            // lstBxIMC
            // 
            this.lstBxIMC.BackColor = System.Drawing.Color.Gray;
            this.lstBxIMC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBxIMC.ForeColor = System.Drawing.Color.White;
            this.lstBxIMC.FormattingEnabled = true;
            this.lstBxIMC.ItemHeight = 30;
            this.lstBxIMC.Location = new System.Drawing.Point(947, 458);
            this.lstBxIMC.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lstBxIMC.Name = "lstBxIMC";
            this.lstBxIMC.Size = new System.Drawing.Size(360, 90);
            this.lstBxIMC.TabIndex = 10;
            // 
            // bttnregresar
            // 
            this.bttnregresar.BackColor = System.Drawing.Color.DarkCyan;
            this.bttnregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnregresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnregresar.FlatAppearance.BorderSize = 0;
            this.bttnregresar.ForeColor = System.Drawing.Color.White;
            this.bttnregresar.Location = new System.Drawing.Point(313, 100);
            this.bttnregresar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bttnregresar.Name = "bttnregresar";
            this.bttnregresar.Size = new System.Drawing.Size(165, 43);
            this.bttnregresar.TabIndex = 11;
            this.bttnregresar.Text = "Regresar";
            this.bttnregresar.UseVisualStyleBackColor = false;
            this.bttnregresar.Click += new System.EventHandler(this.bttnregresar_Click);
            // 
            // pnlfondohs
            // 
            this.pnlfondohs.BackColor = System.Drawing.Color.Transparent;
            this.pnlfondohs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlfondohs.BackgroundImage")));
            this.pnlfondohs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlfondohs.Controls.Add(this.pctrBxHospital);
            this.pnlfondohs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlfondohs.Location = new System.Drawing.Point(0, 0);
            this.pnlfondohs.Margin = new System.Windows.Forms.Padding(4);
            this.pnlfondohs.Name = "pnlfondohs";
            this.pnlfondohs.Size = new System.Drawing.Size(312, 674);
            this.pnlfondohs.TabIndex = 50;
            // 
            // pctrBxHospital
            // 
            this.pctrBxHospital.BackColor = System.Drawing.Color.Transparent;
            this.pctrBxHospital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctrBxHospital.Image = ((System.Drawing.Image)(resources.GetObject("pctrBxHospital.Image")));
            this.pctrBxHospital.Location = new System.Drawing.Point(0, 131);
            this.pctrBxHospital.Margin = new System.Windows.Forms.Padding(4);
            this.pctrBxHospital.Name = "pctrBxHospital";
            this.pctrBxHospital.Size = new System.Drawing.Size(317, 289);
            this.pctrBxHospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxHospital.TabIndex = 8;
            this.pctrBxHospital.TabStop = false;
            // 
            // pnlfondo
            // 
            this.pnlfondo.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlfondo.Controls.Add(this.lbltitulo);
            this.pnlfondo.Location = new System.Drawing.Point(313, 0);
            this.pnlfondo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlfondo.Name = "pnlfondo";
            this.pnlfondo.Size = new System.Drawing.Size(1085, 100);
            this.pnlfondo.TabIndex = 51;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(7, 18);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(1070, 61);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "CALCULO DEL INDICE DE MASA CORPORAL";
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1400, 674);
            this.Controls.Add(this.pnlfondo);
            this.Controls.Add(this.pnlfondohs);
            this.Controls.Add(this.bttnregresar);
            this.Controls.Add(this.lstBxIMC);
            this.Controls.Add(this.lstBxNutricion);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.lblnutricion);
            this.Controls.Add(this.bttnsalir);
            this.Controls.Add(this.bttncalcular);
            this.Controls.Add(this.txtBxEstatura);
            this.Controls.Add(this.txtBxPeso);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.lblPeso);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmIMC";
            this.ShowIcon = false;
            this.Text = "INDICE DE MASA CORPORAL";
            this.pnlfondohs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxHospital)).EndInit();
            this.pnlfondo.ResumeLayout(false);
            this.pnlfondo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPeso;
        private Label lblEstatura;
        private TextBox txtBxPeso;
        private TextBox txtBxEstatura;
        private Button bttncalcular;
        private Button bttnsalir;
        private Label lblnutricion;
        private Label lblimc;
        private ListBox lstBxNutricion;
        private ListBox lstBxIMC;
        private Button bttnregresar;
        private Panel pnlfondohs;
        private PictureBox pctrBxHospital;
        private Panel pnlfondo;
        private Label lbltitulo;
    }
}
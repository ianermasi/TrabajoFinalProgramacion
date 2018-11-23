namespace CapaUsuario
{
    partial class FormPostres
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostres));
            this.PNLOpciones = new System.Windows.Forms.Panel();
            this.BTNConfirmar = new System.Windows.Forms.Button();
            this.PNLContenedor = new System.Windows.Forms.Panel();
            this.LBLNombre = new System.Windows.Forms.Label();
            this.Sundae = new System.Windows.Forms.Panel();
            this.Cono_Relleno = new System.Windows.Forms.Panel();
            this.Cono = new System.Windows.Forms.Panel();
            this.King_Mix = new System.Windows.Forms.Panel();
            this.Cucuruchones = new System.Windows.Forms.Panel();
            this.IMLPostres = new System.Windows.Forms.ImageList(this.components);
            this.PNLOpciones.SuspendLayout();
            this.PNLContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNLOpciones
            // 
            this.PNLOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLOpciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PNLOpciones.Controls.Add(this.BTNConfirmar);
            this.PNLOpciones.Location = new System.Drawing.Point(1, 207);
            this.PNLOpciones.Name = "PNLOpciones";
            this.PNLOpciones.Size = new System.Drawing.Size(830, 147);
            this.PNLOpciones.TabIndex = 8;
            // 
            // BTNConfirmar
            // 
            this.BTNConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.BTNConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNConfirmar.FlatAppearance.BorderSize = 0;
            this.BTNConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTNConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConfirmar.ForeColor = System.Drawing.Color.White;
            this.BTNConfirmar.Location = new System.Drawing.Point(659, 114);
            this.BTNConfirmar.Name = "BTNConfirmar";
            this.BTNConfirmar.Size = new System.Drawing.Size(162, 30);
            this.BTNConfirmar.TabIndex = 54;
            this.BTNConfirmar.Text = "Confirmar";
            this.BTNConfirmar.UseVisualStyleBackColor = false;
            this.BTNConfirmar.Click += new System.EventHandler(this.BTNConfirmar_Click);
            // 
            // PNLContenedor
            // 
            this.PNLContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLContenedor.Controls.Add(this.LBLNombre);
            this.PNLContenedor.Controls.Add(this.Sundae);
            this.PNLContenedor.Controls.Add(this.Cono_Relleno);
            this.PNLContenedor.Controls.Add(this.Cono);
            this.PNLContenedor.Controls.Add(this.King_Mix);
            this.PNLContenedor.Controls.Add(this.Cucuruchones);
            this.PNLContenedor.Location = new System.Drawing.Point(1, 3);
            this.PNLContenedor.Name = "PNLContenedor";
            this.PNLContenedor.Size = new System.Drawing.Size(830, 203);
            this.PNLContenedor.TabIndex = 7;
            // 
            // LBLNombre
            // 
            this.LBLNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNombre.Location = new System.Drawing.Point(10, 139);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(490, 61);
            this.LBLNombre.TabIndex = 16;
            this.LBLNombre.Text = ".";
            // 
            // Sundae
            // 
            this.Sundae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sundae.Location = new System.Drawing.Point(482, 8);
            this.Sundae.Name = "Sundae";
            this.Sundae.Size = new System.Drawing.Size(100, 100);
            this.Sundae.TabIndex = 10;
            this.Sundae.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cucuruchones_MouseClick);
            // 
            // Cono_Relleno
            // 
            this.Cono_Relleno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cono_Relleno.Location = new System.Drawing.Point(364, 8);
            this.Cono_Relleno.Name = "Cono_Relleno";
            this.Cono_Relleno.Size = new System.Drawing.Size(100, 100);
            this.Cono_Relleno.TabIndex = 10;
            this.Cono_Relleno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cucuruchones_MouseClick);
            // 
            // Cono
            // 
            this.Cono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cono.Location = new System.Drawing.Point(246, 8);
            this.Cono.Name = "Cono";
            this.Cono.Size = new System.Drawing.Size(100, 100);
            this.Cono.TabIndex = 10;
            this.Cono.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cucuruchones_MouseClick);
            // 
            // King_Mix
            // 
            this.King_Mix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.King_Mix.Location = new System.Drawing.Point(128, 8);
            this.King_Mix.Name = "King_Mix";
            this.King_Mix.Size = new System.Drawing.Size(100, 100);
            this.King_Mix.TabIndex = 10;
            this.King_Mix.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cucuruchones_MouseClick);
            // 
            // Cucuruchones
            // 
            this.Cucuruchones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cucuruchones.Location = new System.Drawing.Point(10, 8);
            this.Cucuruchones.Name = "Cucuruchones";
            this.Cucuruchones.Size = new System.Drawing.Size(100, 100);
            this.Cucuruchones.TabIndex = 9;
            this.Cucuruchones.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cucuruchones_MouseClick);
            // 
            // IMLPostres
            // 
            this.IMLPostres.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMLPostres.ImageStream")));
            this.IMLPostres.TransparentColor = System.Drawing.Color.Transparent;
            this.IMLPostres.Images.SetKeyName(0, "500x540_cucuruchones.png");
            this.IMLPostres.Images.SetKeyName(1, "500x540_king-mix.png");
            this.IMLPostres.Images.SetKeyName(2, "BK_Web_CONO_500X540px.png");
            this.IMLPostres.Images.SetKeyName(3, "BK_Web_CONOS_RELLENOS_500X540px_0.png");
            this.IMLPostres.Images.SetKeyName(4, "BK_Web_SUNDAE_500X540px.png");
            // 
            // FormPostres
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 371);
            this.Controls.Add(this.PNLOpciones);
            this.Controls.Add(this.PNLContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPostres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormPostres";
            this.PNLOpciones.ResumeLayout(false);
            this.PNLContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLOpciones;
        private System.Windows.Forms.Panel PNLContenedor;
        private System.Windows.Forms.ImageList IMLPostres;
        private System.Windows.Forms.Panel Sundae;
        private System.Windows.Forms.Panel Cono_Relleno;
        private System.Windows.Forms.Panel Cono;
        private System.Windows.Forms.Panel King_Mix;
        private System.Windows.Forms.Panel Cucuruchones;
        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.Button BTNConfirmar;
    }
}
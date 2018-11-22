namespace CapaUsuario
{
    partial class FormBebidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBebidas));
            this.PNLContenedor = new System.Windows.Forms.Panel();
            this.Sprite_Light = new System.Windows.Forms.Panel();
            this.Sprite = new System.Windows.Forms.Panel();
            this.Fanta = new System.Windows.Forms.Panel();
            this.Coca_Cola_Light = new System.Windows.Forms.Panel();
            this.Coca_Cola = new System.Windows.Forms.Panel();
            this.Aquarius = new System.Windows.Forms.Panel();
            this.PNLOpciones = new System.Windows.Forms.Panel();
            this.LBLTamaño = new System.Windows.Forms.Label();
            this.RBTNGrande = new System.Windows.Forms.RadioButton();
            this.RBTNMediano = new System.Windows.Forms.RadioButton();
            this.RBTNPequeño = new System.Windows.Forms.RadioButton();
            this.IMLBebidas = new System.Windows.Forms.ImageList(this.components);
            this.BTNConfirmar = new System.Windows.Forms.Button();
            this.PNLContenedor.SuspendLayout();
            this.PNLOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNLContenedor
            // 
            this.PNLContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLContenedor.Controls.Add(this.BTNConfirmar);
            this.PNLContenedor.Controls.Add(this.Sprite_Light);
            this.PNLContenedor.Controls.Add(this.Sprite);
            this.PNLContenedor.Controls.Add(this.Fanta);
            this.PNLContenedor.Controls.Add(this.Coca_Cola_Light);
            this.PNLContenedor.Controls.Add(this.Coca_Cola);
            this.PNLContenedor.Controls.Add(this.Aquarius);
            this.PNLContenedor.Controls.Add(this.PNLOpciones);
            this.PNLContenedor.Location = new System.Drawing.Point(1, 3);
            this.PNLContenedor.Name = "PNLContenedor";
            this.PNLContenedor.Size = new System.Drawing.Size(829, 367);
            this.PNLContenedor.TabIndex = 0;
            // 
            // Sprite_Light
            // 
            this.Sprite_Light.Location = new System.Drawing.Point(709, 9);
            this.Sprite_Light.Name = "Sprite_Light";
            this.Sprite_Light.Size = new System.Drawing.Size(100, 100);
            this.Sprite_Light.TabIndex = 8;
            this.Sprite_Light.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aquarius_MouseClick);
            // 
            // Sprite
            // 
            this.Sprite.Location = new System.Drawing.Point(578, 9);
            this.Sprite.Name = "Sprite";
            this.Sprite.Size = new System.Drawing.Size(100, 100);
            this.Sprite.TabIndex = 8;
            this.Sprite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aquarius_MouseClick);
            // 
            // Fanta
            // 
            this.Fanta.Location = new System.Drawing.Point(428, 9);
            this.Fanta.Name = "Fanta";
            this.Fanta.Size = new System.Drawing.Size(100, 100);
            this.Fanta.TabIndex = 8;
            this.Fanta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aquarius_MouseClick);
            // 
            // Coca_Cola_Light
            // 
            this.Coca_Cola_Light.Location = new System.Drawing.Point(288, 9);
            this.Coca_Cola_Light.Name = "Coca_Cola_Light";
            this.Coca_Cola_Light.Size = new System.Drawing.Size(100, 100);
            this.Coca_Cola_Light.TabIndex = 8;
            this.Coca_Cola_Light.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aquarius_MouseClick);
            // 
            // Coca_Cola
            // 
            this.Coca_Cola.Location = new System.Drawing.Point(148, 9);
            this.Coca_Cola.Name = "Coca_Cola";
            this.Coca_Cola.Size = new System.Drawing.Size(100, 100);
            this.Coca_Cola.TabIndex = 8;
            this.Coca_Cola.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aquarius_MouseClick);
            // 
            // Aquarius
            // 
            this.Aquarius.Location = new System.Drawing.Point(11, 9);
            this.Aquarius.Name = "Aquarius";
            this.Aquarius.Size = new System.Drawing.Size(100, 100);
            this.Aquarius.TabIndex = 7;
            this.Aquarius.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Aquarius_MouseClick);
            // 
            // PNLOpciones
            // 
            this.PNLOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLOpciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PNLOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLOpciones.Controls.Add(this.LBLTamaño);
            this.PNLOpciones.Controls.Add(this.RBTNGrande);
            this.PNLOpciones.Controls.Add(this.RBTNMediano);
            this.PNLOpciones.Controls.Add(this.RBTNPequeño);
            this.PNLOpciones.Location = new System.Drawing.Point(553, 215);
            this.PNLOpciones.Name = "PNLOpciones";
            this.PNLOpciones.Size = new System.Drawing.Size(107, 147);
            this.PNLOpciones.TabIndex = 6;
            // 
            // LBLTamaño
            // 
            this.LBLTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLTamaño.AutoSize = true;
            this.LBLTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTamaño.Location = new System.Drawing.Point(15, 19);
            this.LBLTamaño.Name = "LBLTamaño";
            this.LBLTamaño.Size = new System.Drawing.Size(67, 20);
            this.LBLTamaño.TabIndex = 15;
            this.LBLTamaño.Text = "Tamaño";
            // 
            // RBTNGrande
            // 
            this.RBTNGrande.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTNGrande.AutoSize = true;
            this.RBTNGrande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNGrande.Location = new System.Drawing.Point(3, 100);
            this.RBTNGrande.Name = "RBTNGrande";
            this.RBTNGrande.Size = new System.Drawing.Size(81, 24);
            this.RBTNGrande.TabIndex = 4;
            this.RBTNGrande.TabStop = true;
            this.RBTNGrande.Text = "Grande";
            this.RBTNGrande.UseVisualStyleBackColor = true;
            // 
            // RBTNMediano
            // 
            this.RBTNMediano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTNMediano.AutoSize = true;
            this.RBTNMediano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNMediano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNMediano.Location = new System.Drawing.Point(3, 73);
            this.RBTNMediano.Name = "RBTNMediano";
            this.RBTNMediano.Size = new System.Drawing.Size(88, 24);
            this.RBTNMediano.TabIndex = 3;
            this.RBTNMediano.TabStop = true;
            this.RBTNMediano.Text = "Mediano";
            this.RBTNMediano.UseVisualStyleBackColor = true;
            // 
            // RBTNPequeño
            // 
            this.RBTNPequeño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTNPequeño.AutoSize = true;
            this.RBTNPequeño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNPequeño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNPequeño.Location = new System.Drawing.Point(3, 49);
            this.RBTNPequeño.Name = "RBTNPequeño";
            this.RBTNPequeño.Size = new System.Drawing.Size(91, 24);
            this.RBTNPequeño.TabIndex = 2;
            this.RBTNPequeño.TabStop = true;
            this.RBTNPequeño.Text = "Pequeño";
            this.RBTNPequeño.UseVisualStyleBackColor = true;
            // 
            // IMLBebidas
            // 
            this.IMLBebidas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMLBebidas.ImageStream")));
            this.IMLBebidas.TransparentColor = System.Drawing.Color.Transparent;
            this.IMLBebidas.Images.SetKeyName(0, "aquarius.png");
            this.IMLBebidas.Images.SetKeyName(1, "Coca-cola.png");
            this.IMLBebidas.Images.SetKeyName(2, "Coca-Cola-Light.png");
            this.IMLBebidas.Images.SetKeyName(3, "Fanta.png");
            this.IMLBebidas.Images.SetKeyName(4, "Sprite.png");
            this.IMLBebidas.Images.SetKeyName(5, "Sprite_Zero.png");
            // 
            // BTNConfirmar
            // 
            this.BTNConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.BTNConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNConfirmar.FlatAppearance.BorderSize = 0;
            this.BTNConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTNConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNConfirmar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConfirmar.ForeColor = System.Drawing.Color.White;
            this.BTNConfirmar.Location = new System.Drawing.Point(662, 332);
            this.BTNConfirmar.Name = "BTNConfirmar";
            this.BTNConfirmar.Size = new System.Drawing.Size(162, 30);
            this.BTNConfirmar.TabIndex = 56;
            this.BTNConfirmar.Text = "Confirmar";
            this.BTNConfirmar.UseVisualStyleBackColor = false;
            // 
            // FormBebidas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 371);
            this.Controls.Add(this.PNLContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBebidas";
            this.Text = "FormBebidas";
            this.PNLContenedor.ResumeLayout(false);
            this.PNLOpciones.ResumeLayout(false);
            this.PNLOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLContenedor;
        private System.Windows.Forms.Panel PNLOpciones;
        private System.Windows.Forms.Label LBLTamaño;
        private System.Windows.Forms.RadioButton RBTNGrande;
        private System.Windows.Forms.RadioButton RBTNMediano;
        private System.Windows.Forms.RadioButton RBTNPequeño;
        private System.Windows.Forms.Panel Sprite_Light;
        private System.Windows.Forms.Panel Sprite;
        private System.Windows.Forms.Panel Fanta;
        private System.Windows.Forms.Panel Coca_Cola_Light;
        private System.Windows.Forms.Panel Coca_Cola;
        private System.Windows.Forms.Panel Aquarius;
        private System.Windows.Forms.ImageList IMLBebidas;
        private System.Windows.Forms.Button BTNConfirmar;
    }
}
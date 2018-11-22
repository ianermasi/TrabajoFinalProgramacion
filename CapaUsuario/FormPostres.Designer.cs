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
            this.PNLOpciones = new System.Windows.Forms.Panel();
            this.LBLSalsa = new System.Windows.Forms.Label();
            this.RBTNFrutilla = new System.Windows.Forms.RadioButton();
            this.RBTNChocolate = new System.Windows.Forms.RadioButton();
            this.RBTNDulce = new System.Windows.Forms.RadioButton();
            this.PNLContenedor = new System.Windows.Forms.Panel();
            this.LBLHelado = new System.Windows.Forms.Label();
            this.RBTNMixto = new System.Windows.Forms.RadioButton();
            this.RBTNDulceDeLeche = new System.Windows.Forms.RadioButton();
            this.RBTNVainilla = new System.Windows.Forms.RadioButton();
            this.PNLContHelado = new System.Windows.Forms.Panel();
            this.PNLContSalsa = new System.Windows.Forms.Panel();
            this.PNLOpciones.SuspendLayout();
            this.PNLContHelado.SuspendLayout();
            this.PNLContSalsa.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNLOpciones
            // 
            this.PNLOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLOpciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PNLOpciones.Controls.Add(this.PNLContSalsa);
            this.PNLOpciones.Controls.Add(this.PNLContHelado);
            this.PNLOpciones.Location = new System.Drawing.Point(12, 207);
            this.PNLOpciones.Name = "PNLOpciones";
            this.PNLOpciones.Size = new System.Drawing.Size(810, 147);
            this.PNLOpciones.TabIndex = 8;
            // 
            // LBLSalsa
            // 
            this.LBLSalsa.AutoSize = true;
            this.LBLSalsa.Font = new System.Drawing.Font("Insaniburger with Cheese", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSalsa.Location = new System.Drawing.Point(73, 16);
            this.LBLSalsa.Name = "LBLSalsa";
            this.LBLSalsa.Size = new System.Drawing.Size(51, 17);
            this.LBLSalsa.TabIndex = 15;
            this.LBLSalsa.Text = "Salsa";
            this.LBLSalsa.Click += new System.EventHandler(this.LBLSalsa_Click);
            // 
            // RBTNFrutilla
            // 
            this.RBTNFrutilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RBTNFrutilla.AutoSize = true;
            this.RBTNFrutilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNFrutilla.Font = new System.Drawing.Font("Insaniburger with Cheese", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNFrutilla.Location = new System.Drawing.Point(12, 99);
            this.RBTNFrutilla.Name = "RBTNFrutilla";
            this.RBTNFrutilla.Size = new System.Drawing.Size(88, 21);
            this.RBTNFrutilla.TabIndex = 4;
            this.RBTNFrutilla.TabStop = true;
            this.RBTNFrutilla.Text = "Frutilla";
            this.RBTNFrutilla.UseVisualStyleBackColor = true;
            this.RBTNFrutilla.CheckedChanged += new System.EventHandler(this.RBTNFrutilla_CheckedChanged);
            // 
            // RBTNChocolate
            // 
            this.RBTNChocolate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RBTNChocolate.AutoSize = true;
            this.RBTNChocolate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNChocolate.Font = new System.Drawing.Font("Insaniburger with Cheese", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNChocolate.Location = new System.Drawing.Point(12, 72);
            this.RBTNChocolate.Name = "RBTNChocolate";
            this.RBTNChocolate.Size = new System.Drawing.Size(112, 21);
            this.RBTNChocolate.TabIndex = 3;
            this.RBTNChocolate.TabStop = true;
            this.RBTNChocolate.Text = "Chocolate";
            this.RBTNChocolate.UseVisualStyleBackColor = true;
            this.RBTNChocolate.CheckedChanged += new System.EventHandler(this.RBTNChocolate_CheckedChanged);
            // 
            // RBTNDulce
            // 
            this.RBTNDulce.AutoSize = true;
            this.RBTNDulce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNDulce.Font = new System.Drawing.Font("Insaniburger with Cheese", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNDulce.Location = new System.Drawing.Point(12, 48);
            this.RBTNDulce.Name = "RBTNDulce";
            this.RBTNDulce.Size = new System.Drawing.Size(132, 21);
            this.RBTNDulce.TabIndex = 2;
            this.RBTNDulce.TabStop = true;
            this.RBTNDulce.Text = "Dulce de leche";
            this.RBTNDulce.UseVisualStyleBackColor = true;
            this.RBTNDulce.CheckedChanged += new System.EventHandler(this.RBTNDulce_CheckedChanged);
            // 
            // PNLContenedor
            // 
            this.PNLContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLContenedor.Location = new System.Drawing.Point(12, 16);
            this.PNLContenedor.Name = "PNLContenedor";
            this.PNLContenedor.Size = new System.Drawing.Size(810, 185);
            this.PNLContenedor.TabIndex = 7;
            // 
            // LBLHelado
            // 
            this.LBLHelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLHelado.AutoSize = true;
            this.LBLHelado.BackColor = System.Drawing.Color.Transparent;
            this.LBLHelado.Font = new System.Drawing.Font("Insaniburger with Cheese", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHelado.Location = new System.Drawing.Point(96, 15);
            this.LBLHelado.Name = "LBLHelado";
            this.LBLHelado.Size = new System.Drawing.Size(62, 17);
            this.LBLHelado.TabIndex = 19;
            this.LBLHelado.Text = "Helado";
            // 
            // RBTNMixto
            // 
            this.RBTNMixto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTNMixto.AutoSize = true;
            this.RBTNMixto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNMixto.Font = new System.Drawing.Font("Insaniburger with Cheese", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNMixto.Location = new System.Drawing.Point(26, 101);
            this.RBTNMixto.Name = "RBTNMixto";
            this.RBTNMixto.Size = new System.Drawing.Size(73, 21);
            this.RBTNMixto.TabIndex = 18;
            this.RBTNMixto.TabStop = true;
            this.RBTNMixto.Text = "Mixto";
            this.RBTNMixto.UseVisualStyleBackColor = true;
            // 
            // RBTNDulceDeLeche
            // 
            this.RBTNDulceDeLeche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTNDulceDeLeche.AutoSize = true;
            this.RBTNDulceDeLeche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNDulceDeLeche.Font = new System.Drawing.Font("Insaniburger with Cheese", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNDulceDeLeche.Location = new System.Drawing.Point(26, 74);
            this.RBTNDulceDeLeche.Name = "RBTNDulceDeLeche";
            this.RBTNDulceDeLeche.Size = new System.Drawing.Size(132, 21);
            this.RBTNDulceDeLeche.TabIndex = 17;
            this.RBTNDulceDeLeche.TabStop = true;
            this.RBTNDulceDeLeche.Text = "Dulce de leche";
            this.RBTNDulceDeLeche.UseVisualStyleBackColor = true;
            // 
            // RBTNVainilla
            // 
            this.RBTNVainilla.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RBTNVainilla.AutoSize = true;
            this.RBTNVainilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNVainilla.Font = new System.Drawing.Font("Insaniburger with Cheese", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNVainilla.Location = new System.Drawing.Point(26, 40);
            this.RBTNVainilla.Name = "RBTNVainilla";
            this.RBTNVainilla.Size = new System.Drawing.Size(88, 21);
            this.RBTNVainilla.TabIndex = 16;
            this.RBTNVainilla.TabStop = true;
            this.RBTNVainilla.Text = "Vainilla";
            this.RBTNVainilla.UseVisualStyleBackColor = true;
            // 
            // PNLContHelado
            // 
            this.PNLContHelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLContHelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLContHelado.Controls.Add(this.LBLHelado);
            this.PNLContHelado.Controls.Add(this.RBTNVainilla);
            this.PNLContHelado.Controls.Add(this.RBTNMixto);
            this.PNLContHelado.Controls.Add(this.RBTNDulceDeLeche);
            this.PNLContHelado.Location = new System.Drawing.Point(557, 5);
            this.PNLContHelado.Name = "PNLContHelado";
            this.PNLContHelado.Size = new System.Drawing.Size(250, 139);
            this.PNLContHelado.TabIndex = 20;
            // 
            // PNLContSalsa
            // 
            this.PNLContSalsa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLContSalsa.Controls.Add(this.LBLSalsa);
            this.PNLContSalsa.Controls.Add(this.RBTNDulce);
            this.PNLContSalsa.Controls.Add(this.RBTNChocolate);
            this.PNLContSalsa.Controls.Add(this.RBTNFrutilla);
            this.PNLContSalsa.Location = new System.Drawing.Point(3, 3);
            this.PNLContSalsa.Name = "PNLContSalsa";
            this.PNLContSalsa.Size = new System.Drawing.Size(250, 139);
            this.PNLContSalsa.TabIndex = 21;
            // 
            // FormPostres
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(834, 371);
            this.Controls.Add(this.PNLOpciones);
            this.Controls.Add(this.PNLContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPostres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormPostres";
            this.PNLOpciones.ResumeLayout(false);
            this.PNLContHelado.ResumeLayout(false);
            this.PNLContHelado.PerformLayout();
            this.PNLContSalsa.ResumeLayout(false);
            this.PNLContSalsa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLOpciones;
        private System.Windows.Forms.Label LBLHelado;
        private System.Windows.Forms.RadioButton RBTNMixto;
        private System.Windows.Forms.RadioButton RBTNDulceDeLeche;
        private System.Windows.Forms.RadioButton RBTNVainilla;
        private System.Windows.Forms.Label LBLSalsa;
        private System.Windows.Forms.RadioButton RBTNFrutilla;
        private System.Windows.Forms.RadioButton RBTNChocolate;
        private System.Windows.Forms.RadioButton RBTNDulce;
        private System.Windows.Forms.Panel PNLContenedor;
        private System.Windows.Forms.Panel PNLContSalsa;
        private System.Windows.Forms.Panel PNLContHelado;
    }
}
namespace CapaUsuario
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PNLContenedor = new System.Windows.Forms.Panel();
            this.PNLEfectivo = new System.Windows.Forms.Panel();
            this.PNLLineaEfectivo = new System.Windows.Forms.Panel();
            this.LBLDevolverNumero = new System.Windows.Forms.Label();
            this.LBLDevolver = new System.Windows.Forms.Label();
            this.PNLOcultar = new System.Windows.Forms.Panel();
            this.NUDRecibido = new System.Windows.Forms.NumericUpDown();
            this.LBLRecibido = new System.Windows.Forms.Label();
            this.PNLLinea = new System.Windows.Forms.Panel();
            this.LBLObservaciones = new System.Windows.Forms.Label();
            this.TXTObservaciones = new System.Windows.Forms.TextBox();
            this.BTNPostres = new System.Windows.Forms.Button();
            this.BTNExtras = new System.Windows.Forms.Button();
            this.BTNHamburguesas = new System.Windows.Forms.Button();
            this.BTNBebidas = new System.Windows.Forms.Button();
            this.BTNCombos = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNFinalizar = new System.Windows.Forms.Button();
            this.PNLForms = new System.Windows.Forms.Panel();
            this.LBLPrecioFinal = new System.Windows.Forms.Label();
            this.LBLTotal = new System.Windows.Forms.Label();
            this.PNLMetodoPago = new System.Windows.Forms.Panel();
            this.RBTNTarjeta = new System.Windows.Forms.RadioButton();
            this.RBTNEfectivo = new System.Windows.Forms.RadioButton();
            this.DGVPedido = new System.Windows.Forms.DataGridView();
            this.PNLCuotas = new System.Windows.Forms.Panel();
            this.RBTN12Cuotas = new System.Windows.Forms.RadioButton();
            this.RBTN6Cuotas = new System.Windows.Forms.RadioButton();
            this.RBTN3Cuotas = new System.Windows.Forms.RadioButton();
            this.RBTNUnPago = new System.Windows.Forms.RadioButton();
            this.LBLCantCuotas = new System.Windows.Forms.Label();
            this.PCBPedido = new System.Windows.Forms.PictureBox();
            this.PBXCerrar = new System.Windows.Forms.PictureBox();
            this.PBXMinimizar = new System.Windows.Forms.PictureBox();
            this.PNLTop = new System.Windows.Forms.Panel();
            this.PNLContenedor.SuspendLayout();
            this.PNLEfectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRecibido)).BeginInit();
            this.PNLMetodoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPedido)).BeginInit();
            this.PNLCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXMinimizar)).BeginInit();
            this.PNLTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNLContenedor
            // 
            this.PNLContenedor.BackColor = System.Drawing.Color.White;
            this.PNLContenedor.CausesValidation = false;
            this.PNLContenedor.Controls.Add(this.PNLEfectivo);
            this.PNLContenedor.Controls.Add(this.PNLLinea);
            this.PNLContenedor.Controls.Add(this.LBLObservaciones);
            this.PNLContenedor.Controls.Add(this.TXTObservaciones);
            this.PNLContenedor.Controls.Add(this.BTNPostres);
            this.PNLContenedor.Controls.Add(this.BTNExtras);
            this.PNLContenedor.Controls.Add(this.BTNHamburguesas);
            this.PNLContenedor.Controls.Add(this.BTNBebidas);
            this.PNLContenedor.Controls.Add(this.BTNCombos);
            this.PNLContenedor.Controls.Add(this.BTNCancelar);
            this.PNLContenedor.Controls.Add(this.BTNFinalizar);
            this.PNLContenedor.Controls.Add(this.PNLForms);
            this.PNLContenedor.Controls.Add(this.LBLPrecioFinal);
            this.PNLContenedor.Controls.Add(this.LBLTotal);
            this.PNLContenedor.Controls.Add(this.PNLMetodoPago);
            this.PNLContenedor.Controls.Add(this.DGVPedido);
            this.PNLContenedor.Controls.Add(this.PNLCuotas);
            this.PNLContenedor.Controls.Add(this.PCBPedido);
            this.PNLContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNLContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNLContenedor.Location = new System.Drawing.Point(0, 35);
            this.PNLContenedor.Name = "PNLContenedor";
            this.PNLContenedor.Size = new System.Drawing.Size(1350, 615);
            this.PNLContenedor.TabIndex = 8;
            // 
            // PNLEfectivo
            // 
            this.PNLEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.PNLEfectivo.Controls.Add(this.PNLLineaEfectivo);
            this.PNLEfectivo.Controls.Add(this.LBLDevolverNumero);
            this.PNLEfectivo.Controls.Add(this.LBLDevolver);
            this.PNLEfectivo.Controls.Add(this.PNLOcultar);
            this.PNLEfectivo.Controls.Add(this.NUDRecibido);
            this.PNLEfectivo.Controls.Add(this.LBLRecibido);
            this.PNLEfectivo.Location = new System.Drawing.Point(898, 387);
            this.PNLEfectivo.Name = "PNLEfectivo";
            this.PNLEfectivo.Size = new System.Drawing.Size(438, 170);
            this.PNLEfectivo.TabIndex = 5;
            // 
            // PNLLineaEfectivo
            // 
            this.PNLLineaEfectivo.BackColor = System.Drawing.Color.Gray;
            this.PNLLineaEfectivo.Location = new System.Drawing.Point(317, 16);
            this.PNLLineaEfectivo.Name = "PNLLineaEfectivo";
            this.PNLLineaEfectivo.Size = new System.Drawing.Size(3, 29);
            this.PNLLineaEfectivo.TabIndex = 5;
            // 
            // LBLDevolverNumero
            // 
            this.LBLDevolverNumero.AutoSize = true;
            this.LBLDevolverNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDevolverNumero.Location = new System.Drawing.Point(178, 58);
            this.LBLDevolverNumero.Name = "LBLDevolverNumero";
            this.LBLDevolverNumero.Size = new System.Drawing.Size(40, 24);
            this.LBLDevolverNumero.TabIndex = 4;
            this.LBLDevolverNumero.Text = "000";
            // 
            // LBLDevolver
            // 
            this.LBLDevolver.AutoSize = true;
            this.LBLDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDevolver.Location = new System.Drawing.Point(8, 57);
            this.LBLDevolver.Name = "LBLDevolver";
            this.LBLDevolver.Size = new System.Drawing.Size(165, 24);
            this.LBLDevolver.TabIndex = 3;
            this.LBLDevolver.Text = "Dinero a Devolver:";
            // 
            // PNLOcultar
            // 
            this.PNLOcultar.Location = new System.Drawing.Point(321, 16);
            this.PNLOcultar.Name = "PNLOcultar";
            this.PNLOcultar.Size = new System.Drawing.Size(61, 32);
            this.PNLOcultar.TabIndex = 2;
            this.PNLOcultar.Paint += new System.Windows.Forms.PaintEventHandler(this.PNLOcultar_Paint);
            // 
            // NUDRecibido
            // 
            this.NUDRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDRecibido.Location = new System.Drawing.Point(165, 16);
            this.NUDRecibido.Name = "NUDRecibido";
            this.NUDRecibido.Size = new System.Drawing.Size(178, 29);
            this.NUDRecibido.TabIndex = 1;
            // 
            // LBLRecibido
            // 
            this.LBLRecibido.AutoSize = true;
            this.LBLRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRecibido.Location = new System.Drawing.Point(8, 21);
            this.LBLRecibido.Name = "LBLRecibido";
            this.LBLRecibido.Size = new System.Drawing.Size(151, 24);
            this.LBLRecibido.TabIndex = 0;
            this.LBLRecibido.Text = "Dinero Recibido:";
            // 
            // PNLLinea
            // 
            this.PNLLinea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLLinea.BackColor = System.Drawing.Color.DimGray;
            this.PNLLinea.Location = new System.Drawing.Point(882, 118);
            this.PNLLinea.Name = "PNLLinea";
            this.PNLLinea.Size = new System.Drawing.Size(5, 504);
            this.PNLLinea.TabIndex = 55;
            // 
            // LBLObservaciones
            // 
            this.LBLObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBLObservaciones.AutoSize = true;
            this.LBLObservaciones.Location = new System.Drawing.Point(38, 569);
            this.LBLObservaciones.Name = "LBLObservaciones";
            this.LBLObservaciones.Size = new System.Drawing.Size(114, 20);
            this.LBLObservaciones.TabIndex = 54;
            this.LBLObservaciones.Text = "Observaciones";
            // 
            // TXTObservaciones
            // 
            this.TXTObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TXTObservaciones.Location = new System.Drawing.Point(165, 566);
            this.TXTObservaciones.Name = "TXTObservaciones";
            this.TXTObservaciones.Size = new System.Drawing.Size(352, 26);
            this.TXTObservaciones.TabIndex = 52;
            // 
            // BTNPostres
            // 
            this.BTNPostres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNPostres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.BTNPostres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNPostres.FlatAppearance.BorderSize = 0;
            this.BTNPostres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTNPostres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPostres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPostres.ForeColor = System.Drawing.Color.White;
            this.BTNPostres.Location = new System.Drawing.Point(713, 153);
            this.BTNPostres.Name = "BTNPostres";
            this.BTNPostres.Size = new System.Drawing.Size(162, 30);
            this.BTNPostres.TabIndex = 51;
            this.BTNPostres.Text = "Postres";
            this.BTNPostres.UseVisualStyleBackColor = false;
            this.BTNPostres.Click += new System.EventHandler(this.BTNPostres_Click);
            // 
            // BTNExtras
            // 
            this.BTNExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.BTNExtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNExtras.FlatAppearance.BorderSize = 0;
            this.BTNExtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTNExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNExtras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNExtras.ForeColor = System.Drawing.Color.White;
            this.BTNExtras.Location = new System.Drawing.Point(545, 153);
            this.BTNExtras.Name = "BTNExtras";
            this.BTNExtras.Size = new System.Drawing.Size(162, 30);
            this.BTNExtras.TabIndex = 50;
            this.BTNExtras.Text = "Extras";
            this.BTNExtras.UseVisualStyleBackColor = false;
            this.BTNExtras.Click += new System.EventHandler(this.BTNExtras_Click);
            // 
            // BTNHamburguesas
            // 
            this.BTNHamburguesas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNHamburguesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.BTNHamburguesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNHamburguesas.FlatAppearance.BorderSize = 0;
            this.BTNHamburguesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTNHamburguesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHamburguesas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHamburguesas.ForeColor = System.Drawing.Color.White;
            this.BTNHamburguesas.Location = new System.Drawing.Point(377, 153);
            this.BTNHamburguesas.Name = "BTNHamburguesas";
            this.BTNHamburguesas.Size = new System.Drawing.Size(162, 30);
            this.BTNHamburguesas.TabIndex = 49;
            this.BTNHamburguesas.Text = "Hamburguesas";
            this.BTNHamburguesas.UseVisualStyleBackColor = false;
            this.BTNHamburguesas.Click += new System.EventHandler(this.BTNHamburguesas_Click);
            // 
            // BTNBebidas
            // 
            this.BTNBebidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.BTNBebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBebidas.FlatAppearance.BorderSize = 0;
            this.BTNBebidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTNBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBebidas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBebidas.ForeColor = System.Drawing.Color.White;
            this.BTNBebidas.Location = new System.Drawing.Point(209, 153);
            this.BTNBebidas.Name = "BTNBebidas";
            this.BTNBebidas.Size = new System.Drawing.Size(162, 30);
            this.BTNBebidas.TabIndex = 48;
            this.BTNBebidas.Text = "Bebidas";
            this.BTNBebidas.UseVisualStyleBackColor = false;
            this.BTNBebidas.Click += new System.EventHandler(this.BTNBebidas_Click);
            // 
            // BTNCombos
            // 
            this.BTNCombos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.BTNCombos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCombos.FlatAppearance.BorderSize = 0;
            this.BTNCombos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTNCombos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCombos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCombos.ForeColor = System.Drawing.Color.White;
            this.BTNCombos.Location = new System.Drawing.Point(41, 153);
            this.BTNCombos.Name = "BTNCombos";
            this.BTNCombos.Size = new System.Drawing.Size(162, 30);
            this.BTNCombos.TabIndex = 47;
            this.BTNCombos.Text = "Combos";
            this.BTNCombos.UseVisualStyleBackColor = false;
            this.BTNCombos.Click += new System.EventHandler(this.BTNCombos_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.BTNCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCancelar.FlatAppearance.BorderSize = 0;
            this.BTNCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTNCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelar.ForeColor = System.Drawing.Color.White;
            this.BTNCancelar.Location = new System.Drawing.Point(986, 569);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(92, 30);
            this.BTNCancelar.TabIndex = 46;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = false;
            // 
            // BTNFinalizar
            // 
            this.BTNFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.BTNFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNFinalizar.FlatAppearance.BorderSize = 0;
            this.BTNFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.BTNFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNFinalizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNFinalizar.ForeColor = System.Drawing.Color.White;
            this.BTNFinalizar.Location = new System.Drawing.Point(1084, 569);
            this.BTNFinalizar.Name = "BTNFinalizar";
            this.BTNFinalizar.Size = new System.Drawing.Size(92, 30);
            this.BTNFinalizar.TabIndex = 45;
            this.BTNFinalizar.Text = "Finalizar";
            this.BTNFinalizar.UseVisualStyleBackColor = false;
            // 
            // PNLForms
            // 
            this.PNLForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLForms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PNLForms.BackColor = System.Drawing.Color.Transparent;
            this.PNLForms.Location = new System.Drawing.Point(41, 189);
            this.PNLForms.Name = "PNLForms";
            this.PNLForms.Size = new System.Drawing.Size(834, 371);
            this.PNLForms.TabIndex = 6;
            // 
            // LBLPrecioFinal
            // 
            this.LBLPrecioFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLPrecioFinal.AutoSize = true;
            this.LBLPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPrecioFinal.Location = new System.Drawing.Point(1258, 573);
            this.LBLPrecioFinal.Name = "LBLPrecioFinal";
            this.LBLPrecioFinal.Size = new System.Drawing.Size(48, 25);
            this.LBLPrecioFinal.TabIndex = 5;
            this.LBLPrecioFinal.Text = "000";
            // 
            // LBLTotal
            // 
            this.LBLTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLTotal.AutoSize = true;
            this.LBLTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTotal.Location = new System.Drawing.Point(1182, 573);
            this.LBLTotal.Name = "LBLTotal";
            this.LBLTotal.Size = new System.Drawing.Size(86, 25);
            this.LBLTotal.TabIndex = 4;
            this.LBLTotal.Text = "TOTAL:";
            // 
            // PNLMetodoPago
            // 
            this.PNLMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.PNLMetodoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLMetodoPago.Controls.Add(this.RBTNTarjeta);
            this.PNLMetodoPago.Controls.Add(this.RBTNEfectivo);
            this.PNLMetodoPago.Location = new System.Drawing.Point(898, 354);
            this.PNLMetodoPago.Name = "PNLMetodoPago";
            this.PNLMetodoPago.Size = new System.Drawing.Size(440, 30);
            this.PNLMetodoPago.TabIndex = 3;
            // 
            // RBTNTarjeta
            // 
            this.RBTNTarjeta.AutoSize = true;
            this.RBTNTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNTarjeta.Location = new System.Drawing.Point(287, 3);
            this.RBTNTarjeta.Name = "RBTNTarjeta";
            this.RBTNTarjeta.Size = new System.Drawing.Size(76, 24);
            this.RBTNTarjeta.TabIndex = 3;
            this.RBTNTarjeta.TabStop = true;
            this.RBTNTarjeta.Text = "Tarjeta";
            this.RBTNTarjeta.UseVisualStyleBackColor = true;
            this.RBTNTarjeta.CheckedChanged += new System.EventHandler(this.RBTNTarjeta_CheckedChanged);
            // 
            // RBTNEfectivo
            // 
            this.RBTNEfectivo.AutoSize = true;
            this.RBTNEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNEfectivo.Location = new System.Drawing.Point(17, 3);
            this.RBTNEfectivo.Name = "RBTNEfectivo";
            this.RBTNEfectivo.Size = new System.Drawing.Size(84, 24);
            this.RBTNEfectivo.TabIndex = 2;
            this.RBTNEfectivo.TabStop = true;
            this.RBTNEfectivo.Text = "Efectivo";
            this.RBTNEfectivo.UseVisualStyleBackColor = true;
            this.RBTNEfectivo.CheckedChanged += new System.EventHandler(this.RBTNEfectivo_CheckedChanged);
            // 
            // DGVPedido
            // 
            this.DGVPedido.AllowUserToAddRows = false;
            this.DGVPedido.AllowUserToDeleteRows = false;
            this.DGVPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPedido.Location = new System.Drawing.Point(898, 127);
            this.DGVPedido.Name = "DGVPedido";
            this.DGVPedido.ReadOnly = true;
            this.DGVPedido.Size = new System.Drawing.Size(440, 220);
            this.DGVPedido.TabIndex = 2;
            // 
            // PNLCuotas
            // 
            this.PNLCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PNLCuotas.BackColor = System.Drawing.Color.Transparent;
            this.PNLCuotas.Controls.Add(this.RBTN12Cuotas);
            this.PNLCuotas.Controls.Add(this.RBTN6Cuotas);
            this.PNLCuotas.Controls.Add(this.RBTN3Cuotas);
            this.PNLCuotas.Controls.Add(this.RBTNUnPago);
            this.PNLCuotas.Controls.Add(this.LBLCantCuotas);
            this.PNLCuotas.Location = new System.Drawing.Point(898, 390);
            this.PNLCuotas.Name = "PNLCuotas";
            this.PNLCuotas.Size = new System.Drawing.Size(438, 170);
            this.PNLCuotas.TabIndex = 1;
            // 
            // RBTN12Cuotas
            // 
            this.RBTN12Cuotas.AutoSize = true;
            this.RBTN12Cuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTN12Cuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN12Cuotas.Location = new System.Drawing.Point(12, 145);
            this.RBTN12Cuotas.Name = "RBTN12Cuotas";
            this.RBTN12Cuotas.Size = new System.Drawing.Size(100, 24);
            this.RBTN12Cuotas.TabIndex = 4;
            this.RBTN12Cuotas.TabStop = true;
            this.RBTN12Cuotas.Text = "12 Cuotas";
            this.RBTN12Cuotas.UseVisualStyleBackColor = true;
            // 
            // RBTN6Cuotas
            // 
            this.RBTN6Cuotas.AutoSize = true;
            this.RBTN6Cuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTN6Cuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN6Cuotas.Location = new System.Drawing.Point(12, 115);
            this.RBTN6Cuotas.Name = "RBTN6Cuotas";
            this.RBTN6Cuotas.Size = new System.Drawing.Size(91, 24);
            this.RBTN6Cuotas.TabIndex = 3;
            this.RBTN6Cuotas.TabStop = true;
            this.RBTN6Cuotas.Text = "6 Cuotas";
            this.RBTN6Cuotas.UseVisualStyleBackColor = true;
            // 
            // RBTN3Cuotas
            // 
            this.RBTN3Cuotas.AutoSize = true;
            this.RBTN3Cuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTN3Cuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN3Cuotas.Location = new System.Drawing.Point(12, 85);
            this.RBTN3Cuotas.Name = "RBTN3Cuotas";
            this.RBTN3Cuotas.Size = new System.Drawing.Size(91, 24);
            this.RBTN3Cuotas.TabIndex = 2;
            this.RBTN3Cuotas.TabStop = true;
            this.RBTN3Cuotas.Text = "3 Cuotas";
            this.RBTN3Cuotas.UseVisualStyleBackColor = true;
            // 
            // RBTNUnPago
            // 
            this.RBTNUnPago.AutoSize = true;
            this.RBTNUnPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBTNUnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNUnPago.Location = new System.Drawing.Point(12, 55);
            this.RBTNUnPago.Name = "RBTNUnPago";
            this.RBTNUnPago.Size = new System.Drawing.Size(88, 24);
            this.RBTNUnPago.TabIndex = 1;
            this.RBTNUnPago.TabStop = true;
            this.RBTNUnPago.Text = "Un pago";
            this.RBTNUnPago.UseVisualStyleBackColor = true;
            // 
            // LBLCantCuotas
            // 
            this.LBLCantCuotas.AutoSize = true;
            this.LBLCantCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCantCuotas.Location = new System.Drawing.Point(-5, 10);
            this.LBLCantCuotas.Name = "LBLCantCuotas";
            this.LBLCantCuotas.Size = new System.Drawing.Size(238, 30);
            this.LBLCantCuotas.TabIndex = 0;
            this.LBLCantCuotas.Text = "Cantidad de Cuotas";
            // 
            // PCBPedido
            // 
            this.PCBPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCBPedido.Image = ((System.Drawing.Image)(resources.GetObject("PCBPedido.Image")));
            this.PCBPedido.Location = new System.Drawing.Point(0, -1);
            this.PCBPedido.Name = "PCBPedido";
            this.PCBPedido.Size = new System.Drawing.Size(1414, 154);
            this.PCBPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PCBPedido.TabIndex = 0;
            this.PCBPedido.TabStop = false;
            // 
            // PBXCerrar
            // 
            this.PBXCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBXCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBXCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PBXCerrar.Image")));
            this.PBXCerrar.Location = new System.Drawing.Point(1313, 4);
            this.PBXCerrar.Name = "PBXCerrar";
            this.PBXCerrar.Size = new System.Drawing.Size(25, 25);
            this.PBXCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBXCerrar.TabIndex = 4;
            this.PBXCerrar.TabStop = false;
            this.PBXCerrar.Click += new System.EventHandler(this.PBXCerrar_Click);
            // 
            // PBXMinimizar
            // 
            this.PBXMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBXMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBXMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("PBXMinimizar.Image")));
            this.PBXMinimizar.Location = new System.Drawing.Point(1281, 4);
            this.PBXMinimizar.Name = "PBXMinimizar";
            this.PBXMinimizar.Size = new System.Drawing.Size(25, 25);
            this.PBXMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBXMinimizar.TabIndex = 5;
            this.PBXMinimizar.TabStop = false;
            this.PBXMinimizar.Click += new System.EventHandler(this.PBXMinimizar_Click);
            // 
            // PNLTop
            // 
            this.PNLTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.PNLTop.Controls.Add(this.PBXMinimizar);
            this.PNLTop.Controls.Add(this.PBXCerrar);
            this.PNLTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNLTop.Location = new System.Drawing.Point(0, 0);
            this.PNLTop.Name = "PNLTop";
            this.PNLTop.Size = new System.Drawing.Size(1350, 35);
            this.PNLTop.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 650);
            this.Controls.Add(this.PNLContenedor);
            this.Controls.Add(this.PNLTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burger KING";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PNLContenedor.ResumeLayout(false);
            this.PNLContenedor.PerformLayout();
            this.PNLEfectivo.ResumeLayout(false);
            this.PNLEfectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRecibido)).EndInit();
            this.PNLMetodoPago.ResumeLayout(false);
            this.PNLMetodoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPedido)).EndInit();
            this.PNLCuotas.ResumeLayout(false);
            this.PNLCuotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXMinimizar)).EndInit();
            this.PNLTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLContenedor;
        private System.Windows.Forms.PictureBox PCBPedido;
        private System.Windows.Forms.PictureBox PBXCerrar;
        private System.Windows.Forms.PictureBox PBXMinimizar;
        private System.Windows.Forms.Panel PNLTop;
        private System.Windows.Forms.Panel PNLCuotas;
        private System.Windows.Forms.Label LBLCantCuotas;
        private System.Windows.Forms.RadioButton RBTNUnPago;
        private System.Windows.Forms.RadioButton RBTN12Cuotas;
        private System.Windows.Forms.RadioButton RBTN6Cuotas;
        private System.Windows.Forms.RadioButton RBTN3Cuotas;
        private System.Windows.Forms.DataGridView DGVPedido;
        private System.Windows.Forms.Panel PNLMetodoPago;
        private System.Windows.Forms.RadioButton RBTNTarjeta;
        private System.Windows.Forms.RadioButton RBTNEfectivo;
        private System.Windows.Forms.Label LBLPrecioFinal;
        private System.Windows.Forms.Label LBLTotal;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNFinalizar;
        private System.Windows.Forms.Panel PNLForms;
        private System.Windows.Forms.Label LBLObservaciones;
        private System.Windows.Forms.TextBox TXTObservaciones;
        private System.Windows.Forms.Button BTNPostres;
        private System.Windows.Forms.Button BTNExtras;
        private System.Windows.Forms.Button BTNHamburguesas;
        private System.Windows.Forms.Button BTNBebidas;
        private System.Windows.Forms.Button BTNCombos;
        private System.Windows.Forms.Panel PNLLinea;
        private System.Windows.Forms.Panel PNLEfectivo;
        private System.Windows.Forms.Label LBLDevolverNumero;
        private System.Windows.Forms.Label LBLDevolver;
        private System.Windows.Forms.Panel PNLOcultar;
        private System.Windows.Forms.NumericUpDown NUDRecibido;
        private System.Windows.Forms.Label LBLRecibido;
        private System.Windows.Forms.Panel PNLLineaEfectivo;
    }
}
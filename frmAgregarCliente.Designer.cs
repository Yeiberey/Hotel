
namespace Hotel
{
    partial class frmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCliente));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltituloInformacion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDescripcion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNumeroCelular = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bttn_Eliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelLeft = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNumeroCelular = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.panelFill = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxCompañia = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCompañia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTipoDocumento = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bttnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.lbltituloInformacion);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(809, 51);
            this.panelTop.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Hotel.Properties.Resources.CerrarForm;
            this.pictureBox1.Location = new System.Drawing.Point(773, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbltituloInformacion
            // 
            this.lbltituloInformacion.AutoSize = true;
            this.lbltituloInformacion.BackColor = System.Drawing.Color.Transparent;
            this.lbltituloInformacion.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloInformacion.ForeColor = System.Drawing.Color.White;
            this.lbltituloInformacion.Location = new System.Drawing.Point(12, 12);
            this.lbltituloInformacion.Name = "lbltituloInformacion";
            this.lbltituloInformacion.Size = new System.Drawing.Size(120, 28);
            this.lbltituloInformacion.TabIndex = 0;
            this.lbltituloInformacion.Text = "Nuevo cliente";
            this.lbltituloInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 192);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(184, 35);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción (0/250)";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumeroCelular
            // 
            this.lblNumeroCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroCelular.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCelular.ForeColor = System.Drawing.Color.Gray;
            this.lblNumeroCelular.Location = new System.Drawing.Point(18, 117);
            this.lblNumeroCelular.Name = "lblNumeroCelular";
            this.lblNumeroCelular.Size = new System.Drawing.Size(184, 35);
            this.lblNumeroCelular.TabIndex = 3;
            this.lblNumeroCelular.Text = "Celular N° (0/12)";
            this.lblNumeroCelular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblNombre.Location = new System.Drawing.Point(20, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(157, 35);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre* (0/50)";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bttn_Eliminar
            // 
            this.bttn_Eliminar.ActiveBorderThickness = 1;
            this.bttn_Eliminar.ActiveCornerRadius = 15;
            this.bttn_Eliminar.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.bttn_Eliminar.ActiveForecolor = System.Drawing.Color.White;
            this.bttn_Eliminar.ActiveLineColor = System.Drawing.Color.Black;
            this.bttn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttn_Eliminar.BackColor = System.Drawing.Color.White;
            this.bttn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Eliminar.BackgroundImage")));
            this.bttn_Eliminar.ButtonText = "Eliminar";
            this.bttn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_Eliminar.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.bttn_Eliminar.IdleBorderThickness = 1;
            this.bttn_Eliminar.IdleCornerRadius = 15;
            this.bttn_Eliminar.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.bttn_Eliminar.IdleForecolor = System.Drawing.Color.White;
            this.bttn_Eliminar.IdleLineColor = System.Drawing.Color.Black;
            this.bttn_Eliminar.Location = new System.Drawing.Point(282, 3);
            this.bttn_Eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.bttn_Eliminar.Name = "bttn_Eliminar";
            this.bttn_Eliminar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttn_Eliminar.Size = new System.Drawing.Size(84, 42);
            this.bttn_Eliminar.TabIndex = 1;
            this.bttn_Eliminar.TabStop = false;
            this.bttn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttn_Eliminar.Visible = false;
            this.bttn_Eliminar.Click += new System.EventHandler(this.bttn_Eliminar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Location = new System.Drawing.Point(17, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 34);
            this.panel3.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(7, 6);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(334, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Tag = "";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Location = new System.Drawing.Point(16, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 34);
            this.panel1.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(7, 6);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(333, 23);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.Tag = "";
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.panel4);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Controls.Add(this.bttn_Eliminar);
            this.panelLeft.Controls.Add(this.lblNombre);
            this.panelLeft.Controls.Add(this.lblNumeroCelular);
            this.panelLeft.Controls.Add(this.lblDescripcion);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.GradientBottomLeft = System.Drawing.Color.White;
            this.panelLeft.GradientBottomRight = System.Drawing.Color.White;
            this.panelLeft.GradientTopLeft = System.Drawing.Color.White;
            this.panelLeft.GradientTopRight = System.Drawing.Color.White;
            this.panelLeft.Location = new System.Drawing.Point(0, 51);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Quality = 10;
            this.panelLeft.Size = new System.Drawing.Size(396, 333);
            this.panelLeft.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.txtNumeroCelular);
            this.panel4.Location = new System.Drawing.Point(17, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 34);
            this.panel4.TabIndex = 4;
            // 
            // txtNumeroCelular
            // 
            this.txtNumeroCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroCelular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNumeroCelular.BackColor = System.Drawing.Color.White;
            this.txtNumeroCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroCelular.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCelular.Location = new System.Drawing.Point(7, 6);
            this.txtNumeroCelular.MaxLength = 12;
            this.txtNumeroCelular.Name = "txtNumeroCelular";
            this.txtNumeroCelular.Size = new System.Drawing.Size(333, 23);
            this.txtNumeroCelular.TabIndex = 0;
            this.txtNumeroCelular.Tag = "";
            this.txtNumeroCelular.TextChanged += new System.EventHandler(this.txtNumeroCelular_TextChanged);
            this.txtNumeroCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroCelular_KeyDown);
            this.txtNumeroCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCelular_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.cbxTipoDocumento);
            this.panel2.Location = new System.Drawing.Point(26, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 34);
            this.panel2.TabIndex = 15;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoDocumento.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos"});
            this.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDocumento.DropDownWidth = 230;
            this.cbxTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipoDocumento.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.ItemHeight = 23;
            this.cbxTipoDocumento.Items.AddRange(new object[] {
            "Todos",
            "Ok"});
            this.cbxTipoDocumento.Location = new System.Drawing.Point(3, 2);
            this.cbxTipoDocumento.MaxDropDownItems = 6;
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(361, 31);
            this.cbxTipoDocumento.TabIndex = 0;
            this.cbxTipoDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxTipoDocumento_KeyDown);
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.panel6);
            this.panelFill.Controls.Add(this.panel2);
            this.panelFill.Controls.Add(this.panel5);
            this.panelFill.Controls.Add(this.lblNumeroDocumento);
            this.panelFill.Controls.Add(this.lblCompañia);
            this.panelFill.Controls.Add(this.lblTipoDocumento);
            this.panelFill.Location = new System.Drawing.Point(396, 54);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(413, 290);
            this.panelFill.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.cbxCompañia);
            this.panel6.Location = new System.Drawing.Point(26, 228);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(367, 34);
            this.panel6.TabIndex = 15;
            // 
            // cbxCompañia
            // 
            this.cbxCompañia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCompañia.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos"});
            this.cbxCompañia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompañia.DropDownWidth = 230;
            this.cbxCompañia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCompañia.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCompañia.FormattingEnabled = true;
            this.cbxCompañia.ItemHeight = 23;
            this.cbxCompañia.Items.AddRange(new object[] {
            "Todos",
            "Ok"});
            this.cbxCompañia.Location = new System.Drawing.Point(3, 2);
            this.cbxCompañia.MaxDropDownItems = 6;
            this.cbxCompañia.Name = "cbxCompañia";
            this.cbxCompañia.Size = new System.Drawing.Size(361, 31);
            this.cbxCompañia.TabIndex = 0;
            this.cbxCompañia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxCompañia_KeyDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.txtNumeroDocumento);
            this.panel5.Location = new System.Drawing.Point(26, 155);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 34);
            this.panel5.TabIndex = 2;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(7, 6);
            this.txtNumeroDocumento.MaxLength = 15;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(352, 23);
            this.txtNumeroDocumento.TabIndex = 0;
            this.txtNumeroDocumento.Tag = "";
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged);
            this.txtNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumento_KeyDown);
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocumento.ForeColor = System.Drawing.Color.Gray;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(25, 117);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(217, 35);
            this.lblNumeroDocumento.TabIndex = 1;
            this.lblNumeroDocumento.Text = "Número documento* (0/15)";
            this.lblNumeroDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompañia
            // 
            this.lblCompañia.BackColor = System.Drawing.Color.Transparent;
            this.lblCompañia.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompañia.ForeColor = System.Drawing.Color.Gray;
            this.lblCompañia.Location = new System.Drawing.Point(25, 192);
            this.lblCompañia.Name = "lblCompañia";
            this.lblCompañia.Size = new System.Drawing.Size(157, 35);
            this.lblCompañia.TabIndex = 3;
            this.lblCompañia.Text = "Compañía*";
            this.lblCompañia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.ForeColor = System.Drawing.Color.Gray;
            this.lblTipoDocumento.Location = new System.Drawing.Point(25, 46);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(157, 35);
            this.lblTipoDocumento.TabIndex = 0;
            this.lblTipoDocumento.Text = "Tipo documento*";
            this.lblTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bttnGuardar);
            this.panel7.Location = new System.Drawing.Point(0, 343);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(809, 41);
            this.panel7.TabIndex = 16;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.ActiveBorderThickness = 1;
            this.bttnGuardar.ActiveCornerRadius = 15;
            this.bttnGuardar.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.bttnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.bttnGuardar.ActiveLineColor = System.Drawing.Color.Black;
            this.bttnGuardar.BackColor = System.Drawing.Color.White;
            this.bttnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnGuardar.BackgroundImage")));
            this.bttnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnGuardar.ButtonText = "Guardar";
            this.bttnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnGuardar.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardar.ForeColor = System.Drawing.Color.Black;
            this.bttnGuardar.IdleBorderThickness = 1;
            this.bttnGuardar.IdleCornerRadius = 15;
            this.bttnGuardar.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.bttnGuardar.IdleForecolor = System.Drawing.Color.White;
            this.bttnGuardar.IdleLineColor = System.Drawing.Color.Black;
            this.bttnGuardar.Location = new System.Drawing.Point(16, 0);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttnGuardar.Size = new System.Drawing.Size(774, 41);
            this.bttnGuardar.TabIndex = 1;
            this.bttnGuardar.Tag = "";
            this.bttnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 384);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelFill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarCliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltituloInformacion;
        private Bunifu.Framework.UI.BunifuGradientPanel panelLeft;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtNombre;
        private Bunifu.Framework.UI.BunifuThinButton2 bttn_Eliminar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNumeroCelular;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescripcion;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txtNumeroDocumento;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNumeroDocumento;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTipoDocumento;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCompañia;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtNumeroCelular;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuThinButton2 bttnGuardar;
        public System.Windows.Forms.ComboBox cbxTipoDocumento;
        public System.Windows.Forms.ComboBox cbxCompañia;
    }
}
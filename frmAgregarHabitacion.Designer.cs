
namespace Hotel
{
    partial class frmAgregarHabitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarHabitacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltituloInformacion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelCamas = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelTablaCamas = new System.Windows.Forms.Panel();
            this.lblFecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCliente = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbltablaEstadoCama = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbltablaDescripcionCama = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tablaCamas = new System.Windows.Forms.DataGridView();
            this.lblDescripcionCama = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bttnEliminarCama = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bttnNuevoCama = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDescripcionCama = new System.Windows.Forms.TextBox();
            this.lblCantidadCamas = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbltituloCamas = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bttnGuardarCama = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelHabitacion = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.bttn_Eliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblPosicion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNumero = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrecio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bttnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelCamas.SuspendLayout();
            this.panelTablaCamas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCamas)).BeginInit();
            this.panel6.SuspendLayout();
            this.panelHabitacion.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltituloInformacion
            // 
            this.lbltituloInformacion.AutoSize = true;
            this.lbltituloInformacion.BackColor = System.Drawing.Color.Transparent;
            this.lbltituloInformacion.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloInformacion.ForeColor = System.Drawing.Color.White;
            this.lbltituloInformacion.Location = new System.Drawing.Point(12, 12);
            this.lbltituloInformacion.Name = "lbltituloInformacion";
            this.lbltituloInformacion.Size = new System.Drawing.Size(154, 28);
            this.lbltituloInformacion.TabIndex = 0;
            this.lbltituloInformacion.Text = "Nueva habitación";
            this.lbltituloInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.lbltituloInformacion);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(989, 51);
            this.panelTop.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Hotel.Properties.Resources.CerrarForm;
            this.pictureBox1.Location = new System.Drawing.Point(953, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelCamas
            // 
            this.PanelCamas.BackColor = System.Drawing.Color.White;
            this.PanelCamas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelCamas.BackgroundImage")));
            this.PanelCamas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelCamas.Controls.Add(this.panelTablaCamas);
            this.PanelCamas.Controls.Add(this.lblDescripcionCama);
            this.PanelCamas.Controls.Add(this.bttnEliminarCama);
            this.PanelCamas.Controls.Add(this.bttnNuevoCama);
            this.PanelCamas.Controls.Add(this.panel6);
            this.PanelCamas.Controls.Add(this.lblCantidadCamas);
            this.PanelCamas.Controls.Add(this.lbltituloCamas);
            this.PanelCamas.Controls.Add(this.bttnGuardarCama);
            this.PanelCamas.GradientBottomLeft = System.Drawing.Color.White;
            this.PanelCamas.GradientBottomRight = System.Drawing.Color.White;
            this.PanelCamas.GradientTopLeft = System.Drawing.Color.White;
            this.PanelCamas.GradientTopRight = System.Drawing.Color.White;
            this.PanelCamas.Location = new System.Drawing.Point(377, 51);
            this.PanelCamas.Name = "PanelCamas";
            this.PanelCamas.Quality = 10;
            this.PanelCamas.Size = new System.Drawing.Size(612, 515);
            this.PanelCamas.TabIndex = 14;
            this.PanelCamas.Visible = false;
            // 
            // panelTablaCamas
            // 
            this.panelTablaCamas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTablaCamas.BackColor = System.Drawing.Color.Transparent;
            this.panelTablaCamas.BackgroundImage = global::Hotel.Properties.Resources.tarjeta;
            this.panelTablaCamas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTablaCamas.Controls.Add(this.lblFecha);
            this.panelTablaCamas.Controls.Add(this.lblCliente);
            this.panelTablaCamas.Controls.Add(this.lbltablaEstadoCama);
            this.panelTablaCamas.Controls.Add(this.lbltablaDescripcionCama);
            this.panelTablaCamas.Controls.Add(this.tablaCamas);
            this.panelTablaCamas.Location = new System.Drawing.Point(11, 48);
            this.panelTablaCamas.Name = "panelTablaCamas";
            this.panelTablaCamas.Size = new System.Drawing.Size(587, 304);
            this.panelTablaCamas.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(435, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 25);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(284, 17);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 25);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltablaEstadoCama
            // 
            this.lbltablaEstadoCama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltablaEstadoCama.AutoSize = true;
            this.lbltablaEstadoCama.BackColor = System.Drawing.Color.Transparent;
            this.lbltablaEstadoCama.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltablaEstadoCama.ForeColor = System.Drawing.Color.Black;
            this.lbltablaEstadoCama.Location = new System.Drawing.Point(167, 17);
            this.lbltablaEstadoCama.Name = "lbltablaEstadoCama";
            this.lbltablaEstadoCama.Size = new System.Drawing.Size(58, 25);
            this.lbltablaEstadoCama.TabIndex = 10;
            this.lbltablaEstadoCama.Text = "Estado";
            this.lbltablaEstadoCama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltablaDescripcionCama
            // 
            this.lbltablaDescripcionCama.AutoSize = true;
            this.lbltablaDescripcionCama.BackColor = System.Drawing.Color.Transparent;
            this.lbltablaDescripcionCama.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltablaDescripcionCama.ForeColor = System.Drawing.Color.Black;
            this.lbltablaDescripcionCama.Location = new System.Drawing.Point(15, 17);
            this.lbltablaDescripcionCama.Name = "lbltablaDescripcionCama";
            this.lbltablaDescripcionCama.Size = new System.Drawing.Size(68, 25);
            this.lbltablaDescripcionCama.TabIndex = 10;
            this.lbltablaDescripcionCama.Text = "Nombre";
            this.lbltablaDescripcionCama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tablaCamas
            // 
            this.tablaCamas.AllowUserToAddRows = false;
            this.tablaCamas.AllowUserToDeleteRows = false;
            this.tablaCamas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaCamas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCamas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaCamas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaCamas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCamas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaCamas.ColumnHeadersHeight = 50;
            this.tablaCamas.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCamas.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCamas.Location = new System.Drawing.Point(2, 47);
            this.tablaCamas.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tablaCamas.Name = "tablaCamas";
            this.tablaCamas.ReadOnly = true;
            this.tablaCamas.RowHeadersVisible = false;
            this.tablaCamas.RowHeadersWidth = 50;
            this.tablaCamas.RowTemplate.ErrorText = "Aqui hay un error";
            this.tablaCamas.RowTemplate.Height = 36;
            this.tablaCamas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCamas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCamas.Size = new System.Drawing.Size(579, 238);
            this.tablaCamas.TabIndex = 9;
            this.tablaCamas.TabStop = false;
            this.tablaCamas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCamas_CellClick);
            // 
            // lblDescripcionCama
            // 
            this.lblDescripcionCama.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionCama.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCama.ForeColor = System.Drawing.Color.Gray;
            this.lblDescripcionCama.Location = new System.Drawing.Point(11, 355);
            this.lblDescripcionCama.Name = "lblDescripcionCama";
            this.lblDescripcionCama.Size = new System.Drawing.Size(158, 35);
            this.lblDescripcionCama.TabIndex = 2;
            this.lblDescripcionCama.Text = "Nombre (0/50)";
            this.lblDescripcionCama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bttnEliminarCama
            // 
            this.bttnEliminarCama.ActiveBorderThickness = 1;
            this.bttnEliminarCama.ActiveCornerRadius = 15;
            this.bttnEliminarCama.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.bttnEliminarCama.ActiveForecolor = System.Drawing.Color.White;
            this.bttnEliminarCama.ActiveLineColor = System.Drawing.Color.Black;
            this.bttnEliminarCama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnEliminarCama.BackColor = System.Drawing.Color.White;
            this.bttnEliminarCama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnEliminarCama.BackgroundImage")));
            this.bttnEliminarCama.ButtonText = "Eliminar";
            this.bttnEliminarCama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEliminarCama.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminarCama.ForeColor = System.Drawing.Color.Black;
            this.bttnEliminarCama.IdleBorderThickness = 1;
            this.bttnEliminarCama.IdleCornerRadius = 15;
            this.bttnEliminarCama.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.bttnEliminarCama.IdleForecolor = System.Drawing.Color.White;
            this.bttnEliminarCama.IdleLineColor = System.Drawing.Color.Black;
            this.bttnEliminarCama.Location = new System.Drawing.Point(520, 359);
            this.bttnEliminarCama.Margin = new System.Windows.Forms.Padding(0);
            this.bttnEliminarCama.Name = "bttnEliminarCama";
            this.bttnEliminarCama.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttnEliminarCama.Size = new System.Drawing.Size(78, 35);
            this.bttnEliminarCama.TabIndex = 8;
            this.bttnEliminarCama.TabStop = false;
            this.bttnEliminarCama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnEliminarCama.Visible = false;
            this.bttnEliminarCama.Click += new System.EventHandler(this.bttnEliminarCama_Click);
            // 
            // bttnNuevoCama
            // 
            this.bttnNuevoCama.ActiveBorderThickness = 1;
            this.bttnNuevoCama.ActiveCornerRadius = 15;
            this.bttnNuevoCama.ActiveFillColor = System.Drawing.Color.Gold;
            this.bttnNuevoCama.ActiveForecolor = System.Drawing.Color.Black;
            this.bttnNuevoCama.ActiveLineColor = System.Drawing.Color.Black;
            this.bttnNuevoCama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnNuevoCama.BackColor = System.Drawing.Color.White;
            this.bttnNuevoCama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnNuevoCama.BackgroundImage")));
            this.bttnNuevoCama.ButtonText = "Nuevo";
            this.bttnNuevoCama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnNuevoCama.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNuevoCama.ForeColor = System.Drawing.Color.Black;
            this.bttnNuevoCama.IdleBorderThickness = 1;
            this.bttnNuevoCama.IdleCornerRadius = 15;
            this.bttnNuevoCama.IdleFillColor = System.Drawing.Color.Gold;
            this.bttnNuevoCama.IdleForecolor = System.Drawing.Color.Black;
            this.bttnNuevoCama.IdleLineColor = System.Drawing.Color.Black;
            this.bttnNuevoCama.Location = new System.Drawing.Point(442, 359);
            this.bttnNuevoCama.Margin = new System.Windows.Forms.Padding(0);
            this.bttnNuevoCama.Name = "bttnNuevoCama";
            this.bttnNuevoCama.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttnNuevoCama.Size = new System.Drawing.Size(68, 35);
            this.bttnNuevoCama.TabIndex = 8;
            this.bttnNuevoCama.TabStop = false;
            this.bttnNuevoCama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnNuevoCama.Visible = false;
            this.bttnNuevoCama.Click += new System.EventHandler(this.bttnNuevoCama_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.txtDescripcionCama);
            this.panel6.Location = new System.Drawing.Point(11, 401);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(589, 45);
            this.panel6.TabIndex = 6;
            // 
            // txtDescripcionCama
            // 
            this.txtDescripcionCama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionCama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescripcionCama.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionCama.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCama.Location = new System.Drawing.Point(15, 11);
            this.txtDescripcionCama.MaxLength = 50;
            this.txtDescripcionCama.Name = "txtDescripcionCama";
            this.txtDescripcionCama.Size = new System.Drawing.Size(562, 23);
            this.txtDescripcionCama.TabIndex = 6;
            this.txtDescripcionCama.Tag = "";
            this.txtDescripcionCama.TextChanged += new System.EventHandler(this.txtDescripcionCama_TextChanged);
            this.txtDescripcionCama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcionCama_KeyDown);
            // 
            // lblCantidadCamas
            // 
            this.lblCantidadCamas.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadCamas.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCamas.ForeColor = System.Drawing.Color.Gray;
            this.lblCantidadCamas.Location = new System.Drawing.Point(172, 0);
            this.lblCantidadCamas.Name = "lblCantidadCamas";
            this.lblCantidadCamas.Size = new System.Drawing.Size(92, 53);
            this.lblCantidadCamas.TabIndex = 2;
            this.lblCantidadCamas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltituloCamas
            // 
            this.lbltituloCamas.BackColor = System.Drawing.Color.Transparent;
            this.lbltituloCamas.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloCamas.ForeColor = System.Drawing.Color.Gray;
            this.lbltituloCamas.Location = new System.Drawing.Point(13, 0);
            this.lbltituloCamas.Name = "lbltituloCamas";
            this.lbltituloCamas.Size = new System.Drawing.Size(81, 53);
            this.lbltituloCamas.TabIndex = 2;
            this.lbltituloCamas.Text = "Camas";
            this.lbltituloCamas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bttnGuardarCama
            // 
            this.bttnGuardarCama.ActiveBorderThickness = 1;
            this.bttnGuardarCama.ActiveCornerRadius = 15;
            this.bttnGuardarCama.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.bttnGuardarCama.ActiveForecolor = System.Drawing.Color.White;
            this.bttnGuardarCama.ActiveLineColor = System.Drawing.Color.Black;
            this.bttnGuardarCama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnGuardarCama.BackColor = System.Drawing.Color.White;
            this.bttnGuardarCama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnGuardarCama.BackgroundImage")));
            this.bttnGuardarCama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnGuardarCama.ButtonText = "Guardar";
            this.bttnGuardarCama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnGuardarCama.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardarCama.ForeColor = System.Drawing.Color.Black;
            this.bttnGuardarCama.IdleBorderThickness = 1;
            this.bttnGuardarCama.IdleCornerRadius = 15;
            this.bttnGuardarCama.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.bttnGuardarCama.IdleForecolor = System.Drawing.Color.White;
            this.bttnGuardarCama.IdleLineColor = System.Drawing.Color.Black;
            this.bttnGuardarCama.Location = new System.Drawing.Point(11, 465);
            this.bttnGuardarCama.Margin = new System.Windows.Forms.Padding(0);
            this.bttnGuardarCama.Name = "bttnGuardarCama";
            this.bttnGuardarCama.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttnGuardarCama.Size = new System.Drawing.Size(589, 41);
            this.bttnGuardarCama.TabIndex = 0;
            this.bttnGuardarCama.Tag = "";
            this.bttnGuardarCama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnGuardarCama.Click += new System.EventHandler(this.bttnGuardarCama_Click_1);
            // 
            // panelHabitacion
            // 
            this.panelHabitacion.BackColor = System.Drawing.Color.White;
            this.panelHabitacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHabitacion.BackgroundImage")));
            this.panelHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHabitacion.Controls.Add(this.panel7);
            this.panelHabitacion.Controls.Add(this.panel1);
            this.panelHabitacion.Controls.Add(this.panel3);
            this.panelHabitacion.Controls.Add(this.bttn_Eliminar);
            this.panelHabitacion.Controls.Add(this.lblPosicion);
            this.panelHabitacion.Controls.Add(this.lblNumero);
            this.panelHabitacion.Controls.Add(this.lblPrecio);
            this.panelHabitacion.Controls.Add(this.panel4);
            this.panelHabitacion.Controls.Add(this.lblDescripcion);
            this.panelHabitacion.Controls.Add(this.bttnGuardar);
            this.panelHabitacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHabitacion.GradientBottomLeft = System.Drawing.Color.White;
            this.panelHabitacion.GradientBottomRight = System.Drawing.Color.White;
            this.panelHabitacion.GradientTopLeft = System.Drawing.Color.White;
            this.panelHabitacion.GradientTopRight = System.Drawing.Color.White;
            this.panelHabitacion.Location = new System.Drawing.Point(0, 51);
            this.panelHabitacion.Name = "panelHabitacion";
            this.panelHabitacion.Quality = 10;
            this.panelHabitacion.Size = new System.Drawing.Size(377, 515);
            this.panelHabitacion.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.txtPosicion);
            this.panel7.Location = new System.Drawing.Point(16, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(349, 44);
            this.panel7.TabIndex = 3;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosicion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPosicion.BackColor = System.Drawing.Color.White;
            this.txtPosicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosicion.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicion.Location = new System.Drawing.Point(7, 11);
            this.txtPosicion.MaxLength = 8;
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(327, 23);
            this.txtPosicion.TabIndex = 0;
            this.txtPosicion.Tag = "2";
            this.txtPosicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosicion_KeyDown);
            this.txtPosicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosicion_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Location = new System.Drawing.Point(17, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 44);
            this.panel1.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(7, 11);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(327, 23);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.Tag = "";
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtNumero);
            this.panel3.Location = new System.Drawing.Point(16, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 44);
            this.panel3.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(7, 11);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(327, 23);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.Tag = "";
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
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
            this.bttn_Eliminar.Location = new System.Drawing.Point(281, 3);
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
            // lblPosicion
            // 
            this.lblPosicion.BackColor = System.Drawing.Color.Transparent;
            this.lblPosicion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.ForeColor = System.Drawing.Color.Gray;
            this.lblPosicion.Location = new System.Drawing.Point(19, 66);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(157, 35);
            this.lblPosicion.TabIndex = 2;
            this.lblPosicion.Text = "Posición";
            this.lblPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumero
            // 
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.Gray;
            this.lblNumero.Location = new System.Drawing.Point(19, 162);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(157, 35);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Nombre (0/50)";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Gray;
            this.lblPrecio.Location = new System.Drawing.Point(19, 363);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(114, 35);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.txtPrecio);
            this.panel4.Location = new System.Drawing.Point(16, 401);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 44);
            this.panel4.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(7, 11);
            this.txtPrecio.MaxLength = 8;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(327, 23);
            this.txtPrecio.TabIndex = 0;
            this.txtPrecio.Tag = "";
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 270);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(184, 35);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción (0/250)";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.bttnGuardar.Location = new System.Drawing.Point(17, 465);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttnGuardar.Size = new System.Drawing.Size(349, 41);
            this.bttnGuardar.TabIndex = 0;
            this.bttnGuardar.Tag = "";
            this.bttnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // frmAgregarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 566);
            this.Controls.Add(this.PanelCamas);
            this.Controls.Add(this.panelHabitacion);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarHabitacion";
            this.Load += new System.EventHandler(this.frmAgregarHabitacion_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelCamas.ResumeLayout(false);
            this.panelTablaCamas.ResumeLayout(false);
            this.panelTablaCamas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCamas)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelHabitacion.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelHabitacion;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 bttn_Eliminar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPosicion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNumero;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrecio;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescripcion;
        private Bunifu.Framework.UI.BunifuThinButton2 bttnGuardar;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltituloInformacion;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView tablaCamas;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescripcionCama;
        private Bunifu.Framework.UI.BunifuThinButton2 bttnEliminarCama;
        private Bunifu.Framework.UI.BunifuThinButton2 bttnNuevoCama;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtDescripcionCama;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCantidadCamas;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltituloCamas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTablaCamas;
        public System.Windows.Forms.TextBox txtPosicion;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtDescripcion;
        public Bunifu.Framework.UI.BunifuGradientPanel PanelCamas;
        private Bunifu.Framework.UI.BunifuThinButton2 bttnGuardarCama;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltablaDescripcionCama;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltablaEstadoCama;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCliente;
    }
}
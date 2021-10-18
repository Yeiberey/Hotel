
namespace Hotel
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbxCompañias = new System.Windows.Forms.ComboBox();
            this.cbxTipoDocumentos = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_buscarCliente = new System.Windows.Forms.TextBox();
            this.bttnAgregarClientes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Hotel.Properties.Resources.tarjeta;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tablaClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 476);
            this.panel1.TabIndex = 9;
            // 
            // tablaClientes
            // 
            this.tablaClientes.AllowUserToAddRows = false;
            this.tablaClientes.AllowUserToDeleteRows = false;
            this.tablaClientes.AllowUserToResizeColumns = false;
            this.tablaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaClientes.ColumnHeadersHeight = 50;
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.tablaClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaClientes.Location = new System.Drawing.Point(17, 19);
            this.tablaClientes.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.ReadOnly = true;
            this.tablaClientes.RowHeadersVisible = false;
            this.tablaClientes.RowHeadersWidth = 50;
            this.tablaClientes.RowTemplate.ErrorText = "Aqui hay un error";
            this.tablaClientes.RowTemplate.Height = 36;
            this.tablaClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaClientes.Size = new System.Drawing.Size(926, 437);
            this.tablaClientes.TabIndex = 5;
            this.tablaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaClientes_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Hotel.Properties.Resources.Editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.Width = 60;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Hotel.Properties.Resources.Eliminar;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Width = 60;
            // 
            // cbxCompañias
            // 
            this.cbxCompañias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCompañias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompañias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCompañias.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCompañias.FormattingEnabled = true;
            this.cbxCompañias.IntegralHeight = false;
            this.cbxCompañias.ItemHeight = 23;
            this.cbxCompañias.Location = new System.Drawing.Point(3, 2);
            this.cbxCompañias.Name = "cbxCompañias";
            this.cbxCompañias.Size = new System.Drawing.Size(207, 31);
            this.cbxCompañias.TabIndex = 10;
            this.cbxCompañias.SelectedIndexChanged += new System.EventHandler(this.cbxCompañias_SelectedIndexChanged);
            // 
            // cbxTipoDocumentos
            // 
            this.cbxTipoDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoDocumentos.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos"});
            this.cbxTipoDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDocumentos.DropDownWidth = 207;
            this.cbxTipoDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipoDocumentos.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDocumentos.FormattingEnabled = true;
            this.cbxTipoDocumentos.IntegralHeight = false;
            this.cbxTipoDocumentos.ItemHeight = 23;
            this.cbxTipoDocumentos.Items.AddRange(new object[] {
            "Todos",
            "Ok"});
            this.cbxTipoDocumentos.Location = new System.Drawing.Point(3, 2);
            this.cbxTipoDocumentos.Name = "cbxTipoDocumentos";
            this.cbxTipoDocumentos.Size = new System.Drawing.Size(207, 31);
            this.cbxTipoDocumentos.TabIndex = 10;
            this.cbxTipoDocumentos.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDocumentos_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_buscarCliente);
            this.panel2.Location = new System.Drawing.Point(20, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 34);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_buscarCliente
            // 
            this.txt_buscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscarCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_buscarCliente.BackColor = System.Drawing.Color.White;
            this.txt_buscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscarCliente.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarCliente.Location = new System.Drawing.Point(36, 5);
            this.txt_buscarCliente.Name = "txt_buscarCliente";
            this.txt_buscarCliente.Size = new System.Drawing.Size(171, 23);
            this.txt_buscarCliente.TabIndex = 3;
            this.txt_buscarCliente.TextChanged += new System.EventHandler(this.txt_buscarHabitacion_TextChanged);
            // 
            // bttnAgregarClientes
            // 
            this.bttnAgregarClientes.ActiveBorderThickness = 1;
            this.bttnAgregarClientes.ActiveCornerRadius = 15;
            this.bttnAgregarClientes.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.bttnAgregarClientes.ActiveForecolor = System.Drawing.Color.White;
            this.bttnAgregarClientes.ActiveLineColor = System.Drawing.Color.Black;
            this.bttnAgregarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnAgregarClientes.BackColor = System.Drawing.Color.White;
            this.bttnAgregarClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnAgregarClientes.BackgroundImage")));
            this.bttnAgregarClientes.ButtonText = "Agregar";
            this.bttnAgregarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAgregarClientes.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregarClientes.ForeColor = System.Drawing.Color.Black;
            this.bttnAgregarClientes.IdleBorderThickness = 1;
            this.bttnAgregarClientes.IdleCornerRadius = 15;
            this.bttnAgregarClientes.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bttnAgregarClientes.IdleForecolor = System.Drawing.Color.White;
            this.bttnAgregarClientes.IdleLineColor = System.Drawing.Color.Black;
            this.bttnAgregarClientes.Location = new System.Drawing.Point(791, 11);
            this.bttnAgregarClientes.Margin = new System.Windows.Forms.Padding(0);
            this.bttnAgregarClientes.Name = "bttnAgregarClientes";
            this.bttnAgregarClientes.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttnAgregarClientes.Size = new System.Drawing.Size(152, 48);
            this.bttnAgregarClientes.TabIndex = 0;
            this.bttnAgregarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnAgregarClientes.Click += new System.EventHandler(this.bttnAgregarClientes_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTop.Controls.Add(this.panel5);
            this.panelTop.Controls.Add(this.panel4);
            this.panelTop.Controls.Add(this.bttnAgregarClientes);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(964, 67);
            this.panelTop.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.cbxCompañias);
            this.panel5.Location = new System.Drawing.Point(484, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 34);
            this.panel5.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.cbxTipoDocumentos);
            this.panel4.Location = new System.Drawing.Point(252, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 34);
            this.panel4.TabIndex = 11;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_buscarCliente;
        private System.Windows.Forms.DataGridView tablaClientes;
        private Bunifu.Framework.UI.BunifuThinButton2 bttnAgregarClientes;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox cbxTipoDocumentos;
        private System.Windows.Forms.ComboBox cbxCompañias;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
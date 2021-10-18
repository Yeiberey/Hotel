
namespace Hotel
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTipoDocumentoBttn = new System.Windows.Forms.Panel();
            this.lblTituloTipoDocumento = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelCompañiasBttn = new System.Windows.Forms.Panel();
            this.lblTituloCompañias = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelFill = new System.Windows.Forms.Panel();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bttnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.bttnContadorTipoDocumento = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bttnContadorCompañias = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelTop.SuspendLayout();
            this.panelTipoDocumentoBttn.SuspendLayout();
            this.panelCompañiasBttn.SuspendLayout();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelTipoDocumentoBttn);
            this.panelTop.Controls.Add(this.panelCompañiasBttn);
            this.panelTop.Controls.Add(this.Separator);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(964, 82);
            this.panelTop.TabIndex = 0;
            // 
            // panelTipoDocumentoBttn
            // 
            this.panelTipoDocumentoBttn.Controls.Add(this.lblTituloTipoDocumento);
            this.panelTipoDocumentoBttn.Controls.Add(this.bttnContadorTipoDocumento);
            this.panelTipoDocumentoBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTipoDocumentoBttn.Location = new System.Drawing.Point(182, 37);
            this.panelTipoDocumentoBttn.Name = "panelTipoDocumentoBttn";
            this.panelTipoDocumentoBttn.Size = new System.Drawing.Size(163, 39);
            this.panelTipoDocumentoBttn.TabIndex = 4;
            this.panelTipoDocumentoBttn.Click += new System.EventHandler(this.bttnTipoDocumento_Click);
            // 
            // lblTituloTipoDocumento
            // 
            this.lblTituloTipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloTipoDocumento.AutoSize = true;
            this.lblTituloTipoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloTipoDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTituloTipoDocumento.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTipoDocumento.ForeColor = System.Drawing.Color.Black;
            this.lblTituloTipoDocumento.Location = new System.Drawing.Point(3, 6);
            this.lblTituloTipoDocumento.Name = "lblTituloTipoDocumento";
            this.lblTituloTipoDocumento.Size = new System.Drawing.Size(122, 23);
            this.lblTituloTipoDocumento.TabIndex = 2;
            this.lblTituloTipoDocumento.Text = "Tipo documentos";
            this.lblTituloTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTituloTipoDocumento.Click += new System.EventHandler(this.bttnTipoDocumento_Click);
            // 
            // panelCompañiasBttn
            // 
            this.panelCompañiasBttn.Controls.Add(this.lblTituloCompañias);
            this.panelCompañiasBttn.Controls.Add(this.bttnContadorCompañias);
            this.panelCompañiasBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCompañiasBttn.Location = new System.Drawing.Point(20, 37);
            this.panelCompañiasBttn.Name = "panelCompañiasBttn";
            this.panelCompañiasBttn.Size = new System.Drawing.Size(126, 39);
            this.panelCompañiasBttn.TabIndex = 4;
            this.panelCompañiasBttn.Click += new System.EventHandler(this.bttnContadorCompañias_Click);
            // 
            // lblTituloCompañias
            // 
            this.lblTituloCompañias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloCompañias.AutoSize = true;
            this.lblTituloCompañias.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCompañias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTituloCompañias.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCompañias.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCompañias.Location = new System.Drawing.Point(3, 6);
            this.lblTituloCompañias.Name = "lblTituloCompañias";
            this.lblTituloCompañias.Size = new System.Drawing.Size(86, 23);
            this.lblTituloCompañias.TabIndex = 2;
            this.lblTituloCompañias.Text = "Compañias";
            this.lblTituloCompañias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTituloCompañias.Click += new System.EventHandler(this.bttnContadorCompañias_Click);
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Separator.LineThickness = 4;
            this.Separator.Location = new System.Drawing.Point(20, 72);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(126, 12);
            this.Separator.TabIndex = 0;
            this.Separator.Transparency = 255;
            this.Separator.Vertical = false;
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFill.Controls.Add(this.bttnAgregar);
            this.panelFill.Controls.Add(this.tabla);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 82);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(964, 461);
            this.panelFill.TabIndex = 1;
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.ColumnHeadersHeight = 50;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.tabla.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.tabla.Location = new System.Drawing.Point(17, 68);
            this.tabla.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersVisible = false;
            this.tabla.RowHeadersWidth = 50;
            this.tabla.RowTemplate.ErrorText = "Aqui hay un error";
            this.tabla.RowTemplate.Height = 36;
            this.tabla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(926, 375);
            this.tabla.TabIndex = 6;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellContentClick);
            this.tabla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellEnter);
            this.tabla.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tabla_DataError);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Hotel.Properties.Resources.Eliminar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.ActiveBorderThickness = 1;
            this.bttnAgregar.ActiveCornerRadius = 15;
            this.bttnAgregar.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.bttnAgregar.ActiveForecolor = System.Drawing.Color.White;
            this.bttnAgregar.ActiveLineColor = System.Drawing.Color.Black;
            this.bttnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnAgregar.BackgroundImage")));
            this.bttnAgregar.ButtonText = "Agregar";
            this.bttnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAgregar.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregar.ForeColor = System.Drawing.Color.Black;
            this.bttnAgregar.IdleBorderThickness = 1;
            this.bttnAgregar.IdleCornerRadius = 15;
            this.bttnAgregar.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bttnAgregar.IdleForecolor = System.Drawing.Color.White;
            this.bttnAgregar.IdleLineColor = System.Drawing.Color.Black;
            this.bttnAgregar.Location = new System.Drawing.Point(791, 9);
            this.bttnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttnAgregar.Size = new System.Drawing.Size(152, 48);
            this.bttnAgregar.TabIndex = 7;
            this.bttnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Hotel.Properties.Resources.Eliminar;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Width = 50;
            // 
            // bttnContadorTipoDocumento
            // 
            this.bttnContadorTipoDocumento.ActiveBorderThickness = 1;
            this.bttnContadorTipoDocumento.ActiveCornerRadius = 20;
            this.bttnContadorTipoDocumento.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.bttnContadorTipoDocumento.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.bttnContadorTipoDocumento.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bttnContadorTipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnContadorTipoDocumento.AutoSize = true;
            this.bttnContadorTipoDocumento.BackColor = System.Drawing.Color.White;
            this.bttnContadorTipoDocumento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnContadorTipoDocumento.BackgroundImage")));
            this.bttnContadorTipoDocumento.ButtonText = "0";
            this.bttnContadorTipoDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnContadorTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnContadorTipoDocumento.ForeColor = System.Drawing.Color.SeaGreen;
            this.bttnContadorTipoDocumento.IdleBorderThickness = 1;
            this.bttnContadorTipoDocumento.IdleCornerRadius = 25;
            this.bttnContadorTipoDocumento.IdleFillColor = System.Drawing.Color.Gainsboro;
            this.bttnContadorTipoDocumento.IdleForecolor = System.Drawing.Color.DimGray;
            this.bttnContadorTipoDocumento.IdleLineColor = System.Drawing.Color.Transparent;
            this.bttnContadorTipoDocumento.Location = new System.Drawing.Point(124, 0);
            this.bttnContadorTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnContadorTipoDocumento.Name = "bttnContadorTipoDocumento";
            this.bttnContadorTipoDocumento.Size = new System.Drawing.Size(30, 37);
            this.bttnContadorTipoDocumento.TabIndex = 3;
            this.bttnContadorTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnContadorTipoDocumento.Click += new System.EventHandler(this.bttnTipoDocumento_Click);
            // 
            // bttnContadorCompañias
            // 
            this.bttnContadorCompañias.ActiveBorderThickness = 1;
            this.bttnContadorCompañias.ActiveCornerRadius = 20;
            this.bttnContadorCompañias.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.bttnContadorCompañias.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.bttnContadorCompañias.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bttnContadorCompañias.AutoSize = true;
            this.bttnContadorCompañias.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bttnContadorCompañias.BackColor = System.Drawing.Color.White;
            this.bttnContadorCompañias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnContadorCompañias.BackgroundImage")));
            this.bttnContadorCompañias.ButtonText = "12";
            this.bttnContadorCompañias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnContadorCompañias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnContadorCompañias.ForeColor = System.Drawing.Color.SeaGreen;
            this.bttnContadorCompañias.IdleBorderThickness = 1;
            this.bttnContadorCompañias.IdleCornerRadius = 25;
            this.bttnContadorCompañias.IdleFillColor = System.Drawing.Color.Gainsboro;
            this.bttnContadorCompañias.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.bttnContadorCompañias.IdleLineColor = System.Drawing.Color.Transparent;
            this.bttnContadorCompañias.Location = new System.Drawing.Point(87, 0);
            this.bttnContadorCompañias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnContadorCompañias.Name = "bttnContadorCompañias";
            this.bttnContadorCompañias.Size = new System.Drawing.Size(30, 35);
            this.bttnContadorCompañias.TabIndex = 3;
            this.bttnContadorCompañias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnContadorCompañias.Click += new System.EventHandler(this.bttnContadorCompañias_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 543);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfiguracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTipoDocumentoBttn.ResumeLayout(false);
            this.panelTipoDocumentoBttn.PerformLayout();
            this.panelCompañiasBttn.ResumeLayout(false);
            this.panelCompañiasBttn.PerformLayout();
            this.panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuThinButton2 bttnContadorCompañias;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTituloCompañias;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panelTipoDocumentoBttn;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTituloTipoDocumento;
        private Bunifu.Framework.UI.BunifuThinButton2 bttnContadorTipoDocumento;
        private System.Windows.Forms.Panel panelCompañiasBttn;
        private Bunifu.Framework.UI.BunifuSeparator Separator;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private Bunifu.Framework.UI.BunifuThinButton2 bttnAgregar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
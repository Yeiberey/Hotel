
namespace Hotel
{
    partial class frmHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHabitaciones));
            this.tablaHabitaciones = new System.Windows.Forms.DataGridView();
            this.Editar1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.bttn_Nuevo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_buscarHabitacion = new System.Windows.Forms.TextBox();
            this.panelTablaHabitaciones = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHabitaciones)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTablaHabitaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaHabitaciones
            // 
            this.tablaHabitaciones.AllowUserToAddRows = false;
            this.tablaHabitaciones.AllowUserToDeleteRows = false;
            this.tablaHabitaciones.AllowUserToResizeColumns = false;
            this.tablaHabitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaHabitaciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaHabitaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaHabitaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaHabitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaHabitaciones.ColumnHeadersHeight = 50;
            this.tablaHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar1,
            this.Eliminar1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaHabitaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaHabitaciones.Location = new System.Drawing.Point(17, 19);
            this.tablaHabitaciones.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tablaHabitaciones.Name = "tablaHabitaciones";
            this.tablaHabitaciones.ReadOnly = true;
            this.tablaHabitaciones.RowHeadersVisible = false;
            this.tablaHabitaciones.RowHeadersWidth = 50;
            this.tablaHabitaciones.RowTemplate.ErrorText = "Aqui hay un error";
            this.tablaHabitaciones.RowTemplate.Height = 36;
            this.tablaHabitaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaHabitaciones.Size = new System.Drawing.Size(926, 437);
            this.tablaHabitaciones.TabIndex = 6;
            this.tablaHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaHabitaciones_CellContentClick);
            // 
            // Editar1
            // 
            this.Editar1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar1.HeaderText = "Editar";
            this.Editar1.Image = global::Hotel.Properties.Resources.Editar;
            this.Editar1.Name = "Editar1";
            this.Editar1.ReadOnly = true;
            this.Editar1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar1.Width = 60;
            // 
            // Eliminar1
            // 
            this.Eliminar1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Eliminar1.HeaderText = "Eliminar";
            this.Eliminar1.Image = global::Hotel.Properties.Resources.Eliminar;
            this.Eliminar1.Name = "Eliminar1";
            this.Eliminar1.ReadOnly = true;
            this.Eliminar1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar1.Width = 60;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.bttn_Nuevo);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(964, 67);
            this.panelTop.TabIndex = 7;
            // 
            // bttn_Nuevo
            // 
            this.bttn_Nuevo.ActiveBorderThickness = 1;
            this.bttn_Nuevo.ActiveCornerRadius = 15;
            this.bttn_Nuevo.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.bttn_Nuevo.ActiveForecolor = System.Drawing.Color.White;
            this.bttn_Nuevo.ActiveLineColor = System.Drawing.Color.Black;
            this.bttn_Nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Nuevo.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Nuevo.BackgroundImage")));
            this.bttn_Nuevo.ButtonText = "Nueva habitación";
            this.bttn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_Nuevo.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Nuevo.ForeColor = System.Drawing.Color.Black;
            this.bttn_Nuevo.IdleBorderThickness = 1;
            this.bttn_Nuevo.IdleCornerRadius = 15;
            this.bttn_Nuevo.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bttn_Nuevo.IdleForecolor = System.Drawing.Color.White;
            this.bttn_Nuevo.IdleLineColor = System.Drawing.Color.Black;
            this.bttn_Nuevo.Location = new System.Drawing.Point(791, 11);
            this.bttn_Nuevo.Margin = new System.Windows.Forms.Padding(0);
            this.bttn_Nuevo.Name = "bttn_Nuevo";
            this.bttn_Nuevo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttn_Nuevo.Size = new System.Drawing.Size(152, 48);
            this.bttn_Nuevo.TabIndex = 8;
            this.bttn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttn_Nuevo.Click += new System.EventHandler(this.bttn_Nuevo_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_buscarHabitacion);
            this.panel2.Location = new System.Drawing.Point(20, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 34);
            this.panel2.TabIndex = 4;
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
            // txt_buscarHabitacion
            // 
            this.txt_buscarHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscarHabitacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_buscarHabitacion.BackColor = System.Drawing.Color.White;
            this.txt_buscarHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscarHabitacion.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarHabitacion.Location = new System.Drawing.Point(36, 5);
            this.txt_buscarHabitacion.Name = "txt_buscarHabitacion";
            this.txt_buscarHabitacion.Size = new System.Drawing.Size(171, 23);
            this.txt_buscarHabitacion.TabIndex = 3;
            this.txt_buscarHabitacion.TextChanged += new System.EventHandler(this.txt_buscarHabitacion_TextChanged);
            // 
            // panelTablaHabitaciones
            // 
            this.panelTablaHabitaciones.BackgroundImage = global::Hotel.Properties.Resources.tarjeta;
            this.panelTablaHabitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTablaHabitaciones.Controls.Add(this.tablaHabitaciones);
            this.panelTablaHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTablaHabitaciones.Location = new System.Drawing.Point(0, 67);
            this.panelTablaHabitaciones.Name = "panelTablaHabitaciones";
            this.panelTablaHabitaciones.Size = new System.Drawing.Size(964, 476);
            this.panelTablaHabitaciones.TabIndex = 9;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Hotel.Properties.Resources.Editar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 451;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Hotel.Properties.Resources.Eliminar;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 450;
            // 
            // frmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 543);
            this.Controls.Add(this.panelTablaHabitaciones);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.frmHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaHabitaciones)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTablaHabitaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaHabitaciones;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_buscarHabitacion;
        private Bunifu.Framework.UI.BunifuThinButton2 bttn_Nuevo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panelTablaHabitaciones;
        private System.Windows.Forms.DataGridViewImageColumn Editar1;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar1;
    }
}
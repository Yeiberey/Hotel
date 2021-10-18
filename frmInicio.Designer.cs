
namespace Hotel
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_buscarHabitacion = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bttnReservados = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bttn_Ocupados = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bttn_disponibles = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelGrande = new System.Windows.Forms.Panel();
            this.tablaCamas = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGrande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCamas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Controls.Add(this.bunifuCustomLabel1);
            this.panelTop.Controls.Add(this.bttnReservados);
            this.panelTop.Controls.Add(this.bttn_Ocupados);
            this.panelTop.Controls.Add(this.bttn_disponibles);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(964, 113);
            this.panelTop.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Hotel.Properties.Resources.CajaTexto;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_buscarHabitacion);
            this.panel2.Location = new System.Drawing.Point(20, 65);
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
            this.txt_buscarHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 2);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 53);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Camas";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bttnReservados
            // 
            this.bttnReservados.ActiveBorderThickness = 1;
            this.bttnReservados.ActiveCornerRadius = 15;
            this.bttnReservados.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.bttnReservados.ActiveForecolor = System.Drawing.Color.White;
            this.bttnReservados.ActiveLineColor = System.Drawing.Color.White;
            this.bttnReservados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnReservados.BackColor = System.Drawing.Color.White;
            this.bttnReservados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnReservados.BackgroundImage")));
            this.bttnReservados.ButtonText = "En reserva";
            this.bttnReservados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReservados.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReservados.ForeColor = System.Drawing.Color.Black;
            this.bttnReservados.IdleBorderThickness = 1;
            this.bttnReservados.IdleCornerRadius = 15;
            this.bttnReservados.IdleFillColor = System.Drawing.Color.White;
            this.bttnReservados.IdleForecolor = System.Drawing.Color.Gray;
            this.bttnReservados.IdleLineColor = System.Drawing.Color.Gray;
            this.bttnReservados.Location = new System.Drawing.Point(824, 60);
            this.bttnReservados.Margin = new System.Windows.Forms.Padding(0);
            this.bttnReservados.Name = "bttnReservados";
            this.bttnReservados.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttnReservados.Size = new System.Drawing.Size(117, 45);
            this.bttnReservados.TabIndex = 0;
            this.bttnReservados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnReservados.Click += new System.EventHandler(this.bttnReservados_Click);
            // 
            // bttn_Ocupados
            // 
            this.bttn_Ocupados.ActiveBorderThickness = 1;
            this.bttn_Ocupados.ActiveCornerRadius = 15;
            this.bttn_Ocupados.ActiveFillColor = System.Drawing.Color.Red;
            this.bttn_Ocupados.ActiveForecolor = System.Drawing.Color.White;
            this.bttn_Ocupados.ActiveLineColor = System.Drawing.Color.White;
            this.bttn_Ocupados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Ocupados.BackColor = System.Drawing.Color.White;
            this.bttn_Ocupados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Ocupados.BackgroundImage")));
            this.bttn_Ocupados.ButtonText = "Ocupados";
            this.bttn_Ocupados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_Ocupados.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Ocupados.ForeColor = System.Drawing.Color.Black;
            this.bttn_Ocupados.IdleBorderThickness = 1;
            this.bttn_Ocupados.IdleCornerRadius = 15;
            this.bttn_Ocupados.IdleFillColor = System.Drawing.Color.White;
            this.bttn_Ocupados.IdleForecolor = System.Drawing.Color.Gray;
            this.bttn_Ocupados.IdleLineColor = System.Drawing.Color.Gray;
            this.bttn_Ocupados.Location = new System.Drawing.Point(671, 60);
            this.bttn_Ocupados.Margin = new System.Windows.Forms.Padding(0);
            this.bttn_Ocupados.Name = "bttn_Ocupados";
            this.bttn_Ocupados.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttn_Ocupados.Size = new System.Drawing.Size(117, 45);
            this.bttn_Ocupados.TabIndex = 0;
            this.bttn_Ocupados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttn_Ocupados.Click += new System.EventHandler(this.bttn_Ocupados_Click);
            // 
            // bttn_disponibles
            // 
            this.bttn_disponibles.ActiveBorderThickness = 1;
            this.bttn_disponibles.ActiveCornerRadius = 15;
            this.bttn_disponibles.ActiveFillColor = System.Drawing.Color.Green;
            this.bttn_disponibles.ActiveForecolor = System.Drawing.Color.White;
            this.bttn_disponibles.ActiveLineColor = System.Drawing.Color.White;
            this.bttn_disponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_disponibles.BackColor = System.Drawing.Color.White;
            this.bttn_disponibles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_disponibles.BackgroundImage")));
            this.bttn_disponibles.ButtonText = "Disponibles";
            this.bttn_disponibles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_disponibles.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_disponibles.ForeColor = System.Drawing.Color.Black;
            this.bttn_disponibles.IdleBorderThickness = 1;
            this.bttn_disponibles.IdleCornerRadius = 15;
            this.bttn_disponibles.IdleFillColor = System.Drawing.Color.White;
            this.bttn_disponibles.IdleForecolor = System.Drawing.Color.Gray;
            this.bttn_disponibles.IdleLineColor = System.Drawing.Color.Gray;
            this.bttn_disponibles.Location = new System.Drawing.Point(515, 60);
            this.bttn_disponibles.Margin = new System.Windows.Forms.Padding(0);
            this.bttn_disponibles.Name = "bttn_disponibles";
            this.bttn_disponibles.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bttn_disponibles.Size = new System.Drawing.Size(119, 45);
            this.bttn_disponibles.TabIndex = 0;
            this.bttn_disponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttn_disponibles.Click += new System.EventHandler(this.bttn_disponibles_Click);
            // 
            // panelGrande
            // 
            this.panelGrande.BackgroundImage = global::Hotel.Properties.Resources.tarjeta;
            this.panelGrande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGrande.Controls.Add(this.tablaCamas);
            this.panelGrande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrande.Location = new System.Drawing.Point(0, 113);
            this.panelGrande.Margin = new System.Windows.Forms.Padding(0);
            this.panelGrande.Name = "panelGrande";
            this.panelGrande.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelGrande.Size = new System.Drawing.Size(964, 430);
            this.panelGrande.TabIndex = 6;
            // 
            // tablaCamas
            // 
            this.tablaCamas.AllowUserToAddRows = false;
            this.tablaCamas.AllowUserToDeleteRows = false;
            this.tablaCamas.AllowUserToResizeColumns = false;
            this.tablaCamas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaCamas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaCamas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCamas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaCamas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCamas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCamas.ColumnHeadersHeight = 50;
            this.tablaCamas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCamas.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaCamas.Location = new System.Drawing.Point(17, 17);
            this.tablaCamas.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tablaCamas.Name = "tablaCamas";
            this.tablaCamas.ReadOnly = true;
            this.tablaCamas.RowHeadersVisible = false;
            this.tablaCamas.RowHeadersWidth = 50;
            this.tablaCamas.RowTemplate.ErrorText = "Aqui hay un error";
            this.tablaCamas.RowTemplate.Height = 36;
            this.tablaCamas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCamas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCamas.Size = new System.Drawing.Size(926, 393);
            this.tablaCamas.TabIndex = 1;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 543);
            this.Controls.Add(this.panelGrande);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.ShowIcon = false;
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.frmHabitaciones_Load);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGrande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCamas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGrande;
        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuThinButton2 bttn_disponibles;
        private Bunifu.Framework.UI.BunifuThinButton2 bttn_Ocupados;
        private System.Windows.Forms.DataGridView tablaCamas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_buscarHabitacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bttnReservados;
    }
}
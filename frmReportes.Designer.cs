
namespace Hotel
{
    partial class frmReportes
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
            this.lbl_tituloPagina = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lbl_tituloPagina
            // 
            this.lbl_tituloPagina.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tituloPagina.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloPagina.ForeColor = System.Drawing.Color.Gray;
            this.lbl_tituloPagina.Location = new System.Drawing.Point(12, 9);
            this.lbl_tituloPagina.Name = "lbl_tituloPagina";
            this.lbl_tituloPagina.Size = new System.Drawing.Size(313, 55);
            this.lbl_tituloPagina.TabIndex = 3;
            this.lbl_tituloPagina.Text = "Reportes formularios";
            this.lbl_tituloPagina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_tituloPagina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbl_tituloPagina;
    }
}
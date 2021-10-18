using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmSuccess : Form
    {

        private string tipoaccion = string.Empty;

        public frmSuccess(string titulo, string subtitulo, Color color, string NameButtom, Boolean visibleCancelar, string tipoAccion)
        {
            InitializeComponent();
            lbl_titulo.Text = titulo;
            lbl_subtitulo.Text = subtitulo;
            panel1.BackColor = color;
            bttnAceptar.OnHovercolor = color;
            bttnAceptar.Activecolor = color;
            bttnAceptar.Text = NameButtom;
            bttnCancelar.Visible = visibleCancelar;
            tipoaccion = tipoAccion;

        }

        private void frmSuccess_Load(object sender, EventArgs e)
        {
        }

        public static void confirmacionForm(string titulo, string subtitulo)
        {
            //frmSuccess frm = new frmSuccess(titulo,subtitulo,);
            //frm.ShowDialog();

        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (tipoaccion == "salir")
            {
                Application.Exit();
            }
            else if (tipoaccion == "eliminar")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {

                this.Close();
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}

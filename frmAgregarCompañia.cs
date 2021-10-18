using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaEntidades;
using CapaNegocio;

namespace Hotel
{
    public partial class frmAgregarCompañia : Form
    {
        public int tipo = 0;


        DataTable dataTableCompañias = new DataTable();
        E_Compañia objEntidadCompañias = new E_Compañia();
        N_Compañia objNegocioCompañias = new N_Compañia();


        DataTable dataTableTipoDocumentos = new DataTable();
        E_TipoDocumento objEntidadTipoDocumentos = new E_TipoDocumento();
        N_TipoDocumento objNegocioTipoDocumentos = new N_TipoDocumento();
        public frmAgregarCompañia()
        {
            InitializeComponent();
        }

        public void alerta(string titulo, string subtitulo, Color color, string buttomText)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmSuccess(titulo, subtitulo, color, buttomText, false, "");
            resultado = mensaje.ShowDialog();
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre* (" + Convert.ToString(txtNombre.Text.Length) + "/50)";
        }


        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guardar();
            }
        }

        private void guardar()
        {
            Boolean error = false;
            if (txtNombre.Text.Length < 1 || txtNombre.Text.Length > 50)
            {
                error = true;
            }
            if (error)
            {
                alerta("Verifica que todos los campos", "No deben estar vacios o que incumplan lo requerido", Color.Red, "ENTENDIDO");
            }
            else
            {
                if (tipo == 1)
                {
                    objEntidadCompañias.Nombre = txtNombre.Text;
                    objEntidadCompañias.Descripcion = "";

                    objNegocioCompañias.insertandoCompañia(objEntidadCompañias);
                    DialogResult = DialogResult.OK;
                }

                else if (tipo == 2)
                {
                    objEntidadTipoDocumentos.Nombre = txtNombre.Text;

                    objNegocioTipoDocumentos.insertandoTipoDocumento(objEntidadTipoDocumentos);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

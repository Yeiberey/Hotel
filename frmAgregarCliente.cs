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
    public partial class frmAgregarCliente : Form
    {
        public bool UpdateForm = false;
        public int idCliente = 0;
        public int posicionCliente = 0;
        public int indexTipoDocumento = 0;
        public int indexCompañia = 0;
        public string nombre = "";

        E_Cliente objEntidad = new E_Cliente();

        N_Cliente objNegocio = new N_Cliente();

        DataTable tablaTipoDocumento = new DataTable();
        DataTable tablaCompañia = new DataTable();
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            mostrarCompañias("");
            mostrarTipoDocumentos("");
            if (UpdateForm)
            {
                bttnGuardar.ButtonText = "Actualizar";
                bttnGuardar.IdleFillColor = Color.RoyalBlue;
                bttnGuardar.ActiveFillColor = Color.RoyalBlue;
                bttn_Eliminar.Visible = true;

                cbxTipoDocumento.SelectedIndex = indexTipoDocumento;
                cbxCompañia.SelectedIndex = indexCompañia;
            }
            else
            {

            }
        }
        public void alerta(string titulo, string subtitulo, Color color, string buttomText)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmSuccess(titulo, subtitulo, color, buttomText, false, "");
            resultado = mensaje.ShowDialog();
        }

        public void mostrarTipoDocumentos(string buscar)
        {

            N_TipoDocumento objTipoDocumento = new N_TipoDocumento();
            tablaTipoDocumento = objTipoDocumento.ListandoTipoDocumento(buscar);
            cbxTipoDocumento.DataSource = tablaTipoDocumento;
            cbxTipoDocumento.ValueMember = "ID";
            cbxTipoDocumento.DisplayMember = "Nombre";
        }
        public void mostrarCompañias(string buscar)
        {
            N_Compañia objCompañia = new N_Compañia();
            tablaCompañia = objCompañia.ListandoCompañia(buscar);
            cbxCompañia.DataSource = tablaCompañia;
            cbxCompañia.ValueMember = "ID";
            cbxCompañia.DisplayMember = "Nombre";
        }

        public void guardarCliente()
        {

            Boolean error = false;
            if (txtNombre.Text.Length < 1 || txtNombre.Text.Length > 50)
            {
                error = true;
            }
            if (txtNumeroDocumento.Text.Length < 1 || txtNumeroDocumento.Text.Length > 15)
            {
                error = true;
            }
            if (error)
            {
                alerta("Verifica que todos los campos", "No deben estar vacios o que incumplan lo requerido", Color.Red, "ENTENDIDO");
            }
            else
            {
                if (idCliente == 0)
                {
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.TipoDocumentoID = Convert.ToInt32(tablaTipoDocumento.Rows[cbxTipoDocumento.SelectedIndex]["ID"]);
                    objEntidad.NumeroDocumento = txtNumeroDocumento.Text;
                    objEntidad.CompañiaID = Convert.ToInt32(tablaCompañia.Rows[cbxCompañia.SelectedIndex]["ID"]);
                    objEntidad.NumeroCelular = txtNumeroCelular.Text;
                    objEntidad.Descripcion = txtDescripcion.Text;

                    objNegocio.insertandoCliente(objEntidad);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    objEntidad.ID = idCliente;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.TipoDocumentoID = Convert.ToInt32(tablaTipoDocumento.Rows[cbxTipoDocumento.SelectedIndex]["ID"]);
                    objEntidad.NumeroDocumento = txtNumeroDocumento.Text;
                    objEntidad.CompañiaID = Convert.ToInt32(tablaCompañia.Rows[cbxCompañia.SelectedIndex]["ID"]);
                    objEntidad.NumeroCelular = txtNumeroCelular.Text;
                    objEntidad.Descripcion = txtDescripcion.Text;

                    objNegocio.editandoCliente(objEntidad);
                    DialogResult = DialogResult.OK;

                }

            }
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            guardarCliente();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre* (" + Convert.ToString(txtNombre.Text.Length) + "/50)";
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumeroCelular.Focus();
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            lblDescripcion.Text = "Descripción (" + Convert.ToString(txtDescripcion.Text.Length) + "/250)";
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxTipoDocumento.Focus();
            }
        }

        private void cbxTipoDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumeroDocumento.Focus();
            }
        }

        private void txtNumeroCelular_TextChanged(object sender, EventArgs e)
        {
            lblNumeroCelular.Text = "Celular N° (" + Convert.ToString(txtNumeroCelular.Text.Length) + "/12)";
        }

        private void txtNumeroCelular_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            lblNumeroDocumento.Text = "Número documento* (" + Convert.ToString(txtNumeroDocumento.Text.Length) + "/15)";
        }
       
        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxCompañia.Focus();
            }

        }

        private void cbxCompañia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guardarCliente();
            }

        }

        private void eliminarCliente()
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmSuccess(nombre + "\n¿Desea eliminar este cliente?", "Se eliminá permanentemente", Color.Red, "ELIMINAR", true, "eliminar");
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                objEntidad.ID = idCliente;
                objNegocio.eliminandoCliente(objEntidad);
                this.DialogResult = DialogResult.OK;
            }
        }
        private void bttn_Eliminar_Click(object sender, EventArgs e)
        {
            eliminarCliente();
        }

        private void txtNumeroCelular_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

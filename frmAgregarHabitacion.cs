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
    public partial class frmAgregarHabitacion : Form
    {
        public bool UpdateForm = false;
        public int idHabitacion = 0;
        public int posicionHabitacion = 0;

        private int idCama = 0;

        E_Habitacion objEntidad = new E_Habitacion();

        N_Habitacion objNegocio_Habitacion = new N_Habitacion();


        DataTable dataTableCamas = new DataTable();
        E_Cama objEntidadCama = new E_Cama();
        N_Cama objNegocioCama = new N_Cama();


        DataTable dataTableCliente = new DataTable();
        E_Cliente objEntidadCliente = new E_Cliente();
        N_Cliente objNegocioCliente = new N_Cliente();

        DataTable dataTableReporte = new DataTable();
        E_Reporte objEntidadReporte = new E_Reporte();
        N_Reporte objNegocioReporte = new N_Reporte();
        public frmAgregarHabitacion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarHabitacion_Load(object sender, EventArgs e)
        {
            if (UpdateForm)
            {
                bttnGuardar.ButtonText = "Actualizar";
                bttnGuardar.IdleFillColor = Color.RoyalBlue; 
                bttnGuardar.ActiveFillColor = Color.RoyalBlue;
                lbltituloInformacion.Text = "Actualizar habitación";
                bttn_Eliminar.Visible = true;
                mostrarlistaCamasCodigoHabitacion(idHabitacion);
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
        public void mostrarlistaCamasCodigoHabitacion(int habitacion)
        {
            dataTableCamas = objNegocioCama.ListaCamasPorCodigoHabitacion(habitacion);
            dataTableCamas.Columns.Add("ClienteID");
            dataTableCamas.Columns.Add("Cliente");
            dataTableCamas.Columns.Add("ReporteID");
            dataTableCamas.Columns.Add("FechaEntrada");

            int lengthCamas = dataTableCamas.Rows.Count;

            dataTableReporte = objNegocioReporte.buscarReporte("");
            dataTableCliente = objNegocioCliente.ListandoClientes(0, 0, "");
            for (int item = 0; item < lengthCamas; item++)
            {
                    DataRow[] rows1 = dataTableReporte.Select("CamaID = '" + dataTableCamas.Rows[item]["ID"] + "'AND EstadoReporteID = '1'");
                    int indexReporte = -1;
                    if (rows1.Length > 0)
                    {
                        indexReporte = dataTableReporte.Rows.IndexOf(rows1[0]);
                    }
                    if (indexReporte >= 0)
                    {
                        DataRow[] rows2 = dataTableCliente.Select("ID = '" + Convert.ToString(dataTableReporte.Rows[indexReporte]["ClienteID"]) + "'");
                        int indexCliente = -1;
                        if (rows2.Length > 0)
                        {
                            indexCliente = dataTableCliente.Rows.IndexOf(rows2[0]);
                        }
                        if (indexCliente >= 0)
                        {
                            dataTableCamas.Rows[item]["ClienteID"] = dataTableCliente.Rows[indexCliente]["ID"];
                            dataTableCamas.Rows[item]["Cliente"] = dataTableCliente.Rows[indexCliente]["Nombre"];
                            dataTableCamas.Rows[item]["ReporteID"] = Convert.ToString(dataTableReporte.Rows[indexReporte]["ID"]);
                            dataTableCamas.Rows[item]["FechaEntrada"] = Convert.ToString(dataTableReporte.Rows[indexReporte]["FechaEntrada"]);

                        }
                    }


                
            }





            tablaCamas.DataSource = dataTableCamas;
            //ID
            tablaCamas.Columns[0].Visible = false;
            //descripcionCama
            tablaCamas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tablaCamas.Columns[1].Resizable = DataGridViewTriState.False;
            tablaCamas.Columns[1].Width = 150;

            //estadoCamaID
            tablaCamas.Columns[2].Visible = false;

            //
            tablaCamas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tablaCamas.Columns[3].Resizable = DataGridViewTriState.False;
            tablaCamas.Columns[3].Width = 100;

            //habitacionID
            tablaCamas.Columns[4].Visible = false;
            //nombreHabitacion
            tablaCamas.Columns[5].Visible = false;

            //clienteID
            tablaCamas.Columns[6].Visible = false;

            //nombreCliente
            tablaCamas.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaCamas.Columns[7].Resizable = DataGridViewTriState.False;

            //reporteID
            tablaCamas.Columns[8].Visible = false;

            //fechaEntradaReporte
            tablaCamas.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaCamas.Columns[9].Resizable = DataGridViewTriState.False;

            tablaCamas.ClearSelection();
            lblCantidadCamas.Text = Convert.ToString(tablaCamas.Rows.Count);
            

            txtDescripcionCama.Text = string.Empty;
            idCama = 0;
            bttnEliminarCama.Visible = false;
            bttnNuevoCama.Visible = false;
            PanelCamas.Visible = true;
        }
        public void eliminarHabitacion()
        {
            DataTable tablaCamas = objNegocioCama.ListaCamasPorCodigoHabitacion(idHabitacion);
            DataTable tablaHabitaciones = objNegocio_Habitacion.ListandoHabitacion("");
            int cantidadCamas = tablaCamas.Rows.Count;
            if (cantidadCamas < 1)
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new frmSuccess("¿Desea eliminar esta habitación?", "Se eliminá permanentemente", Color.Red, "ELIMINAR", true, "eliminar");
                resultado = mensaje.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    objEntidad.ID = idHabitacion;
                    objNegocio_Habitacion.eliminandoHabitacion(objEntidad);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                string codigoCamas = "";
                for (int f = 0; f < cantidadCamas; f++)
                {
                    if (codigoCamas == "")
                    {
                        codigoCamas = Convert.ToString(tablaCamas.Rows[f]["Descripcion"]);
                    }
                    else
                    {
                        codigoCamas = codigoCamas + "\n" + Convert.ToString(tablaCamas.Rows[f]["Descripcion"]);
                    }

                }
                DialogResult resultado = new DialogResult();
                Form mensaje = new frmSuccess(tablaHabitaciones.Rows[posicionHabitacion]["Nombre"] + "\n¿Seguro desea eliminar esta habitación?",
                    "Se eliminará permanentemente con \nlas siguientes camas:\n"+ codigoCamas,
                    Color.OrangeRed,
                    "ELIMINAR TODO",
                    true,
                    "eliminar");

                resultado = mensaje.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    for (int f = 0; f < cantidadCamas; f++)
                    {
                        objEntidadCama.ID = Convert.ToInt32(tablaCamas.Rows[f]["ID"]);
                        objNegocioCama.eliminandoCama(objEntidadCama);
                    }

                    objEntidad.ID = idHabitacion;
                    objNegocio_Habitacion.eliminandoHabitacion(objEntidad);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        public void guardarHabitacion()
        {

            Boolean error = false;

            if (txtPosicion.Text.Length < 1 || txtPosicion.Text.Length > 10)
            {
                error = true;
            }

            if (txtNumero.Text.Length < 1 || txtNumero.Text.Length > 50)
            {
                error = true;
            }
            if (txtPrecio.Text.Length < 1)
            {
                error = true;
            }
            if (txtDescripcion.Text.Length < 1 || txtDescripcion.Text.Length > 250)
            {
                error = true;
            }
            if (error)
            {
                alerta("Verifica que todos los campos", "No deben estar vacios o que incumplan lo requerido", Color.Red, "ENTENDIDO");
            }
            else
            {
                if (idHabitacion == 0)
                {
                    objEntidad.Posicion = Convert.ToInt32(txtPosicion.Text);
                    objEntidad.Nombre = txtNumero.Text;
                    objEntidad.Descripcion = txtDescripcion.Text;
                    objEntidad.Precio = Convert.ToDecimal(txtPrecio.Text.Replace(".", ","));

                    objNegocio_Habitacion.insertandoHabitacion(objEntidad);
                    bttnGuardar.ButtonText = "Actualizar";
                    lbltituloInformacion.Text = "Actualizar habitación";
                    bttn_Eliminar.Visible = true;
                    mostrarlistaCamasCodigoHabitacion(idHabitacion);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    objEntidad.ID = idHabitacion;
                    objEntidad.Posicion = Convert.ToInt32(txtPosicion.Text);
                    objEntidad.Nombre = txtNumero.Text;
                    objEntidad.Precio = Convert.ToDecimal(txtPrecio.Text.Replace(".", ","));
                    objEntidad.Descripcion = txtDescripcion.Text;
                    objNegocio_Habitacion.editandoHabitacion(objEntidad);
                    DialogResult = DialogResult.OK;

                }

            }
        }
        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            guardarHabitacion();
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guardarHabitacion();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPosicion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumero.Focus();
            }

        }

        private void txtPosicion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            lblNumero.Text = "Nombre (" + Convert.ToString(txtNumero.Text.Length) + "/50)";
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrecio.Focus();
            }
        }

        private void txtDescripcionCama_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                guardarCama();
            }
        }

        private void txtDescripcionCama_TextChanged(object sender, EventArgs e)
        {
            lblDescripcionCama.Text = "Descripción (" + Convert.ToString(txtDescripcionCama.Text.Length) + "/50)";
        }

        private void tablaCamas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCamas.SelectedRows.Count > 0 && tablaCamas.SelectedRows.Count < 2)
            {
                idCama = Convert.ToInt32(tablaCamas.CurrentRow.Cells[0].Value.ToString());
                txtDescripcionCama.Text = tablaCamas.CurrentRow.Cells[1].Value.ToString();
                bttnNuevoCama.Visible = true;
                bttnEliminarCama.Visible = true;
                bttnGuardarCama.ButtonText = "Actualizar";
                bttnGuardarCama.ActiveFillColor = Color.RoyalBlue;
                bttnGuardarCama.IdleFillColor = Color.RoyalBlue;
            }
            else
            {

                alerta("Selecionar un elemento", "", Color.Red, "ENTENDIDO");
            }
        }
        public void nuevoCama()
        {
            txtDescripcionCama.Text = string.Empty;
            idCama = 0;
            tablaCamas.ClearSelection();
            bttnEliminarCama.Visible = false;
            bttnNuevoCama.Visible = false;
            bttnGuardarCama.ButtonText = "Guardar";
            bttnGuardarCama.IdleFillColor = Color.MediumSeaGreen; 
            bttnGuardarCama.ActiveFillColor = Color.MediumSeaGreen;
            lblCantidadCamas.Text = "";

            if (idHabitacion == 0)
            {
                tablaCamas.Columns.Clear();
            }
            else
            {
                mostrarlistaCamasCodigoHabitacion(idHabitacion);
            }

        }
        public void guardarCama()
        {

            Boolean error = false;

            if (txtDescripcionCama.Text.Length < 1 || txtDescripcionCama.Text.Length > 250)
            {
                error = true;
            }

            if (error)
            {
                alerta("Todos los campos son obligatorios", "", Color.Red, "ENTENDIDO");
            }
            else
            {
                if (idCama == 0)
                {
                    objEntidadCama.EstadoCamaID = 1;
                    objEntidadCama.HabitacionID = idHabitacion;
                    objEntidadCama.Descripcion = txtDescripcionCama.Text;

                    objNegocioCama.insertandoCama(objEntidadCama);
                    //alerta("Se guardo correctamente!", Color.Green, "ENTENDIDO");
                    nuevoCama();

                }
                else
                {
                    objEntidadCama.ID = idCama;
                    objEntidadCama.EstadoCamaID = Convert.ToInt32(tablaCamas.CurrentRow.Cells[3].Value.ToString());
                    objEntidadCama.HabitacionID = idHabitacion;
                    objEntidadCama.Descripcion = txtDescripcionCama.Text;

                    objNegocioCama.editandoCama(objEntidadCama);
                    //alerta("Se actualizo correctamente!", Color.Green, "ENTENDIDO");
                    mostrarlistaCamasCodigoHabitacion(idHabitacion);

                }
            }
        }

        private void bttnNuevoCama_Click(object sender, EventArgs e)
        {
            nuevoCama();
        }

        private void bttnEliminarCama_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmSuccess("¿Desea eliminar esta cama?", "Se eliminá permanentemente", Color.OrangeRed, "ELIMINAR", true, "eliminar");
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {

                objEntidadCama.ID = idCama;
                objNegocioCama.eliminandoCama(objEntidadCama);
                //alerta("Se ha eliminado correctamente", Color.Red, "ENTENDIDO");
                nuevoCama();
            }
        }

        private void bttn_Eliminar_Click(object sender, EventArgs e)
        {
            eliminarHabitacion();
        }

        private void bttnGuardarCama_Click_1(object sender, EventArgs e)
        {
            guardarCama();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

            lblDescripcion.Text = "Descripción (" + Convert.ToString(txtDescripcion.Text.Length) + "/250)";
        }
    }
}

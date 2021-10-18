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
    public partial class frmHabitaciones : Form
    {
        private int indexSelect = 0;
        private int idHabitacion = 0;
        DataTable dataTableHabitaciones = new DataTable();

        E_Habitacion objEntidad = new E_Habitacion();

        N_Habitacion objNegocio_Habitacion = new N_Habitacion();


        E_Cama objEntidadCama = new E_Cama();
        N_Cama objNegocioCama = new N_Cama();
        public frmHabitaciones()
        {
            InitializeComponent();
        }
        public void ocultarMoverAncharColumnas()
        {
            tablaHabitaciones.Columns[2].Visible = false;

            tablaHabitaciones.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tablaHabitaciones.Columns[3].Resizable = DataGridViewTriState.False;
            tablaHabitaciones.Columns[3].Width = 60;

            tablaHabitaciones.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaHabitaciones.Columns[4].Resizable = DataGridViewTriState.False;

            tablaHabitaciones.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaHabitaciones.Columns[5].Resizable = DataGridViewTriState.False;

            tablaHabitaciones.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tablaHabitaciones.Columns[6].Resizable = DataGridViewTriState.False;
            tablaHabitaciones.Columns[6].Width = 90;

            tablaHabitaciones.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tablaHabitaciones.Columns[7].Resizable = DataGridViewTriState.False;
            tablaHabitaciones.Columns[7].Width = 60;

            tablaHabitaciones.Columns[0].DisplayIndex = dataTableHabitaciones.Columns.Count+1;
            tablaHabitaciones.Columns[1].DisplayIndex = dataTableHabitaciones.Columns.Count+1;

            tablaHabitaciones.ClearSelection();
        }

        public void mostrarBuscarTabla(string habitacion)
        {
            dataTableHabitaciones = objNegocio_Habitacion.ListandoHabitacion(habitacion);
            dataTableHabitaciones.Columns.Add("Camas");

            int lengthHabitaciones = dataTableHabitaciones.Rows.Count;

            for (int item = 0; item < lengthHabitaciones; item++ )
            {
                DataTable dataTableCamas = objNegocioCama.ListaCamasPorCodigoHabitacion(Convert.ToInt32(dataTableHabitaciones.Rows[item]["ID"]));
                dataTableHabitaciones.Rows[item]["Camas"] = dataTableCamas.Rows.Count;
            }



            tablaHabitaciones.DataSource = dataTableHabitaciones;

            ocultarMoverAncharColumnas();
        }


        public void alerta(string titulo,string subtitulo, Color color, string buttomText)
        {

            DialogResult resultado = new DialogResult();
            Form mensaje = new frmSuccess(titulo, subtitulo, color, buttomText, false, "");
            resultado = mensaje.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_buscarHabitacion_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txt_buscarHabitacion.Text);
        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
        }
        private void bttn_Nuevo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmAgregarHabitacion frm = new frmAgregarHabitacion();
            frm.Text = "Nueva habitación";
            frm.Width = 377;
            frm.Height = 566;
            DataTable tablaHabitaciones = objNegocio_Habitacion.ListandoHabitacion("");
            int posicion = Convert.ToInt32(tablaHabitaciones.Rows[tablaHabitaciones.Rows.Count-1]["Posicion"])+1;
            frm.txtPosicion.Text = Convert.ToString(posicion);
            frm.txtNumero.Focus();
            resultado = frm.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                mostrarBuscarTabla("");
            }
        }


        public void eliminarHabitacion()
        {

            idHabitacion = Convert.ToInt32(tablaHabitaciones.CurrentRow.Cells[2].Value.ToString());
            DataTable tablaCamas = objNegocioCama.ListaCamasPorCodigoHabitacion(idHabitacion);
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
                        mostrarBuscarTabla("");
                }
                }
                else
                {
                string codigoCamas = "";
                for (int f = 0; f < cantidadCamas; f++)
                {
                    if(codigoCamas == "")
                    {
                        codigoCamas = Convert.ToString(tablaCamas.Rows[f]["Descripcion"]);
                    }
                    else
                    {
                        codigoCamas = codigoCamas + "\n"+ Convert.ToString(tablaCamas.Rows[f]["Descripcion"]);
                    }
                    
                }
                DialogResult resultado = new DialogResult();
                    Form mensaje = new frmSuccess(tablaHabitaciones.CurrentRow.Cells[4].Value.ToString() + "\n¿Seguro desea eliminar esta habitación?",
                    "Se eliminará permanentemente con \nlas siguientes camas:\n" + codigoCamas, 
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
                    mostrarBuscarTabla("");
                }
                }
        }
        public void editar()
        {
            DialogResult resultado = new DialogResult();
            frmAgregarHabitacion frm = new frmAgregarHabitacion();
            frm.Text = "Actualizar habitación";
            frm.UpdateForm = true;
            frm.posicionHabitacion = indexSelect;
            frm.idHabitacion = Convert.ToInt32(tablaHabitaciones.CurrentRow.Cells[2].Value.ToString());
            frm.txtPosicion.Text = tablaHabitaciones.CurrentRow.Cells[3].Value.ToString();
            frm.txtNumero.Text = tablaHabitaciones.CurrentRow.Cells[4].Value.ToString();
            frm.txtDescripcion.Text = tablaHabitaciones.CurrentRow.Cells[5].Value.ToString();
            frm.txtPrecio.Text = tablaHabitaciones.CurrentRow.Cells[6].Value.ToString().Replace(",",".");
            resultado = frm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                mostrarBuscarTabla("");
            }
        }

        private void tablaHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSelect = e.RowIndex;
            if (e.ColumnIndex == 1)
            {
                eliminarHabitacion();
            }
            else if (e.ColumnIndex == 0)
            {
                editar();
            }
        }
    }
}

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
    public partial class frmClientes : Form
    {
        private int indexSelect = 0;
        private int idCliente = 0;

        DataTable tablaTipoDocumento = new DataTable();
        DataTable tablaCompañia = new DataTable();

        DataTable dataTableClientes = new DataTable();
        E_Cliente objEntidadCliente = new E_Cliente();
        N_Cliente objNegocioCliente = new N_Cliente();

        DataTable dataTableReporte = new DataTable();
        E_Reporte objEntidadReporte = new E_Reporte();
        N_Reporte objNegocioReporte = new N_Reporte();

        DataTable dataTableCamas = new DataTable();
        E_Cama objEntidadCama = new E_Cama();
        N_Cama objNegocioCama = new N_Cama();

        DataTable dataTableHabitaciones = new DataTable();
        E_Habitacion objEntidadHabitaciones = new E_Habitacion();
        N_Habitacion objNegocioHabitaciones = new N_Habitacion();


        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

            mostrarTipoDocumentos("");
            mostrarCompañias("");
            mostrarTablaClientes(0,0,"");
        }

        public void ocultarMoverAncharColumnas()
        {
            //id
            tablaClientes.Columns[2].Visible = false;

            //nombre
            tablaClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaClientes.Columns[3].Resizable = DataGridViewTriState.False;
            
            //this.lblTipoDocumento.Location = new System.Drawing.Point(Convert.ToInt32(tablaClientes.get), 17);
            //lblTipoDocumento.Text = Convert.ToString(Convert.ToInt32(tablaClientes.Columns[2].FillWeight));

            //id tipo documento
            tablaClientes.Columns[4].Visible = false;

            //nombre tipo documento
            tablaClientes.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaClientes.Columns[5].Resizable = DataGridViewTriState.False;
            //tablaClientes.Columns[5].Width = 60;

            //numero documento
            tablaClientes.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaClientes.Columns[6].Resizable = DataGridViewTriState.False;
            //tablaClientes.Columns[6].Width = 60;

            //id compañia
            tablaClientes.Columns[7].Visible = false;
            //tablaClientes.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //tablaClientes.Columns[7].Resizable = DataGridViewTriState.False;
            //tablaClientes.Columns[7].Width = 60;

            //nombre compañia
            tablaClientes.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaClientes.Columns[8].Resizable = DataGridViewTriState.False;
            //tablaClientes.Columns[8].Width = 60;

            //numero celular
            tablaClientes.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaClientes.Columns[9].Resizable = DataGridViewTriState.False;
            //tablaClientes.Columns[9].Width = 60;

            //descripcion
            tablaClientes.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaClientes.Columns[10].Resizable = DataGridViewTriState.False;
            //tablaClientes.Columns[10].Width = 60;

            //CamaID
            tablaClientes.Columns[11].Visible = false;

            //estado
            tablaClientes.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaClientes.Columns[12].Resizable = DataGridViewTriState.False;

            //habitacionID
            tablaClientes.Columns[13].Visible = false;

            //Habitacion
            tablaClientes.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaClientes.Columns[14].Resizable = DataGridViewTriState.False;

            tablaClientes.Columns[0].DisplayIndex = dataTableClientes.Columns.Count+1;
            tablaClientes.Columns[1].DisplayIndex = dataTableClientes.Columns.Count+1;

            tablaClientes.ClearSelection();
        }
        public void mostrarTablaClientes(int tipoDocumentoID,int compañiaID,string buscar)
        {
            dataTableClientes = objNegocioCliente.ListandoClientes(tipoDocumentoID,compañiaID,buscar);
            dataTableClientes.Columns.Add("CamaID");
            dataTableClientes.Columns.Add("Estado");
            dataTableClientes.Columns.Add("HabitacionID");
            dataTableClientes.Columns.Add("Habitacion");
            int lengthClientes = dataTableClientes.Rows.Count;
            
            dataTableReporte = objNegocioReporte.buscarReporte("");
            dataTableCamas = objNegocioCama.ListaCamasPorCodigoHabitacion(0);
            dataTableHabitaciones = objNegocioHabitaciones.ListandoHabitacion("");

            for (int item = 0; item < lengthClientes; item++)
            {
                
                DataRow[] rows1 = dataTableReporte.Select("ClienteID = '" + dataTableClientes.Rows[item]["ID"] + "'AND EstadoReporteID = '1'");
                int indexReporte = -1;

                if (rows1.Length > 0)
                {
                    indexReporte = dataTableReporte.Rows.IndexOf(rows1[0]);
                }
                if (indexReporte >= 0)
                {
                    DataRow[] rows2 = dataTableCamas.Select("ID = '" + dataTableReporte.Rows[indexReporte]["CamaID"] + "'");
                    int indexCama = -1;
                    if (rows2.Length > 0)
                    {
                        indexCama = dataTableCamas.Rows.IndexOf(rows2[0]);
                    }

                    if (indexCama >= 0)
                    {

                        DataRow[] rows3 = dataTableHabitaciones.Select("ID = '" + dataTableCamas.Rows[indexCama]["HabitacionID"] + "'");
                        int indexHabitacion = -1;
                        if (rows3.Length > 0)
                        {
                            indexHabitacion = dataTableHabitaciones.Rows.IndexOf(rows3[0]);
                        }
                        if (indexHabitacion >= 0)
                        {
                            dataTableClientes.Rows[item]["CamaID"] = dataTableCamas.Rows[indexCama]["ID"];
                            int estadoCama = Convert.ToInt32(dataTableCamas.Rows[indexCama]["EstadoCamaID"]);
                            if (estadoCama == 2)
                            {
                                dataTableClientes.Rows[item]["Estado"] = "Ocupado";
                            }
                            else
                            {
                                dataTableClientes.Rows[item]["Estado"] = "Reservación";
                            }
                            
                            dataTableClientes.Rows[item]["HabitacionID"] = dataTableHabitaciones.Rows[indexHabitacion]["ID"];
                            dataTableClientes.Rows[item]["Habitacion"] = dataTableHabitaciones.Rows[indexHabitacion]["Nombre"];
                        }
                    }

                }
            }


                tablaClientes.DataSource = dataTableClientes;
            ocultarMoverAncharColumnas();
        }
        public void mostrarTipoDocumentos(string buscar)
        {

            N_TipoDocumento objTipoDocumento = new N_TipoDocumento();
            tablaTipoDocumento = objTipoDocumento.ListandoTipoDocumento(buscar);
            tablaTipoDocumento.Rows.Add("0","Todos");
            cbxTipoDocumentos.DataSource = tablaTipoDocumento;
            cbxTipoDocumentos.ValueMember = "ID";
            cbxTipoDocumentos.DisplayMember = "Nombre";
            cbxTipoDocumentos.SelectedIndex = tablaTipoDocumento.Rows.Count-1;
            //cbxTipoDocumento.Rows[0].ItemArray = cbxTipoDocumento.Rows[cbxTipoDocumento.Rows.Count-1].ItemArray;
        }
        public void mostrarCompañias(string buscar)
        {
            N_Compañia objCompañia = new N_Compañia();
            tablaCompañia = objCompañia.ListandoCompañia(buscar);
            tablaCompañia.Rows.Add("0", "Todos");
            cbxCompañias.DataSource = tablaCompañia;
            cbxCompañias.ValueMember = "ID";
            cbxCompañias.DisplayMember = "Nombre";
            cbxCompañias.SelectedIndex = tablaCompañia.Rows.Count-1;
        }

        private void bttnAgregarClientes_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmAgregarCliente frm = new frmAgregarCliente();
            frm.Text = "Nuevo cliente";
            resultado = frm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                actualizarTablaCliente();
            }
        }
        private void actualizarTablaCliente()
        {


            if (Convert.ToInt32(cbxCompañias.SelectedIndex) != -1 && Convert.ToInt32(cbxTipoDocumentos.SelectedIndex) != -1)
            {
                mostrarTablaClientes(Convert.ToInt32(tablaTipoDocumento.Rows[cbxTipoDocumentos.SelectedIndex]["ID"])
                    , Convert.ToInt32(tablaCompañia.Rows[cbxCompañias.SelectedIndex]["ID"]), txt_buscarCliente.Text);
            }
        }

        private void txt_buscarHabitacion_TextChanged(object sender, EventArgs e)
        {
            actualizarTablaCliente();
        }

        private void cbxTipoDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarTablaCliente();
        }

        private void cbxCompañias_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarTablaCliente();
        }

        private void eliminarCliente()
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmSuccess(Convert.ToString(tablaClientes.CurrentRow.Cells[3].Value.ToString()) + "\n¿Desea eliminar este cliente?", "Se eliminá permanentemente", Color.Red, "ELIMINAR", true, "eliminar");
            resultado = mensaje.ShowDialog();

            if(resultado == DialogResult.OK)
            {
            idCliente = Convert.ToInt32(tablaClientes.CurrentRow.Cells[2].Value.ToString());
            objEntidadCliente.ID = idCliente;
            objNegocioCliente.eliminandoCliente(objEntidadCliente);
            actualizarTablaCliente();
            }
        }
        public void editar()
        {
            DialogResult resultado = new DialogResult();
            frmAgregarCliente frm = new frmAgregarCliente();
            frm.Text = "Actualizar cliente";
            frm.UpdateForm = true;
            frm.posicionCliente = indexSelect;
            frm.idCliente = Convert.ToInt32(tablaClientes.CurrentRow.Cells[2].Value.ToString());
            frm.nombre = tablaClientes.CurrentRow.Cells[3].Value.ToString();
            frm.txtNombre.Text = tablaClientes.CurrentRow.Cells[3].Value.ToString();

            DataRow[] rowstip = tablaTipoDocumento.Select("ID = '"+ Convert.ToString(tablaClientes.CurrentRow.Cells[4].Value.ToString())+"'");
            int IndexTipoDocumento = 0;
            if (rowstip.Length >= 0)
            {
                IndexTipoDocumento = tablaTipoDocumento.Rows.IndexOf(rowstip[0]);
            }

            DataRow[] rowsCom = tablaCompañia.Select("ID = '" + Convert.ToString(tablaClientes.CurrentRow.Cells[7].Value.ToString()) + "'");
            int IndexCompañia = 0;
            if (rowsCom.Length >= 0)
            {
                IndexCompañia = tablaCompañia.Rows.IndexOf(rowsCom[0]);
            }


            frm.indexTipoDocumento = IndexTipoDocumento;
            frm.txtNumeroDocumento.Text = tablaClientes.CurrentRow.Cells[6].Value.ToString();
            frm.indexCompañia = IndexCompañia;
            frm.txtNumeroCelular.Text = tablaClientes.CurrentRow.Cells[9].Value.ToString();
            frm.txtDescripcion.Text = tablaClientes.CurrentRow.Cells[10].Value.ToString();
            resultado = frm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                actualizarTablaCliente();
            }
        }
        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSelect = e.ColumnIndex;
            if (e.ColumnIndex == 1)
            {
                eliminarCliente();
            }
            else if (e.ColumnIndex == 0)
            {
                editar();
            }
        }
    }
}

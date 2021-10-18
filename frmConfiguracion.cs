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
    public partial class frmConfiguracion : Form
    {
        int posicionPagina = 1;

        DataTable dataTableCompañias = new DataTable();
        E_Compañia objEntidadCompañias = new E_Compañia();
        N_Compañia objNegocioCompañias = new N_Compañia();

        DataTable dataTableTipoDocumentos = new DataTable();
        E_TipoDocumento objEntidadTipoDocumentos = new E_TipoDocumento();
        N_TipoDocumento objNegocioTipoDocumentos = new N_TipoDocumento();


        DataTable dataTableClientes = new DataTable();
        E_Cliente objEntidadCliente = new E_Cliente();
        N_Cliente objNegocioCliente = new N_Cliente();
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void MostrarTodosTipoDocumento(bool mostrarTabla)
        {
            dataTableTipoDocumentos = objNegocioTipoDocumentos.ListandoTipoDocumento("");
            dataTableTipoDocumentos.Columns.Add("Cant. clientes", typeof(Int32));
            dataTableClientes = objNegocioCliente.ListandoClientes(0, 0, "");

            int lengthTipoDocumentos = dataTableTipoDocumentos.Rows.Count;
            for (int i = 0; i < lengthTipoDocumentos; i++)
            {
                DataRow[] rows1 = dataTableClientes.Select("TipoDocumentoID = '" + dataTableTipoDocumentos.Rows[i]["ID"] + "'");

                dataTableTipoDocumentos.Rows[i]["Cant. clientes"] = rows1.Length;
            }

            bttnContadorTipoDocumento.ButtonText = Convert.ToString(dataTableTipoDocumentos.Rows.Count);
            if (mostrarTabla)
            {


                tabla.DataSource = dataTableTipoDocumentos;


                //id
                tabla.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                tabla.Columns[1].Resizable = DataGridViewTriState.False;


                //Nombre
                tabla.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tabla.Columns[2].Resizable = DataGridViewTriState.False;
                tabla.Columns[2].ReadOnly = false;
                ((DataGridViewTextBoxColumn)tabla.Columns[2]).MaxInputLength = 50;

                //Cant. clientes
                tabla.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                tabla.Columns[3].Resizable = DataGridViewTriState.False;
                tabla.Columns[3].ReadOnly = true;

                tabla.Columns[0].DisplayIndex = dataTableTipoDocumentos.Columns.Count;

                tabla.ClearSelection();
            }

        }
        private void mostrarTodosCompañias(bool mostrarTabla)
        {
            dataTableCompañias = objNegocioCompañias.ListandoCompañia("");
            dataTableCompañias.Columns.Add("Cant. clientes", typeof(Int32));
            dataTableClientes = objNegocioCliente.ListandoClientes(0, 0, "");
            int lengthCompañias = dataTableCompañias.Rows.Count;
            for(int i = 0; i < lengthCompañias; i++)
            {
                DataRow[] rows1 = dataTableClientes.Select("CompañiaID = '" + dataTableCompañias.Rows[i]["ID"] + "'");

                dataTableCompañias.Rows[i]["Cant. clientes"] = rows1.Length;
            }

            bttnContadorCompañias.ButtonText = Convert.ToString(dataTableCompañias.Rows.Count);
            if (mostrarTabla)
            {

                tabla.DataSource = dataTableCompañias;
                //id
                tabla.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                tabla.Columns[1].Resizable = DataGridViewTriState.False;

                //Nombre
                tabla.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                tabla.Columns[2].Resizable = DataGridViewTriState.False;
                tabla.Columns[2].ReadOnly = false;
                ((DataGridViewTextBoxColumn)tabla.Columns[2]).MaxInputLength = 50;

                //Descripcion
                tabla.Columns[3].Visible = false;


                //Cant. clientes
                tabla.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                tabla.Columns[4].Resizable = DataGridViewTriState.False;
                tabla.Columns[4].ReadOnly = true;

                tabla.Columns[0].DisplayIndex = dataTableCompañias.Columns.Count;

                tabla.ClearSelection();
            }
        }
        private void frmConfiguracion_Load(object sender, EventArgs e)
        {

            mostrarTodosCompañias(true);
            MostrarTodosTipoDocumento(false);
            
        }
        private void selecionarBoton(Bunifu.Framework.UI.BunifuThinButton2 sender,System.Windows.Forms.Panel panel)
        {
            bttnContadorCompañias.IdleForecolor = Color.DimGray;

            bttnContadorTipoDocumento.IdleForecolor = Color.DimGray;

            sender.IdleForecolor = Color.RoyalBlue;
            this.Separator.Location = new System.Drawing.Point(panel.Location.X,72);
            Separator.Width = panel.Size.Width;


        }
        private void bttnContadorCompañias_Click(object sender, EventArgs e)
        {
            posicionPagina = 1;
            selecionarBoton(bttnContadorCompañias,panelCompañiasBttn);
            mostrarTodosCompañias(true);
        }
        private void bttnTipoDocumento_Click(object sender, EventArgs e)
        {
            posicionPagina = 2;
            selecionarBoton(bttnContadorTipoDocumento,panelTipoDocumentoBttn);
            MostrarTodosTipoDocumento(true);

        }
        private void tabla_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (posicionPagina == 1)
            {
                    objEntidadCompañias.ID = Convert.ToInt32(dataTableCompañias.Rows[tabla.CurrentRow.Index]["ID"]);
                    objEntidadCompañias.Nombre = Convert.ToString(dataTableCompañias.Rows[tabla.CurrentRow.Index]["Nombre"]);
                    objEntidadCompañias.Descripcion = "";

                    objNegocioCompañias.editandoCompañia(objEntidadCompañias);
            }
            if (posicionPagina == 2)
            {

                objEntidadTipoDocumentos.ID = Convert.ToInt32(dataTableTipoDocumentos.Rows[tabla.CurrentRow.Index]["ID"]);
                objEntidadTipoDocumentos.Nombre = Convert.ToString(dataTableTipoDocumentos.Rows[tabla.CurrentRow.Index]["Nombre"]);

                objNegocioTipoDocumentos.editandoTipoDocumento(objEntidadTipoDocumentos);
            }
        }

        private void tabla_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (posicionPagina == 1)
            {
                tabla.CurrentRow.Cells[3].Value = dataTableCompañias.Rows[e.RowIndex]["Nombre"];
            }
        }

        private void eliminarCompañia()
        {
            DataRow[] rows1 = dataTableClientes.Select("CompañiaID = '" + dataTableCompañias.Rows[tabla.CurrentRow.Index]["ID"] + "'");

            DialogResult resultado = new DialogResult();
            Form mensaje;
            if (rows1.Length > 0)
            {
                mensaje = new frmSuccess(Convert.ToString(dataTableCompañias.Rows[tabla.CurrentRow.Index]["Nombre"]) + "\n¿Desea eliminar esta compañia?", "Se eliminá permanentemente\n\nContiene " + rows1.Length + " clientes.", Color.Red, "ELIMINAR", true, "eliminar");
            }
            else
            {
                mensaje = new frmSuccess(Convert.ToString(dataTableCompañias.Rows[tabla.CurrentRow.Index]["Nombre"]) + "\n¿Desea eliminar esta compañia?", "Se eliminá permanentemente", Color.Red, "ELIMINAR", true, "eliminar");
            }
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                objEntidadCompañias.ID = Convert.ToInt32(dataTableCompañias.Rows[tabla.CurrentRow.Index]["ID"]);
                objNegocioCompañias.eliminandoCompañia(objEntidadCompañias);
                mostrarTodosCompañias(true);
            }
        }
        private void eliminarTipoDocumento()
        {

            DataRow[] rows1 = dataTableClientes.Select("TipoDocumentoID = '" + dataTableTipoDocumentos.Rows[tabla.CurrentRow.Index]["ID"] + "'");

            DialogResult resultado = new DialogResult();
            Form mensaje;
            if (rows1.Length > 0)
            {
                mensaje = new frmSuccess(Convert.ToString(dataTableTipoDocumentos.Rows[tabla.CurrentRow.Index]["Nombre"]) + "\n¿Desea eliminar este tipo de documento?", "Se eliminá permanentemente\n\nContiene " + rows1.Length + " clientes.", Color.Red, "ELIMINAR", true, "eliminar");
            }
            else
            {
                mensaje = new frmSuccess(Convert.ToString(dataTableTipoDocumentos.Rows[tabla.CurrentRow.Index]["Nombre"]) + "\n¿Desea eliminar este tipo de documento", "Se eliminá permanentemente", Color.Red, "ELIMINAR", true, "eliminar");
            }
            resultado = mensaje.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                objEntidadTipoDocumentos.ID = Convert.ToInt32(dataTableTipoDocumentos.Rows[tabla.CurrentRow.Index]["ID"]);
                objNegocioTipoDocumentos.eliminandoTipoDocumento(objEntidadTipoDocumentos);
                MostrarTodosTipoDocumento(true);
            }

        }
        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (posicionPagina == 1)
            {
                if (e.ColumnIndex == 0)
                {
                    eliminarCompañia();
                }
            }
            if (posicionPagina == 2)
            {
                if (e.ColumnIndex == 0)
                {
                    eliminarTipoDocumento();
                }

            }
        }
        public void editar()
        {
            DialogResult resultado = new DialogResult();
            frmAgregarCompañia frm = new frmAgregarCompañia();
            if (posicionPagina == 1) 
            {
                frm.Text = "Nueva compañia";
                frm.tipo = 1;
                frm.lbltituloInformacion.Text = "Nueva compañia";
            }
            else if (posicionPagina == 2)
            {
                frm.Text = "Nuevo tipo de documento";
                frm.tipo = 2;
                frm.lbltituloInformacion.Text = "Nuevo tipo de documento";
            }
            resultado = frm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                if (posicionPagina == 1)
                {
                    mostrarTodosCompañias(true);
                }
                else if (posicionPagina == 2)
                {
                    MostrarTodosTipoDocumento(true);
                }
            }
        }
        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            editar();
        }
    }
}

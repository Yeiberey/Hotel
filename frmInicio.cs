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
    public partial class frmInicio : Form
    {

        public int selectEstado = 0;


        DataTable dataTableCamas = new DataTable();
        E_Cama objEntidadCama = new E_Cama();
        N_Cama objNegocioCama = new N_Cama();

        DataTable dataTableReporte = new DataTable();
        E_Reporte objEntidadReporte = new E_Reporte();
        N_Reporte objNegocioReporte = new N_Reporte();

        DataTable dataTableClientes = new DataTable();
        E_Cliente objEntidadCliente = new E_Cliente();
        N_Cliente objNegocioCliente = new N_Cliente();

        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            
            mostrarBuscar(0,"");
        }
        public void ocultarMoverAncharColumnas()
        {

            //idCama
            tablaCamas.Columns[0].Visible = false;

            //descripcionCama
            tablaCamas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tablaCamas.Columns[1].Resizable = DataGridViewTriState.False;
            tablaCamas.Columns[1].Width = 150;

            //EstadoCamaID
            tablaCamas.Columns[2].Visible = false;

            //EstadoCama
            tablaCamas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tablaCamas.Columns[3].Resizable = DataGridViewTriState.False;
            tablaCamas.Columns[3].Width = 100;

            //HabitacionID
            tablaCamas.Columns[4].Visible = false;

            //nombreHabitacion
            tablaCamas.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tablaCamas.Columns[5].Resizable = DataGridViewTriState.False;
            tablaCamas.Columns[5].Width = 150;


            //ClienteID
            tablaCamas.Columns[6].Visible = false;

            //Cliente
            tablaCamas.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tablaCamas.Columns[7].Resizable = DataGridViewTriState.False;
            tablaCamas.Columns[7].Width = 150;

            //ReporteID
            tablaCamas.Columns[8].Visible = false;

            //FechaEntrada
            tablaCamas.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaCamas.Columns[9].Resizable = DataGridViewTriState.False;


            tablaCamas.ClearSelection();

        }

        public void mostrarBuscar(int estado, string habitacion)
        {
            dataTableCamas = objNegocioCama.listandoCama(estado, habitacion);
            dataTableCamas.Columns.Add("ClienteID");
            dataTableCamas.Columns.Add("Cliente");
            dataTableCamas.Columns.Add("ReporteID");
            dataTableCamas.Columns.Add("FechaEntrada");
            int lengthCamas = dataTableCamas.Rows.Count;

            dataTableReporte = objNegocioReporte.buscarReporte("");
            dataTableClientes = objNegocioCliente.ListandoClientes(0, 0, "");
            for (int item = 0;item < lengthCamas; item++)
            {
                DataRow[] rows1 = dataTableReporte.Select("CamaID = '" + dataTableCamas.Rows[item]["ID"] + "'AND EstadoReporteID = '1'");
                int indexReporte = -1;

                if (rows1.Length > 0)
                {
                    indexReporte = dataTableReporte.Rows.IndexOf(rows1[0]);
                }
                if (indexReporte >= 0)
                {
                    DataRow[] rows2 = dataTableClientes.Select("ID = '" + dataTableReporte.Rows[indexReporte]["ClienteID"] + "'");
                    int indexCliente = -1;
                    if (rows2.Length > 0)
                    {
                        indexCliente = dataTableClientes.Rows.IndexOf(rows2[0]);
                    }

                    if (indexCliente >= 0)
                    {

                        dataTableCamas.Rows[item]["ClienteID"] = dataTableClientes.Rows[indexCliente]["ID"];
                        dataTableCamas.Rows[item]["Cliente"] = dataTableClientes.Rows[indexCliente]["Nombre"];
                        dataTableCamas.Rows[item]["ReporteID"] = dataTableReporte.Rows[indexReporte]["ID"];
                        dataTableCamas.Rows[item]["FechaEntrada"] = dataTableReporte.Rows[indexReporte]["FechaEntrada"];
                    }
                }
            }


            tablaCamas.DataSource = dataTableCamas;

            ocultarMoverAncharColumnas();
            
        }

        public void cambiarColorbttn(Bunifu.Framework.UI.BunifuThinButton2 buttom,Color backColor,Color textColor, Color activeBackColor, Color activeTextColor)
        {
            buttom.IdleFillColor = backColor;
            buttom.IdleForecolor = textColor;
            buttom.IdleLineColor = textColor;

            buttom.ActiveFillColor = activeBackColor;
            buttom.ActiveForecolor = activeTextColor;
            buttom.ActiveLineColor = activeTextColor;
            
        }

        private void bttn_disponibles_Click(object sender, EventArgs e)
        {
            cambiarColorbttn(bttn_Ocupados,Color.White,Color.Gray,Color.Red,Color.White);
            cambiarColorbttn(bttnReservados, Color.White, Color.Gray, Color.DarkOrange, Color.White);
            if (selectEstado == 1)
            {
                cambiarColorbttn(bttn_disponibles, Color.White, Color.Gray, Color.Green, Color.White);
                selectEstado = 0;
            }
            else
            {
                cambiarColorbttn(bttn_disponibles, Color.Green, Color.White, Color.White,Color.Gray);
                selectEstado = 1;
            }
            mostrarBuscar(selectEstado, txt_buscarHabitacion.Text);
        }

        private void bttn_Ocupados_Click(object sender, EventArgs e)
        {
            cambiarColorbttn(bttn_disponibles, Color.White, Color.Gray, Color.Green, Color.White);
            cambiarColorbttn(bttnReservados, Color.White, Color.Gray, Color.DarkOrange, Color.White);

            if (selectEstado == 2)
            {
                cambiarColorbttn(bttn_Ocupados, Color.White, Color.Gray, Color.Red, Color.White);
                selectEstado = 0;
            }
            else
            {
                cambiarColorbttn(bttn_Ocupados, Color.Red, Color.White, Color.White, Color.Gray);
                selectEstado = 2;
            }
            mostrarBuscar(selectEstado, txt_buscarHabitacion.Text);
        }

        private void txt_buscarHabitacion_TextChanged(object sender, EventArgs e)
        {

            mostrarBuscar(selectEstado, txt_buscarHabitacion.Text);
        }

        private void bttnReservados_Click(object sender, EventArgs e)
        {

            cambiarColorbttn(bttn_disponibles, Color.White, Color.Gray, Color.Green, Color.White);
            cambiarColorbttn(bttn_Ocupados, Color.White, Color.Gray, Color.Red, Color.White);

            if (selectEstado == 3)
            {
                cambiarColorbttn(bttnReservados, Color.White, Color.Gray, Color.DarkOrange, Color.White);
                selectEstado = 0;
            }
            else
            {
                cambiarColorbttn(bttnReservados, Color.DarkOrange, Color.White, Color.White, Color.Gray);
                selectEstado = 3;
            }
            mostrarBuscar(selectEstado, txt_buscarHabitacion.Text);
        }
    }
}

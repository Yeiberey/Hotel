using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmSuccess("¿Desea salir?","Salir en modo seguro",Color.Red,"Salir",true,"salir");
            resultado = mensaje.ShowDialog();
        }

        private void pantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pantallaOk();
            abrirFormulario(new frmInicio());
        }
        private Form formAbierto = null;
        private void abrirFormulario(Form hijo)
        {

            if(formAbierto != null)
            {
                formAbierto.Close();
                formAbierto = hijo;
            }
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            wrapper.Controls.Add(hijo);
            wrapper.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();

        }

        private void selecionarBoton(Bunifu.Framework.UI.BunifuFlatButton sender, System.Windows.Forms.PictureBox picture, System.Drawing.Bitmap Image)
        {
            bttn_habitacionesIr.Textcolor = Color.White;
            bttn_habitacionesIr.Normalcolor = Color.Transparent;
            bttn_habitacionesIr.Iconimage = Hotel.Properties.Resources.habitacion1;
            bttn_habitacionesIr.OnHovercolor = Color.Transparent;
            img_seleccionInicio.Visible = false;

            bttn_reportesIr.Textcolor = Color.White;
            bttn_reportesIr.Normalcolor = Color.Transparent;
            bttn_reportesIr.Iconimage = Hotel.Properties.Resources.alquilar1;
            bttn_reportesIr.OnHovercolor = Color.Transparent;
            img_seleccionReportes.Visible = false;

            bttnHabitacionesIr.Textcolor = Color.White;
            bttnHabitacionesIr.Normalcolor = Color.Transparent;
            bttnHabitacionesIr.Iconimage = Hotel.Properties.Resources.habitacion1;
            bttnHabitacionesIr.OnHovercolor = Color.Transparent;
            img_seleccionHabitaciones.Visible = false;

            bttnClientesIr.Textcolor = Color.White;
            bttnClientesIr.Normalcolor = Color.Transparent;
            bttnClientesIr.Iconimage = Hotel.Properties.Resources.cliente1;
            bttnClientesIr.OnHovercolor = Color.Transparent;
            img_seleccionClientes.Visible = false;

            bttnConfiguración.Textcolor = Color.White;
            bttnConfiguración.Normalcolor = Color.Transparent;
            bttnConfiguración.Iconimage = Hotel.Properties.Resources.configuracion1;
            bttnConfiguración.OnHovercolor = Color.Transparent;
            img_seleccionConfiguración.Visible = false;



            sender.selected = true;
            if (sender.selected)
            {
                sender.Textcolor = Color.Black;
                sender.Normalcolor = Color.White;
                sender.Activecolor = Color.White;
                sender.OnHovercolor = Color.White;
                sender.Iconimage = Image;
                picture.Visible = true;
                lbl_tituloPagina.Text = sender.Text;
            }

        }

        private void bttn_habitacionesIr_Click(object sender, EventArgs e)
        {
            selecionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender, img_seleccionInicio, Hotel.Properties.Resources.habitacion);
            abrirFormulario(new frmInicio());
            
            
            
        }

        private void bttn_reportesIr_Click(object sender, EventArgs e)
        {
            selecionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender, img_seleccionReportes, Hotel.Properties.Resources.alquilar);
            abrirFormulario(new frmReportes());
        }

        private void bttnHabitacionesIr_Click(object sender, EventArgs e)
        {
            selecionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender, img_seleccionHabitaciones, Hotel.Properties.Resources.habitacion);
            abrirFormulario(new frmHabitaciones());
        }

        private void bttnClientesIr_Click(object sender, EventArgs e)
        {
            selecionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender, img_seleccionClientes, Hotel.Properties.Resources.cliente);
            abrirFormulario(new frmClientes());
        }

        private void bttnEntidades_Click(object sender, EventArgs e)
        {
            selecionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender, img_seleccionConfiguración, Hotel.Properties.Resources.configuracion);
            abrirFormulario(new frmConfiguracion());
        }
    }
}

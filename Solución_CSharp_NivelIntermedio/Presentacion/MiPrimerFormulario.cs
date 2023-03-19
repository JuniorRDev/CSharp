using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MiPrimerFormulario : Form
    {
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }

        private void MiPrimerFormulario_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = true;

            //txt_codigo.Enabled = true;
            //txt_descripcion.Enabled = true;
            //btn_cancelar.Visible = true;
            //btn_guardar.Visible = true;

            //Inhabilitar los botones al seleccionar nuevo
            //btn_nuevo.Enabled = false;
            //btn_actualizar.Enabled = false;
            //btn_reporte.Enabled = false;
            //btn_eliminar.Enabled = false;
            //btn_salir.Enabled = false;

            grb_botones_principales.Enabled = false;

           // txt_codigo.Select();
            txt_codigo.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled=false;

            //txt_codigo.Enabled = false;
            //txt_descripcion.Enabled = false;

            //btn_cancelar.Visible = false;
            //btn_guardar.Visible = false;

            // Habilitar la barra de los botones despues de darle a cancelar
            //btn_nuevo.Enabled = true;
            //btn_actualizar.Enabled = true;
            //btn_reporte.Enabled = true;
            //btn_eliminar.Enabled = true;
            //btn_salir.Enabled = true;

            grb_botones_principales.Enabled=true;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Cuando precione guardar, quiero que los datos de codigo y descripcion se guarden
            //en el lst_mantenimiento

            string registro;
            registro = txt_codigo.Text.Trim() +" | " + txt_descripcion.Text.Trim();
            
            lst_mantenimiento.Items.Add(registro);

            MessageBox.Show("Datos Guardados");

            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;

            grb_botones_principales.Enabled = true;

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);
            MessageBox.Show("Elemento eliminado");
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {

        }

        private void lst_mantenimiento_Click(object sender, EventArgs e)
        {
            //
            string textoSeleccionado;
            int longitudTexto;

            textoSeleccionado = lst_mantenimiento.SelectedItem.ToString().Trim();//trim para eliminar espacios de los lados
            longitudTexto = textoSeleccionado.Length;

            txt_codigo.Text = textoSeleccionado.Substring(0,3); //Substraer la longitud de esta variable en este caso le pusimos maxlength 3
            txt_descripcion.Text = textoSeleccionado.Substring(6, longitudTexto - 6);//Substraer la el texto de la descripcion, tomando en cuenta que
                                                                                     //cuantos elementos hay antes de llegar a esa longitud y restandolo así mismo
            
        }
    }
}

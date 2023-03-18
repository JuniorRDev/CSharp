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
    public partial class frm_encuesta : Form
    {
        public frm_encuesta()
        {
            InitializeComponent();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            string resultado, resultadoClase;
            
            resultado = "";
            resultadoClase = "";

            if(chk_vfp.Checked == true ) 
            {
                //Resultado = Resultado + chk_vfp.Text;
                //El de arriba es lo mismo pero el que utilizo es mas simplificado
                resultado += chk_vfp.Text + "\r\n"; ;
            }
            if (chk_csharp.Checked == true)
            {
               resultado += chk_csharp.Text + "\r\n"; ;
            }
            if (chk_vbnet.Checked == true)
            {
                resultado += chk_vbnet.Text + "\r\n"; ;
            }
            if (chk_java.Checked == true)
            {
                resultado += chk_java.Text + "\r\n"; ;
            }

            //Evaluando proceso de seleccion del radiobutton
            if (rdb_presencial.Checked == true)
            {
                resultadoClase += rdb_presencial.Text;
            }
            else
            {
                resultadoClase += rdb_virtual.Text;
            }
            txt_resultado.Text = resultado + "Las clases se impartirán de forma: " + resultadoClase;
        }

    }
}

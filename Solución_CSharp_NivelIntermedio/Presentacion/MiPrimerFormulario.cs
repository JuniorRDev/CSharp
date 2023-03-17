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
            txt_codigo.Text = string.Empty;
            txt_descripcion.Text = string.Empty;
            txt_codigo.Enabled = true;
            txt_descripcion.Enabled = true;    
           // txt_codigo.Select();
            txt_codigo.Focus();
        }
    }
}

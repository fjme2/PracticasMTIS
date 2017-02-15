using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpolaridad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butdni_Click(object sender, EventArgs e)
        {
            String key = txtdnikey.Text.ToString();
            String dni = txtdni.Text.ToString();
            eclipse.Pr1 obj = new eclipse.Pr1();
            String mensaje = obj.ValidarNIF(dni, key);
            label1.Text = mensaje;
        }

        private void butcodpos_Click(object sender, EventArgs e)
        {
            String key = txtcodposkey.Text.ToString();
            String codpos = txtcodpos.Text.ToString();
            String pob = "";
            String prov = "";
            eclipse.Pr1 postal = new eclipse.Pr1();
            postal.consultaCodigoPostal(codpos, key, out pob, out prov);
            lbpob.Text = pob;
            lbprov.Text = prov;
        }
    }
}

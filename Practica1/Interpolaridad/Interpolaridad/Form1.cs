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

        private void butgen_Click(object sender, EventArgs e)
        {
            int cantidad, id;
            bool generado= false;
            id = int.Parse(txtcli.Text);
            DateTime fecha = dateTimePicker1.Value;
            cantidad = int.Parse(txtcant.Text);
            String referencia = txtref.Text.ToString();
            String key = txtgenkey.Text.ToString();
            eclipse.Pr1 gen = new eclipse.Pr1();
            int presu = gen.generarPresupuesto(key, fecha, id, referencia, cantidad, out generado);
            if (generado==true)
            {
                lblid.Text = presu.ToString();
            }else
            {
                lblid.Text = "ERROR";
            }
            
        }

        private void butsoli_Click(object sender, EventArgs e)
        {
            String key = txtkeysoli.Text.ToString();
            String referencia = txtrefsoli.Text.ToString();
            int prov = int.Parse(txtprov.Text);
            eclipse.Pr1 soli = new eclipse.Pr1();
            bool disp = false;
            DateTime fecha = new DateTime();
            try
            {
                float precio = soli.solicitarPresupuesto(key, referencia, prov, out disp, out fecha);
                lblprecio.Text = precio.ToString();
                if (disp == true)
                {
                    lblfecha.Text = "Disponible!";
                }
                else
                {
                    lblfecha.Text = fecha.ToString();
                }
            }catch(Exception ex)
            {
                lblprecio.Text = "ERROR";
                lblfecha.Text = "ERROR";
            }
           
        }

        private void butiban_Click(object sender, EventArgs e)
        {
            String key = txtkeyiban.Text.ToString();
            String iban = txtiban.Text.ToString();
            String mensaje = "";
            eclipse.Pr1 comprobar = new eclipse.Pr1();
            bool correcto = comprobar.ValidarIBAN(iban, key, out mensaje);
            lbliban.Text = mensaje;
        }
    }
}

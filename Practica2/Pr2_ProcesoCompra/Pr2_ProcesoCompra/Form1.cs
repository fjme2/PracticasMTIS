using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2_ProcesoCompra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProcesoCompra.ProcesoCompraRequest comprar = new ProcesoCompra.ProcesoCompraRequest();
                comprar.referencia = txtReferencia.Text;
                comprar.cantidad = int.Parse(txtCantidad.Text);
                ProcesoCompra.ProcesoCompraBinding soap = new ProcesoCompra.ProcesoCompraBinding();
                lblResul.Text = soap.process(comprar).funciona.ToString();
            }
            catch(Exception ex)
            {
                lblResul.Text = "Error en la compra";
            }

        }
    }
}

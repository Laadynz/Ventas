using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto memoria = new Producto();
            memoria.Codigo = "001";
            memoria.Descripcion = "Memoria RAM";
            memoria.PrecioUnitario = 100.15m;
        }
    }
}

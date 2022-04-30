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

            Producto discoDuro = new Producto() 
            {
                Codigo = "002",
                Descripcion = "Memoria RAM 206",
                PrecioUnitario = 1150.15m
            
            };

            Producto Laptop = new Producto() 
            {
               Codigo = "2112",
               Descripcion = "Computadora Portatil DELL",
               PrecioUnitario = 12000m
            };

            List<Producto> productos = new List<Producto>();
            productos.Add(memoria);
            productos.Add(discoDuro);
            productos.Add(Laptop);

            dgvProductos.DataSource = productos;

        } 
    }
}

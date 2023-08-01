using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Precentacion
{
    public partial class frmVerDetalle : Form
    {
        private Articulos articulos;
        public frmVerDetalle()
        {
            InitializeComponent();
        }
        public frmVerDetalle(Articulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
            Text = "Detalle del producto";

        }
        private void frmVerDetalle_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                txtCodigoDetalle.Text = articulos.Codigo;
                txtNombreDetalle.Text = articulos.Nombre;
                txtDescripcionDetalle.Text = articulos.Descripcion;
                pbxArticulosDetalle.Text = articulos.UrlImagen;
                cargarImagen(pbxArticulosDetalle.Text);
                txtCategoriaDetalle.Text = articulos.Categoria.ToString();
                txtMarcaDetalle.Text = articulos.Marcas.ToString();
                txtPrecioDetalle.Text = articulos.Precio.ToString("$0,00");


                negocio.verDetalle(articulos);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulosDetalle.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulosDetalle.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

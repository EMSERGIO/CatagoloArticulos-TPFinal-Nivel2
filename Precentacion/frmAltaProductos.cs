using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Precentacion
{
    public partial class frmAltaProductos : Form
    {
        public frmAltaProductos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                art.Codigo = txtCodigo.Text;
                art.Nombre = txtNombre.Text;
                art.Descripcion = txtDescripcion.Text;
                art.UrlImagen = txtUrlImagen.Text;
                art.Marcas = (Marcas)cboMarca.SelectedItem;
                art.Categoria = (Categoria)cboCategoria.SelectedItem;
                art.Precio = int.Parse(txtPrecio.Text);
              

                negocio.agregar(art);
                MessageBox.Show("Articulo agredado correctamente...");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmAltaProductos_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcasNegocio marcaNegocio = new MarcasNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

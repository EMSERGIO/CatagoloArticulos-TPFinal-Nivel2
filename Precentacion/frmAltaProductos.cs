using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace Precentacion
{
    public partial class frmAltaProductos : Form
    {
        private Articulos articulos = null;
        private OpenFileDialog archivo = null;

        public frmAltaProductos()
        {
            InitializeComponent();
        }
        public frmAltaProductos(Articulos articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
            Text = "Modificar Producto";
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if(articulos == null)
                    articulos = new Articulos();

                articulos.Codigo = txtCodigo.Text;
                articulos.Nombre = txtNombre.Text;
                articulos.Descripcion = txtDescripcion.Text;
                articulos.UrlImagen = txtUrlImagen.Text;
                articulos.Marcas = (Marcas)cboMarca.SelectedItem;
                articulos.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulos.Precio = int.Parse(txtPrecio.Text);
              
                if(articulos.Id != 0)
                {
                    negocio.modificar(articulos);
                    MessageBox.Show("Articulo modificado correctamente...");
                }
                else
                {
                    negocio.agregar(articulos);
                    MessageBox.Show("Articulo agredado correctamente...");
                }

                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta-imagen"] + archivo.SafeFileName);
                }


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
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if (articulos != null)
                {
                    txtCodigo.Text = articulos.Codigo;
                    txtNombre.Text = articulos.Nombre;
                    txtDescripcion.Text = articulos.Descripcion;
                    txtUrlImagen.Text = articulos.UrlImagen;
                    cargarImagen(articulos.UrlImagen);
                    cboCategoria.SelectedValue = articulos.Categoria.Id;
                    cboMarca.SelectedValue = articulos.Marcas.Id;
                    txtPrecio.Text = articulos.Precio.ToString("$0,00");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text); 
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png|JPG|*.jpg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }

}


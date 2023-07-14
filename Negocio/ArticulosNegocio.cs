using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Codigo, Nombre,A.Descripcion as Detalle, ImagenUrl as UrlImagen, Precio , C.Descripcion as Categoria, M.Descripcion as Marcas from ARTICULOS A,CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria and M.Id = A.IdMarca";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Detalle"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Precio = (float)(Decimal)lector["Precio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.Marcas = new Marcas();
                    aux.Marcas.Descripcion = (string)lector["Marcas"];


                    lista.Add(aux);
                }
                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
             try
             {
                datos.setearConsulta("Insert Into Articulos (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria) values (@Codigo, @Nombre, @Descripcion, @ImagenUrl, @Precio, @IdMarca, @IdCategoria)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@ImagenUrl", nuevo.UrlImagen);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@IdMarca", nuevo.Marcas.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);

                datos.ejecutarAccion();
             }
             catch (Exception ex)
             {

                throw ex;
             }
            finally
            {
                datos.cerrarConexion();
            }  
        }
        public void modificar(Articulos modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("");

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}

        }
    }
}

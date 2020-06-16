using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using TiendaIdeasElArca.Models;

namespace TiendaIdeasElArca.Context
{
    public class My_CRUD_DB
    {
        string connectionString = "Data Source =LAPTOP-C42Q2V8V\\SQLEXPRESS01; Initial Catalog = IdeasElArca; Integrated Security=SSPI";
        /// <summary>
        /// Obtenemos todos los usuarios
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            var ListaUsuarios = new List<Usuario>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_ConsultaUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    var usuario = new Usuario();
                    usuario.id = Convert.ToInt32(dr["id"].ToString());
                    usuario.Nombre = dr["Nombre"].ToString();
                    usuario.Correo = dr["Correo"].ToString();
                    usuario.Direccion = dr["Direccion"].ToString();
                    usuario.Telefono = dr["Telefono"].ToString();

                    ListaUsuarios.Add(usuario);
                }
                con.Close();
            }
            return ListaUsuarios;
        }
        /// <summary>
        /// Creación Usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void CrearUsuario(Usuario usuario)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_CrearUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        /// <summary>
        /// Actualización Usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void ActualizarUsuario(Usuario usuario)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_ActualizarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", usuario.id);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        /// <summary>
        /// Eliminación de Usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void EliminarUsuario(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        /// <summary>
        /// Consulta de Usuario por ID
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario ConsultaUsuarioPorID(int id)
        {
            var usuario = new Usuario();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_ConsultaUsuarioPorID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(); 
                while (dr.Read())
                {
                    usuario.id = Convert.ToInt32(dr["id"].ToString());
                    usuario.Nombre = dr["Nombre"].ToString();
                    usuario.Correo = dr["Correo"].ToString();
                    usuario.Direccion = dr["Direccion"].ToString();
                    usuario.Telefono = dr["Telefono"].ToString(); 
                }
                con.Close();
            }
            return usuario;
        }
        
        /// <summary>
        /// Creación Producto
        /// </summary>
        /// <param name="usuario"></param>
        public int CrearProducto(Producto producto)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_CrearProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Imagen", producto.Imagen);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);

                con.Open();
                int resultado = cmd.ExecuteNonQuery();
                con.Close(); 
                return resultado;
            }
        }
        /// <summary>
        /// Obtenemos todos los Productos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Producto> ConsultarProductos()
        {
            var ListaProductos = new List<Producto>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_ConsultaProductos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var producto = new Producto();
                    producto.id = Convert.ToInt32(dr["id"].ToString());
                    producto.Nombre = dr["Nombre"].ToString();
                    producto.Descripcion = dr["Descripcion"].ToString();
                    producto.Imagen = dr["Imagen"].ToString();
                    producto.Precio = dr["Precio"].ToString();

                    ListaProductos.Add(producto);
                }
                con.Close();
            }
            return ListaProductos;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaIdeasElArca.Context;

namespace TiendaIdeasElArca.Models
{
    public class ProductosBL
    {
        My_CRUD_DB _dal = new My_CRUD_DB();
        public int CrearProducto(Producto producto)
        {
            return _dal.CrearProducto(producto);
        }
        public IEnumerable<Producto> ConsultarProductos()
        {
            return _dal.ConsultarProductos();
        }
    }
}

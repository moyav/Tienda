using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TiendaIdeasElArca.Context;
using TiendaIdeasElArca.Models;

namespace TiendaIdeasElArca.Controllers
{
    public class UsuarioController : Controller
    {
        My_CRUD_DB dbContext = new My_CRUD_DB();

        // GET: Usuario
        public ActionResult Index()
        {
            List<Usuario> ListaUsuarios = dbContext.ObtenerUsuarios().ToList();
            return View(ListaUsuarios);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            Usuario usuario = dbContext.ConsultaUsuarioPorID(id);
            
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {   
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Usuario usuario)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    dbContext.CrearUsuario(usuario);
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            Usuario usuario = dbContext.ConsultaUsuarioPorID(id);

            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind] Usuario usuario)
        {
            try
            {
                // TODO: Add update logic here
                if (id <= 0)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    dbContext.ActualizarUsuario(usuario);
                    return RedirectToAction("Index");
                }
                return View(dbContext);
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            Usuario usuario = dbContext.ConsultaUsuarioPorID(id);

            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                // TODO: Add delete logic here
                dbContext.EliminarUsuario(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
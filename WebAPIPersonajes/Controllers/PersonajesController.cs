using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIPersonajes.Models;

namespace WebAPIPersonajes.Controllers
{
    public class PersonajesController : Controller
    {
        // GET: PersonajesController
        public ActionResult Index()
        {
            List<Personaje> listaPersonajes = new();
            listaPersonajes.Add(new Personaje() { Id = 1, Name = "Superman", Force = 100, Hight = 190, canFly = true, BirthDate = new DateTime(1938, 6, 1) });
            listaPersonajes.Add(new Personaje() { Id = 2, Name = "Batman", Force = 85, Hight = 185, canFly = false, BirthDate = new DateTime(1939, 5, 1) });
            listaPersonajes.Add(new Personaje() { Id =3, Name = "Spiderman", Force = 90, Hight = 175, canFly = false, BirthDate = new DateTime(1962, 8, 1) });

            return View(listaPersonajes);
        }

        // GET: PersonajesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonajesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonajesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonajesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonajesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonajesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonajesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

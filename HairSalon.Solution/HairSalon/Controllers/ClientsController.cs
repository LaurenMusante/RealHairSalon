using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
    public class ItemsController : Controller
    {
        private readonly HairSalonContext _db;

        public ItemsController(HairSalonContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Client> model = _db.Clients.Include(client => clients.Stylist).ToList(); //We can utilize eager loading by using Entity's built-in Include() methodThis basically states the following: for each Item in the database, include the Category it belongs to and then put all the Items into list.
            return View(model);
        }


        public ActionResult Create()
        {
            ViewBag.Stylist = new SelectList(_db.Stylists, "StylistId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            _db.Items.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
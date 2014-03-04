using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormToDbDemo.Models;
using FormToDbDemo.DAL;

namespace FormToDbDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var repo = new EquipmentRepo();
            var equipItems = repo.Equipments.ToList();
            return View(equipItems);
        }

        public ActionResult Init()
        {
            var repo = new EquipmentRepo();
            repo.Init();
            var equipItems = repo.Equipments.ToList();
            return View(equipItems);
        }

        public ActionResult List()
        {
            var repo = new EquipmentRepo();
            var equipItems = repo.Equipments.ToList();
            return View(equipItems);
        }

        public ActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddItem(Equipment item)
        {
            var repo = new EquipmentRepo();
            repo.SaveItem(item);
            return RedirectToAction("List");
        }
    }
}

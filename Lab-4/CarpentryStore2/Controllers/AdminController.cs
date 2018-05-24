using CarpentyStore2.Domain.Abstract;
using CarpentyStore2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarpentryStore2.Controllers
{
    public class AdminController : Controller
    {
        private IDoorRepository repository;

        public AdminController (IDoorRepository repo)
        {
            repository = repo;
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View(repository.Doors);
        }

        public ActionResult Edit(int doorId)
        {
            Door door = repository.Doors
                .FirstOrDefault(d => d.DoorId == doorId);
            return View(door);
        }

        [HttpPost]
        public ActionResult Edit(Door door, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    door.ImageMimeType = image.ContentType;
                    door.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(door.ImageData, 0, image.ContentLength);
                }
                repository.SaveDoor(door);
                TempData["message"] = string.Format("{0} has been saved ", door.TypeDoor);
                return RedirectToAction("Index");
            }
            else
            {
                return View(door);
            }
        }
        // Добавление нового товара в Doors
        public ViewResult Create()
        {
            return View("Edit", new Door());
        }

        public ViewResult CreateLand()
        {
            return View("EditLand", new Land());
        }

        public ActionResult LandIndex()
        {
            return View(repository.Lands);
        }

        public ActionResult EditLand(int landId) 
        {
            Land land = repository.Lands.
                FirstOrDefault(l => l.LandId == landId);
            return View(land);
        }

        // EditLand для редактирования таблицы Lands.
        [HttpPost]
        public ActionResult EditLand(Land land, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    land.ImageMimeType = image.ContentType;
                    land.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(land.ImageData, 0, image.ContentLength);
                }
                repository.SaveLand(land);
                TempData["message"] = string.Format("{0} has been saved", land.TypeOfLand);
                return RedirectToAction("LandIndex");                
            }
            else
            {
                return View(land);
            }
        }

        [HttpPost]
        public ActionResult DeleteLand(int LandId)
        {
            Land deletedLand  = repository.DeleteLand(LandId);
            if (deletedLand != null)
            {
                TempData["message"] = String.Format("{0} was deleted", deletedLand.TypeOfLand);
            }
            return RedirectToAction("LandIndex");
        }

        [HttpPost]
        public ActionResult Delete(int DoorId)
        {
            Door deletedDoor = repository.DeleteDoor(DoorId);
            if (deletedDoor != null)
            {
                TempData["message"] = String.Format("{0} was deleted", deletedDoor.TypeDoor);
            }
            return RedirectToAction("Index");
        }

        public ActionResult ArmchairIndex()
        {
            return View(repository.Armchairs);
        }
             
        public ActionResult EditArmchair(int ArmchairId)
        {
            Armchair armchair = repository.Armchairs.
                FirstOrDefault(l => l.ArmchairId == ArmchairId);
            return View(armchair);
        }

        // EditLand для редактирования таблицы Armchairs.
        [HttpPost]
        public ActionResult EditArmchair(Armchair armchair, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    armchair.ImageMimeType = image.ContentType;
                    armchair.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(armchair.ImageData, 0, image.ContentLength);
                }
                repository.SaveArmchair(armchair);
                TempData["message"] = string.Format("{0} has been saved", 
                    armchair.TypeOfArmchair);
                return RedirectToAction("ArmchairIndex");
            }
            else
            {
                return View(armchair);
            }
        }

        public ViewResult CreateArmchair()
        {
            return View("EditArmchair", new Land());
        }

        [HttpPost]
        public ActionResult DeleteArmchair(int ArmchairId)
        {
            Armchair deletedArmchair = repository.DeleteArmchair(ArmchairId);
            if (deletedArmchair != null)
            {
                TempData["message"] = String.Format("{0} was deleted",
                    deletedArmchair.TypeOfArmchair);
            }
            return RedirectToAction("ArmchairIndex");
        }



        public ActionResult TableIndex()
        {
            return View(repository.Tables);
        }


        public ActionResult EditTable(int TableId)
        {
            Table table = repository.Tables.
                FirstOrDefault(l => l.TableId == TableId);
            return View(table);
        }

        // EditLand для редактирования таблицы Armchairs.
        [HttpPost]
        public ActionResult EditTable(Table table, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    table.ImageMimeType = image.ContentType;
                    table.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(table.ImageData, 0, image.ContentLength);
                }
                repository.SaveTable(table);
                TempData["message"] = string.Format("{0} has been saved",
                    table.TypeOfTable);
                return RedirectToAction("TableIndex");
            }
            else
            {
                return View(table);
            }
        }

        [HttpPost]
        public ActionResult DeleteTable (int TableId)
        {
            Table deletedTable = repository.DeleteTable(TableId);
            if (deletedTable != null)
            {
                TempData["message"] = String.Format("{0} was deleted", deletedTable.TypeOfTable);
            }
            return RedirectToAction("TableIndex");
        }


    }
}
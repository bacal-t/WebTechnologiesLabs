using CarpentryStore2.Models;
using CarpentyStore2.Domain.Abstract;
using CarpentyStore2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarpentryStore2.Controllers
{
    public class HomeController : Controller
    {
        private IDoorRepository repository;

        public int PageSize = 4;

        public HomeController(IDoorRepository doorRepository)
        {
            this.repository = doorRepository;
        }
        // Для вкладки Главная
        public ActionResult Index(int page = 1 )
        {
            DoorsListViewModel model = new DoorsListViewModel()
            {
                Doors = repository.Doors
                 .OrderBy(p => p.DoorId)
                 .Skip((page - 1) * PageSize)
                 .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Doors.Count()
                }
            };
            return View(model);
        }

        public ActionResult Lands (int page = 1)
        {
            LandsListViewModel model = new LandsListViewModel()
            {
                Lands = repository.Lands
                 .OrderBy(p => p.LandId)
                 .Skip((page - 1) * PageSize)
                 .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Doors.Count()
                }
            };
            return View(model);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public FileContentResult GetImage(int doorId)
        {
            Door door = repository.Doors.FirstOrDefault(d => d.DoorId == doorId);
            if (door != null)
            {
                return File(door.ImageData, door.ImageMimeType);
            }
            else
            {
                return null;
            }
        }


        // Получаем фото из таблицы Lands
        public FileContentResult LandGetImage(int landId)
        {
            Land land = repository.Lands.FirstOrDefault(l => l.LandId == landId);
            if (land != null)
            {
                return File(land.ImageData, land.ImageMimeType);
            }
            else
            {
                return null;
            }
        }


        // Для вкладки Дерево.
        public ActionResult Tree()
        {
            return View();
        }
        // Для вкладки Сроки.
        public ActionResult DateExecuting ()
        {
            return View();
        }

        public ActionResult Armchairs (int page = 1)
        {
            ArmchairListViewModel model = new ArmchairListViewModel()
            {
                Armchairs = repository.Armchairs
                 .OrderBy(p => p.ArmchairId)
                 .Skip((page - 1) * PageSize)
                 .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Doors.Count()
                }
            };
            return View(model);
        }

        // Получаем фото из таблицы  Armchair
        public FileContentResult ArmchairGetImage(int ArmchairId)
        {
            Armchair land = repository.Armchairs.FirstOrDefault(l => l.ArmchairId == ArmchairId);
            if (land != null)
            {
                return File(land.ImageData, land.ImageMimeType);
            }
            else
            {
                return null;
            }
        }

        public ActionResult Tables(int page = 1)
        {
            TableListViewModel model = new TableListViewModel()
            {
                Tables = repository.Tables
                 .OrderBy(p => p.TableId)
                 .Skip((page - 1) * PageSize)
                 .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Tables.Count()
                }
            };
            return View(model);

         }

        // Получаем фото из таблицы  Armchair
        public FileContentResult TableGetImage(int TableId)
        {
            Table table = repository.Tables.FirstOrDefault(l => l.TableId == TableId);
            if (table != null)
            {
                return File(table.ImageData, table.ImageMimeType);
            }
            else
            {
                return null;
            }
        }

        public ActionResult AboutSite()
        {
            return View();
        }

        public ActionResult Authorized()
        {
            return View();
        }

    }
}
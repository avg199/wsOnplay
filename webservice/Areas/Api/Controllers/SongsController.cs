using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webservice.Areas.Api.Models;

namespace webservice.Areas.Api.Controllers
{
    public class SongsController : Controller{

        private SongManager songManager;

        public SongsController()
        {
            songManager = new SongManager();
        }

        // GET: Api/Songs
        [HttpGet]
        public JsonResult song()
        {
            return Json(songManager.obtenirSongs(),JsonRequestBehavior.AllowGet);
        }

        //public JsonResult song(int? id, song item)
        //{
        //    //Un switch per si mes endevant s'han d'introduir mes
        //    switch (Request.HttpMethod)
        //    {
        //        case "GET":
        //            return Json(songManager.obtenirSong(id.GetValueOrDefault()), JsonRequestBehavior.AllowGet);
        //    }

        //    return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        //}

        // GET: Api/Songs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Api/Songs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Api/Songs/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Api/Songs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Api/Songs/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Api/Songs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Api/Songs/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

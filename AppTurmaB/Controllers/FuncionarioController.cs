using AppTurmaB.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTurmaB.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index(Funcionario funcionario)
        {
            return View(funcionario);
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        public ActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Index", funcionario);
            return View();
        }

        public ActionResult ValidaLogin(string login)
        {
            var dbexemplo = new Collection<String>()
            {
                "Enildo 01",
                "Enildo 02",
                "Enildo 03",
                "Enildo 04",
                "Enildo 05"
            };
            return Json(dbexemplo.All(
                                        a => a.ToLower() != login.ToLower()), 
                                        JsonRequestBehavior.AllowGet
                                     );
        }

        //// GET: Funcionario/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}
        // GET: Funcionario/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// POST: Funcionario/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Funcionario/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Funcionario/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}

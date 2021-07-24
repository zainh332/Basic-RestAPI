using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestAPI.Models;

namespace RestAPI.Controllers
{
    public class StudentdataController : Controller
    {
        // GET: Studentdata
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public List<studentdemodata> Get()
        {
           studentdatalist stdobj = new studentdatalist();
           return stdobj.std;

        }

        // GET: Studentdata/Details/5
        public studentdemodata Get(int id)
        {
            studentdemodata sdreturn = null;
            studentdatalist stdobj = new studentdatalist();
           foreach (studentdemodata sd in stdobj.std)
            {
                if(sd.rollno == id)
                {
                    sdreturn = sd;
                    break;
                }
            }
            return sdreturn;
        }

        // GET: Studentdata/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studentdata/Create
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

        // GET: Studentdata/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Studentdata/Edit/5
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

        // GET: Studentdata/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Studentdata/Delete/5
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

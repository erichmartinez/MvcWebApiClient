using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcWebApiClientNestedPayload.Models;
using WebApiRestService;
using System.Threading.Tasks;

namespace MvcWebApiClientNestedPayload.Controllers
{
    public class PersonController : Controller
    {
        private WebApiClientOptions options = new WebApiClientOptions("http://localhost:65386/api", "person");
        // GET: Person
        public async Task<ActionResult> Index()
        {
            List<PersonModel1> list = null;

            using (WebApiClient<PersonModel1> client = new WebApiClient<PersonModel1>(options))
            {
                list = await client.GetManyAsync();
            }

            return View(list);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
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

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
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

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
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

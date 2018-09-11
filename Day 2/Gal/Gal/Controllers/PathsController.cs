using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gal.Models;
using PagedList.Mvc;
using PagedList;

namespace Gal.Controllers
{
    public class PathsController : Controller
    {
        private ImageModule db = new ImageModule();

        // GET: Pathes
        public ActionResult Index(int? page)
        {
            var records = new List<Path>();

            foreach (var item in db.Paths)
            {
                records.Add(item);
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(records.ToPagedList(pageNumber, pageSize));
        }
    }
}

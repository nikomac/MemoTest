﻿using MemoTest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemoTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var notes = NotesDAL.Retrieve(new Models.NoteRequest());


            return View(notes);
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
    }
}
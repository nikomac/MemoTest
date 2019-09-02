using MemoTest.DAL;
using MemoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemoTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(NoteRequest request)
        {
            var notes = NotesDAL.Retrieve(request);

            ViewBag.Title = "Notes";

            return View(notes);
        }

        public ActionResult Edit(Note note)
        {
            ViewBag.Title = "Edit " + note.Name;

            return View(note);
        }

        public ActionResult Create()
        {
            ViewBag.Title = "New";

            return View("Edit", new Note() { CreationDate = DateTime.Now, EditionDate = DateTime.Now });
        }

        public ActionResult Pin(Note note)
        {
            note.IsMarked = !note.IsMarked;
            NotesDAL.Update(note);

            return RedirectToAction("Index");
        }

        public ActionResult Save(Note note)
        {
            if (note.Id == 0)
                NotesDAL.Create(note);
            else
                NotesDAL.Update(note);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            NotesDAL.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
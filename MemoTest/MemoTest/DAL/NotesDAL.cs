using MemoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoTest.DAL
{
    public class NotesDAL : BaseDal
    {

        public static List<Note> Retrieve(NoteRequest request)
        {
            List<Note> list = new List<Note>();

            using (MemoTestContext ctx = new MemoTestContext(GetConnectionString()))
            {
                list.AddRange((from note in ctx.Notes
                               where
                                     (string.IsNullOrEmpty(request.Name) || note.Name == request.Name)
                               orderby note.IsMarked descending, note.CreationDate descending
                               select note).ToList());
            }
            return list;
        }

        public static Note Get(int id)
        {
            Note result = null;

            using (MemoTestContext ctx = new MemoTestContext(GetConnectionString()))
            {
                result = (from note in ctx.Notes
                          where note.Id == id
                          select note).FirstOrDefault();
            }
            return result;
        }


        public static Note Create(Note note)
        {
            note.CreationDate = DateTime.Now;
            note.EditionDate = DateTime.Now;

            using (MemoTestContext ctx = new MemoTestContext(GetConnectionString()))
            {
                ctx.Notes.Add(note);
                ctx.SaveChanges();
            }
            return note;
        }

        public static Note Update(Note note)
        {
            using (MemoTestContext ctx = new MemoTestContext(GetConnectionString()))
            {
                var result = ctx.Notes.FirstOrDefault(n => n.Id == note.Id);
                if (result != null)
                {
                    result.Name = note.Name;
                    result.Data = note.Data;
                    result.IsMarked = note.IsMarked;
                    result.EditionDate = DateTime.Now;
                    ctx.SaveChanges();
                }

                return result;
            }
        }


        public static void Delete(int id)
        {
            using (MemoTestContext ctx = new MemoTestContext(GetConnectionString()))
            {
                Note note = new Note() { Id = id };
                ctx.Notes.Attach(note);
                ctx.Notes.Remove(note);
                ctx.SaveChanges();


                //var result = ctx.Notes.FirstOrDefault(n => n.Id == id);
                //if (result != null)
                //{
                //    ctx.Notes.Remove(result);
                //    ctx.SaveChanges();
                //}
            }
        }

    }
}
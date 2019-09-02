using MemoTest.DAL;
using MemoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace MemoTest.Controllers
{
    [RoutePrefix("api/notes")]
    public class NotesController : ApiController
    {

        [HttpGet]
        [Route]
        public IHttpActionResult Get()
        {
            return Content(HttpStatusCode.OK, NotesDAL.Retrieve(new NoteRequest()));
        }


    }
}
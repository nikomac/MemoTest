using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoTest.Models
{
    public class NoteRequest
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        //public DateTime CreationDate { get; set; }
        //public DateTime EditionDate { get; set; }
    }

}
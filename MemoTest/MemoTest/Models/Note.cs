using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoTest.Models
{
    public class Note
    {
        public int Id { get; set; }
        public bool IsMarked { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditionDate { get; set; }
        public string Data { get; set; }

        public string MarkedName => IsMarked ? "Unpin" : "Pin";
        public string MarkedBackground => IsMarked ? "LightSteelBlue" : "Transparent";

    }

}
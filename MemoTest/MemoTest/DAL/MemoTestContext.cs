using MemoTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MemoTest.DAL
{
    public class MemoTestContext : DbContext
    {

        public MemoTestContext(string con) : base(con)
        {

        }

        public DbSet<Note> Notes { get; set; }
    }
}
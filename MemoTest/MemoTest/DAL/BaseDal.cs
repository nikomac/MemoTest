using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MemoTest.DAL
{
    public class BaseDal
    {
        protected static string ConnectionName => "NotesDbCS";

        protected static string GetConnectionString()
        {
            var con = ConfigurationManager.ConnectionStrings[ConnectionName]?.ConnectionString;
            return con;

        }
    }
}
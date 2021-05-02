using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Jhone_Doe_Template.Data
{
    public class Jhone_Doe_DbContext : DbContext
    {
        public Jhone_Doe_DbContext() : base("Jhone_Doe_DbConnection")
        {

        }
    }
}
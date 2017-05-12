using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer:DbContext
    {
        public Customer()
        {
        }

        protected Customer(DbCompiledModel model) : base(model)
        {
        }

        public int Id{ get; set; }
        public string Name { get; set; }
    }
}
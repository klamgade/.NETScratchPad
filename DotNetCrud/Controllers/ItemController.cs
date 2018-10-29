using DotNetCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetCrud.Controllers
{
    public class ItemController : Controller
    {
        DatabaseContext dbContext = new DatabaseContext();

    //POST: Add Item
        public ActionResult AddItems()
        {
            using(dbContext)
            {
                var item = new Item()
                {
                    Name = "Cheese"
                };
                dbContext.Items.Add(item);
                dbContext.SaveChanges();
            }
            return View();
        }

        private 
    }
}
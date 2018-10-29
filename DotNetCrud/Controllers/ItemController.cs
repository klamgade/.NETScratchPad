using DotNetCrud.Models;
using DotNetCrud.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DotNetCrud.Controllers
{
    public class ItemController : Controller
    {
        public DatabaseContext _dbContext = new DatabaseContext();

        public ItemController()
        {
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Item item)
        {
            using(_dbContext)
            {
                _dbContext.Items.Add(item);
                _dbContext.SaveChanges();
            }
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            using (_dbContext)
            {
                var items =  _dbContext.Items.ToListAsync();
                return View(await items);
            }
        }

        [HttpGet]
        public ActionResult GetItem(int id)
        {
            using (_dbContext)
            {
                var item =  _dbContext.Items.Single(x => x.Id == id);
                return View(item);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (_dbContext)
            {
                var item = _dbContext.Items.Single(x => x.Id == id);
                return View(item);
            }
        }

        [HttpPost]
        public ActionResult Edit(Item item)
        {
            if(ModelState.IsValid)
            {
                using (_dbContext)
                {
                    _dbContext.Entry(item).State = EntityState.Modified;
                    _dbContext.SaveChanges();
                    return RedirectToAction("index", new { id = item.Id });
                }
            }
            return View(item);
        }

  
        public ActionResult Delete(int id)
        {
            using (_dbContext)
            {
                var item = _dbContext.Items.Single(x => x.Id == id);
                _dbContext.Items.Remove(item);
                _dbContext.SaveChanges();
                return RedirectToAction("index");
            }
        }
    }
}
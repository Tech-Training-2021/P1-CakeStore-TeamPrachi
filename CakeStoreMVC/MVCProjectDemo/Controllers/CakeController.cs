using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Data.Entities;
using MVCProjectDemo.Models;

namespace MVCProjectDemo.Controllers
{
    public class CakeController : Controller
    {
        CakeRepository cakerepo;
        
        public CakeController()
        {
            cakerepo = new CakeRepository(new CakeModel());
        }
        
        public ActionResult Index()
        {
            var cakes = cakerepo.GetAllCakes();
            var data = new List<MVCProjectDemo.Models.Cake>();
            foreach(var c in cakes)
            {
                data.Add(Mapper.Map(c));
            }
            return View(data);
        }

        public ActionResult GetCakeById(int cakeid)
        {
                FlavourType cake = cakerepo.GetCakeById(cakeid);
                return View(Mapper.Map(cake));
        }

        public ActionResult Create()
        {
            return View(new FlavourType());
        }
        [HttpPost]
        public ActionResult Create(FlavourType flavour)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cakerepo.AddCake(flavour);
                    cakerepo.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }

            return View(flavour);
        }
    }
}
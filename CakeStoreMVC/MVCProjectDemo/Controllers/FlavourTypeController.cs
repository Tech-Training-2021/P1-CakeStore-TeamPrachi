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
    public class FlavourTypeController : Controller
    {
        FlavourTypeRepository cakerepo;
        
        public FlavourTypeController()
        {
            cakerepo = new FlavourTypeRepository(new CakeModel());
        }
        
        public ActionResult Index()
        {
            var cakes = cakerepo.GetAllCakes();
            var data = new List<MVCProjectDemo.Models.FlavourType>();
            foreach(var c in cakes)
            {
                data.Add(MVCProjectDemo.Mappers.Mapper.Map(c));
            }
            return View(data);
        }

        public ActionResult GetCakesById(int id)
        {
                var cake = cakerepo.GetCakeById(id);
                return View(Mappers.Mapper.Map(cake));
        }

        public ActionResult Create()
        {
            ViewBag.Flavour = new SelectList(cakerepo.GetAllFlavour(), "FlavourID", "FlavourName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(MVCProjectDemo.Models.FlavourTypeViewModel flavour)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cakerepo.AddCake(MVCProjectDemo.Mappers.Mapper.Map(flavour));
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
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Flavour = new SelectList(cakerepo.GetAllFlavour(), "FlavourID", "FlavourName");
            var cake = cakerepo.GetCakeById(id);
            TempData["Flavour"] = cake.FlavourID;
            return View(MVCProjectDemo.Mappers.Mapper.MapViewModel(cake));
        }
        [HttpPost]
        public ActionResult Edit(int id, FlavourTypeViewModel cake)
        {
            if (ModelState.IsValid)
            {
                cakerepo.UpdateCake(id, MVCProjectDemo.Mappers.Mapper.Map(cake));
                cakerepo.Save();
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        public ActionResult DeleteCake(int id)
        {
            cakerepo.DeleteCake(id);
            return RedirectToAction("Index");
        }


       

    }
}
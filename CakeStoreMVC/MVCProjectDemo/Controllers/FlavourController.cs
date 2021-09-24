using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Entities;
using Data.Repositories;

namespace MVCProjectDemo.Controllers
{
    public class FlavourController : Controller
    {

        FlavourRepository cakerepo;

        public FlavourController()
        {
            cakerepo = new FlavourRepository(new CakeModel());
        }

        public ActionResult Index()
        {
            var cakes = cakerepo.GetAllFlavours();
            var data = new List<MVCProjectDemo.Models.Flavour>();
            foreach (var c in cakes)
            {
                data.Add(MVCProjectDemo.Mappers.FlavourMapper.Map(c));
            }
            return View(data);
        }

        public ActionResult GetCakesById(int cakeid)
        {
            var cake = cakerepo.GetFlavourById(cakeid);
            return View(Mappers.FlavourMapper.Map(cake));
        }

        public ActionResult Create()
        {
            ViewBag.Flavour = new SelectList(cakerepo.GetAllFlavours(), "FlavourID", "FlavourName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(MVCProjectDemo.Models.FlavourViewModel flavour)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cakerepo.AddFlavour(MVCProjectDemo.Mappers.FlavourMapper.Map(flavour));
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
        public ActionResult Edit(int cakeid)
        {
            ViewBag.Flavour = new SelectList(cakerepo.GetAllFlavours(), "FlavourID", "FlavourName");
            var cake = cakerepo.GetFlavourById(cakeid);
            TempData["Flavour"] = cake.FlavourID;
            return View(Mappers.FlavourMapper.MapViewModel(cake));
        }
        [HttpPost]
        public ActionResult Edit(int cakeid,MVCProjectDemo.Models.FlavourViewModel cake)
        {
            if (ModelState.IsValid)
            {
                cakerepo.UpdateFlavour(cakeid, MVCProjectDemo.Mappers.FlavourMapper.Map(cake));
                cakerepo.Save();
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        public ActionResult DeleteCake(int cakeid)
        {
            cakerepo.DeleteFlavour(cakeid);
            return RedirectToAction("Index");
        }

    }
}
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
    public class UserController : Controller
    {
        UserRepository cakerepo;
        public UserController()
        {
            cakerepo = new UserRepository(new CakeModel());
        }
        public ActionResult Index()
        {
            var cakes = cakerepo.GetAllUser();
            var data = new List<MVCProjectDemo.Models.User>();
            foreach (var c in cakes)
            {
                data.Add(MVCProjectDemo.Mappers.UserMapper.Map(c));
            }
            return View(data);
        }
        public ActionResult GetUserById(string id)
        {
            var cake = cakerepo.GetUserById(id);
            return View(Mappers.UserMapper.Map(cake));
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            ViewBag.UserTbl = new SelectList(cakerepo.GetAllUser());
            var cake = cakerepo.GetUserById(id);
            TempData["UserTbl"] = cake.userId;
            return View(Mappers.UserMapper.MapViewModel(cake));
        }
        [HttpPost]
        public ActionResult Edit(string id, MVCProjectDemo.Models.UserViewModel cake)
        {
            if (ModelState.IsValid)
            {
                cakerepo.UpdateUser(id, MVCProjectDemo.Mappers.UserMapper.Map(cake));
                return RedirectToAction("Index");
            }
            else
                return View(); 
        }
        public ActionResult DeleteUser(string id)
        {
            cakerepo.DeleteUser(id);
            return RedirectToAction("Index");
        }
    }
}
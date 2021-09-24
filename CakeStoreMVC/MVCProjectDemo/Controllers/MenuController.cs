using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Entities;
using Data.Repositories;
using MVCProjectDemo.Models;


namespace MVCProjectDemo.Controllers
{
    public class MenuController : Controller
    {
        private CakeModel db;
        Data.Repositories.Order cakerepo;
        Data.FlavourTypeRepository frepo;
        private List<CartViewModel> cvm;
        public MenuController()
        {
            db = new CakeModel();
            cvm = new List<CartViewModel>();
            cakerepo = new Data.Repositories.Order (new CakeModel());
            frepo = new Data.FlavourTypeRepository(new CakeModel());

        }

        public ActionResult Checkout()
        {
            string userid = Session["Id"].ToString();
            cakerepo.checkout(userid);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Index()
        {
            string userid = Session["Id"].ToString();
            TempData["count"] = cakerepo.GetCartByUserId(userid).Count();
            TempData["UserId"] = Session["Id"];
            IEnumerable<MenuViewModel> mvm = (from ft in db.FlavourTypes
                                              join
                                              f in db.Flavours
                                              on ft.FlavourID equals f.FlavourID
                                              select new MenuViewModel()
                                              {
                                                  FlavourTypeID=ft.FlavourTypeID,
                                                  FlavourTypeName = ft.FlavourTypeName,
                                                  Price = ft.Price,
                                                  AvailableQuantity = ft.AvailableQuantity,
                                                  ImgUrl=ft.ImgUrl,
                                              }).ToList();
            
            return View(mvm);
        }
        public ActionResult Delete(int id)
        {
            cakerepo.delete(id);
            return RedirectToAction("Cart");
;        }

        [HttpGet]
        public ActionResult Cart()
        {
            string userid = Session["Id"].ToString();
            var data = cakerepo.GetCartByUserId(userid);
            var data2 = new List<MVCProjectDemo.Models.OrderModel>();
            foreach (var d in data)
            {
                data2.Add(MVCProjectDemo.Mappers.OrderMapper.Map2(d));
            }
            int total = 0;
            foreach(var d2 in data2)
            {
                var temp = d2.Price * d2.Quantity;
                total = (int)(total + d2.Price);
            }
            TempData["total"] = total;
            return View(data2);
        }
        
        public ActionResult AddtoCart(int id)
        {
            var flavour = frepo.GetCakeById(id);
            string userid = Session["Id"].ToString();
            var mapper = MVCProjectDemo.Mappers.OrderMapper.Map(flavour, userid);
            cakerepo.AddOrder(MVCProjectDemo.Mappers.OrderMapper.Map(mapper));
            return RedirectToAction("Index");
        }

        public ActionResult OrderDetails()
        {
            string userid = Session["Id"].ToString();
            var data=cakerepo.OrderHistory(userid);
            var data2 = new List<MVCProjectDemo.Models.OrderHistory>();
            foreach(var d in data)
            {
                data2.Add(MVCProjectDemo.Mappers.OrderHistoryMapper.Map(d));
            }
            return View(data2);
        }


    }
}
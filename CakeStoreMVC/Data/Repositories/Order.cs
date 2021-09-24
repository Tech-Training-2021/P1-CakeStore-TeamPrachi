using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Repositories
{
   public class Order:IOrder
    {
        private CakeModel db;

        public Order (CakeModel db)
        {
            this.db = db;

        }

        public void checkout(string userid)
        {
            var data = GetCartByUserId(userid);
            foreach(var d in data)
            {
                var history = new Data.Entities.OrderHistory()
                {
                    UserId = d.UserId,
                    FlavourTypeID = d.FlavourTypeID,
                    Price = d.Price,
                    Quantity = d.Quantity,
                    ImgUrl = d.ImgUrl,
                    FlavourID = d.FlavourID,
                };
                db.OrderHistories.Add(history);
                db.Orders.Remove(d);
            }
            Save();
        }
        public void delete(int id)
        {
           var data= db.Orders.Where(p => p.OrderID == id).FirstOrDefault();
            db.Orders.Remove(data);
            Save();
        }
        public void AddOrder(Entities.Order order)
        {
            var flavourtype = db.FlavourTypes.Where(c => c.FlavourTypeID == order.FlavourTypeID).FirstOrDefault();
            var data = db.Orders.Where(p => p.UserId == order.UserId && p.FlavourTypeID == order.FlavourTypeID).FirstOrDefault();
            if (data == null) { 
            
            db.Orders.Add(order);
            }
            else
            {
                var qty = data.Quantity + 1;
                data.Quantity = qty;
                var total = qty * flavourtype.Price;
                data.Price = (int) total;
            }
            Save();
        }

        public IEnumerable<Data.Entities.Order> GetCartByUserId(string userId)
        {
            var data = db.Orders.Where(x => x.UserId == userId).ToList();
            return data;
        }

        public IEnumerable<Data.Entities.OrderHistory> OrderHistory(string userId)
        {
            var data = db.OrderHistories.Where(x => x.UserId == userId).ToList();
            return data;
        }



        //public void AddOrder(int FlavourTypeId, int _OrderedQuantity, int _TotalPrice)
        //{
        //    var order = new Data.Entities.OrderDetail()
        //    {
        //        FlavourTypeID = FlavourTypeId,
        //        OrderedQuantity = _OrderedQuantity,
        //        TotalPrice = _TotalPrice,

        //    };
        //    db.OrderDetails.Add(order);
        //    Save();

        //}

        public void Save()
        {
            db.SaveChanges();
        }
    }

}

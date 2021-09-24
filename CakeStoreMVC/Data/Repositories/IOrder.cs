using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    interface IOrder
    {
        //void AddOrder(int FlavourTypeId, int _OrderedQuantity, int _TotalPrice);

        void AddOrder(Data.Entities.Order order);

        IEnumerable<Data.Entities.Order> GetCartByUserId(string userId);
    }
}

using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    interface IFlavourRepository
    {
        IEnumerable<Flavour> GetAllFlavours();

        void AddFlavour(Flavour objcake);

        Flavour GetFlavourById(int cakeId);

        Flavour UpdateFlavour(int cakeid, Flavour flavour);

        void DeleteFlavour(int id);

        void Save();
    }
}

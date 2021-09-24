using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public interface IFlavourTypeRepository
    {
        IEnumerable<FlavourType> GetAllCakes();

        void AddCake(FlavourType objcake);

        FlavourType GetCakeById(int cakeId);

        FlavourType UpdateCake(int cakeid,FlavourType flavour);

        void DeleteCake(int id);

        void Save();
    }
}

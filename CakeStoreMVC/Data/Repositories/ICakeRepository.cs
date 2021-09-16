using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public interface ICakeRepository
    {
        IEnumerable<FlavourType> GetAllCakes();

        void AddCake(FlavourType objcake);

        FlavourType GetCakeById(int cakeId);

        void UpdateCake(FlavourType flavour);

        void Save();

        

        //void DeleteCake(int cakeId);
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public class CakeRepository : ICakeRepository
    {
        private CakeModel db;
        public CakeRepository(CakeModel db)
        {
            this.db = db;
        }
        public void AddCake(FlavourType objcake)
        {
            db.FlavourTypes.Add(objcake);
            //int result = -1;
            //if (objcake != null)
            //{
            //    db.FlavourTypes.Add(objcake);
            //    db.SaveChanges();
            //    result = objcake.FlavourTypeID;
            //}
            //return result;
        }

        public IEnumerable<FlavourType> GetAllCakes()
        {
            return db.FlavourTypes.ToList();
        }

        public FlavourType GetCakeById(int cakeid)
        {
            return db.FlavourTypes.Find(cakeid);
        }

        public void UpdateCake(FlavourType flavour)
        {
            db.Entry(flavour).State = EntityState.Modified;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}

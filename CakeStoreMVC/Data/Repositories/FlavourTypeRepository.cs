using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public class FlavourTypeRepository : IFlavourTypeRepository
    {
        private CakeModel db;
        public FlavourTypeRepository(CakeModel db)
        {
            this.db = db;
        }
        public void AddCake(FlavourType objcake)
        {
            db.FlavourTypes.Add(objcake);
        }

        public IEnumerable<FlavourType> GetAllCakes()
        {
            var cakename = db.FlavourTypes.Include(c => c.Flavour).ToList();
            return cakename;
        }
        public IEnumerable<Flavour> GetAllFlavour()
        {
            var flavour = db.Flavours.ToList();
            return flavour;
        }
        public FlavourType GetCakeById(int cakeid)
        {
            if (cakeid > 0)
            {
                var flavour = db.FlavourTypes.Include(f => f.Flavour).Where(e => e.FlavourTypeID == cakeid).FirstOrDefault();
                if (flavour != null)
                {
                    return flavour;
                }
                else { return null; }
            }
            else
                throw new ArgumentException("Flavour Not Found");
        }

        public FlavourType UpdateCake(int cakeid,Data.Entities.FlavourType flavour)
        {
            FlavourType updatecake = (from c in db.FlavourTypes
                                      where c.FlavourTypeID == cakeid
                                      select c).FirstOrDefault();
            updatecake.FlavourTypeName = flavour.FlavourTypeName;
            updatecake.FlavourID = flavour.FlavourID;
            updatecake.Price = flavour.Price;
            updatecake.AvailableQuantity = flavour.AvailableQuantity;
            updatecake.ImgUrl = flavour.ImgUrl;
            Save();
            return flavour;
        }


        public void DeleteCake(int id)
        {
            var user = db.FlavourTypes.Where<Data.Entities.FlavourType>(u => u.FlavourTypeID== id).First();
            if (user != null)
            {
                db.FlavourTypes.Remove(user);
                Save();
                return;
            }
            else
            {
                throw new ArgumentException($"No User Found With the id : {id}");
            }
            throw new ArgumentException("Id cannot be less than 0");
        }


        public void Save()
        {
            db.SaveChanges();
        }
    }
}

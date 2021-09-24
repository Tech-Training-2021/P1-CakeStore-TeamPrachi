using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class FlavourRepository
    {
        private CakeModel db;
        public FlavourRepository(CakeModel db)
        {
            this.db = db;
        }
        public void AddFlavour(Flavour objcake)
        {
            db.Flavours.Add(objcake);
        }

        public IEnumerable<Flavour> GetAllFlavours()
        {
            var cakename = db.Flavours.ToList();
            return cakename;
        }
       
        public Flavour GetFlavourById(int cakeid)
        {
            if (cakeid > 0)
            {
                var flavour = db.Flavours.Where(e => e.FlavourID == cakeid).FirstOrDefault();
                if (flavour != null)
                {
                    return flavour;
                }
                else { return null; }
            }
            else
                throw new ArgumentException("Flavour Not Found");
        }

        public Flavour UpdateFlavour(int cakeid, Flavour flavour)
        {
            Flavour updatecake = (from c in db.Flavours
                                      where c.FlavourID == cakeid
                                      select c).FirstOrDefault();
            updatecake.FlavourName = flavour.FlavourName;
            
            Save();
            return flavour;
        }


        public void DeleteFlavour(int id)
        {
            var user = db.Flavours.Where<Data.Entities.Flavour>(u => u.FlavourID == id).First();
            if (user != null)
            {
                db.Flavours.Remove(user);
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

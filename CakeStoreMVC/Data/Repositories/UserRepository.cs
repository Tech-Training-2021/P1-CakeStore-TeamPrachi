using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Repositories
{
    public class UserRepository
    {
        private CakeModel db;

        public UserRepository(CakeModel db)
        {
            this.db = db;
        }
        public IEnumerable<UserTbl> GetAllUser()
        {
            var users = db.UserTbls.ToList();
            return users;
        }
        public UserTbl GetUserById(string id)
        {
            if (id != null)
            {
                var us = db.UserTbls.Where(e => e.userId == id).FirstOrDefault();
                if (us != null)
                {
                    return us;
                }
                else { return null; }
            }
            else
                throw new ArgumentException("User Not Found");

        }
        public void UpdateUser(string id, UserTbl user)
        {
            UserTbl updateuser = (from c in db.UserTbls
                                  where c.userId == id
                                  select c).FirstOrDefault();
            updateuser.fullName = user.fullName;
            updateuser.dob = user.dob;
            updateuser.contactNo = user.contactNo;
            updateuser.email = user.email;
            updateuser.state = user.state;
            updateuser.city = user.city;
            updateuser.pincode = user.pincode;
            updateuser.fullAddress = user.fullAddress;
            updateuser.userId = user.userId;
            updateuser.password = user.password;

            Save();
           
        }
        public void DeleteUser(string id)
        {
            var user = db.UserTbls.Where(u => u.userId == id).First();
            if (user != null)
            {
                db.UserTbls.Remove(user);
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

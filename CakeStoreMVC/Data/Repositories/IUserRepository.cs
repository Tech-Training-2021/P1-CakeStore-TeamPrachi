using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Repositories
{
    interface IUserRepository
    {
        IEnumerable<UserTbl> GetAllUser();

        void GetUserById(string id);

        void UpdateUser(string id, UserTbl user);

        void DeleteUser(string id);

        void Save();
    }
}

using Proj.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Repositories
{
    public interface IUserRepository
    {
        List<Users> Selectall();
        Users SelectByID(int id);
        void Insert(Users us);
        void Update(Users us);
        void Delete(int id);
    }
}

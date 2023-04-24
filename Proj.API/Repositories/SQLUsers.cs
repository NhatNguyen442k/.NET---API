using Microsoft.EntityFrameworkCore;
using Proj.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Repositories
{
    public class SQLUsers : IUserRepository
    {
        private readonly DBcontext data = null;

        public SQLUsers(DBcontext data)
        {
            this.data = data;
        }
        public void Delete(int id)
        {
            data.Database.ExecuteSqlRaw("DELETE FROM Users WHERE IDuser = {0}", id);
        }

        public void Insert(Users us)
        {
            data.Database.ExecuteSqlRaw("INSERT INTO Users(Name,Sex,Phone,Address) " +
                "VALUES({0},{1},{2},{3})", us.Nameuser, us.Sex, us.Phone, us.Address);
        }

        public List<Users> Selectall()
        {
            List<Users> us = data.users.FromSqlRaw("SELECT * FROM Users").ToList();
            return us;
        }

        public Users SelectByID(int id)
        {
            Users us = data.users.FromSqlRaw("SELECT * FROM Users WHERE IDuser = {0}", id).SingleOrDefault();
            return us;
        }

        public void Update(Users us)
        {
            data.Database.ExecuteSqlRaw("UPDATE Users SET Name = {0}, Sex = {1}, Phone = {2}, Address = {3}"
                , us.Nameuser, us.Sex, us.Phone, us.Address);
        }
    }
}

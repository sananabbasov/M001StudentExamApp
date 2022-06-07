using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AuthManager
    {
        AppDbContext _context = new();


        public User Login(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(x=>x.Id == id);
        }
    }
}

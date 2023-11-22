using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public User AddUser(User user)
        {
            _context.UserList.Add(user);
            return user;
        }

        public void DeleteUser(int id)
        {
            _context.UserList.Remove(_context.UserList.Find(u => u.Id == id));
        }

        public User GetById(int id)
        {
            return _context.UserList.Find(u => u.Id == id);
        }

        public List<User> GetUsers()
        {
            return _context.UserList;
        }

        public User UpdateUser(int id, User user)
        {
            var updateUser = _context.UserList.Find(u => u.Id == id);
            if (updateUser != null)
            {
                updateUser.Name = user.Name;
                updateUser.Email = user.Email;
                return updateUser;
            }
            return null;
        }
    }
}

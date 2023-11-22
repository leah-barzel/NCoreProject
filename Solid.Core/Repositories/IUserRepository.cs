using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();

        User GetById(int id);

        User AddUser(User user);

        User UpdateUser(int id, User user);

        void DeleteUser(int id);
    }
}

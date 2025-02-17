using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JET2.Entities.User.IUser
{
    public interface IUserRepository
    {
        Task UserInsert(string firstName, string lastName, string PhoneNumber, string email);

        Task<List<User>> UsersGet();
    }
}

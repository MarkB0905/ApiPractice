using JET2.Entities.User.IUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JET2.Entities.User.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserProcedures _userProcedures;

        public UserRepository(IUserProcedures userProcedures)
        {
            _userProcedures = userProcedures;
        }

        public async Task UserInsert(string firstName, string lastName, string phoneNumber, string email)
        {
            //new UserProcedures().UserInsert(firstName, lastName, phoneNumber, email);
           await _userProcedures.UserInsert(firstName, lastName, phoneNumber, email);
        }
    }
}

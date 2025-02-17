using JET2.Entities.User.IUser;
using System;
using System.Collections.Generic;
using System.Data;
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


        public async Task<List<User>> UsersGet()
        {
            List<User> users = new List<User>();

            DataSet ds = new DataSet();

            ds =  await _userProcedures.UsersGet();

            if (ds.Tables[0].Rows.Count > 0 && ds.Tables != null)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                   users.Add(new User(dr, ds.Tables[1]));
                }

            }
      

            return users;
        }
    }
}

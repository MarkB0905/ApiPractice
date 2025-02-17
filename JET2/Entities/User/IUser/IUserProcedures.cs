using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace JET2.Entities.User.IUser
{
    public interface IUserProcedures
    {
        Task UserInsert(string firstName, string lastName, string phoneNumber, string email);
        Task<DataSet> UsersGet();
    }
}

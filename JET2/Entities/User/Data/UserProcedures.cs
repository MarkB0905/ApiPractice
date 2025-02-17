using JET2.Connection;
using JET2.Connection.IConnection;
using JET2.Entities.User.IUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace JET2.Entities.User.Data
{
    public class UserProcedures : IUserProcedures
    {

        private readonly IConnection _connection;

        public UserProcedures(IConnection connection)
        {
            _connection = connection;
        }

        public async Task UserInsert(string firstName, string lastName, string phoneNumber, string email)
        {
            await Task.Run(() => _connection.RunProcedure("sp_Users_UserInsert", new List<DbParam>
        {
            new DbParam("@FirstName", firstName),
            new DbParam("@LastName", lastName),
            new DbParam("@PhoneNumber", phoneNumber),
            new DbParam("@Email", email)
        }));
        }
    }
}

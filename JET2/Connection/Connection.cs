using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace JET2.Connection
{
    public class Connection : IConnection.IConnection
    {
        private readonly string _connectionString;

        public Connection(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<DataSet> RunProcedure(string Name, List<DbParam> paramas)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    DataSet ds = new DataSet();
                    using (SqlCommand cmd = new SqlCommand(Name, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (DbParam i in paramas)
                        {
                            cmd.Parameters.AddWithValue(i.Name, i.Value);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            await Task.Run(() => adapter.Fill(ds)); // Simulating async behavior
                        }
                    }

                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occurred While Calling The Database", ex);
            }
        }
    }
}
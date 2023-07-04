using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace HELPDESK.Data
{
    public class SqlConexionA
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public SqlConexionA(IConfiguration configuration)
        {
            _configuration = configuration;
            //_connectionString = _configuration.GetConnectionString("mysqlconection");
            _connectionString = _configuration.GetConnectionString("sqlconection_A");
        }

        public IDbConnection CreateConnection()
            //=> new MySqlConnection(_connectionString);
            => new SqlConnection(_connectionString);
    }

    public class SqlConexionB
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public SqlConexionB(IConfiguration configuration)
        {
            _configuration = configuration;
            //_connectionString = _configuration.GetConnectionString("mysqlconection");
            _connectionString = _configuration.GetConnectionString("sqlconection_B");
        }

        public IDbConnection CreateConnection()
            //=> new MySqlConnection(_connectionString);
            => new SqlConnection(_connectionString);
    }
}

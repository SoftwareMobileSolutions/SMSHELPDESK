using Dapper;
using HELPDESK.Data;
using HELPDESK.Interfaces;
using HELPDESK.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HELPDESK.Services
{
    public class LoginServices : ILogin
    {
        readonly SqlConexionA _context;

        public LoginServices(SqlConexionA context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LoginModel>> InitSession(string iUserName, string iPassword, string iConnection)
        {
            IEnumerable<LoginModel> lstLogin;
            using(var conn = new SqlConnection(iConnection))
            {
                string query = @"exec HD_InitSession @userName, @password";
                try
                {
                    if(conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    lstLogin = await conn.QueryAsync<LoginModel>(query, new { iUserName, iPassword }, commandType: CommandType.Text);
                }
                finally
                {
                    if(conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            return lstLogin;
        }
    }
}

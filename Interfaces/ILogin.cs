using HELPDESK.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HELPDESK.Interfaces
{
    public interface ILogin
    {
        Task<IEnumerable<LoginModel>> InitSession(string iUserName, string iPassword, string iConnection);
    }
}

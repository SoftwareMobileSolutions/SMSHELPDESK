using System.ComponentModel;
using System.Collections.Generic;
using HELPDESK.Models;
using HELPDESK.Data;
using HELPDESK.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using HELPDESK.Interfaces;
using System.Threading.Tasks;

namespace HELPDESK.Controllers
{
    public class LoginController : Controller
    {
        readonly IHttpContextAccessor ctx;
        readonly ILogin ILogin;

        public LoginController(IHttpContextAccessor _ctx, ILogin _ILogin)
        {
            ctx = _ctx;
            ILogin = _ILogin;
        }
        public IActionResult Login()
        {
            if (ModelState.IsValid)
            {
                var dataSession = _Session.Get<IEnumerable<LoginModel>>(HttpContext.Session, "User");
                //No ha iniciado Session
                if (dataSession == null)
                {

                }
            }
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> IniciarSession(LoginModel args)
        {
            if (ModelState.IsValid)
            {
                var dataSession = _Session.Get<IEnumerable<LoginModel>>(HttpContext.Session, "User");
                //No ha iniciado Session
                if (dataSession == null)
                {
                }
                return Json(null);
            }

            return Json(null);
        }
    }
}

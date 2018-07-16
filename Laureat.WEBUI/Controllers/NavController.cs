using Laureat.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laureat.WEBUI.Controllers
{
    public class NavController : Controller
    {
        private IUserRepository repository;
       public NavController(IUserRepository repo)
        {
            repository = repo;
        }
        public PartialViewResult Menu(string role = null)
        {
            ViewBag.SelectedRole = role;
            IEnumerable<string> roles = repository.Users
                .Select(x => x.Role)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(roles);
        }
    }
}
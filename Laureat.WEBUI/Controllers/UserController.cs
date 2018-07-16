using Laureat.Domain.Abstract;
using Laureat.WEBUI.Models;
using System.Linq;
using System.Web.Mvc;

namespace Laureat.WEBUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository repository;
        public int PageSize = 4;

        public UserController(IUserRepository userRepo)
        {
            repository = userRepo;
        }
        public ViewResult List(string role, int page=1)
         {
            UserListViewModel model = new UserListViewModel
            {
                Users = repository.Users
                    .Where(p => role == null || p.Role == role)
                    .OrderBy(p => p.Role)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagesInfos
                {
                    CurrentPage = page,
                    UsersPerPage = PageSize,
                    TotalUsers = role== null ? repository.Users.Count() 
                                          : repository.Users.Where(p=>p.Role== role).Count()
                    
                },
                CurrentRole = role
            };

            return View(model);
        }
    }
}
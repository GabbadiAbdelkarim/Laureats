using Laureat.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laureat.Domain.Entities;

namespace Laureat.Domain.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }
    }
}

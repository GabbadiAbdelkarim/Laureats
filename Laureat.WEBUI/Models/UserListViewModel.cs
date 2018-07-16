using Laureat.Domain.Entities;
using System.Collections.Generic;

namespace Laureat.WEBUI.Models
{
    public class UserListViewModel
    {
        public IEnumerable<User> Users { get; set;}
        public PagesInfos PagingInfo { get; set; }
        public string CurrentRole { get; set; }
    }
}
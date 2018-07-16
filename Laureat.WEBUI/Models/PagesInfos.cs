using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laureat.WEBUI.Models
{
    public class PagesInfos
    {
        public int TotalUsers { get; set; }
        public int UsersPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages {
            get
            {
                return (int)Math.Ceiling((Decimal)TotalUsers / UsersPerPage);
            }
        }


    }
}
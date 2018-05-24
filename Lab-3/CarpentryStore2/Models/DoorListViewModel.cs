using CarpentyStore2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarpentryStore2.Models
{
    public class DoorsListViewModel
    {
        public IEnumerable<Door> Doors { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
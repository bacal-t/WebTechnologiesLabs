using CarpentyStore2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarpentryStore2.Models
{
    public class ArmchairListViewModel
    {
        public IEnumerable<Armchair> Armchairs { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
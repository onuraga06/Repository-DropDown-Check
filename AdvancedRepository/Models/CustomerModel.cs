using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvancedRepository.Models
{
    public class CustomerModel
    {
        public Customers customers { get; set; }
        public List<Customers> clist { get; set; }
        public IEnumerable<SelectListItem> Listele { get; set; }
    }
}
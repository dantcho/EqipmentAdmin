using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class SecurityChekSiteLocation
    {
        [Key]
        public int Id { get; set; }
        public enum Terminal { T1 = 1, T2 = 2 }
        public string LoacationName { get; set; }
        public virtual Department DepartamentId { get; set; }

    }
}
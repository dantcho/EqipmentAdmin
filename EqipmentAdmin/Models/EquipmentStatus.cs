using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class EquipmentStatus
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateOfTest { get; set; }
        public virtual Equipment Equipment {get;set;}
        public virtual EquipmentTestData TestData { get; set; }
        public virtual ApplicationUser UserId { get; set; }
    }
}
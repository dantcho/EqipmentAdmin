using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class SatTest
    {
        [Key]
        public int Id { get; set; }
        public virtual Equipment EquipmentId { get; set; }
        public DateTime DateOfTest { get; set; }

    }
}
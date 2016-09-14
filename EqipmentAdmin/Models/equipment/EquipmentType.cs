using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class EquipmentType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }

        public string Serial { get; set; }
        public string InventarNum { get; set; }
        public virtual Passport Passport { get; set; }
        public virtual EquipmentModel ModelId { get; set; }
    }
}
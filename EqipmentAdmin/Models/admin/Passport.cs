using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class Passport
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        [Required]
        public virtual Equipment EquipmentId { get; set; }
        public virtual ICollection<SiteHistory> MovingHistory { get; set; }
        public virtual ICollection<SatTest> SatTests { get; set; }
        public virtual ICollection<EquipmentStatus> Statuses { get; set; }


        // public virtual Equipment EQ { get; set; }


    }
}
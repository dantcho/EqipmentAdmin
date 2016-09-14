using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class SiteHistory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual Equipment EquipmentId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual SecurityChekSiteLocation Location { get; set; }

    }
}
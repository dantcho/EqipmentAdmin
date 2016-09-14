using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class UserTipActivity
    {
        [Key]
        public int Id { get; set; }
        public virtual EquipmentUser UserId { get; set; }
        public DateTime Date { get; set; }
        public virtual Equipment Machine { get; set; }
        public virtual SecurityChekSiteLocation Site { get; set; }
        public string Descision { get; set; }
        public string TipName { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
    }
}
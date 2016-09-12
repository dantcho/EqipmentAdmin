using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class EquipmentModel
    {
        [Key]
        public int Id { get; set; }
        public string ProducerName { get; set; }
        public string ModelName { get; set; }
        public virtual ICollection<Standart> Standarts { get; set; }
        public virtual EquipmentType EquipmentTypeId { get; set; }
    }
}
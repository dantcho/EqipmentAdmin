using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EqipmentAdmin.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentModel> EquipmentModels { get; set; }
        public DbSet<EquipmentStatus> EquipmentStatuses { get; set; }
        public DbSet<EquipmentTestData> EquipmentTestDatas { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<EquipmentUser> EquipmentUsers { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<SatTest> SatTests { get; set; }
        public DbSet<SecurityChekSiteLocation> SecurityChekSiteLocations { get; set; }
        public DbSet<SiteHistory> SiteHistorys { get; set; }
        public DbSet<Standart> Standarts { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<UserActivity> UserActivitys { get; set; }
        public DbSet<UserHistory> UserHistorys { get; set; }
        public DbSet<UserTipActivity> UserTipActivitys { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Comments> Comments { get; set; }

    }
}

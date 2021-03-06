namespace EqipmentAdmin.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "EqipmentAdmin.Models.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                // If the database is empty, populate sample data in it

                CreateUser(context, "admin@gmail.com", "123", "System Administrator");
                CreateUser(context, "pesho@gmail.com", "123", "Peter Ivanov");
                CreateUser(context, "merry@gmail.com", "123", "Maria Petrova");
                CreateUser(context, "geshu@gmail.com", "123", "George Petrov");
                CreateRole(context, "Administrators");
                AddUserToRole(context, "admin@gmail.com", "Administrators");
                context.SaveChanges();
            }
            if (!context.Departments.Any())
            {
                CreateDepartment(context, "ПСЛ");
                CreateDepartment(context, "ПРБ");
                CreateDepartment(context, "Карго");
                CreateDepartment(context, "ПСПРБ");
                CreateDepartment(context, "Служебен");
                CreateDepartment(context, "ВКАС");
                CreateDepartment(context, "ГВА");
                CreateDepartment(context, "Други");
                context.SaveChanges();
            }
            if (!context.SecurityChekSiteLocations.Any())
            {
                CreateSecuritySiteCheck(context, "Т1 Обществена зона - Заминаване", "Служебен");
                CreateSecuritySiteCheck(context, "Т1 Карго", "Карго");
                CreateSecuritySiteCheck(context, "Т1 Стоки за летище", "Карго");
                CreateSecuritySiteCheck(context, "Т1 Заминаване 1", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 Заминаване 2", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 Заминаване 3", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 Заминаване 4", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 Заминаване 5", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 ВИП А Ръчен багаж", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 ВИП А Ръчен багаж НСО", "Други");
                CreateSecuritySiteCheck(context, "Т1 ВИП Б Ръчен багаж", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 ВИП А Регистриран багаж", "ПРБ");
                CreateSecuritySiteCheck(context, "Т1 ВИП Б Регистриран багаж", "ПРБ");
                CreateSecuritySiteCheck(context, "Т1 Регистриран багаж Изток", "ПРБ");
                CreateSecuritySiteCheck(context, "Т1 Регистриран багаж Запад", "ПРБ");
                CreateSecuritySiteCheck(context, "Т1 Извън Габаритен", "ПРБ");
                CreateSecuritySiteCheck(context, "Т1 Служебен вход 1", "ПСЛ");
                CreateSecuritySiteCheck(context, "Т1 Служебен вход 3", "ПСЛ");
                CreateSecuritySiteCheck(context, "Т1 Служебен вход 5", "ПСЛ");
                CreateSecuritySiteCheck(context, "Т2 Служебен вход 6", "ПСЛ");
                CreateSecuritySiteCheck(context, "Т2 Служебен вход 7", "ПСЛ");
                CreateSecuritySiteCheck(context, "Т2 Служебен вход 9", "ПСЛ");
                CreateSecuritySiteCheck(context, "Т2 Стоки за летище - 2", "ПСЛ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване 1", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване 2", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване 3", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване 4", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване 5", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване 6", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Трансфер", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване Д1-1", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване Д1-2", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Обществена зона - Заминаване", "Служебен");
                CreateSecuritySiteCheck(context, "Т2 Обществена зона - Пристигане", "Служебен");
                CreateSecuritySiteCheck(context, "Т2 Изход A1", "Служебен");
                CreateSecuritySiteCheck(context, "Т2 Изход C1", "Служебен");
                CreateSecuritySiteCheck(context, "Т2 Изход B3", "Служебен");
                CreateSecuritySiteCheck(context, "Т2 Ръш багаж Багажно хале", "ПРБ");
                CreateSecuritySiteCheck(context, "Т2 Багажно хале", "ПРБ");
                context.SaveChanges();
            }
            if (!context.EquipmentTypes.Any())
            {
                CreateEquipmentType(context, "XRAY");
                CreateEquipmentType(context, "ETD");
                CreateEquipmentType(context, "SMD");
                CreateEquipmentType(context, "WTMD");
                context.SaveChanges();
                //  
            }
            if (!context.Standarts.Any())
            {
                CreateStandart(context, "XRAY-1", "X-RAY Standart 1");
                CreateStandart(context, "XRAY-2", "X-RAY Standart 2");
                CreateStandart(context, "WTMD-ST1", "WTMD Standart 1");
                CreateStandart(context, "WTMD-ST2", "WTMD Standart 2");
                CreateStandart(context, "EDS-1", "Find Explosives");
                CreateStandart(context, "EDS-2", "Find Explosives");
                CreateStandart(context, "ETD-1", "Find Explosives");
                CreateStandart(context, "ScPMML", "Find pokemon");
                CreateStandart(context, "QRS-ST2", "Find tits");
                CreateStandart(context, "WMSMTR", "Find everything");
                context.SaveChanges();
            }

            if (!context.EquipmentModels.Any())
            {
                CreateEquipmentModel(context, "Smiths Detection", "HI-SCAN 100100V", "XRAY", new string[] { "XRAY-1" });
                CreateEquipmentModel(context, "Meteor", "M700", "WTMD", new string[] { "WTMD-ST1" });
                CreateEquipmentModel(context, "CEIA", "PX2", "WTMD", new string[] { "WTMD-ST2" });
                CreateEquipmentModel(context, "CEIA", "PX2", "SMD", new string[] { });
                CreateEquipmentModel(context, "Smiths Detection", "IONSCAN 500DT", "ETD", new string[] { "ETD-1" });
                CreateEquipmentModel(context, "Smiths Detection", "HI-SCAN 6040aTiX", "XRAY", new string[] { "XRAY-1", "EDS-1", "ScPMML" });
                CreateEquipmentModel(context, "Smiths Detection", "HI-SCAN 145180-2is", "XRAY", new string[] { "XRAY-1" });
                CreateEquipmentModel(context, "Smiths Detection", "HI-SCAN 145180TS", "XRAY", new string[] { "XRAY-1" });
                CreateEquipmentModel(context, "Smiths Detection", "HI-SCAN 6046si", "XRAY", new string[] { "XRAY-1", "XRAY-2" });
                context.SaveChanges();
            }

            if (!context.Equipments.Any())
            {
                CreateEquipment(context, "34534", "HI-SCAN 145180TS");
                CreateEquipment(context, "3556", "HI-SCAN 6040aTiX");
                CreateEquipment(context, "346743", "HI-SCAN 145180-2is");
                CreateEquipment(context, "234563", "HI-SCAN 6040aTiX");
                CreateEquipment(context, "65969", "HI-SCAN 6046si");
                CreateEquipment(context, "322355", "HI-SCAN 6040aTiX");
                CreateEquipment(context, "97555", "IONSCAN 500DT");
                CreateEquipment(context, "322355", "HI-SCAN 100100V");
                CreateEquipment(context, "52355", "HI-SCAN 6040aTiX");
                CreateEquipment(context, "3683245", "PX2");
                CreateEquipment(context, "3683246", "PX2");
                CreateEquipment(context, "3683247", "PX2");
                CreateEquipment(context, "3683248", "PX2");
                CreateEquipment(context, "7467352", "M700");
                CreateEquipment(context, "7467355", "M700");
                CreateEquipment(context, "7467354", "M700");
                CreateEquipment(context, "7467356", "M700");
                context.SaveChanges();
            }
            if (!context.EquipmentUsers.Any())
            {
                CreateEquipmentUser(context, "Пенчо Въбанов", "Pencho Varbanov", "00873", "3242", true, true);
                CreateEquipmentUser(context, "Иван Въбанов", "Ivan Varbanov", "05773", "322", true, true);
                CreateEquipmentUser(context, "Драган Исмаилов", "Dragan Ismailov", "00863", "32422", true, true);
                CreateEquipmentUser(context, "Витко Пеев", "Vitko Peev", "00853", "3245", true, false);
                CreateEquipmentUser(context, "Резьо Иванов", "Rezjo Ivanov", "00843", "3243", true, true);
                CreateEquipmentUser(context, "Кирчо Киров", "Kircho Kirov", "08267", "3252", true, true);
                CreateEquipmentUser(context, "Иван Баламезов", "Ivan Balamezov", "00733", "3342", true, false);
                context.SaveChanges();
            }
            if (!context.UserHistorys.Any())
            {
                CreateUserHistory(context, "00873", "ПСЛ", "12/1/2015");
                CreateUserHistory(context, "05773", "ПСЛ", "1/2/2011", "2/12/2015");
                CreateUserHistory(context, "05773", "ПСПРБ", "3/12/2015");
                CreateUserHistory(context, "00863", "ПСПРБ", "11/1/2015");
                CreateUserHistory(context, "00853", "ПСПРБ", "1/1/2014");
                CreateUserHistory(context, "00843", "ПРБ", "12/2/2012");
                CreateUserHistory(context, "08267", "ПРБ", "10/12/2013");
                CreateUserHistory(context, "00733", "ПСЛ", "10/10/2012");
            }
            context.SaveChanges();

        }

        private void CreateUserHistory(ApplicationDbContext context, string userId, string dep, string fromDate)
        {
            var usrH = new UserHistory()
            {
                EquipmentUserId = context.EquipmentUsers.First(x => x.UserID.Equals(userId)),
                DepartmentId = context.Departments.First(x => x.Name.Equals(dep)),
                StartDate = DateTime.Parse(fromDate)
            };
            context.UserHistorys.Add(usrH);
        }
        private void CreateUserHistory(ApplicationDbContext context, string userId, string dep, string fromDate, string toDate)
        {
            var usrH = new UserHistory()
            {
                EquipmentUserId = context.EquipmentUsers.First(x => x.UserID.Equals(userId)),
                DepartmentId = context.Departments.First(x => x.Name.Equals(dep)),
                StartDate = DateTime.Parse(fromDate),
                EndDate = DateTime.Parse(toDate)
            };
            context.UserHistorys.Add(usrH);
        }

        private void CreateEquipmentUser(ApplicationDbContext context, string nameBg, string name, string userId, string password, bool isActive, bool isForEvulation)
        {
            var eqUsr = new EquipmentUser() { NameBG = nameBg, NameUS = name, UserID = userId, Password = password, IsActive = isActive, IsForEvulation = isForEvulation };
            context.EquipmentUsers.Add(eqUsr);
        }

        private void CreateEquipment(ApplicationDbContext context, string serial, string model)
        {
            var equipment = new Equipment() { Serial = serial };
            equipment.ModelId = context.EquipmentModels.First(x => x.ModelName.Equals(model));
            context.Equipments.Add(equipment);
        }

        private void CreateEquipmentModel(ApplicationDbContext context, string producer, string model, string type, ICollection<string> stColection)
        {
            var eqM = new EquipmentModel
            {
                EquipmentTypeId = context.EquipmentTypes.First(x => x.Name.Equals(type)),
                ModelName = model,
                ProducerName = producer
            };
            foreach (var stndart in stColection)
            {
                Standart st = context.Standarts.First(x => x.Name.Equals(stndart));
                if (eqM.Standarts == null)
                {
                    eqM.Standarts = new List<Standart>();
                }
                eqM.Standarts.Add(st);
            }
            context.EquipmentModels.Add(eqM);

        }

        private void CreateStandart(ApplicationDbContext context, string v1, string v2)
        {
            var sdt = new Standart { Name = v1, Description = v2 };
            context.Standarts.Add(sdt);
        }

        private void CreateEquipmentType(ApplicationDbContext context, string v)
        {
            var eqT = new EquipmentType
            {
                Name = v
            };
            context.EquipmentTypes.Add(eqT);
        }

        private void CreateUser(ApplicationDbContext context,
            string email, string password, string fullName)
        {
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                FullName = fullName
            };

            var userCreateResult = userManager.Create(user, password);
            if (!userCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", userCreateResult.Errors));
            }
        }

        private void CreateRole(ApplicationDbContext context, string roleName)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));
            var roleCreateResult = roleManager.Create(new IdentityRole(roleName));
            if (!roleCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", roleCreateResult.Errors));
            }
        }

        private void AddUserToRole(ApplicationDbContext context, string userName, string roleName)
        {
            var user = context.Users.First(u => u.UserName == userName);
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var addAdminRoleResult = userManager.AddToRole(user.Id, roleName);
            if (!addAdminRoleResult.Succeeded)
            {
                throw new Exception(string.Join("; ", addAdminRoleResult.Errors));
            }
        }

        private void CreateDepartment(ApplicationDbContext context,
            string depName)
        {
            var department = new Department();
            department.Name = depName;
            context.Departments.Add(department);
        }
        private void CreateSecuritySiteCheck(ApplicationDbContext context, string name, string depart)
        {
            var SiteCheck = new SecurityChekSiteLocation();
            SiteCheck.LoacationName = name;
            SiteCheck.DepartamentId = context.Departments.First(x => x.Name.Equals(depart));
            context.SecurityChekSiteLocations.Add(SiteCheck);
        }
    }
}

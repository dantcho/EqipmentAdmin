namespace EqipmentAdmin.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
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
                CreateDepartment(context, "ПСПРБ");
                CreateDepartment(context, "Служебен");
                CreateDepartment(context, "ВКАС");
                CreateDepartment(context, "ГВА");
                CreateDepartment(context, "Други");
                context.SaveChanges();
            }
            if (!context.SecurityChekSiteLocations.Any())
            {
                CreateSecuritySiteCheck(context, "Т1 Заминаване 1", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 Заминаване 2", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 Заминаване 3", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 Заминаване 4", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 Заминаване 5", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т1 ВИП А Ръчен багаж", "ПСПРБ");
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
                CreateSecuritySiteCheck(context, "Т2 Заминаване 1", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване 2", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване 3", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване 4", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване 5", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване Д1-1", "ПСПРБ");
                CreateSecuritySiteCheck(context, "Т2 Заминаване Д1-2", "ПСПРБ");




                context.SaveChanges();
            }
            
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
        private void CreateSecuritySiteCheck(ApplicationDbContext context,
    string name, string depart)
        {
            var SiteCheck = new SecurityChekSiteLocation();
            SiteCheck.LoacationName = name;
            SiteCheck.DepartamentId = context.Departments.First(x=>x.Name.Equals(depart));
            context.SecurityChekSiteLocations.Add(SiteCheck);
        }
    }
}

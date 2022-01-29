using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Projectusers.Data;
using System;
using System.Linq;
namespace Projectusers.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectusersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProjectusersContext>>()))
            {
                if (context == null || context.User == null)
                {
                    throw new ArgumentNullException("NUll WebApplicationUserContext");
                }
                if (context.User.Any())
                {
                    return;
                }
                if (!context.User.Any())
                {
                    context.User.AddRange(
                        new User
                        {
                            Name = "Anna",
                            Surname = "Smith",
                            dateOfBirth = DateTime.Parse("1999-2-12"),
                            Login = "AnnaSmith21",
                        //isDeleted = false

                    },
                        new User
                        {
                            Name = "Will",
                            Surname = "Boyce",
                            dateOfBirth = DateTime.Parse("1982-09-15"),
                            Login = "Will2132",
                        // isDeleted=false

                    },
                        new User
                        {
                            Name = "Jake",
                            Surname = "Lake",
                            dateOfBirth = DateTime.Parse("1964-01-22"),
                            Login = "Jale123124",
                        //isDeleted=false

                    }
                        );
                    context.SaveChanges();
                }
            }
        }
    }

}
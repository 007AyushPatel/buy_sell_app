using BuySellAPI.data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySellAPI.data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.USERS.Any())
                {
                    context.USERS.AddRange(new Users()
                    {
                        UserMobile = 8591248940,
                        UserName = "Ankur",
                        UserMail = "ankurc@gmail.com",
                        UserPassword = "Ankur123"

                    },
                    new Users()
                    {
                        UserMobile = 8384017474,
                        UserName = "Mohit",
                        UserMail = "MohitJ@gmail.com",
                        UserPassword = "Mohit123"
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}

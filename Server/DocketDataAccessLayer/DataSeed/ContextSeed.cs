using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocketEntities.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DocketDataAccessLayer.DataSeed
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            CreteDefaultRecords(modelBuilder);
        }

        private static void CreteDefaultRecords(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(DefaultUser.ListUser());

            modelBuilder.Entity<Role>().HasData(DefaultRole.ListRole());

            modelBuilder.Entity<UserRole>().HasData(DefaultUserRole.ListUserRole());

            modelBuilder.Entity<ColorPalette>().HasData(DefaultColorPalette.ListColorPalette());

        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);
            //IConfigurationRoot configuration = builder.Build();
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DB"));
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:DB"];

            return strConn;
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Address> Addresses{ get; set; } = null!;
        public virtual DbSet<Press> Presses{ get; set; } = null!;
        public virtual DbSet<Book> Books{ get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Book" },
                new Category { CategoryId = 2, Name = "Magazine" },
                new Category { CategoryId = 3, Name = "EBook" }
            );

            modelBuilder.Entity<Address>().HasData(
                new Address { AddressId = 1, City = "HCM City", Street = "Nguyen Hue Street"},
                new Address { AddressId = 2, City = "HCM City", Street = "Le Loi Street"},
                new Address { AddressId = 3, City = "Binh Duong", Street = "Binh Duong Revenue"},
                new Address { AddressId = 4, City = "Binh Duong", Street = "Hung Vuong Street"},
                new Address { AddressId = 5, City = "HCM City", Street = "Pham Ngu Lao Street"},
                new Address { AddressId = 6, City = "HCM City", Street = "Hai Ba Trung Street"},
                new Address { AddressId = 7, City = "Binh Duong", Street = "Tran Hung Dao Street"},
                new Address { AddressId = 8, City = "Binh Duong", Street = "Le Hong Phong Street"},
                new Address { AddressId = 9, City = "HCM City", Street = "Ton Duc Thang Street"},
                new Address { AddressId = 10, City = "HCM City", Street = "Dien Bien Phu Street"}
            );

            modelBuilder.Entity<Press>().HasData(
                new Press { PressId = 1, PressName = "Kim Dong Publishing House", CategoryId = 1},
                new Press { PressId = 2, PressName = "Tre Publishing House", CategoryId = 1},
                new Press { PressId = 3, PressName = "National Political Publishing House", CategoryId = 1},
                new Press { PressId = 4, PressName = "General Publishing House", CategoryId = 1},
                new Press { PressId = 5, PressName = "Communication And News Publishing House", CategoryId = 2},
                new Press { PressId = 6, PressName = "Education Publishing House", CategoryId = 1},
                new Press { PressId = 7, PressName = "Women Publishing House", CategoryId = 2},
                new Press { PressId = 8, PressName = "Lao Dong Publishing House", CategoryId = 2},
                new Press { PressId = 9, PressName = "Science And Technology Publishing House", CategoryId = 3},
                new Press { PressId = 10, PressName = "Culture And Arts Publishing House", CategoryId = 3}
            );
        }
    }
}

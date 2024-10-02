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
                .AddJsonFile("appsettingsjson", true, true)
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

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, IBSN = "9786042073143", Title = "Doraemon", Author = "Fujiko F. Fujio", Price = 14376, AddressId = 1, PressId = 1 },
                new Book { BookId = 2, IBSN = "9786041073007", Title = "The Little Prince", Author = "Antoine de Saint-Exupéry", Price = 25200, AddressId = 2, PressId = 2 },
                new Book { BookId = 3, IBSN = "9786043097919", Title = "Ho Chi Minh: A Life", Author = "William Duiker", Price = 30600, AddressId = 3, PressId = 3 },
                new Book { BookId = 4, IBSN = "9786041156545", Title = "The Tale of Kieu", Author = "Nguyen Du", Price = 18000, AddressId = 4, PressId = 4 },
                new Book { BookId = 5, IBSN = "9786042129877", Title = "Forbes Magazine", Author = "Forbes Media", Price = 16776, AddressId = 5, PressId = 5 },
                new Book { BookId = 6, IBSN = "9786042028981", Title = "Textbook of Chemistry", Author = "Nguyen Quang Hieu", Price = 36000, AddressId = 6, PressId = 6 },
                new Book { BookId = 7, IBSN = "9786042130425", Title = "Women's World Magazine", Author = "Various", Price = 11976, AddressId = 7, PressId = 7 },
                new Book { BookId = 8, IBSN = "9786042032517", Title = "Labor and Employment Law", Author = "Nguyen Van Thanh", Price = 22200, AddressId = 8, PressId = 8 },
                new Book { BookId = 9, IBSN = "9786043049989", Title = "Principles of Technology", Author = "Le Van Minh", Price = 45576, AddressId = 9, PressId = 9 },
                new Book { BookId = 10, IBSN = "9786045068940", Title = "Vietnamese Art Through the Ages", Author = "Le Huy Toan", Price = 49200, AddressId = 10, PressId = 10 },
                new Book { BookId = 11, IBSN = "9786041072545", Title = "Harry Potter and the Philosopher's Stone", Author = "J.K. Rowling", Price = 21576, AddressId = 1, PressId = 2 },
                new Book { BookId = 12, IBSN = "9786042067812", Title = "A Brief History of Vietnam", Author = "Truong Buu Lam", Price = 33000, AddressId = 2, PressId = 3 },
                new Book { BookId = 13, IBSN = "9786043152176", Title = "Cooking with Love", Author = "Le Thi Kim", Price = 14376, AddressId = 3, PressId = 4 },
                new Book { BookId = 14, IBSN = "9786041092182", Title = "Business News Magazine", Author = "Various Authors", Price = 18000, AddressId = 4, PressId = 5 },
                new Book { BookId = 15, IBSN = "9786042076541", Title = "Advanced Mathematics", Author = "Pham Van Dinh", Price = 39600, AddressId = 5, PressId = 6 },
                new Book { BookId = 16, IBSN = "9786042151430", Title = "Women's Weekly Magazine", Author = "Various", Price = 95760, AddressId = 6, PressId = 7 },
                new Book { BookId = 17, IBSN = "9786043087103", Title = "Employment Law Handbook", Author = "Nguyen Thi Lan", Price = 26400, AddressId = 7, PressId = 8 },
                new Book { BookId = 18, IBSN = "9786044087217", Title = "The Science of Everything", Author = "Le Duc Thinh", Price = 54600, AddressId = 8, PressId = 9 },
                new Book { BookId = 19, IBSN = "9786045089128", Title = "Vietnamese Folk Art", Author = "Tran Quang Huy", Price = 61200, AddressId = 9, PressId = 10 },
                new Book { BookId = 20, IBSN = "9786042075652", Title = "Dragon Ball", Author = "Akira Toriyama", Price = 15600, AddressId = 10, PressId = 1 }
            );
        }
    }
}

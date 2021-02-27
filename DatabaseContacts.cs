using Microsoft.EntityFrameworkCore;

namespace MyContacts
{
    public class DatabaseContacts : DbContext
    {
        public DbSet<Contact> Contacts{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-H6KLGA1\SQLEXPRESS;Database=MY_CONTACTS;Integrated Security=True");
    }
}
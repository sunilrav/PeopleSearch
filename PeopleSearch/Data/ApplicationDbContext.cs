using PeopleSearch.Models.Domain;
using System.Data.Entity;

namespace PeopleSearch.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
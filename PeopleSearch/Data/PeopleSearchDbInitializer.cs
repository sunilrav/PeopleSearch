using PeopleSearch.Models.Domain;
using System.Collections.Generic;
using System.Data.Entity;

namespace PeopleSearch.Data
{
    public class PeopleSearchDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            IList<Contact> contacts = new List<Contact>();

            contacts.Add(new Contact() { FirstName = "Mickey", LastName = "Mouse" });
            contacts.Add(new Contact() { FirstName = "Donald", LastName = "Duck" });
            contacts.Add(new Contact() { FirstName = "Minnie", LastName = "Mouse" });

            foreach (Contact contact in contacts)
                context.Contacts.Add(contact);

            base.Seed(context);
        }
    }
}
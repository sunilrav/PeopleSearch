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

            contacts.Add(new Contact() { FirstName = "Mickey", LastName = "Mouse", Age = 20, Picture = "", Interests = "", Address = new Address { Address1 = "", City = "", State = "", Zip = "" } });
            contacts.Add(new Contact() { FirstName = "Donald", LastName = "Duck", Age = 20, Picture = "", Interests = "", Address = new Address { Address1 = "", City = "", State = "", Zip = "" } });
            contacts.Add(new Contact() { FirstName = "Minnie", LastName = "Mouse", Age = 20, Picture = "", Interests = "", Address = new Address { Address1 = "", City = "", State = "", Zip = "" } });
            contacts.Add(new Contact() { FirstName = "Daffy", LastName = "Duck", Age = 20, Picture = "", Interests = "", Address = new Address { Address1 = "", City = "", State = "", Zip = "" } });
            contacts.Add(new Contact() { FirstName = "Trevor", LastName = "Smith", Age = 20, Picture = "", Interests = "", Address = new Address { Address1 = "", City = "", State = "", Zip = "" } });
            contacts.Add(new Contact() { FirstName = "Peter", LastName = "Mcclanahan", Age = 20, Picture = "", Interests = "", Address = new Address { Address1 = "", City = "", State = "", Zip = "" } });
            contacts.Add(new Contact() { FirstName = "Sunil", LastName = "Ravulapalli", Age = 20, Picture = "", Interests = "", Address = new Address { Address1 = "", City = "", State = "", Zip = "" } });

            foreach (Contact contact in contacts)
                context.Contacts.Add(contact);

            base.Seed(context);
        }
    }
}
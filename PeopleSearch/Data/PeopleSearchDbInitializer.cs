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

            contacts.Add(new Contact() { FirstName = "Mickey", LastName = "Mouse", Age = 21, Picture = "NoPhoto.png", Interests = "Sports, Outdoors", Address = new Address { Address1 = "1010 S 340 W", City = "Salt lake city", State = "UT", Zip = "84111" } });
            contacts.Add(new Contact() { FirstName = "Donald", LastName = "Duck", Age = 33, Picture = "NoPhoto.png", Interests = "Knitting", Address = new Address { Address1 = "3432 Thanos ln", City = "South Jordan", State = "UT", Zip = "84156" } });
            contacts.Add(new Contact() { FirstName = "Minnie", LastName = "Mouse", Age = 38, Picture = "NoPhoto.png", Interests = "Extreme Sports", Address = new Address { Address1 = "190 Mill St", City = "Draper", State = "UT", Zip = "84115" } });
            contacts.Add(new Contact() { FirstName = "Daffy", LastName = "Duck", Age = 55, Picture = "NoPhoto.png", Interests = "Swimming", Address = new Address { Address1 = "878 S 900 W", City = "North Salt lake", State = "UT", Zip = "84789" } });
            contacts.Add(new Contact() { FirstName = "Trevor", LastName = "Smith", Age = 20, Picture = "NoPhoto.png", Interests = "Golf", Address = new Address { Address1 = "145 San Marino dr", City = "Carteret", State = "NJ", Zip = "07008" } });
            contacts.Add(new Contact() { FirstName = "Peter", LastName = "Pan", Age = 20, Picture = "NoPhoto.png", Interests = "Flying, Golf", Address = new Address { Address1 = "4 Main st", City = "New Brunswick", State = "NJ", Zip = "07089" } });
            contacts.Add(new Contact() { FirstName = "Sunil", LastName = "Ravulapalli", Age = 34, Picture = "NoPhoto.png", Interests = "Gaming, Sports", Address = new Address { Address1 = "900 Lion ct", City = "Austin", State = "TX", Zip = "98989" } });

            foreach (Contact contact in contacts)
                context.Contacts.Add(contact);

            base.Seed(context);
        }
    }
}
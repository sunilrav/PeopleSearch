using System.ComponentModel.DataAnnotations;

namespace PeopleSearch.Models.Domain
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
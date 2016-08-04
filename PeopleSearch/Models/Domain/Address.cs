using System.ComponentModel.DataAnnotations;

namespace PeopleSearch.Models.Domain
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
using System.Collections.Generic;
using System.Linq;
using PeopleSearch.Models.Domain;
using PeopleSearch.Data;

namespace PeopleSearch.Services
{
    public class SearchService : ISearchService
    {
        IGenericRepository<Contact> _contactRepository;
        public SearchService(IGenericRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public List<Contact> SearchByName(string inputName)
        {
            var contacts = _contactRepository.Get(x => x.FirstName.Contains(inputName) || x.LastName.Contains(inputName));

            return contacts.ToList();
        }
    }
}
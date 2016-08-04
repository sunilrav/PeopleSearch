using PeopleSearch.Models.Domain;
using System.Collections.Generic;

namespace PeopleSearch.Services
{
    public interface ISearchService
    {
        List<Contact> SearchByName(string inputName);
    }
}

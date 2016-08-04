using PeopleSearch.Models.Domain;
using PeopleSearch.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace PeopleSearch.Controllers
{
    public class SearchController : ApiController
    {
        ISearchService _searchService;
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        public List<Contact> Get(string q)
        {
            return _searchService.SearchByName(q);
        }
    }
}

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

        [Route("api/search")]
        public List<Contact> Get(string q)
        {
            var list = _searchService.SearchByName(q);
            return list;
        }
    }
}

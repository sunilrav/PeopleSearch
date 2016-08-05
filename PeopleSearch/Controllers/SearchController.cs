using PeopleSearch.Models.Domain;
using PeopleSearch.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<List<Contact>> Get(string q)
        {
            await Task.Delay(5000);
            var list = _searchService.SearchByName(q);
            return list;
        }
    }
}

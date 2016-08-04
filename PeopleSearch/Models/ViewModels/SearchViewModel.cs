using System.ComponentModel.DataAnnotations;

namespace PeopleSearch.Models.ViewModels
{
    public class SearchViewModel
    {
        [Display(Name = "Name")]
        public string InputName { get; set; }
    }
}
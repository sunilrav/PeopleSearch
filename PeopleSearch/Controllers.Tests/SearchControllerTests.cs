using Moq;
using PeopleSearch.Models.Domain;
using PeopleSearch.Services;
using System.Collections.Generic;
using Xunit;

namespace PeopleSearch.Controllers.Tests
{
    public class SearchControllerTests
    {
        [Fact]
        public async void Search_IfNameFound_ReturnListOfContacts()
        {
            //Arrange
            var searchService = new Mock<ISearchService>();
            searchService.Setup(x => x.SearchByName(It.IsAny<string>()))
                           .Returns(new List<Contact>
                                        { new Contact { FirstName = "Mickey", LastName = "Mouse" } });

            var searchController = new SearchController(searchService.Object);
           
            //Act
            List<Contact> contacts = await searchController.Get("Mouse");

            //Assert
            Assert.True(contacts.Count > 0);
        }
    }
}
using PeopleSearch.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xunit;

namespace PeopleSearch.Services.Tests
{
    public class SearchServiceTests
    {
        [Fact]
        public void Search_IfNameFound_ReturnListOfContacts()
        {
            //Arrange
            var searchService = new SearchService();

            //Act
            List<Contact> contacts = searchService.SearchByName();

            //Assert
            Assert.True(contacts.Count > 0);
        }
    }
}
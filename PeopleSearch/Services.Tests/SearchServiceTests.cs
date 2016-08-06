using Moq;
using PeopleSearch.Data;
using PeopleSearch.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;

namespace PeopleSearch.Services.Tests
{
    public class SearchServiceTests
    {
        [Fact]
        public void Search_IfNameFound_ReturnListOfContacts()
        {
            //Arrange
            var contactRepository = new Mock<IGenericRepository<Contact>>();
            contactRepository.Setup(
                e => e.Get(It.IsAny<Expression<Func<Contact, bool>>>(), "Address"))
                                        .Returns(new List<Contact>
                                        { new Contact { FirstName = "Mickey", LastName = "Mouse" } });

            var searchService = new SearchService(contactRepository.Object);

            //Act
            List<Contact> contacts = searchService.SearchByName("Mick");

            //Assert
            Assert.True(contacts.Count > 0);
        }

        [Fact]
        public void Search_IfNameFound_ReturnZeroContacts()
        {
            //Arrange
            var contactRepository = new Mock<IGenericRepository<Contact>>();
            contactRepository.Setup(
                e => e.Get(It.IsAny<Expression<Func<Contact, bool>>>(), "Address"))
                                        .Returns(new List<Contact> { } );

            var searchService = new SearchService(contactRepository.Object);

            //Act
            List<Contact> contacts = searchService.SearchByName("asdf");

            //Assert
            Assert.True(contacts.Count == 0);
        }
    }
}
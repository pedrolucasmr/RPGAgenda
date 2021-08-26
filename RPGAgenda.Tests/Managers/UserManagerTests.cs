using System;
using RPGAgenda.Managers;
using RPGAgenda.Tests.Mock.Repositories;
using Xunit;

namespace RPGAgenda.Tests.Managers
{
    public class UserManagerTests
    {
        [Fact]
        public void Create_User_Should_Return_Valid_User_Object()
        {
            // arrange
            var userRepo = UserRepositoryMock.GetSuccessUserRepository();
            var userManager = new UserManager(userRepo);

            string name = "Roger";
            string lastName = "Waters";
            string alias = "Rogy";
            string email = "rogy@test.com";

            // act
            var result = userManager.CreateUser(name, lastName, email, alias);
            
            // assert
            Assert.Equal(name, result.Name);
            Assert.Equal(lastName, result.LastName);
            Assert.Equal(alias, result.Alias);
            Assert.Equal(email, result.Email);
            Assert.Empty(result.ActiveTables);
            Assert.Empty(result.InactiveTables);
        }
        
        [Fact]
        public void Create_User_Without_Alias_Should_Return_Valid_User_Object()
        {
            // arrange
            var userRepo = UserRepositoryMock.GetSuccessUserRepository();
            var userManager = new UserManager(userRepo);

            string name = "Roger";
            string lastName = "Waters";
            string email = "rogy@test.com";

            // act
            var result = userManager.CreateUser(name, lastName, email);
            
            // assert
            Assert.Equal(name, result.Name);
            Assert.Equal(lastName, result.LastName);
            Assert.Null(result.Alias);
            Assert.Equal(email, result.Email);
            Assert.Empty(result.ActiveTables);
            Assert.Empty(result.InactiveTables);
        }
    }
}
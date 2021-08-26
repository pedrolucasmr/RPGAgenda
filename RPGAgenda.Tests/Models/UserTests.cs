using RPGAgenda.Tests.Mock.Models;
using WebApi.Models.Exceptions;
using Xunit;

namespace RPGAgenda.Tests.Models
{
    public class UserTests
    {
        [Fact]
        public void AddTable_Should_Add_Active_Table()
        {
            // arrange
            var user = UserMock.GetDefaultUser();
            var table = TableMock.GetDefaultActiveTable();
            
            // act
            user.AddTable(table);
            
            // assert
            Assert.NotNull(user.ActiveTables[0]);
        }
        
        [Fact]
        public void AddTable_Should_Add_Inactive_Table()
        {
            // arrange
            var user = UserMock.GetDefaultUser();
            var table = TableMock.GetDefaultActiveTable();
            
            // act
            user.AddTable(table);
            
            // assert
            Assert.NotNull(user.ActiveTables[0]);
        }
        
        [Fact]
        public void AddTable_Should_Throw_BadGatewayException_If_Table_Status_Is_Undefined()
        {
            // arrange
            var user = UserMock.GetDefaultUser();
            var table = TableMock.GetDefaultUndefinedTable();

            string expectedMessage = "Table status cannot be undefined";
            
            // act and assert
            var result = Assert.Throws<BadGatewayException>(() => user.AddTable(table));
            Assert.Equal(expectedMessage, result.Message);
        }
    }
}
using System;
using System.Collections.Generic;
using RPGAgenda.Models;
using RPGAgenda.Models.Interfaces;

namespace RPGAgenda.Tests.Mock.Models
{
    public static class UserMock
    {
        public static User GetDefaultUser()
        {
            return new User()
            {
                Id = new Guid(),
                Name = "John",
                LastName = "Lennon",
                Alias = "Johnny Boy",
                Email = "johnyoko@test.com",
                ActiveTables = new List<ITable>(),
                InactiveTables = new List<ITable>()
            };
        }
    }
}
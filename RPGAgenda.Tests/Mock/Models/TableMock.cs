using System;
using System.Collections.Generic;
using RPGAgenda.Models;
using RPGAgenda.Models.Enums;
using RPGAgenda.Models.Interfaces;

namespace RPGAgenda.Tests.Mock.Models
{
    public static class TableMock
    {
        public static Table GetDefaultActiveTable()
        {
            return new Table
            {
                Id = new Guid(),
                Name = "D&D of the comrades",
                System = "D&D",
                CreatedAt = DateTime.Now,
                Status = TableStatus.Active,
                Events = new List<IEvent>(),
                Players = new List<IPlayer>(),
                Master = null,
                LastEvent = null,
                NextEvent = null
            };
        }
        
        public static Table GetDefaultInactiveTable()
        {
            return new Table
            {
                Id = new Guid(),
                Name = "D&D of the comrades",
                System = "D&D",
                CreatedAt = DateTime.Now,
                Status = TableStatus.Inactive,
                Events = new List<IEvent>(),
                Players = new List<IPlayer>(),
                Master = null,
                LastEvent = null,
                NextEvent = null
            };
        }
        
        public static Table GetDefaultUndefinedTable()
        {
            return new Table
            {
                Id = new Guid(),
                Name = "D&D of the comrades",
                System = "D&D",
                CreatedAt = DateTime.Now,
                Status = TableStatus.Undefined,
                Events = new List<IEvent>(),
                Players = new List<IPlayer>(),
                Master = null,
                LastEvent = null,
                NextEvent = null
            };
        }
    }
}
using System;
using System.Collections.Generic;
using RPGAgenda.Models.Interfaces;
using RPGAgenda.Models.Enums;
using PackUtils;
using WebApi.Models.Exceptions;

namespace RPGAgenda.Models
{
    public class User: IUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Alias { get; set; }
        public string Email { get; set; }
        public List<ITable> ActiveTables { get; set; }
        public List<ITable> InactiveTables { get; set; }
        public void AddTable(ITable table)
        {
            if (table.Status == TableStatus.Undefined)
            {
                throw new BadGatewayException("Table status cannot be undefined");
            }
            
            if (table.Status == TableStatus.Active)
            {
                ActiveTables.Add(table);
            }
            
            InactiveTables.Add(table);
        }
    }
}
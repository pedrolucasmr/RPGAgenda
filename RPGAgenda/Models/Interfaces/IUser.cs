using System;
using System.Collections.Generic;

namespace RPGAgenda.Models.Interfaces
{
    public interface IUser
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        string Alias { get; set; }
        string Email { get; set; }
        List<ITable> ActiveTables { get; set; }
        List<ITable> InactiveTables { get; set; }
    }
}
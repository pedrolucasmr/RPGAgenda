using System;

namespace RPGAgenda.Models.Interfaces
{
    public interface IMaster
    { 
        Guid Id { get; set; }
        IUser User { get; set; }
        ITable Table { get; set; }
    }
}
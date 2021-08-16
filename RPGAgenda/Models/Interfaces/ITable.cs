using System;
using System.Collections.Generic;
using RPGAgenda.Models.Enums;

namespace RPGAgenda.Models.Interfaces
{
    public interface ITable
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string System { get; set; }
        DateTime CreatedAt { get; set; }
        TableStatus Status { get; set; }
        List<IEvent> Events { get; set; }
        List<IPlayer> Players { get; set; }
        IMaster Master { get; set; }
        abstract IEvent LastEvent { get; set; }
        abstract IEvent NextEvent { get; set; }
    }
}
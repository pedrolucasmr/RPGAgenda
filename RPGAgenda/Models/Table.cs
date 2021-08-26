using System;
using System.Collections.Generic;
using RPGAgenda.Models.Enums;
using RPGAgenda.Models.Interfaces;

namespace RPGAgenda.Models
{
    public class Table: ITable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string System { get; set; }
        public DateTime CreatedAt { get; set; }
        public TableStatus Status { get; set; }
        public List<IEvent> Events { get; set; }
        public List<IPlayer> Players { get; set; }
        public IMaster Master { get; set; }
        public IEvent LastEvent { get; set; }
        public IEvent NextEvent { get; set; }
        public void AddEvent()
        {
            throw new NotImplementedException();
        }
    }
}
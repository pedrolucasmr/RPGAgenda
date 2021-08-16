using System;

namespace RPGAgenda.Models.Interfaces
{
    public interface IPlayer
    {
        Guid Id { get; set; }
        IUser User { get; set; }
        ITable Table { get; set; }
        string CharacterName { get; set; }
        bool IsAssistant { get; set; }
    }
}
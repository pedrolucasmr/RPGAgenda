using RPGAgenda.Models.Interfaces;

namespace RPGAgenda.Repository.Interfaces
{
    public interface IUserRepository
    {
        bool Upsert(IUser user);
    }
}
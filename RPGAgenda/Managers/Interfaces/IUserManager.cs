using RPGAgenda.Models;

namespace RPGAgenda.Managers.Interfaces
{
    public interface IUserManager
    {
        User CreateUser(string name, string lastName, string email, string alias = null);
        User GetUser();
        User UpdateUser();
        User DeleteUser();

    }
}
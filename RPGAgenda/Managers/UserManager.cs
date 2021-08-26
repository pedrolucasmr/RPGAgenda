using System;
using System.Collections.Generic;
using RPGAgenda.Managers.Interfaces;
using RPGAgenda.Models;
using RPGAgenda.Models.Interfaces;
using RPGAgenda.Repository.Interfaces;
using WebApi.Models.Exceptions;

namespace RPGAgenda.Managers
{
    public class UserManager: IUserManager
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        
        public User CreateUser(string name, string lastName, string email, string alias = null)
        {
            User user = new User()
            {
                Id = new Guid(),
                Name = name,
                LastName = lastName,
                Alias = alias,
                Email = email,
                ActiveTables = new List<ITable>(),
                InactiveTables = new List<ITable>()
            };
            
            if (!_userRepository.Upsert(user))
            {
                throw new BadGatewayException("A error has ocurred, try again later");
            }

            return user;
        }

        public User GetUser()
        {
            throw new System.NotImplementedException();
        }

        public User UpdateUser()
        {
            throw new System.NotImplementedException();
        }

        public User DeleteUser()
        {
            throw new System.NotImplementedException();
        }
    }
}
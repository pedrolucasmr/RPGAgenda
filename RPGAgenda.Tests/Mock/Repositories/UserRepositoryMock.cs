using Moq;
using RPGAgenda.Models.Interfaces;
using RPGAgenda.Repository.Interfaces;

namespace RPGAgenda.Tests.Mock.Repositories
{
    public static class UserRepositoryMock
    {
        public static IUserRepository GetSuccessUserRepository(IUser user = null)
        {
            var repoMock = new Mock<IUserRepository>();
            repoMock
                .Setup(m => m.Upsert(It.IsAny<IUser>()))
                .Returns(true);
            
            return repoMock.Object;
        }
    }
}
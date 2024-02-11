using Moq;
using System.Threading.Tasks;
using Xunit;
using Project.WORK.Models;
using Project.WORK.Repositories.Interfaces;
using Project.WORK.Services.Implementations;

namespace Project.WORK.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public async Task GetUserByIdAsync_UserExists_ReturnsUser()
        {
            // Arrange
            var mockUserRepository = new Mock<IUserRepository>();
            var userService = new UserService(mockUserRepository.Object);
            var userId = 1;
            var expectedUser = new User { ID = userId };

            mockUserRepository.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(expectedUser);

            // Act
            var actualUser = await userService.GetByIdAsync(userId);

            // Assert
            Assert.NotNull(actualUser);
            Assert.Equal(expectedUser.ID, actualUser.ID);
            mockUserRepository.Verify(repo => repo.GetByIdAsync(userId), Times.Once);
        }
    }
}

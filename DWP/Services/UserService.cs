using WebApplication.DTOs;
using WebApplication.Services;

namespace TestProject.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository? _repo;

        public Task<UserDTO>CreateUser(CreateUserDTO user)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

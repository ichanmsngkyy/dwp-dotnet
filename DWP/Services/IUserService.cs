using WebApplication.DTOs;
using WebApplication.Repositories;

namespace TestProject.Services
{
    public interface IUserService
    {

        Task<UserDTO> GetById (int id);
        Task<UserDTO> CreateUser(CreateUserDTO user);
    }
}

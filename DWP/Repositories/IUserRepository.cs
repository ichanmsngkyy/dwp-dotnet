using WebApplication.Models;

namespace WebApplication.Repositories
{
     public interface IUserRepository
        {
            IQueryable<User> GetAll();
            Task<User> CreateAsync(User user);
        }

}

using Back_end.Models;

namespace Back_end.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        Task<User> Create(User user);
        Task<List<User>> Delete(int id);
    }
}
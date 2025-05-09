using Model.DTO;
using Model.Entities;

namespace Repository.Interfaces
{
    public interface IUserRepository
    {
        Task RegisterUser(UserPayload user);
        Task<IEnumerable<UserEntity>> GetAllUsers();
        Task<UserEntity> GetUserByEmail(string? email);
    }
}

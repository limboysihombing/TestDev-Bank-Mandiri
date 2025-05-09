using Model.DTO;

namespace Service.Interfaces
{
    public interface IUserService
    {
        Task RegisterUser(UserPayload userDto);
        Task<IEnumerable<UserResponse>> GetAllUsers();
        Task<UserResponse> GetUserByEmail(string? email);
    }
}

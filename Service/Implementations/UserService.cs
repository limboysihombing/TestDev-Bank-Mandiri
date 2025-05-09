
using AutoMapper;
using Model.DTO;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task RegisterUser(UserPayload payload)
        {
            try
            {
                await _userRepository.RegisterUser(payload);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<UserResponse>> GetAllUsers()
        {
            try
            {
                var users = await _userRepository.GetAllUsers();
                return _mapper.Map<IEnumerable<UserResponse>>(users);
            }
            catch
            {
                throw;
            }
        }

        public async Task<UserResponse> GetUserByEmail(string? email)
        {
            // validate
            try
            {

                if (string.IsNullOrEmpty(email))
                {
                    throw new Exception("Email tidak boleh null");
                }

                var userEntity = await _userRepository.GetUserByEmail(email);
                return _mapper.Map<UserResponse>(userEntity);
            }
            catch 
            {
                throw;
            }
        }
    }
}

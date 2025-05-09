using AutoMapper;
using Model.DTO;
using Model.Entities;

namespace Service.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserEntity, UserResponse>();
        }
    }
}

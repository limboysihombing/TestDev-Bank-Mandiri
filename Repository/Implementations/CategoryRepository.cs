using Dapper;
using LARS.Models;
using Microsoft.Extensions.Options;
using Model.DTO;
using Model.Entities;
using Repository.Interfaces;
using System.Data;

namespace Repository.Implementations
{
    public class CategoryRepository : BaseRepository, IUserRepository
    {
        public CategoryRepository(IOptions<AppSetting> setting) : base(setting) { }

               public async Task RegisterUser(UserPayload user)
        {
            using (var conn = GetConnection())
            {
                var reader = await conn.ExecuteAsync(
                    "User_Create",
                    param: new
                    {
                        user.Name,
                        user.Email,
                        user.Password
                    },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task<IEnumerable<UserEntity>> GetAllUsers()
        {
            using (var conn = GetConnection())
            {
                var reader = await conn.QueryMultipleAsync(
                    "User_GetAll",

                    commandType: CommandType.StoredProcedure
                );

                return reader.Read<UserEntity>().ToList();
            }
        }

        public async Task<UserEntity> GetUserByEmail(string? email)
        {
            using (var conn = GetConnection())
            {
                var reader = await conn.QueryMultipleAsync(
                    "User_GetAll",
                    param: new
                    {
                        Email = email
                    },
                    commandType: CommandType.StoredProcedure
                );

                return reader.Read<UserEntity>().Single();
            }
        }
    }
}


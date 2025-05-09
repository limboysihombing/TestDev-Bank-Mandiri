using LARS.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace Repository
{
    public abstract class BaseRepository
    {
        private readonly IOptions<AppSetting> _setting;

        protected BaseRepository(IOptions<AppSetting> setting)
        {
            _setting = setting;
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_setting.Value.DatabaseConnectionString);
        }

    }

}

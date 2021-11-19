using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Jellimix.Infrastructure
{
    public class Database
    {
        #region Properties
        public IDbConnection dbConnection;
        IConfiguration _configuration;
        string _connectionString = string.Empty;
        #endregion

        #region Constructor
        public Database(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("Jellimix");
            dbConnection = new MySqlConnection(_connectionString);
        }
        #endregion
    }
}

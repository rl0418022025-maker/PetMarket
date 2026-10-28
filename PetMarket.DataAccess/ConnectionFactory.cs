using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace PetMarket.DataAccess
{
    public class ConnectionFactory
    {
        private readonly string _connectionString;

        public ConnectionFactory()
        {
            _connectionString = @"Server=localhost\SQLEXPRESS;Database=PetMarket;User Id=sa;Password=PetMarket123*;TrustServerCertificate=True;Connection Timeout=10;";
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
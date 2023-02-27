using System;
using System.Data;
using System.Data.SqlClient;


namespace DapperTutorialInfrastructure.Data
{
  public class DapperDbContext
  {
    IDbConnection dbConnection;
    public DapperDbContext()
    {

      var connectionString = "data source=localhost;initial catalog=JanBatch2023;user id=sa;password=SGF86&pop";
      dbConnection = new SqlConnection(connectionString);
    }

    public IDbConnection GetConnection()
    {
      return dbConnection;
    }
  }
}


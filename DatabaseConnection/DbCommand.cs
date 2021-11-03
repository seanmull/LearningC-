using System;
namespace LearningC_.DatabaseConnection
{
    public class DbCommand
    {
        public readonly DbConnection _dbConnection;
        public DbCommand(DbConnection dbConnection)
        {
            if(dbConnection == null)
              throw new ArgumentException("dbConnection cannot be null");    

            _dbConnection = dbConnection; 
        
        }

        public void Execute()
        {
            _dbConnection.Open();
            System.Console.WriteLine("Command to databate is executing");
            _dbConnection.Close();
        }
    }
}
using System;

namespace LearningC_.DatabaseConnection
{
    public abstract class DbConnection
    {
        public readonly string _connectionString;
        public TimeSpan Timeout { get; set; }

        public DbConnection(string ConnectionString)
        {
            if(ConnectionString == null ||
               ConnectionString == "")
               {
                   throw new ArgumentException("Cannot have null or empty connection string"); 
               }
            
            

            _connectionString = ConnectionString;
            
        }

        public abstract void Open();

        public abstract void Close();
    }
}
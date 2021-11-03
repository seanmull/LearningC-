using System;

namespace LearningC_.DatabaseConnection
{
        public class SqlConnection : DbConnection
    {
        public SqlConnection(string ConnectionString) : base(ConnectionString)
        {
        }

        public override void Close()
        {
            Timeout = TimeSpan.Zero;
            System.Console.WriteLine("Sql connection is closed");
        }

        public override void Open()
        {
            if(Timeout.Seconds > 200)
                throw new TimeoutException("SqlDB is timed out");

            System.Console.WriteLine("Sql connection is opened");
        }
    }
}
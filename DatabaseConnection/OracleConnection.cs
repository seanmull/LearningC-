using System;

namespace LearningC_.DatabaseConnection
{
        public class OracleConnection : DbConnection
    {
        public OracleConnection(string ConnectionString) : base(ConnectionString)
        {
        }

        public override void Close()
        {
            Timeout = TimeSpan.Zero;
            System.Console.WriteLine("Oracle connection is closed");
        }

        public override void Open()
        {
            if(Timeout.Seconds > 200)
                throw new TimeoutException("OracleDB is timed out");

            System.Console.WriteLine("Oracle connection is opened");
        }
    }
}
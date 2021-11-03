using System;
using System.IO;

namespace LearningC_.Extensibility
{


    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;

        }
        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + " : " + message);
            }


        }
    }


    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);

    }
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);


        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(message);


        }
    }
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;

        }
        public void Migrate()
        {
            _logger.LogInfo($"Migrating started at {0}" + DateTime.Now);
            //Details of migrating the database 
            _logger.LogInfo($"Migrating finished at {0}" + DateTime.Now);
        }
    }


    public class Program
    {

        // static void Main(string[] args)
        // {
        //     var DbMigrator = new DbMigrator(new FileLogger("C:\\Windows\\Users\\log.txt"));
        //     DbMigrator.Migrate();


        // }
    }

}
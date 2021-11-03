namespace LearningC_.Compostion
{
    public class Dbmigrator
    {
        private readonly Logger _logger;
        public Dbmigrator(Logger logger)
        {
            _logger = logger;

        }

        public void Migrate()
        {
            _logger.Log("We are migrating.....");
        }
    }
}
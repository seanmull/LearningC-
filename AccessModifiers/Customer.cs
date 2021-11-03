namespace LearningC_.AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if(rating == 0)
                System.Console.WriteLine("Promoted to Level 1");
            else
                System.Console.WriteLine("Promoted to Lever 2");
        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }

        // static void Main(string[] args)
        // {
        //     var customer = new Customer();
        //     var rating = customer.CalculateRating(true);

        // }
    }
}
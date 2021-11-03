namespace LearningC_.AccessModifiers
{
    public class GoldCustomer : Customer
    {
       public void OfferVoucher()
       {
           this.CalculateRating(true); //accessable
       
       } 
    }
}
namespace shopAPI
{
    public class logic
    {
        public int discount(int amount, int price)
        {
            return (amount-(amount/4 ))* price;
        }
    }
}
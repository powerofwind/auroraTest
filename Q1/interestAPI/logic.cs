namespace interestAPI
{
    public class logic
    {
        public double interestLogic(double inputMoney, double inputInterest, int inputYear)
        {
            double total = 0;
            double pay = 0;

            double interest = (inputInterest / 100);
            double useInterest = inputMoney * (interest);

            for (int i = 0; i < inputYear; i++)
            {
                pay = inputMoney + useInterest;
                total += pay;
            }

            return 0;
        }
    }
}
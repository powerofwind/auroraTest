namespace interestAPI
{
    public class logic
    {
        public double interestLogic(double inputMoney, double inputInterest)
        {

            // double total = 0;
            // double pay = 0;

            double interest = (inputInterest / 100);
            double useInterest = inputMoney * (interest);

            
                // pay = inputMoney + useInterest;
                // total += pay;
            

            return useInterest;
        }
    }
}
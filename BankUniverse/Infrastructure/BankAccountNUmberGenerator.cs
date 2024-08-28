namespace BankUniverse.Infrastructure
{
    public class BankAccountNUmberGenerator
    {
        public static string AlfaNumericGenerator()
        {
            Random ran = new Random();

            String b = "abcdefghijklmnopqrstuvwxyz1234567890";

            int length = 10;

            String random = "";

            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(36);
                random += b.ElementAt(a);
            }
            return random.ToUpper();
        }
    }
}

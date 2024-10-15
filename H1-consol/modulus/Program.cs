namespace modulus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                //indexer til 100
                if (i % 3 == 0 && i % 5 == 0)
                {
                    //tjekker om talet går op i både 3 og 5
                    Console.WriteLine(i + " BANKEBØF ");
                }
                else if (i % 3 == 0)
                {
                    //tjekker om talet går op i 3
                    Console.WriteLine(i + " BANKE");
                }
                else if (i % 5 == 0)
                {
                    //tjekker om talet går op i 5
                    Console.WriteLine(i + " BØF");
                }
                else
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}

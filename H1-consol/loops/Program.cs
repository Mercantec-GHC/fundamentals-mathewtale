namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? readresult;
            bool validateresult = false;
            Console.WriteLine("Enter a number between 5 and 10:");
            do
            {
                readresult = Convert.ToInt32(Console.ReadLine());
                if (readresult != null)
                {

                    if (readresult >= 5 && readresult <= 10)
                    {
                        validateresult = true;
                        Console.WriteLine($"we have accepted {readresult} as a valid input");
                    }
                    else
                    {
                        Console.WriteLine($"we can't accept {readresult} as a valid input");
                    }


                }
               
            } while (validateresult == false);
                
        }
    }
}

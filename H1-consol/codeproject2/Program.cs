namespace codeproject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? UInput;
            bool validateinput = false;

            Console.WriteLine("Write A for Admin, M for Manager and U for User");
            do
            {
                UInput = Console.ReadLine();
                
                if (UInput != null)
                {
                    UInput = UInput.ToLower().Trim();
                    if (UInput == "a")
                    {
                        validateinput = true;
                        Console.WriteLine($"hej Administrator");
                    }
                    else if (UInput == "m")
                    {
                        validateinput = true;
                        Console.WriteLine("hej Manager");
                    }
                    else if (UInput == "u")
                    {
                        validateinput = true;
                        Console.WriteLine("hej User");
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                }
            }
            while (validateinput == false);
                Console.WriteLine("input accepted");
        }
    }
    }


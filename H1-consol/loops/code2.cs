using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class code2
    {
        static void Main(string[] args) 
        {
            string? UInput;
            bool validateinput = false;

            Console.WriteLine("Write A for Admin, M for Manager and U for User");
            do
            { 
                UInput = Console.ReadLine().Trim();
                UInput = UInput.ToLower();
                if (UInput != null)
                {
                    if (UInput == "a")
                    {
                        Console.WriteLine($"hej {UInput}");
                    }
                }
            }
            while (validateinput == false);
        }

    }
}

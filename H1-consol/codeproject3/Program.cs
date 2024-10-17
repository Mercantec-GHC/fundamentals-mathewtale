namespace codeproject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myStrings = new string[2]
                    {
            "I like pizza. I like roast chicken. I like salad",
            "I like all three of the menu choices"
                    };

            foreach (string originalString in myStrings)
            {
                string myString = originalString; // Create a mutable copy of the original string
                int periodLocation;

                // Process each sentence
                while ((periodLocation = myString.IndexOf(".")) != -1) // While there's a period in the string
                {
                    // Extract the sentence
                    string sentence = myString.Substring(0, periodLocation).Trim();

                    // Display the sentence (without the period)
                    Console.WriteLine(sentence);

                    // Remove the processed sentence and the period
                    myString = myString.Remove(0, periodLocation + 1).Trim();
                }

                // Display any remaining text after the last period, if any
                if (!string.IsNullOrWhiteSpace(myString))
                {
                    Console.WriteLine(myString.Trim());
                }
            }

        }
    } 
}

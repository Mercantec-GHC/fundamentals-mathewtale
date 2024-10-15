namespace H1_consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            float grade;
            Console.WriteLine("student\t\tGrade\n");
            name = "sophia :";
            grade = (93 + 87 + 98 + 95 + 100) / 5f;
            Console.WriteLine(name + "\t\t" + grade + "\tA");

            name = "Nicolas :";
            grade = (80 + 83 + 82 + 88 + 85) / 5f;
            Console.WriteLine(name + "\t\t" + grade + "\tB");

            name = "Zahirah :";
            grade = (84 + 96 + 73 + 79 + 85) / 5f;
            Console.WriteLine(name + "\t\t" + grade + "\tB");

            name = "Jeong :";
            grade = (90 + 92 + 98 + 100 + 97) / 5f;
            Console.WriteLine(name + "\t\t\t" + grade + "\tA");
        }
    }
}

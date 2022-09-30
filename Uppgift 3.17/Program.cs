using System;
namespace Uppgift_3._17
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Vilket nummer väljer du mellan 1-4");
            int val1 = int.Parse(Console.ReadLine());
            int val2  = int.Parse(Console.ReadLine());
            Console.WriteLine("Välj 1.Addition 2.Subtaraktion 3.multiplikation 4.Division");
            string val3 = Console.ReadLine();
            int val4 = Convert.ToInt32(val3);
            
            switch (val4)
            {
                case 1:
                    Console.WriteLine(val1 + val2);
                    break;
                    case 2:
                    Console.WriteLine(val1 - val2);
                    break;
                case 3:
                    Console.WriteLine(val1 * val2);
                    break;
                case 4:
                    Console.WriteLine(val1 / val2);
                    break;
            }
        }
    }
}
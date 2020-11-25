using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Spielfelder = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Console.WriteLine("Let us play Tic Tac Toe!");
            Console.WriteLine("_{0}__|_{1}__|_{2}__", Spielfelder[0], Spielfelder[1], Spielfelder[2]);
            Console.WriteLine("_{0}__|_{1}__|_{2}__", Spielfelder[3], Spielfelder[4], Spielfelder[5]);
            Console.WriteLine(" {0}  | {1}  | {2}  ", Spielfelder[6], Spielfelder[7], Spielfelder[8]);

            var input = Console.ReadKey(false);
            Console.WriteLine(input.Key);

            double wert = Char.GetNumericValue(input.KeyChar);
            Spielfelder[(int)(wert-1)] = 'X';

            Console.WriteLine("Let us play Tic Tac Toe!");
            Console.WriteLine("_{0}__|_{1}__|_{2}__", Spielfelder[0], Spielfelder[1], Spielfelder[2]);
            Console.WriteLine("_{0}__|_{1}__|_{2}__", Spielfelder[3], Spielfelder[4], Spielfelder[5]);
            Console.WriteLine(" {0}  | {1}  | {2}  ", Spielfelder[6], Spielfelder[7], Spielfelder[8]);


            //var input2 = Console.ReadLine();
            //Console.WriteLine(input2);


        }
    }
}

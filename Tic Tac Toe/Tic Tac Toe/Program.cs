using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Spielfelder = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int spieler = 1;

            while (true)
            {
                Console.WriteLine("Let us play Tic Tac Toe!");
                Console.WriteLine("_{0}__|_{1}__|_{2}__", Spielfelder[0], Spielfelder[1], Spielfelder[2]);
                Console.WriteLine("_{0}__|_{1}__|_{2}__", Spielfelder[3], Spielfelder[4], Spielfelder[5]);
                Console.WriteLine(" {0}  | {1}  | {2}  ", Spielfelder[6], Spielfelder[7], Spielfelder[8]);


                var input = Console.ReadKey(false);
                Console.WriteLine(input.Key);

                double wert = char.GetNumericValue(input.KeyChar);
                if (spieler == 1)
                {
                    Spielfelder[(int)(wert - 1)] = 'X';
                }
                if (spieler == 2)
                {
                    Spielfelder[(int)(wert - 1)] = 'O';
                }
                


                if (spieler == 1)
                {
                    spieler = 2;
                }
                else if (spieler == 2)
                {
                    spieler = 1;                    
                }
                else 
                {
                    //error
                }

                //todo: spieler wechseln
            }

            Console.WriteLine("Let us play Tic Tac Toe!");
            Console.WriteLine("_{0}__|_{1}__|_{2}__", Spielfelder[0], Spielfelder[1], Spielfelder[2]);
            Console.WriteLine("_{0}__|_{1}__|_{2}__", Spielfelder[3], Spielfelder[4], Spielfelder[5]);
            Console.WriteLine(" {0}  | {1}  | {2}  ", Spielfelder[6], Spielfelder[7], Spielfelder[8]);


            //var input2 = Console.ReadLine();
            //Console.WriteLine(input2);


        }
    }
}

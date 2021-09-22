using System;

namespace SnakeAndLadder
{
    class Program
    {
        //Constant
        const int START = 0;
        const int NOPLAY = 1;
        const int SNAKE = 2;
        const int LADDER = 3;
        public static int RollDice(int position)
        {
            Random random = new Random();
            int dice, option;
            dice = random.Next(1, 7);
            option = random.Next(1, 4);
            if (position < 0)
            {
                position = START;
            }
            switch (option)
            {
                case NOPLAY:
                    position += 0;
                    break;
                case LADDER:
                    position += dice;
                    RollDice(position);
                    break;
                case SNAKE:
                    position -= dice;
                    break;
            }
            return position;
        }

        static void Main(string[] args)
        {
            int player1Count = 0;
            int player2Count = 0;

            while (player1Count <= 100 || player2Count <= 100)
            {
                player1Count = RollDice(player1Count);
                player2Count = RollDice(player2Count);
                if (player1Count == 100 || player2Count == 100)
                {
                    break;
                }
            }

            if (player1Count == 100)
            {
                Console.WriteLine("Player 1 is winner " + player1Count);
            }
            else
            {
                Console.WriteLine("Player 2 is winner " + player2Count);
            }

        }
    }
}

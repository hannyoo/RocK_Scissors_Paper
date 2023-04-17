using System;

namespace MyApp
{
    internal class Program
    {
        enum Choice
        {
            Scissors = 1,
            Rock = 2,
            Paper = 3
        }
        static void Main( string[] args )
        {
            Random random = new Random( );                         // 컴퓨터의 랜덤선택
            int cmptrChoice = random.Next(1, 4);                   // 1 ~ 3 사이의 값

            int myChoice = Convert.ToInt32(Console.ReadLine( ));   // 내 선택 입력

            switch(myChoice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("1_Scissors");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("2_Rock");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("3_Paper");
                    break;
            }

            switch(cmptrChoice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("cmptr_Scissor");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("cmptr_Rock");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("cmptr_Paper");
                    break;
            }

            if(myChoice == cmptrChoice) 
            {
                Console.WriteLine("Draw");
            }
            else if(myChoice == (int)Choice.Scissors && cmptrChoice== (int)Choice.Paper)
            {
                Console.WriteLine("You Win");
            }
            else if(myChoice == (int)Choice.Rock && cmptrChoice == (int)Choice.Scissors)
            {
                Console.WriteLine("You Win");
            }
            else if(myChoice == (int)Choice.Paper && cmptrChoice == (int)Choice.Rock)
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("You Lose");
            }
        }
    }
}

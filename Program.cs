namespace RockPaperScissor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!, WElcome to Rock Paper and Scissors game");

            // Accepting choice from Player

            
            int pl_choice = UserChoice();
            String player_choice = ConvertChoice(pl_choice);
            Console.WriteLine("You chose :  " + player_choice);


            //Generating Computer Choice for Rock Papee Scissor

            int c_choice = ComputerChoice();
            String Comp_choice = ConvertChoice(c_choice);
            Console.WriteLine("Computer Chose : " + Comp_choice);

            FindWinner(pl_choice, c_choice);

            Console.WriteLine("DO you wish to continue to play");
            char ch = char.Parse(Console.ReadLine());


        }

        public static int UserChoice()
        {
            Console.WriteLine("Pls enter your choice for Rock, Paper or Scissor");
            Console.WriteLine("Enter 1 for Rock, 2 for Paper and 3 for Scissor");
            int p_choice = int.Parse(Console.ReadLine());
            return p_choice;
        }

        public static int ComputerChoice()
        {

            int c_choice = new Random().Next(1, 3);
            return c_choice;
        }

        public static String ConvertChoice(int InputValue)
        {
            String choice = "";
            switch (InputValue)
            {
                case 1:
                    choice = "Rock";
                    //   Console.WriteLine(Comp_choice);
                    break;

                case 2:
                    choice = "Paper";
                    // Console.WriteLine(Comp_choice);
                    break;

                case 3:
                    choice = "Scissor";
                    // Console.WriteLine(Comp_choice);
                    break;

            }
            return choice;

        }


        public static void FindWinner(int p_choice, int c_choice)
        {


            if (p_choice == c_choice)
            {
                Console.WriteLine("Its a draw");
            }
            else
            {
                if (p_choice == 1)
                {
                    if (c_choice == 2)
                    {
                        Console.WriteLine("Computer is the winner");
                    }
                    else
                    {
                        Console.WriteLine("You is the winner");
                    }
                }
                else
                    if (p_choice == 2)
                {
                    if (c_choice == 1)
                    {
                        Console.WriteLine("You are the winner");
                    }
                    else
                    {
                        Console.WriteLine("Computer is the winner");
                    }
                }
                else
                    if (p_choice == 3)
                {
                    if (c_choice == 1)
                    {
                        Console.WriteLine("Computer is the winner");
                    }
                    else
                    {
                        Console.WriteLine("You are the winner");
                    }
                }




            }
        }




    }
}

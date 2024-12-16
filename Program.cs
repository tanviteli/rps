namespace RockPaperScissor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!, WElcome to Rock Paper and Scissors game");

            // Accepting choice from Player
            int pl_choice;
            int c_choice;
            String player_choice = "";
            String Comp_choice = "";
            char ch;

            do
            {
                pl_choice = UserChoice();
                player_choice = ConvertChoice(pl_choice);
                Console.WriteLine("You chose :  " + player_choice);


                //Generating Computer Choice for Rock Papee Scissor

                c_choice = ComputerChoice();
                Comp_choice = ConvertChoice(c_choice);
                Console.WriteLine("Computer Chose : " + Comp_choice);

                FindWinner(pl_choice, c_choice);

                Console.WriteLine("DO you wish to continue to play");
                ch = char.Parse(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');


        }

        //Method to accept user's choice
        public static int UserChoice()
        {
            Console.WriteLine("Pls enter your choice for Rock, Paper or Scissor");
            Console.WriteLine("Enter 1 for Rock, 2 for Paper and 3 for Scissor");
            int p_choice = int.Parse(Console.ReadLine());
            return p_choice;
        }

        //Method to generate random computer choice
        public static int ComputerChoice()
        {

            int c_choice = new Random().Next(1, 3);
            return c_choice;
        }

        // Method to convery User and Computer choice to STring
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

        // Method to find the winner
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

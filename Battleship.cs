using System;

namespace The_Battleship
{

    class Program
    {

        static void Main(string[] args)
        {

            // creating start screen variable
            string pName, gameLevel = "Atlantis" ;
            

            // ask for player name
            Console.Writeline("Please enter your name");
            pName = Console.Readline()

            // display welcome message
            Console.Writeline($"Hello {pName} ! Welcone to the battleship");
            Console.Writeline("----------------------------------------------------");

            // ask player if they want to play again
            bool playing = true;
            while(playing)
            {
                
                // defining game variables
                int cannonBalls = 10, bships = 5;

                // informing player of the new game
            Console.Writeline($"You have entered the waters of {gamelevel}!");
            Console.Writeline($"{bships} hostile ships are coming, you have {CannonBalls} cannonballs to destroy them!");
            Console.Writeline("----------------------------------------------------");

                // asking if the player wants to play again or not
                Console.Writeline("Do you want to play the game again? Yes/No ");
                string ans = Console.Readline();
                if(ans.Equals("No"))
                {
                    Console.Writeline("Thank you for playing");
                    playing = false;
                } 
            }
        }
    }
}

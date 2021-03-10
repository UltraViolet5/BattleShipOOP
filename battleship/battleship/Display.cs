using System;
using battleship.enums;

namespace battleship
{
    public class Display
    {
        /*
        Implement class Display and its methods.
        Class Display prints the game menu.
        Class Display prints the board during manual ship placement process.
        Class Display prints the gameplay.
        Class Display prints the outcome of the game when it's over.
        No Console.WriteLine() happens outside of Display class.
        */


        public void Ocean(Board Ocean_player_A, Board Ocean_player_B)
        {
/*
Zerowa linia zaczyna się od opisu plansz graczy A i B
pierwsza linia zazczyna się od dwuch spacji potem pierwsza litera alfabetu potem spacja i druga alfabetu potem spacja i trzecia listera

Od drugiej lini zaczyna się od cyfra lini potem spacja potem pozycja okrętu 0 po Y i 0 po X potem 0 po Y i 1 po X potem 0 po Y i 2 po X  


PLAYER A       PLAYER B
  A B C D E F  A B C D E F  
1 O O O O O O  O O O O O O 1
2 O O O O O O  O O O O O O 2
3 O O O O O O  O O O O O O 3
4 O O O O O O  O O O O O O 4
5 O O O O O O  O O O O O O 5
  A B C D E F  A B C D E F  
*/


        }

        public void Menu(DisplayText version)
        {
            //version 0 Welcome text
            switch (version)
            {
                case DisplayText.WelcomeGraphic :

                Console.WriteLine(" _    _      _                                 ");
                Console.WriteLine("| |  | |    | |                                ");
                Console.WriteLine("| |  | | ___| | ___ ___  _ __ ___   ___        ");
                Console.WriteLine("| |/\\| |/ _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\       ");
                Console.WriteLine("\\  /\\  /  __/ | (_| (_) | | | | | |  __/       ");
                Console.WriteLine(" \\/  \\/ \\___|_|\\___\\___/|_| |_| |_|\\___|       ");
                Console.WriteLine("                                               ");
                Console.WriteLine("                                               ");
                Console.WriteLine("                _                              ");
                Console.WriteLine("               (_)                             ");
                Console.WriteLine("                _ _ __                         ");
                Console.WriteLine("               | | '_ \\                        ");
                Console.WriteLine("               | | | | |                       ");
                Console.WriteLine("               |_|_| |_|                       ");
                Console.WriteLine("                                               ");
                Console.WriteLine("                                               ");
                Console.WriteLine(" _           _   _   _           _     _       ");
                Console.WriteLine("| |         | | | | | |         | |   (_)      ");
                Console.WriteLine("| |__   __ _| |_| |_| | ___  ___| |__  _ _ __  ");
                Console.WriteLine("| '_ \\ / _` | __| __| |/ _ \\/ __| '_ \\| | '_ \\ ");
                Console.WriteLine("| |_) | (_| | |_| |_| |  __/\\__ \\ | | | | |_) |");
                Console.WriteLine("|_.__/ \\__,_|\\__|\\__|_|\\___||___/_| |_|_| .__/ ");
                Console.WriteLine("                                        | |    ");
                Console.WriteLine("                                        |_|   ");


                break;
                
                case DisplayText.WelcomeMenu: // Welcome menu

                    Console.WriteLine("*********************************************");
                    Console.WriteLine("*                                           *");
                    Console.WriteLine("* 1 - Start multiplayer game                *");
                    Console.WriteLine("* 2 - Start singleplayer game win AI        *");
                    Console.WriteLine("* 3 - Info about game                       *");
                    Console.WriteLine("* 4 - to exit game                          *");
                    Console.WriteLine("*                                           *");
                    Console.WriteLine("*********************************************");


                    break;
                case DisplayText.InfoAboutGame: // info about game
                    Console.WriteLine("****************************************************************************");
                    Console.WriteLine("*                                                                          *");
                    Console.WriteLine("* Battleship (also Battleships or Sea Battle[1]) is a strategy type        *");
                    Console.WriteLine("* guessing game for two players. It is played on ruled grids               *");
                    Console.WriteLine("* (paper or board) on which each player's fleet of ships                   *");
                    Console.WriteLine("* (including battleships) are marked.                                      *");
                    Console.WriteLine("* The locations of the fleets are concealed from the other player. Players *");
                    Console.WriteLine("* alternate turns calling \"shots\" at the other player's ships, and the     *");
                    Console.WriteLine("* objective of the game is to destroy the opposing player's fleet.         *");
                    Console.WriteLine("* Battleship is known worldwide as a pencil and paper game which dates     *");
                    Console.WriteLine("* from World War I. It was published by various companies as a             *");
                    Console.WriteLine("* pad-and-pencil g0ame in the 1930s, and was released as a plastic board   *");
                    Console.WriteLine("* game by Milton Bradley in 1967. The game has spawned electronic          *");
                    Console.WriteLine("* versions, video games, smart device apps and a film.                     *");
                    Console.WriteLine("*                                                                          *");
                    Console.WriteLine("****************************************************************************");
                    break;

                case DisplayText.BoardSizeInput: // input board size

                    Console.WriteLine("*********************************************");
                    Console.WriteLine("*                                           *");
                    Console.WriteLine("*    Put board size (5 - 10)                *");
                    Console.WriteLine("*                                           *");
                    Console.WriteLine("*********************************************");

                    break;

            }
        }
    }
}
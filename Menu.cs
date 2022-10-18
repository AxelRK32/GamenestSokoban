using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace MapTemplate
{
    class Menu
    {
        public Menu()
        {

            while (true)
            {
                Console.WriteLine("Welcome to the Sokoban game");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Play game");
                Console.WriteLine("2. Select level");
                Console.WriteLine("3. How to play");
                ConsoleKeyInfo Keyinfo;
                Keyinfo = Console.ReadKey(true);

                switch (Keyinfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Game game = new Game();
                        Player player = new Player();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();

                        bool level = false;
                        while (!(level))
                        {
                            Console.WriteLine("Level 1");
                            Console.WriteLine("Level 2");
                            Console.WriteLine("Level 3");
                            Console.WriteLine("Press a number to select level. Press esc to go back to the menu");
                            Keyinfo = Console.ReadKey(true);

                            switch (Keyinfo.Key)
                            {
                                case ConsoleKey.D1:
                                    Console.Clear();
                                    Game game1 = new Game();
                                    player = new Player();
                                    break;
                                case ConsoleKey.D2:
                                    Console.Clear();
                                    Console.WriteLine("This level doesen't exist yet");
                                    break;
                                case ConsoleKey.D3:
                                    Console.Clear();
                                    Console.WriteLine("This level doesen't exist yet");
                                    break;
                                case ConsoleKey.Escape:
                                    Console.Clear();
                                    level = true;
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("You play as the 'P'. You can move it around with arrow keys");
                        Console.WriteLine("'W' is a wall. 'B' is a box and '.' is an empty space.");
                        Console.WriteLine("If there is a wall in the way you cannot move there.");
                        Console.WriteLine("If there is a box in the way it will be pushed the way you move unless there is a wall or another box in the way");
                        Console.WriteLine("If there is an empty space or an 'o' in the way you can move there");
                        Console.WriteLine("There are places in the map marked with 'o' which you need to push the boxes to in order to win");
                        Console.WriteLine("If you want stop playing and go back to the menu press the esc key");
                        bool how = false;
                        while (!(how))
                        {
                            Keyinfo = Console.ReadKey(true);
                            switch (Keyinfo.Key)
                            {
                                case ConsoleKey.Escape:
                                    how = true;
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong key. Try again");
                        break;
                }
            }
        }
    }
}
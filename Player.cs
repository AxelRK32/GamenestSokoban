using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTemplate
{
    class Player
    {
        public Player()
        {
            while (true)
            {
                ConsoleKeyInfo Keyinfo;
                Keyinfo = Console.ReadKey(true);

                switch (Keyinfo.Key)
                {
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Menu menu = new Menu();
                        break;
                }
            }
        }
    }
}
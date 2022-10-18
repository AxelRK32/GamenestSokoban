using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Map
    {
        string[][] map =
        {
            new string[] { "w", "w", "w", "w", "w", "w", "w", "w", "w", "w" },
            new string[] { "w", "o", ".", ".", "w", ".", ".", ".", ".", "w" },
            new string[] { "w", ".", ".", ".", "w", ".", "w", "w", ".", "w" },
            new string[] { "w", ".", "w", ".", "w", ".", "w", "w", ".", "w" },
            new string[] { "w", ".", "w", ".", "w", ".", "w", "w", "B", "w" },
            new string[] { "w", ".", ".", ".", "B", ".", ".", ".", ".", "w" },
            new string[] { "w", ".", "w", ".", "w", ".", "w", "w", ".", "w" },
            new string[] { "w", ".", "B", ".", "w", "B", "w", "w", "o", "w" },
            new string[] { "w", ".", ".", ".", "o", ".", "w", "w", "o", "w" },
            new string[] { "w", "w", "w", "w", "w", "w", "w", "w", "w", "w" }
        };

        string[][] tempMap;

        public Map()
        {

        }

        // This function places all my moveable objects on my static map,
        // then prints it.
        public void PrintMap(List<GameObject> objects)
        {
            tempMap = (string[][])map.Clone();
            foreach (GameObject obj in objects)
            {
                tempMap[obj.X][obj.Y] = obj.mapMarker;
            }

            PrintMap(tempMap);
        }

        // This function prints a map that is given to it.
        private void PrintMap(string[][] mapToPrint)
        {
            for (int y = 0; y < mapToPrint.Length; y++)
            {
                for (int x = 0; x < mapToPrint[y].Length; x++)
                {
                    Console.Write(mapToPrint[y][x] + " ");
                }
                Console.WriteLine();
            }
        }

        // Returns what kind of tile it is via an x and y value.
        public string ReturnTile(int x, int y)
        {
            if (x < 0 || y < 0 || x > map[y].Length || y > map.Length)
            {
                return "";
            }
            return map[y][x];
        }
    }
}

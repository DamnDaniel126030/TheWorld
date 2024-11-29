using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld
{
    internal class World
    {
        public static int Width;
        public static int Height;
        public Cell[,] Cells;

        public World(int width, int height)
        {
            Width = width;
            Height = height;
            Cells = new Cell[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Cells[i, j] = new Cell(i, j);
                }
            }
        }
      
        public static Cell GetCell(int x, int y)
        {
            //World staticWorld = new World(Width, Height);
            //return staticWorld.Cells[x, y];                       //Mindig újat fog csinálni úgyhogy nem jó.........
        }

        public void AddCreature(Creature creature, int x, int y)
        {
			//World staticWorld = new World(Width, Height);
			//staticWorld.Cells[x, y].Inhabitants.Add(creature);
		}

        public void AddPlant(Plant plant, int x, int y)
        {
			//World staticWorld = new World(Width, Height);
   //         staticWorld.Cells[x, y].Plant = plant;
		}

        public void RemoveCreature(Creature creature, int x, int y)
        {
            
        }



    }
}

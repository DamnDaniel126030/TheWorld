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
        public static Cell[,] Cells;

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
      
        public Cell GetCell(int x, int y)
        {
            return Cells[x, y];
        }

        //public void AddCreature(Creature creature, int x, int y)
        //{
        //    cells[x, y] = creature;
        //}

        //public void AddPlant(Plant plant, int x, int y)
        //{
        //    cells[x, y] = plant;
        //}

        //public void RemoveCreature(Creature creature)
        //{
        //    for (int i = 0; i < width; i++)
        //    {
        //        for (int j = 0; j < height; j++)
        //        {
        //            if ()
        //        }
        //    }
        //}

        

    }
}

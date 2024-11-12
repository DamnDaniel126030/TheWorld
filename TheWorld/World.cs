using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld
{
    internal class World
    {
        private int width;
        private int height;
        private Cell[,] cells;

        public World(int width, int height)
        {
            this.width = width;
            this.height = height;
            cells = new Cell[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    cells[i, j] = new Cell(i, j);
                }
            }
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        internal Cell[,] Cells { get => cells; set => cells = value; }

        public Cell GetCell(int x, int y)
        {
            return cells[x, y];
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

        public List<Cell> GetNeighbours(Cell cell)
        {
            List<Cell> neighbourCells = new List<Cell>();
            return neighbourCells;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld
{
    internal class Herbivore : Creature
    {
        private int size;

        public Herbivore(int energy, int sightrange, Cell currentCell, int size) : base(energy, sightrange, currentCell)
        {
            this.size = size;
        }

        public override void Eat(Creature otherCreature)
        {
            if (CurrentCell.Plant != null && otherCreature.Equals(CurrentCell.Plant))
            {
                CurrentCell.Plant = null;
                Energy += 30;
            }
        }

        public override void Move(Cell newCell)
        {
            CurrentCell = newCell;
        }

        public Cell FindBestCellToMove()
        {
            Cell[,] cells = World.Cells;
            Cell bestCell = null;
            for (int i = 0; i < World.Width; i++)
            {
                for (int j = 0; j < World.Height; j++)
                {
                    if (cells[i, j].Plant != null && cells[i, j].HowManyCarnivores() < CurrentCell.HowManyCarnivores())
                    {
                        bestCell = cells[i, j];
                        CurrentCell = bestCell;
                    }
                }
            }
            return bestCell;
        }

        public void EatPlant()
        {
            if (CurrentCell.Plant != null)
            {
                CurrentCell.Plant = null;
                Energy += 30;
            }
        }
    }
}

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

        //public Cell FindBestCellToMove()
        //{
            
        //}

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

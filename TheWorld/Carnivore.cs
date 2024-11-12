using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld
{
    internal class Carnivore : Creature
    {
        private int size;

        public Carnivore(int energy, int sightrange, Cell currentCell, int size) : base(energy, sightrange, currentCell)
        {
            this.size = size;
        }

        public override void Eat(Creature otherCreature)
        {
            if (CurrentCell.Inhabitants.Count > 1)
            {
                foreach (Creature creature in CurrentCell.Inhabitants)
                {
                    if (creature == otherCreature && otherCreature.IsAlive())
                    {
                        creature.Energy = 0;
                        Energy += 50;
                    }
                }
            }
            else
            {
                return;
            }
        }

        public override void Move(Cell newCell)
        {
            CurrentCell = newCell;
        }


    }
}

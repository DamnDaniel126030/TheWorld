using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld
{
    internal abstract class Creature
    {
        private int energy;
        private int sightrange;
        private Cell currentCell;

        protected Creature(int energy, int sightrange, Cell currentCell)
        {
            this.energy = energy;
            this.sightrange = sightrange;
            this.currentCell = currentCell;
        }

        public int Energy { get => energy; set => energy = value; }
        public int Sightrange { get => sightrange; set => sightrange = value; }
        internal Cell CurrentCell { get => currentCell; set => currentCell = value; }

        public abstract void Move(Cell newCell);

        public abstract void Eat(Creature otherCreature);

        public bool IsAlive()
        {
            if(energy < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

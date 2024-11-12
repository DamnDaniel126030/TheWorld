using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld
{
    internal class Cell
    {
        private int x;
        private int y;
        private List<Creature> inhabitants;
        private Plant plant;

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.inhabitants = new List<Creature>();
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        internal List<Creature> Inhabitants { get => inhabitants; set => inhabitants = value; }
        internal Plant Plant { get => plant; set => plant = value; }

        public void AddCreature(Creature creature)
        {
            inhabitants.Add(creature);
        }

        public void RemoveCreature(Creature creature)
        {
            inhabitants.Remove(creature);
        }

        public void AddPlant(Plant plant)
        {
            this.plant = plant;
        }
    }
}

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
        private List<Cell> neighbourCells;

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.inhabitants = new List<Creature>();
            this.neighbourCells = new List<Cell>();
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

        public int HowManyCarnivores()
        {
            int numOfCarnivores = 0;
            foreach (Creature creature in inhabitants)
            {
                if (typeof(Carnivore).Equals(creature))
                {
                    numOfCarnivores++;
                }
            }
            return numOfCarnivores;
        }

		public int HowManyHerbivores()
		{
			int numOfHerbivores = 0;
			foreach (Creature creature in inhabitants)
			{
				if (typeof(Herbivore).Equals(creature))
				{
					numOfHerbivores++;
				}
			}
			return numOfHerbivores;
		}

        public void GetNeighbourCells()
        {
            Cell currentCell = World.Cells[this.x, this.y];
            //if (currentCell )
        }
	}
}

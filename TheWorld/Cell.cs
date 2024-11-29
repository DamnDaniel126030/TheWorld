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
        public List<Creature> Inhabitants { get => inhabitants; set => inhabitants = value; }
        public Plant Plant { get => plant; set => plant = value; }
		public List<Cell> NeighbourCells { get => neighbourCells; set => neighbourCells = value; }

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
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0) continue;
                    int nx = this.x + dx;
                    int ny = this.y + dy;
                    if (nx >= 0 && ny >= 0 && nx < World.Width && ny < World.Height)
                    {
                        this.neighbourCells.Add(World.GetCell(nx, ny));
                    }
                }
            }

        }

        public void SpreadPlant()
        {
            if (this.plant != null && this.plant.IsFullyGrown)
            {
                this.GetNeighbourCells();
                foreach (Cell cell in this.neighbourCells)
                {
                    cell.plant = this.plant;
                }
            }
        }
	}
}

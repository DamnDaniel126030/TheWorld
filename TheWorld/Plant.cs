using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld
{
    internal class Plant
    {
        private int growthLevel;
        private bool isFullyGrown;

		public Plant(int growthLevel, bool isFullyGrown)
		{
			this.growthLevel = growthLevel;
			this.isFullyGrown = isFullyGrown;
		}

		public int GrowthLevel { get => growthLevel; set => growthLevel = value; }
		public bool IsFullyGrown { get => isFullyGrown; set => isFullyGrown = value; }

		public void Grow()
		{
			this.growthLevel++;
			if (growthLevel == 5)
			{
				Spread();
			}
		}

		public void Spread()
		{

		}

	}
}

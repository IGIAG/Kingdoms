using Kingdoms.Buildings;
using Kingdoms.Buildings.Housing;

namespace Kingdoms
{
    public class Kingdom
    {
		public int Age { get; set; } = 0;
		public int People { get; set; }
		public int Gold { get; set; }
		public int Materials { get; set; }
		public float Happyness { get; set; }
		public int Water { get; set; }
		public int Food { get; set; }

		public int LastAge { get; set; } = 0;
        public int LastPeople { get; set; } = 0;
        public int LastGold { get; set; } = 0;
        public int LastMaterials { get; set; } = 0;
        public float LastHappyness { get; set; } = 0;
        public int LastWater { get; set; } = 0;
		public int LastFood { get; set; } = 0;

		public bool Failed { get; set; } = false;

        public List<Building> Buildings { get; set; } = new List<Building>() { new Castle() };

		public void Logic()
        {
            LastAge = Age;
            LastPeople = People;
            LastGold = Gold;
            LastMaterials = Materials;
            LastHappyness = Happyness;
            LastWater = Water;
            LastFood = Food;
            if (Failed)
            {
                throw new Exception("Can't Process a failed kingdom!");
            }
            Age++;
            BaseBehaviour();

            foreach (Building b in Buildings)
            {
                b.Policy(this);
            }
            if(People <= 0)
            {
                Failed = true;
            }
        }

        private void BaseBehaviour()
        {
			Happyness = Math.Clamp(Happyness--, 0, 100);
            Food = Math.Max(Food - People, 0);

            if(Happyness < 25)
            {
                People = Math.Max((int)(People * 0.9),0);
            }
			if (Happyness > 80)
			{
				People += (int)Math.Max(Random.Shared.Next(-10,2),0);
			}
			if (Food == 0)
            {
				Happyness = (float)Math.Clamp((Happyness - People * Config.StarvingPenaltyPerPerson), 0, 100);
			}
            if (GetCapacity() > People)
            {
                Happyness = (float)Math.Clamp((Happyness + Config.HappynessBonusForHousing), 0, 100);
			}


		}

        public void BuyBuilding(Building b)
        {
            if(b.GoldCost <= Gold && b.MaterialsCost <= Materials)
            {
                Buildings.Add(b);
                Gold -= b.GoldCost;
                Materials -= b.MaterialsCost;
                return;
            }

        }
        public int GetCapacity()
        {
			return Buildings.Where(x => x.GetType().IsSubclassOf(typeof(House))).Sum(x => ((House)x).Capacity);
		}


    }
}

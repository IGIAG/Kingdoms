namespace Kingdoms.Buildings.Production
{
	[Purchasable]
	public class Farm : Building
	{
		public override string Name => "Farm";

		public override string Description => "Makes 10 food for 1 water";

		public override int GoldCost => 10;

		public override int MaterialsCost => 0;

		public override bool Invincable => false;

		public override void Policy(Kingdom kingdom)
		{
			if(kingdom.Water > 0)
			{
				kingdom.Water--;
				kingdom.Food += 10;
			}
		}
	}
}

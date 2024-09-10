namespace Kingdoms.Buildings.Production
{
	[Purchasable]
	public class WaterPump : Building
	{
		public override string Name => "Water pump";

		public override string Description => "Pumps 1L of water";

		public override int GoldCost => 10;

		public override int MaterialsCost => 0;

		public override bool Invincable => false;

		public override void Policy(Kingdom kingdom)
		{
			kingdom.Water++;
		}
	}
}

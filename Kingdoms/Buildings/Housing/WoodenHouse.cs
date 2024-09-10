namespace Kingdoms.Buildings.Housing
{
	[Purchasable]
	public class WoodenHouse : House
	{
		public override string Name => "Wooden House";

		public override string Description => "A simple wooden house ( Houses 8 people )";

		public override int Capacity => 8;

		public override int GoldCost => 40;

		public override int MaterialsCost => 40;

		public override bool Invincable => false;
	}
}

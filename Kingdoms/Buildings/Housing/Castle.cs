namespace Kingdoms.Buildings.Housing
{
	public class Castle : House
	{
		public override int Capacity => 10;

		public override string Name => "Castle";

		public override string Description => "Fill this in later";

		public override int GoldCost => 0;

		public override int MaterialsCost => 0;

		public override bool Invincable => true;
	}
}

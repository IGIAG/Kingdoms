namespace Kingdoms.Buildings.Housing
{
	public class Tenement : House
	{
		public override string Name => "Tenement";

		public override string Description => "A tenement ( Houses 20 people )";

		public override int Capacity => 20;

		public override int GoldCost => 40;

		public override int MaterialsCost => 40;

		public override bool Invincable => false;

		public override string RenderString => "🏨";
	}
}

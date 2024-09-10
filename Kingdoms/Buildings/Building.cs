namespace Kingdoms.Buildings
{
	public abstract class Building
	{
		public abstract string Name { get; }

		public abstract string Description { get; }

		public abstract int GoldCost { get; }

		public abstract int MaterialsCost { get; }

		public abstract void Policy(Kingdom kingdom);

		public abstract bool Invincable { get; }
	}
}

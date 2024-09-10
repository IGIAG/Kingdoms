namespace Kingdoms.Buildings
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class PurchasableAttribute : Attribute
	{
		public PurchasableAttribute() { }
	}
}

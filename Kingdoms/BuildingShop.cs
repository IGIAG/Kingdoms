using System.Reflection;
using Kingdoms.Buildings;

namespace Kingdoms
{
	public class BuildingShop
	{
		public static IEnumerable<Type> BuildingTypes = from type in Assembly.GetExecutingAssembly().GetTypes()
												 where type.GetCustomAttributes<PurchasableAttribute>().Count() > 0 && type.IsAssignableTo(typeof(Building))
												 select type;


	}
}

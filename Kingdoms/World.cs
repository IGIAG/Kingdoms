namespace Kingdoms
{
	public static class World
	{
		private static List<Kingdom> Kingdoms = new List<Kingdom>();

		public static void SpawnKingdom(Kingdom kingdom)
		{
			if (!Kingdoms.Contains(kingdom))
			{
				Kingdoms.Add(kingdom);
			}

		}
		public static void DespawnKingdom(Kingdom kingdom)
		{
			if (!Kingdoms.Contains(kingdom))
			{
				Kingdoms.Remove(kingdom);
			}
		}

		public static async Task RunWorld()
		{
			while (true)
			{
				await Task.Delay(5000);
				foreach (var kingdom in Kingdoms)
				{
					try
					{
						kingdom.Logic();
					}
					catch (Exception e)
					{
						kingdom.Failed = true;
						DespawnKingdom(kingdom);
						Console.WriteLine(e);
					}
				}
			}


		}
	}
}

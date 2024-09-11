namespace Kingdoms.Buildings.Production
{
    [Purchasable]
    public class TaxOffice : Building
    {
        public override string Name => "Tax office";

        public override string Description => "Collects taxes from your people. Place more for increased tax";

        public override int GoldCost => 40;

        public override int MaterialsCost => 10;

		public override bool Invincable => false;

		public override string RenderString => "🏛️";

		public override void Policy(Kingdom kingdom)
        {
            double YieldPerPerson = Config.TaxYieldPerPerson;

            int GoldCollected = (int)(YieldPerPerson * kingdom.People);

            int HappynessPenalty = (int)(YieldPerPerson * Config.HappynessPenaltyForTax);

            kingdom.Gold += GoldCollected;
            kingdom.Happyness = Math.Clamp(kingdom.Happyness - HappynessPenalty, 0, 100);
        }
    }
}

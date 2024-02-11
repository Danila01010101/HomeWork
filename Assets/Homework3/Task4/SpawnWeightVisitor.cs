using Assets.Homework3.Task3.Scripts;

namespace Assets.Homework3
{
    public class SpawnWeightVisitor : ISpawnVisitor
    {
        public int Weight => _weight;

        public int _weight = 0;

        public void Visit(Coin coin) => _weight += 1;

        public void Visit(BonusCoin coin) => _weight += 5;
    }
}
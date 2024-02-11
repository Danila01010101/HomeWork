using Assets.Homework3.Task3.Scripts;

namespace Assets.Homework3
{
    public interface ISpawnVisitor
    {
        void Visit(Coin coin);
        void Visit(BonusCoin coin);
    }
}
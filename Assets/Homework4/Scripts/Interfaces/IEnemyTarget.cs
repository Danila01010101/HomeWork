using System.Numerics;

namespace Assets.Homework4.Scripts
{
    public interface IEnemyTarget : IDamagable
    {
        Vector3 Position { get; }
    }
}
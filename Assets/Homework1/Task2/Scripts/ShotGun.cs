using UnityEngine;

public class ShotGun : Gun
{
    private int shotsAmount = 3;

    public override void TryShoot()
    {
        for (int i = 0; i < shotsAmount; i++)
        {
            base.TryShoot();
        }
    }
}
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private bool infiniteAmmo = false;
    [SerializeField] private int ammo = 1;

    private int currentAmmo;

    private void Awake()
    {
        currentAmmo = ammo;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TryShoot();
        }
    }

    public virtual void TryShoot()
    {
        if (currentAmmo > 0)
        {
            Debug.Log("Bang!");
            UseAmmo();
        }
        else
        {
            Debug.Log("Nothing to shoot! No more Ammo :(");
        }
    }

    private void UseAmmo()
    {
        if (infiniteAmmo == false) currentAmmo--;
    }
}
using UnityEngine;

public class GunSwitcher : MonoBehaviour
{
    [SerializeField] private Gun[] guns;

    private int currentWeaponIndex = 0;

    private void Awake()
    {
        foreach (var gun in guns) 
        { 
            gun.gameObject.SetActive(false); 
        }

        SwitchWeapon(currentWeaponIndex);
    }

    private void Update()
    {
        int weaponIndex = -1;

        if (Input.GetKeyDown(KeyCode.Alpha1)) weaponIndex = 0;

        if (Input.GetKeyDown(KeyCode.Alpha2)) weaponIndex = 1;

        if (Input.GetKeyDown(KeyCode.Alpha3)) weaponIndex = 2;

        if (weaponIndex != -1) SwitchWeapon(weaponIndex);
    }

    public void SwitchWeapon(int weaponIndex)
    {
        guns[currentWeaponIndex].gameObject.SetActive(false);
        currentWeaponIndex = weaponIndex;
        guns[currentWeaponIndex].gameObject.SetActive(true);
    }
}
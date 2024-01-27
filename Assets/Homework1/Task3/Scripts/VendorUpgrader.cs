using UnityEngine;

public class VendorUpgrader : MonoBehaviour
{
    [SerializeField] private Vendor vendor;

    private int reputation = 0;
    private void Initialize()
    {
        vendor.Initialize(new NonContactable());
    }

    private void Awake()
    {
        Initialize();
    }

    private void OnEnable()
    {
        Vendor.PlayerContacted += Upgrade;
    }

    private void OnDisable()
    {
        Vendor.PlayerContacted -= Upgrade;
    }


    private void Upgrade()
    {
        switch (++reputation)
        {
            case 0:
                vendor.Initialize(new NonContactable());
                break;
            case 1:
                vendor.Initialize(new ArmourSeller());
                break;
            case 2:
                vendor.Initialize(new FruitSeller());
                break;
        }
    }
}
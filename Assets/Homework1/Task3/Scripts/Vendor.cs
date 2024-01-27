using System;
using UnityEngine;

public class Vendor : MonoBehaviour
{
    private ISeller seller;

    private bool isInitialized = false;

    public static Action PlayerContacted;

    public void Initialize(ISeller seller)
    {
        isInitialized = true;
        this.seller = seller;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
        {
            Contact(player);
        }
    }

    public void Contact(Player player)
    {
        if (isInitialized == false) return;

        PlayerContacted?.Invoke();
        seller.Sell(player);
    }
}
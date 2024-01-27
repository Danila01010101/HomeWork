using UnityEngine;

public class Player : MonoBehaviour
{
    public void Trade(string item)
    {
        Debug.Log("You got a new item! - " + item);
    }
}
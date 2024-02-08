using System;
using UnityEngine;

public class LevelInput : MonoBehaviour
{
    public Action CButtonPressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            CButtonPressed?.Invoke();
        }
    }
}
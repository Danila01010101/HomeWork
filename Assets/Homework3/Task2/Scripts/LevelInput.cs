using System;
using UnityEngine;

namespace Assets.Homework3.Task2.Scripts
{
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
}
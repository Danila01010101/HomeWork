using System;
using UnityEngine;
using Zenject;

namespace Assets.Homework4.Scripts
{
    public class DesctopInput : IInput, ITickable
    {
        public event Action<Vector3> ClickDown;
        public event Action<Vector3> ClickUp;
        public event Action<Vector3> Drag;

        private const int LeftMouseButton = 0;

        private Vector3 _previousMousePosition;
        private bool _isSwiping = false;

        public void Tick()
        {
            ProcessClickUp();
            ProcessClickDown();
            ProcessSwipe();
        }

        private void ProcessSwipe()
        {
            if (_isSwiping == false)
                return;

            if (Input.mousePosition != _previousMousePosition)
                Drag(Input.mousePosition);

            _previousMousePosition = Input.mousePosition;
        }

        private void ProcessClickDown()
        {
            if (Input.GetMouseButtonDown(LeftMouseButton))
            {
                ClickDown?.Invoke(Input.mousePosition);
                _isSwiping = true;
            }
        }

        private void ProcessClickUp()
        {
            if (Input.GetMouseButtonUp(LeftMouseButton))
            {
                ClickUp?.Invoke(Input.mousePosition);
                _isSwiping = false;
            }
        }
    }
}
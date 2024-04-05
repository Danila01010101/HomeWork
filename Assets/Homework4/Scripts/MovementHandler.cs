using System;
using UnityEngine;

namespace Assets.Homework4.Scripts
{
    public class MovementHandler: IDisposable
    {
        private IInput _input;

        public MovementHandler(IInput input)
        {
            _input = input;

            _input.ClickDown += OnClickDown;
            _input.ClickUp += OnClickUp;
            _input.Drag += OnDrag;
        }

        public void Dispose()
        {
            _input.ClickDown -= OnClickDown;
            _input.ClickUp -= OnClickUp;
            _input.Drag -= OnDrag;
        }

        private void OnDrag(Vector3 position)
        {
            Debug.Log("Drag");
        }

        private void OnClickUp(Vector3 position)
        {
            Debug.Log("ClickUp");
        }

        private void OnClickDown(Vector3 position)
        {
            Debug.Log("ClickDown");
        }
    }
}
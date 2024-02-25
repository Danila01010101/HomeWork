using UnityEngine;

namespace Assets.Homework4.Scripts
{
    public class MovementHandler
    {
        private IInput _input;

        public MovementHandler(IInput input)
        {
            _input = input;

            Debug.Log(_input.GetType());
        }
    }
}
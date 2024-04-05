﻿using System;
using UnityEngine;

namespace Assets.Homework4.Scripts
{
    public interface IInput
    {
        public event Action<Vector3> ClickDown;
        public event Action<Vector3> ClickUp;
        public event Action<Vector3> Drag;
        public void Tick();
    }
}
﻿using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehaviour : MonoBehaviour
{
    public UnityEvent MouseDown;
    public UnityEvent MouseUp;

    private void OnMouseDown ()
    {
        MouseDown.Invoke();
    }

    private void OnMouseUp()
    {
        MouseUp.Invoke();
    }
}

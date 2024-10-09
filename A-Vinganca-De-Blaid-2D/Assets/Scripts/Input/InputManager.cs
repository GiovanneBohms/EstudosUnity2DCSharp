using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;

public class InputManager
{
    private PlayerControls playerControls;
    public float Movement => playerControls.Gameplay.Movement.ReadValue<float>();
    public InputManager()
    {
       playerControls = new PlayerControls();
       playerControls.Gameplay.Enable();

    }
}

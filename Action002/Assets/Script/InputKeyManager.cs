using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputKeyManager
{
    public InputAction move;
    public InputAction look;
    public InputAction fire;
    public InputAction jump;

    public InputKeyManager(PlayerInput pInput)
    {
        var actionMap = pInput.currentActionMap;

        move = actionMap["Move"];
        look = actionMap["Look"];
        fire = actionMap["Fire"];
        jump = actionMap["Jump"];
    }
}

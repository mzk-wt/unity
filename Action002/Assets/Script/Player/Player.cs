using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// プレイヤークラス
/// </summary>
public partial class Player : MonoBehaviour
{
    InputKeyManager input;
    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        input = new InputKeyManager(GetComponent<PlayerInput>());
        controller = GetComponent<CharacterController>();

        InitState();
        InitEquipment();
        InitLocomotion();
        InitAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateState();
        UpdateEquipment();
        UpdateLocomotion();
        UpdateAnimation();
    }
}

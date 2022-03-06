using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤークラス（移動関連のパーシャルクラス）
/// </summary>
public partial class Player
{
    Vector3 moveDirection = Vector3.zero;

    void InitLocomotion()
    {
        moveDirection = transform.TransformDirection(moveDirection);
    }

    void UpdateLocomotion()
    {
        // 左右の移動
        if (input.move.IsPressed()) {
            Vector2 move = input.move.ReadValue<Vector2>();
            moveDirection.x = move.x * speed;

        } else {
            moveDirection.x = 0;
        }

        // 上下の移動
        if (input.jump.WasPressedThisFrame() && jumpCount < maxJumpCount) {
            // ジャンプ
            moveDirection.y = jumpForce;
            jumpCount += 1;

        } else {
            if (controller.isGrounded) {
                // ジャンプ回数をリセット
                jumpCount = 0;

            } else {
                // 自由落下
                moveDirection.y -= gravity * Time.deltaTime;
            }
        }

        // 実際に移動
        controller.Move(moveDirection * Time.deltaTime);
    }
}

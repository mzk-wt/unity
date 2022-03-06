using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤークラス（状態管理用のパーシャルクラス）
/// </summary>
public partial class Player
{
    const int STATE_NONE = -1;
    const int STATE_STANDING = 0;
    const int STATE_MOVE_LEFT = 1;
    const int STATE_MOVE_RIGHT = 2;

    int state = STATE_STANDING;
    int enterState = STATE_NONE;
    int exitState = STATE_NONE;

    void InitState()
    {
    }

    void UpdateState()
    {
        int tmpState = STATE_STANDING;
        if (input.move.IsPressed()) {
            Vector2 move = input.move.ReadValue<Vector2>();
            if (move.x > 0) {
                tmpState = STATE_MOVE_RIGHT;
            } else if (move.x < 0) {
                tmpState = STATE_MOVE_LEFT;
            }
        }

        if (state != tmpState) {
            enterState = tmpState;
            exitState = state;
        } else {
            enterState = STATE_NONE;
            exitState = STATE_NONE;
        }

        state = tmpState;
    }
}

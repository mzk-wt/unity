using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤークラス（アニメーション関連のパーシャルクラス）
/// </summary>
public partial class Player
{
    Animation anim;

    void InitAnimation()
    {
        anim = GetComponent<Animation>();
        anim.Play("BoosterRoll01");
    }
    
    void UpdateAnimation()
    {
        // 状態に変化があったときのアニメーション
        if (enterState != STATE_NONE) {
            EnterStateAnimation();
        }
        if (exitState != STATE_NONE) {
            ExitStateAnimation();
        }

        // 状態に応じたアニメーション
        StateAnimation();
    }

    void EnterStateAnimation()
    {
        if (enterState == STATE_MOVE_RIGHT) {
            transform.Rotate(0.0f, 0.0f, -10.0f);

        } else if (enterState == STATE_MOVE_LEFT) {
            transform.Rotate(0.0f, 0.0f, 10.0f);
        }
    }

    void ExitStateAnimation()
    {
        if (exitState == STATE_MOVE_RIGHT) {
            transform.Rotate(0.0f, 0.0f, 10.0f);

        } else if (exitState == STATE_MOVE_LEFT) {
            transform.Rotate(0.0f, 0.0f, -10.0f);
        }
    }

    void StateAnimation()
    {
        // ブースターの色
        GameObject[] boosterEmissions = GameObject.FindGameObjectsWithTag("BoosterEmission");
        foreach (GameObject boosterEmission in boosterEmissions) {
            Material boosterEmissionMaterial = boosterEmission.GetComponent<Renderer>().material;
            if (input.jump.IsPressed()) {
                Debug.Log(boosterEmissionMaterial.name);
                boosterEmissionMaterial.SetColor("_Color", new Color(0.827451f, 0.4196078f, 1.0f, 1.0f));

            } else if (state == STATE_MOVE_RIGHT || state == STATE_MOVE_LEFT) {
                boosterEmissionMaterial.SetColor("_Color", new Color(0.4196078f, 0.827451f, 1.0f, 1.0f));

            } else {
                boosterEmissionMaterial.SetColor("_Color", new Color(0.0f, 0.0f, 0.0f, 0.0f));
            }
        }
    }
}

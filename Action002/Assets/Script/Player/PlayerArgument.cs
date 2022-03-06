using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤークラス（属性用のパーシャルクラス）
/// </summary>
public partial class Player
{
    public Vector3 initPosition;            // 初期ポジション
    public float speed = 6.0f;              // 移動速度
    public float jumpForce = 8.0f;          // ジャンプ力
    public float gravity = 20.0f;           // 重力
    public int maxJumpCount = 0;            // 最大ジャンプ回数
    public int jumpCount = 0;               // ジャンプ回数
    public List<GameObject> equipmentList;     // 装備一覧
}

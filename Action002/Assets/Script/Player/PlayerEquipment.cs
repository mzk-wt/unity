using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤークラス（装備管理用のパーシャルクラス）
/// </summary>
public partial class Player
{
    Dictionary<string, GameObject> equipments = new Dictionary<string, GameObject>();

    void InitEquipment()
    {
        // 登録＆初期化
        foreach (GameObject equip in equipmentList) {
            equip.SetActive(false);
            equipments.Add(equip.name, equip);
        }
    }

    void UpdateEquipment()
    {
        // TODO 装備切り替え
        if (!equipments["Booster"].activeInHierarchy && maxJumpCount > 0) {
            equipments["Booster"].SetActive(true);
        }
    }
}

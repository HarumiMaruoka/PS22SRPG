using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>ステージ上で使うユニットの構造体(仮)</summary>
[System.Serializable]
public struct Unit
{
    public int _num;
    public GameObject _obj;
}

/// <summary>戦闘シーンの便利クラス</summary>
public static class BattleUtility
{
    /// <summary>タイルとユニットを設置する際のオフセット</summary>
    public static readonly (int x, int z) Offset = (-4, 4);


}
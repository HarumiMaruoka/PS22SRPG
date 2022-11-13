using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// このステージで使用するユニットを生成するクラス
/// </summary>
public class UnitGenerator : MonoBehaviour
{
    // そこには何も配置しないを示す数値
    readonly int NonUnit = 0;
    // ステージ上のユニットを設置する高さ
    readonly int UnitPosY = 1;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>初期化</summary>
    public void Init()
    {

    }

    /// <summary>ユニットを生成して配置する</summary>
    public void Generate(int[][] array, Unit[] units)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[0].Length; j++)
            {
                if (array[i][j] == NonUnit) continue;

                // TODO:そのマスに対応するユニットがいるかUnitsの配列内からループで検索しているが
                //      後々ユニット数が増えてくるので辞書型を使用するよう直す
                for (int k = 0; k < units.Length; k++)
                {
                    if (array[i][j] == units[k]._num)
                    {
                        int posX = i + BattleUtility.Offset.x;
                        int posZ = j + BattleUtility.Offset.z;
                        Instantiate(units[k]._obj, new Vector3(posX, UnitPosY, posZ), Quaternion.identity);
                    }
                }
            }
        }
    }
}

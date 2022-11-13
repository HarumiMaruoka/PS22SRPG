using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// 配列を渡すとオブジェクトに変換してステージを作成するクラス
/// </summary>
public class StageGenerator : MonoBehaviour
{
    // TODO:プレイヤーの設置など他でも使う場合は便利クラスを作りそっちに移す
    [System.Serializable]
    public class Tile
    {
        public char _char;
        public GameObject _obj;
    }

    // TODO:プレイヤーの設置など他でも使う場合は便利クラスを作りそっちに移す
    readonly (int x, int z) Offset = (5, 5);
    // ステージ上の障害物を設置する高さ
    readonly int ObstPosY = 1;
    // そこには何も配置しないを示す文字
    readonly char NonTile = '_';

    [Header("文字と対応するプレハブをセット")]
    [SerializeField] Tile[] _tiles;
    [Header("生成したステージのオブジェクトの親")]
    [SerializeField] Transform _parent;

    Dictionary<char, Tile> _dic;

    void Awake()
    {
        _dic = _tiles.ToDictionary(t => t._char, t => t);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>初期化、管理するスクリプトから呼ぶ</summary>
    public void Init()
    {
        // 外部からの参照とか書く
    }

    /// <summary>配列からステージを生成する。ジャグ配列には対応していない</summary>
    public void Generate(char[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[0].Length; j++)
            {
                if (array[i][j] == NonTile) continue;

                if (_dic.TryGetValue(array[i][j], out Tile tile))
                {
                    Instantiate(tile._obj, new Vector3(i + Offset.x, 0, j + Offset.z), Quaternion.identity, _parent);
                }
                else
                {
                    Debug.LogError("<color=red>文字に対応するタイルがありません: </color>" + array[i][j]);
                }
            }
        }
    }

    /// <summary>配列からステージ上の障害物を生成する。ジャグ配列には対応していない</summary>
    public void GenerateObst(char[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[0].Length; j++)
            {
                if (array[i][j] == NonTile) continue;

                if (_dic.TryGetValue(array[i][j], out Tile tile))
                {
                    Instantiate(tile._obj, new Vector3(i + Offset.x, ObstPosY, j + Offset.z), Quaternion.identity, _parent);
                }
                else
                {
                    Debug.LogError("<color=red>文字に対応するタイルがありません: </color>" + array[i][j]);
                }
            }
        }
    }
}

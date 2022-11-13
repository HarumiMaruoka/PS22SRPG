using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// 配列を渡すとオブジェクトに変換してステージを作成する
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
    public void Generate(char[][] str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str[0].Length; j++)
            {
                if (_dic.TryGetValue(str[i][j], out Tile tile))
                {
                    Instantiate(tile._obj, new Vector3(i + Offset.x, 0, j + Offset.z), Quaternion.identity, _parent);
                }
                else
                {
                    Debug.LogError("<color=red>文字に対応するタイルがありません: </color>" + str[i][j]);
                }
            }
        }
    }
}

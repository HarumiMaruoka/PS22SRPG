using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームの流れを管理するクラス
/// </summary>
public class InGameStream : MonoBehaviour
{
    [SerializeField] StageGenerator _stageGenerator;

    // TODO:文字からステージを生成のテスト、テストが終わったら消す
    char[][] array = new char[9][]
{
            new char[]{'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g',},
            new char[]{'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g',},
            new char[]{'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g',},
            new char[]{'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g',},
            new char[]{'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g',},
            new char[]{'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g',},
            new char[]{'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g',},
            new char[]{'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g',},
            new char[]{'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g',},
};

    void Awake()
    {
        // 同じオブジェクト内から各種参照の取得
    }

    void Start()
    {
        Init();
        _stageGenerator.Init();
        _stageGenerator.Generate(array);
    }

    void Update()
    {
        
    }

    /// <summary>シーンの初期化、最初に1度だけ呼ばれる</summary>
    void Init()
    {
        // キャラクター情報の取得
        // キャラクター情報のセット
        // *外部から*ステージを読み込む
        // ステージを画面に反映する
        // 各種UIに情報を反映
    }
}

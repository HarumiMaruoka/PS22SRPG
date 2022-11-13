using UnityEngine;

/// <summary>
/// ゲームの流れを管理するクラス
/// </summary>
public class InGameStream : MonoBehaviour
{
    [SerializeField] MapUI _mapUI;
    [SerializeField] StageGenerator _stageGenerator;
    [SerializeField] UnitGenerator _unitGenerator;

    // TODO:後々適切な場所に移すことを留意しておく
    // このステージで生成するユニットの配列
    [SerializeField] Unit[] _units;

    // TODO:文字からステージを生成のテスト、テストが終わったら消す
    char[][] _tileArray = new char[9][]
    {
            new char[]{'w', 'g', 'g', 'g', 'g', 'g', 'r', 'g', 'g', 'w', },
            new char[]{'w', 'g', 'g', 'r', 'r', 'r', 'r', 'g', 'g', 'w', },
            new char[]{'w', 'g', 'g', 'r', 'g', 'g', 'g', 'g', 'g', 'w', },
            new char[]{'w', 'g', 'g', 'r', 'g', 'g', 'g', 'g', 'g', 'w', },
            new char[]{'w', 'g', 'g', 'r', 'g', 'g', 'g', 'g', 'g', 'w', },
            new char[]{'w', 'g', 'g', 'r', 'r', 'g', 'g', 'g', 'g', 'w', },
            new char[]{'w', 'g', 'g', 'g', 'r', 'g', 'g', 'g', 'g', 'w', },
            new char[]{'w', 'g', 'g', 'g', 'r', 'g', 'g', 'g', 'g', 'w', },
            new char[]{'w', 'g', 'g', 'g', 'r', 'g', 'g', 'g', 'g', 'w', },
    };

    // TODO:文字からステージ上の障害物生成のテスト、テストが終わったら消す
    char[][] _obstArray = new char[9][]
    {
            new char[]{'_', '_', 't', 't', 't', '_', '_', '_', '_', '_', },
            new char[]{'_', '_', '_', 't', 't', '_', '_', '_', '_', '_', },
            new char[]{'_', '_', '_', '_', '_', '_', '_', '_', '_', '_', },
            new char[]{'_', '_', '_', '_', '_', '_', '_', '_', '_', '_', },
            new char[]{'_', '_', '_', '_', '_', '_', '_', 't', 't', '_', },
            new char[]{'_', 't', '_', '_', '_', '_', '_', 't', '_', '_', },
            new char[]{'_', 't', '_', '_', '_', '_', '_', '_', '_', '_', },
            new char[]{'_', '_', '_', '_', '_', '_', 't', '_', '_', '_', },
            new char[]{'_', '_', '_', '_', '_', '_', '_', '_', '_', '_', },
    };

    // TODO:数字からステージ上のユニット生成のテスト、テストが終わったら消す
    int[][] _unitArray = new int[9][]
    {
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,2,0,0,0},
            new int[]{0,0,0,0,1,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
    };

    void Awake()
    {
        // 同じオブジェクト内から各種参照の取得
    }

    void Start()
    {
        Init();
        _mapUI.Init();
        _stageGenerator.Init();
        _stageGenerator.Generate(_tileArray);
        _stageGenerator.GenerateObst(_obstArray);
        _unitGenerator.Init();
        _unitGenerator.Generate(_unitArray, _units);
        // ステージで使用する味方ユニットを生成する
        // ステージに登場する敵ユニットを生成する

    }

    void Update()
    {
        
    }

    /// <summary>シーンの初期化、最初に1度だけ呼ばれる</summary>
    void Init()
    {
        // タイルのデータとキャラクターの配置は同じデータ群に所属しているべき
        // 味方のキャラクターの数は"パーティのデータ"に保持されているはず
        // キャラクターのステータスや名前などのデータは要検討
        // 仮のデータ保持クラスを作って試してみる必要あり。
        // 参照先が変わってもきちんとデータをとってくれば動くように作る。

        // キャラクター情報の取得
        // キャラクター情報のセット
        // *外部から*ステージを読み込む
        // ステージを画面に反映する
        // 各種UIに情報を反映
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ステージの情報を表示するUIを管理するクラス
/// </summary>
public class StageInfoUI : MonoBehaviour
{
    /// <summary>ターン数を表示するテキスト</summary>
    [SerializeField] Text _turnText;
    /// <summary>現在の目標を表示するテキスト</summary>
    [SerializeField] Text _targetText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>初期化</summary>
    public void Init()
    {
        // TODO このステージの目標が渡されてくるのでそれを表示する
        SetTurnText(1);
        SetTargetText("目標", 0,1);
    }

    /// <summary>現在のターンを表示する</summary>
    void SetTurnText(int turn)
    {
        _turnText.text = turn.ToString("00");
    }

    /// <summary>現在の目標を表示する</summary>
    void SetTargetText(string target, int current, int max)
    {
        _targetText.text = $"{target} {current}/{max}";
    }
}

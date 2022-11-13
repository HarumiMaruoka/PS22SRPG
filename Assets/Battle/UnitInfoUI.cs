using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ユニットの情報を表示するUIを管理するクラス
/// </summary>
public class UnitInfoUI : MonoBehaviour
{
    /// <summary>初期化時に子になっているUIを取得して管理するため参照を持っておく</summary>
    [SerializeField] Transform _unitInfoRoot;
    
    UnitInfoView[] _views;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>初期化</summary>
    public void Init()
    {
        // ユニットの数と各ユニットの情報が渡されてくる
        // ユニットの数だけビューを生成し、アイコンと名前をセットする
        _views = _unitInfoRoot.GetComponentsInChildren<UnitInfoView>();
    }

    /// <summary>指定した番号のUIのゲージを更新する</summary>
    public void SetGauge(int index, int current, int max)
    {
        if (index > _views.Length - 1)
        {
            Debug.LogError("<color=red>キャラクターの情報を表示するビューの数より多いです: </color>" + index);
            return;
        }

        _views[index].SetGauge(current, max);
    }
}

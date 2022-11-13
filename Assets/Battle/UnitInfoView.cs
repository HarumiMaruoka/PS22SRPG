using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// マップ画面で各ユニットの情報を表示するUI
/// </summary>
public class UnitInfoView : MonoBehaviour
{
    [SerializeField] Image _icon;
    [SerializeField] Text _nameText;
    [SerializeField] Transform _gauge;

    void Start()
    {
        
    }

    void Update()
    {

    }

    /// <summary>アイコンと名前をセットする</summary>
    public void SetProfile(Sprite icon, string name)
    {
        _icon.sprite = icon;
        _nameText.text = name;
    }

    /// <summary>
    /// 体力ゲージを増減させる
    /// 呼び出す際には体力を0~最大体力にしておくこと
    /// </summary>
    public void SetGauge(int current, int max)
    {
        // TODO: 増減するアニメーションを作る
        _gauge.localScale = new Vector3(1.0f * current / max, 1, 1) ;
    }
}

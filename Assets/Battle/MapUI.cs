using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// マップ画面のUIを管理するクラス
/// </summary>
public class MapUI : MonoBehaviour
{
    [SerializeField] StageInfoUI _stageInfoUI;
    [SerializeField] UnitInfoUI _unitInfoUI;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>初期化</summary>
    public void Init()
    {
        // TODO: このステージの目標、ユニットのデータのリストが渡されてくる
        //       目標はStageInfoに、ユニットのデータはUnitInfoに渡して初期化する
        _stageInfoUI.Init();
        _unitInfoUI.Init();
    }
}

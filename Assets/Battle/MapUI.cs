using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �}�b�v��ʂ�UI���Ǘ�����N���X
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

    /// <summary>������</summary>
    public void Init()
    {
        // TODO: ���̃X�e�[�W�̖ڕW�A���j�b�g�̃f�[�^�̃��X�g���n����Ă���
        //       �ڕW��StageInfo�ɁA���j�b�g�̃f�[�^��UnitInfo�ɓn���ď���������
        _stageInfoUI.Init();
        _unitInfoUI.Init();
    }
}

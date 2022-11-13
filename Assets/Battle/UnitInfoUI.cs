using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���j�b�g�̏���\������UI���Ǘ�����N���X
/// </summary>
public class UnitInfoUI : MonoBehaviour
{
    /// <summary>���������Ɏq�ɂȂ��Ă���UI���擾���ĊǗ����邽�ߎQ�Ƃ������Ă���</summary>
    [SerializeField] Transform _unitInfoRoot;
    
    UnitInfoView[] _views;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>������</summary>
    public void Init()
    {
        // ���j�b�g�̐��Ɗe���j�b�g�̏�񂪓n����Ă���
        // ���j�b�g�̐������r���[�𐶐����A�A�C�R���Ɩ��O���Z�b�g����
        _views = _unitInfoRoot.GetComponentsInChildren<UnitInfoView>();
    }

    /// <summary>�w�肵���ԍ���UI�̃Q�[�W���X�V����</summary>
    public void SetGauge(int index, int current, int max)
    {
        if (index > _views.Length - 1)
        {
            Debug.LogError("<color=red>�L�����N�^�[�̏���\������r���[�̐���葽���ł�: </color>" + index);
            return;
        }

        _views[index].SetGauge(current, max);
    }
}

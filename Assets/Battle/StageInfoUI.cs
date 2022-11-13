using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �X�e�[�W�̏���\������UI���Ǘ�����N���X
/// </summary>
public class StageInfoUI : MonoBehaviour
{
    /// <summary>�^�[������\������e�L�X�g</summary>
    [SerializeField] Text _turnText;
    /// <summary>���݂̖ڕW��\������e�L�X�g</summary>
    [SerializeField] Text _targetText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>������</summary>
    public void Init()
    {
        // TODO ���̃X�e�[�W�̖ڕW���n����Ă���̂ł����\������
        SetTurnText(1);
        SetTargetText("�ڕW", 0,1);
    }

    /// <summary>���݂̃^�[����\������</summary>
    void SetTurnText(int turn)
    {
        _turnText.text = turn.ToString("00");
    }

    /// <summary>���݂̖ڕW��\������</summary>
    void SetTargetText(string target, int current, int max)
    {
        _targetText.text = $"{target} {current}/{max}";
    }
}

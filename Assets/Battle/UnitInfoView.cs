using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �}�b�v��ʂŊe���j�b�g�̏���\������UI
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

    /// <summary>�A�C�R���Ɩ��O���Z�b�g����</summary>
    public void SetProfile(Sprite icon, string name)
    {
        _icon.sprite = icon;
        _nameText.text = name;
    }

    /// <summary>
    /// �̗̓Q�[�W�𑝌�������
    /// �Ăяo���ۂɂ̗͑͂�0~�ő�̗͂ɂ��Ă�������
    /// </summary>
    public void SetGauge(int current, int max)
    {
        // TODO: ��������A�j���[�V���������
        _gauge.localScale = new Vector3(1.0f * current / max, 1, 1) ;
    }
}

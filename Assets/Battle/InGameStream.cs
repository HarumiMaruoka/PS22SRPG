using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �Q�[���̗�����Ǘ�����N���X
/// </summary>
public class InGameStream : MonoBehaviour
{
    [SerializeField] StageGenerator _stageGenerator;

    // TODO:��������X�e�[�W�𐶐��̃e�X�g�A�e�X�g���I����������
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
        // �����I�u�W�F�N�g������e��Q�Ƃ̎擾
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

    /// <summary>�V�[���̏������A�ŏ���1�x�����Ă΂��</summary>
    void Init()
    {
        // �L�����N�^�[���̎擾
        // �L�����N�^�[���̃Z�b�g
        // *�O������*�X�e�[�W��ǂݍ���
        // �X�e�[�W����ʂɔ��f����
        // �e��UI�ɏ��𔽉f
    }
}

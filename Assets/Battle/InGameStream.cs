using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �Q�[���̗�����Ǘ�����N���X
/// </summary>
public class InGameStream : MonoBehaviour
{
    [SerializeField] StageGenerator _stageGenerator;
    [SerializeField] UnitGenerator _unitGenerator;

    // TODO:��������X�e�[�W�𐶐��̃e�X�g�A�e�X�g���I����������
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

    // TODO:��������X�e�[�W��̏�Q�������̃e�X�g�A�e�X�g���I����������
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

    void Awake()
    {
        // �����I�u�W�F�N�g������e��Q�Ƃ̎擾
    }

    void Start()
    {
        Init();
        _stageGenerator.Init();
        _stageGenerator.Generate(_tileArray);
        _stageGenerator.GenerateObst(_obstArray);
        // �X�e�[�W�Ŏg�p���閡�����j�b�g�𐶐�����
        // �X�e�[�W�ɓo�ꂷ��G���j�b�g�𐶐�����

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

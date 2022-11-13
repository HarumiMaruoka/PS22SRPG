using UnityEngine;

/// <summary>
/// �Q�[���̗�����Ǘ�����N���X
/// </summary>
public class InGameStream : MonoBehaviour
{
    [SerializeField] MapUI _mapUI;
    [SerializeField] StageGenerator _stageGenerator;
    [SerializeField] UnitGenerator _unitGenerator;

    // TODO:��X�K�؂ȏꏊ�Ɉڂ����Ƃ𗯈ӂ��Ă���
    // ���̃X�e�[�W�Ő������郆�j�b�g�̔z��
    [SerializeField] Unit[] _units;

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

    // TODO:��������X�e�[�W��̃��j�b�g�����̃e�X�g�A�e�X�g���I����������
    int[][] _unitArray = new int[9][]
    {
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,2,0,0,0},
            new int[]{0,0,0,0,1,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
            new int[]{0,0,0,0,0,0,0,0,0,0},
    };

    void Awake()
    {
        // �����I�u�W�F�N�g������e��Q�Ƃ̎擾
    }

    void Start()
    {
        Init();
        _mapUI.Init();
        _stageGenerator.Init();
        _stageGenerator.Generate(_tileArray);
        _stageGenerator.GenerateObst(_obstArray);
        _unitGenerator.Init();
        _unitGenerator.Generate(_unitArray, _units);
        // �X�e�[�W�Ŏg�p���閡�����j�b�g�𐶐�����
        // �X�e�[�W�ɓo�ꂷ��G���j�b�g�𐶐�����

    }

    void Update()
    {
        
    }

    /// <summary>�V�[���̏������A�ŏ���1�x�����Ă΂��</summary>
    void Init()
    {
        // �^�C���̃f�[�^�ƃL�����N�^�[�̔z�u�͓����f�[�^�Q�ɏ������Ă���ׂ�
        // �����̃L�����N�^�[�̐���"�p�[�e�B�̃f�[�^"�ɕێ�����Ă���͂�
        // �L�����N�^�[�̃X�e�[�^�X�▼�O�Ȃǂ̃f�[�^�͗v����
        // ���̃f�[�^�ێ��N���X������Ď����Ă݂�K�v����B
        // �Q�Ɛ悪�ς���Ă�������ƃf�[�^���Ƃ��Ă���Γ����悤�ɍ��B

        // �L�����N�^�[���̎擾
        // �L�����N�^�[���̃Z�b�g
        // *�O������*�X�e�[�W��ǂݍ���
        // �X�e�[�W����ʂɔ��f����
        // �e��UI�ɏ��𔽉f
    }
}

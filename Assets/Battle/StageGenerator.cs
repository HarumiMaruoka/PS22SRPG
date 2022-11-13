using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// �z���n���ƃI�u�W�F�N�g�ɕϊ����ăX�e�[�W���쐬����N���X
/// </summary>
public class StageGenerator : MonoBehaviour
{
    // TODO:�v���C���[�̐ݒu�ȂǑ��ł��g���ꍇ�͕֗��N���X����肻�����Ɉڂ�
    [System.Serializable]
    public struct Tile
    {
        public char _char;
        public GameObject _obj;
    }

    // �X�e�[�W��̏�Q����ݒu���鍂��
    readonly int ObstPosY = 1;
    // �����ɂ͉����z�u���Ȃ�����������
    readonly char NonTile = '_';

    [Header("�����ƑΉ�����v���n�u���Z�b�g")]
    [SerializeField] Tile[] _tiles;
    [Header("���������X�e�[�W�̃I�u�W�F�N�g�̐e")]
    [SerializeField] Transform _parent;

    Dictionary<char, Tile> _dic;

    void Awake()
    {
        _dic = _tiles.ToDictionary(t => t._char, t => t);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>�������A�Ǘ�����X�N���v�g����Ă�</summary>
    public void Init()
    {
        // �O������̎Q�ƂƂ�����
    }

    /// <summary>�z�񂩂�X�e�[�W�𐶐�����B�W���O�z��ɂ͑Ή����Ă��Ȃ�</summary>
    public void Generate(char[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[0].Length; j++)
            {
                if (array[i][j] == NonTile) continue;

                if (_dic.TryGetValue(array[i][j], out Tile tile))
                {
                    int posX = i + BattleUtility.Offset.x;
                    int posZ = j + BattleUtility.Offset.z;
                    Instantiate(tile._obj, new Vector3(posX, 0, posZ), Quaternion.identity, _parent);
                }
                else
                {
                    Debug.LogError("<color=red>�����ɑΉ�����^�C��������܂���: </color>" + array[i][j]);
                }
            }
        }
    }

    /// <summary>�z�񂩂�X�e�[�W��̏�Q���𐶐�����B�W���O�z��ɂ͑Ή����Ă��Ȃ�</summary>
    public void GenerateObst(char[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[0].Length; j++)
            {
                if (array[i][j] == NonTile) continue;

                if (_dic.TryGetValue(array[i][j], out Tile tile))
                {
                    int posX = i + BattleUtility.Offset.x;
                    int posZ = j + BattleUtility.Offset.z;
                    Instantiate(tile._obj, new Vector3(posX, ObstPosY, posZ), Quaternion.identity, _parent);
                }
                else
                {
                    Debug.LogError("<color=red>�����ɑΉ�����^�C��������܂���: </color>" + array[i][j]);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// �z���n���ƃI�u�W�F�N�g�ɕϊ����ăX�e�[�W���쐬����
/// </summary>
public class StageGenerator : MonoBehaviour
{
    // TODO:�v���C���[�̐ݒu�ȂǑ��ł��g���ꍇ�͕֗��N���X����肻�����Ɉڂ�
    [System.Serializable]
    public class Tile
    {
        public char _char;
        public GameObject _obj;
    }

    // TODO:�v���C���[�̐ݒu�ȂǑ��ł��g���ꍇ�͕֗��N���X����肻�����Ɉڂ�
    readonly (int x, int z) Offset = (5, 5);

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
    public void Generate(char[][] str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str[0].Length; j++)
            {
                if (_dic.TryGetValue(str[i][j], out Tile tile))
                {
                    Instantiate(tile._obj, new Vector3(i + Offset.x, 0, j + Offset.z), Quaternion.identity, _parent);
                }
                else
                {
                    Debug.LogError("<color=red>�����ɑΉ�����^�C��������܂���: </color>" + str[i][j]);
                }
            }
        }
    }
}

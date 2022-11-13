using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���̃X�e�[�W�Ŏg�p���郆�j�b�g�𐶐�����N���X
/// </summary>
public class UnitGenerator : MonoBehaviour
{
    // �����ɂ͉����z�u���Ȃ����������l
    readonly int NonUnit = 0;
    // �X�e�[�W��̃��j�b�g��ݒu���鍂��
    readonly int UnitPosY = 1;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>������</summary>
    public void Init()
    {

    }

    /// <summary>���j�b�g�𐶐����Ĕz�u����</summary>
    public void Generate(int[][] array, Unit[] units)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[0].Length; j++)
            {
                if (array[i][j] == NonUnit) continue;

                // TODO:���̃}�X�ɑΉ����郆�j�b�g�����邩Units�̔z������烋�[�v�Ō������Ă��邪
                //      ��X���j�b�g���������Ă���̂Ŏ����^���g�p����悤����
                for (int k = 0; k < units.Length; k++)
                {
                    if (array[i][j] == units[k]._num)
                    {
                        int posX = i + BattleUtility.Offset.x;
                        int posZ = j + BattleUtility.Offset.z;
                        Instantiate(units[k]._obj, new Vector3(posX, UnitPosY, posZ), Quaternion.identity);
                    }
                }
            }
        }
    }
}

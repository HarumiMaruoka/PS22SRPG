using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�X�e�[�W��Ŏg�����j�b�g�̍\����(��)</summary>
[System.Serializable]
public struct Unit
{
    public int _num;
    public GameObject _obj;
}

/// <summary>�퓬�V�[���֗̕��N���X</summary>
public static class BattleUtility
{
    /// <summary>�^�C���ƃ��j�b�g��ݒu����ۂ̃I�t�Z�b�g</summary>
    public static readonly (int x, int z) Offset = (-4, 4);


}
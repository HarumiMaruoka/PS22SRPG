using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//[System.Serializable]
public class CsvReader : MonoBehaviour
{
    [SerializeField] TextAsset _textAsset;
    private List<TalkData> _talkDatas = new List<TalkData>();

    public void Init() 
    {
        StringReader sr = new StringReader(_textAsset.text);
        //最初の行はスキップ
        sr.ReadLine();

        while (true)
        {
            string line = sr.ReadLine();

            if (string.IsNullOrEmpty(line))
            {
                break;
            }

            string[] parts = line.Split(',');

            _talkDatas.Add(new TalkData(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]));
        }
    }
}

public struct TalkData 
{
    private string _name;
    private string _charaMove;
    private string _talk;
    private string _bgm;
    private string _se;
    private string _event; 

    public TalkData(string name, string charamove, string talk, string bgm, string se, string eventSt)
    {
        _name = name;
        _charaMove = charamove;
        _talk = talk;
        _bgm = bgm;
        _se = se;
        _event = eventSt;
    }
}

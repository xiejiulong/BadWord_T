/*************************************************************************************
 * CLR version      : version 5.6.2f1
 * TargetFW Version : 5.0
 * Class Name       :
 * Machine Name     : SC-201609201141 Hp Win7
 * Name Space       :
 * File Name        :
 * Create Date      : 2018/01/16 14:01:32
 * Author           : XieJiulong
 *
 * Modify Date      :
 * Author           :
 * Description      : 客户端 关键字 过滤助手函数
 *************************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HelperWordFilter
{
    private static List<Word> m_listBadWords = new List<Word>();
    private static string     strPathBadWords = "BadWords";         // 实际路径 ：\Resources\BadWords.json
    private static string     strReplace = "*";                     // 要替换的字符
    private static bool       m_bInit = false;

    // 获取过滤过的字符串
    public static string Filter(string strOri)
    {
        string strRet = strOri;

        Init();

        for (int i = 0; i < m_listBadWords.Count; i++)
        {
            strRet = strRet.Replace(m_listBadWords[i].word, strReplace);
        }

        Debug.Log(strRet);
        return strRet;
    }

    #region Inner

    [Serializable]
    private class BadWordsJson
    {
        public List<Word> wordList;
    }

    [Serializable]
    public class Word : ISerializationCallbackReceiver
    {
        public string word;

        // 反序列化   从文本信息 到对象
        public void OnAfterDeserialize()
        {
        }

        public void OnBeforeSerialize()
        {
        }
    }

    private static void Init()
    {
        if (m_bInit)
            return;

        if (m_listBadWords == null)
        {
            m_listBadWords = new List<Word>();
        }

        // 加载过滤字
        if (m_listBadWords.Count == 0)
        {
            TextAsset ta = Resources.Load<TextAsset>(strPathBadWords);
            BadWordsJson json = JsonUtility.FromJson<BadWordsJson>(ta.text);
            m_listBadWords = json.wordList;
        }

        m_bInit = true;
    }

    #endregion
}

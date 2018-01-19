/*************************************************************************************
 * CLR version      : version 5.6.2f1
 * TargetFW Version : 5.0
 * Class Name       :
 * Machine Name     : SC-201609201141 Hp Win7
 * Name Space       :
 * File Name        :
 * Create Date      : 2017/06/09 14:01:32
 * Author           : XieJiulong
 *
 * Modify Date      :
 * Author           :
 * Description      :
 *************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFilter : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        HelperWordFilter.Filter("我日共你党共产日本党我草 你好 我草 ");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
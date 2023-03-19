using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTest : MonoBehaviour
{
    //ֻ��ί���޷���ֵ�ķ��� 0-16������
    public Action<int> ActionTest1;
    void Start()
    {
        ActionTest1 += CallbackTest1;
        ActionTest1 += CallbackTest2;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ActionTest1(1);
        }
    }

    public void CallbackTest1(int i)
    {
        Debug.Log("Action����A" + i);
    }

    public void CallbackTest2(int i)
    {
        Debug.Log("Action����B" + i);
    }
}

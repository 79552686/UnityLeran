using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FuncTest : MonoBehaviour
{
    public Func<string> MyTestFunc1;
    //������0-16
    public Func<int, string> MyTestFunc2;
    // Start is called before the first frame update
    void Start()
    {
        MyTestFunc1 = CallbackFunc1;
        MyTestFunc2 = CallbackFunc2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(MyTestFunc1());
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(MyTestFunc2(2));
        }
    }

    public string CallbackFunc1()
    {
        return "����1";
    }

    public string CallbackFunc2(int num)
    {
        //�޲δ�����ֵ��Funcί�� 1
        return "���� " + num;
    }
}

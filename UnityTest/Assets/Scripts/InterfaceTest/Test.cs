using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour,ITest
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            MethodName();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Change();
        }
    }
    public void MethodName()
    {
        Debug.Log("����");
    }

    public void Change()
    {
        Debug.Log("�ı�");
    }

}

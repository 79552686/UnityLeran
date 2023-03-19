using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour, ITest
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            MethodName();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Change();
        }
    }

    public void Change()
    {
        Debug.Log("Test2 Change");
    }

    public void MethodName()
    {
        Debug.Log("Test2 MethodName");
    }
}

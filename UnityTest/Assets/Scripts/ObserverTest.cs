using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 事件委托观察者
/// </summary>

// 事件是特殊委托
public class ObserverTest : MonoBehaviour
{
    //delegate 标准委托
    public delegate void myDelegate(int num);
    public myDelegate m_delegate;
    //event 标准事件 
    //主要区别：
    //1.事件不能再外部使用赋值=符号，只能使用+ - 委托 哪里都能用
    //2.事件 不能再外部执行 只能在类内部分装调用 且不能作为临时变量 委托哪里都能执行
    //3.事件 不能作为 函数中的临时变量的 委托可以
    //1.防止外部随意置空委托
    //2.防止外部随意调用委托
    //3.事件相当于对委托进行了一次封装 让其更加安全
    public event myDelegate m_event;
    //EventHandler
    //这是它的定义
    //@sender: 引发事件的对象
    //@e: 传递的参数
    //自定义委托类型为EventHandler
    public event EventHandler m_EventHandle;
    //Action
    //Action是系统预定义的一种委托，无返回值，参数在<>中传入
    //1，Action省略了void，因为它本身就是无返回值
    //2, Action的参数在<>中定义的，delegate就是传统定义
    //3，delegate要用关键字，然后自定义一个委托名字。而Action委托名字已定。不需要delegate关键字
    public Action<int> m_action;

    void Start()
    {
        Test1();
    }
    public void Test1()
    {
        //delegate
        m_delegate += MyEventFun;
        m_delegate(1);
        m_delegate = (d) => { Debug.Log("m_delegate : " + d); };
        m_delegate(1);
        //event
        m_event = MyEventFun;
        m_event(2);
        m_event = (d) => { Debug.Log("m_event : " + d); };
        m_event(2);
        //EventHandler
        m_EventHandle += MyEventFun;
        m_EventHandle(3, new EventArgs());
        m_EventHandle += (o, e) => { Debug.Log("m_EventHandle: " + Convert.ToInt32(o) + "\t " + e.ToString()); };
        m_EventHandle(3, new EventArgs());
        //Action
        m_action += MyEventFun;
        m_action(4);
        m_action = (d) => { Debug.Log("m_action : " + d); };
        m_action(4);
    }

    public void MyEventFun(int num)
    {
        Debug.Log("my func1: " + num);
    }

    public void MyEventFun(object sender, EventArgs e)
    {
        Debug.Log("my func2: " + Convert.ToInt32(sender) + "\t " + e.ToString());
    }

}
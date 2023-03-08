using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �¼�ί�й۲���
/// </summary>

// �¼�������ί��
public class ObserverTest : MonoBehaviour
{
    //delegate ��׼ί��
    public delegate void myDelegate(int num);
    public myDelegate m_delegate;
    //event ��׼�¼� 
    //��Ҫ����
    //1.�¼��������ⲿʹ�ø�ֵ=���ţ�ֻ��ʹ��+ - ί�� ���ﶼ����
    //2.�¼� �������ⲿִ�� ֻ�������ڲ���װ���� �Ҳ�����Ϊ��ʱ���� ί�����ﶼ��ִ��
    //3.�¼� ������Ϊ �����е���ʱ������ ί�п���
    //1.��ֹ�ⲿ�����ÿ�ί��
    //2.��ֹ�ⲿ�������ί��
    //3.�¼��൱�ڶ�ί�н�����һ�η�װ ������Ӱ�ȫ
    public event myDelegate m_event;
    //EventHandler
    //�������Ķ���
    //@sender: �����¼��Ķ���
    //@e: ���ݵĲ���
    //�Զ���ί������ΪEventHandler
    public event EventHandler m_EventHandle;
    //Action
    //Action��ϵͳԤ�����һ��ί�У��޷���ֵ��������<>�д���
    //1��Actionʡ����void����Ϊ����������޷���ֵ
    //2, Action�Ĳ�����<>�ж���ģ�delegate���Ǵ�ͳ����
    //3��delegateҪ�ùؼ��֣�Ȼ���Զ���һ��ί�����֡���Actionί�������Ѷ�������Ҫdelegate�ؼ���
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
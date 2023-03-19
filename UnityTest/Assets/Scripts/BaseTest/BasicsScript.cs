using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicsScript : MonoBehaviour
{
    //Array ��������
    public String[] array = new String[3];
    //ArrayList ����Ҫ�������� ��̬����
    public ArrayList aList = new ArrayList();
    //List ���ͼ��� ���Դ���class 
    public List<Person> List = new List<Person>();
    //LinkedList< T > ������ ������û�зǷ�����İ汾������һ��˫����������Ԫ��ָ��Ԫ�ص�ǰһ�����һ��Ԫ��
    LinkedList<int> list = new LinkedList<int>();
    //HashTable ��ϣ����ͨ��key-value����ʽ����ȡ���ݵ�
    Hashtable table = new Hashtable();
    //Dictionary< T > ��Ȼ���з��͵�HashTable����Dictionary
    Dictionary<string, Person> dictionary = new Dictionary<string, Person>();
    //HashSet<T> HashSet���ص㣺һ�鲻�����ظ�Ԫ�صļ���
    HashSet<string> set = new HashSet<string>();
    //Queue ���У�Queue��������һ���Ƚ��ȳ��Ķ��󼯺ϡ�  ���䷺�Ͷ���
    //������Ҫ�Ը�������Ƚ��ȳ��ķ���ʱ��
    //��ʹ�ö��С��������б������һ���Ϊ��ӣ��������б����Ƴ�һ��ʱ����Ϊ���ӡ�
    Queue q = new Queue();
    //Stack ��ջ��Stack��������һ������ȳ��Ķ��󼯺ϡ�  ���䷺�Ͷ�ջ
    //������Ҫ�Ը�����к���ȳ��ķ���ʱ����ʹ�ö�ջ���������б������һ�
    //��Ϊ����Ԫ�أ��������б����Ƴ�һ��ʱ����Ϊ����Ԫ�ء�
    Stack st = new Stack();
    void Start()
    {

    }

    public void ArrayTest()
    {
        array[0] = "����";
        array[1] = "1";
        array[2] = "��Ӿ";

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("��������" + array[i]);
        }
    }

    public void ArrayListTest()
    {
        aList.Add("����");
        aList.Add(123);
        aList.Add(123.2);

        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log("������������" + aList[i]);
        }
    }

    public void ListTest()
    {
        Person person1 = new Person() { name = "����", age = 20 };
        Person person2 = new Person() { name = "����", age = 21 };
        List.Add(person1);
        List.Add(person2);

        foreach (Person p in List)
        {
            Debug.Log("����List����" + p.ToString());
        }
    }

    public void HashtableTest()
    {
        table.Add("����", "����");
        table.Add("����", 10);
        Debug.Log("��ϣ������" + table["����"] + table["����"]);
        //Ҳ���Ա���
        foreach (DictionaryEntry entry in table)
        {
            Debug.Log("��ϣ������" + entry.Key + ":" + entry.Value);
        }
    }

    public void DictionaryTest()
    {
        Person person1 = new Person() { name = "����", age = 20};
        Person person2 = new Person() { name = "����", age = 21};
        dictionary.Add("ѧ��1", person1);
        dictionary.Add("ѧ��2", person2);
        //ȡȫ���ֵ�
        foreach (KeyValuePair<string, Person> pair in dictionary)
        {
            Debug.Log("��ӡ�ֵ�����" + pair.Key + "��" + pair.Value.ToString());
        }
        //ȡkey
        foreach (string key in dictionary.Keys)
        {
            Debug.Log("��ӡ�ֵ�Key����" + key);
        }
        //ȡvalue
        foreach (Person person in dictionary.Values)
        {
            Debug.Log("��ӡ�ֵ�Value����" + person.ToString());
        }
    }

    public void HashSetTest()
    {
        set.Add("�ϻ�");
        set.Add("ʨ��");
        set.Add("С��");
        set.Add("Сè");
        set.Add("С��");

        foreach (var n in set)
        {
            Debug.Log("��ӡHashSet����" + n);
        }
    }

    // ����ȫ
}

public class Person
{
    public string name;
    public int age;
}


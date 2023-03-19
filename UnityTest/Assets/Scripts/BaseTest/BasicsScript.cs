using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicsScript : MonoBehaviour
{
    //Array 基础数组
    public String[] array = new String[3];
    //ArrayList 不需要申明长度 动态增加
    public ArrayList aList = new ArrayList();
    //List 泛型集合 可以储存class 
    public List<Person> List = new List<Person>();
    //LinkedList< T > 代掌握 集合类没有非泛型类的版本，它是一个双向链表，它的元素指向元素的前一个与后一个元素
    LinkedList<int> list = new LinkedList<int>();
    //HashTable 哈希表是通过key-value的形式来存取数据的
    Hashtable table = new Hashtable();
    //Dictionary< T > 当然还有泛型的HashTable，即Dictionary
    Dictionary<string, Person> dictionary = new Dictionary<string, Person>();
    //HashSet<T> HashSet的特点：一组不包含重复元素的集合
    HashSet<string> set = new HashSet<string>();
    //Queue 队列（Queue）代表了一个先进先出的对象集合。  补充泛型队列
    //当您需要对各项进行先进先出的访问时，
    //则使用队列。当您在列表中添加一项，称为入队，当您从列表中移除一项时，称为出队。
    Queue q = new Queue();
    //Stack 堆栈（Stack）代表了一个后进先出的对象集合。  补充泛型堆栈
    //当您需要对各项进行后进先出的访问时，则使用堆栈。当您在列表中添加一项，
    //称为推入元素，当您从列表中移除一项时，称为弹出元素。
    Stack st = new Stack();
    void Start()
    {

    }

    public void ArrayTest()
    {
        array[0] = "张三";
        array[1] = "1";
        array[2] = "游泳";

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("数组内容" + array[i]);
        }
    }

    public void ArrayListTest()
    {
        aList.Add("张三");
        aList.Add(123);
        aList.Add(123.2);

        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log("泛型数组内容" + aList[i]);
        }
    }

    public void ListTest()
    {
        Person person1 = new Person() { name = "张三", age = 20 };
        Person person2 = new Person() { name = "李四", age = 21 };
        List.Add(person1);
        List.Add(person2);

        foreach (Person p in List)
        {
            Debug.Log("泛型List内容" + p.ToString());
        }
    }

    public void HashtableTest()
    {
        table.Add("名字", "张三");
        table.Add("年龄", 10);
        Debug.Log("哈希表内容" + table["名字"] + table["年龄"]);
        //也可以遍历
        foreach (DictionaryEntry entry in table)
        {
            Debug.Log("哈希表内容" + entry.Key + ":" + entry.Value);
        }
    }

    public void DictionaryTest()
    {
        Person person1 = new Person() { name = "张三", age = 20};
        Person person2 = new Person() { name = "李四", age = 21};
        dictionary.Add("学生1", person1);
        dictionary.Add("学生2", person2);
        //取全部字典
        foreach (KeyValuePair<string, Person> pair in dictionary)
        {
            Debug.Log("打印字典内容" + pair.Key + "：" + pair.Value.ToString());
        }
        //取key
        foreach (string key in dictionary.Keys)
        {
            Debug.Log("打印字典Key内容" + key);
        }
        //取value
        foreach (Person person in dictionary.Values)
        {
            Debug.Log("打印字典Value内容" + person.ToString());
        }
    }

    public void HashSetTest()
    {
        set.Add("老虎");
        set.Add("狮子");
        set.Add("小狗");
        set.Add("小猫");
        set.Add("小狗");

        foreach (var n in set)
        {
            Debug.Log("打印HashSet内容" + n);
        }
    }

    // 待补全
}

public class Person
{
    public string name;
    public int age;
}


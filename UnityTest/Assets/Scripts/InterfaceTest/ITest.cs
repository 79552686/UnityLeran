using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Tip:需要改变其他对象的状态或者数据时，
/// 不使用接口的话一般就是创建新的变量
/// 然后获取目标对应脚本组件再把变量的值赋值过去，
/// 这样写会很不方便，并且可能存在大量隐性bug。
/// </summary>
public interface ITest
{
    void MethodName();
    void Change();
}

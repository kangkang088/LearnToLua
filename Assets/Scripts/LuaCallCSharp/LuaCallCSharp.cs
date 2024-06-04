using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using System;
using UnityEngine.Events;

#region Lesson1_CallClass
public class Test
{
    public void Speak(string str)
    {
        Debug.Log("Test:" + str);
    }
}
namespace MrKang
{
    public class Test2
    {
        public void Speak(string str)
        {
            Debug.Log("Test2:" + str);
        }
    }
}
#endregion

#region Lesson1_CallEnum
public enum E_MyEnum
{
    Idle, Move, Atk
}
#endregion

#region Lesson3_CallArrayListDictionary
public class Lesson3
{
    public int[] array = new int[5] { 1, 2, 3, 4, 5 };
    public List<int> list = new List<int>();
    public Dictionary<int, string> dic = new Dictionary<int, string>();
}
#endregion

#region Lesson4_CallExtensionFunction
public class Lesson4
{
    public string name = "kangkang";
    public void Speak(string str)
    {
        Debug.Log(str);
    }
    public static void Eat()
    {
        Debug.Log("吃东西");
    }
}
public static class Tools
{
    public static void Move(this Lesson4 obj)
    {
        Debug.Log(obj.name);
    }
}
#endregion

#region Lesson5_CallRefOut
public class Lesson5
{
    public int RefFun(int a, ref int b, ref int c, int d)
    {
        b = a + d;
        c = a - d;
        return 100;
    }
    public int OutFun(int a, out int b, out int c, int d)
    {
        b = a;
        c = d;
        return 200;
    }
    public int RefOutFun(int a, out int b, ref int c)
    {
        b = a * 10;
        c = a * 20;
        return 300;
    }
}
#endregion

#region Lesson6_CallOverrideFunction
public class Lesson6
{
    public int Calc()
    {
        return 100;
    }
    public int Calc(int a)
    {
        Debug.Log("int");
        return a;
    }
    public float Calc(float a)
    {
        Debug.Log("Float");
        return a;
    }
    public string Calc(string a)
    {
        Debug.Log("String");
        return a;
    }
    public int Calc(int a, int b)
    {
        return a + b;
    }
    public int Calc(int a, out int b)
    {
        b = 10;
        return a + b;
    }
}
#endregion

#region Lesson7_CallDelegateEvent
public class Lesson7
{
    public UnityAction del;
    public void DoDel()
    {
        if (del != null)
            del();
    }
    
    public event UnityAction eventAction;
    public void DoEvent()
    {
        if (eventAction != null)
            eventAction();
    }
    public void ClearEvent()
    {
        Debug.Log("清空完成");
        eventAction = null;
    }
}
#endregion
public class LuaCallCSharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

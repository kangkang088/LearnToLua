using System;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;
using UnityEngine.Events;

public delegate int CustomCallOut(int a, out int b, out bool c, out string d, out int e);
public delegate int CustomCallRef(int a, ref int b, ref bool c, ref string d, ref int e);
public delegate void CustomCallParams(int a, params object[] objects);
public class Lesson5_CallFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().Require("Main");

        #region 无参无返回值
        LuaFunction luaFunction = LuaMgr.GetInstance().LuaState.GetFunction("testFun");
        luaFunction.Call();
        luaFunction.Dispose();

        luaFunction = LuaMgr.GetInstance().LuaState["testFun"] as LuaFunction;
        luaFunction.Call();
        luaFunction.Dispose();

        luaFunction = LuaMgr.GetInstance().LuaState.GetFunction("testFun");
        UnityAction action = luaFunction.ToDelegate<UnityAction>();
        action();
        luaFunction.Dispose();
        #endregion
        #region 有参有返回值
        luaFunction = LuaMgr.GetInstance().LuaState.GetFunction("testFun2");
        luaFunction.BeginPCall();
        luaFunction.Push(99);
        luaFunction.PCall();
        int number = Convert.ToInt32(luaFunction.CheckNumber());
        luaFunction.EndPCall();
        Debug.Log(number);

        number = luaFunction.Invoke<int, int>(199);
        Debug.Log(number);

        Func<int, int> func = luaFunction.ToDelegate<Func<int, int>>();
        number = func(900);
        Debug.Log(number);

        number = LuaMgr.GetInstance().LuaState.Invoke<int, int>("testFun2", 800, true);
        Debug.Log(number);
        #endregion
        #region 多返回值
        luaFunction = LuaMgr.GetInstance().LuaState.GetFunction("testFun3");
        //开始调用
        luaFunction.BeginPCall();
        //传参
        luaFunction.Push(1000);
        //调用
        luaFunction.PCall();
        //得到返回值
        int a1 = (int)luaFunction.CheckNumber();
        int b1 = (int)luaFunction.CheckNumber();
        bool c1 = luaFunction.CheckBoolean();
        string d1 = luaFunction.CheckString();
        int e1 = (int)luaFunction.CheckNumber();
        luaFunction.EndPCall();
        Debug.Log("第一个返回值：" + a1);
        Debug.Log(b1 + "_" + c1 + "_" + d1 + "_" + e1);

        CustomCallOut callOut = luaFunction.ToDelegate<CustomCallOut>();
        number = callOut(999, out int b2, out bool c2, out string d2, out int e2);
        Debug.Log("out第一个返回值：" + number);
        Debug.Log(b2 + "_" + c2 + "_" + d2 + "_" + e2);

        #endregion
        #region 变长参数
        luaFunction = LuaMgr.GetInstance().LuaState.GetFunction("testFun4");
        CustomCallParams callParams = luaFunction.ToDelegate<CustomCallParams>();
        callParams(100, 1, true, "123", 0, false);

        luaFunction.Call<int, int, bool, string, int>(100,10,true,"123",0);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEditor;
using UnityEngine;

public class Lesson2_Loader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        new LuaCustomLoader();
        LuaState luaState = new LuaState();
        luaState.Start();
        //luaState.AddSearchPath(Application.dataPath + "/MyLua");
        luaState.Require("CSharpCallLua/Lesson2_Loader");
        // luaState.AddSearchPath(Application.dataPath + "/Lua/CSharpCallLua");
        // luaState.Require("Lesson2_Loader");
        //luaState.Require("CSharpCallLua/Lesson2_Loader");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

public class Lesson1_LuaState : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaState luaState = new LuaState();
        luaState.Start();
        luaState.DoString("print('Lua Code')", "Lesson1_LuaState");
        //luaState.DoFile("Main.lua");
        luaState.Require("Main");

        luaState.CheckTop();
        luaState.Dispose();
        luaState = null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

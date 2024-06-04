using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

/// <summary>
/// lua解析器管理器，要继承Mono单例，之后要使用相关特性
/// </summary>
public class LuaMgr : SingletonAutoMono<LuaMgr>
{
    private LuaState luaState;
    public LuaState LuaState
    {
        get
        {
            return luaState;
        }
    }
    public void Init()
    {
        //new LuaCustomLoader();
        luaState = new LuaState();
        luaState.Start();
        DelegateFactory.Init();
        LuaLooper loop = this.gameObject.AddComponent<LuaLooper>();
        loop.luaState = this.luaState;

        LuaCoroutine.Register(this.luaState, this);

        LuaBinder.Bind(luaState);
    }
    public void DoString(string str, string chunkName = "LuaMgr.cs")
    {
        luaState.DoString(str, chunkName);
    }
    public void Require(string fileName)
    {
        luaState.Require(fileName);
    }
    public void Dispose()
    {
        if (luaState == null)
            return;
        luaState.CheckTop();
        luaState.Dispose();
        luaState = null;
    }
}

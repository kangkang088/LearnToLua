﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MrKang_Test2Wrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MrKang.Test2), typeof(System.Object));
		L.RegFunction("Speak", Speak);
		L.RegFunction("New", _CreateMrKang_Test2);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMrKang_Test2(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MrKang.Test2 obj = new MrKang.Test2();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MrKang.Test2.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Speak(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MrKang.Test2 obj = (MrKang.Test2)ToLua.CheckObject<MrKang.Test2>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.Speak(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}


﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Lesson5Wrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Lesson5), typeof(System.Object));
		L.RegFunction("RefFun", RefFun);
		L.RegFunction("OutFun", OutFun);
		L.RegFunction("RefOutFun", RefOutFun);
		L.RegFunction("New", _CreateLesson5);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLesson5(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Lesson5 obj = new Lesson5();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Lesson5.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefFun(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			Lesson5 obj = (Lesson5)ToLua.CheckObject<Lesson5>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
			int o = obj.RefFun(arg0, ref arg1, ref arg2, arg3);
			LuaDLL.lua_pushinteger(L, o);
			LuaDLL.lua_pushinteger(L, arg1);
			LuaDLL.lua_pushinteger(L, arg2);
			return 3;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OutFun(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			Lesson5 obj = (Lesson5)ToLua.CheckObject<Lesson5>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1;
			int arg2;
			int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
			int o = obj.OutFun(arg0, out arg1, out arg2, arg3);
			LuaDLL.lua_pushinteger(L, o);
			LuaDLL.lua_pushinteger(L, arg1);
			LuaDLL.lua_pushinteger(L, arg2);
			return 3;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefOutFun(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Lesson5 obj = (Lesson5)ToLua.CheckObject<Lesson5>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1;
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			int o = obj.RefOutFun(arg0, out arg1, ref arg2);
			LuaDLL.lua_pushinteger(L, o);
			LuaDLL.lua_pushinteger(L, arg1);
			LuaDLL.lua_pushinteger(L, arg2);
			return 3;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}


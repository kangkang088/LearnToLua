print("*********************tolua访问C#的类************************")

local obj1 = UnityEngine.GameObject()
local obj2 = UnityEngine.GameObject("Test")

GameObject = UnityEngine.GameObject

local obj3 = GameObject("kangkang")

local obj4 = GameObject.Find("Test")

print(obj4.transform.position.x)

Debug = UnityEngine.Debug

Debug.Log(obj4.transform.position.x)

Vector3 = UnityEngine.Vector3

obj4.transform:Translate(Vector3.right)
Debug.Log(obj4.transform.position.x)

local obj5 = GameObject("加脚本测试")
--LuaCallCSharp，自定义类，Lua不认识
obj5:AddComponent(typeof(LuaCallCSharp))

local t1 = Test()
t1:Speak("t1说话")

local t2 = MrKang.Test2()
t2:Speak("t2说话")

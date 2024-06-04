PrimitiveType = UnityEngine.PrimitiveType
GameObject = UnityEngine.GameObject

local obj = GameObject.CreatePrimitive(PrimitiveType.Cube)

local c = E_MyEnum.Idle
local d = E_MyEnum.Move
print(c)

if c== d then
    print("枚举相等")
    else
        print("枚举不相等")
end

print("枚举转字符串")
print(tostring(c))
print("枚举转数字")
print(c:ToInt())

print("数字转枚举")
print(E_MyEnum.IntToEnum(0))
print(tostring(E_MyEnum.IntToEnum(0)))

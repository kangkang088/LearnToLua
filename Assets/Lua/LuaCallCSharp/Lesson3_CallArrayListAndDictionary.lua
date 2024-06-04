local obj = Lesson3()
print(obj.array.Length)
print(obj.array[1])
print("查找元素位置:"..obj.array:IndexOf(2))

for i=0,obj.array.Length - 1 do
    print("Array:"..obj.array[i])
end

local iter = obj.array:GetEnumerator()
while iter:MoveNext() do
    print("iter".. iter.Current)
end

local t = obj.array:ToTable()

for i = 1, #t do
    print("table.."..t[i])
end

local array2 = System.Array.CreateInstance(typeof(System.Int32),10)
print(array2.Length)
print(array2[0])
array2[0] = 99
print(array2[0])


local objList = Lesson3()
--添加
objList.list:Add(10)
objList.list:Add(12)
objList.list:Add(15)
print("获取："..objList.list[0])
print("长度："..objList.list.Count)

for i=0,objList.list.Count-1 do
    print("list:"..objList.list[i])
end

--创建
local list2 = System.Collections.Generic.List_string()
list2:Add("123")
print(list2[0])

obj.dic:Add(1,"123")
obj.dic:Add(2,"234")
obj.dic:Add(3,"345")

print(obj.dic[1])

local iterDic = obj.dic:GetEnumerator()
while iterDic:MoveNext() do
    local v = iterDic.Current
    print(v.Key .. "_" .. v.Value)
end
--遍历键
local keyIter = obj.dic.Keys:GetEnumerator()
while keyIter:MoveNext() do
    print("Key:" .. keyIter.Current)
end
--遍历值
local valueIter = obj.dic.Values:GetEnumerator()
while valueIter:MoveNext() do
    print("Value:" .. valueIter.Current)
end

local dic2 = System.Collections.Generic.Dictionary_int_string()
dic2:Add(10,"123")
print("创建：" .. dic2[10])
local dic3 = System.Collections.Generic.Dictionary_string_int()
dic3:Add("123",888)
--xlua中创建C#dic访问值的时候键要是字符串，不能通过[]访问
local b,v = dic3:TryGetValue("123",nil)
print(v)
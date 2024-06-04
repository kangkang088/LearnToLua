local obj = Lesson5()
--多返回值，第一个默认为函数的返回值，后面依次为ref或out的

--ref
print(obj:RefFun(10,0,0,1))
local a,b,c = obj:RefFun(10,0,0,1)
print(a,b,c)

--out
--tolua中，out参数不能省略
print(obj:OutFun(20,nil,nil,30))
local a,b,c = obj:OutFun(20,nil,nil,30)
print(a,b,c)

print(obj:RefOutFun(20,nil,0))
local a,b,c = obj:RefOutFun(20,nil,0)
print(a,b,c)
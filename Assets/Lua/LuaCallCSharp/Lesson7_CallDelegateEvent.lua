local obj = Lesson7()

local fun = function ()
    print("Lua函数Fun")
end

--tolua使用C#委托添加函数的规则和xlua一样
obj.del = fun
obj.del = obj.del + fun
obj.del = obj.del + function()
    print("临时生成的函数")
end

--xlua执行委托，obj.del()
--toluab不行，C#必须包裹一层
obj:DoDel()

fun2 = function()
    print("事件加的函数")
end
--obj.eventAction = fun2
obj.eventAction = obj.eventAction + fun2
obj.eventAction = obj.eventAction + function()
    print("事件加的匿名函数")
end
obj:DoEvent()
obj:ClearEvent()
obj:DoEvent()
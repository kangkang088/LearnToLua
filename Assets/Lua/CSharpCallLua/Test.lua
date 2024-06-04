print("C#调用lua测试脚本")

testNumber = 1
testBool = true
testFloat = 1.2
testString  = '123'

local testLocal = 10

testFun = function()
    print("无参无返回")
end

--有参有返回
testFun2 = function(a)
    print("有参有返回")
    return a + 100
end

--多返回值
testFun3 = function(a)
    print("多返回值")
    return 1,2,false,'123',a
end 

--变长参数
testFun4 = function(a,...)
    arg = {...}
    print(a)
    print("变长参数")
    for k,v in pairs(arg) do
        print(k,v)
    end
end

--table表现List
testList = {10,20,30,40,50,60}
testList2 ={"123","123",true,1,1.2}
--table表现Dictionary
testDic = {
    ["1"] = 1,
    ["2"] = 10,
    ["3"] = 20,
    ["4"] = 30,
}
testDic2 = {
    ["1"] = 1,
    [true] = 1,
    [false] = true,
    ["123"] = false
}

--table
testClass = {
    testInt = 2,
    testBool = 123,
    testFloat = 1.2,
    testString = "123",
    testFun = function ()
        print("表中的函数打印")
    end
}

--lua协程程序

local coDelay = nil
StartDelay = function()
    coDelay = coroutine.start(Delay)
end

Delay = function()
    local c = 1
    while true do
        --等待1s 执行一次逻辑
        coroutine.wait(1)
        print("Count:"..c)
        c = c + 1
        if c>= 5 then
            StopDelay()
            break
        end
    end
end

StopDelay = function()
    coroutine.stop(coDelay)
end
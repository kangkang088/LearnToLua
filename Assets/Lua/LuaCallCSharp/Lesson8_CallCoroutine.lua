local coDelay = nil
StartDelay = function()
    --tolua提供的，类似Unity中的
    coDelay = StartCoroutine(Delay)
end

Delay = function()
    local c = 1
    while true do
        --tolua提供的，类似Unity中的
        --Yield(0)
        --WaitForFixedUpdate()
        --WaitForEndOfFrame()
        --Yield(异步加载返回值)
        WaitForSeconds(1)
        print("Count:"..c)
        c = c+1
        if c > 5 then
            StopDelay()
            break
        end
    end
end 

StopDelay = function()
    StopCoroutine(coDelay)
    coDelay = nil
end

StartDelay()
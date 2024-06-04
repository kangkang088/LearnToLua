local obj = Lesson6()

print(obj:Calc())
print(obj:Calc(1))
print(obj:Calc(1.2))
print(obj:Calc("123"))

--调用的是非Out的重载
print(obj:Calc(10,1))
--就想用out，怎么办
print(obj:Calc(10,nil))

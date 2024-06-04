using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

public class Lesson7_CallTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().Require("Main");

        LuaTable table = LuaMgr.GetInstance().LuaState.GetTable("testClass");
        table = LuaMgr.GetInstance().LuaState["testClass"] as LuaTable;
        Debug.Log(table["testInt"]);
        Debug.Log(table["testBool"]);
        Debug.Log(table["testFloat"]);
        Debug.Log(table["testString"]);
        LuaFunction function = table.GetLuaFunction("testFun");
        function.Call();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

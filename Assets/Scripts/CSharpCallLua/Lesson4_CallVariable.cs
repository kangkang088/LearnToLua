using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_CallVariable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().Require("Main");

        Debug.Log("testNumber" + LuaMgr.GetInstance().LuaState["testNumber"]);
        Debug.Log("testBool" + LuaMgr.GetInstance().LuaState["testBool"]);
        Debug.Log("testFloat" + LuaMgr.GetInstance().LuaState["testFloat"]);
        Debug.Log("testString" + LuaMgr.GetInstance().LuaState["testString"]);
        LuaMgr.GetInstance().LuaState["testString"] = "321";
        Debug.Log("testString" + LuaMgr.GetInstance().LuaState["testString"]);
        //Debug.Log("testLocal" + LuaMgr.GetInstance().LuaState["testLocal"]);

        Debug.Log("addValue" + LuaMgr.GetInstance().LuaState["addValue"]);
        LuaMgr.GetInstance().LuaState["addValue"] = 999;
        Debug.Log("addValue" + LuaMgr.GetInstance().LuaState["addValue"]);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

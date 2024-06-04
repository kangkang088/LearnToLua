using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEditor.Build.Content;
using UnityEngine;

public class Lesson6_CallListAndDIctionary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().Require("Main");

        LuaTable table = LuaMgr.GetInstance().LuaState.GetTable("testList");
        Debug.Log(table[1]);
        Debug.Log(table[2]);
        Debug.Log(table[3]);
        Debug.Log(table[4]);
        Debug.Log(table[5]);
        Debug.Log(table[6]);
        object[] objects = table.ToArray();
        foreach (object item in objects)
        {
            Debug.Log("遍历打印" + item);
        }
        LuaTable table2 = LuaMgr.GetInstance().LuaState.GetTable("testList2");
        Debug.Log(table2[1]);
        Debug.Log(table2[2]);
        Debug.Log(table2[3]);
        Debug.Log(table2[4]);
        Debug.Log(table2[5]);

        LuaTable dic = LuaMgr.GetInstance().LuaState.GetTable("testDic");
        Debug.Log(dic["1"]);
        Debug.Log(dic["2"]);
        Debug.Log(dic["3"]);
        Debug.Log(dic["4"]);
        LuaTable dic2 = LuaMgr.GetInstance().LuaState.GetTable("testDic2");
        LuaDictTable<object, object> luaDic2 = dic2.ToDictTable<object, object>();
        Debug.Log(luaDic2["1"]);
        Debug.Log(luaDic2[true]);
        Debug.Log(luaDic2[false]);
        Debug.Log(luaDic2["123"]);
        IEnumerator<LuaDictEntry<object, object>> ie = luaDic2.GetEnumerator();
        while (ie.MoveNext())
        {
            Debug.Log(ie.Current.Key + "_" + ie.Current.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

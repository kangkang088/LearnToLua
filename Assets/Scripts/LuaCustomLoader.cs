using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

public class LuaCustomLoader : LuaFileUtils
{
    public override byte[] ReadFile(string fileName)
    {
        Debug.Log("自定义解析方式：" + fileName);
        if (!fileName.EndsWith(".lua"))
        {
            fileName += ".lua";
        }
        byte[] buffer = null;
        //ab包我们只需要文件名
        string[] strs = fileName.Split('/');
        TextAsset luaCode = ABMgr.GetInstance().LoadRes<TextAsset>("lua", strs[strs.Length - 1]);
        if (luaCode != null)
        {
            buffer = luaCode.bytes;
            Resources.UnloadAsset(luaCode);
        }
        if (buffer == null)
        {
            string path = "Lua/" + fileName;
            TextAsset txt = Resources.Load<TextAsset>(path);
            if (txt != null)
            {
                buffer = txt.bytes;
                Resources.UnloadAsset(txt);
            }
        }
        return buffer;
    }
}

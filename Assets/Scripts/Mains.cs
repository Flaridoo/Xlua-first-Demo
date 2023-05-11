using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class Mains : MonoBehaviour
{
    public static LuaEnv luaEnv;

    private void Awake()
    {
        luaEnv = new LuaEnv();
        luaEnv.DoString("require 'hotfix'");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnDisable()
    {
        luaEnv.DoString("require 'dispose'");
    }

    private void OnDestroy()
    {
        luaEnv.Dispose();
    }
}

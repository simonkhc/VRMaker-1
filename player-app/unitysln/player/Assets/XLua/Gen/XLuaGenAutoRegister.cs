﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(SVMAPI.Math), SVMAPIMathWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SVMAPI.Action), SVMAPIActionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SVMAPI.Slate), SVMAPISlateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SVMAPI.VR), SVMAPIVRWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SVMAPI.Camera), SVMAPICameraWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SVMAPI.Canvas), SVMAPICanvasWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SVMAPI.Ui), SVMAPIUiWrap.__Register);
				
				translator.DelayWrapLoader(typeof(SVMAPI.Sound), SVMAPISoundWrap.__Register);
				
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	public static partial class Utils
    {
	    
	    static Utils()
		{
		    extension_method_map = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
		}
	}
}

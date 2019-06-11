﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Spine_Unity_SkeletonAnimationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Spine.Unity.SkeletonAnimation), typeof(Spine.Unity.SkeletonRenderer));
		L.RegFunction("AddToGameObject", AddToGameObject);
		L.RegFunction("NewSkeletonAnimationGameObject", NewSkeletonAnimationGameObject);
		L.RegFunction("ClearState", ClearState);
		L.RegFunction("Initialize", Initialize);
		L.RegFunction("Update", Update);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("state", get_state, set_state);
		L.RegVar("loop", get_loop, set_loop);
		L.RegVar("timeScale", get_timeScale, set_timeScale);
		L.RegVar("AnimationState", get_AnimationState, null);
		L.RegVar("AnimationName", get_AnimationName, set_AnimationName);
		L.RegVar("UpdateLocal", get_UpdateLocal, set_UpdateLocal);
		L.RegVar("UpdateWorld", get_UpdateWorld, set_UpdateWorld);
		L.RegVar("UpdateComplete", get_UpdateComplete, set_UpdateComplete);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddToGameObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			Spine.Unity.SkeletonDataAsset arg1 = (Spine.Unity.SkeletonDataAsset)ToLua.CheckObject<Spine.Unity.SkeletonDataAsset>(L, 2);
			Spine.Unity.SkeletonAnimation o = Spine.Unity.SkeletonAnimation.AddToGameObject(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NewSkeletonAnimationGameObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Spine.Unity.SkeletonDataAsset arg0 = (Spine.Unity.SkeletonDataAsset)ToLua.CheckObject<Spine.Unity.SkeletonDataAsset>(L, 1);
			Spine.Unity.SkeletonAnimation o = Spine.Unity.SkeletonAnimation.NewSkeletonAnimationGameObject(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearState(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)ToLua.CheckObject<Spine.Unity.SkeletonAnimation>(L, 1);
			obj.ClearState();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)ToLua.CheckObject<Spine.Unity.SkeletonAnimation>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Initialize(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)ToLua.CheckObject<Spine.Unity.SkeletonAnimation>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Update(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_state(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)o;
			Spine.AnimationState ret = obj.state;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index state on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)o;
			bool ret = obj.loop;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index loop on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)o;
			float ret = obj.timeScale;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index timeScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AnimationState(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)o;
			Spine.AnimationState ret = obj.AnimationState;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AnimationState on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AnimationName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)o;
			string ret = obj.AnimationName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AnimationName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UpdateLocal(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(Spine.Unity.UpdateBonesDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UpdateWorld(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(Spine.Unity.UpdateBonesDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UpdateComplete(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(Spine.Unity.UpdateBonesDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_state(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)o;
			Spine.AnimationState arg0 = (Spine.AnimationState)ToLua.CheckObject<Spine.AnimationState>(L, 2);
			obj.state = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index state on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_loop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.loop = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index loop on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_timeScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.timeScale = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index timeScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_AnimationName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.AnimationName = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AnimationName on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UpdateLocal(IntPtr L)
	{
		try
		{
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)ToLua.CheckObject(L, 1, typeof(Spine.Unity.SkeletonAnimation));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'Spine.Unity.SkeletonAnimation.UpdateLocal' can only appear on the left hand side of += or -= when used outside of the type 'Spine.Unity.SkeletonAnimation'");
			}

			if (arg0.op == EventOp.Add)
			{
				Spine.Unity.UpdateBonesDelegate ev = (Spine.Unity.UpdateBonesDelegate)arg0.func;
				obj.UpdateLocal += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				Spine.Unity.UpdateBonesDelegate ev = (Spine.Unity.UpdateBonesDelegate)arg0.func;
				obj.UpdateLocal -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UpdateWorld(IntPtr L)
	{
		try
		{
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)ToLua.CheckObject(L, 1, typeof(Spine.Unity.SkeletonAnimation));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'Spine.Unity.SkeletonAnimation.UpdateWorld' can only appear on the left hand side of += or -= when used outside of the type 'Spine.Unity.SkeletonAnimation'");
			}

			if (arg0.op == EventOp.Add)
			{
				Spine.Unity.UpdateBonesDelegate ev = (Spine.Unity.UpdateBonesDelegate)arg0.func;
				obj.UpdateWorld += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				Spine.Unity.UpdateBonesDelegate ev = (Spine.Unity.UpdateBonesDelegate)arg0.func;
				obj.UpdateWorld -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UpdateComplete(IntPtr L)
	{
		try
		{
			Spine.Unity.SkeletonAnimation obj = (Spine.Unity.SkeletonAnimation)ToLua.CheckObject(L, 1, typeof(Spine.Unity.SkeletonAnimation));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'Spine.Unity.SkeletonAnimation.UpdateComplete' can only appear on the left hand side of += or -= when used outside of the type 'Spine.Unity.SkeletonAnimation'");
			}

			if (arg0.op == EventOp.Add)
			{
				Spine.Unity.UpdateBonesDelegate ev = (Spine.Unity.UpdateBonesDelegate)arg0.func;
				obj.UpdateComplete += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				Spine.Unity.UpdateBonesDelegate ev = (Spine.Unity.UpdateBonesDelegate)arg0.func;
				obj.UpdateComplete -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}


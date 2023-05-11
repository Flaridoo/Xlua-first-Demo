

using System.Collections.Generic;
using System;
using XLua;
using System.Reflection;
using System.Linq;

public static class HotfixCfg
{
	[Hotfix]
	public static List<Type> fields = new ()
	{
		typeof(Cubes)
	};
}

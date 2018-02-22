using System;
using System.Reflection;

// Token: 0x02000006 RID: 6
internal class Class1
{
	// Token: 0x0600000E RID: 14 RVA: 0x000027D8 File Offset: 0x000009D8
	internal static void OyHmTthhDLjHe(int typemdt)
	{
		Type type = Class1.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class1.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0000223C File Offset: 0x0000043C
	public Class1()
	{
		Class5.WNqmTthz2i6ny();
		base..ctor();
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002258 File Offset: 0x00000458
	static Class1()
	{
		// Note: this type is marked as 'beforefieldinit'.
		Class5.WNqmTthz2i6ny();
		Class1.module_0 = typeof(Class1).Assembly.ManifestModule;
	}

	// Token: 0x0400000B RID: 11
	internal static Module module_0;

	// Token: 0x02000007 RID: 7
	// (Invoke) Token: 0x06000012 RID: 18
	internal delegate void Delegate0(object o);
}

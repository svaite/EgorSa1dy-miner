using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Miner1.Properties
{
	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000223C File Offset: 0x0000043C
		internal Resources()
		{
			Class5.WNqmTthz2i6ny();
			base..ctor();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002448 File Offset: 0x00000648
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("Miner1.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002488 File Offset: 0x00000688
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002249 File Offset: 0x00000449
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000249C File Offset: 0x0000069C
		internal static byte[] MSASCuiL
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject(Class2.smethod_11(0), Resources.resourceCulture);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002251 File Offset: 0x00000451
		static Resources()
		{
			// Note: this type is marked as 'beforefieldinit'.
			Class6.kLjw4iIsCLsZtxc4lksN0j();
		}

		// Token: 0x04000001 RID: 1
		private static ResourceManager resourceMan;

		// Token: 0x04000002 RID: 2
		private static CultureInfo resourceCulture;
	}
}

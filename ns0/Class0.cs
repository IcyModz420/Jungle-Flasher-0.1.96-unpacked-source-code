using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns0
{
	// Token: 0x020000E6 RID: 230
	internal class Class0
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x00155D18 File Offset: 0x00155D18
		public Class0(string string_0)
		{
			this.mutex_0 = new Mutex(false, string_0);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x003CF338 File Offset: 0x00317338
		protected override void Finalize()
		{
			try
			{
				this.mutex_0.ReleaseMutex();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00155D78 File Offset: 0x00155D78
		[return: MarshalAs(UnmanagedType.U1)]
		public bool method_0()
		{
			return ((!this.mutex_0.WaitOne(10, true)) ? 1 : 0) != 0;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00155D9C File Offset: 0x00155D9C
		public void method_1()
		{
			GC.SuppressFinalize(this);
			this.Finalize();
		}

		// Token: 0x040004FC RID: 1276
		private Mutex mutex_0;
	}
}

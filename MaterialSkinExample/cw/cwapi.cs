using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace cw
{
	// Token: 0x02000006 RID: 6
	internal class cwapi
	{
		// Token: 0x06000026 RID: 38
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(cwapi.ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

		// Token: 0x06000027 RID: 39
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, long nSize, out IntPtr lpNumberOfBytesRead);

		// Token: 0x06000028 RID: 40
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [MarshalAs(UnmanagedType.AsAny)] object lpBuffer, long nSize, out IntPtr lpNumberOfBytesWritten);

		// Token: 0x06000029 RID: 41
		[DllImport("kernel32.dll")]
		private static extern bool Process32First(IntPtr hSnapshot, ref cwapi.PROCESSENTRY32 lppe);

		// Token: 0x0600002A RID: 42
		[DllImport("kernel32.dll")]
		private static extern bool Process32Next(IntPtr hSnapshot, ref cwapi.PROCESSENTRY32 lppe);

		// Token: 0x0600002B RID: 43
		[DllImport("kernel32.dll")]
		private static extern bool Module32First(IntPtr hSnapshot, ref cwapi.MODULEENTRY32 lpme);

		// Token: 0x0600002C RID: 44
		[DllImport("kernel32.dll")]
		private static extern bool Module32Next(IntPtr hSnapshot, ref cwapi.MODULEENTRY32 lpme);

		// Token: 0x0600002D RID: 45
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool CloseHandle(IntPtr hHandle);

		// Token: 0x0600002E RID: 46
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateToolhelp32Snapshot(cwapi.SnapshotFlags dwFlags, int th32ProcessID);

		// Token: 0x0600002F RID: 47 RVA: 0x00004D40 File Offset: 0x00002F40
		public static IntPtr GetModuleBaseAddress(Process proc, string modName)
		{
			IntPtr result = IntPtr.Zero;
			foreach (object obj in proc.Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				if (processModule.ModuleName == modName)
				{
					result = processModule.BaseAddress;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004DB0 File Offset: 0x00002FB0
		public static IntPtr GetModuleBaseAddress(int procId, string modName)
		{
			IntPtr result = IntPtr.Zero;
			IntPtr intPtr = cwapi.CreateToolhelp32Snapshot(cwapi.SnapshotFlags.Module | cwapi.SnapshotFlags.Module32, procId);
			if (intPtr.ToInt64() != -1L)
			{
				cwapi.MODULEENTRY32 moduleentry = default(cwapi.MODULEENTRY32);
				moduleentry.dwSize = (uint)Marshal.SizeOf(typeof(cwapi.MODULEENTRY32));
				if (cwapi.Module32First(intPtr, ref moduleentry))
				{
					while (!moduleentry.szModule.Equals(modName))
					{
						if (!cwapi.Module32Next(intPtr, ref moduleentry))
						{
							goto IL_63;
						}
					}
					result = moduleentry.modBaseAddr;
				}
			}
		IL_63:
			cwapi.CloseHandle(intPtr);
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004E28 File Offset: 0x00003028
		public static IntPtr FindDMAAddy(IntPtr hProc, IntPtr ptr, int[] offsets)
		{
			byte[] array = new byte[IntPtr.Size];
			foreach (int offset in offsets)
			{
				IntPtr intPtr;
				cwapi.ReadProcessMemory(hProc, ptr, array, (long)array.Length, out intPtr);
				ptr = ((IntPtr.Size == 4) ? IntPtr.Add(new IntPtr(BitConverter.ToInt32(array, 0)), offset) : (ptr = IntPtr.Add(new IntPtr(BitConverter.ToInt64(array, 0)), offset)));
			}
			return ptr;
		}

		// Token: 0x0400006D RID: 109
		private const int INVALID_HANDLE_VALUE = -1;

		// Token: 0x02000008 RID: 8
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			// Token: 0x04000072 RID: 114
			All = 2035711U,
			// Token: 0x04000073 RID: 115
			Terminate = 1U,
			// Token: 0x04000074 RID: 116
			CreateThread = 2U,
			// Token: 0x04000075 RID: 117
			VirtualMemoryOperation = 8U,
			// Token: 0x04000076 RID: 118
			VirtualMemoryRead = 16U,
			// Token: 0x04000077 RID: 119
			VirtualMemoryWrite = 32U,
			// Token: 0x04000078 RID: 120
			DuplicateHandle = 64U,
			// Token: 0x04000079 RID: 121
			CreateProcess = 128U,
			// Token: 0x0400007A RID: 122
			SetQuota = 256U,
			// Token: 0x0400007B RID: 123
			SetInformation = 512U,
			// Token: 0x0400007C RID: 124
			QueryInformation = 1024U,
			// Token: 0x0400007D RID: 125
			QueryLimitedInformation = 4096U,
			// Token: 0x0400007E RID: 126
			Synchronize = 1048576U
		}

		// Token: 0x02000009 RID: 9
		public struct PROCESSENTRY32
		{
			// Token: 0x0400007F RID: 127
			public uint dwSize;

			// Token: 0x04000080 RID: 128
			public uint cntUsage;

			// Token: 0x04000081 RID: 129
			public uint th32ProcessID;

			// Token: 0x04000082 RID: 130
			public IntPtr th32DefaultHeapID;

			// Token: 0x04000083 RID: 131
			public uint th32ModuleID;

			// Token: 0x04000084 RID: 132
			public uint cntThreads;

			// Token: 0x04000085 RID: 133
			public uint th32ParentProcessID;

			// Token: 0x04000086 RID: 134
			public int pcPriClassBase;

			// Token: 0x04000087 RID: 135
			public uint dwFlags;

			// Token: 0x04000088 RID: 136
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}

		// Token: 0x0200000A RID: 10
		public struct MODULEENTRY32
		{
			// Token: 0x04000089 RID: 137
			internal uint dwSize;

			// Token: 0x0400008A RID: 138
			internal uint th32ModuleID;

			// Token: 0x0400008B RID: 139
			internal uint th32ProcessID;

			// Token: 0x0400008C RID: 140
			internal uint GlblcntUsage;

			// Token: 0x0400008D RID: 141
			internal uint ProccntUsage;

			// Token: 0x0400008E RID: 142
			internal IntPtr modBaseAddr;

			// Token: 0x0400008F RID: 143
			internal uint modBaseSize;

			// Token: 0x04000090 RID: 144
			internal IntPtr hModule;

			// Token: 0x04000091 RID: 145
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			internal string szModule;

			// Token: 0x04000092 RID: 146
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			internal string szExePath;
		}

		// Token: 0x0200000B RID: 11
		[Flags]
		private enum SnapshotFlags : uint
		{
			// Token: 0x04000094 RID: 148
			HeapList = 1U,
			// Token: 0x04000095 RID: 149
			Process = 2U,
			// Token: 0x04000096 RID: 150
			Thread = 4U,
			// Token: 0x04000097 RID: 151
			Module = 8U,
			// Token: 0x04000098 RID: 152
			Module32 = 16U,
			// Token: 0x04000099 RID: 153
			Inherit = 2147483648U,
			// Token: 0x0400009A RID: 154
			All = 31U,
			// Token: 0x0400009B RID: 155
			NoHeaps = 1073741824U
		}
	}
}

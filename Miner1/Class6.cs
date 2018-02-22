using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

// Token: 0x02000011 RID: 17
internal class Class6
{
	// Token: 0x06000043 RID: 67 RVA: 0x000042C8 File Offset: 0x000024C8
	private static void smethod_0()
	{
		if (!Class6.bool_0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class2).Assembly.GetManifestResourceStream(Class2.smethod_11(498)));
			binaryReader.BaseStream.Position = 0L;
			byte[] byte_ = new byte[0];
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 102;
			array2[0] = 145;
			array2[0] = 100;
			array2[0] = 110;
			array2[0] = 98;
			array2[0] = 131;
			array2[1] = 141;
			array2[1] = 120;
			array2[1] = 161;
			array2[2] = 61;
			array2[2] = 107;
			array2[2] = 111;
			array2[2] = 174;
			array2[3] = 100;
			array2[3] = 43;
			array2[3] = 193;
			array2[4] = 167;
			array2[4] = 154;
			array2[4] = 168;
			array2[4] = 104;
			array2[4] = 226;
			array2[5] = 87;
			array2[5] = 180;
			array2[5] = 166;
			array2[5] = 88;
			array2[6] = 125;
			array2[6] = 134;
			array2[6] = 31;
			array2[6] = 105;
			array2[7] = 148;
			array2[7] = 140;
			array2[7] = 190;
			array2[8] = 87;
			array2[8] = 90;
			array2[8] = 200;
			array2[8] = 101;
			array2[8] = 122;
			array2[8] = 135;
			array2[9] = 128;
			array2[9] = 133;
			array2[9] = 137;
			array2[9] = 103;
			array2[9] = 162;
			array2[10] = 88;
			array2[10] = 145;
			array2[10] = 34;
			array2[11] = 192;
			array2[11] = 134;
			array2[11] = 134;
			array2[12] = 34;
			array2[12] = 91;
			array2[12] = 144;
			array2[12] = 140;
			array2[12] = 129;
			array2[13] = 25;
			array2[13] = 139;
			array2[13] = 88;
			array2[13] = 195;
			array2[14] = 185;
			array2[14] = 156;
			array2[14] = 128;
			array2[14] = 122;
			array2[14] = 62;
			array2[15] = 96;
			array2[15] = 166;
			array2[15] = 189;
			array2[15] = 233;
			array2[16] = 162;
			array2[16] = 155;
			array2[16] = 215;
			array2[17] = 119;
			array2[17] = 121;
			array2[17] = 150;
			array2[17] = 4;
			array2[17] = 110;
			array2[17] = 83;
			array2[18] = 166;
			array2[18] = 161;
			array2[18] = 122;
			array2[19] = 57;
			array2[19] = 134;
			array2[19] = 221;
			array2[19] = 163;
			array2[19] = 101;
			array2[19] = 229;
			array2[20] = 102;
			array2[20] = 107;
			array2[20] = 98;
			array2[21] = 150;
			array2[21] = 218;
			array2[21] = 68;
			array2[21] = 52;
			array2[21] = 198;
			array2[22] = 79;
			array2[22] = 139;
			array2[22] = 126;
			array2[22] = 108;
			array2[22] = 157;
			array2[22] = 179;
			array2[23] = 154;
			array2[23] = 86;
			array2[23] = 90;
			array2[23] = 195;
			array2[23] = 92;
			array2[23] = 125;
			array2[24] = 84;
			array2[24] = 120;
			array2[24] = 126;
			array2[24] = 115;
			array2[24] = 107;
			array2[24] = 107;
			array2[25] = 56;
			array2[25] = 176;
			array2[25] = 212;
			array2[25] = 159;
			array2[25] = 150;
			array2[26] = 156;
			array2[26] = 129;
			array2[26] = 182;
			array2[27] = 120;
			array2[27] = 130;
			array2[27] = 143;
			array2[27] = 18;
			array2[27] = 189;
			array2[27] = 26;
			array2[28] = 154;
			array2[28] = 233;
			array2[28] = 141;
			array2[28] = 123;
			array2[28] = 108;
			array2[28] = 201;
			array2[29] = 163;
			array2[29] = 228;
			array2[29] = 155;
			array2[29] = 59;
			array2[29] = 153;
			array2[29] = 39;
			array2[30] = 114;
			array2[30] = 141;
			array2[30] = 156;
			array2[30] = 138;
			array2[30] = 171;
			array2[30] = 220;
			array2[31] = 125;
			array2[31] = 136;
			array2[31] = 203;
			array2[31] = 137;
			array2[31] = 35;
			array2[31] = 78;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 96;
			array4[0] = 155;
			array4[0] = 97;
			array4[0] = 151;
			array4[1] = 110;
			array4[1] = 134;
			array4[1] = 147;
			array4[1] = 106;
			array4[1] = 142;
			array4[1] = 234;
			array4[2] = 88;
			array4[2] = 59;
			array4[2] = 117;
			array4[2] = 106;
			array4[2] = 50;
			array4[3] = 100;
			array4[3] = 86;
			array4[3] = 120;
			array4[3] = 95;
			array4[3] = 159;
			array4[4] = 170;
			array4[4] = 164;
			array4[4] = 98;
			array4[4] = 81;
			array4[5] = 180;
			array4[5] = 159;
			array4[5] = 116;
			array4[5] = 70;
			array4[6] = 92;
			array4[6] = 134;
			array4[6] = 31;
			array4[6] = 85;
			array4[7] = 148;
			array4[7] = 190;
			array4[7] = 14;
			array4[7] = 88;
			array4[7] = 146;
			array4[7] = 106;
			array4[8] = 85;
			array4[8] = 164;
			array4[8] = 170;
			array4[9] = 37;
			array4[9] = 212;
			array4[9] = 126;
			array4[9] = 30;
			array4[9] = 160;
			array4[9] = 37;
			array4[10] = 97;
			array4[10] = 71;
			array4[10] = 87;
			array4[10] = 50;
			array4[10] = 151;
			array4[11] = 118;
			array4[11] = 150;
			array4[11] = 106;
			array4[12] = 142;
			array4[12] = 127;
			array4[12] = 2;
			array4[13] = 106;
			array4[13] = 89;
			array4[13] = 134;
			array4[13] = 180;
			array4[13] = 152;
			array4[13] = 115;
			array4[14] = 127;
			array4[14] = 150;
			array4[14] = 241;
			array4[14] = 144;
			array4[14] = 148;
			array4[14] = 243;
			array4[15] = 119;
			array4[15] = 166;
			array4[15] = 30;
			byte[] array5 = array4;
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] ^= array5[i];
			}
			byte[] array6 = array;
			int num = array6.Length % 4;
			int num2 = array6.Length / 4;
			byte[] array7 = new byte[array6.Length];
			int num3 = array3.Length / 4;
			uint num4 = 0u;
			if (num > 0)
			{
				num2++;
			}
			for (int j = 0; j < num2; j++)
			{
				int num5 = j % num3;
				int num6 = j * 4;
				uint num7 = (uint)(num5 * 4);
				uint num8 = (uint)((int)array3[(int)((UIntPtr)(num7 + 3u))] << 24 | (int)array3[(int)((UIntPtr)(num7 + 2u))] << 16 | (int)array3[(int)((UIntPtr)(num7 + 1u))] << 8 | (int)array3[(int)((UIntPtr)num7)]);
				uint num9 = 255u;
				int num10 = 0;
				uint num11;
				if (j == num2 - 1 && num > 0)
				{
					num11 = 0u;
					num4 += num8;
					for (int k = 0; k < num; k++)
					{
						if (k > 0)
						{
							num11 <<= 8;
						}
						num11 |= (uint)array6[array6.Length - (1 + k)];
					}
				}
				else
				{
					num7 = (uint)num6;
					num4 += num8;
					num11 = (uint)((int)array6[(int)((UIntPtr)(num7 + 3u))] << 24 | (int)array6[(int)((UIntPtr)(num7 + 2u))] << 16 | (int)array6[(int)((UIntPtr)(num7 + 1u))] << 8 | (int)array6[(int)((UIntPtr)num7)]);
				}
				uint num12 = num4;
				uint num13 = num12;
				uint num14 = num12;
				uint num15 = 1117540173u;
				uint num16 = 2053035004u;
				uint num17 = 236713647u;
				uint num18 = 476602603u;
				uint num19 = 3769154997u;
				if (1117540173 == 0.0)
				{
					num15 -= 1u;
				}
				uint num20 = (uint)((double)((short)num16) / num15 + num15);
				num15 = (uint)(27282u * num20 + 809622430.0);
				num14 ^= num14 >> 5;
				num14 += num18;
				num14 ^= num14 >> 12;
				num14 += num19;
				num14 ^= num14 << 21;
				num14 += num15;
				num14 = ((num18 << 9) + num17 ^ num18) + num14;
				num12 = num13 + (uint)num14;
				num4 = num12;
				if (j == num2 - 1 && num > 0)
				{
					uint num21 = num4 ^ num11;
					for (int l = 0; l < num; l++)
					{
						if (l > 0)
						{
							num9 <<= 8;
							num10 += 8;
						}
						array7[num6 + l] = (byte)((num21 & num9) >> num10);
					}
				}
				else
				{
					uint num22 = num4 ^ num11;
					array7[num6] = (byte)(num22 & 255u);
					array7[num6 + 1] = (byte)((num22 & 65280u) >> 8);
					array7[num6 + 2] = (byte)((num22 & 16711680u) >> 16);
					array7[num6 + 3] = (byte)((num22 & 4278190080u) >> 24);
				}
			}
			byte_ = array7;
			Class6.object_0 = Class6.Class7.smethod_18(Class6.Class7.smethod_17(byte_));
			Class6.string_0 = ((Assembly)Class6.object_0).GetManifestResourceNames();
			Class6.bool_0 = true;
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00005018 File Offset: 0x00003218
	internal static string[] smethod_1(Assembly assembly_0)
	{
		if (assembly_0 == typeof(Class6).Assembly)
		{
			if (!Class6.bool_0)
			{
				Class6.smethod_0();
			}
			List<string> list = new List<string>();
			list.AddRange(assembly_0.GetManifestResourceNames());
			list.AddRange(((Assembly)Class6.object_0).GetManifestResourceNames());
			return list.ToArray();
		}
		return assembly_0.GetManifestResourceNames();
	}

	// Token: 0x06000045 RID: 69 RVA: 0x0000507C File Offset: 0x0000327C
	private static Assembly smethod_2(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		if (!Class6.bool_0)
		{
			Class6.smethod_0();
		}
		string name = resolveEventArgs_0.Name;
		for (int i = 0; i < Class6.string_0.Length; i++)
		{
			if (Class6.string_0[i] == name)
			{
				return (Assembly)Class6.object_0;
			}
		}
		return null;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000023C8 File Offset: 0x000005C8
	public Class6()
	{
		AppDomain.CurrentDomain.ResourceResolve += Class6.smethod_2;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x000023E6 File Offset: 0x000005E6
	internal static void kLjw4iIsCLsZtxc4lksN0j()
	{
		if (!Class6.bool_1)
		{
			Class6.bool_1 = true;
			new Class6();
		}
	}

	// Token: 0x0400002C RID: 44
	private static string[] string_0 = new string[0];

	// Token: 0x0400002D RID: 45
	private static object object_0 = null;

	// Token: 0x0400002E RID: 46
	private static bool bool_0 = false;

	// Token: 0x0400002F RID: 47
	private static bool bool_1 = false;

	// Token: 0x02000012 RID: 18
	private enum Enum1
	{

	}

	// Token: 0x02000013 RID: 19
	internal class Class7
	{
		// Token: 0x06000049 RID: 73 RVA: 0x000050CC File Offset: 0x000032CC
		private unsafe static uint smethod_0(void* pVoid_0, uint uint_0)
		{
			uint result = 0u;
			if (BitConverter.IsLittleEndian)
			{
				result = *(uint*)pVoid_0;
			}
			else
			{
				switch (uint_0)
				{
				case 1u:
					result = (uint)(*(byte*)pVoid_0);
					break;
				case 2u:
					result = (uint)((int)(*(byte*)pVoid_0) | (int)((byte*)pVoid_0)[1] << 8);
					break;
				case 3u:
					result = (uint)((int)(*(byte*)pVoid_0) | (int)((byte*)pVoid_0)[1] << 8 | (int)((byte*)pVoid_0)[2] << 16);
					break;
				case 4u:
					result = (uint)((int)(*(byte*)pVoid_0) | (int)((byte*)pVoid_0)[1] << 8 | (int)((byte*)pVoid_0)[2] << 16 | (int)((byte*)pVoid_0)[3] << 24);
					break;
				}
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000514C File Offset: 0x0000334C
		private unsafe static void smethod_1(uint uint_0, void* pVoid_0, uint uint_1)
		{
			if (BitConverter.IsLittleEndian)
			{
				switch (uint_1)
				{
				case 1u:
					*(byte*)pVoid_0 = (byte)uint_0;
					return;
				case 2u:
				case 3u:
				case 4u:
					*(int*)pVoid_0 = (int)uint_0;
					return;
				default:
					return;
				}
			}
			else
			{
				switch (uint_1)
				{
				case 1u:
					*(byte*)pVoid_0 = (byte)uint_0;
					return;
				case 2u:
					*(byte*)pVoid_0 = (byte)uint_0;
					((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
					return;
				case 3u:
					*(byte*)pVoid_0 = (byte)uint_0;
					((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
					((byte*)pVoid_0)[2] = (byte)(uint_0 >> 16);
					return;
				case 4u:
					*(byte*)pVoid_0 = (byte)uint_0;
					((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
					((byte*)pVoid_0)[2] = (byte)(uint_0 >> 16);
					((byte*)pVoid_0)[3] = (byte)(uint_0 >> 24);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000051F0 File Offset: 0x000033F0
		private unsafe static bool smethod_2(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			bool flag = true;
			uint num = 0u;
			while (flag && num < uint_0)
			{
				flag = (((byte*)pVoid_0)[num] == ((byte*)pVoid_1)[num]);
				num += 1u;
			}
			return flag;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000521C File Offset: 0x0000341C
		private unsafe static bool smethod_3(void* pVoid_0, string string_0)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			byte[] array;
			byte* ptr;
			if ((array = bytes) != null && array.Length != 0)
			{
				fixed (byte* ptr = &array[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			return Class6.Class7.smethod_2(pVoid_0, (void*)ptr, (uint)bytes.Length);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000525C File Offset: 0x0000345C
		private unsafe static void smethod_4(void* pVoid_0, byte byte_0, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num += 1u)
			{
				((byte*)pVoid_0)[num] = byte_0;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000527C File Offset: 0x0000347C
		private unsafe static void smethod_5(void* pVoid_0, void* pVoid_1, uint uint_0)
		{
			for (uint num = 0u; num < uint_0; num += 1u)
			{
				((byte*)pVoid_0)[num] = ((byte*)pVoid_1)[num];
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000052A0 File Offset: 0x000034A0
		private unsafe static void smethod_6(void* pVoid_0, string string_0)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			byte[] array;
			byte* ptr;
			if ((array = bytes) != null && array.Length != 0)
			{
				fixed (byte* ptr = &array[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			Class6.Class7.smethod_5(pVoid_0, (void*)ptr, (uint)bytes.Length);
			ptr = null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000052E0 File Offset: 0x000034E0
		private unsafe static void smethod_7(byte* pByte_0, byte* pByte_1, uint uint_0)
		{
			if (BitConverter.IsLittleEndian)
			{
				if (uint_0 < 5u)
				{
					*(int*)pByte_0 = (int)(*(uint*)pByte_1);
					return;
				}
				byte* ptr = pByte_0 + uint_0;
				while (pByte_0 < ptr)
				{
					*(int*)pByte_0 = (int)(*(uint*)pByte_1);
					pByte_0 += 4;
					pByte_1 += 4;
				}
				return;
			}
			else
			{
				if (uint_0 > 8u && pByte_1 + uint_0 < pByte_0)
				{
					Class6.Class7.smethod_5((void*)pByte_0, (void*)pByte_1, uint_0);
					return;
				}
				byte* ptr2 = pByte_0 + uint_0;
				while (pByte_0 < ptr2)
				{
					*pByte_0 = *pByte_1;
					pByte_0++;
					pByte_1++;
				}
				return;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005348 File Offset: 0x00003548
		private unsafe static uint smethod_8(byte[] byte_0, uint uint_0, Class6.Enum1 enum1_0)
		{
			uint result = 0u;
			byte* ptr;
			if (byte_0 != null && byte_0.Length != 0)
			{
				fixed (byte* ptr = &byte_0[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			if (Class6.Class7.smethod_3((void*)((byte*)ptr + uint_0), Class2.smethod_11(576)))
			{
				result = ((uint*)ptr + uint_0 / 4u)[(IntPtr)enum1_0];
			}
			ptr = null;
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000241A File Offset: 0x0000061A
		private static uint smethod_9(byte[] byte_0)
		{
			return Class6.Class7.smethod_8(byte_0, 0u, (Class6.Enum1)2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002424 File Offset: 0x00000624
		public static uint smethod_10(byte[] byte_0, uint uint_0)
		{
			return Class6.Class7.smethod_8(byte_0, uint_0, (Class6.Enum1)3);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005394 File Offset: 0x00003594
		private unsafe static uint smethod_11(byte[] byte_0, uint uint_0, byte[] byte_1, uint uint_1)
		{
			byte* ptr;
			if (byte_0 != null && byte_0.Length != 0)
			{
				fixed (byte* ptr = &byte_0[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			byte* ptr2;
			if (byte_1 != null && byte_1.Length != 0)
			{
				fixed (byte* ptr2 = &byte_1[0])
				{
				}
			}
			else
			{
				ptr2 = null;
			}
			byte* ptr3 = ptr + uint_0;
			uint num = 32u;
			byte* ptr4 = ptr3 + uint_1 - 1;
			byte* ptr5 = ptr3 + 1;
			byte** ptr6 = (byte**)ptr2 + uint_1 / (uint)sizeof(byte*) + 36000 / sizeof(byte*) - (IntPtr)sizeof(byte*) * 4096 / (IntPtr)sizeof(byte*) - (ptr2 + uint_1) % 8L;
			byte* pVoid_ = ptr2 + 32;
			byte* ptr7 = ptr2 + 32 + 4 + 1;
			byte* ptr8 = ptr7;
			byte* ptr9 = ptr5;
			uint num2 = 1073741824u;
			uint* ptr10 = (uint*)ptr2;
			byte* ptr11 = ptr4 - 16;
			Class6.Class7.smethod_6((void*)ptr10, Class2.smethod_11(576));
			*ptr2 = 81;
			ptr2[1] = 67;
			ptr2[2] = 76;
			ptr2[3] = 90;
			Class6.Class7.smethod_1(3u, (void*)(ptr10 + 1), 4u);
			Class6.Class7.smethod_1(uint_1, (void*)(ptr10 + 3), 4u);
			for (uint num3 = 0u; num3 < 4096u; num3 += 1u)
			{
				*(IntPtr*)(ptr6 + (ulong)num3 * (ulong)((long)sizeof(byte*)) / (ulong)sizeof(byte*)) = ptr3;
			}
			(ptr2 + num)[4] = *ptr3;
			while (ptr5 < ptr11 - 2050)
			{
				if ((num2 & 1u) == 1u)
				{
					if (ptr7 + 2050 + 128 != ptr2 + uint_1 + 2050 + 256)
					{
						Class6.Class7.smethod_5((void*)((byte*)ptr2 + num), (void*)ptr3, uint_1);
						Class6.Class7.smethod_1(0u, (void*)(ptr10 + 4), 4u);
						Class6.Class7.smethod_1(uint_1 + num + 4u, (void*)(ptr10 + 2), 4u);
						Class6.Class7.smethod_6((void*)((byte*)((byte*)ptr2 + Class6.Class7.smethod_0((void*)(ptr10 + 2), 4u)) - 4), Class2.smethod_11(576));
						return Class6.Class7.smethod_0((void*)(ptr10 + 2), 4u);
					}
					Class6.Class7.smethod_1((uint)((ulong)(num2 >> 1) | 18446744071562067968UL), (void*)pVoid_, 4u);
					pVoid_ = ptr7;
					ptr7 += 4;
					num2 = 2147483648u;
					if ((long)(ptr7 - ptr8) > (long)(ptr5 - ptr9) && ptr5 + 4100 < ptr11)
					{
						while (ptr5 < ptr9 + 2050 - 32)
						{
							Class6.Class7.smethod_1(2147483648u, (void*)(ptr7 - 4), 4u);
							Class6.Class7.smethod_7(ptr7, ptr5, 31u);
							ptr7 += 35;
							ptr5 += 31;
						}
						ptr9 = ptr5;
						ptr8 = ptr7;
						pVoid_ = ptr7 - 4;
					}
				}
				if (Class6.Class7.smethod_0((void*)ptr5, 4u) == Class6.Class7.smethod_0((void*)(ptr5 + 1), 4u))
				{
					uint num4 = Class6.Class7.smethod_0((void*)ptr5, 4u);
					byte* ptr12 = ptr5;
					ptr5 += 5;
					while (num4 == Class6.Class7.smethod_0((void*)ptr5, 4u) && ptr5 < ptr12 + 2050 - 4)
					{
						ptr5 += 4;
					}
					Class6.Class7.smethod_1((num4 & 255u) << 16 | (uint)((uint)((long)(ptr5 - ptr12)) << 4) | 15u, (void*)ptr7, 4u);
					ptr7 += 3;
					num2 = (num2 >> 1 | 2147483648u);
				}
				else
				{
					uint num4 = Class6.Class7.smethod_0((void*)ptr5, 4u);
					uint num3 = (num4 >> 12 ^ num4) & 4095u;
					byte* ptr13 = *(IntPtr*)(ptr6 + (ulong)num3 * (ulong)((long)sizeof(byte*)) / (ulong)sizeof(byte*));
					*(IntPtr*)(ptr6 + (ulong)num3 * (ulong)((long)sizeof(byte*)) / (ulong)sizeof(byte*)) = ptr5;
					bool flag;
					if (BitConverter.IsLittleEndian)
					{
						flag = ((long)(ptr5 - ptr13) <= 131071L && (long)(ptr5 - ptr13) > 3L && ((*(uint*)ptr13 ^ *(uint*)ptr5) & 16777215u) == 0u);
					}
					else
					{
						flag = ((long)(ptr5 - ptr13) <= 131071L && (long)(ptr5 - ptr13) > 3L && *ptr5 == *ptr13 && ptr5[1] == ptr13[1] && ptr5[2] == ptr13[2]);
					}
					if (flag)
					{
						uint num5 = (uint)((long)(ptr5 - ptr13));
						if (BitConverter.IsLittleEndian)
						{
							flag = (*(uint*)ptr13 != *(uint*)ptr5);
						}
						else
						{
							flag = (ptr13[3] != ptr5[3]);
						}
						if (flag)
						{
							if (num5 <= 63u)
							{
								*ptr7 = (byte)(num5 << 2);
								ptr7++;
								num2 = (num2 >> 1 | 2147483648u);
								ptr5 += 3;
							}
							else if (num5 <= 16383u)
							{
								uint uint_2 = num5 << 2 | 1u;
								Class6.Class7.smethod_1(uint_2, (void*)ptr7, 2u);
								ptr7 += 2;
								num2 = (num2 >> 1 | 2147483648u);
								ptr5 += 3;
							}
							else
							{
								*ptr7 = *ptr5;
								ptr7++;
								ptr5++;
								num2 >>= 1;
							}
						}
						else
						{
							num2 = (num2 >> 1 | 2147483648u);
							uint num6 = 3u;
							while (ptr13[num6] == ptr5[num6] && num6 < 2050u)
							{
								num6 += 1u;
							}
							ptr5 += num6;
							if (num6 <= 18u && num5 <= 1023u)
							{
								uint uint_3 = num6 - 3u << 2 | num5 << 6 | 2u;
								Class6.Class7.smethod_1(uint_3, (void*)ptr7, 2u);
								ptr7 += 2;
							}
							else if (num6 <= 34u && num5 <= 65535u)
							{
								uint uint_4 = num6 - 3u << 3 | num5 << 8 | 3u;
								Class6.Class7.smethod_1(uint_4, (void*)ptr7, 3u);
								ptr7 += 3;
							}
							else if (num6 >= 3u)
							{
								uint uint_5 = num6 - 3u << 4 | num5 << 15 | 7u;
								Class6.Class7.smethod_1(uint_5, (void*)ptr7, 4u);
								ptr7 += 4;
							}
						}
					}
					else
					{
						*ptr7 = *ptr5;
						ptr7++;
						ptr5++;
						num2 >>= 1;
					}
				}
			}
			while (ptr5 == ptr4)
			{
				if ((num2 & 1u) == 1u)
				{
					Class6.Class7.smethod_1(num2 >> 1 | 2147483648u, (void*)pVoid_, 4u);
					pVoid_ = ptr7;
					ptr7 += 4;
					num2 = 2147483648u;
				}
				*ptr7 = *ptr5;
				ptr7++;
				ptr5++;
				num2 >>= 1;
			}
			while ((num2 & 1u) != 1u)
			{
				num2 >>= 1;
			}
			Class6.Class7.smethod_1(num2 >> 1 | 2147483648u, (void*)pVoid_, 4u);
			ptr7 += 4;
			Class6.Class7.smethod_1(1u, (void*)(ptr10 + 4), 4u);
			Class6.Class7.smethod_1((uint)((long)(ptr7 - ptr2) - 1L + 4L), (void*)(ptr10 + 2), 4u);
			Class6.Class7.smethod_6((void*)((byte*)((byte*)ptr2 + Class6.Class7.smethod_0((void*)(ptr10 + 2), 4u)) - 4), Class2.smethod_11(576));
			ptr = null;
			ptr2 = null;
			return Class6.Class7.smethod_9(byte_1);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000059D4 File Offset: 0x00003BD4
		private unsafe static uint smethod_12(byte[] byte_0, uint uint_0, byte[] byte_1)
		{
			byte* ptr;
			if (byte_0 != null && byte_0.Length != 0)
			{
				fixed (byte* ptr = &byte_0[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			byte* ptr2;
			if (byte_1 != null && byte_1.Length != 0)
			{
				fixed (byte* ptr2 = &byte_1[0])
				{
				}
			}
			else
			{
				ptr2 = null;
			}
			byte* ptr3 = ptr + uint_0;
			uint num = 32u;
			byte* ptr4 = ptr3 + 32;
			byte* ptr5 = ptr2;
			uint* ptr6 = (uint*)ptr3;
			byte* ptr7 = ptr2 + Class6.Class7.smethod_0((void*)(ptr6 + 3), 4u);
			uint num2 = 1u;
			uint[] array = new uint[]
			{
				4u,
				0u,
				1u,
				0u,
				2u,
				0u,
				1u,
				0u,
				3u,
				0u,
				1u,
				0u,
				2u,
				0u,
				1u,
				0u
			};
			byte* ptr8 = ptr7 - 4;
			uint result;
			if (!Class6.Class7.smethod_3((void*)ptr6, Class2.smethod_11(576)))
			{
				result = 0u;
			}
			else if (Class6.Class7.smethod_0((void*)(ptr6 + 1), 4u) != 3u)
			{
				result = 0u;
			}
			else if (!Class6.Class7.smethod_3((void*)(ptr3 + Class6.Class7.smethod_0((void*)(ptr6 + 2), 4u) - 4), Class2.smethod_11(576)))
			{
				result = 0u;
			}
			else if (Class6.Class7.smethod_0((void*)(ptr6 + 4), 4u) != 1u)
			{
				Class6.Class7.smethod_5((void*)ptr2, (void*)(ptr3 + num), Class6.Class7.smethod_0((void*)(ptr6 + 3), 4u));
				result = Class6.Class7.smethod_0((void*)(ptr6 + 3), 4u);
			}
			else if (ptr5 >= ptr8)
			{
				ptr4 += 4;
				while (ptr5 < ptr7)
				{
					*ptr5 = *ptr4;
					ptr5++;
					ptr4++;
				}
				result = (uint)((long)(ptr5 - ptr2));
			}
			else
			{
				for (;;)
				{
					if (num2 == 1u)
					{
						num2 = Class6.Class7.smethod_0((void*)ptr4, 4u);
						ptr4 += 4;
					}
					uint num3 = Class6.Class7.smethod_0((void*)ptr4, 4u);
					if ((num2 & 1u) == 1u)
					{
						num2 >>= 1;
						if ((num3 & 3u) == 0u)
						{
							uint num4 = (num3 & 255u) >> 2;
							Class6.Class7.smethod_7(ptr5, ptr5 - num4, 3u);
							ptr5 += 3;
							ptr4++;
						}
						else if ((num3 & 2u) == 0u)
						{
							uint num4 = (num3 & 65535u) >> 2;
							Class6.Class7.smethod_7(ptr5, ptr5 - num4, 3u);
							ptr5 += 3;
							ptr4 += 2;
						}
						else if ((num3 & 1u) == 0u)
						{
							uint num4 = (num3 & 65535u) >> 6;
							uint num5 = (num3 >> 2 & 15u) + 3u;
							Class6.Class7.smethod_7(ptr5, ptr5 - num4, num5);
							ptr5 += num5;
							ptr4 += 2;
						}
						else if ((num3 & 4u) == 0u)
						{
							uint num4 = (num3 & 16777215u) >> 8;
							uint num5 = (num3 >> 3 & 31u) + 3u;
							Class6.Class7.smethod_7(ptr5, ptr5 - num4, num5);
							ptr5 += num5;
							ptr4 += 3;
						}
						else if ((num3 & 8u) == 0u)
						{
							uint num4 = num3 >> 15;
							uint num5 = (num3 >> 4 & 2047u) + 3u;
							Class6.Class7.smethod_7(ptr5, ptr5 - num4, num5);
							ptr5 += num5;
							ptr4 += 4;
						}
						else
						{
							byte byte_2 = (byte)(num3 >> 16);
							uint num5 = num3 >> 4 & 4095u;
							Class6.Class7.smethod_4((void*)ptr5, byte_2, num5);
							ptr5 += num5;
							ptr4 += 3;
						}
					}
					else
					{
						Class6.Class7.smethod_7(ptr5, ptr4, 4u);
						ptr5 += array[(int)((UIntPtr)(num2 & 15u))];
						ptr4 += array[(int)((UIntPtr)(num2 & 15u))];
						num2 >>= (int)((byte)array[(int)((UIntPtr)(num2 & 15u))]);
						if (ptr5 >= ptr8)
						{
							break;
						}
					}
				}
				while (ptr5 < ptr7)
				{
					if (num2 == 1u)
					{
						ptr4 += 4;
						num2 = 2147483648u;
					}
					*ptr5 = *ptr4;
					ptr5++;
					ptr4++;
					num2 >>= 1;
				}
				result = (uint)((long)(ptr5 - ptr2));
			}
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005D38 File Offset: 0x00003F38
		private static byte[] smethod_13(string string_0)
		{
			byte[] array = null;
			FileStream fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
			}
			finally
			{
				fileStream.Close();
			}
			return array;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005D84 File Offset: 0x00003F84
		public static byte[] smethod_14(string string_0)
		{
			byte[] byte_ = Class6.Class7.smethod_13(string_0);
			return Class6.Class7.smethod_16(byte_);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005DA0 File Offset: 0x00003FA0
		public static byte[] smethod_15(string string_0)
		{
			byte[] byte_ = Class6.Class7.smethod_13(string_0);
			return Class6.Class7.smethod_17(byte_);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000242E File Offset: 0x0000062E
		public static byte[] smethod_16(byte[] byte_0)
		{
			return Class6.Class7.smethod_19(byte_0, 0u, Convert.ToUInt32(byte_0.Length));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000243F File Offset: 0x0000063F
		public static byte[] smethod_17(byte[] byte_0)
		{
			return Class6.Class7.smethod_20(byte_0, 0u);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005DBC File Offset: 0x00003FBC
		internal static object smethod_18(byte[] byte_0)
		{
			return typeof(Assembly).GetMethod(Class2.smethod_11(588), new Type[]
			{
				typeof(byte[])
			}).Invoke(null, new object[]
			{
				byte_0
			});
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005E0C File Offset: 0x0000400C
		public static byte[] smethod_19(byte[] byte_0, uint uint_0, uint uint_1)
		{
			byte[] array = new byte[uint_1 + 36000u];
			uint num = Class6.Class7.smethod_11(byte_0, uint_0, array, uint_1);
			byte[] array2 = new byte[num];
			for (uint num2 = 0u; num2 < num; num2 += 1u)
			{
				array2[(int)((UIntPtr)num2)] = array[(int)((UIntPtr)num2)];
			}
			return array2;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005E50 File Offset: 0x00004050
		public static byte[] smethod_20(byte[] byte_0, uint uint_0)
		{
			uint num = Class6.Class7.smethod_10(byte_0, uint_0);
			byte[] array = null;
			if (num != 0u)
			{
				array = new byte[num];
				Class6.Class7.smethod_12(byte_0, uint_0, array);
			}
			return array;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000223C File Offset: 0x0000043C
		public Class7()
		{
			Class5.WNqmTthz2i6ny();
			base..ctor();
		}
	}
}

using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000008 RID: 8
internal class Class2
{
	// Token: 0x06000015 RID: 21 RVA: 0x00002844 File Offset: 0x00000A44
	static Class2()
	{
		Class2.JhHvOiKbi = typeof(Class2).Assembly;
		Class2.uint_0 = new uint[]
		{
			3614090360u,
			3905402710u,
			606105819u,
			3250441966u,
			4118548399u,
			1200080426u,
			2821735955u,
			4249261313u,
			1770035416u,
			2336552879u,
			4294925233u,
			2304563134u,
			1804603682u,
			4254626195u,
			2792965006u,
			1236535329u,
			4129170786u,
			3225465664u,
			643717713u,
			3921069994u,
			3593408605u,
			38016083u,
			3634488961u,
			3889429448u,
			568446438u,
			3275163606u,
			4107603335u,
			1163531501u,
			2850285829u,
			4243563512u,
			1735328473u,
			2368359562u,
			4294588738u,
			2272392833u,
			1839030562u,
			4259657740u,
			2763975236u,
			1272893353u,
			4139469664u,
			3200236656u,
			681279174u,
			3936430074u,
			3572445317u,
			76029189u,
			3654602809u,
			3873151461u,
			530742520u,
			3299628645u,
			4096336452u,
			1126891415u,
			2878612391u,
			4237533241u,
			1700485571u,
			2399980690u,
			4293915773u,
			2240044497u,
			1873313359u,
			4264355552u,
			2734768916u,
			1309151649u,
			4149444226u,
			3174756917u,
			718787259u,
			3951481745u
		};
		Class2.bool_0 = false;
		Class2.bool_5 = false;
		Class2.hGuHvuTlc = new byte[0];
		Class2.byte_0 = new byte[0];
		Class2.byte_2 = new byte[0];
		Class2.byte_1 = new byte[0];
		Class2.intptr_0 = IntPtr.Zero;
		Class2.uUtrpcVp3 = IntPtr.Zero;
		Class2.string_0 = new string[0];
		Class2.int_2 = new int[0];
		Class2.int_4 = 1;
		Class2.bool_1 = false;
		Class2.sortedList_0 = new SortedList();
		Class2.int_0 = 0;
		Class2.long_1 = 0L;
		Class2.delegate1_1 = null;
		Class2.delegate1_0 = null;
		Class2.long_0 = 0L;
		Class2.int_1 = 0;
		Class2.bool_3 = false;
		Class2.bool_2 = false;
		Class2.int_3 = 0;
		Class2.intptr_1 = IntPtr.Zero;
		Class2.firstrundone = false;
		Class2.hashtable_0 = new Hashtable();
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002278 File Offset: 0x00000478
	private void l4smTthXLXbAC()
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002978 File Offset: 0x00000B78
	internal static byte[] smethod_0(byte[] byte_3)
	{
		uint[] array = new uint[16];
		int num = 448 - byte_3.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0u)
		{
			num2 = 512u;
		}
		uint num3 = (uint)((long)byte_3.Length + (long)((ulong)(num2 / 8u)) + 8L);
		ulong num4 = (ulong)((long)byte_3.Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < byte_3.Length; i++)
		{
			array2[i] = byte_3[i];
		}
		byte[] array3 = array2;
		int num5 = byte_3.Length;
		array3[num5] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num3 - (ulong)((long)j)))))] = (byte)(num4 >> (8 - j) * 8 & 255UL);
		}
		uint num6 = (uint)(array2.Length * 8 / 32);
		uint num7 = 1732584193u;
		uint num8 = 4023233417u;
		uint num9 = 2562383102u;
		uint num10 = 271733878u;
		for (uint num11 = 0u; num11 < num6 / 16u; num11 += 1u)
		{
			uint num12 = num11 << 6;
			for (uint num13 = 0u; num13 < 61u; num13 += 4u)
			{
				array[(int)((UIntPtr)(num13 >> 2))] = (uint)((int)array2[(int)((UIntPtr)(num12 + (num13 + 3u)))] << 24 | (int)array2[(int)((UIntPtr)(num12 + (num13 + 2u)))] << 16 | (int)array2[(int)((UIntPtr)(num12 + (num13 + 1u)))] << 8 | (int)array2[(int)((UIntPtr)(num12 + num13))]);
			}
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			uint num17 = num10;
			Class2.smethod_1(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			Class2.smethod_1(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			Class2.smethod_1(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			Class2.smethod_1(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			Class2.smethod_1(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			Class2.smethod_1(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			Class2.smethod_1(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			Class2.smethod_1(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			Class2.smethod_1(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			Class2.smethod_1(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			Class2.smethod_1(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			Class2.smethod_1(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			Class2.smethod_1(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			Class2.smethod_1(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			Class2.smethod_1(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			Class2.smethod_1(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			Class2.smethod_2(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			Class2.smethod_2(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			Class2.smethod_2(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			Class2.smethod_2(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			Class2.smethod_2(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			Class2.smethod_2(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			Class2.smethod_2(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			Class2.smethod_2(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			Class2.smethod_2(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			Class2.smethod_2(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			Class2.smethod_2(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			Class2.smethod_2(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			Class2.smethod_2(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			Class2.smethod_2(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			Class2.smethod_2(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			Class2.smethod_2(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			Class2.smethod_3(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			Class2.smethod_3(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			Class2.smethod_3(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			Class2.smethod_3(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			Class2.smethod_3(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			Class2.smethod_3(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			Class2.smethod_3(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			Class2.smethod_3(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			Class2.smethod_3(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			Class2.smethod_3(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			Class2.smethod_3(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			Class2.smethod_3(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			Class2.smethod_3(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			Class2.smethod_3(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			Class2.smethod_3(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			Class2.smethod_3(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			Class2.smethod_4(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			Class2.smethod_4(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			Class2.smethod_4(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			Class2.smethod_4(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			Class2.smethod_4(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			Class2.smethod_4(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			Class2.smethod_4(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			Class2.smethod_4(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			Class2.smethod_4(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			Class2.smethod_4(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			Class2.smethod_4(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			Class2.smethod_4(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			Class2.smethod_4(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			Class2.smethod_4(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			Class2.smethod_4(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			Class2.smethod_4(ref num8, num9, num10, num7, 9u, 21, 64u, array);
			num7 += num14;
			num8 += num15;
			num9 += num16;
			num10 += num17;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num10), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000227A File Offset: 0x0000047A
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[(int)((UIntPtr)uint_5)] + Class2.uint_0[(int)((UIntPtr)(uint_6 - 1u))], ushort_0);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000022A5 File Offset: 0x000004A5
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[(int)((UIntPtr)uint_5)] + Class2.uint_0[(int)((UIntPtr)(uint_6 - 1u))], ushort_0);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000022D0 File Offset: 0x000004D0
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[(int)((UIntPtr)uint_5)] + Class2.uint_0[(int)((UIntPtr)(uint_6 - 1u))], ushort_0);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000022F8 File Offset: 0x000004F8
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class2.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[(int)((UIntPtr)uint_5)] + Class2.uint_0[(int)((UIntPtr)(uint_6 - 1u))], ushort_0);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002321 File Offset: 0x00000521
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return uint_1 >> (int)(32 - ushort_0) | uint_1 << (int)ushort_0;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002333 File Offset: 0x00000533
	internal static bool smethod_6()
	{
		if (!Class2.bool_0)
		{
			Class2.smethod_8();
			Class2.bool_0 = true;
		}
		return Class2.bool_5;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0000301C File Offset: 0x0000121C
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm result = null;
		if (Class2.smethod_6())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
		}
		return result;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003070 File Offset: 0x00001270
	internal static void smethod_8()
	{
		try
		{
			Class2.bool_5 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000234C File Offset: 0x0000054C
	internal static byte[] smethod_9(byte[] byte_3)
	{
		if (!Class2.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_3);
		}
		return Class2.smethod_0(byte_3);
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002367 File Offset: 0x00000567
	private static uint smethod_10(uint uint_1)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000030A0 File Offset: 0x000012A0
	[Class2.Attribute0(typeof(Class2.Attribute0.Class3<object>[]))]
	internal static string smethod_11(int int_5)
	{
		if (Class2.byte_2.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(Class2.JhHvOiKbi.GetManifestResourceStream("DJucFXL0oclpIZNx7I.loluK2421PM52EkXJW"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			byte[] array2 = new byte[32];
			array2[0] = 102;
			array2[0] = 128;
			array2[0] = 177;
			array2[0] = 147;
			array2[0] = 230;
			array2[1] = 108;
			array2[1] = 162;
			array2[1] = 131;
			array2[1] = 157;
			array2[2] = 108;
			array2[2] = 97;
			array2[2] = 226;
			array2[3] = 121;
			array2[3] = 132;
			array2[3] = 150;
			array2[3] = 136;
			array2[4] = 164;
			array2[4] = 154;
			array2[4] = 204;
			array2[4] = 122;
			array2[4] = 193;
			array2[5] = 122;
			array2[5] = 107;
			array2[5] = 16;
			array2[5] = 248;
			array2[6] = 127;
			array2[6] = 86;
			array2[6] = 123;
			array2[6] = 121;
			array2[6] = 157;
			array2[6] = 82;
			array2[7] = 164;
			array2[7] = 148;
			array2[7] = 197;
			array2[8] = 125;
			array2[8] = 100;
			array2[8] = 20;
			array2[9] = 116;
			array2[9] = 107;
			array2[9] = 178;
			array2[10] = 99;
			array2[10] = 164;
			array2[10] = 99;
			array2[10] = 96;
			array2[10] = 234;
			array2[11] = 114;
			array2[11] = 131;
			array2[11] = 96;
			array2[11] = 46;
			array2[12] = 140;
			array2[12] = 166;
			array2[12] = 44;
			array2[12] = 120;
			array2[12] = 113;
			array2[12] = 197;
			array2[13] = 97;
			array2[13] = 133;
			array2[13] = 158;
			array2[13] = 112;
			array2[13] = 74;
			array2[13] = 150;
			array2[14] = 150;
			array2[14] = 135;
			array2[14] = 28;
			array2[14] = 115;
			array2[14] = 121;
			array2[14] = 246;
			array2[15] = 166;
			array2[15] = 155;
			array2[15] = 118;
			array2[15] = 209;
			array2[16] = 168;
			array2[16] = 151;
			array2[16] = 81;
			array2[17] = 117;
			array2[17] = 103;
			array2[17] = 119;
			array2[17] = 98;
			array2[17] = 132;
			array2[17] = 168;
			array2[18] = 94;
			array2[18] = 72;
			array2[18] = 150;
			array2[18] = 84;
			array2[18] = 134;
			array2[18] = 192;
			array2[19] = 68;
			array2[19] = 94;
			array2[19] = 85;
			array2[19] = 137;
			array2[19] = 125;
			array2[19] = 95;
			array2[20] = 92;
			array2[20] = 140;
			array2[20] = 157;
			array2[20] = 138;
			array2[21] = 132;
			array2[21] = 126;
			array2[21] = 124;
			array2[21] = 39;
			array2[22] = 231;
			array2[22] = 147;
			array2[22] = 44;
			array2[23] = 146;
			array2[23] = 138;
			array2[23] = 163;
			array2[23] = 11;
			array2[23] = 158;
			array2[23] = 185;
			array2[24] = 169;
			array2[24] = 152;
			array2[24] = 94;
			array2[24] = 160;
			array2[25] = 143;
			array2[25] = 158;
			array2[25] = 165;
			array2[25] = 244;
			array2[26] = 105;
			array2[26] = 94;
			array2[26] = 202;
			array2[27] = 165;
			array2[27] = 27;
			array2[27] = 33;
			array2[27] = 45;
			array2[28] = 100;
			array2[28] = 223;
			array2[28] = 232;
			array2[29] = 131;
			array2[29] = 102;
			array2[29] = 148;
			array2[29] = 94;
			array2[30] = 154;
			array2[30] = 139;
			array2[30] = 136;
			array2[30] = 95;
			array2[30] = 152;
			array2[31] = 124;
			array2[31] = 123;
			array2[31] = 10;
			array2[31] = 91;
			array2[31] = 101;
			array2[31] = 201;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 102;
			array4[0] = 96;
			array4[0] = 142;
			array4[0] = 79;
			array4[1] = 156;
			array4[1] = 88;
			array4[1] = 230;
			array4[1] = 176;
			array4[1] = 74;
			array4[1] = 219;
			array4[2] = 95;
			array4[2] = 59;
			array4[2] = 132;
			array4[2] = 53;
			array4[3] = 125;
			array4[3] = 235;
			array4[3] = 145;
			array4[4] = 161;
			array4[4] = 163;
			array4[4] = 122;
			array4[4] = 5;
			array4[5] = 134;
			array4[5] = 90;
			array4[5] = 138;
			array4[6] = 100;
			array4[6] = 108;
			array4[6] = 130;
			array4[6] = 91;
			array4[7] = 157;
			array4[7] = 210;
			array4[7] = 114;
			array4[7] = 125;
			array4[7] = 110;
			array4[7] = 67;
			array4[8] = 90;
			array4[8] = 107;
			array4[8] = 134;
			array4[8] = 54;
			array4[8] = 216;
			array4[9] = 89;
			array4[9] = 144;
			array4[9] = 135;
			array4[9] = 203;
			array4[10] = 108;
			array4[10] = 133;
			array4[10] = 106;
			array4[11] = 100;
			array4[11] = 119;
			array4[11] = 241;
			array4[12] = 120;
			array4[12] = 123;
			array4[12] = 161;
			array4[12] = 38;
			array4[12] = 49;
			array4[13] = 125;
			array4[13] = 69;
			array4[13] = 96;
			array4[13] = 95;
			array4[13] = 119;
			array4[13] = 170;
			array4[14] = 28;
			array4[14] = 90;
			array4[14] = 23;
			array4[14] = 156;
			array4[15] = 117;
			array4[15] = 106;
			array4[15] = 90;
			byte[] array5 = array4;
			Array.Reverse(array5);
			byte[] publicKeyToken = Class2.JhHvOiKbi.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
			{
				array5[1] = publicKeyToken[0];
				array5[3] = publicKeyToken[1];
				array5[5] = publicKeyToken[2];
				array5[7] = publicKeyToken[3];
				array5[9] = publicKeyToken[4];
				array5[11] = publicKeyToken[5];
				array5[13] = publicKeyToken[6];
				array5[15] = publicKeyToken[7];
			}
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] ^= array5[i];
			}
			if (int_5 == -1)
			{
				SymmetricAlgorithm symmetricAlgorithm = Class2.smethod_7();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				Class2.byte_2 = memoryStream.ToArray();
				memoryStream.Close();
				cryptoStream.Close();
				array = Class2.byte_2;
			}
			int num = array.Length % 4;
			int num2 = array.Length / 4;
			byte[] array6 = new byte[array.Length];
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
						num11 |= (uint)array[array.Length - (1 + k)];
					}
				}
				else
				{
					num4 += num8;
					num7 = (uint)num6;
					num11 = (uint)((int)array[(int)((UIntPtr)(num7 + 3u))] << 24 | (int)array[(int)((UIntPtr)(num7 + 2u))] << 16 | (int)array[(int)((UIntPtr)(num7 + 1u))] << 8 | (int)array[(int)((UIntPtr)num7)]);
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
						array6[num6 + l] = (byte)((num21 & num9) >> num10);
					}
				}
				else
				{
					uint num22 = num4 ^ num11;
					array6[num6] = (byte)(num22 & 255u);
					array6[num6 + 1] = (byte)((num22 & 65280u) >> 8);
					array6[num6 + 2] = (byte)((num22 & 16711680u) >> 16);
					array6[num6 + 3] = (byte)((num22 & 4278190080u) >> 24);
				}
			}
			Class2.byte_2 = array6;
		}
		int count = BitConverter.ToInt32(Class2.byte_2, int_5);
		try
		{
			return Encoding.Unicode.GetString(Class2.byte_2, int_5 + 4, count);
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00003E10 File Offset: 0x00002010
	[Class2.Attribute0(typeof(Class2.Attribute0.Class3<object>[]))]
	internal static string smethod_12(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00003E40 File Offset: 0x00002040
	private static void nAaFwtUps()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00003E6C File Offset: 0x0000206C
	private static Delegate smethod_13(IntPtr intptr_2, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[]
		{
			intptr_2,
			type_0
		});
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00003ED0 File Offset: 0x000020D0
	internal static object smethod_14(Assembly assembly_0)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_0).Location))
			{
				return ((Assembly)assembly_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString()))
			{
				return assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00003FE0 File Offset: 0x000021E0
	[Class2.Attribute0(typeof(Class2.Attribute0.Class3<object>[]))]
	private static byte[] smethod_15(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			long length = fileStream.Length;
			int i = (int)length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00004048 File Offset: 0x00002248
	[Class2.Attribute0(typeof(Class2.Attribute0.Class3<object>[]))]
	private static byte[] smethod_16(byte[] byte_3)
	{
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class2.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			26,
			108,
			114,
			44,
			93,
			100,
			35,
			33,
			147,
			248,
			250,
			176,
			16,
			27,
			11,
			213,
			216,
			76,
			53,
			93,
			9,
			72,
			211,
			18,
			69,
			238,
			88,
			53,
			214,
			111,
			74,
			254
		};
		symmetricAlgorithm.IV = new byte[]
		{
			136,
			148,
			199,
			77,
			140,
			47,
			2,
			141,
			102,
			148,
			23,
			113,
			217,
			104,
			87,
			47
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_3, 0, byte_3.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002373 File Offset: 0x00000573
	private byte[] method_0()
	{
		return null;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002373 File Offset: 0x00000573
	private byte[] method_1()
	{
		return null;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x000040B8 File Offset: 0x000022B8
	private byte[] method_2()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000040F8 File Offset: 0x000022F8
	private byte[] method_3()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00004138 File Offset: 0x00002338
	private byte[] method_4()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00004178 File Offset: 0x00002378
	private byte[] method_5()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600002F RID: 47 RVA: 0x000041B8 File Offset: 0x000023B8
	internal byte[] method_6()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000041F8 File Offset: 0x000023F8
	internal byte[] method_7()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[]
			{
				1,
				2
			};
		}
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002373 File Offset: 0x00000573
	internal byte[] method_8()
	{
		return null;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002373 File Offset: 0x00000573
	internal byte[] IdsjjcYpS()
	{
		return null;
	}

	// Token: 0x0400000C RID: 12
	private static uint[] uint_0;

	// Token: 0x0400000D RID: 13
	private static bool bool_0;

	// Token: 0x0400000E RID: 14
	private static byte[] byte_0;

	// Token: 0x0400000F RID: 15
	private static IntPtr intptr_0;

	// Token: 0x04000010 RID: 16
	private static string[] string_0;

	// Token: 0x04000011 RID: 17
	private static bool bool_1;

	// Token: 0x04000012 RID: 18
	private static int int_0;

	// Token: 0x04000013 RID: 19
	private static bool bool_2;

	// Token: 0x04000014 RID: 20
	internal static Hashtable hashtable_0;

	// Token: 0x04000015 RID: 21
	private static IntPtr uUtrpcVp3;

	// Token: 0x04000016 RID: 22
	private static byte[] hGuHvuTlc;

	// Token: 0x04000017 RID: 23
	private static int int_1;

	// Token: 0x04000018 RID: 24
	private static bool bool_3;

	// Token: 0x04000019 RID: 25
	[Class2.Attribute0(typeof(Class2.Attribute0.Class3<object>[]))]
	private static bool firstrundone;

	// Token: 0x0400001A RID: 26
	private static Assembly JhHvOiKbi;

	// Token: 0x0400001B RID: 27
	internal static Class2.Delegate1 delegate1_0;

	// Token: 0x0400001C RID: 28
	internal static Class2.Delegate1 delegate1_1;

	// Token: 0x0400001D RID: 29
	private static bool bool_4 = false;

	// Token: 0x0400001E RID: 30
	private static IntPtr intptr_1;

	// Token: 0x0400001F RID: 31
	private static int[] int_2;

	// Token: 0x04000020 RID: 32
	private static int int_3;

	// Token: 0x04000021 RID: 33
	private static int int_4;

	// Token: 0x04000022 RID: 34
	private static SortedList sortedList_0;

	// Token: 0x04000023 RID: 35
	private static bool bool_5;

	// Token: 0x04000024 RID: 36
	private static long long_0;

	// Token: 0x04000025 RID: 37
	private static byte[] byte_1;

	// Token: 0x04000026 RID: 38
	private static byte[] byte_2;

	// Token: 0x04000027 RID: 39
	private static long long_1;

	// Token: 0x02000009 RID: 9
	internal class Attribute0 : Attribute
	{
		// Token: 0x06000034 RID: 52 RVA: 0x0000237E File Offset: 0x0000057E
		[Class2.Attribute0(typeof(Class2.Attribute0.Class3<object>[]))]
		public Attribute0(object object_0)
		{
			Class5.WNqmTthz2i6ny();
			base..ctor();
		}

		// Token: 0x0200000A RID: 10
		internal class Class3<T>
		{
			// Token: 0x06000035 RID: 53 RVA: 0x0000223C File Offset: 0x0000043C
			public Class3()
			{
				Class5.WNqmTthz2i6ny();
				base..ctor();
			}
		}
	}

	// Token: 0x0200000B RID: 11
	internal class Class4
	{
		// Token: 0x06000036 RID: 54 RVA: 0x0000238B File Offset: 0x0000058B
		[Class2.Attribute0(typeof(Class2.Attribute0.Class3<object>[]))]
		internal static void ce4DmfsmSrOT856tDgfrkMb()
		{
			if (!(Class2.Class4.smethod_0(Convert.ToBase64String(Class2.JhHvOiKbi.GetName().GetPublicKeyToken()), Class2.smethod_11(484)) != Class2.smethod_11(490)))
			{
				return;
			}
			for (;;)
			{
				Class2.Class4.ce4DmfsmSrOT856tDgfrkMb();
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004238 File Offset: 0x00002438
		[Class2.Attribute0(typeof(Class2.Attribute0.Class3<object>[]))]
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class2.smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class2.smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000223C File Offset: 0x0000043C
		public Class4()
		{
			Class5.WNqmTthz2i6ny();
			base..ctor();
		}
	}

	// Token: 0x0200000C RID: 12
	// (Invoke) Token: 0x0600003A RID: 58
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate1(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x0200000D RID: 13
	// (Invoke) Token: 0x0600003E RID: 62
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate2();

	// Token: 0x0200000E RID: 14
	internal struct Struct0
	{
		// Token: 0x04000028 RID: 40
		internal bool bool_0;

		// Token: 0x04000029 RID: 41
		internal byte[] byte_0;
	}

	// Token: 0x0200000F RID: 15
	[Flags]
	private enum Enum0
	{

	}
}

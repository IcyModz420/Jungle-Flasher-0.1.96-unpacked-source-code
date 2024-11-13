using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ns0;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00001000 File Offset: 0x00001000
	public static byte smethod_0(ushort ushort_0)
	{
		byte result;
		if (ushort_0 < 10)
		{
			result = <Module>.smethod_22(ushort_0);
		}
		else
		{
			result = <Module>.smethod_151(ushort_0);
		}
		return result;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00001028 File Offset: 0x00001028
	public static ushort smethod_1(ushort ushort_0)
	{
		ushort result;
		if (ushort_0 < 10)
		{
			result = <Module>.smethod_23(ushort_0);
		}
		else
		{
			result = <Module>.smethod_152(ushort_0);
		}
		return result;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00001050 File Offset: 0x00001050
	public static void smethod_2(ushort ushort_0, byte byte_0)
	{
		if (ushort_0 < 10)
		{
			<Module>.smethod_26(ushort_0, byte_0);
		}
		else
		{
			<Module>.smethod_154(ushort_0, byte_0);
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00001074 File Offset: 0x00001074
	public static void smethod_3(ushort ushort_0, ushort ushort_1)
	{
		if (ushort_0 < 10)
		{
			<Module>.smethod_27(ushort_0, ushort_1);
		}
		else
		{
			<Module>.smethod_155(ushort_0, ushort_1);
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00001098 File Offset: 0x00001098
	public unsafe static void smethod_4(byte* pByte_0, byte byte_0)
	{
		Struct3 @struct = 0;
		initblk(ref @struct + 1, 0, 63);
		Struct3 struct2 = 0;
		initblk(ref struct2 + 1, 0, 63);
		@struct = 64;
		*(ref @struct + 1) = (byte)((sbyte)byte_0);
		if (<Module>.smethod_30((sbyte*)(&@struct), 2, (sbyte*)(&struct2), (int)byte_0) == 1)
		{
			<Module>.memcpy((void*)pByte_0, (void*)(&struct2), (uint)byte_0);
		}
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000010E8 File Offset: 0x000010E8
	public unsafe static void smethod_5(byte* pByte_0, byte byte_0)
	{
		Struct3 @struct = 0;
		initblk(ref @struct + 1, 0, 63);
		Struct3 struct2 = 0;
		initblk(ref struct2 + 1, 0, 63);
		int int_ = (int)(byte_0 + 2);
		int num = 2;
		@struct = 65;
		*(ref @struct + 1) = (byte)((sbyte)byte_0);
		<Module>.memcpy(ref @struct + 2, (void*)pByte_0, (uint)byte_0);
		if (<Module>.smethod_30((sbyte*)(&@struct), int_, (sbyte*)(&struct2), 2) != 1 || num == 2)
		{
		}
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00001144 File Offset: 0x00001144
	public static int smethod_6()
	{
		return <Module>.timeGetTime();
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000115C File Offset: 0x0000115C
	public unsafe static int smethod_7(byte* pByte_0, ushort ushort_0, byte byte_0, byte byte_1, GStruct3* pGstruct3_0)
	{
		uint num = <Module>.timeGetTime();
		byte b;
		do
		{
			b = <Module>.smethod_0(ushort_0);
			if ((b & byte_0) == byte_1)
			{
				goto IL_36;
			}
		}
		while (<Module>.timeGetTime() - num < *(int*)(pGstruct3_0 + 40 / sizeof(GStruct3)));
		if (pByte_0 != null)
		{
			*pByte_0 = b;
		}
		*(int*)(pGstruct3_0 + 24 / sizeof(GStruct3)) = 2;
		return 1;
		IL_36:
		if (pByte_0 != null)
		{
			*pByte_0 = b;
		}
		return 0;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000011A8 File Offset: 0x000011A8
	public unsafe static int smethod_8(byte byte_0, byte byte_1, GStruct4* pGstruct4_0, GStruct4* pGstruct4_1, byte byte_2, GStruct3* pGstruct3_0)
	{
		int result;
		if (<Module>.smethod_7(null, *(ushort*)(pGstruct3_0 + 20 / sizeof(GStruct3)), byte_2 | 136, byte_2, pGstruct3_0) != null)
		{
			*(int*)(pGstruct3_0 + 24 / sizeof(GStruct3)) = 2;
			result = 1;
		}
		else
		{
			if (pGstruct4_0 != null)
			{
				if ((*(byte*)pGstruct4_0 & 1) != 0)
				{
					if ((*(byte*)pGstruct4_0 & 128) != 0)
					{
						<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 4 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 4 / sizeof(GStruct4)) >> 8));
					}
					<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 4 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 4 / sizeof(GStruct4))));
				}
				if ((*(byte*)pGstruct4_0 & 2) != 0)
				{
					if ((*(byte*)pGstruct4_0 & 128) != 0)
					{
						<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 6 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 12 / sizeof(GStruct4)) >> 8));
					}
					<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 6 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 12 / sizeof(GStruct4))));
				}
				if ((*(byte*)pGstruct4_0 & 4) != 0)
				{
					if ((*(byte*)pGstruct4_0 & 128) != 0)
					{
						<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 8 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 10 / sizeof(GStruct4)) >> 8));
					}
					<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 8 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 10 / sizeof(GStruct4))));
				}
				if ((*(byte*)pGstruct4_0 & 8) != 0)
				{
					if ((*(byte*)pGstruct4_0 & 128) != 0)
					{
						<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 10 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 8 / sizeof(GStruct4)) >> 8));
					}
					<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 10 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 8 / sizeof(GStruct4))));
				}
				if ((*(byte*)pGstruct4_0 & 16) != 0)
				{
					if ((*(byte*)pGstruct4_0 & 128) != 0)
					{
						<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 12 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 6 / sizeof(GStruct4)) >> 8));
					}
					<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 12 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 6 / sizeof(GStruct4))));
				}
			}
			if (pGstruct4_0 != null && (*(byte*)pGstruct4_0 & 32) != 0)
			{
				if ((*(byte*)pGstruct4_0 & 128) != 0)
				{
					<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 2 / sizeof(GStruct4)) >> 8));
				}
				if (byte_1 == 0)
				{
					<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3)), (byte)((int)(*(ushort*)(pGstruct4_0 + 2 / sizeof(GStruct4))) & -17));
				}
				else if (byte_1 == 16)
				{
					<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 2 / sizeof(GStruct4)) | 16));
				}
				else
				{
					<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3)), (byte)(*(ushort*)(pGstruct4_0 + 2 / sizeof(GStruct4))));
				}
				if (<Module>.smethod_7(null, *(ushort*)(pGstruct3_0 + 20 / sizeof(GStruct3)), byte_2 | 136, byte_2, pGstruct3_0) != null)
				{
					return 1;
				}
			}
			else if (byte_1 != 1 && (<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3))) & 16) != byte_1)
			{
				if (pGstruct4_0 != null && (*(byte*)pGstruct4_0 & 128) != 0)
				{
					<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3)), 0);
				}
				<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3)), byte_1);
				if (<Module>.smethod_7(null, *(ushort*)(pGstruct3_0 + 20 / sizeof(GStruct3)), byte_2 | 136, byte_2, pGstruct3_0) != null)
				{
					return 1;
				}
			}
			<Module>.smethod_2(*(ushort*)(pGstruct3_0 + 18 / sizeof(GStruct3)), byte_0);
			if (byte_0 != 144)
			{
				<Module>.Sleep(1);
			}
			else
			{
				<Module>.Sleep(2);
			}
			if (<Module>.smethod_7((byte*)(pGstruct3_0 + 28 / sizeof(GStruct3)), *(ushort*)(pGstruct3_0 + 20 / sizeof(GStruct3)), 128, 0, pGstruct3_0) != null)
			{
				result = 1;
			}
			else if ((*(byte*)(pGstruct3_0 + 28 / sizeof(GStruct3)) & 33) != 0)
			{
				*(byte*)(pGstruct3_0 + 29 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 2 / sizeof(GStruct3)));
				if (byte_0 == 236 || byte_0 == 32)
				{
					*(byte*)(pGstruct3_0 + 36 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3)));
					*(byte*)(pGstruct3_0 + 33 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 12 / sizeof(GStruct3)));
					*(byte*)(pGstruct3_0 + 34 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 10 / sizeof(GStruct3)));
					*(byte*)(pGstruct3_0 + 35 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 8 / sizeof(GStruct3)));
					*(byte*)(pGstruct3_0 + 32 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 6 / sizeof(GStruct3)));
				}
				*(int*)(pGstruct3_0 + 24 / sizeof(GStruct3)) = 0;
				result = 1;
			}
			else
			{
				if (byte_0 == 144 || byte_0 == 8)
				{
					*(byte*)(pGstruct3_0 + 29 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 2 / sizeof(GStruct3)));
					*(byte*)(pGstruct3_0 + 36 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3)));
					*(byte*)(pGstruct3_0 + 33 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 12 / sizeof(GStruct3)));
					*(byte*)(pGstruct3_0 + 34 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 10 / sizeof(GStruct3)));
					*(byte*)(pGstruct3_0 + 35 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 8 / sizeof(GStruct3)));
					*(byte*)(pGstruct3_0 + 32 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 6 / sizeof(GStruct3)));
				}
				if (pGstruct4_1 != null)
				{
					if ((*(byte*)pGstruct4_1 & 32) != 0)
					{
						*(short*)(pGstruct4_1 + 2 / sizeof(GStruct4)) = (short)<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3)));
					}
					if ((*(byte*)pGstruct4_1 & 1) != 0)
					{
						*(short*)(pGstruct4_1 + 4 / sizeof(GStruct4)) = (short)<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 4 / sizeof(GStruct3)));
					}
					if ((*(byte*)pGstruct4_1 & 16) != 0)
					{
						*(short*)(pGstruct4_1 + 6 / sizeof(GStruct4)) = (short)<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 12 / sizeof(GStruct3)));
					}
					if ((*(byte*)pGstruct4_1 & 8) != 0)
					{
						*(short*)(pGstruct4_1 + 8 / sizeof(GStruct4)) = (short)<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 10 / sizeof(GStruct3)));
					}
					if ((*(byte*)pGstruct4_1 & 4) != 0)
					{
						*(short*)(pGstruct4_1 + 10 / sizeof(GStruct4)) = (short)<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 8 / sizeof(GStruct3)));
					}
					if ((*(byte*)pGstruct4_1 & 2) != 0)
					{
						*(short*)(pGstruct4_1 + 12 / sizeof(GStruct4)) = (short)<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 6 / sizeof(GStruct3)));
					}
					if ((*(byte*)pGstruct4_1 & 128) != 0)
					{
						if ((*(byte*)pGstruct4_1 & 32) != 0)
						{
							*(short*)(pGstruct4_1 + 2 / sizeof(GStruct4)) = (*(ushort*)(pGstruct4_1 + 2 / sizeof(GStruct4)) | <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 14 / sizeof(GStruct3))) << 8);
						}
						if ((*(byte*)pGstruct4_1 & 1) != 0)
						{
							*(short*)(pGstruct4_1 + 4 / sizeof(GStruct4)) = (*(ushort*)(pGstruct4_1 + 4 / sizeof(GStruct4)) | <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 4 / sizeof(GStruct3))) << 8);
						}
						if ((*(byte*)pGstruct4_1 & 16) != 0)
						{
							*(short*)(pGstruct4_1 + 6 / sizeof(GStruct4)) = (*(ushort*)(pGstruct4_1 + 6 / sizeof(GStruct4)) | <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 12 / sizeof(GStruct3))) << 8);
						}
						if ((*(byte*)pGstruct4_1 & 8) != 0)
						{
							*(short*)(pGstruct4_1 + 8 / sizeof(GStruct4)) = (*(ushort*)(pGstruct4_1 + 8 / sizeof(GStruct4)) | <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 10 / sizeof(GStruct3))) << 8);
						}
						if ((*(byte*)pGstruct4_1 & 4) != 0)
						{
							*(short*)(pGstruct4_1 + 10 / sizeof(GStruct4)) = (*(ushort*)(pGstruct4_1 + 10 / sizeof(GStruct4)) | <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 8 / sizeof(GStruct3))) << 8);
						}
						if ((*(byte*)pGstruct4_1 & 2) != 0)
						{
							*(short*)(pGstruct4_1 + 12 / sizeof(GStruct4)) = (*(ushort*)(pGstruct4_1 + 12 / sizeof(GStruct4)) | <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 6 / sizeof(GStruct3))) << 8);
						}
					}
				}
				result = 0;
			}
		}
		return result;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000164C File Offset: 0x0000164C
	public unsafe static int smethod_9(void* pVoid_0, uint* pUint_0, uint uint_2, uint uint_3, GStruct3* pGstruct3_0)
	{
		Struct4 @struct = 0;
		initblk(ref @struct + 1, 0, 63);
		*pUint_0 = 0U;
		byte b;
		if (uint_3 == 0U)
		{
			b = 1;
		}
		else
		{
			b = 0;
		}
		while (<Module>.smethod_7((byte*)(pGstruct3_0 + 28 / sizeof(GStruct3)), *(ushort*)(pGstruct3_0 + 20 / sizeof(GStruct3)), 128, 0, pGstruct3_0) == null)
		{
			int result;
			if ((*(byte*)(pGstruct3_0 + 28 / sizeof(GStruct3)) & 8) != 0)
			{
				if (b != 0)
				{
					uint_3 = (<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 12 / sizeof(GStruct3))) << 8 | <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 10 / sizeof(GStruct3))));
				}
				if (uint_2 - *pUint_0 < uint_3)
				{
					uint_3 = uint_2 - *pUint_0;
				}
				uint num;
				uint num2;
				if (*(byte*)(pGstruct3_0 + 22 / sizeof(GStruct3)) == 0)
				{
					num = uint_3 >> 2;
					for (num2 = 0U; num2 < num; num2 += 1U)
					{
						*(int*)((byte*)pVoid_0 + num2 * 4U) = *(*(ushort*)pGstruct3_0);
					}
				}
				else if (*(byte*)(pGstruct3_0 + 22 / sizeof(GStruct3)) == 1)
				{
					if (*(ushort*)pGstruct3_0 == 0)
					{
						uint num3 = uint_3 / 64U;
						uint num4 = uint_3 % 64U;
						for (num2 = 0U; num2 < num3; num2 += 1U)
						{
							<Module>.smethod_4((byte*)(&@struct), 64);
							for (uint num5 = 0U; num5 < 64U; num5 += 1U)
							{
								((byte*)pVoid_0)[num5 + num2 * 64U] = *(ref @struct + num5);
							}
						}
						<Module>.memset((void*)(&@struct), 0, 64U);
						if (num4 != 0U)
						{
							<Module>.smethod_4((byte*)(&@struct), (byte)num4);
							for (uint num5 = 0U; num5 < num4; num5 += 1U)
							{
								((byte*)pVoid_0)[num5 + num3 * 64U] = *(ref @struct + num5);
							}
						}
					}
					else
					{
						num = uint_3 >> 1;
						for (num2 = 0U; num2 < num; num2 += 1U)
						{
							*(short*)((byte*)pVoid_0 + num2 * 2U) = <Module>.smethod_1(*(ushort*)pGstruct3_0);
						}
					}
				}
				else
				{
					for (num2 = 0U; num2 < num; num2 += 1U)
					{
						((byte*)pVoid_0)[num2] = <Module>.smethod_0(*(ushort*)pGstruct3_0);
					}
				}
				if (*(byte*)(pGstruct3_0 + 22 / sizeof(GStruct3)) == 0)
				{
					num = (uint_3 & 3U);
					if (num != 0U)
					{
						if (num > 1U)
						{
							*(short*)((byte*)pVoid_0 + num2 * 4U) = <Module>.smethod_1(*(ushort*)pGstruct3_0);
							if (num > 2U)
							{
								((byte*)((byte*)pVoid_0 + num2 * 4U))[4] = <Module>.smethod_0(*(ushort*)pGstruct3_0);
							}
						}
						else
						{
							((byte*)pVoid_0)[num2 * 4U] = <Module>.smethod_0(*(ushort*)pGstruct3_0);
						}
					}
				}
				else if (*(byte*)(pGstruct3_0 + 22 / sizeof(GStruct3)) == 1 && *(ushort*)pGstruct3_0 != 0 && num == (uint_3 & 1U))
				{
					((byte*)pVoid_0)[num2 * 2U] = <Module>.smethod_0(*(ushort*)pGstruct3_0);
				}
				*pUint_0 += uint_3;
				if (*pUint_0 < uint_2)
				{
					pVoid_0 = (void*)((byte*)pVoid_0 + uint_3);
					<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 20 / sizeof(GStruct3)));
					continue;
				}
				result = 0;
			}
			else if ((*(byte*)(pGstruct3_0 + 28 / sizeof(GStruct3)) & 33) != 0)
			{
				*(byte*)(pGstruct3_0 + 29 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 2 / sizeof(GStruct3)));
				*(int*)(pGstruct3_0 + 24 / sizeof(GStruct3)) = 0;
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}
		return 1;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00001874 File Offset: 0x00001874
	public unsafe static int smethod_10(void* pVoid_0, uint* pUint_0, uint uint_2, uint uint_3, GStruct3* pGstruct3_0)
	{
		Struct5 @struct = 0;
		initblk(ref @struct + 1, 0, 55);
		*pUint_0 = 0U;
		byte b;
		if (uint_3 == 0U)
		{
			b = 1;
		}
		else
		{
			b = 0;
		}
		while (<Module>.smethod_7((byte*)(pGstruct3_0 + 28 / sizeof(GStruct3)), *(ushort*)(pGstruct3_0 + 20 / sizeof(GStruct3)), 128, 0, pGstruct3_0) == null)
		{
			int result;
			if ((*(byte*)(pGstruct3_0 + 28 / sizeof(GStruct3)) & 8) != 0)
			{
				if (b != 0)
				{
					uint_3 = (<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 12 / sizeof(GStruct3))) << 8 | <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 10 / sizeof(GStruct3))));
				}
				if (uint_2 - *pUint_0 < uint_3)
				{
					uint_3 = uint_2 - *pUint_0;
				}
				uint num;
				uint num2;
				if (*(byte*)(pGstruct3_0 + 22 / sizeof(GStruct3)) == 0)
				{
					num = uint_3 >> 2;
					for (num2 = 0U; num2 < num; num2 += 1U)
					{
						*(*(ushort*)pGstruct3_0) = *(int*)((byte*)pVoid_0 + num2 * 4U);
					}
				}
				else if (*(byte*)(pGstruct3_0 + 22 / sizeof(GStruct3)) == 1)
				{
					if (*(ushort*)pGstruct3_0 == 0)
					{
						uint num3 = uint_3 / 56U;
						uint num4 = uint_3 % 56U;
						num = uint_3 >> 1;
						for (num2 = 0U; num2 < num3; num2 += 1U)
						{
							for (uint num5 = 0U; num5 < 56U; num5 += 1U)
							{
								*(ref @struct + num5) = ((byte*)pVoid_0)[num5 + num2 * 56U];
							}
							<Module>.smethod_5((byte*)(&@struct), 56);
						}
						<Module>.memset((void*)(&@struct), 0, 56U);
						if (num4 != 0U)
						{
							for (uint num5 = 0U; num5 < num4; num5 += 1U)
							{
								*(ref @struct + num5) = ((byte*)pVoid_0)[num5 + num3 * 56U];
							}
							<Module>.smethod_5((byte*)(&@struct), (byte)num4);
						}
					}
					else
					{
						num = uint_3 >> 1;
						for (num2 = 0U; num2 < num; num2 += 1U)
						{
							<Module>.smethod_3(*(ushort*)pGstruct3_0, *(ushort*)((byte*)pVoid_0 + num2 * 2U));
						}
					}
				}
				else
				{
					for (num2 = 0U; num2 < num; num2 += 1U)
					{
						<Module>.smethod_2(*(ushort*)pGstruct3_0, ((byte*)pVoid_0)[num2]);
					}
				}
				if (*(byte*)(pGstruct3_0 + 22 / sizeof(GStruct3)) == 0)
				{
					num = (uint_3 & 3U);
					if (num != 0U)
					{
						if (num > 1U)
						{
							<Module>.smethod_3(*(ushort*)pGstruct3_0, *(ushort*)((byte*)pVoid_0 + num2 * 4U));
							if (num > 2U)
							{
								<Module>.smethod_2(*(ushort*)pGstruct3_0, ((byte*)((byte*)pVoid_0 + num2 * 4U))[4]);
							}
						}
						else
						{
							<Module>.smethod_2(*(ushort*)pGstruct3_0, ((byte*)pVoid_0)[num2 * 4U]);
						}
					}
				}
				else if (*(byte*)(pGstruct3_0 + 22 / sizeof(GStruct3)) == 1 && *(ushort*)pGstruct3_0 != 0 && num == (uint_3 & 1U))
				{
					<Module>.smethod_2(*(ushort*)pGstruct3_0, ((byte*)pVoid_0)[num2 * 2U]);
				}
				*pUint_0 += uint_3;
				if (*pUint_0 < uint_2)
				{
					pVoid_0 = (void*)((byte*)pVoid_0 + uint_3);
					<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 20 / sizeof(GStruct3)));
					continue;
				}
				result = 0;
			}
			else if ((*(byte*)(pGstruct3_0 + 28 / sizeof(GStruct3)) & 33) != 0)
			{
				*(byte*)(pGstruct3_0 + 29 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 2 / sizeof(GStruct3)));
				*(int*)(pGstruct3_0 + 24 / sizeof(GStruct3)) = 0;
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}
		return 1;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00001AA0 File Offset: 0x00001AA0
	public unsafe static int smethod_11(byte byte_0, byte byte_1, GStruct4* pGstruct4_0, GStruct4* pGstruct4_1, byte byte_2, byte byte_3, GStruct3* pGstruct3_0)
	{
		return <Module>.smethod_8(byte_0, byte_1, pGstruct4_0, pGstruct4_1, byte_2, pGstruct3_0);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00001AC0 File Offset: 0x00001AC0
	public unsafe static int smethod_12(byte byte_0, byte byte_1, GStruct4* pGstruct4_0, GStruct4* pGstruct4_1, byte byte_2, void* pVoid_0, uint* pUint_0, uint uint_2, uint uint_3, byte byte_3, GStruct3* pGstruct3_0)
	{
		int num = <Module>.smethod_8(byte_0, byte_1, pGstruct4_0, pGstruct4_1, byte_2, pGstruct3_0);
		if (num == 0)
		{
			num = <Module>.smethod_9(pVoid_0, pUint_0, uint_2, uint_3, pGstruct3_0);
		}
		return num;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00001AF4 File Offset: 0x00001AF4
	public unsafe static int smethod_13(byte byte_0, byte byte_1, GStruct4* pGstruct4_0, GStruct4* pGstruct4_1, byte byte_2, void* pVoid_0, uint* pUint_0, uint uint_2, uint uint_3, byte byte_3, GStruct3* pGstruct3_0)
	{
		int num = <Module>.smethod_8(byte_0, byte_1, pGstruct4_0, pGstruct4_1, byte_2, pGstruct3_0);
		if (num == 0)
		{
			num = <Module>.smethod_10(pVoid_0, pUint_0, uint_2, uint_3, pGstruct3_0);
		}
		return num;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00001B28 File Offset: 0x00001B28
	public unsafe static int smethod_14(byte* pByte_0, uint uint_2, byte byte_0, ushort ushort_0, GStruct3* pGstruct3_0)
	{
		GStruct4 gstruct = 3;
		*(ref gstruct + 4) = 0;
		*(ref gstruct + 12) = 0;
		if (ushort_0 != 0)
		{
			gstruct |= 24;
			*(ref gstruct + 8) = (short)(ushort_0 & 255);
			*(ref gstruct + 6) = (short)(ushort_0 >> 8);
		}
		int result;
		uint num;
		if (<Module>.smethod_8(160, byte_0, &gstruct, null, 0, pGstruct3_0) != null)
		{
			*(int*)(pGstruct3_0 + 24 / sizeof(GStruct3)) = 0;
			result = 1;
		}
		else if (<Module>.smethod_10((void*)pByte_0, &num, uint_2, 512U, pGstruct3_0) != null)
		{
			*(int*)(pGstruct3_0 + 24 / sizeof(GStruct3)) = 0;
			result = 1;
		}
		else if (num != uint_2)
		{
			*(int*)(pGstruct3_0 + 24 / sizeof(GStruct3)) = 1;
			result = 1;
		}
		else
		{
			<Module>.smethod_0(*(ushort*)(pGstruct3_0 + 20 / sizeof(GStruct3)));
			if (<Module>.smethod_7((byte*)(pGstruct3_0 + 28 / sizeof(GStruct3)), *(ushort*)(pGstruct3_0 + 20 / sizeof(GStruct3)), 128, 0, pGstruct3_0) != null)
			{
				result = 1;
			}
			else if ((*(byte*)(pGstruct3_0 + 28 / sizeof(GStruct3)) & 33) != 0)
			{
				*(byte*)(pGstruct3_0 + 29 / sizeof(GStruct3)) = <Module>.smethod_0(*(ushort*)(pGstruct3_0 + 2 / sizeof(GStruct3)));
				*(int*)(pGstruct3_0 + 24 / sizeof(GStruct3)) = 0;
				result = 1;
			}
			else
			{
				result = 0;
			}
		}
		return result;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00001C04 File Offset: 0x00001C04
	public unsafe static int smethod_15(byte* pByte_0, uint uint_2, byte byte_0, byte byte_1, GStruct3* pGstruct3_0)
	{
		return <Module>.smethod_14(pByte_0, uint_2, byte_0, 0, pGstruct3_0);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00001C20 File Offset: 0x00001C20
	public unsafe static int smethod_16(byte* pByte_0, uint uint_2, byte byte_0, ushort ushort_0, void* pVoid_0, uint* pUint_0, uint uint_3, byte byte_1, GStruct3* pGstruct3_0)
	{
		int num = <Module>.smethod_14(pByte_0, uint_2, byte_0, ushort_0, pGstruct3_0);
		if (num == 0)
		{
			<Module>.Sleep(50);
			num = <Module>.smethod_9(pVoid_0, pUint_0, uint_3, 0U, pGstruct3_0);
		}
		return num;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00001C58 File Offset: 0x00001C58
	public unsafe static int smethod_17(byte* pByte_0, uint uint_2, byte byte_0, ushort ushort_0, void* pVoid_0, uint* pUint_0, uint uint_3, byte byte_1, GStruct3* pGstruct3_0)
	{
		int num = <Module>.smethod_14(pByte_0, uint_2, byte_0, ushort_0, pGstruct3_0);
		if (num == 0)
		{
			<Module>.Sleep(50);
			num = <Module>.smethod_10(pVoid_0, pUint_0, uint_3, 0U, pGstruct3_0);
		}
		return num;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00001C90 File Offset: 0x00001C90
	public unsafe static void smethod_18(GStruct5* pGstruct5_0, int int_43)
	{
		<Module>.fprintf(pGstruct5_0, *(ref <Module>.struct11_0 + int_43 * 4));
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00001CB0 File Offset: 0x00001CB0
	public unsafe static void smethod_19(GStruct5* pGstruct5_0, GStruct6* pGstruct6_0)
	{
		if (*(int*)pGstruct6_0 != 0)
		{
			<Module>.smethod_18(pGstruct5_0, *(int*)pGstruct6_0);
			<Module>.fprintf(pGstruct5_0, (sbyte*)(&<Module>.struct6_0));
		}
		else if ((*(byte*)(pGstruct6_0 + 4 / sizeof(GStruct6)) & 32) == 0 && (*(byte*)(pGstruct6_0 + 4 / sizeof(GStruct6)) & 1) == 0)
		{
			<Module>.fprintf(pGstruct5_0, (sbyte*)(&<Module>.struct7_0));
		}
		else
		{
			if ((*(byte*)(pGstruct6_0 + 4 / sizeof(GStruct6)) & 32) != 0)
			{
				<Module>.fprintf(pGstruct5_0, (sbyte*)(&<Module>.struct1_1));
			}
			if ((*(byte*)(pGstruct6_0 + 4 / sizeof(GStruct6)) & 1) != 0 || (*(byte*)(pGstruct6_0 + 4 / sizeof(GStruct6)) & 32) != 0)
			{
				if ((*(byte*)(pGstruct6_0 + 5 / sizeof(GStruct6)) & 4) != 0)
				{
					<Module>.fprintf(pGstruct5_0, (sbyte*)(&<Module>.struct8_0));
				}
				<Module>.fprintf(pGstruct5_0, (sbyte*)(&<Module>.struct9_0), *(byte*)(pGstruct6_0 + 5 / sizeof(GStruct6)));
				for (byte b = 0; b < 8; b += 1)
				{
					if (((int)(*(byte*)(pGstruct6_0 + 5 / sizeof(GStruct6))) & 128 >> (int)b) == 0)
					{
						<Module>.fprintf(pGstruct5_0, (sbyte*)(&<Module>.struct6_1));
					}
					else
					{
						<Module>.fprintf(pGstruct5_0, (sbyte*)(&<Module>.struct6_2));
					}
				}
				<Module>.fprintf(pGstruct5_0, (sbyte*)(&<Module>.struct10_0));
			}
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00001D88 File Offset: 0x00001D88
	public unsafe static void smethod_20(GStruct7* pGstruct7_0, ushort ushort_0, ushort ushort_1)
	{
		*(short*)(pGstruct7_0 + 20 / sizeof(GStruct7)) = (short)(ushort_0 + 7);
		*(short*)(pGstruct7_0 + 18 / sizeof(GStruct7)) = (short)(ushort_0 + 7);
		*(short*)pGstruct7_0 = (short)ushort_0;
		*(short*)(pGstruct7_0 + 14 / sizeof(GStruct7)) = (short)(ushort_0 + 6);
		*(short*)(pGstruct7_0 + 2 / sizeof(GStruct7)) = (short)(ushort_0 + 1);
		*(short*)(pGstruct7_0 + 4 / sizeof(GStruct7)) = (short)(ushort_0 + 1);
		*(short*)(pGstruct7_0 + 12 / sizeof(GStruct7)) = (short)(ushort_0 + 5);
		*(short*)(pGstruct7_0 + 8 / sizeof(GStruct7)) = (short)(ushort_0 + 3);
		*(short*)(pGstruct7_0 + 10 / sizeof(GStruct7)) = (short)(ushort_0 + 4);
		*(short*)(pGstruct7_0 + 6 / sizeof(GStruct7)) = (short)(ushort_0 + 2);
		*(short*)(pGstruct7_0 + 16 / sizeof(GStruct7)) = (short)(ushort_0 + 7);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00001DE4 File Offset: 0x00001DE4
	public unsafe static void smethod_21(GStruct3* pGstruct3_0, ushort ushort_0, ushort ushort_1, byte byte_0, uint uint_2)
	{
		<Module>.smethod_20((GStruct7*)pGstruct3_0, ushort_0, ushort_1);
		*(byte*)(pGstruct3_0 + 22 / sizeof(GStruct3)) = byte_0;
		<Module>.memset((void*)(pGstruct3_0 + 24 / sizeof(GStruct3)), 0, 8U);
		<Module>.memset((void*)(pGstruct3_0 + 32 / sizeof(GStruct3)), 0, 5U);
		*(int*)(pGstruct3_0 + 40 / sizeof(GStruct3)) = (int)uint_2;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00001E20 File Offset: 0x00001E20
	public unsafe static byte smethod_22(ushort ushort_0)
	{
		byte result = 0;
		Struct3 @struct = 0;
		initblk(ref @struct + 1, 0, 63);
		Struct3 struct2 = 0;
		initblk(ref struct2 + 1, 0, 63);
		int num = 3;
		@struct = ushort_0 + 32;
		if (<Module>.smethod_30((sbyte*)(&@struct), 1, (sbyte*)(&struct2), 3) == 1)
		{
			if (num == 3 && struct2 == ushort_0 + 32)
			{
				result = (byte)(*(ref struct2 + 1));
			}
			else
			{
				result = 0;
			}
		}
		return result;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00001E80 File Offset: 0x00001E80
	public unsafe static ushort smethod_23(ushort ushort_0)
	{
		ushort result = 0;
		Struct3 @struct = 0;
		initblk(ref @struct + 1, 0, 63);
		Struct3 struct2 = 0;
		initblk(ref struct2 + 1, 0, 63);
		int num = 3;
		@struct = ushort_0 + 32;
		if (<Module>.smethod_30((sbyte*)(&@struct), 1, (sbyte*)(&struct2), 3) == 1)
		{
			if (num == 3 && struct2 == ushort_0 + 32)
			{
				ushort num2 = (ushort)((int)(*(ref struct2 + 1)));
				ushort num3 = (ushort)(*(ref struct2 + 2) << 8);
				result = num2 + num3;
			}
			else
			{
				result = 0;
			}
		}
		return result;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00001EEC File Offset: 0x00001EEC
	public unsafe static void smethod_24(byte* pByte_0, byte byte_0)
	{
		Struct3 @struct = 0;
		initblk(ref @struct + 1, 0, 63);
		Struct3 struct2 = 0;
		initblk(ref struct2 + 1, 0, 63);
		@struct = 64;
		*(ref @struct + 1) = (byte)((sbyte)byte_0);
		if (<Module>.smethod_30((sbyte*)(&@struct), 2, (sbyte*)(&struct2), (int)byte_0) == 1)
		{
			<Module>.memcpy((void*)pByte_0, (void*)(&struct2), (uint)byte_0);
		}
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00001F3C File Offset: 0x00001F3C
	public unsafe static void smethod_25(byte* pByte_0, byte byte_0)
	{
		Struct3 @struct = 0;
		initblk(ref @struct + 1, 0, 63);
		Struct3 struct2 = 0;
		initblk(ref struct2 + 1, 0, 63);
		int int_ = (int)(byte_0 + 2);
		@struct = 65;
		*(ref @struct + 1) = (byte)((sbyte)byte_0);
		<Module>.smethod_30((sbyte*)(&@struct), int_, (sbyte*)(&struct2), 2);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00001F84 File Offset: 0x00001F84
	public unsafe static void smethod_26(ushort ushort_0, byte byte_0)
	{
		Struct3 @struct = 0;
		initblk(ref @struct + 1, 0, 63);
		Struct3 struct2 = 0;
		initblk(ref struct2 + 1, 0, 63);
		@struct = ushort_0 + 16;
		*(ref @struct + 2) = 0;
		*(ref @struct + 1) = (byte)((sbyte)byte_0);
		<Module>.smethod_30((sbyte*)(&@struct), 3, (sbyte*)(&struct2), 1);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00001FD0 File Offset: 0x00001FD0
	public unsafe static void smethod_27(ushort ushort_0, ushort ushort_1)
	{
		Struct3 @struct = 0;
		initblk(ref @struct + 1, 0, 63);
		Struct3 struct2 = 0;
		initblk(ref struct2 + 1, 0, 63);
		@struct = ushort_0 + 16;
		*(ref @struct + 1) = (byte)(ushort_1 & 255);
		*(ref @struct + 2) = (byte)((ushort_1 & 65280) >> 8);
		<Module>.smethod_30((sbyte*)(&@struct), 3, (sbyte*)(&struct2), 1);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002028 File Offset: 0x00002028
	public unsafe static int smethod_28(byte byte_0)
	{
		Struct3 @struct = 0;
		initblk(ref @struct + 1, 0, 63);
		Struct3 struct2 = 0;
		initblk(ref struct2 + 1, 0, 63);
		int int_ = 1;
		int num = 1;
		if (byte_0 == 1)
		{
			@struct = 1;
		}
		else if (byte_0 == 2)
		{
			@struct = 2;
		}
		else if (byte_0 == 5)
		{
			@struct = 5;
		}
		else if (byte_0 == 6)
		{
			@struct = 6;
		}
		else if (byte_0 == 7)
		{
			@struct = 7;
		}
		else if (byte_0 == 8)
		{
			@struct = 8;
		}
		else if (byte_0 == 9)
		{
			@struct = -88;
		}
		else
		{
			if (byte_0 != 10)
			{
				return 0;
			}
			@struct = -3;
		}
		return (<Module>.smethod_30((sbyte*)(&@struct), int_, (sbyte*)(&struct2), num) != 1) ? 0 : ((num != 1 || struct2 != @struct) ? 0 : 1);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000020D0 File Offset: 0x000020D0
	public unsafe static int smethod_29()
	{
		ushort num;
		if (*(ref <Module>.gstruct10_0 + 14) == 1)
		{
			num = 33591;
		}
		else
		{
			num = 33587;
		}
		<Module>.usb_init();
		<Module>.usb_find_busses();
		<Module>.usb_find_devices();
		GStruct8* ptr = <Module>.usb_get_busses();
		<Module>.usb_set_debug(4);
		<Module>.gstruct10_0 = 0;
		for (GStruct8* ptr2 = ptr; ptr2 != null; ptr2 = *(int*)ptr2)
		{
			for (GStruct9* ptr3 = *(int*)(ptr2 + 520 / sizeof(GStruct8)); ptr3 != null; ptr3 = *(int*)ptr3)
			{
				if (*(ushort*)(ptr3 + 532 / sizeof(GStruct9)) == 4564 && *(ushort*)(ptr3 + 534 / sizeof(GStruct9)) == num)
				{
					<Module>.gstruct10_0 = <Module>.usb_open(ptr3);
				}
			}
		}
		int result;
		if (<Module>.gstruct10_0 == null)
		{
			result = 0;
		}
		else if (<Module>.usb_set_configuration(<Module>.gstruct10_0, 1) < 0)
		{
			<Module>.usb_close(<Module>.gstruct10_0);
			result = 0;
		}
		else if (<Module>.usb_claim_interface(<Module>.gstruct10_0, 0) < 0)
		{
			<Module>.usb_close(<Module>.gstruct10_0);
			result = 0;
		}
		else
		{
			<Module>.smethod_28(2);
			result = 1;
		}
		return result;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000021C0 File Offset: 0x000021C0
	public unsafe static int smethod_30(sbyte* pSbyte_0, int int_43, sbyte* pSbyte_1, int int_44)
	{
		if (<Module>.gstruct10_0 == null)
		{
			<Module>.smethod_29();
		}
		int result;
		if (<Module>.usb_bulk_write(<Module>.gstruct10_0, 1, pSbyte_0, int_43, 15000) == int_43)
		{
			if (int_44 != 0)
			{
				if (<Module>.usb_bulk_read(<Module>.gstruct10_0, 129, pSbyte_1, int_44, 15000) == int_44)
				{
					if (int_44 > 4)
					{
						Struct3 @struct;
						<Module>.memcpy((void*)(&@struct), (void*)pSbyte_1, 64U);
					}
					result = 1;
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = 1;
			}
		}
		else
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002418 File Offset: 0x00002418
	public unsafe static int smethod_31(int int_43, uint uint_2, int int_44)
	{
		int result;
		if (int_43 == 5)
		{
			GStruct11* ptr = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct12_0));
			GStruct12 gstruct;
			GStruct12 gstruct2;
			GStruct12 gstruct3;
			if (ptr != null && uint_2 != 0U && ptr != uint_2 && <Module>.GetWindowRect(<Module>.GetDesktopWindow(), &gstruct) != null && <Module>.GetWindowRect(ptr, &gstruct2) != null && <Module>.GetWindowRect(uint_2, &gstruct3) != null)
			{
				int num = *(ref gstruct3 + 8) - gstruct3;
				int num2 = *(ref gstruct3 + 12) - *(ref gstruct3 + 4);
				GStruct13 gstruct4 = gstruct2 + (*(ref gstruct2 + 8) - gstruct2) / 2;
				*(ref gstruct4 + 4) = *(ref gstruct2 + 4) + (*(ref gstruct2 + 12) - *(ref gstruct2 + 4)) / 2;
				GStruct13 gstruct5 = gstruct4 - num / 2;
				*(ref gstruct5 + 4) = *(ref gstruct4 + 4) - num2 / 2;
				if (gstruct5 < 0)
				{
					gstruct5 = 0;
				}
				if (*(ref gstruct5 + 4) < 0)
				{
					*(ref gstruct5 + 4) = 0;
				}
				if (gstruct5 + num > *(ref gstruct + 8))
				{
					gstruct5 = *(ref gstruct + 8) - num;
				}
				if (*(ref gstruct5 + 4) + num2 > *(ref gstruct + 12))
				{
					*(ref gstruct5 + 4) = *(ref gstruct + 12) - num2;
				}
				<Module>.MoveWindow(uint_2, gstruct5, *(ref gstruct5 + 4), num, num2, 0);
			}
			<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_0);
			result = 0;
		}
		else
		{
			<Module>.CallNextHookEx(<Module>.pGstruct14_0, int_43, uint_2, int_44);
			result = 0;
		}
		return result;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002558 File Offset: 0x00002558
	public unsafe static int smethod_32(int int_43, uint uint_2, int int_44)
	{
		if (int_43 == 5)
		{
			GStruct11* ptr = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct12_1));
			GStruct11* ptr2 = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct13_0));
			GStruct12 gstruct;
			GStruct12 gstruct2;
			GStruct12 gstruct3;
			if (ptr2 != null && ptr != uint_2 && uint_2 != 0U && ptr2 != uint_2 && <Module>.GetWindowRect(<Module>.GetDesktopWindow(), &gstruct) != null && <Module>.GetWindowRect(ptr2, &gstruct2) != null && <Module>.GetWindowRect(uint_2, &gstruct3) != null)
			{
				int num = *(ref gstruct3 + 8) - gstruct3;
				int num2 = *(ref gstruct3 + 12) - *(ref gstruct3 + 4);
				GStruct13 gstruct4 = gstruct2 + (*(ref gstruct2 + 8) - gstruct2) / 2;
				*(ref gstruct4 + 4) = *(ref gstruct2 + 4) + (*(ref gstruct2 + 12) - *(ref gstruct2 + 4)) / 2;
				GStruct13 gstruct5 = gstruct4 - num / 2;
				*(ref gstruct5 + 4) = *(ref gstruct4 + 4) - num2 / 2;
				if (gstruct5 < 0)
				{
					gstruct5 = 0;
				}
				if (*(ref gstruct5 + 4) < 0)
				{
					*(ref gstruct5 + 4) = 0;
				}
				if (gstruct5 + num > *(ref gstruct + 8))
				{
					gstruct5 = *(ref gstruct + 8) - num;
				}
				if (*(ref gstruct5 + 4) + num2 > *(ref gstruct + 12))
				{
					*(ref gstruct5 + 4) = *(ref gstruct + 12) - num2;
				}
				<Module>.MoveWindow(uint_2, gstruct5, *(ref gstruct5 + 4), num, num2, 0);
			}
			<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_1);
		}
		else
		{
			<Module>.CallNextHookEx(<Module>.pGstruct14_1, int_43, uint_2, int_44);
		}
		return 0;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000026B8 File Offset: 0x000026B8
	public unsafe static int smethod_33(int int_43, uint uint_2, int int_44)
	{
		if (int_43 == 5)
		{
			GStruct11* ptr = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct12_2));
			GStruct11* ptr2 = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct14_0));
			GStruct12 gstruct;
			GStruct12 gstruct2;
			GStruct12 gstruct3;
			if (ptr2 != null && ptr != uint_2 && uint_2 != 0U && ptr2 != uint_2 && <Module>.GetWindowRect(<Module>.GetDesktopWindow(), &gstruct) != null && <Module>.GetWindowRect(ptr2, &gstruct2) != null && <Module>.GetWindowRect(uint_2, &gstruct3) != null)
			{
				int num = *(ref gstruct3 + 8) - gstruct3;
				int num2 = *(ref gstruct3 + 12) - *(ref gstruct3 + 4);
				GStruct13 gstruct4 = gstruct2 + (*(ref gstruct2 + 8) - gstruct2) / 2;
				*(ref gstruct4 + 4) = *(ref gstruct2 + 4) + (*(ref gstruct2 + 12) - *(ref gstruct2 + 4)) / 2;
				GStruct13 gstruct5 = gstruct4 - num / 2;
				*(ref gstruct5 + 4) = *(ref gstruct4 + 4) - num2 / 2;
				if (gstruct5 < 0)
				{
					gstruct5 = 0;
				}
				if (*(ref gstruct5 + 4) < 0)
				{
					*(ref gstruct5 + 4) = 0;
				}
				if (gstruct5 + num > *(ref gstruct + 8))
				{
					gstruct5 = *(ref gstruct + 8) - num;
				}
				if (*(ref gstruct5 + 4) + num2 > *(ref gstruct + 12))
				{
					*(ref gstruct5 + 4) = *(ref gstruct + 12) - num2;
				}
				<Module>.MoveWindow(uint_2, gstruct5, *(ref gstruct5 + 4), num, num2, 0);
			}
			<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_2);
		}
		else
		{
			<Module>.CallNextHookEx(<Module>.pGstruct14_2, int_43, uint_2, int_44);
		}
		return 0;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002818 File Offset: 0x00002818
	public unsafe static int smethod_34(int int_43, uint uint_2, int int_44)
	{
		if (int_43 == 5)
		{
			GStruct11* ptr = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct12_3));
			GStruct11* ptr2 = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct15_0));
			GStruct12 gstruct;
			GStruct12 gstruct2;
			GStruct12 gstruct3;
			if (ptr2 != null && ptr != uint_2 && uint_2 != 0U && ptr2 != uint_2 && <Module>.GetWindowRect(<Module>.GetDesktopWindow(), &gstruct) != null && <Module>.GetWindowRect(ptr2, &gstruct2) != null && <Module>.GetWindowRect(uint_2, &gstruct3) != null)
			{
				int num = *(ref gstruct3 + 8) - gstruct3;
				int num2 = *(ref gstruct3 + 12) - *(ref gstruct3 + 4);
				GStruct13 gstruct4 = gstruct2 + (*(ref gstruct2 + 8) - gstruct2) / 2;
				*(ref gstruct4 + 4) = *(ref gstruct2 + 4) + (*(ref gstruct2 + 12) - *(ref gstruct2 + 4)) / 2;
				GStruct13 gstruct5 = gstruct4 - num / 2;
				*(ref gstruct5 + 4) = *(ref gstruct4 + 4) - num2 / 2;
				if (gstruct5 < 0)
				{
					gstruct5 = 0;
				}
				if (*(ref gstruct5 + 4) < 0)
				{
					*(ref gstruct5 + 4) = 0;
				}
				if (gstruct5 + num > *(ref gstruct + 8))
				{
					gstruct5 = *(ref gstruct + 8) - num;
				}
				if (*(ref gstruct5 + 4) + num2 > *(ref gstruct + 12))
				{
					*(ref gstruct5 + 4) = *(ref gstruct + 12) - num2;
				}
				<Module>.MoveWindow(uint_2, gstruct5, *(ref gstruct5 + 4), num, num2, 0);
			}
			<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_3);
		}
		else
		{
			<Module>.CallNextHookEx(<Module>.pGstruct14_3, int_43, uint_2, int_44);
		}
		return 0;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002978 File Offset: 0x00002978
	public unsafe static int smethod_35(int int_43, uint uint_2, int int_44)
	{
		if (int_43 == 5)
		{
			GStruct11* ptr = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct12_4));
			GStruct11* ptr2 = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct16_0));
			GStruct12 gstruct;
			GStruct12 gstruct2;
			GStruct12 gstruct3;
			if (ptr2 != null && ptr != uint_2 && uint_2 != 0U && ptr2 != uint_2 && <Module>.GetWindowRect(<Module>.GetDesktopWindow(), &gstruct) != null && <Module>.GetWindowRect(ptr2, &gstruct2) != null && <Module>.GetWindowRect(uint_2, &gstruct3) != null)
			{
				int num = *(ref gstruct3 + 8) - gstruct3;
				int num2 = *(ref gstruct3 + 12) - *(ref gstruct3 + 4);
				GStruct13 gstruct4 = gstruct2 + (*(ref gstruct2 + 8) - gstruct2) / 2;
				*(ref gstruct4 + 4) = *(ref gstruct2 + 4) + (*(ref gstruct2 + 12) - *(ref gstruct2 + 4)) / 2;
				GStruct13 gstruct5 = gstruct4 - num / 2;
				*(ref gstruct5 + 4) = *(ref gstruct4 + 4) - num2 / 2;
				if (gstruct5 < 0)
				{
					gstruct5 = 0;
				}
				if (*(ref gstruct5 + 4) < 0)
				{
					*(ref gstruct5 + 4) = 0;
				}
				if (gstruct5 + num > *(ref gstruct + 8))
				{
					gstruct5 = *(ref gstruct + 8) - num;
				}
				if (*(ref gstruct5 + 4) + num2 > *(ref gstruct + 12))
				{
					*(ref gstruct5 + 4) = *(ref gstruct + 12) - num2;
				}
				<Module>.MoveWindow(uint_2, gstruct5, *(ref gstruct5 + 4), num, num2, 0);
			}
			<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_4);
		}
		else
		{
			<Module>.CallNextHookEx(<Module>.pGstruct14_4, int_43, uint_2, int_44);
		}
		return 0;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00003768 File Offset: 0x00003768
	public unsafe static void smethod_36(sbyte* pSbyte_0, sbyte* pSbyte_1)
	{
		*pSbyte_0 = (byte)(*pSbyte_1);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00003468 File Offset: 0x00003468
	public unsafe static sbyte* smethod_37(sbyte* pSbyte_0, sbyte* pSbyte_1, uint uint_2)
	{
		return <Module>.memcpy((void*)pSbyte_0, (void*)pSbyte_1, uint_2);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00003718 File Offset: 0x00003718
	public unsafe static sbyte* smethod_38(sbyte* pSbyte_0, sbyte* pSbyte_1, uint uint_2)
	{
		return <Module>.memmove((void*)pSbyte_0, (void*)pSbyte_1, uint_2);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002AD8 File Offset: 0x00002AD8
	public unsafe static GStruct18* smethod_39(GStruct18* pGstruct18_0, GStruct18* pGstruct18_1)
	{
		return pGstruct18_0;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002AF8 File Offset: 0x00002AF8
	public unsafe static GStruct29* smethod_40(GStruct29* pGstruct29_0, GStruct29* pGstruct29_1)
	{
		<Module>.smethod_47(pGstruct29_0, pGstruct29_1);
		return pGstruct29_0;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002B28 File Offset: 0x00002B28
	public unsafe static GStruct30* smethod_41(GStruct30* pGstruct30_0, GStruct30* pGstruct30_1)
	{
		<Module>.smethod_42(pGstruct30_0, pGstruct30_1);
		return pGstruct30_0;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002B48 File Offset: 0x00002B48
	public unsafe static GStruct30* smethod_42(GStruct30* pGstruct30_0, GStruct30* pGstruct30_1)
	{
		*pGstruct30_0 = *pGstruct30_1;
		*pGstruct30_1 = 0;
		return pGstruct30_0;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002B98 File Offset: 0x00002B98
	public unsafe static void smethod_43(GStruct35.GStruct37* pGstruct37_0)
	{
		GStruct39 gstruct;
		<Module>.std._Lockit.__ctor(ref gstruct, 0);
		try
		{
			if (*(pGstruct37_0 + 4) < -1)
			{
				*(pGstruct37_0 + 4) = *(pGstruct37_0 + 4) + 1;
			}
		}
		catch
		{
			<Module>.__CxxCallUnwindDtor(<Module>.ppInt_0, (void*)(&gstruct));
			throw;
		}
		<Module>.std._Lockit.__dtor(ref gstruct);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002B68 File Offset: 0x00002B68
	public unsafe static GStruct35* smethod_44(GStruct35* pGstruct35_0, GStruct35* pGstruct35_1)
	{
		*pGstruct35_0 = *pGstruct35_1;
		<Module>.smethod_43(*pGstruct35_0);
		return pGstruct35_0;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00003324 File Offset: 0x00003324
	public unsafe static GStruct19* smethod_45(GStruct19* pGstruct19_0, GStruct19* pGstruct19_1)
	{
		GStruct61 gstruct;
		<Module>.smethod_53(pGstruct19_0, <Module>.smethod_54(ref gstruct, pGstruct19_1));
		<Module>.smethod_51(pGstruct19_0, false, 0U);
		<Module>.smethod_50(pGstruct19_0, pGstruct19_1, 0U, <Module>.uint_0);
		return pGstruct19_0;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00003488 File Offset: 0x00003488
	public unsafe static uint smethod_46(GStruct19* pGstruct19_0)
	{
		return *(pGstruct19_0 + 20);
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00003368 File Offset: 0x00003368
	public unsafe static GStruct63* smethod_47(GStruct63* pGstruct63_0, GStruct63* pGstruct63_1)
	{
		GStruct62 gstruct;
		<Module>.smethod_58(pGstruct63_0, <Module>.smethod_49(ref gstruct, pGstruct63_1));
		<Module>.smethod_56(pGstruct63_0, false, 0U);
		<Module>.smethod_55(pGstruct63_0, pGstruct63_1, 0U, <Module>.uint_1);
		return pGstruct63_0;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000033A8 File Offset: 0x000033A8
	public unsafe static void smethod_48(GStruct63* pGstruct63_0)
	{
		<Module>.smethod_56(pGstruct63_0, true, 0U);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x000033C8 File Offset: 0x000033C8
	public unsafe static GStruct62* smethod_49(GStruct62* pGstruct62_0, GStruct62* pGstruct62_1)
	{
		<Module>.smethod_54(pGstruct62_0, pGstruct62_1);
		return pGstruct62_0;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x000033E8 File Offset: 0x000033E8
	public unsafe static GStruct19* smethod_50(GStruct19* pGstruct19_0, GStruct19* pGstruct19_1, uint uint_2, uint uint_3)
	{
		if (<Module>.smethod_46(pGstruct19_1) < uint_2)
		{
			<Module>.std._String_base._Xran(pGstruct19_0);
		}
		uint num = <Module>.smethod_46(pGstruct19_1) - uint_2;
		if (uint_3 < num)
		{
			num = uint_3;
		}
		if (pGstruct19_0 == pGstruct19_1)
		{
			<Module>.smethod_59(pGstruct19_0, uint_2 + num, <Module>.uint_0);
			<Module>.smethod_59(pGstruct19_0, 0U, uint_2);
		}
		else if (<Module>.smethod_61(pGstruct19_0, num, false) != null)
		{
			<Module>.smethod_37(<Module>.smethod_62(pGstruct19_0), <Module>.smethod_52(pGstruct19_1) + uint_2, num);
			<Module>.smethod_60(pGstruct19_0, num);
		}
		return pGstruct19_0;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x000034A8 File Offset: 0x000034A8
	public unsafe static void smethod_51(GStruct19* pGstruct19_0, [MarshalAs(UnmanagedType.U1)] bool bool_0, uint uint_2)
	{
		if (bool_0 && 16 <= *(pGstruct19_0 + 24))
		{
			sbyte* ptr = *(pGstruct19_0 + 4);
			if (0U < uint_2)
			{
				<Module>.smethod_37(pGstruct19_0 + 4, (sbyte*)ptr, uint_2);
			}
			<Module>.smethod_63(pGstruct19_0, ptr, (uint)(*(pGstruct19_0 + 24) + 1));
		}
		*(pGstruct19_0 + 24) = 15;
		<Module>.smethod_60(pGstruct19_0, uint_2);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003508 File Offset: 0x00003508
	public unsafe static sbyte* smethod_52(GStruct19* pGstruct19_0)
	{
		return (16 > *(pGstruct19_0 + 24)) ? (pGstruct19_0 + 4) : (*(pGstruct19_0 + 4));
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003538 File Offset: 0x00003538
	public unsafe static GStruct69* smethod_53(GStruct69* pGstruct69_0, GStruct61* pGstruct61_0)
	{
		<Module>.smethod_54(pGstruct69_0, pGstruct61_0);
		return pGstruct69_0;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003558 File Offset: 0x00003558
	public unsafe static GStruct61* smethod_54(GStruct61* pGstruct61_0, GStruct61* pGstruct61_1)
	{
		return pGstruct61_0;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00003578 File Offset: 0x00003578
	public unsafe static GStruct63* smethod_55(GStruct63* pGstruct63_0, GStruct63* pGstruct63_1, uint uint_2, uint uint_3)
	{
		if (<Module>.smethod_65(pGstruct63_1) < uint_2)
		{
			<Module>.std._String_base._Xran(pGstruct63_0);
		}
		uint num = <Module>.smethod_65(pGstruct63_1) - uint_2;
		if (uint_3 < num)
		{
			num = uint_3;
		}
		if (pGstruct63_0 == pGstruct63_1)
		{
			<Module>.smethod_64(pGstruct63_0, uint_2 + num, <Module>.uint_1);
			<Module>.smethod_64(pGstruct63_0, 0U, uint_2);
		}
		else if (<Module>.smethod_67(pGstruct63_0, num, false) != null)
		{
			<Module>.smethod_37(<Module>.smethod_68(pGstruct63_0), <Module>.smethod_57(pGstruct63_1) + uint_2, num);
			<Module>.smethod_66(pGstruct63_0, num);
		}
		return pGstruct63_0;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x000035F8 File Offset: 0x000035F8
	public unsafe static void smethod_56(GStruct63* pGstruct63_0, [MarshalAs(UnmanagedType.U1)] bool bool_0, uint uint_2)
	{
		if (bool_0 && 16 <= *(pGstruct63_0 + 24))
		{
			sbyte* ptr = *(pGstruct63_0 + 4);
			if (0U < uint_2)
			{
				<Module>.smethod_37(pGstruct63_0 + 4, (sbyte*)ptr, uint_2);
			}
			<Module>.smethod_69(pGstruct63_0, ptr, (uint)(*(pGstruct63_0 + 24) + 1));
		}
		*(pGstruct63_0 + 24) = 15;
		<Module>.smethod_66(pGstruct63_0, uint_2);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003658 File Offset: 0x00003658
	public unsafe static sbyte* smethod_57(GStruct63* pGstruct63_0)
	{
		return (16 > *(pGstruct63_0 + 24)) ? (pGstruct63_0 + 4) : (*(pGstruct63_0 + 4));
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00003688 File Offset: 0x00003688
	public unsafe static GStruct70* smethod_58(GStruct70* pGstruct70_0, GStruct62* pGstruct62_0)
	{
		<Module>.smethod_49(pGstruct70_0, pGstruct62_0);
		return pGstruct70_0;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000036A8 File Offset: 0x000036A8
	public unsafe static GStruct19* smethod_59(GStruct19* pGstruct19_0, uint uint_2, uint uint_3)
	{
		if (*(pGstruct19_0 + 20) < (int)uint_2)
		{
			<Module>.std._String_base._Xran(pGstruct19_0);
		}
		if (*(pGstruct19_0 + 20) - (int)uint_2 < (int)uint_3)
		{
			uint_3 = (uint)(*(pGstruct19_0 + 20) - (int)uint_2);
		}
		if (0U < uint_3)
		{
			<Module>.smethod_38(<Module>.smethod_62(pGstruct19_0) + uint_2, <Module>.smethod_62(pGstruct19_0) + uint_2 + uint_3, (uint)(*(pGstruct19_0 + 20) - (int)uint_2 - (int)uint_3));
			uint uint_4 = (uint)(*(pGstruct19_0 + 20) - (int)uint_3);
			<Module>.smethod_60(pGstruct19_0, uint_4);
		}
		return pGstruct19_0;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00003738 File Offset: 0x00003738
	public unsafe static void smethod_60(GStruct19* pGstruct19_0, uint uint_2)
	{
		sbyte b = 0;
		*(pGstruct19_0 + 20) = (int)uint_2;
		<Module>.smethod_36(<Module>.smethod_62(pGstruct19_0) + uint_2, ref b);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00003788 File Offset: 0x00003788
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool smethod_61(GStruct19* pGstruct19_0, uint uint_2, [MarshalAs(UnmanagedType.U1)] bool bool_0)
	{
		if (<Module>.smethod_70(pGstruct19_0) < uint_2)
		{
			<Module>.std._String_base._Xlen(pGstruct19_0);
		}
		if (*(pGstruct19_0 + 24) < (int)uint_2)
		{
			<Module>.smethod_71(pGstruct19_0, uint_2, (uint)(*(pGstruct19_0 + 20)));
		}
		else if (bool_0 && uint_2 < 16U)
		{
			uint uint_3;
			if (uint_2 < (uint)(*(pGstruct19_0 + 20)))
			{
				uint_3 = uint_2;
			}
			else
			{
				uint_3 = (uint)(*(pGstruct19_0 + 20));
			}
			<Module>.smethod_51(pGstruct19_0, true, uint_3);
		}
		else if (uint_2 == 0U)
		{
			<Module>.smethod_60(pGstruct19_0, 0U);
		}
		return (0U < uint_2) ? 1 : 0;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000037F8 File Offset: 0x000037F8
	public unsafe static sbyte* smethod_62(GStruct19* pGstruct19_0)
	{
		return (16 > *(pGstruct19_0 + 24)) ? (pGstruct19_0 + 4) : (*(pGstruct19_0 + 4));
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00003828 File Offset: 0x00003828
	public unsafe static void smethod_63(GStruct61* pGstruct61_0, sbyte* pSbyte_0, uint uint_2)
	{
		<Module>.delete((void*)pSbyte_0);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00003848 File Offset: 0x00003848
	public unsafe static GStruct63* smethod_64(GStruct63* pGstruct63_0, uint uint_2, uint uint_3)
	{
		if (*(pGstruct63_0 + 20) < (int)uint_2)
		{
			<Module>.std._String_base._Xran(pGstruct63_0);
		}
		if (*(pGstruct63_0 + 20) - (int)uint_2 < (int)uint_3)
		{
			uint_3 = (uint)(*(pGstruct63_0 + 20) - (int)uint_2);
		}
		if (0U < uint_3)
		{
			<Module>.smethod_38(<Module>.smethod_68(pGstruct63_0) + uint_2, <Module>.smethod_68(pGstruct63_0) + uint_2 + uint_3, (uint)(*(pGstruct63_0 + 20) - (int)uint_2 - (int)uint_3));
			uint uint_4 = (uint)(*(pGstruct63_0 + 20) - (int)uint_3);
			<Module>.smethod_66(pGstruct63_0, uint_4);
		}
		return pGstruct63_0;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000038B8 File Offset: 0x000038B8
	public unsafe static uint smethod_65(GStruct63* pGstruct63_0)
	{
		return *(pGstruct63_0 + 20);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x000038D8 File Offset: 0x000038D8
	public unsafe static void smethod_66(GStruct63* pGstruct63_0, uint uint_2)
	{
		sbyte b = 0;
		*(pGstruct63_0 + 20) = (int)uint_2;
		<Module>.smethod_36(<Module>.smethod_68(pGstruct63_0) + uint_2, ref b);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00003908 File Offset: 0x00003908
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool smethod_67(GStruct63* pGstruct63_0, uint uint_2, [MarshalAs(UnmanagedType.U1)] bool bool_0)
	{
		if (<Module>.smethod_72(pGstruct63_0) < uint_2)
		{
			<Module>.std._String_base._Xlen(pGstruct63_0);
		}
		if (*(pGstruct63_0 + 24) < (int)uint_2)
		{
			<Module>.smethod_73(pGstruct63_0, uint_2, (uint)(*(pGstruct63_0 + 20)));
		}
		else if (bool_0 && uint_2 < 16U)
		{
			uint uint_3;
			if (uint_2 < (uint)(*(pGstruct63_0 + 20)))
			{
				uint_3 = uint_2;
			}
			else
			{
				uint_3 = (uint)(*(pGstruct63_0 + 20));
			}
			<Module>.smethod_56(pGstruct63_0, true, uint_3);
		}
		else if (uint_2 == 0U)
		{
			<Module>.smethod_66(pGstruct63_0, 0U);
		}
		return (0U < uint_2) ? 1 : 0;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00003978 File Offset: 0x00003978
	public unsafe static sbyte* smethod_68(GStruct63* pGstruct63_0)
	{
		return (16 > *(pGstruct63_0 + 24)) ? (pGstruct63_0 + 4) : (*(pGstruct63_0 + 4));
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000039A8 File Offset: 0x000039A8
	public unsafe static void smethod_69(GStruct62* pGstruct62_0, sbyte* pSbyte_0, uint uint_2)
	{
		<Module>.smethod_77((void*)pSbyte_0);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x000039C8 File Offset: 0x000039C8
	public unsafe static uint smethod_70(GStruct19* pGstruct19_0)
	{
		uint num = <Module>.smethod_75(pGstruct19_0);
		return (num > 1U) ? (num - 1U) : 1U;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x000039F8 File Offset: 0x000039F8
	public unsafe static void smethod_71(GStruct19* pGstruct19_0, uint uint_2, uint uint_3)
	{
		uint num = <Module>.__CxxQueryExceptionSize();
		int num2 = (int)stackalloc byte[num * 2U];
		uint num3 = uint_2 | 15U;
		if (<Module>.smethod_70(pGstruct19_0) < num3)
		{
			num3 = uint_2;
		}
		else if (num3 / 3U < (uint)(*(pGstruct19_0 + 24) / 2) && *(pGstruct19_0 + 24) <= <Module>.smethod_70(pGstruct19_0) - *(pGstruct19_0 + 24) / 2)
		{
			num3 = (uint)(*(pGstruct19_0 + 24) + *(pGstruct19_0 + 24) / 2);
		}
		sbyte* ptr;
		try
		{
			int num4 = num2 + (int)num;
			ptr = <Module>.smethod_74(pGstruct19_0, num3 + 1U);
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			Marshal.GetExceptionCode();
			endfilter(<Module>.__CxxExceptionFilter(Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num5 = 0U;
			int num4;
			<Module>.__CxxRegisterExceptionObject(Marshal.GetExceptionPointers(), num4);
			try
			{
				try
				{
					num3 = uint_2;
					try
					{
						ptr = <Module>.smethod_74(pGstruct19_0, num3 + 1U);
					}
					catch when (delegate
					{
						// Failed to create a 'catch-when' expression
						Marshal.GetExceptionCode();
						endfilter(<Module>.__CxxExceptionFilter(Marshal.GetExceptionPointers(), null, 0, null) != null);
					})
					{
						uint num6 = 0U;
						<Module>.__CxxRegisterExceptionObject(Marshal.GetExceptionPointers(), num2);
						try
						{
							try
							{
								<Module>.smethod_51(pGstruct19_0, true, 0U);
								<Module>._CxxThrowException(null, null);
							}
							catch when (delegate
							{
								// Failed to create a 'catch-when' expression
								num6 = <Module>.__CxxDetectRethrow(Marshal.GetExceptionPointers());
								endfilter(num6 != 0U);
							})
							{
							}
							if (num6 != 0U)
							{
								throw;
							}
						}
						finally
						{
							<Module>.__CxxUnregisterExceptionObject(num2, (int)num6);
						}
					}
					goto IL_11D;
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					num5 = <Module>.__CxxDetectRethrow(Marshal.GetExceptionPointers());
					endfilter(num5 != 0U);
				})
				{
				}
				if (num5 != 0U)
				{
					throw;
				}
			}
			finally
			{
				<Module>.__CxxUnregisterExceptionObject(num4, (int)num5);
			}
		}
		IL_11D:
		if (0U < uint_3)
		{
			<Module>.smethod_37(ptr, <Module>.smethod_62(pGstruct19_0), uint_3);
		}
		<Module>.smethod_51(pGstruct19_0, true, 0U);
		*(pGstruct19_0 + 4) = ptr;
		*(pGstruct19_0 + 24) = (int)num3;
		<Module>.smethod_60(pGstruct19_0, uint_3);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00003BF8 File Offset: 0x00003BF8
	public unsafe static uint smethod_72(GStruct63* pGstruct63_0)
	{
		uint num = <Module>.smethod_75(pGstruct63_0);
		return (num > 1U) ? (num - 1U) : 1U;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00003C28 File Offset: 0x00003C28
	public unsafe static void smethod_73(GStruct63* pGstruct63_0, uint uint_2, uint uint_3)
	{
		uint num = <Module>.__CxxQueryExceptionSize();
		int num2 = (int)stackalloc byte[num * 2U];
		uint num3 = uint_2 | 15U;
		if (<Module>.smethod_72(pGstruct63_0) < num3)
		{
			num3 = uint_2;
		}
		else if (num3 / 3U < (uint)(*(pGstruct63_0 + 24) / 2) && *(pGstruct63_0 + 24) <= <Module>.smethod_72(pGstruct63_0) - *(pGstruct63_0 + 24) / 2)
		{
			num3 = (uint)(*(pGstruct63_0 + 24) + *(pGstruct63_0 + 24) / 2);
		}
		sbyte* ptr;
		try
		{
			int num4 = num2 + (int)num;
			ptr = <Module>.smethod_76(pGstruct63_0, num3 + 1U);
		}
		catch when (delegate
		{
			// Failed to create a 'catch-when' expression
			Marshal.GetExceptionCode();
			endfilter(<Module>.__CxxExceptionFilter(Marshal.GetExceptionPointers(), null, 0, null) != null);
		})
		{
			uint num5 = 0U;
			int num4;
			<Module>.__CxxRegisterExceptionObject(Marshal.GetExceptionPointers(), num4);
			try
			{
				try
				{
					num3 = uint_2;
					try
					{
						ptr = <Module>.smethod_76(pGstruct63_0, num3 + 1U);
					}
					catch when (delegate
					{
						// Failed to create a 'catch-when' expression
						Marshal.GetExceptionCode();
						endfilter(<Module>.__CxxExceptionFilter(Marshal.GetExceptionPointers(), null, 0, null) != null);
					})
					{
						uint num6 = 0U;
						<Module>.__CxxRegisterExceptionObject(Marshal.GetExceptionPointers(), num2);
						try
						{
							try
							{
								<Module>.smethod_56(pGstruct63_0, true, 0U);
								<Module>._CxxThrowException(null, null);
							}
							catch when (delegate
							{
								// Failed to create a 'catch-when' expression
								num6 = <Module>.__CxxDetectRethrow(Marshal.GetExceptionPointers());
								endfilter(num6 != 0U);
							})
							{
							}
							if (num6 != 0U)
							{
								throw;
							}
						}
						finally
						{
							<Module>.__CxxUnregisterExceptionObject(num2, (int)num6);
						}
					}
					goto IL_11D;
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					num5 = <Module>.__CxxDetectRethrow(Marshal.GetExceptionPointers());
					endfilter(num5 != 0U);
				})
				{
				}
				if (num5 != 0U)
				{
					throw;
				}
			}
			finally
			{
				<Module>.__CxxUnregisterExceptionObject(num4, (int)num5);
			}
		}
		IL_11D:
		if (0U < uint_3)
		{
			<Module>.smethod_37(ptr, <Module>.smethod_68(pGstruct63_0), uint_3);
		}
		<Module>.smethod_56(pGstruct63_0, true, 0U);
		*(pGstruct63_0 + 4) = ptr;
		*(pGstruct63_0 + 24) = (int)num3;
		<Module>.smethod_66(pGstruct63_0, uint_3);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00003E28 File Offset: 0x00003E28
	public unsafe static sbyte* smethod_74(GStruct61* pGstruct61_0, uint uint_2)
	{
		return <Module>.smethod_78(uint_2, null);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003E48 File Offset: 0x00003E48
	public unsafe static uint smethod_75(GStruct61* pGstruct61_0)
	{
		return -1;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00003E78 File Offset: 0x00003E78
	public unsafe static sbyte* smethod_76(GStruct62* pGstruct62_0, uint uint_2)
	{
		return <Module>.smethod_159(uint_2, ref <Module>.gstruct72_0, (sbyte*)(&<Module>.struct21_0), 87);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00003EA8 File Offset: 0x00003EA8
	public unsafe static void smethod_77(void* pVoid_0)
	{
		if (pVoid_0 != null)
		{
			<Module>.free(pVoid_0);
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00003EC8 File Offset: 0x00003EC8
	public unsafe static sbyte* smethod_78(uint uint_2, sbyte* pSbyte_0)
	{
		return <Module>.@new(uint_2);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00015468 File Offset: 0x00015468
	public unsafe static int smethod_79(GStruct0* pGstruct0_0, GStruct0* pGstruct0_1)
	{
		return <Module>.memcmp(pGstruct0_0, pGstruct0_1, 16U) == 0;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00015448 File Offset: 0x00015448
	public unsafe static int smethod_80(GStruct0* pGstruct0_0, GStruct0* pGstruct0_1)
	{
		return <Module>.smethod_79(pGstruct0_0, pGstruct0_1);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0034E174 File Offset: 0x00296174
	public unsafe static int smethod_81(GStruct86* pGstruct86_0, int int_43, ushort ushort_0)
	{
		void* ptr = <Module>.SetupDiGetClassDevsA((GStruct0*)(&<Module>.gstruct0_2), null, null, 2);
		int result;
		if (ptr == -1)
		{
			result = 1;
		}
		else
		{
			GStruct87 gstruct = 28;
			byte b = 1;
			uint num = 0U;
			while (<Module>.SetupDiEnumDeviceInfo(ptr, num, &gstruct) != null)
			{
				GStruct88 gstruct2 = 287;
				uint num2 = 0U;
				uint num3 = 0U;
				if (<Module>.SetupDiGetDeviceInfoListDetailA(ptr, &gstruct2) == null && <Module>.CM_Get_DevNode_Status_Ex((uint*)(&num2), (uint*)(&num3), *(ref gstruct + 20), 0, null) != null)
				{
					return 2;
				}
				uint num4 = 0U;
				bool flag = false;
				if ((num2 & 1024U) == 0U && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 2, null) == null)
				{
					flag = true;
				}
				if (!flag && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 4, null) == null)
				{
					flag = true;
				}
				if (!flag && ((num2 & 1024U) == 0U || num3 != 29U) && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 3, null) == null)
				{
					flag = true;
				}
				if (flag)
				{
					uint num5 = 0U;
					uint num6 = num4;
					while (<Module>.CM_Get_Next_Res_Des_Ex((uint*)(&num5), num6, 2, null, 0, null) == null)
					{
						if (num6 != num4)
						{
							<Module>.CM_Free_Res_Des_Handle(num6);
						}
						num6 = num5;
						uint num7;
						if (<Module>.CM_Get_Res_Des_Data_Size_Ex((uint*)(&num7), num5, 0, null) == null)
						{
							byte* ptr2 = <Module>.@new(num7);
							if (ptr2 != null)
							{
								if (<Module>.CM_Get_Res_Des_Data_Ex(num5, (void*)ptr2, num7, 0, null) != null)
								{
									<Module>.delete((void*)ptr2);
								}
								else
								{
									GStruct89* ptr3 = (GStruct89*)ptr2;
									if (*(long*)(ptr3 + 16 / sizeof(GStruct89)) - *(long*)(ptr3 + 8 / sizeof(GStruct89)) + 1L != 0L && *(long*)(ptr3 + 8 / sizeof(GStruct89)) + 7L == *(long*)(ptr3 + 16 / sizeof(GStruct89)) && int_43 < (int)ushort_0)
									{
										Struct27 @struct;
										<Module>.memset((void*)(&@struct), 0, 1024U);
										<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 1, null, (byte*)(&@struct), 1024, null);
										<Module>._strlwr((sbyte*)(&@struct));
										uint num8;
										if (((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_2)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_0)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_1)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_3)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_2)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_3)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_1)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_4)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_5)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_2)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_6)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_7)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_3)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_8)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_9)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_4)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_10)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_11)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_5)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_12)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_13)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_6)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_14)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_15)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_7)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_16)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_17)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_8)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_18)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_19)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_9)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_20)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_21)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_10)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_22)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_23)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_11)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_24)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_25)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_12)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_26)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_27)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_13)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_28)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_29)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_14)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_30)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_31)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_15)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_32)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_33)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_16)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_34)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_35)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_17)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_36)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_37)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_18)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_38)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_39)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_19)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_40)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_41)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_20)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_42)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_43)) == null))
										{
											if (((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_4)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_44)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_45)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_5)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_46)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_47)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_6)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_48)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_49)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_7)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_50)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_51)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_8)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_52)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_53)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_9)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_54)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_55)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_10)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_56)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_57)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_11)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_58)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_59)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_12)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_60)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_61)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_13)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_62)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_63)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_14)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_64)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_65)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_15)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_66)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_67)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_16)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_68)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_69)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct10_17)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_70)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_71)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_21)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_72)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_73)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_22)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_74)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_75)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_23)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_76)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_77)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_24)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_78)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_79)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_25)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_80)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_81)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_26)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_82)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_83)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_27)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_84)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_85)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_28)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_86)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_87)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_29)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_88)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_89)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_30)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_90)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_91)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_31)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_92)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_93)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_32)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_94)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_95)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_33)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_96)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_97)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_34)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_98)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_99)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_35)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_100)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_101)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_36)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_102)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_103)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_37)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_104)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_105)) == null) && ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct23_38)) == null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_106)) == null) || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_107)) == null))
											{
												num8 = 2U;
											}
											else
											{
												num8 = 1U;
											}
										}
										else
										{
											num8 = 0U;
										}
										if (*(long*)(ptr3 + 8 / sizeof(GStruct89)) == 496L)
										{
											if (num8 != 0U)
											{
												if (num8 != 2U)
												{
													if (num8 == 1U)
													{
														*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 496;
														*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
														*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
														*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
														<Module>.memset((void*)(&@struct), 0, 1024U);
														<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
														int_43++;
														goto IL_EF4;
													}
													goto IL_EF4;
												}
											}
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 496;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											<Module>.memset((void*)(&@struct), 0, 1024U);
											<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
											int_43++;
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 496;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 176;
											<Module>.memset((void*)(&@struct), 0, 1024U);
											<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
											int_43++;
										}
										else if (*(long*)(ptr3 + 8 / sizeof(GStruct89)) == 368L)
										{
											if (num8 != 0U)
											{
												if (num8 != 2U)
												{
													if (num8 == 1U)
													{
														*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 368;
														*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
														*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
														*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
														<Module>.memset((void*)(&@struct), 0, 1024U);
														<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
														int_43++;
														goto IL_EF4;
													}
													goto IL_EF4;
												}
											}
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 368;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											<Module>.memset((void*)(&@struct), 0, 1024U);
											<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
											int_43++;
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 368;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 176;
											<Module>.memset((void*)(&@struct), 0, 1024U);
											<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
											int_43++;
										}
										else
										{
											if (num8 != 1U)
											{
												if (num8 != 2U)
												{
													if (num8 == 0U)
													{
														*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)((uint)(*(long*)(ptr3 + 8 / sizeof(GStruct89))));
														*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
														if (b == 1)
														{
															*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
														}
														else
														{
															*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
														}
														*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
														<Module>.memset((void*)(&@struct), 0, 1024U);
														<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
														int_43++;
														*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)((uint)(*(long*)(ptr3 + 8 / sizeof(GStruct89))));
														*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
														if (b == 1)
														{
															*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
															b = 0;
														}
														else
														{
															*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
															b = 1;
														}
														*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 176;
														<Module>.memset((void*)(&@struct), 0, 1024U);
														<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
														int_43++;
														goto IL_EF4;
													}
													goto IL_EF4;
												}
											}
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)((uint)(*(long*)(ptr3 + 8 / sizeof(GStruct89))));
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
											if (b == 1)
											{
												*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
												b = 0;
											}
											else
											{
												*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
												b = 1;
											}
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											<Module>.memset((void*)(&@struct), 0, 1024U);
											<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
											int_43++;
										}
									}
									IL_EF4:
									<Module>.delete((void*)ptr2);
								}
							}
						}
					}
					if (num6 != num4)
					{
						<Module>.CM_Free_Res_Des_Handle(num6);
					}
					<Module>.CM_Free_Log_Conf_Handle(num4);
				}
				num += 1U;
			}
			<Module>.SetupDiDestroyDeviceInfoList(ptr);
			result = int_43;
		}
		return result;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x0034F0C8 File Offset: 0x002970C8
	public unsafe static int smethod_82(GStruct86* pGstruct86_0, int int_43, ushort ushort_0)
	{
		void* ptr = <Module>.SetupDiGetClassDevsA(null, null, null, 6);
		int result;
		if (ptr == -1)
		{
			result = 1;
		}
		else
		{
			GStruct87 gstruct = 28;
			uint num = 0U;
			while (<Module>.SetupDiEnumDeviceInfo(ptr, num, &gstruct) != null)
			{
				sbyte* ptr2 = null;
				uint uint_ = 0U;
				Struct27 @struct;
				<Module>.memset((void*)(&@struct), 0, 1024U);
				while (<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 1, null, (byte*)(&@struct), 1024, null) == null && <Module>.GetLastError() == 122)
				{
					if (ptr2 != null)
					{
						<Module>.LocalFree((void*)ptr2);
					}
					ptr2 = <Module>.LocalAlloc(64U, uint_);
				}
				if (<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_1)) == null || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_2)) == null)
				{
					goto IL_35C;
				}
				GStruct88 gstruct2 = 287;
				uint num2 = 0U;
				uint num3 = 0U;
				if (<Module>.SetupDiGetDeviceInfoListDetailA(ptr, &gstruct2) == null && <Module>.CM_Get_DevNode_Status_Ex((uint*)(&num2), (uint*)(&num3), *(ref gstruct + 20), 0, null) != null)
				{
					return 2;
				}
				uint num4 = 0U;
				bool flag = false;
				if ((num2 & 1024U) == 0U && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 2, null) == null)
				{
					flag = true;
				}
				if (!flag && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 4, null) == null)
				{
					flag = true;
				}
				if (!flag && ((num2 & 1024U) == 0U || num3 != 29U) && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 3, null) == null)
				{
					flag = true;
				}
				if (flag)
				{
					uint num5 = 0U;
					uint num6 = num4;
					int num7 = 0;
					<Module>.CM_Get_DevNode_Status((uint*)(&num2), (uint*)(&num3), *(ref gstruct + 20), 0);
					while (<Module>.CM_Get_Next_Res_Des_Ex((uint*)(&num5), num6, 2, null, 0, null) == null)
					{
						if (num6 != num4)
						{
							<Module>.CM_Free_Res_Des_Handle(num6);
						}
						num6 = num5;
						uint num8;
						if (<Module>.CM_Get_Res_Des_Data_Size_Ex((uint*)(&num8), num5, 0, null) == null)
						{
							byte* ptr3 = <Module>.@new(num8);
							if (ptr3 != null)
							{
								if (<Module>.CM_Get_Res_Des_Data_Ex(num5, (void*)ptr3, num8, 0, null) != null)
								{
									<Module>.delete((void*)ptr3);
								}
								else
								{
									GStruct89* ptr4 = (GStruct89*)ptr3;
									if (*(long*)(ptr4 + 16 / sizeof(GStruct89)) - *(long*)(ptr4 + 8 / sizeof(GStruct89)) + 1L != 0L && int_43 < (int)ushort_0 && num7 < 4)
									{
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)((uint)(*(long*)(ptr4 + 8 / sizeof(GStruct89))));
										if (num7 == 0)
										{
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											*(int*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 68 / sizeof(GStruct86)) = (int)num3;
											<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
										}
										else if (num7 == 1)
										{
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											*(int*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 68 / sizeof(GStruct86)) = (int)num3;
											<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
										}
										else if (num7 == 2)
										{
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											*(int*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 68 / sizeof(GStruct86)) = (int)num3;
											<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
											int_43++;
											num7++;
											if (int_43 > (int)ushort_0)
											{
												return 3;
											}
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)((uint)(*(long*)(ptr4 + 8 / sizeof(GStruct89))));
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 176;
											*(int*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 68 / sizeof(GStruct86)) = (int)num3;
											<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
										}
										int_43++;
										num7++;
									}
									<Module>.delete((void*)ptr3);
								}
							}
						}
					}
					if (num6 != num4)
					{
						<Module>.CM_Free_Res_Des_Handle(num6);
					}
					<Module>.CM_Free_Log_Conf_Handle(num4);
					goto IL_35C;
				}
				IL_368:
				num += 1U;
				continue;
				IL_35C:
				if (ptr2 != null)
				{
					<Module>.LocalFree((void*)ptr2);
					goto IL_368;
				}
				goto IL_368;
			}
			<Module>.SetupDiDestroyDeviceInfoList(ptr);
			result = int_43;
		}
		return result;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x0034F464 File Offset: 0x00297464
	public unsafe static int smethod_83(GStruct86* pGstruct86_0, int int_43, ushort ushort_0)
	{
		void* ptr = <Module>.SetupDiGetClassDevsA(null, null, null, 6);
		int result;
		if (ptr == -1)
		{
			result = 1;
		}
		else
		{
			GStruct87 gstruct = 28;
			uint num = 0U;
			while (<Module>.SetupDiEnumDeviceInfo(ptr, num, &gstruct) != null)
			{
				Struct27 @struct;
				<Module>.memset((void*)(&@struct), 0, 1024U);
				<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 1, null, (byte*)(&@struct), 1024, null);
				<Module>._strlwr((sbyte*)(&@struct));
				if (((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct25_2)) != null || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_108)) != null) && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_109)) != null) || ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct25_3)) != null || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_110)) != null) && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_111)) != null) || ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct25_4)) != null || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_112)) != null) && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_113)) != null) || ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct25_5)) != null || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_114)) != null) && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_115)) != null) || ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct25_6)) != null || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_116)) != null) && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_117)) != null) || ((<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct25_7)) != null || <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_118)) != null) && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct35_119)) != null))
				{
					GStruct88 gstruct2 = 287;
					uint num2 = 0U;
					uint num3 = 0U;
					if (<Module>.SetupDiGetDeviceInfoListDetailA(ptr, &gstruct2) == null && <Module>.CM_Get_DevNode_Status_Ex((uint*)(&num2), (uint*)(&num3), *(ref gstruct + 20), 0, null) != null)
					{
						return 2;
					}
					uint num4 = 0U;
					int num5 = 0;
					if ((num2 & 1024U) == 0U && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 2, null) == null)
					{
						num5 = 1;
					}
					if (num5 == 0 && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 4, null) == null)
					{
						num5 = 1;
					}
					if (num5 == 0 && ((num2 & 1024U) == 0U || num3 != 29U) && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 3, null) == null)
					{
						num5 = 1;
					}
					if (num5 != 0)
					{
						uint num6 = 0U;
						uint num7 = num4;
						<Module>.CM_Get_DevNode_Status((uint*)(&num2), (uint*)(&num3), *(ref gstruct + 20), 0);
						int num8 = 0;
						while (<Module>.CM_Get_Next_Res_Des_Ex((uint*)(&num6), num7, 2, null, 0, null) == null)
						{
							if (num7 != num4)
							{
								<Module>.CM_Free_Res_Des_Handle(num7);
							}
							num7 = num6;
							uint num9;
							if (<Module>.CM_Get_Res_Des_Data_Size_Ex((uint*)(&num9), num6, 0, null) == null)
							{
								byte* ptr2 = <Module>.@new(num9);
								if (ptr2 != null)
								{
									if (<Module>.CM_Get_Res_Des_Data_Ex(num6, (void*)ptr2, num9, 0, null) != null)
									{
										<Module>.delete((void*)ptr2);
									}
									else
									{
										GStruct89* ptr3 = (GStruct89*)ptr2;
										if (*(long*)(ptr3 + 16 / sizeof(GStruct89)) - *(long*)(ptr3 + 8 / sizeof(GStruct89)) + 1L != 0L && int_43 < (int)ushort_0 && num8 < 2)
										{
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)((uint)(*(long*)(ptr3 + 8 / sizeof(GStruct89))));
											if (num8 == 0 || num8 == 2)
											{
												*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
												*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
												*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
												*(int*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 68 / sizeof(GStruct86)) = (int)num3;
												<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
											}
											int_43++;
											num8++;
										}
										<Module>.delete((void*)ptr2);
									}
								}
							}
						}
						if (num7 != num4)
						{
							<Module>.CM_Free_Res_Des_Handle(num7);
						}
						<Module>.CM_Free_Log_Conf_Handle(num4);
					}
				}
				num += 1U;
			}
			<Module>.SetupDiDestroyDeviceInfoList(ptr);
			result = int_43;
		}
		return result;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x0034F7A8 File Offset: 0x002977A8
	public unsafe static int smethod_84(GStruct86* pGstruct86_0, int int_43, ushort ushort_0)
	{
		void* ptr = <Module>.SetupDiGetClassDevsA((GStruct0*)(&<Module>.gstruct0_0), null, null, 2);
		int result;
		if (ptr == -1)
		{
			result = 1;
		}
		else
		{
			GStruct87 gstruct = 28;
			uint num = 0U;
			while (<Module>.SetupDiEnumDeviceInfo(ptr, num, &gstruct) != null)
			{
				sbyte* ptr2 = null;
				uint uint_ = 0U;
				Struct27 @struct;
				<Module>.memset((void*)(&@struct), 0, 1024U);
				Struct27 struct2;
				<Module>.memset((void*)(&struct2), 0, 1024U);
				while (<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 1, null, (byte*)(&@struct), 1024, null) == null && <Module>.GetLastError() == 122)
				{
					if (ptr2 != null)
					{
						<Module>.LocalFree((void*)ptr2);
					}
					ptr2 = <Module>.LocalAlloc(64U, uint_);
				}
				if (<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_3)) != null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_4)) != null)
				{
					goto IL_26F;
				}
				GStruct88 gstruct2 = 287;
				uint num2 = 0U;
				uint num3 = 0U;
				if (<Module>.SetupDiGetDeviceInfoListDetailA(ptr, &gstruct2) == null && <Module>.CM_Get_DevNode_Status_Ex((uint*)(&num2), (uint*)(&num3), *(ref gstruct + 20), 0, null) != null)
				{
					return 2;
				}
				uint num4 = 0U;
				bool flag = false;
				if ((num2 & 1024U) == 0U && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 2, null) == null)
				{
					flag = true;
				}
				if (!flag && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 4, null) == null)
				{
					flag = true;
				}
				if (!flag && ((num2 & 1024U) == 0U || num3 != 29U) && <Module>.CM_Get_First_Log_Conf_Ex((uint*)(&num4), *(ref gstruct + 20), 3, null) == null)
				{
					flag = true;
				}
				if (flag)
				{
					uint num5 = 0U;
					uint num6 = num4;
					while (<Module>.CM_Get_Next_Res_Des_Ex((uint*)(&num5), num6, 2, null, 0, null) == null)
					{
						if (num6 != num4)
						{
							<Module>.CM_Free_Res_Des_Handle(num6);
						}
						num6 = num5;
						uint num7;
						if (<Module>.CM_Get_Res_Des_Data_Size_Ex((uint*)(&num7), num5, 0, null) == null)
						{
							byte* ptr3 = <Module>.@new(num7);
							if (ptr3 != null)
							{
								if (<Module>.CM_Get_Res_Des_Data_Ex(num5, (void*)ptr3, num7, 0, null) != null)
								{
									<Module>.delete((void*)ptr3);
								}
								else
								{
									<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(&struct2), 1024, null);
									if (!(<Module>.strstr((sbyte*)(&struct2), (sbyte*)(&<Module>.struct35_120)) != 0 | <Module>.strstr((sbyte*)(&struct2), (sbyte*)(&<Module>.struct22_1)) != 0))
									{
										GStruct89* ptr4 = (GStruct89*)ptr3;
										if (*(long*)(ptr4 + 16 / sizeof(GStruct89)) - *(long*)(ptr4 + 8 / sizeof(GStruct89)) + 1L != 0L)
										{
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)((uint)(*(long*)(ptr4 + 8 / sizeof(GStruct89))));
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 5 / sizeof(GStruct86)), 1024, null);
											int_43++;
										}
									}
									<Module>.delete((void*)ptr3);
								}
							}
						}
					}
					if (num6 != num4)
					{
						<Module>.CM_Free_Res_Des_Handle(num6);
					}
					<Module>.CM_Free_Log_Conf_Handle(num4);
					goto IL_26F;
				}
				IL_279:
				num += 1U;
				continue;
				IL_26F:
				if (ptr2 != null)
				{
					<Module>.LocalFree((void*)ptr2);
					goto IL_279;
				}
				goto IL_279;
			}
			<Module>.SetupDiDestroyDeviceInfoList(ptr);
			result = int_43;
		}
		return result;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x0000A920 File Offset: 0x0000A920
	public unsafe static int smethod_85(GStruct86* pGstruct86_0, int int_43, ushort ushort_0)
	{
		Struct36 @struct = 145;
		*(ref @struct + 1) = 17;
		*(ref @struct + 2) = 13;
		*(ref @struct + 3) = 0;
		*(ref @struct + 4) = 1;
		*(ref @struct + 5) = 0;
		*(ref @struct + 6) = 134;
		*(ref @struct + 7) = 128;
		*(ref @struct + 8) = 82;
		*(ref @struct + 9) = 38;
		*(ref @struct + 10) = 1;
		*(ref @struct + 11) = 0;
		*(ref @struct + 12) = 134;
		*(ref @struct + 13) = 128;
		*(ref @struct + 14) = 83;
		*(ref @struct + 15) = 38;
		*(ref @struct + 16) = 1;
		*(ref @struct + 17) = 0;
		*(ref @struct + 18) = 134;
		*(ref @struct + 19) = 128;
		*(ref @struct + 20) = 193;
		*(ref @struct + 21) = 39;
		*(ref @struct + 22) = 1;
		*(ref @struct + 23) = 0;
		*(ref @struct + 24) = 134;
		*(ref @struct + 25) = 128;
		*(ref @struct + 26) = 197;
		*(ref @struct + 27) = 39;
		*(ref @struct + 28) = 1;
		*(ref @struct + 29) = 0;
		*(ref @struct + 30) = 134;
		*(ref @struct + 31) = 128;
		*(ref @struct + 32) = 195;
		*(ref @struct + 33) = 39;
		*(ref @struct + 34) = 1;
		*(ref @struct + 35) = 0;
		*(ref @struct + 36) = 185;
		*(ref @struct + 37) = 16;
		*(ref @struct + 38) = 136;
		*(ref @struct + 39) = 82;
		*(ref @struct + 40) = 1;
		*(ref @struct + 41) = 0;
		*(ref @struct + 42) = 134;
		*(ref @struct + 43) = 128;
		*(ref @struct + 44) = 129;
		*(ref @struct + 45) = 38;
		*(ref @struct + 46) = 1;
		*(ref @struct + 47) = 0;
		*(ref @struct + 48) = 134;
		*(ref @struct + 49) = 128;
		*(ref @struct + 50) = 130;
		*(ref @struct + 51) = 38;
		*(ref @struct + 52) = 1;
		*(ref @struct + 53) = 0;
		*(ref @struct + 54) = 134;
		*(ref @struct + 55) = 128;
		*(ref @struct + 56) = 131;
		*(ref @struct + 57) = 38;
		*(ref @struct + 58) = 1;
		*(ref @struct + 59) = 0;
		*(ref @struct + 60) = 134;
		*(ref @struct + 61) = 128;
		*(ref @struct + 62) = 198;
		*(ref @struct + 63) = 39;
		*(ref @struct + 64) = 1;
		*(ref @struct + 65) = 0;
		*(ref @struct + 66) = 134;
		*(ref @struct + 67) = 128;
		*(ref @struct + 68) = 33;
		*(ref @struct + 69) = 40;
		*(ref @struct + 70) = 1;
		*(ref @struct + 71) = 0;
		*(ref @struct + 72) = 134;
		*(ref @struct + 73) = 128;
		*(ref @struct + 74) = 34;
		*(ref @struct + 75) = 40;
		*(ref @struct + 76) = 1;
		*(ref @struct + 77) = 0;
		*(ref @struct + 78) = 134;
		*(ref @struct + 79) = 128;
		*(ref @struct + 80) = 36;
		*(ref @struct + 81) = 40;
		*(ref @struct + 82) = 1;
		*(ref @struct + 83) = 0;
		*(ref @struct + 84) = 134;
		*(ref @struct + 85) = 128;
		*(ref @struct + 86) = 41;
		*(ref @struct + 87) = 40;
		*(ref @struct + 88) = 1;
		*(ref @struct + 89) = 0;
		*(ref @struct + 90) = 134;
		*(ref @struct + 91) = 128;
		*(ref @struct + 92) = 42;
		*(ref @struct + 93) = 40;
		*(ref @struct + 94) = 1;
		*(ref @struct + 95) = 0;
		*(ref @struct + 96) = 134;
		*(ref @struct + 97) = 128;
		*(ref @struct + 98) = 34;
		*(ref @struct + 99) = 41;
		*(ref @struct + 100) = 1;
		*(ref @struct + 101) = 0;
		*(ref @struct + 102) = 134;
		*(ref @struct + 103) = 128;
		*(ref @struct + 104) = 35;
		*(ref @struct + 105) = 41;
		*(ref @struct + 106) = 1;
		*(ref @struct + 107) = 0;
		*(ref @struct + 108) = 134;
		*(ref @struct + 109) = 128;
		*(ref @struct + 110) = 36;
		*(ref @struct + 111) = 41;
		*(ref @struct + 112) = 1;
		*(ref @struct + 113) = 0;
		*(ref @struct + 114) = 134;
		*(ref @struct + 115) = 128;
		*(ref @struct + 116) = 37;
		*(ref @struct + 117) = 41;
		*(ref @struct + 118) = 1;
		*(ref @struct + 119) = 0;
		*(ref @struct + 120) = 134;
		*(ref @struct + 121) = 128;
		*(ref @struct + 122) = 39;
		*(ref @struct + 123) = 41;
		*(ref @struct + 124) = 1;
		*(ref @struct + 125) = 0;
		*(ref @struct + 126) = 134;
		*(ref @struct + 127) = 128;
		*(ref @struct + 128) = 41;
		*(ref @struct + 129) = 41;
		*(ref @struct + 130) = 1;
		*(ref @struct + 131) = 0;
		*(ref @struct + 132) = 134;
		*(ref @struct + 133) = 128;
		*(ref @struct + 134) = 42;
		*(ref @struct + 135) = 41;
		*(ref @struct + 136) = 1;
		*(ref @struct + 137) = 0;
		*(ref @struct + 138) = 134;
		*(ref @struct + 139) = 128;
		*(ref @struct + 140) = 43;
		*(ref @struct + 141) = 41;
		*(ref @struct + 142) = 1;
		*(ref @struct + 143) = 0;
		*(ref @struct + 144) = 134;
		*(ref @struct + 145) = 128;
		*(ref @struct + 146) = 44;
		*(ref @struct + 147) = 41;
		*(ref @struct + 148) = 1;
		*(ref @struct + 149) = 0;
		*(ref @struct + 150) = 134;
		*(ref @struct + 151) = 128;
		*(ref @struct + 152) = 47;
		*(ref @struct + 153) = 41;
		*(ref @struct + 154) = 1;
		*(ref @struct + 155) = 0;
		*(ref @struct + 156) = 134;
		*(ref @struct + 157) = 128;
		*(ref @struct + 158) = 77;
		*(ref @struct + 159) = 41;
		*(ref @struct + 160) = 1;
		*(ref @struct + 161) = 0;
		*(ref @struct + 162) = 134;
		*(ref @struct + 163) = 128;
		*(ref @struct + 164) = 78;
		*(ref @struct + 165) = 41;
		*(ref @struct + 166) = 1;
		*(ref @struct + 167) = 0;
		*(ref @struct + 168) = 134;
		*(ref @struct + 169) = 128;
		*(ref @struct + 170) = 42;
		*(ref @struct + 171) = 80;
		*(ref @struct + 172) = 1;
		*(ref @struct + 173) = 0;
		*(ref @struct + 174) = 134;
		*(ref @struct + 175) = 128;
		*(ref @struct + 176) = 43;
		*(ref @struct + 177) = 80;
		*(ref @struct + 178) = 1;
		*(ref @struct + 179) = 0;
		*(ref @struct + 180) = 134;
		*(ref @struct + 181) = 128;
		*(ref @struct + 182) = 5;
		*(ref @struct + 183) = 58;
		*(ref @struct + 184) = 1;
		*(ref @struct + 185) = 0;
		*(ref @struct + 186) = 134;
		*(ref @struct + 187) = 128;
		*(ref @struct + 188) = 34;
		*(ref @struct + 189) = 58;
		*(ref @struct + 190) = 1;
		*(ref @struct + 191) = 0;
		*(ref @struct + 192) = 134;
		*(ref @struct + 193) = 128;
		*(ref @struct + 194) = 37;
		*(ref @struct + 195) = 58;
		*(ref @struct + 196) = 1;
		*(ref @struct + 197) = 0;
		*(ref @struct + 198) = 134;
		*(ref @struct + 199) = 128;
		*(ref @struct + 200) = 34;
		*(ref @struct + 201) = 59;
		*(ref @struct + 202) = 1;
		*(ref @struct + 203) = 0;
		*(ref @struct + 204) = 134;
		*(ref @struct + 205) = 128;
		*(ref @struct + 206) = 35;
		*(ref @struct + 207) = 59;
		*(ref @struct + 208) = 1;
		*(ref @struct + 209) = 0;
		*(ref @struct + 210) = 134;
		*(ref @struct + 211) = 128;
		*(ref @struct + 212) = 36;
		*(ref @struct + 213) = 59;
		*(ref @struct + 214) = 1;
		*(ref @struct + 215) = 0;
		*(ref @struct + 216) = 134;
		*(ref @struct + 217) = 128;
		*(ref @struct + 218) = 37;
		*(ref @struct + 219) = 59;
		*(ref @struct + 220) = 1;
		*(ref @struct + 221) = 0;
		*(ref @struct + 222) = 134;
		*(ref @struct + 223) = 128;
		*(ref @struct + 224) = 41;
		*(ref @struct + 225) = 59;
		*(ref @struct + 226) = 1;
		*(ref @struct + 227) = 0;
		*(ref @struct + 228) = 134;
		*(ref @struct + 229) = 128;
		*(ref @struct + 230) = 43;
		*(ref @struct + 231) = 59;
		*(ref @struct + 232) = 1;
		*(ref @struct + 233) = 0;
		*(ref @struct + 234) = 134;
		*(ref @struct + 235) = 128;
		*(ref @struct + 236) = 44;
		*(ref @struct + 237) = 59;
		*(ref @struct + 238) = 1;
		*(ref @struct + 239) = 0;
		*(ref @struct + 240) = 134;
		*(ref @struct + 241) = 128;
		*(ref @struct + 242) = 47;
		*(ref @struct + 243) = 59;
		*(ref @struct + 244) = 1;
		*(ref @struct + 245) = 0;
		*(ref @struct + 246) = 134;
		*(ref @struct + 247) = 128;
		*(ref @struct + 248) = 2;
		*(ref @struct + 249) = 28;
		*(ref @struct + 250) = 1;
		*(ref @struct + 251) = 0;
		*(ref @struct + 252) = 134;
		*(ref @struct + 253) = 128;
		*(ref @struct + 254) = 3;
		*(ref @struct + 255) = 28;
		*(ref @struct + 256) = 1;
		*(ref @struct + 257) = 0;
		*(ref @struct + 258) = 134;
		*(ref @struct + 259) = 128;
		*(ref @struct + 260) = 4;
		*(ref @struct + 261) = 28;
		*(ref @struct + 262) = 1;
		*(ref @struct + 263) = 0;
		*(ref @struct + 264) = 134;
		*(ref @struct + 265) = 128;
		*(ref @struct + 266) = 5;
		*(ref @struct + 267) = 28;
		*(ref @struct + 268) = 1;
		*(ref @struct + 269) = 0;
		*(ref @struct + 270) = 134;
		*(ref @struct + 271) = 128;
		*(ref @struct + 272) = 6;
		*(ref @struct + 273) = 28;
		*(ref @struct + 274) = 1;
		*(ref @struct + 275) = 0;
		*(ref @struct + 276) = 134;
		*(ref @struct + 277) = 128;
		*(ref @struct + 278) = 7;
		*(ref @struct + 279) = 28;
		*(ref @struct + 280) = 1;
		*(ref @struct + 281) = 0;
		*(ref @struct + 282) = 134;
		*(ref @struct + 283) = 128;
		*(ref @struct + 284) = 2;
		*(ref @struct + 285) = 29;
		*(ref @struct + 286) = 1;
		*(ref @struct + 287) = 0;
		*(ref @struct + 288) = 134;
		*(ref @struct + 289) = 128;
		*(ref @struct + 290) = 4;
		*(ref @struct + 291) = 29;
		*(ref @struct + 292) = 1;
		*(ref @struct + 293) = 0;
		*(ref @struct + 294) = 134;
		*(ref @struct + 295) = 128;
		*(ref @struct + 296) = 6;
		*(ref @struct + 297) = 29;
		*(ref @struct + 298) = 1;
		*(ref @struct + 299) = 0;
		*(ref @struct + 300) = 134;
		*(ref @struct + 301) = 128;
		*(ref @struct + 302) = 38;
		*(ref @struct + 303) = 40;
		*(ref @struct + 304) = 1;
		*(ref @struct + 305) = 0;
		*(ref @struct + 306) = 134;
		*(ref @struct + 307) = 128;
		*(ref @struct + 308) = 35;
		*(ref @struct + 309) = 35;
		*(ref @struct + 310) = 1;
		*(ref @struct + 311) = 0;
		*(ref @struct + 312) = 134;
		*(ref @struct + 313) = 128;
		*(ref @struct + 314) = 2;
		*(ref @struct + 315) = 30;
		*(ref @struct + 316) = 1;
		*(ref @struct + 317) = 0;
		*(ref @struct + 318) = 134;
		*(ref @struct + 319) = 128;
		*(ref @struct + 320) = 3;
		*(ref @struct + 321) = 30;
		*(ref @struct + 322) = 1;
		*(ref @struct + 323) = 0;
		*(ref @struct + 324) = 134;
		*(ref @struct + 325) = 128;
		*(ref @struct + 326) = 4;
		*(ref @struct + 327) = 30;
		*(ref @struct + 328) = 1;
		*(ref @struct + 329) = 0;
		*(ref @struct + 330) = 134;
		*(ref @struct + 331) = 128;
		*(ref @struct + 332) = 5;
		*(ref @struct + 333) = 30;
		*(ref @struct + 334) = 1;
		*(ref @struct + 335) = 0;
		*(ref @struct + 336) = 134;
		*(ref @struct + 337) = 128;
		*(ref @struct + 338) = 6;
		*(ref @struct + 339) = 30;
		*(ref @struct + 340) = 1;
		*(ref @struct + 341) = 0;
		*(ref @struct + 342) = 134;
		*(ref @struct + 343) = 128;
		*(ref @struct + 344) = 7;
		*(ref @struct + 345) = 30;
		*(ref @struct + 346) = 1;
		*(ref @struct + 347) = 0;
		*(ref @struct + 348) = 134;
		*(ref @struct + 349) = 128;
		*(ref @struct + 350) = 14;
		*(ref @struct + 351) = 30;
		*(ref @struct + 352) = 1;
		*(ref @struct + 353) = 0;
		*(ref @struct + 354) = 2;
		*(ref @struct + 355) = 16;
		*(ref @struct + 356) = 128;
		*(ref @struct + 357) = 67;
		*(ref @struct + 358) = 1;
		*(ref @struct + 359) = 0;
		*(ref @struct + 360) = 2;
		*(ref @struct + 361) = 16;
		*(ref @struct + 362) = 144;
		*(ref @struct + 363) = 67;
		*(ref @struct + 364) = 1;
		*(ref @struct + 365) = 0;
		*(ref @struct + 366) = 2;
		*(ref @struct + 367) = 16;
		*(ref @struct + 368) = 145;
		*(ref @struct + 369) = 67;
		*(ref @struct + 370) = 1;
		*(ref @struct + 371) = 0;
		*(ref @struct + 372) = 2;
		*(ref @struct + 373) = 16;
		*(ref @struct + 374) = 146;
		*(ref @struct + 375) = 67;
		*(ref @struct + 376) = 1;
		*(ref @struct + 377) = 0;
		*(ref @struct + 378) = 2;
		*(ref @struct + 379) = 16;
		*(ref @struct + 380) = 147;
		*(ref @struct + 381) = 67;
		*(ref @struct + 382) = 1;
		*(ref @struct + 383) = 0;
		*(ref @struct + 384) = 2;
		*(ref @struct + 385) = 16;
		*(ref @struct + 386) = 148;
		*(ref @struct + 387) = 67;
		*(ref @struct + 388) = 1;
		*(ref @struct + 389) = 0;
		*(ref @struct + 390) = 2;
		*(ref @struct + 391) = 16;
		*(ref @struct + 392) = 149;
		*(ref @struct + 393) = 67;
		*(ref @struct + 394) = 1;
		*(ref @struct + 395) = 0;
		*(ref @struct + 396) = 34;
		*(ref @struct + 397) = 16;
		*(ref @struct + 398) = 0;
		*(ref @struct + 399) = 120;
		*(ref @struct + 400) = 1;
		*(ref @struct + 401) = 0;
		*(ref @struct + 402) = 6;
		*(ref @struct + 403) = 17;
		*(ref @struct + 404) = 73;
		*(ref @struct + 405) = 51;
		*(ref @struct + 406) = 1;
		*(ref @struct + 407) = 0;
		*(ref @struct + 408) = 6;
		*(ref @struct + 409) = 17;
		*(ref @struct + 410) = 135;
		*(ref @struct + 411) = 98;
		*(ref @struct + 412) = 1;
		*(ref @struct + 413) = 0;
		*(ref @struct + 414) = 222;
		*(ref @struct + 415) = 16;
		*(ref @struct + 416) = 76;
		*(ref @struct + 417) = 4;
		*(ref @struct + 418) = 1;
		*(ref @struct + 419) = 0;
		*(ref @struct + 420) = 222;
		*(ref @struct + 421) = 16;
		*(ref @struct + 422) = 77;
		*(ref @struct + 423) = 4;
		*(ref @struct + 424) = 1;
		*(ref @struct + 425) = 0;
		*(ref @struct + 426) = 222;
		*(ref @struct + 427) = 16;
		*(ref @struct + 428) = 78;
		*(ref @struct + 429) = 4;
		*(ref @struct + 430) = 1;
		*(ref @struct + 431) = 0;
		*(ref @struct + 432) = 222;
		*(ref @struct + 433) = 16;
		*(ref @struct + 434) = 79;
		*(ref @struct + 435) = 4;
		*(ref @struct + 436) = 1;
		*(ref @struct + 437) = 0;
		*(ref @struct + 438) = 222;
		*(ref @struct + 439) = 16;
		*(ref @struct + 440) = 92;
		*(ref @struct + 441) = 4;
		*(ref @struct + 442) = 1;
		*(ref @struct + 443) = 0;
		*(ref @struct + 444) = 222;
		*(ref @struct + 445) = 16;
		*(ref @struct + 446) = 93;
		*(ref @struct + 447) = 4;
		*(ref @struct + 448) = 1;
		*(ref @struct + 449) = 0;
		*(ref @struct + 450) = 222;
		*(ref @struct + 451) = 16;
		*(ref @struct + 452) = 94;
		*(ref @struct + 453) = 4;
		*(ref @struct + 454) = 1;
		*(ref @struct + 455) = 0;
		*(ref @struct + 456) = 222;
		*(ref @struct + 457) = 16;
		*(ref @struct + 458) = 95;
		*(ref @struct + 459) = 4;
		*(ref @struct + 460) = 1;
		*(ref @struct + 461) = 0;
		*(ref @struct + 462) = 222;
		*(ref @struct + 463) = 16;
		*(ref @struct + 464) = 80;
		*(ref @struct + 465) = 5;
		*(ref @struct + 466) = 1;
		*(ref @struct + 467) = 0;
		*(ref @struct + 468) = 222;
		*(ref @struct + 469) = 16;
		*(ref @struct + 470) = 81;
		*(ref @struct + 471) = 5;
		*(ref @struct + 472) = 1;
		*(ref @struct + 473) = 0;
		*(ref @struct + 474) = 222;
		*(ref @struct + 475) = 16;
		*(ref @struct + 476) = 82;
		*(ref @struct + 477) = 5;
		*(ref @struct + 478) = 1;
		*(ref @struct + 479) = 0;
		*(ref @struct + 480) = 222;
		*(ref @struct + 481) = 16;
		*(ref @struct + 482) = 83;
		*(ref @struct + 483) = 5;
		*(ref @struct + 484) = 1;
		*(ref @struct + 485) = 0;
		*(ref @struct + 486) = 222;
		*(ref @struct + 487) = 16;
		*(ref @struct + 488) = 84;
		*(ref @struct + 489) = 5;
		*(ref @struct + 490) = 1;
		*(ref @struct + 491) = 0;
		*(ref @struct + 492) = 222;
		*(ref @struct + 493) = 16;
		*(ref @struct + 494) = 85;
		*(ref @struct + 495) = 5;
		*(ref @struct + 496) = 1;
		*(ref @struct + 497) = 0;
		*(ref @struct + 498) = 222;
		*(ref @struct + 499) = 16;
		*(ref @struct + 500) = 86;
		*(ref @struct + 501) = 5;
		*(ref @struct + 502) = 1;
		*(ref @struct + 503) = 0;
		*(ref @struct + 504) = 222;
		*(ref @struct + 505) = 16;
		*(ref @struct + 506) = 87;
		*(ref @struct + 507) = 5;
		*(ref @struct + 508) = 1;
		*(ref @struct + 509) = 0;
		*(ref @struct + 510) = 222;
		*(ref @struct + 511) = 16;
		*(ref @struct + 512) = 88;
		*(ref @struct + 513) = 5;
		*(ref @struct + 514) = 1;
		*(ref @struct + 515) = 0;
		*(ref @struct + 516) = 222;
		*(ref @struct + 517) = 16;
		*(ref @struct + 518) = 89;
		*(ref @struct + 519) = 5;
		*(ref @struct + 520) = 1;
		*(ref @struct + 521) = 0;
		*(ref @struct + 522) = 222;
		*(ref @struct + 523) = 16;
		*(ref @struct + 524) = 90;
		*(ref @struct + 525) = 5;
		*(ref @struct + 526) = 1;
		*(ref @struct + 527) = 0;
		*(ref @struct + 528) = 222;
		*(ref @struct + 529) = 16;
		*(ref @struct + 530) = 91;
		*(ref @struct + 531) = 5;
		*(ref @struct + 532) = 1;
		*(ref @struct + 533) = 0;
		*(ref @struct + 534) = 222;
		*(ref @struct + 535) = 16;
		*(ref @struct + 536) = 128;
		*(ref @struct + 537) = 5;
		*(ref @struct + 538) = 1;
		*(ref @struct + 539) = 0;
		*(ref @struct + 540) = 222;
		*(ref @struct + 541) = 16;
		*(ref @struct + 542) = 129;
		*(ref @struct + 543) = 5;
		*(ref @struct + 544) = 1;
		*(ref @struct + 545) = 0;
		*(ref @struct + 546) = 222;
		*(ref @struct + 547) = 16;
		*(ref @struct + 548) = 130;
		*(ref @struct + 549) = 5;
		*(ref @struct + 550) = 1;
		*(ref @struct + 551) = 0;
		*(ref @struct + 552) = 222;
		*(ref @struct + 553) = 16;
		*(ref @struct + 554) = 131;
		*(ref @struct + 555) = 5;
		*(ref @struct + 556) = 1;
		*(ref @struct + 557) = 0;
		*(ref @struct + 558) = 222;
		*(ref @struct + 559) = 16;
		*(ref @struct + 560) = 132;
		*(ref @struct + 561) = 5;
		*(ref @struct + 562) = 1;
		*(ref @struct + 563) = 0;
		*(ref @struct + 564) = 222;
		*(ref @struct + 565) = 16;
		*(ref @struct + 566) = 133;
		*(ref @struct + 567) = 5;
		*(ref @struct + 568) = 1;
		*(ref @struct + 569) = 0;
		*(ref @struct + 570) = 222;
		*(ref @struct + 571) = 16;
		*(ref @struct + 572) = 134;
		*(ref @struct + 573) = 5;
		*(ref @struct + 574) = 1;
		*(ref @struct + 575) = 0;
		*(ref @struct + 576) = 222;
		*(ref @struct + 577) = 16;
		*(ref @struct + 578) = 135;
		*(ref @struct + 579) = 5;
		*(ref @struct + 580) = 1;
		*(ref @struct + 581) = 0;
		*(ref @struct + 582) = 222;
		*(ref @struct + 583) = 16;
		*(ref @struct + 584) = 136;
		*(ref @struct + 585) = 5;
		*(ref @struct + 586) = 1;
		*(ref @struct + 587) = 0;
		*(ref @struct + 588) = 222;
		*(ref @struct + 589) = 16;
		*(ref @struct + 590) = 137;
		*(ref @struct + 591) = 5;
		*(ref @struct + 592) = 1;
		*(ref @struct + 593) = 0;
		*(ref @struct + 594) = 222;
		*(ref @struct + 595) = 16;
		*(ref @struct + 596) = 138;
		*(ref @struct + 597) = 5;
		*(ref @struct + 598) = 1;
		*(ref @struct + 599) = 0;
		*(ref @struct + 600) = 222;
		*(ref @struct + 601) = 16;
		*(ref @struct + 602) = 139;
		*(ref @struct + 603) = 5;
		*(ref @struct + 604) = 1;
		*(ref @struct + 605) = 0;
		*(ref @struct + 606) = 222;
		*(ref @struct + 607) = 16;
		*(ref @struct + 608) = 140;
		*(ref @struct + 609) = 5;
		*(ref @struct + 610) = 1;
		*(ref @struct + 611) = 0;
		*(ref @struct + 612) = 222;
		*(ref @struct + 613) = 16;
		*(ref @struct + 614) = 141;
		*(ref @struct + 615) = 5;
		*(ref @struct + 616) = 1;
		*(ref @struct + 617) = 0;
		*(ref @struct + 618) = 222;
		*(ref @struct + 619) = 16;
		*(ref @struct + 620) = 142;
		*(ref @struct + 621) = 5;
		*(ref @struct + 622) = 1;
		*(ref @struct + 623) = 0;
		*(ref @struct + 624) = 222;
		*(ref @struct + 625) = 16;
		*(ref @struct + 626) = 143;
		*(ref @struct + 627) = 5;
		*(ref @struct + 628) = 1;
		*(ref @struct + 629) = 0;
		*(ref @struct + 630) = 222;
		*(ref @struct + 631) = 16;
		*(ref @struct + 632) = 240;
		*(ref @struct + 633) = 7;
		*(ref @struct + 634) = 1;
		*(ref @struct + 635) = 0;
		*(ref @struct + 636) = 222;
		*(ref @struct + 637) = 16;
		*(ref @struct + 638) = 241;
		*(ref @struct + 639) = 7;
		*(ref @struct + 640) = 1;
		*(ref @struct + 641) = 0;
		*(ref @struct + 642) = 222;
		*(ref @struct + 643) = 16;
		*(ref @struct + 644) = 242;
		*(ref @struct + 645) = 7;
		*(ref @struct + 646) = 1;
		*(ref @struct + 647) = 0;
		*(ref @struct + 648) = 222;
		*(ref @struct + 649) = 16;
		*(ref @struct + 650) = 243;
		*(ref @struct + 651) = 7;
		*(ref @struct + 652) = 1;
		*(ref @struct + 653) = 0;
		*(ref @struct + 654) = 222;
		*(ref @struct + 655) = 16;
		*(ref @struct + 656) = 244;
		*(ref @struct + 657) = 7;
		*(ref @struct + 658) = 1;
		*(ref @struct + 659) = 0;
		*(ref @struct + 660) = 222;
		*(ref @struct + 661) = 16;
		*(ref @struct + 662) = 245;
		*(ref @struct + 663) = 7;
		*(ref @struct + 664) = 1;
		*(ref @struct + 665) = 0;
		*(ref @struct + 666) = 222;
		*(ref @struct + 667) = 16;
		*(ref @struct + 668) = 246;
		*(ref @struct + 669) = 7;
		*(ref @struct + 670) = 1;
		*(ref @struct + 671) = 0;
		*(ref @struct + 672) = 222;
		*(ref @struct + 673) = 16;
		*(ref @struct + 674) = 247;
		*(ref @struct + 675) = 7;
		*(ref @struct + 676) = 1;
		*(ref @struct + 677) = 0;
		*(ref @struct + 678) = 222;
		*(ref @struct + 679) = 16;
		*(ref @struct + 680) = 248;
		*(ref @struct + 681) = 7;
		*(ref @struct + 682) = 1;
		*(ref @struct + 683) = 0;
		*(ref @struct + 684) = 222;
		*(ref @struct + 685) = 16;
		*(ref @struct + 686) = 249;
		*(ref @struct + 687) = 7;
		*(ref @struct + 688) = 1;
		*(ref @struct + 689) = 0;
		*(ref @struct + 690) = 222;
		*(ref @struct + 691) = 16;
		*(ref @struct + 692) = 250;
		*(ref @struct + 693) = 7;
		*(ref @struct + 694) = 1;
		*(ref @struct + 695) = 0;
		*(ref @struct + 696) = 222;
		*(ref @struct + 697) = 16;
		*(ref @struct + 698) = 251;
		*(ref @struct + 699) = 7;
		*(ref @struct + 700) = 1;
		*(ref @struct + 701) = 0;
		*(ref @struct + 702) = 222;
		*(ref @struct + 703) = 16;
		*(ref @struct + 704) = 208;
		*(ref @struct + 705) = 10;
		*(ref @struct + 706) = 1;
		*(ref @struct + 707) = 0;
		*(ref @struct + 708) = 222;
		*(ref @struct + 709) = 16;
		*(ref @struct + 710) = 209;
		*(ref @struct + 711) = 10;
		*(ref @struct + 712) = 1;
		*(ref @struct + 713) = 0;
		*(ref @struct + 714) = 222;
		*(ref @struct + 715) = 16;
		*(ref @struct + 716) = 210;
		*(ref @struct + 717) = 10;
		*(ref @struct + 718) = 1;
		*(ref @struct + 719) = 0;
		*(ref @struct + 720) = 222;
		*(ref @struct + 721) = 16;
		*(ref @struct + 722) = 211;
		*(ref @struct + 723) = 10;
		*(ref @struct + 724) = 1;
		*(ref @struct + 725) = 0;
		*(ref @struct + 726) = 222;
		*(ref @struct + 727) = 16;
		*(ref @struct + 728) = 212;
		*(ref @struct + 729) = 10;
		*(ref @struct + 730) = 1;
		*(ref @struct + 731) = 0;
		*(ref @struct + 732) = 222;
		*(ref @struct + 733) = 16;
		*(ref @struct + 734) = 213;
		*(ref @struct + 735) = 10;
		*(ref @struct + 736) = 1;
		*(ref @struct + 737) = 0;
		*(ref @struct + 738) = 222;
		*(ref @struct + 739) = 16;
		*(ref @struct + 740) = 214;
		*(ref @struct + 741) = 10;
		*(ref @struct + 742) = 1;
		*(ref @struct + 743) = 0;
		*(ref @struct + 744) = 222;
		*(ref @struct + 745) = 16;
		*(ref @struct + 746) = 215;
		*(ref @struct + 747) = 10;
		*(ref @struct + 748) = 1;
		*(ref @struct + 749) = 0;
		*(ref @struct + 750) = 222;
		*(ref @struct + 751) = 16;
		*(ref @struct + 752) = 216;
		*(ref @struct + 753) = 10;
		*(ref @struct + 754) = 1;
		*(ref @struct + 755) = 0;
		*(ref @struct + 756) = 222;
		*(ref @struct + 757) = 16;
		*(ref @struct + 758) = 217;
		*(ref @struct + 759) = 10;
		*(ref @struct + 760) = 1;
		*(ref @struct + 761) = 0;
		*(ref @struct + 762) = 222;
		*(ref @struct + 763) = 16;
		*(ref @struct + 764) = 218;
		*(ref @struct + 765) = 10;
		*(ref @struct + 766) = 1;
		*(ref @struct + 767) = 0;
		*(ref @struct + 768) = 222;
		*(ref @struct + 769) = 16;
		*(ref @struct + 770) = 219;
		*(ref @struct + 771) = 10;
		*(ref @struct + 772) = 1;
		*(ref @struct + 773) = 0;
		*(ref @struct + 774) = 222;
		*(ref @struct + 775) = 16;
		*(ref @struct + 776) = 180;
		*(ref @struct + 777) = 10;
		*(ref @struct + 778) = 1;
		*(ref @struct + 779) = 0;
		*(ref @struct + 780) = 222;
		*(ref @struct + 781) = 16;
		*(ref @struct + 782) = 181;
		*(ref @struct + 783) = 10;
		*(ref @struct + 784) = 1;
		*(ref @struct + 785) = 0;
		*(ref @struct + 786) = 222;
		*(ref @struct + 787) = 16;
		*(ref @struct + 788) = 182;
		*(ref @struct + 789) = 10;
		*(ref @struct + 790) = 1;
		*(ref @struct + 791) = 0;
		*(ref @struct + 792) = 222;
		*(ref @struct + 793) = 16;
		*(ref @struct + 794) = 183;
		*(ref @struct + 795) = 10;
		*(ref @struct + 796) = 1;
		*(ref @struct + 797) = 0;
		*(ref @struct + 798) = 222;
		*(ref @struct + 799) = 16;
		*(ref @struct + 800) = 184;
		*(ref @struct + 801) = 10;
		*(ref @struct + 802) = 1;
		*(ref @struct + 803) = 0;
		*(ref @struct + 804) = 222;
		*(ref @struct + 805) = 16;
		*(ref @struct + 806) = 185;
		*(ref @struct + 807) = 10;
		*(ref @struct + 808) = 1;
		*(ref @struct + 809) = 0;
		*(ref @struct + 810) = 222;
		*(ref @struct + 811) = 16;
		*(ref @struct + 812) = 186;
		*(ref @struct + 813) = 10;
		*(ref @struct + 814) = 1;
		*(ref @struct + 815) = 0;
		*(ref @struct + 816) = 222;
		*(ref @struct + 817) = 16;
		*(ref @struct + 818) = 187;
		*(ref @struct + 819) = 10;
		*(ref @struct + 820) = 1;
		*(ref @struct + 821) = 0;
		*(ref @struct + 822) = 222;
		*(ref @struct + 823) = 16;
		*(ref @struct + 824) = 188;
		*(ref @struct + 825) = 10;
		*(ref @struct + 826) = 1;
		*(ref @struct + 827) = 0;
		*(ref @struct + 828) = 222;
		*(ref @struct + 829) = 16;
		*(ref @struct + 830) = 189;
		*(ref @struct + 831) = 10;
		*(ref @struct + 832) = 1;
		*(ref @struct + 833) = 0;
		*(ref @struct + 834) = 222;
		*(ref @struct + 835) = 16;
		*(ref @struct + 836) = 190;
		*(ref @struct + 837) = 10;
		*(ref @struct + 838) = 1;
		*(ref @struct + 839) = 0;
		*(ref @struct + 840) = 222;
		*(ref @struct + 841) = 16;
		*(ref @struct + 842) = 191;
		*(ref @struct + 843) = 10;
		*(ref @struct + 844) = 1;
		*(ref @struct + 845) = 0;
		*(ref @struct + 846) = 222;
		*(ref @struct + 847) = 16;
		*(ref @struct + 848) = 132;
		*(ref @struct + 849) = 13;
		*(ref @struct + 850) = 1;
		*(ref @struct + 851) = 0;
		*(ref @struct + 852) = 222;
		*(ref @struct + 853) = 16;
		*(ref @struct + 854) = 133;
		*(ref @struct + 855) = 13;
		*(ref @struct + 856) = 1;
		*(ref @struct + 857) = 0;
		*(ref @struct + 858) = 222;
		*(ref @struct + 859) = 16;
		*(ref @struct + 860) = 134;
		*(ref @struct + 861) = 13;
		*(ref @struct + 862) = 1;
		*(ref @struct + 863) = 0;
		*(ref @struct + 864) = 222;
		*(ref @struct + 865) = 16;
		*(ref @struct + 866) = 135;
		*(ref @struct + 867) = 13;
		*(ref @struct + 868) = 1;
		*(ref @struct + 869) = 0;
		*(ref @struct + 870) = 222;
		*(ref @struct + 871) = 16;
		*(ref @struct + 872) = 136;
		*(ref @struct + 873) = 13;
		*(ref @struct + 874) = 1;
		*(ref @struct + 875) = 0;
		*(ref @struct + 876) = 222;
		*(ref @struct + 877) = 16;
		*(ref @struct + 878) = 137;
		*(ref @struct + 879) = 13;
		*(ref @struct + 880) = 1;
		*(ref @struct + 881) = 0;
		*(ref @struct + 882) = 222;
		*(ref @struct + 883) = 16;
		*(ref @struct + 884) = 138;
		*(ref @struct + 885) = 13;
		*(ref @struct + 886) = 1;
		*(ref @struct + 887) = 0;
		*(ref @struct + 888) = 222;
		*(ref @struct + 889) = 16;
		*(ref @struct + 890) = 139;
		*(ref @struct + 891) = 13;
		*(ref @struct + 892) = 1;
		*(ref @struct + 893) = 0;
		*(ref @struct + 894) = 222;
		*(ref @struct + 895) = 16;
		*(ref @struct + 896) = 140;
		*(ref @struct + 897) = 13;
		*(ref @struct + 898) = 1;
		*(ref @struct + 899) = 0;
		*(ref @struct + 900) = 222;
		*(ref @struct + 901) = 16;
		*(ref @struct + 902) = 141;
		*(ref @struct + 903) = 13;
		*(ref @struct + 904) = 1;
		*(ref @struct + 905) = 0;
		*(ref @struct + 906) = 222;
		*(ref @struct + 907) = 16;
		*(ref @struct + 908) = 142;
		*(ref @struct + 909) = 13;
		*(ref @struct + 910) = 1;
		*(ref @struct + 911) = 0;
		*(ref @struct + 912) = 222;
		*(ref @struct + 913) = 16;
		*(ref @struct + 914) = 143;
		*(ref @struct + 915) = 13;
		*(ref @struct + 916) = 1;
		*(ref @struct + 917) = 0;
		*(ref @struct + 918) = 57;
		*(ref @struct + 919) = 16;
		*(ref @struct + 920) = 132;
		*(ref @struct + 921) = 17;
		*(ref @struct + 922) = 1;
		*(ref @struct + 923) = 0;
		*(ref @struct + 924) = 57;
		*(ref @struct + 925) = 16;
		*(ref @struct + 926) = 133;
		*(ref @struct + 927) = 17;
		*(ref @struct + 928) = 1;
		*(ref @struct + 929) = 0;
		*(ref @struct + 930) = 57;
		*(ref @struct + 931) = 16;
		*(ref @struct + 932) = 134;
		*(ref @struct + 933) = 1;
		*(ref @struct + 934) = 1;
		*(ref @struct + 935) = 0;
		*(ref @struct + 936) = 171;
		*(ref @struct + 937) = 17;
		*(ref @struct + 938) = 69;
		*(ref @struct + 939) = 97;
		*(ref @struct + 940) = 1;
		*(ref @struct + 941) = 0;
		*(ref @struct + 942) = 171;
		*(ref @struct + 943) = 17;
		*(ref @struct + 944) = 33;
		*(ref @struct + 945) = 97;
		*(ref @struct + 946) = 1;
		*(ref @struct + 947) = 0;
		*(ref @struct + 948) = 75;
		*(ref @struct + 949) = 27;
		*(ref @struct + 950) = 35;
		*(ref @struct + 951) = 145;
		*(ref @struct + 952) = 1;
		*(ref @struct + 953) = 0;
		*(ref @struct + 954) = 75;
		*(ref @struct + 955) = 27;
		*(ref @struct + 956) = 37;
		*(ref @struct + 957) = 145;
		*(ref @struct + 958) = 1;
		*(ref @struct + 959) = 0;
		*(ref @struct + 960) = 75;
		*(ref @struct + 961) = 27;
		*(ref @struct + 962) = 163;
		*(ref @struct + 963) = 145;
		*(ref @struct + 964) = 1;
		*(ref @struct + 965) = 0;
		*(ref @struct + 966) = 90;
		*(ref @struct + 967) = 16;
		*(ref @struct + 968) = 32;
		*(ref @struct + 969) = 63;
		*(ref @struct + 970) = 1;
		*(ref @struct + 971) = 0;
		*(ref @struct + 972) = 66;
		*(ref @struct + 973) = 16;
		*(ref @struct + 974) = 32;
		*(ref @struct + 975) = 48;
		*(ref @struct + 976) = 0;
		*(ref @struct + 977) = 0;
		*(ref @struct + 978) = 18;
		*(ref @struct + 979) = 148;
		*(ref @struct + 980) = 101;
		*(ref @struct + 981) = 101;
		*(ref @struct + 982) = 0;
		*(ref @struct + 983) = 0;
		*(ref @struct + 984) = 96;
		*(ref @struct + 985) = 16;
		*(ref @struct + 986) = 1;
		*(ref @struct + 987) = 1;
		*(ref @struct + 988) = 0;
		*(ref @struct + 989) = 0;
		*(ref @struct + 990) = 96;
		*(ref @struct + 991) = 16;
		*(ref @struct + 992) = 106;
		*(ref @struct + 993) = 136;
		*(ref @struct + 994) = 0;
		*(ref @struct + 995) = 0;
		*(ref @struct + 996) = 96;
		*(ref @struct + 997) = 16;
		*(ref @struct + 998) = 58;
		*(ref @struct + 999) = 103;
		*(ref @struct + 1000) = 0;
		*(ref @struct + 1001) = 0;
		*(ref @struct + 1002) = 136;
		*(ref @struct + 1003) = 51;
		*(ref @struct + 1004) = 19;
		*(ref @struct + 1005) = 128;
		*(ref @struct + 1006) = 0;
		*(ref @struct + 1007) = 0;
		*(ref @struct + 1008) = 6;
		*(ref @struct + 1009) = 17;
		*(ref @struct + 1010) = 97;
		*(ref @struct + 1011) = 5;
		*(ref @struct + 1012) = 0;
		*(ref @struct + 1013) = 0;
		*(ref @struct + 1014) = 69;
		*(ref @struct + 1015) = 16;
		*(ref @struct + 1016) = 88;
		*(ref @struct + 1017) = 197;
		*(ref @struct + 1018) = 0;
		*(ref @struct + 1019) = 0;
		*(ref @struct + 1020) = 202;
		*(ref @struct + 1021) = 22;
		*(ref @struct + 1022) = 1;
		*(ref @struct + 1023) = 0;
		*(ref @struct + 1024) = 0;
		*(ref @struct + 1025) = 0;
		*(ref @struct + 1026) = 222;
		*(ref @struct + 1027) = 16;
		*(ref @struct + 1028) = 133;
		*(ref @struct + 1029) = 13;
		*(ref @struct + 1030) = 0;
		*(ref @struct + 1031) = 0;
		*(ref @struct + 1032) = 107;
		*(ref @struct + 1033) = 16;
		*(ref @struct + 1034) = 137;
		*(ref @struct + 1035) = 203;
		*(ref @struct + 1036) = 0;
		*(ref @struct + 1037) = 0;
		*(ref @struct + 1038) = 121;
		*(ref @struct + 1039) = 17;
		*(ref @struct + 1040) = 1;
		*(ref @struct + 1041) = 1;
		*(ref @struct + 1042) = 0;
		*(ref @struct + 1043) = 0;
		*(ref @struct + 1044) = 121;
		*(ref @struct + 1045) = 17;
		*(ref @struct + 1046) = 2;
		*(ref @struct + 1047) = 1;
		*(ref @struct + 1048) = 0;
		*(ref @struct + 1049) = 0;
		*(ref @struct + 1050) = 121;
		*(ref @struct + 1051) = 17;
		*(ref @struct + 1052) = 3;
		*(ref @struct + 1053) = 1;
		*(ref @struct + 1054) = 0;
		*(ref @struct + 1055) = 0;
		*(ref @struct + 1056) = 121;
		*(ref @struct + 1057) = 17;
		*(ref @struct + 1058) = 5;
		*(ref @struct + 1059) = 1;
		*(ref @struct + 1060) = 0;
		*(ref @struct + 1061) = 0;
		*(ref @struct + 1062) = 134;
		*(ref @struct + 1063) = 128;
		*(ref @struct + 1064) = 16;
		*(ref @struct + 1065) = 112;
		*(ref @struct + 1066) = 0;
		*(ref @struct + 1067) = 0;
		*(ref @struct + 1068) = 134;
		*(ref @struct + 1069) = 128;
		*(ref @struct + 1070) = 17;
		*(ref @struct + 1071) = 113;
		*(ref @struct + 1072) = 0;
		*(ref @struct + 1073) = 0;
		*(ref @struct + 1074) = 134;
		*(ref @struct + 1075) = 128;
		*(ref @struct + 1076) = 17;
		*(ref @struct + 1077) = 113;
		*(ref @struct + 1078) = 0;
		*(ref @struct + 1079) = 0;
		*(ref @struct + 1080) = 134;
		*(ref @struct + 1081) = 128;
		*(ref @struct + 1082) = 153;
		*(ref @struct + 1083) = 113;
		*(ref @struct + 1084) = 0;
		*(ref @struct + 1085) = 0;
		*(ref @struct + 1086) = 134;
		*(ref @struct + 1087) = 128;
		*(ref @struct + 1088) = 1;
		*(ref @struct + 1089) = 118;
		*(ref @struct + 1090) = 0;
		*(ref @struct + 1091) = 0;
		*(ref @struct + 1092) = 134;
		*(ref @struct + 1093) = 128;
		*(ref @struct + 1094) = 202;
		*(ref @struct + 1095) = 132;
		*(ref @struct + 1096) = 0;
		*(ref @struct + 1097) = 0;
		*(ref @struct + 1098) = 134;
		*(ref @struct + 1099) = 128;
		*(ref @struct + 1100) = 17;
		*(ref @struct + 1101) = 36;
		*(ref @struct + 1102) = 0;
		*(ref @struct + 1103) = 0;
		*(ref @struct + 1104) = 134;
		*(ref @struct + 1105) = 128;
		*(ref @struct + 1106) = 33;
		*(ref @struct + 1107) = 36;
		*(ref @struct + 1108) = 0;
		*(ref @struct + 1109) = 0;
		*(ref @struct + 1110) = 134;
		*(ref @struct + 1111) = 128;
		*(ref @struct + 1112) = 74;
		*(ref @struct + 1113) = 36;
		*(ref @struct + 1114) = 0;
		*(ref @struct + 1115) = 0;
		*(ref @struct + 1116) = 134;
		*(ref @struct + 1117) = 128;
		*(ref @struct + 1118) = 75;
		*(ref @struct + 1119) = 36;
		*(ref @struct + 1120) = 0;
		*(ref @struct + 1121) = 0;
		*(ref @struct + 1122) = 134;
		*(ref @struct + 1123) = 128;
		*(ref @struct + 1124) = 138;
		*(ref @struct + 1125) = 36;
		*(ref @struct + 1126) = 0;
		*(ref @struct + 1127) = 0;
		*(ref @struct + 1128) = 134;
		*(ref @struct + 1129) = 128;
		*(ref @struct + 1130) = 139;
		*(ref @struct + 1131) = 36;
		*(ref @struct + 1132) = 0;
		*(ref @struct + 1133) = 0;
		*(ref @struct + 1134) = 134;
		*(ref @struct + 1135) = 128;
		*(ref @struct + 1136) = 193;
		*(ref @struct + 1137) = 36;
		*(ref @struct + 1138) = 0;
		*(ref @struct + 1139) = 0;
		*(ref @struct + 1140) = 134;
		*(ref @struct + 1141) = 128;
		*(ref @struct + 1142) = 202;
		*(ref @struct + 1143) = 36;
		*(ref @struct + 1144) = 0;
		*(ref @struct + 1145) = 0;
		*(ref @struct + 1146) = 134;
		*(ref @struct + 1147) = 128;
		*(ref @struct + 1148) = 203;
		*(ref @struct + 1149) = 36;
		*(ref @struct + 1150) = 0;
		*(ref @struct + 1151) = 0;
		*(ref @struct + 1152) = 134;
		*(ref @struct + 1153) = 128;
		*(ref @struct + 1154) = 219;
		*(ref @struct + 1155) = 36;
		*(ref @struct + 1156) = 0;
		*(ref @struct + 1157) = 0;
		*(ref @struct + 1158) = 134;
		*(ref @struct + 1159) = 128;
		*(ref @struct + 1160) = 91;
		*(ref @struct + 1161) = 36;
		*(ref @struct + 1162) = 0;
		*(ref @struct + 1163) = 0;
		*(ref @struct + 1164) = 134;
		*(ref @struct + 1165) = 128;
		*(ref @struct + 1166) = 162;
		*(ref @struct + 1167) = 37;
		*(ref @struct + 1168) = 0;
		*(ref @struct + 1169) = 0;
		*(ref @struct + 1170) = 134;
		*(ref @struct + 1171) = 128;
		*(ref @struct + 1172) = 111;
		*(ref @struct + 1173) = 38;
		*(ref @struct + 1174) = 0;
		*(ref @struct + 1175) = 0;
		*(ref @struct + 1176) = 134;
		*(ref @struct + 1177) = 128;
		*(ref @struct + 1178) = 223;
		*(ref @struct + 1179) = 39;
		*(ref @struct + 1180) = 0;
		*(ref @struct + 1181) = 0;
		*(ref @struct + 1182) = 134;
		*(ref @struct + 1183) = 128;
		*(ref @struct + 1184) = 158;
		*(ref @struct + 1185) = 38;
		*(ref @struct + 1186) = 0;
		*(ref @struct + 1187) = 0;
		*(ref @struct + 1188) = 134;
		*(ref @struct + 1189) = 128;
		*(ref @struct + 1190) = 80;
		*(ref @struct + 1191) = 40;
		*(ref @struct + 1192) = 0;
		*(ref @struct + 1193) = 0;
		*(ref @struct + 1194) = 134;
		*(ref @struct + 1195) = 128;
		*(ref @struct + 1196) = 209;
		*(ref @struct + 1197) = 36;
		*(ref @struct + 1198) = 1;
		*(ref @struct + 1199) = 0;
		*(ref @struct + 1200) = 134;
		*(ref @struct + 1201) = 128;
		*(ref @struct + 1202) = 223;
		*(ref @struct + 1203) = 36;
		*(ref @struct + 1204) = 1;
		*(ref @struct + 1205) = 0;
		*(ref @struct + 1206) = 134;
		*(ref @struct + 1207) = 128;
		*(ref @struct + 1208) = 163;
		*(ref @struct + 1209) = 37;
		*(ref @struct + 1210) = 1;
		*(ref @struct + 1211) = 0;
		*(ref @struct + 1212) = 134;
		*(ref @struct + 1213) = 128;
		*(ref @struct + 1214) = 176;
		*(ref @struct + 1215) = 37;
		*(ref @struct + 1216) = 1;
		*(ref @struct + 1217) = 0;
		*(ref @struct + 1218) = 134;
		*(ref @struct + 1219) = 128;
		*(ref @struct + 1220) = 81;
		*(ref @struct + 1221) = 38;
		*(ref @struct + 1222) = 1;
		*(ref @struct + 1223) = 0;
		*(ref @struct + 1224) = 134;
		*(ref @struct + 1225) = 128;
		*(ref @struct + 1226) = 82;
		*(ref @struct + 1227) = 38;
		*(ref @struct + 1228) = 1;
		*(ref @struct + 1229) = 0;
		*(ref @struct + 1230) = 134;
		*(ref @struct + 1231) = 128;
		*(ref @struct + 1232) = 83;
		*(ref @struct + 1233) = 38;
		*(ref @struct + 1234) = 1;
		*(ref @struct + 1235) = 0;
		*(ref @struct + 1236) = 134;
		*(ref @struct + 1237) = 128;
		*(ref @struct + 1238) = 192;
		*(ref @struct + 1239) = 39;
		*(ref @struct + 1240) = 1;
		*(ref @struct + 1241) = 0;
		*(ref @struct + 1242) = 134;
		*(ref @struct + 1243) = 128;
		*(ref @struct + 1244) = 196;
		*(ref @struct + 1245) = 39;
		*(ref @struct + 1246) = 1;
		*(ref @struct + 1247) = 0;
		*(ref @struct + 1248) = 134;
		*(ref @struct + 1249) = 128;
		*(ref @struct + 1250) = 128;
		*(ref @struct + 1251) = 38;
		*(ref @struct + 1252) = 1;
		*(ref @struct + 1253) = 0;
		*(ref @struct + 1254) = 134;
		*(ref @struct + 1255) = 128;
		*(ref @struct + 1256) = 32;
		*(ref @struct + 1257) = 40;
		*(ref @struct + 1258) = 1;
		*(ref @struct + 1259) = 0;
		*(ref @struct + 1260) = 134;
		*(ref @struct + 1261) = 128;
		*(ref @struct + 1262) = 37;
		*(ref @struct + 1263) = 40;
		*(ref @struct + 1264) = 1;
		*(ref @struct + 1265) = 0;
		*(ref @struct + 1266) = 134;
		*(ref @struct + 1267) = 128;
		*(ref @struct + 1268) = 40;
		*(ref @struct + 1269) = 40;
		*(ref @struct + 1270) = 1;
		*(ref @struct + 1271) = 0;
		*(ref @struct + 1272) = 134;
		*(ref @struct + 1273) = 128;
		*(ref @struct + 1274) = 40;
		*(ref @struct + 1275) = 40;
		*(ref @struct + 1276) = 1;
		*(ref @struct + 1277) = 0;
		*(ref @struct + 1278) = 134;
		*(ref @struct + 1279) = 128;
		*(ref @struct + 1280) = 40;
		*(ref @struct + 1281) = 40;
		*(ref @struct + 1282) = 1;
		*(ref @struct + 1283) = 0;
		*(ref @struct + 1284) = 134;
		*(ref @struct + 1285) = 128;
		*(ref @struct + 1286) = 40;
		*(ref @struct + 1287) = 40;
		*(ref @struct + 1288) = 1;
		*(ref @struct + 1289) = 0;
		*(ref @struct + 1290) = 134;
		*(ref @struct + 1291) = 128;
		*(ref @struct + 1292) = 32;
		*(ref @struct + 1293) = 41;
		*(ref @struct + 1294) = 1;
		*(ref @struct + 1295) = 0;
		*(ref @struct + 1296) = 134;
		*(ref @struct + 1297) = 128;
		*(ref @struct + 1298) = 33;
		*(ref @struct + 1299) = 41;
		*(ref @struct + 1300) = 1;
		*(ref @struct + 1301) = 0;
		*(ref @struct + 1302) = 134;
		*(ref @struct + 1303) = 128;
		*(ref @struct + 1304) = 38;
		*(ref @struct + 1305) = 41;
		*(ref @struct + 1306) = 1;
		*(ref @struct + 1307) = 0;
		*(ref @struct + 1308) = 134;
		*(ref @struct + 1309) = 128;
		*(ref @struct + 1310) = 40;
		*(ref @struct + 1311) = 41;
		*(ref @struct + 1312) = 1;
		*(ref @struct + 1313) = 0;
		*(ref @struct + 1314) = 134;
		*(ref @struct + 1315) = 128;
		*(ref @struct + 1316) = 45;
		*(ref @struct + 1317) = 41;
		*(ref @struct + 1318) = 1;
		*(ref @struct + 1319) = 0;
		*(ref @struct + 1320) = 134;
		*(ref @struct + 1321) = 128;
		*(ref @struct + 1322) = 46;
		*(ref @struct + 1323) = 41;
		*(ref @struct + 1324) = 1;
		*(ref @struct + 1325) = 0;
		*(ref @struct + 1326) = 134;
		*(ref @struct + 1327) = 128;
		*(ref @struct + 1328) = 40;
		*(ref @struct + 1329) = 80;
		*(ref @struct + 1330) = 1;
		*(ref @struct + 1331) = 0;
		*(ref @struct + 1332) = 134;
		*(ref @struct + 1333) = 128;
		*(ref @struct + 1334) = 0;
		*(ref @struct + 1335) = 58;
		*(ref @struct + 1336) = 1;
		*(ref @struct + 1337) = 0;
		*(ref @struct + 1338) = 134;
		*(ref @struct + 1339) = 128;
		*(ref @struct + 1340) = 6;
		*(ref @struct + 1341) = 58;
		*(ref @struct + 1342) = 1;
		*(ref @struct + 1343) = 0;
		*(ref @struct + 1344) = 134;
		*(ref @struct + 1345) = 128;
		*(ref @struct + 1346) = 32;
		*(ref @struct + 1347) = 58;
		*(ref @struct + 1348) = 1;
		*(ref @struct + 1349) = 0;
		*(ref @struct + 1350) = 134;
		*(ref @struct + 1351) = 128;
		*(ref @struct + 1352) = 38;
		*(ref @struct + 1353) = 58;
		*(ref @struct + 1354) = 1;
		*(ref @struct + 1355) = 0;
		*(ref @struct + 1356) = 134;
		*(ref @struct + 1357) = 128;
		*(ref @struct + 1358) = 32;
		*(ref @struct + 1359) = 59;
		*(ref @struct + 1360) = 1;
		*(ref @struct + 1361) = 0;
		*(ref @struct + 1362) = 134;
		*(ref @struct + 1363) = 128;
		*(ref @struct + 1364) = 33;
		*(ref @struct + 1365) = 59;
		*(ref @struct + 1366) = 1;
		*(ref @struct + 1367) = 0;
		*(ref @struct + 1368) = 134;
		*(ref @struct + 1369) = 128;
		*(ref @struct + 1370) = 38;
		*(ref @struct + 1371) = 59;
		*(ref @struct + 1372) = 1;
		*(ref @struct + 1373) = 0;
		*(ref @struct + 1374) = 134;
		*(ref @struct + 1375) = 128;
		*(ref @struct + 1376) = 40;
		*(ref @struct + 1377) = 59;
		*(ref @struct + 1378) = 1;
		*(ref @struct + 1379) = 0;
		*(ref @struct + 1380) = 134;
		*(ref @struct + 1381) = 128;
		*(ref @struct + 1382) = 45;
		*(ref @struct + 1383) = 59;
		*(ref @struct + 1384) = 1;
		*(ref @struct + 1385) = 0;
		*(ref @struct + 1386) = 134;
		*(ref @struct + 1387) = 128;
		*(ref @struct + 1388) = 46;
		*(ref @struct + 1389) = 59;
		*(ref @struct + 1390) = 1;
		*(ref @struct + 1391) = 0;
		*(ref @struct + 1392) = 134;
		*(ref @struct + 1393) = 128;
		*(ref @struct + 1394) = 0;
		*(ref @struct + 1395) = 28;
		*(ref @struct + 1396) = 1;
		*(ref @struct + 1397) = 0;
		*(ref @struct + 1398) = 134;
		*(ref @struct + 1399) = 128;
		*(ref @struct + 1400) = 1;
		*(ref @struct + 1401) = 28;
		*(ref @struct + 1402) = 1;
		*(ref @struct + 1403) = 0;
		*(ref @struct + 1404) = 134;
		*(ref @struct + 1405) = 128;
		*(ref @struct + 1406) = 8;
		*(ref @struct + 1407) = 28;
		*(ref @struct + 1408) = 1;
		*(ref @struct + 1409) = 0;
		*(ref @struct + 1410) = 134;
		*(ref @struct + 1411) = 128;
		*(ref @struct + 1412) = 9;
		*(ref @struct + 1413) = 28;
		*(ref @struct + 1414) = 1;
		*(ref @struct + 1415) = 0;
		*(ref @struct + 1416) = 134;
		*(ref @struct + 1417) = 128;
		*(ref @struct + 1418) = 0;
		*(ref @struct + 1419) = 29;
		*(ref @struct + 1420) = 1;
		*(ref @struct + 1421) = 0;
		*(ref @struct + 1422) = 134;
		*(ref @struct + 1423) = 128;
		*(ref @struct + 1424) = 8;
		*(ref @struct + 1425) = 29;
		*(ref @struct + 1426) = 1;
		*(ref @struct + 1427) = 0;
		*(ref @struct + 1428) = 134;
		*(ref @struct + 1429) = 128;
		*(ref @struct + 1430) = 0;
		*(ref @struct + 1431) = 30;
		*(ref @struct + 1432) = 1;
		*(ref @struct + 1433) = 0;
		*(ref @struct + 1434) = 134;
		*(ref @struct + 1435) = 128;
		*(ref @struct + 1436) = 1;
		*(ref @struct + 1437) = 30;
		*(ref @struct + 1438) = 1;
		*(ref @struct + 1439) = 0;
		*(ref @struct + 1440) = 134;
		*(ref @struct + 1441) = 128;
		*(ref @struct + 1442) = 8;
		*(ref @struct + 1443) = 30;
		*(ref @struct + 1444) = 1;
		*(ref @struct + 1445) = 0;
		*(ref @struct + 1446) = 134;
		*(ref @struct + 1447) = 128;
		*(ref @struct + 1448) = 9;
		*(ref @struct + 1449) = 30;
		*(ref @struct + 1450) = 1;
		*(ref @struct + 1451) = 0;
		*(ref @struct + 1452) = 185;
		*(ref @struct + 1453) = 16;
		*(ref @struct + 1454) = 40;
		*(ref @struct + 1455) = 82;
		*(ref @struct + 1456) = 0;
		*(ref @struct + 1457) = 0;
		*(ref @struct + 1458) = 185;
		*(ref @struct + 1459) = 16;
		*(ref @struct + 1460) = 41;
		*(ref @struct + 1461) = 82;
		*(ref @struct + 1462) = 0;
		*(ref @struct + 1463) = 0;
		*(ref @struct + 1464) = 34;
		*(ref @struct + 1465) = 16;
		*(ref @struct + 1466) = 1;
		*(ref @struct + 1467) = 116;
		*(ref @struct + 1468) = 0;
		*(ref @struct + 1469) = 0;
		*(ref @struct + 1470) = 34;
		*(ref @struct + 1471) = 16;
		*(ref @struct + 1472) = 9;
		*(ref @struct + 1473) = 116;
		*(ref @struct + 1474) = 0;
		*(ref @struct + 1475) = 0;
		*(ref @struct + 1476) = 34;
		*(ref @struct + 1477) = 16;
		*(ref @struct + 1478) = 17;
		*(ref @struct + 1479) = 116;
		*(ref @struct + 1480) = 0;
		*(ref @struct + 1481) = 0;
		*(ref @struct + 1482) = 34;
		*(ref @struct + 1483) = 16;
		*(ref @struct + 1484) = 65;
		*(ref @struct + 1485) = 116;
		*(ref @struct + 1486) = 0;
		*(ref @struct + 1487) = 0;
		*(ref @struct + 1488) = 34;
		*(ref @struct + 1489) = 16;
		*(ref @struct + 1490) = 105;
		*(ref @struct + 1491) = 116;
		*(ref @struct + 1492) = 0;
		*(ref @struct + 1493) = 0;
		*(ref @struct + 1494) = 222;
		*(ref @struct + 1495) = 16;
		*(ref @struct + 1496) = 188;
		*(ref @struct + 1497) = 1;
		*(ref @struct + 1498) = 0;
		*(ref @struct + 1499) = 0;
		*(ref @struct + 1500) = 222;
		*(ref @struct + 1501) = 16;
		*(ref @struct + 1502) = 101;
		*(ref @struct + 1503) = 0;
		*(ref @struct + 1504) = 0;
		*(ref @struct + 1505) = 0;
		*(ref @struct + 1506) = 222;
		*(ref @struct + 1507) = 16;
		*(ref @struct + 1508) = 133;
		*(ref @struct + 1509) = 0;
		*(ref @struct + 1510) = 0;
		*(ref @struct + 1511) = 0;
		*(ref @struct + 1512) = 222;
		*(ref @struct + 1513) = 16;
		*(ref @struct + 1514) = 213;
		*(ref @struct + 1515) = 0;
		*(ref @struct + 1516) = 0;
		*(ref @struct + 1517) = 0;
		*(ref @struct + 1518) = 222;
		*(ref @struct + 1519) = 16;
		*(ref @struct + 1520) = 229;
		*(ref @struct + 1521) = 0;
		*(ref @struct + 1522) = 0;
		*(ref @struct + 1523) = 0;
		*(ref @struct + 1524) = 222;
		*(ref @struct + 1525) = 16;
		*(ref @struct + 1526) = 83;
		*(ref @struct + 1527) = 0;
		*(ref @struct + 1528) = 0;
		*(ref @struct + 1529) = 0;
		*(ref @struct + 1530) = 222;
		*(ref @struct + 1531) = 16;
		*(ref @struct + 1532) = 53;
		*(ref @struct + 1533) = 0;
		*(ref @struct + 1534) = 0;
		*(ref @struct + 1535) = 0;
		*(ref @struct + 1536) = 222;
		*(ref @struct + 1537) = 16;
		*(ref @struct + 1538) = 101;
		*(ref @struct + 1539) = 2;
		*(ref @struct + 1540) = 0;
		*(ref @struct + 1541) = 0;
		*(ref @struct + 1542) = 222;
		*(ref @struct + 1543) = 16;
		*(ref @struct + 1544) = 110;
		*(ref @struct + 1545) = 3;
		*(ref @struct + 1546) = 0;
		*(ref @struct + 1547) = 0;
		*(ref @struct + 1548) = 222;
		*(ref @struct + 1549) = 16;
		*(ref @struct + 1550) = 236;
		*(ref @struct + 1551) = 3;
		*(ref @struct + 1552) = 0;
		*(ref @struct + 1553) = 0;
		*(ref @struct + 1554) = 222;
		*(ref @struct + 1555) = 16;
		*(ref @struct + 1556) = 72;
		*(ref @struct + 1557) = 4;
		*(ref @struct + 1558) = 0;
		*(ref @struct + 1559) = 0;
		*(ref @struct + 1560) = 222;
		*(ref @struct + 1561) = 16;
		*(ref @struct + 1562) = 96;
		*(ref @struct + 1563) = 5;
		*(ref @struct + 1564) = 0;
		*(ref @struct + 1565) = 0;
		*(ref @struct + 1566) = 222;
		*(ref @struct + 1567) = 16;
		*(ref @struct + 1568) = 108;
		*(ref @struct + 1569) = 5;
		*(ref @struct + 1570) = 0;
		*(ref @struct + 1571) = 0;
		*(ref @struct + 1572) = 222;
		*(ref @struct + 1573) = 16;
		*(ref @struct + 1574) = 89;
		*(ref @struct + 1575) = 7;
		*(ref @struct + 1576) = 0;
		*(ref @struct + 1577) = 0;
		*(ref @struct + 1578) = 34;
		*(ref @struct + 1579) = 16;
		*(ref @struct + 1580) = 154;
		*(ref @struct + 1581) = 32;
		*(ref @struct + 1582) = 0;
		*(ref @struct + 1583) = 0;
		*(ref @struct + 1584) = 145;
		*(ref @struct + 1585) = 17;
		*(ref @struct + 1586) = 5;
		*(ref @struct + 1587) = 0;
		*(ref @struct + 1588) = 0;
		*(ref @struct + 1589) = 0;
		*(ref @struct + 1590) = 145;
		*(ref @struct + 1591) = 17;
		*(ref @struct + 1592) = 6;
		*(ref @struct + 1593) = 0;
		*(ref @struct + 1594) = 0;
		*(ref @struct + 1595) = 0;
		*(ref @struct + 1596) = 145;
		*(ref @struct + 1597) = 17;
		*(ref @struct + 1598) = 7;
		*(ref @struct + 1599) = 0;
		*(ref @struct + 1600) = 0;
		*(ref @struct + 1601) = 0;
		*(ref @struct + 1602) = 145;
		*(ref @struct + 1603) = 17;
		*(ref @struct + 1604) = 8;
		*(ref @struct + 1605) = 0;
		*(ref @struct + 1606) = 0;
		*(ref @struct + 1607) = 0;
		*(ref @struct + 1608) = 145;
		*(ref @struct + 1609) = 17;
		*(ref @struct + 1610) = 9;
		*(ref @struct + 1611) = 0;
		*(ref @struct + 1612) = 0;
		*(ref @struct + 1613) = 0;
		*(ref @struct + 1614) = 2;
		*(ref @struct + 1615) = 16;
		*(ref @struct + 1616) = 73;
		*(ref @struct + 1617) = 67;
		*(ref @struct + 1618) = 0;
		*(ref @struct + 1619) = 0;
		*(ref @struct + 1620) = 2;
		*(ref @struct + 1621) = 16;
		*(ref @struct + 1622) = 105;
		*(ref @struct + 1623) = 67;
		*(ref @struct + 1624) = 0;
		*(ref @struct + 1625) = 0;
		*(ref @struct + 1626) = 2;
		*(ref @struct + 1627) = 16;
		*(ref @struct + 1628) = 118;
		*(ref @struct + 1629) = 67;
		*(ref @struct + 1630) = 0;
		*(ref @struct + 1631) = 0;
		*(ref @struct + 1632) = 2;
		*(ref @struct + 1633) = 16;
		*(ref @struct + 1634) = 140;
		*(ref @struct + 1635) = 67;
		*(ref @struct + 1636) = 0;
		*(ref @struct + 1637) = 0;
		*(ref @struct + 1638) = 2;
		*(ref @struct + 1639) = 16;
		*(ref @struct + 1640) = 156;
		*(ref @struct + 1641) = 67;
		*(ref @struct + 1642) = 0;
		*(ref @struct + 1643) = 0;
		*(ref @struct + 1644) = 34;
		*(ref @struct + 1645) = 16;
		*(ref @struct + 1646) = 12;
		*(ref @struct + 1647) = 120;
		*(ref @struct + 1648) = 0;
		*(ref @struct + 1649) = 0;
		*(ref @struct + 1650) = 145;
		*(ref @struct + 1651) = 17;
		*(ref @struct + 1652) = 10;
		*(ref @struct + 1653) = 0;
		*(ref @struct + 1654) = 0;
		*(ref @struct + 1655) = 0;
		*(ref @struct + 1656) = 145;
		*(ref @struct + 1657) = 17;
		*(ref @struct + 1658) = 11;
		*(ref @struct + 1659) = 0;
		*(ref @struct + 1660) = 0;
		*(ref @struct + 1661) = 0;
		*(ref @struct + 1662) = 149;
		*(ref @struct + 1663) = 16;
		*(ref @struct + 1664) = 64;
		*(ref @struct + 1665) = 6;
		*(ref @struct + 1666) = 0;
		*(ref @struct + 1667) = 0;
		*(ref @struct + 1668) = 149;
		*(ref @struct + 1669) = 16;
		*(ref @struct + 1670) = 67;
		*(ref @struct + 1671) = 6;
		*(ref @struct + 1672) = 0;
		*(ref @struct + 1673) = 0;
		*(ref @struct + 1674) = 149;
		*(ref @struct + 1675) = 16;
		*(ref @struct + 1676) = 70;
		*(ref @struct + 1677) = 6;
		*(ref @struct + 1678) = 0;
		*(ref @struct + 1679) = 0;
		*(ref @struct + 1680) = 149;
		*(ref @struct + 1681) = 16;
		*(ref @struct + 1682) = 72;
		*(ref @struct + 1683) = 6;
		*(ref @struct + 1684) = 0;
		*(ref @struct + 1685) = 0;
		*(ref @struct + 1686) = 149;
		*(ref @struct + 1687) = 16;
		*(ref @struct + 1688) = 73;
		*(ref @struct + 1689) = 6;
		*(ref @struct + 1690) = 0;
		*(ref @struct + 1691) = 0;
		*(ref @struct + 1692) = 120;
		*(ref @struct + 1693) = 16;
		*(ref @struct + 1694) = 0;
		*(ref @struct + 1695) = 0;
		*(ref @struct + 1696) = 0;
		*(ref @struct + 1697) = 0;
		*(ref @struct + 1698) = 120;
		*(ref @struct + 1699) = 16;
		*(ref @struct + 1700) = 2;
		*(ref @struct + 1701) = 0;
		*(ref @struct + 1702) = 0;
		*(ref @struct + 1703) = 0;
		*(ref @struct + 1704) = 120;
		*(ref @struct + 1705) = 16;
		*(ref @struct + 1706) = 2;
		*(ref @struct + 1707) = 1;
		*(ref @struct + 1708) = 0;
		*(ref @struct + 1709) = 0;
		*(ref @struct + 1710) = 11;
		*(ref @struct + 1711) = 16;
		*(ref @struct + 1712) = 45;
		*(ref @struct + 1713) = 0;
		*(ref @struct + 1714) = 0;
		*(ref @struct + 1715) = 0;
		*(ref @struct + 1716) = 34;
		*(ref @struct + 1717) = 16;
		*(ref @struct + 1718) = 143;
		*(ref @struct + 1719) = 32;
		*(ref @struct + 1720) = 0;
		*(ref @struct + 1721) = 0;
		*(ref @struct + 1722) = 34;
		*(ref @struct + 1723) = 16;
		*(ref @struct + 1724) = 154;
		*(ref @struct + 1725) = 32;
		*(ref @struct + 1726) = 0;
		*(ref @struct + 1727) = 0;
		*(ref @struct + 1728) = 128;
		*(ref @struct + 1729) = 16;
		*(ref @struct + 1730) = 147;
		*(ref @struct + 1731) = 198;
		*(ref @struct + 1732) = 0;
		*(ref @struct + 1733) = 0;
		*(ref @struct + 1734) = 85;
		*(ref @struct + 1735) = 16;
		*(ref @struct + 1736) = 48;
		*(ref @struct + 1737) = 145;
		*(ref @struct + 1738) = 0;
		*(ref @struct + 1739) = 0;
		*(ref @struct + 1740) = 3;
		*(ref @struct + 1741) = 17;
		*(ref @struct + 1742) = 4;
		*(ref @struct + 1743) = 0;
		*(ref @struct + 1744) = 0;
		*(ref @struct + 1745) = 0;
		*(ref @struct + 1746) = 3;
		*(ref @struct + 1747) = 17;
		*(ref @struct + 1748) = 4;
		*(ref @struct + 1749) = 0;
		*(ref @struct + 1750) = 0;
		*(ref @struct + 1751) = 0;
		*(ref @struct + 1752) = 3;
		*(ref @struct + 1753) = 17;
		*(ref @struct + 1754) = 7;
		*(ref @struct + 1755) = 0;
		*(ref @struct + 1756) = 0;
		*(ref @struct + 1757) = 0;
		*(ref @struct + 1758) = 3;
		*(ref @struct + 1759) = 17;
		*(ref @struct + 1760) = 5;
		*(ref @struct + 1761) = 0;
		*(ref @struct + 1762) = 0;
		*(ref @struct + 1763) = 0;
		*(ref @struct + 1764) = 3;
		*(ref @struct + 1765) = 17;
		*(ref @struct + 1766) = 8;
		*(ref @struct + 1767) = 0;
		*(ref @struct + 1768) = 0;
		*(ref @struct + 1769) = 0;
		*(ref @struct + 1770) = 3;
		*(ref @struct + 1771) = 17;
		*(ref @struct + 1772) = 6;
		*(ref @struct + 1773) = 0;
		*(ref @struct + 1774) = 0;
		*(ref @struct + 1775) = 0;
		*(ref @struct + 1776) = 3;
		*(ref @struct + 1777) = 17;
		*(ref @struct + 1778) = 4;
		*(ref @struct + 1779) = 0;
		*(ref @struct + 1780) = 0;
		*(ref @struct + 1781) = 0;
		*(ref @struct + 1782) = 3;
		*(ref @struct + 1783) = 17;
		*(ref @struct + 1784) = 7;
		*(ref @struct + 1785) = 0;
		*(ref @struct + 1786) = 0;
		*(ref @struct + 1787) = 0;
		*(ref @struct + 1788) = 3;
		*(ref @struct + 1789) = 17;
		*(ref @struct + 1790) = 5;
		*(ref @struct + 1791) = 0;
		*(ref @struct + 1792) = 0;
		*(ref @struct + 1793) = 0;
		*(ref @struct + 1794) = 3;
		*(ref @struct + 1795) = 17;
		*(ref @struct + 1796) = 6;
		*(ref @struct + 1797) = 0;
		*(ref @struct + 1798) = 0;
		*(ref @struct + 1799) = 0;
		*(ref @struct + 1800) = 3;
		*(ref @struct + 1801) = 17;
		*(ref @struct + 1802) = 9;
		*(ref @struct + 1803) = 0;
		*(ref @struct + 1804) = 0;
		*(ref @struct + 1805) = 0;
		*(ref @struct + 1806) = 3;
		*(ref @struct + 1807) = 17;
		*(ref @struct + 1808) = 3;
		*(ref @struct + 1809) = 0;
		*(ref @struct + 1810) = 0;
		*(ref @struct + 1811) = 0;
		*(ref @struct + 1812) = 131;
		*(ref @struct + 1813) = 18;
		*(ref @struct + 1814) = 19;
		*(ref @struct + 1815) = 130;
		*(ref @struct + 1816) = 0;
		*(ref @struct + 1817) = 0;
		*(ref @struct + 1818) = 131;
		*(ref @struct + 1819) = 18;
		*(ref @struct + 1820) = 17;
		*(ref @struct + 1821) = 130;
		*(ref @struct + 1822) = 0;
		*(ref @struct + 1823) = 0;
		*(ref @struct + 1824) = 131;
		*(ref @struct + 1825) = 18;
		*(ref @struct + 1826) = 18;
		*(ref @struct + 1827) = 130;
		*(ref @struct + 1828) = 0;
		*(ref @struct + 1829) = 0;
		*(ref @struct + 1830) = 243;
		*(ref @struct + 1831) = 23;
		*(ref @struct + 1832) = 16;
		*(ref @struct + 1833) = 16;
		*(ref @struct + 1834) = 0;
		*(ref @struct + 1835) = 0;
		*(ref @struct + 1836) = 107;
		*(ref @struct + 1837) = 16;
		*(ref @struct + 1838) = 51;
		*(ref @struct + 1839) = 0;
		*(ref @struct + 1840) = 0;
		*(ref @struct + 1841) = 0;
		*(ref @struct + 1842) = 107;
		*(ref @struct + 1843) = 16;
		*(ref @struct + 1844) = 59;
		*(ref @struct + 1845) = 0;
		*(ref @struct + 1846) = 0;
		*(ref @struct + 1847) = 0;
		*(ref @struct + 1848) = 107;
		*(ref @struct + 1849) = 16;
		*(ref @struct + 1850) = 67;
		*(ref @struct + 1851) = 0;
		*(ref @struct + 1852) = 0;
		*(ref @struct + 1853) = 0;
		*(ref @struct + 1854) = 107;
		*(ref @struct + 1855) = 16;
		*(ref @struct + 1856) = 80;
		*(ref @struct + 1857) = 0;
		*(ref @struct + 1858) = 0;
		*(ref @struct + 1859) = 0;
		*(ref @struct + 1860) = 107;
		*(ref @struct + 1861) = 16;
		*(ref @struct + 1862) = 105;
		*(ref @struct + 1863) = 0;
		*(ref @struct + 1864) = 0;
		*(ref @struct + 1865) = 0;
		*(ref @struct + 1866) = 171;
		*(ref @struct + 1867) = 17;
		*(ref @struct + 1868) = 1;
		*(ref @struct + 1869) = 97;
		*(ref @struct + 1870) = 0;
		*(ref @struct + 1871) = 0;
		*(ref @struct + 1872) = 171;
		*(ref @struct + 1873) = 17;
		*(ref @struct + 1874) = 33;
		*(ref @struct + 1875) = 97;
		*(ref @struct + 1876) = 0;
		*(ref @struct + 1877) = 0;
		*(ref @struct + 1878) = 171;
		*(ref @struct + 1879) = 17;
		*(ref @struct + 1880) = 35;
		*(ref @struct + 1881) = 97;
		*(ref @struct + 1882) = 0;
		*(ref @struct + 1883) = 0;
		*(ref @struct + 1884) = 171;
		*(ref @struct + 1885) = 17;
		*(ref @struct + 1886) = 69;
		*(ref @struct + 1887) = 97;
		*(ref @struct + 1888) = 0;
		*(ref @struct + 1889) = 0;
		*(ref @struct + 1890) = 75;
		*(ref @struct + 1891) = 27;
		*(ref @struct + 1892) = 160;
		*(ref @struct + 1893) = 145;
		*(ref @struct + 1894) = 0;
		*(ref @struct + 1895) = 0;
		*(ref @struct + 1896) = 75;
		*(ref @struct + 1897) = 27;
		*(ref @struct + 1898) = 164;
		*(ref @struct + 1899) = 145;
		*(ref @struct + 1900) = 0;
		*(ref @struct + 1901) = 0;
		*(ref @struct + 1902) = 134;
		*(ref @struct + 1903) = 128;
		*(ref @struct + 1904) = 52;
		*(ref @struct + 1905) = 18;
		*(ref @struct + 1906) = 0;
		*(ref @struct + 1907) = 0;
		*(ref @struct + 1908) = 156;
		*(ref @struct + 1909) = 22;
		*(ref @struct + 1910) = 68;
		*(ref @struct + 1911) = 0;
		*(ref @struct + 1912) = 0;
		*(ref @struct + 1913) = 0;
		*(ref @struct + 1914) = 252;
		*(ref @struct + 1915) = 16;
		*(ref @struct + 1916) = 3;
		*(ref @struct + 1917) = 0;
		*(ref @struct + 1918) = 0;
		*(ref @struct + 1919) = 0;
		*(ref @struct + 1920) = 69;
		*(ref @struct + 1921) = 17;
		*(ref @struct + 1922) = 8;
		*(ref @struct + 1923) = 128;
		*(ref @struct + 1924) = 0;
		*(ref @struct + 1925) = 0;
		*(ref @struct + 1926) = 69;
		*(ref @struct + 1927) = 17;
		*(ref @struct + 1928) = 8;
		*(ref @struct + 1929) = 240;
		*(ref @struct + 1930) = 0;
		*(ref @struct + 1931) = 0;
		*(ref @struct + 1932) = 69;
		*(ref @struct + 1933) = 17;
		*(ref @struct + 1934) = 33;
		*(ref @struct + 1935) = 240;
		*(ref @struct + 1936) = 0;
		*(ref @struct + 1937) = 0;
		*(ref @struct + 1938) = 69;
		*(ref @struct + 1939) = 17;
		*(ref @struct + 1940) = 36;
		*(ref @struct + 1941) = 240;
		*(ref @struct + 1942) = 0;
		*(ref @struct + 1943) = 0;
		*(ref @struct + 1944) = 69;
		*(ref @struct + 1945) = 17;
		*(ref @struct + 1946) = 44;
		*(ref @struct + 1947) = 240;
		*(ref @struct + 1948) = 0;
		*(ref @struct + 1949) = 0;
		*(ref @struct + 1950) = 11;
		*(ref @struct + 1951) = 16;
		*(ref @struct + 1952) = 1;
		*(ref @struct + 1953) = 208;
		*(ref @struct + 1954) = 0;
		*(ref @struct + 1955) = 0;
		*(ref @struct + 1956) = 11;
		*(ref @struct + 1957) = 16;
		*(ref @struct + 1958) = 2;
		*(ref @struct + 1959) = 0;
		*(ref @struct + 1960) = 0;
		*(ref @struct + 1961) = 0;
		*(ref @struct + 1962) = 134;
		*(ref @struct + 1963) = 128;
		*(ref @struct + 1964) = 48;
		*(ref @struct + 1965) = 18;
		*(ref @struct + 1966) = 0;
		*(ref @struct + 1967) = 0;
		*(ref @struct + 1968) = 69;
		*(ref @struct + 1969) = 16;
		*(ref @struct + 1970) = 33;
		*(ref @struct + 1971) = 198;
		*(ref @struct + 1972) = 0;
		*(ref @struct + 1973) = 0;
		*(ref @struct + 1974) = 69;
		*(ref @struct + 1975) = 16;
		*(ref @struct + 1976) = 104;
		*(ref @struct + 1977) = 213;
		*(ref @struct + 1978) = 0;
		*(ref @struct + 1979) = 0;
		*(ref @struct + 1980) = 69;
		*(ref @struct + 1981) = 16;
		*(ref @struct + 1982) = 104;
		*(ref @struct + 1983) = 213;
		*(ref @struct + 1984) = 0;
		*(ref @struct + 1985) = 0;
		*(ref @struct + 1986) = 90;
		*(ref @struct + 1987) = 16;
		*(ref @struct + 1988) = 104;
		*(ref @struct + 1989) = 77;
		*(ref @struct + 1990) = 0;
		*(ref @struct + 1991) = 0;
		*(ref @struct + 1992) = 90;
		*(ref @struct + 1993) = 16;
		*(ref @struct + 1994) = 105;
		*(ref @struct + 1995) = 77;
		*(ref @struct + 1996) = 0;
		*(ref @struct + 1997) = 0;
		*(ref @struct + 1998) = 90;
		*(ref @struct + 1999) = 16;
		*(ref @struct + 2000) = 104;
		*(ref @struct + 2001) = 98;
		*(ref @struct + 2002) = 0;
		*(ref @struct + 2003) = 0;
		*(ref @struct + 2004) = 90;
		*(ref @struct + 2005) = 16;
		*(ref @struct + 2006) = 105;
		*(ref @struct + 2007) = 98;
		*(ref @struct + 2008) = 0;
		*(ref @struct + 2009) = 0;
		*(ref @struct + 2010) = 90;
		*(ref @struct + 2011) = 16;
		*(ref @struct + 2012) = 117;
		*(ref @struct + 2013) = 18;
		*(ref @struct + 2014) = 0;
		*(ref @struct + 2015) = 0;
		*(ref @struct + 2016) = 90;
		*(ref @struct + 2017) = 16;
		*(ref @struct + 2018) = 117;
		*(ref @struct + 2019) = 82;
		*(ref @struct + 2020) = 0;
		*(ref @struct + 2021) = 0;
		*(ref @struct + 2022) = 90;
		*(ref @struct + 2023) = 16;
		*(ref @struct + 2024) = 117;
		*(ref @struct + 2025) = 114;
		*(ref @struct + 2026) = 0;
		*(ref @struct + 2027) = 0;
		*(ref @struct + 2028) = 90;
		*(ref @struct + 2029) = 16;
		*(ref @struct + 2030) = 51;
		*(ref @struct + 2031) = 77;
		*(ref @struct + 2032) = 0;
		*(ref @struct + 2033) = 0;
		*(ref @struct + 2034) = 90;
		*(ref @struct + 2035) = 16;
		*(ref @struct + 2036) = 56;
		*(ref @struct + 2037) = 77;
		*(ref @struct + 2038) = 0;
		*(ref @struct + 2039) = 0;
		*(ref @struct + 2040) = 90;
		*(ref @struct + 2041) = 16;
		*(ref @struct + 2042) = 56;
		*(ref @struct + 2043) = 13;
		*(ref @struct + 2044) = 0;
		*(ref @struct + 2045) = 0;
		*(ref @struct + 2046) = 90;
		*(ref @struct + 2047) = 16;
		*(ref @struct + 2048) = 48;
		*(ref @struct + 2049) = 13;
		*(ref @struct + 2050) = 0;
		*(ref @struct + 2051) = 0;
		*(ref @struct + 2052) = 90;
		*(ref @struct + 2053) = 16;
		*(ref @struct + 2054) = 48;
		*(ref @struct + 2055) = 77;
		*(ref @struct + 2056) = 0;
		*(ref @struct + 2057) = 0;
		*(ref @struct + 2058) = 121;
		*(ref @struct + 2059) = 17;
		*(ref @struct + 2060) = 1;
		*(ref @struct + 2061) = 1;
		*(ref @struct + 2062) = 0;
		*(ref @struct + 2063) = 0;
		*(ref @struct + 2064) = 121;
		*(ref @struct + 2065) = 17;
		*(ref @struct + 2066) = 2;
		*(ref @struct + 2067) = 1;
		*(ref @struct + 2068) = 0;
		*(ref @struct + 2069) = 0;
		*(ref @struct + 2070) = 121;
		*(ref @struct + 2071) = 17;
		*(ref @struct + 2072) = 3;
		*(ref @struct + 2073) = 1;
		*(ref @struct + 2074) = 0;
		*(ref @struct + 2075) = 0;
		*(ref @struct + 2076) = 121;
		*(ref @struct + 2077) = 17;
		*(ref @struct + 2078) = 5;
		*(ref @struct + 2079) = 1;
		*(ref @struct + 2080) = 0;
		*(ref @struct + 2081) = 0;
		*(ref @struct + 2082) = 49;
		*(ref @struct + 2083) = 19;
		*(ref @struct + 2084) = 1;
		*(ref @struct + 2085) = 130;
		*(ref @struct + 2086) = 0;
		*(ref @struct + 2087) = 0;
		*(ref @struct + 2088) = 243;
		*(ref @struct + 2089) = 23;
		*(ref @struct + 2090) = 17;
		*(ref @struct + 2091) = 16;
		*(ref @struct + 2092) = 0;
		*(ref @struct + 2093) = 0;
		*(ref @struct + 2094) = 243;
		*(ref @struct + 2095) = 23;
		*(ref @struct + 2096) = 18;
		*(ref @struct + 2097) = 16;
		*(ref @struct + 2098) = 0;
		*(ref @struct + 2099) = 0;
		*(ref @struct + 2100) = 66;
		*(ref @struct + 2101) = 16;
		*(ref @struct + 2102) = 0;
		*(ref @struct + 2103) = 16;
		*(ref @struct + 2104) = 0;
		*(ref @struct + 2105) = 0;
		*(ref @struct + 2106) = 66;
		*(ref @struct + 2107) = 16;
		*(ref @struct + 2108) = 1;
		*(ref @struct + 2109) = 16;
		*(ref @struct + 2110) = 0;
		*(ref @struct + 2111) = 0;
		*(ref @struct + 2112) = 11;
		*(ref @struct + 2113) = 16;
		*(ref @struct + 2114) = 2;
		*(ref @struct + 2115) = 5;
		*(ref @struct + 2116) = 0;
		*(ref @struct + 2117) = 0;
		*(ref @struct + 2118) = 47;
		*(ref @struct + 2119) = 16;
		*(ref @struct + 2120) = 180;
		*(ref @struct + 2121) = 1;
		*(ref @struct + 2122) = 0;
		*(ref @struct + 2123) = 0;
		*(ref @struct + 2124) = 134;
		*(ref @struct + 2125) = 128;
		*(ref @struct + 2126) = 26;
		*(ref @struct + 2127) = 129;
		*(ref @struct + 2128) = 0;
		*(ref @struct + 2129) = 0;
		*(ref @struct + 2130) = 102;
		*(ref @struct + 2131) = 17;
		*(ref @struct + 2132) = 17;
		*(ref @struct + 2133) = 2;
		*(ref @struct + 2134) = 0;
		*(ref @struct + 2135) = 0;
		*(ref @struct + 2136) = 102;
		*(ref @struct + 2137) = 17;
		*(ref @struct + 2138) = 18;
		*(ref @struct + 2139) = 2;
		*(ref @struct + 2140) = 0;
		*(ref @struct + 2141) = 0;
		*(ref @struct + 2142) = 102;
		*(ref @struct + 2143) = 17;
		*(ref @struct + 2144) = 19;
		*(ref @struct + 2145) = 2;
		*(ref @struct + 2146) = 0;
		*(ref @struct + 2147) = 0;
		*(ref @struct + 2148) = 102;
		*(ref @struct + 2149) = 17;
		*(ref @struct + 2150) = 23;
		*(ref @struct + 2151) = 2;
		*(ref @struct + 2152) = 0;
		*(ref @struct + 2153) = 0;
		*(ref @struct + 2154) = 102;
		*(ref @struct + 2155) = 17;
		*(ref @struct + 2156) = 20;
		*(ref @struct + 2157) = 2;
		*(ref @struct + 2158) = 0;
		*(ref @struct + 2159) = 0;
		*(ref @struct + 2160) = 149;
		*(ref @struct + 2161) = 16;
		*(ref @struct + 2162) = 128;
		*(ref @struct + 2163) = 6;
		*(ref @struct + 2164) = 0;
		*(ref @struct + 2165) = 0;
		*(ref @struct + 2166) = 57;
		*(ref @struct + 2167) = 16;
		*(ref @struct + 2168) = 19;
		*(ref @struct + 2169) = 85;
		*(ref @struct + 2170) = 0;
		*(ref @struct + 2171) = 0;
		*(ref @struct + 2172) = 57;
		*(ref @struct + 2173) = 16;
		*(ref @struct + 2174) = 24;
		*(ref @struct + 2175) = 85;
		*(ref @struct + 2176) = 0;
		*(ref @struct + 2177) = 0;
		*(ref @struct + 2178) = 57;
		*(ref @struct + 2179) = 16;
		*(ref @struct + 2180) = 128;
		*(ref @struct + 2181) = 17;
		*(ref @struct + 2182) = 0;
		*(ref @struct + 2183) = 0;
		*(ref @struct + 2184) = 173;
		*(ref @struct + 2185) = 16;
		*(ref @struct + 2186) = 5;
		*(ref @struct + 2187) = 1;
		*(ref @struct + 2188) = 0;
		*(ref @struct + 2189) = 0;
		*(ref @struct + 2190) = 17;
		*(ref @struct + 2191) = 14;
		*(ref @struct + 2192) = 51;
		*(ref @struct + 2193) = 174;
		*(ref @struct + 2194) = 0;
		*(ref @struct + 2195) = 0;
		*(ref @struct + 2196) = 6;
		*(ref @struct + 2197) = 17;
		*(ref @struct + 2198) = 21;
		*(ref @struct + 2199) = 4;
		*(ref @struct + 2200) = 0;
		*(ref @struct + 2201) = 0;
		*(ref @struct + 2202) = 6;
		*(ref @struct + 2203) = 17;
		*(ref @struct + 2204) = 113;
		*(ref @struct + 2205) = 5;
		*(ref @struct + 2206) = 0;
		*(ref @struct + 2207) = 0;
		*(ref @struct + 2208) = 6;
		*(ref @struct + 2209) = 17;
		*(ref @struct + 2210) = 129;
		*(ref @struct + 2211) = 5;
		*(ref @struct + 2212) = 0;
		*(ref @struct + 2213) = 0;
		*(ref @struct + 2214) = 6;
		*(ref @struct + 2215) = 17;
		*(ref @struct + 2216) = 113;
		*(ref @struct + 2217) = 21;
		*(ref @struct + 2218) = 0;
		*(ref @struct + 2219) = 0;
		*(ref @struct + 2220) = 6;
		*(ref @struct + 2221) = 17;
		*(ref @struct + 2222) = 100;
		*(ref @struct + 2223) = 49;
		*(ref @struct + 2224) = 0;
		*(ref @struct + 2225) = 0;
		*(ref @struct + 2226) = 6;
		*(ref @struct + 2227) = 17;
		*(ref @struct + 2228) = 36;
		*(ref @struct + 2229) = 83;
		*(ref @struct + 2230) = 0;
		*(ref @struct + 2231) = 0;
		*(ref @struct + 2232) = 6;
		*(ref @struct + 2233) = 17;
		*(ref @struct + 2234) = 9;
		*(ref @struct + 2235) = 196;
		*(ref @struct + 2236) = 0;
		*(ref @struct + 2237) = 0;
		*(ref @struct + 2238) = 6;
		*(ref @struct + 2239) = 17;
		*(ref @struct + 2240) = 1;
		*(ref @struct + 2241) = 144;
		*(ref @struct + 2242) = 0;
		*(ref @struct + 2243) = 0;
		*(ref @struct + 2244) = 233;
		*(ref @struct + 2245) = 21;
		*(ref @struct + 2246) = 65;
		*(ref @struct + 2247) = 24;
		*(ref @struct + 2248) = 1;
		*(ref @struct + 2249) = 0;
		*(ref @struct + 2250) = 1;
		*(ref @struct + 2251) = 17;
		*(ref @struct + 2252) = 34;
		*(ref @struct + 2253) = 22;
		*(ref @struct + 2254) = 1;
		*(ref @struct + 2255) = 0;
		*(ref @struct + 2256) = 171;
		*(ref @struct + 2257) = 17;
		*(ref @struct + 2258) = 64;
		*(ref @struct + 2259) = 80;
		*(ref @struct + 2260) = 1;
		*(ref @struct + 2261) = 0;
		*(ref @struct + 2262) = 171;
		*(ref @struct + 2263) = 17;
		*(ref @struct + 2264) = 65;
		*(ref @struct + 2265) = 80;
		*(ref @struct + 2266) = 1;
		*(ref @struct + 2267) = 0;
		*(ref @struct + 2268) = 171;
		*(ref @struct + 2269) = 17;
		*(ref @struct + 2270) = 128;
		*(ref @struct + 2271) = 80;
		*(ref @struct + 2272) = 1;
		*(ref @struct + 2273) = 0;
		*(ref @struct + 2274) = 171;
		*(ref @struct + 2275) = 17;
		*(ref @struct + 2276) = 129;
		*(ref @struct + 2277) = 80;
		*(ref @struct + 2278) = 1;
		*(ref @struct + 2279) = 0;
		*(ref @struct + 2280) = 3;
		*(ref @struct + 2281) = 17;
		*(ref @struct + 2282) = 32;
		*(ref @struct + 2283) = 23;
		*(ref @struct + 2284) = 1;
		*(ref @struct + 2285) = 0;
		*(ref @struct + 2286) = 3;
		*(ref @struct + 2287) = 17;
		*(ref @struct + 2288) = 64;
		*(ref @struct + 2289) = 23;
		*(ref @struct + 2290) = 1;
		*(ref @struct + 2291) = 0;
		*(ref @struct + 2292) = 3;
		*(ref @struct + 2293) = 17;
		*(ref @struct + 2294) = 66;
		*(ref @struct + 2295) = 23;
		*(ref @struct + 2296) = 1;
		*(ref @struct + 2297) = 0;
		*(ref @struct + 2298) = 171;
		*(ref @struct + 2299) = 17;
		*(ref @struct + 2300) = 64;
		*(ref @struct + 2301) = 96;
		*(ref @struct + 2302) = 1;
		*(ref @struct + 2303) = 0;
		*(ref @struct + 2304) = 171;
		*(ref @struct + 2305) = 17;
		*(ref @struct + 2306) = 65;
		*(ref @struct + 2307) = 96;
		*(ref @struct + 2308) = 1;
		*(ref @struct + 2309) = 0;
		*(ref @struct + 2310) = 171;
		*(ref @struct + 2311) = 17;
		*(ref @struct + 2312) = 66;
		*(ref @struct + 2313) = 96;
		*(ref @struct + 2314) = 1;
		*(ref @struct + 2315) = 0;
		*(ref @struct + 2316) = 171;
		*(ref @struct + 2317) = 17;
		*(ref @struct + 2318) = 128;
		*(ref @struct + 2319) = 96;
		*(ref @struct + 2320) = 1;
		*(ref @struct + 2321) = 0;
		*(ref @struct + 2322) = 171;
		*(ref @struct + 2323) = 17;
		*(ref @struct + 2324) = 129;
		*(ref @struct + 2325) = 96;
		*(ref @struct + 2326) = 1;
		*(ref @struct + 2327) = 0;
		*(ref @struct + 2328) = 5;
		*(ref @struct + 2329) = 144;
		*(ref @struct + 2330) = 65;
		*(ref @struct + 2331) = 2;
		*(ref @struct + 2332) = 1;
		*(ref @struct + 2333) = 0;
		*(ref @struct + 2334) = 5;
		*(ref @struct + 2335) = 144;
		*(ref @struct + 2336) = 67;
		*(ref @struct + 2337) = 2;
		*(ref @struct + 2338) = 1;
		*(ref @struct + 2339) = 0;
		*(ref @struct + 2340) = 171;
		*(ref @struct + 2341) = 17;
		*(ref @struct + 2342) = 66;
		*(ref @struct + 2343) = 112;
		*(ref @struct + 2344) = 1;
		*(ref @struct + 2345) = 0;
		*(ref @struct + 2346) = 3;
		*(ref @struct + 2347) = 17;
		*(ref @struct + 2348) = 0;
		*(ref @struct + 2349) = 35;
		*(ref @struct + 2350) = 1;
		*(ref @struct + 2351) = 0;
		*(ref @struct + 2352) = 3;
		*(ref @struct + 2353) = 17;
		*(ref @struct + 2354) = 16;
		*(ref @struct + 2355) = 35;
		*(ref @struct + 2356) = 1;
		*(ref @struct + 2357) = 0;
		*(ref @struct + 2358) = 222;
		*(ref @struct + 2359) = 16;
		*(ref @struct + 2360) = 142;
		*(ref @struct + 2361) = 0;
		*(ref @struct + 2362) = 1;
		*(ref @struct + 2363) = 0;
		*(ref @struct + 2364) = 222;
		*(ref @struct + 2365) = 16;
		*(ref @struct + 2366) = 227;
		*(ref @struct + 2367) = 0;
		*(ref @struct + 2368) = 1;
		*(ref @struct + 2369) = 0;
		*(ref @struct + 2370) = 222;
		*(ref @struct + 2371) = 16;
		*(ref @struct + 2372) = 238;
		*(ref @struct + 2373) = 0;
		*(ref @struct + 2374) = 1;
		*(ref @struct + 2375) = 0;
		*(ref @struct + 2376) = 222;
		*(ref @struct + 2377) = 16;
		*(ref @struct + 2378) = 84;
		*(ref @struct + 2379) = 0;
		*(ref @struct + 2380) = 1;
		*(ref @struct + 2381) = 0;
		*(ref @struct + 2382) = 222;
		*(ref @struct + 2383) = 16;
		*(ref @struct + 2384) = 85;
		*(ref @struct + 2385) = 0;
		*(ref @struct + 2386) = 1;
		*(ref @struct + 2387) = 0;
		*(ref @struct + 2388) = 222;
		*(ref @struct + 2389) = 16;
		*(ref @struct + 2390) = 54;
		*(ref @struct + 2391) = 0;
		*(ref @struct + 2392) = 1;
		*(ref @struct + 2393) = 0;
		*(ref @struct + 2394) = 222;
		*(ref @struct + 2395) = 16;
		*(ref @struct + 2396) = 62;
		*(ref @struct + 2397) = 0;
		*(ref @struct + 2398) = 1;
		*(ref @struct + 2399) = 0;
		*(ref @struct + 2400) = 222;
		*(ref @struct + 2401) = 16;
		*(ref @struct + 2402) = 102;
		*(ref @struct + 2403) = 2;
		*(ref @struct + 2404) = 1;
		*(ref @struct + 2405) = 0;
		*(ref @struct + 2406) = 222;
		*(ref @struct + 2407) = 16;
		*(ref @struct + 2408) = 103;
		*(ref @struct + 2409) = 2;
		*(ref @struct + 2410) = 1;
		*(ref @struct + 2411) = 0;
		*(ref @struct + 2412) = 222;
		*(ref @struct + 2413) = 16;
		*(ref @struct + 2414) = 126;
		*(ref @struct + 2415) = 3;
		*(ref @struct + 2416) = 1;
		*(ref @struct + 2417) = 0;
		*(ref @struct + 2418) = 222;
		*(ref @struct + 2419) = 16;
		*(ref @struct + 2420) = 127;
		*(ref @struct + 2421) = 3;
		*(ref @struct + 2422) = 1;
		*(ref @struct + 2423) = 0;
		*(ref @struct + 2424) = 222;
		*(ref @struct + 2425) = 16;
		*(ref @struct + 2426) = 231;
		*(ref @struct + 2427) = 3;
		*(ref @struct + 2428) = 1;
		*(ref @struct + 2429) = 0;
		*(ref @struct + 2430) = 222;
		*(ref @struct + 2431) = 16;
		*(ref @struct + 2432) = 246;
		*(ref @struct + 2433) = 3;
		*(ref @struct + 2434) = 1;
		*(ref @struct + 2435) = 0;
		*(ref @struct + 2436) = 222;
		*(ref @struct + 2437) = 16;
		*(ref @struct + 2438) = 247;
		*(ref @struct + 2439) = 3;
		*(ref @struct + 2440) = 1;
		*(ref @struct + 2441) = 0;
		*(ref @struct + 2442) = 90;
		*(ref @struct + 2443) = 16;
		*(ref @struct + 2444) = 113;
		*(ref @struct + 2445) = 51;
		*(ref @struct + 2446) = 1;
		*(ref @struct + 2447) = 0;
		*(ref @struct + 2448) = 90;
		*(ref @struct + 2449) = 16;
		*(ref @struct + 2450) = 115;
		*(ref @struct + 2451) = 51;
		*(ref @struct + 2452) = 1;
		*(ref @struct + 2453) = 0;
		*(ref @struct + 2454) = 90;
		*(ref @struct + 2455) = 16;
		*(ref @struct + 2456) = 117;
		*(ref @struct + 2457) = 51;
		*(ref @struct + 2458) = 1;
		*(ref @struct + 2459) = 0;
		*(ref @struct + 2460) = 90;
		*(ref @struct + 2461) = 16;
		*(ref @struct + 2462) = 118;
		*(ref @struct + 2463) = 51;
		*(ref @struct + 2464) = 1;
		*(ref @struct + 2465) = 0;
		*(ref @struct + 2466) = 90;
		*(ref @struct + 2467) = 16;
		*(ref @struct + 2468) = 112;
		*(ref @struct + 2469) = 53;
		*(ref @struct + 2470) = 1;
		*(ref @struct + 2471) = 0;
		*(ref @struct + 2472) = 90;
		*(ref @struct + 2473) = 16;
		*(ref @struct + 2474) = 113;
		*(ref @struct + 2475) = 53;
		*(ref @struct + 2476) = 1;
		*(ref @struct + 2477) = 0;
		*(ref @struct + 2478) = 90;
		*(ref @struct + 2479) = 16;
		*(ref @struct + 2480) = 116;
		*(ref @struct + 2481) = 53;
		*(ref @struct + 2482) = 1;
		*(ref @struct + 2483) = 0;
		*(ref @struct + 2484) = 90;
		*(ref @struct + 2485) = 16;
		*(ref @struct + 2486) = 119;
		*(ref @struct + 2487) = 53;
		*(ref @struct + 2488) = 1;
		*(ref @struct + 2489) = 0;
		*(ref @struct + 2490) = 90;
		*(ref @struct + 2491) = 16;
		*(ref @struct + 2492) = 115;
		*(ref @struct + 2493) = 61;
		*(ref @struct + 2494) = 1;
		*(ref @struct + 2495) = 0;
		*(ref @struct + 2496) = 90;
		*(ref @struct + 2497) = 16;
		*(ref @struct + 2498) = 117;
		*(ref @struct + 2499) = 61;
		*(ref @struct + 2500) = 1;
		*(ref @struct + 2501) = 0;
		*(ref @struct + 2502) = 90;
		*(ref @struct + 2503) = 16;
		*(ref @struct + 2504) = 24;
		*(ref @struct + 2505) = 51;
		*(ref @struct + 2506) = 1;
		*(ref @struct + 2507) = 0;
		*(ref @struct + 2508) = 90;
		*(ref @struct + 2509) = 16;
		*(ref @struct + 2510) = 25;
		*(ref @struct + 2511) = 51;
		*(ref @struct + 2512) = 1;
		*(ref @struct + 2513) = 0;
		*(ref @struct + 2514) = 90;
		*(ref @struct + 2515) = 16;
		*(ref @struct + 2516) = 21;
		*(ref @struct + 2517) = 53;
		*(ref @struct + 2518) = 1;
		*(ref @struct + 2519) = 0;
		*(ref @struct + 2520) = 90;
		*(ref @struct + 2521) = 16;
		*(ref @struct + 2522) = 25;
		*(ref @struct + 2523) = 53;
		*(ref @struct + 2524) = 1;
		*(ref @struct + 2525) = 0;
		*(ref @struct + 2526) = 90;
		*(ref @struct + 2527) = 16;
		*(ref @struct + 2528) = 23;
		*(ref @struct + 2529) = 61;
		*(ref @struct + 2530) = 1;
		*(ref @struct + 2531) = 0;
		*(ref @struct + 2532) = 90;
		*(ref @struct + 2533) = 16;
		*(ref @struct + 2534) = 24;
		*(ref @struct + 2535) = 61;
		*(ref @struct + 2536) = 1;
		*(ref @struct + 2537) = 0;
		*(ref @struct + 2538) = 90;
		*(ref @struct + 2539) = 16;
		*(ref @struct + 2540) = 41;
		*(ref @struct + 2541) = 102;
		*(ref @struct + 2542) = 1;
		*(ref @struct + 2543) = 0;
		*(ref @struct + 2544) = 233;
		*(ref @struct + 2545) = 21;
		*(ref @struct + 2546) = 104;
		*(ref @struct + 2547) = 32;
		*(ref @struct + 2548) = 1;
		*(ref @struct + 2549) = 0;
		*(ref @struct + 2550) = 149;
		*(ref @struct + 2551) = 16;
		*(ref @struct + 2552) = 18;
		*(ref @struct + 2553) = 49;
		*(ref @struct + 2554) = 1;
		*(ref @struct + 2555) = 0;
		*(ref @struct + 2556) = 149;
		*(ref @struct + 2557) = 16;
		*(ref @struct + 2558) = 64;
		*(ref @struct + 2559) = 2;
		*(ref @struct + 2560) = 1;
		*(ref @struct + 2561) = 0;
		*(ref @struct + 2562) = 149;
		*(ref @struct + 2563) = 16;
		*(ref @struct + 2564) = 18;
		*(ref @struct + 2565) = 53;
		*(ref @struct + 2566) = 1;
		*(ref @struct + 2567) = 0;
		*(ref @struct + 2568) = 149;
		*(ref @struct + 2569) = 16;
		*(ref @struct + 2570) = 20;
		*(ref @struct + 2571) = 49;
		*(ref @struct + 2572) = 1;
		*(ref @struct + 2573) = 0;
		*(ref @struct + 2574) = 2;
		*(ref @struct + 2575) = 16;
		*(ref @struct + 2576) = 110;
		*(ref @struct + 2577) = 67;
		*(ref @struct + 2578) = 1;
		*(ref @struct + 2579) = 0;
		*(ref @struct + 2580) = 2;
		*(ref @struct + 2581) = 16;
		*(ref @struct + 2582) = 121;
		*(ref @struct + 2583) = 67;
		*(ref @struct + 2584) = 1;
		*(ref @struct + 2585) = 0;
		*(ref @struct + 2586) = 2;
		*(ref @struct + 2587) = 16;
		*(ref @struct + 2588) = 122;
		*(ref @struct + 2589) = 67;
		*(ref @struct + 2590) = 1;
		*(ref @struct + 2591) = 0;
		*(ref @struct + 2592) = 149;
		*(ref @struct + 2593) = 16;
		*(ref @struct + 2594) = 36;
		*(ref @struct + 2595) = 49;
		*(ref @struct + 2596) = 1;
		*(ref @struct + 2597) = 0;
		*(ref @struct + 2598) = 134;
		*(ref @struct + 2599) = 128;
		*(ref @struct + 2600) = 36;
		*(ref @struct + 2601) = 49;
		*(ref @struct + 2602) = 1;
		*(ref @struct + 2603) = 0;
		*(ref @struct + 2604) = 149;
		*(ref @struct + 2605) = 16;
		*(ref @struct + 2606) = 50;
		*(ref @struct + 2607) = 49;
		*(ref @struct + 2608) = 1;
		*(ref @struct + 2609) = 0;
		*(ref @struct + 2610) = 149;
		*(ref @struct + 2611) = 16;
		*(ref @struct + 2612) = 66;
		*(ref @struct + 2613) = 2;
		*(ref @struct + 2614) = 1;
		*(ref @struct + 2615) = 0;
		*(ref @struct + 2616) = 149;
		*(ref @struct + 2617) = 16;
		*(ref @struct + 2618) = 68;
		*(ref @struct + 2619) = 2;
		*(ref @struct + 2620) = 1;
		*(ref @struct + 2621) = 0;
		*(ref @struct + 2622) = 149;
		*(ref @struct + 2623) = 16;
		*(ref @struct + 2624) = 49;
		*(ref @struct + 2625) = 49;
		*(ref @struct + 2626) = 1;
		*(ref @struct + 2627) = 0;
		*(ref @struct + 2628) = 149;
		*(ref @struct + 2629) = 16;
		*(ref @struct + 2630) = 49;
		*(ref @struct + 2631) = 53;
		*(ref @struct + 2632) = 1;
		*(ref @struct + 2633) = 0;
		*(ref @struct + 2634) = 57;
		*(ref @struct + 2635) = 16;
		*(ref @struct + 2636) = 128;
		*(ref @struct + 2637) = 1;
		*(ref @struct + 2638) = 1;
		*(ref @struct + 2639) = 0;
		*(ref @struct + 2640) = 57;
		*(ref @struct + 2641) = 16;
		*(ref @struct + 2642) = 129;
		*(ref @struct + 2643) = 1;
		*(ref @struct + 2644) = 1;
		*(ref @struct + 2645) = 0;
		*(ref @struct + 2646) = 57;
		*(ref @struct + 2647) = 16;
		*(ref @struct + 2648) = 130;
		*(ref @struct + 2649) = 1;
		*(ref @struct + 2650) = 1;
		*(ref @struct + 2651) = 0;
		*(ref @struct + 2652) = 57;
		*(ref @struct + 2653) = 16;
		*(ref @struct + 2654) = 131;
		*(ref @struct + 2655) = 1;
		*(ref @struct + 2656) = 1;
		*(ref @struct + 2657) = 0;
		*(ref @struct + 2658) = 57;
		*(ref @struct + 2659) = 16;
		*(ref @struct + 2660) = 130;
		*(ref @struct + 2661) = 17;
		*(ref @struct + 2662) = 1;
		*(ref @struct + 2663) = 0;
		*(ref @struct + 2664) = 57;
		*(ref @struct + 2665) = 16;
		*(ref @struct + 2666) = 131;
		*(ref @struct + 2667) = 17;
		*(ref @struct + 2668) = 1;
		*(ref @struct + 2669) = 0;
		*(ref @struct + 2670) = 102;
		*(ref @struct + 2671) = 17;
		*(ref @struct + 2672) = 64;
		*(ref @struct + 2673) = 2;
		*(ref @struct + 2674) = 1;
		*(ref @struct + 2675) = 0;
		*(ref @struct + 2676) = 102;
		*(ref @struct + 2677) = 17;
		*(ref @struct + 2678) = 65;
		*(ref @struct + 2679) = 2;
		*(ref @struct + 2680) = 1;
		*(ref @struct + 2681) = 0;
		*(ref @struct + 2682) = 102;
		*(ref @struct + 2683) = 17;
		*(ref @struct + 2684) = 66;
		*(ref @struct + 2685) = 2;
		*(ref @struct + 2686) = 1;
		*(ref @struct + 2687) = 0;
		*(ref @struct + 2688) = 102;
		*(ref @struct + 2689) = 17;
		*(ref @struct + 2690) = 74;
		*(ref @struct + 2691) = 2;
		*(ref @struct + 2692) = 1;
		*(ref @struct + 2693) = 0;
		*(ref @struct + 2694) = 102;
		*(ref @struct + 2695) = 17;
		*(ref @struct + 2696) = 75;
		*(ref @struct + 2697) = 2;
		*(ref @struct + 2698) = 1;
		*(ref @struct + 2699) = 0;
		*(ref @struct + 2700) = 102;
		*(ref @struct + 2701) = 17;
		*(ref @struct + 2702) = 16;
		*(ref @struct + 2703) = 4;
		*(ref @struct + 2704) = 1;
		*(ref @struct + 2705) = 0;
		*(ref @struct + 2706) = 102;
		*(ref @struct + 2707) = 17;
		*(ref @struct + 2708) = 17;
		*(ref @struct + 2709) = 4;
		*(ref @struct + 2710) = 1;
		*(ref @struct + 2711) = 0;
		*(ref @struct + 2712) = 90;
		*(ref @struct + 2713) = 16;
		*(ref @struct + 2714) = 34;
		*(ref @struct + 2715) = 102;
		*(ref @struct + 2716) = 1;
		*(ref @struct + 2717) = 0;
		*(ref @struct + 2718) = 185;
		*(ref @struct + 2719) = 16;
		*(ref @struct + 2720) = 137;
		*(ref @struct + 2721) = 82;
		*(ref @struct + 2722) = 1;
		*(ref @struct + 2723) = 0;
		*(ref @struct + 2724) = 185;
		*(ref @struct + 2725) = 16;
		*(ref @struct + 2726) = 135;
		*(ref @struct + 2727) = 82;
		*(ref @struct + 2728) = 1;
		*(ref @struct + 2729) = 0;
		*(ref @struct + 2730) = 185;
		*(ref @struct + 2731) = 16;
		*(ref @struct + 2732) = 129;
		*(ref @struct + 2733) = 82;
		*(ref @struct + 2734) = 1;
		*(ref @struct + 2735) = 0;
		*(ref @struct + 2736) = 6;
		*(ref @struct + 2737) = 17;
		*(ref @struct + 2738) = 55;
		*(ref @struct + 2739) = 83;
		*(ref @struct + 2740) = 1;
		*(ref @struct + 2741) = 0;
		*(ref @struct + 2742) = 6;
		*(ref @struct + 2743) = 17;
		*(ref @struct + 2744) = 114;
		*(ref @struct + 2745) = 83;
		*(ref @struct + 2746) = 1;
		*(ref @struct + 2747) = 0;
		*(ref @struct + 2748) = 6;
		*(ref @struct + 2749) = 17;
		*(ref @struct + 2750) = 114;
		*(ref @struct + 2751) = 115;
		*(ref @struct + 2752) = 1;
		*(ref @struct + 2753) = 0;
		*(ref @struct + 2754) = 6;
		*(ref @struct + 2755) = 17;
		*(ref @struct + 2756) = 0;
		*(ref @struct + 2757) = 144;
		*(ref @struct + 2758) = 1;
		*(ref @struct + 2759) = 0;
		*(ref @struct + 2760) = 37;
		*(ref @struct + 2761) = 23;
		*(ref @struct + 2762) = 116;
		*(ref @struct + 2763) = 113;
		*(ref @struct + 2764) = 1;
		*(ref @struct + 2765) = 0;
		*(ref @struct + 2766) = 134;
		*(ref @struct + 2767) = 128;
		*(ref @struct + 2768) = 0;
		*(ref @struct + 2769) = 50;
		*(ref @struct + 2770) = 1;
		*(ref @struct + 2771) = 0;
		*(ref @struct + 2772) = 145;
		*(ref @struct + 2773) = 17;
		*(ref @struct + 2774) = 5;
		*(ref @struct + 2775) = 0;
		*(ref @struct + 2776) = 0;
		*(ref @struct + 2777) = 0;
		*(ref @struct + 2778) = 145;
		*(ref @struct + 2779) = 17;
		*(ref @struct + 2780) = 6;
		*(ref @struct + 2781) = 0;
		*(ref @struct + 2782) = 0;
		*(ref @struct + 2783) = 0;
		*(ref @struct + 2784) = 145;
		*(ref @struct + 2785) = 17;
		*(ref @struct + 2786) = 7;
		*(ref @struct + 2787) = 0;
		*(ref @struct + 2788) = 0;
		*(ref @struct + 2789) = 0;
		*(ref @struct + 2790) = 145;
		*(ref @struct + 2791) = 17;
		*(ref @struct + 2792) = 8;
		*(ref @struct + 2793) = 0;
		*(ref @struct + 2794) = 0;
		*(ref @struct + 2795) = 0;
		*(ref @struct + 2796) = 145;
		*(ref @struct + 2797) = 17;
		*(ref @struct + 2798) = 9;
		*(ref @struct + 2799) = 0;
		*(ref @struct + 2800) = 0;
		*(ref @struct + 2801) = 0;
		*(ref @struct + 2802) = 185;
		*(ref @struct + 2803) = 16;
		*(ref @struct + 2804) = 41;
		*(ref @struct + 2805) = 82;
		*(ref @struct + 2806) = 0;
		*(ref @struct + 2807) = 0;
		*(ref @struct + 2808) = 185;
		*(ref @struct + 2809) = 16;
		*(ref @struct + 2810) = 40;
		*(ref @struct + 2811) = 82;
		*(ref @struct + 2812) = 0;
		*(ref @struct + 2813) = 0;
		*(ref @struct + 2814) = 34;
		*(ref @struct + 2815) = 16;
		*(ref @struct + 2816) = 1;
		*(ref @struct + 2817) = 116;
		*(ref @struct + 2818) = 0;
		*(ref @struct + 2819) = 0;
		*(ref @struct + 2820) = 34;
		*(ref @struct + 2821) = 16;
		*(ref @struct + 2822) = 9;
		*(ref @struct + 2823) = 116;
		*(ref @struct + 2824) = 0;
		*(ref @struct + 2825) = 0;
		*(ref @struct + 2826) = 34;
		*(ref @struct + 2827) = 16;
		*(ref @struct + 2828) = 17;
		*(ref @struct + 2829) = 116;
		*(ref @struct + 2830) = 0;
		*(ref @struct + 2831) = 0;
		*(ref @struct + 2832) = 34;
		*(ref @struct + 2833) = 16;
		*(ref @struct + 2834) = 65;
		*(ref @struct + 2835) = 116;
		*(ref @struct + 2836) = 0;
		*(ref @struct + 2837) = 0;
		*(ref @struct + 2838) = 34;
		*(ref @struct + 2839) = 16;
		*(ref @struct + 2840) = 105;
		*(ref @struct + 2841) = 116;
		*(ref @struct + 2842) = 0;
		*(ref @struct + 2843) = 0;
		*(ref @struct + 2844) = 222;
		*(ref @struct + 2845) = 16;
		*(ref @struct + 2846) = 188;
		*(ref @struct + 2847) = 1;
		*(ref @struct + 2848) = 0;
		*(ref @struct + 2849) = 0;
		*(ref @struct + 2850) = 222;
		*(ref @struct + 2851) = 16;
		*(ref @struct + 2852) = 101;
		*(ref @struct + 2853) = 0;
		*(ref @struct + 2854) = 0;
		*(ref @struct + 2855) = 0;
		*(ref @struct + 2856) = 222;
		*(ref @struct + 2857) = 16;
		*(ref @struct + 2858) = 133;
		*(ref @struct + 2859) = 0;
		*(ref @struct + 2860) = 0;
		*(ref @struct + 2861) = 0;
		*(ref @struct + 2862) = 222;
		*(ref @struct + 2863) = 16;
		*(ref @struct + 2864) = 142;
		*(ref @struct + 2865) = 0;
		*(ref @struct + 2866) = 1;
		*(ref @struct + 2867) = 0;
		*(ref @struct + 2868) = 222;
		*(ref @struct + 2869) = 16;
		*(ref @struct + 2870) = 213;
		*(ref @struct + 2871) = 0;
		*(ref @struct + 2872) = 0;
		*(ref @struct + 2873) = 0;
		*(ref @struct + 2874) = 222;
		*(ref @struct + 2875) = 16;
		*(ref @struct + 2876) = 229;
		*(ref @struct + 2877) = 0;
		*(ref @struct + 2878) = 0;
		*(ref @struct + 2879) = 0;
		*(ref @struct + 2880) = 222;
		*(ref @struct + 2881) = 16;
		*(ref @struct + 2882) = 227;
		*(ref @struct + 2883) = 0;
		*(ref @struct + 2884) = 1;
		*(ref @struct + 2885) = 0;
		*(ref @struct + 2886) = 222;
		*(ref @struct + 2887) = 16;
		*(ref @struct + 2888) = 238;
		*(ref @struct + 2889) = 0;
		*(ref @struct + 2890) = 1;
		*(ref @struct + 2891) = 0;
		*(ref @struct + 2892) = 222;
		*(ref @struct + 2893) = 16;
		*(ref @struct + 2894) = 83;
		*(ref @struct + 2895) = 0;
		*(ref @struct + 2896) = 0;
		*(ref @struct + 2897) = 0;
		*(ref @struct + 2898) = 222;
		*(ref @struct + 2899) = 16;
		*(ref @struct + 2900) = 53;
		*(ref @struct + 2901) = 0;
		*(ref @struct + 2902) = 0;
		*(ref @struct + 2903) = 0;
		*(ref @struct + 2904) = 222;
		*(ref @struct + 2905) = 16;
		*(ref @struct + 2906) = 101;
		*(ref @struct + 2907) = 2;
		*(ref @struct + 2908) = 0;
		*(ref @struct + 2909) = 0;
		*(ref @struct + 2910) = 222;
		*(ref @struct + 2911) = 16;
		*(ref @struct + 2912) = 110;
		*(ref @struct + 2913) = 3;
		*(ref @struct + 2914) = 0;
		*(ref @struct + 2915) = 0;
		*(ref @struct + 2916) = 222;
		*(ref @struct + 2917) = 16;
		*(ref @struct + 2918) = 236;
		*(ref @struct + 2919) = 3;
		*(ref @struct + 2920) = 0;
		*(ref @struct + 2921) = 0;
		*(ref @struct + 2922) = 222;
		*(ref @struct + 2923) = 16;
		*(ref @struct + 2924) = 72;
		*(ref @struct + 2925) = 4;
		*(ref @struct + 2926) = 0;
		*(ref @struct + 2927) = 0;
		*(ref @struct + 2928) = 222;
		*(ref @struct + 2929) = 16;
		*(ref @struct + 2930) = 96;
		*(ref @struct + 2931) = 5;
		*(ref @struct + 2932) = 0;
		*(ref @struct + 2933) = 0;
		*(ref @struct + 2934) = 222;
		*(ref @struct + 2935) = 16;
		*(ref @struct + 2936) = 108;
		*(ref @struct + 2937) = 5;
		*(ref @struct + 2938) = 0;
		*(ref @struct + 2939) = 0;
		*(ref @struct + 2940) = 222;
		*(ref @struct + 2941) = 16;
		*(ref @struct + 2942) = 89;
		*(ref @struct + 2943) = 7;
		*(ref @struct + 2944) = 0;
		*(ref @struct + 2945) = 0;
		*(ref @struct + 2946) = 34;
		*(ref @struct + 2947) = 16;
		*(ref @struct + 2948) = 154;
		*(ref @struct + 2949) = 32;
		*(ref @struct + 2950) = 0;
		*(ref @struct + 2951) = 0;
		*(ref @struct + 2952) = 2;
		*(ref @struct + 2953) = 16;
		*(ref @struct + 2954) = 73;
		*(ref @struct + 2955) = 67;
		*(ref @struct + 2956) = 0;
		*(ref @struct + 2957) = 0;
		*(ref @struct + 2958) = 2;
		*(ref @struct + 2959) = 16;
		*(ref @struct + 2960) = 105;
		*(ref @struct + 2961) = 67;
		*(ref @struct + 2962) = 0;
		*(ref @struct + 2963) = 0;
		*(ref @struct + 2964) = 2;
		*(ref @struct + 2965) = 16;
		*(ref @struct + 2966) = 118;
		*(ref @struct + 2967) = 67;
		*(ref @struct + 2968) = 0;
		*(ref @struct + 2969) = 0;
		*(ref @struct + 2970) = 2;
		*(ref @struct + 2971) = 16;
		*(ref @struct + 2972) = 140;
		*(ref @struct + 2973) = 67;
		*(ref @struct + 2974) = 0;
		*(ref @struct + 2975) = 0;
		*(ref @struct + 2976) = 2;
		*(ref @struct + 2977) = 16;
		*(ref @struct + 2978) = 156;
		*(ref @struct + 2979) = 67;
		*(ref @struct + 2980) = 0;
		*(ref @struct + 2981) = 0;
		*(ref @struct + 2982) = 34;
		*(ref @struct + 2983) = 16;
		*(ref @struct + 2984) = 12;
		*(ref @struct + 2985) = 120;
		*(ref @struct + 2986) = 0;
		*(ref @struct + 2987) = 0;
		*(ref @struct + 2988) = 149;
		*(ref @struct + 2989) = 16;
		*(ref @struct + 2990) = 67;
		*(ref @struct + 2991) = 6;
		*(ref @struct + 2992) = 0;
		*(ref @struct + 2993) = 0;
		*(ref @struct + 2994) = 149;
		*(ref @struct + 2995) = 16;
		*(ref @struct + 2996) = 70;
		*(ref @struct + 2997) = 6;
		*(ref @struct + 2998) = 0;
		*(ref @struct + 2999) = 0;
		*(ref @struct + 3000) = 149;
		*(ref @struct + 3001) = 16;
		*(ref @struct + 3002) = 72;
		*(ref @struct + 3003) = 6;
		*(ref @struct + 3004) = 0;
		*(ref @struct + 3005) = 0;
		*(ref @struct + 3006) = 149;
		*(ref @struct + 3007) = 16;
		*(ref @struct + 3008) = 73;
		*(ref @struct + 3009) = 6;
		*(ref @struct + 3010) = 0;
		*(ref @struct + 3011) = 0;
		*(ref @struct + 3012) = 120;
		*(ref @struct + 3013) = 16;
		*(ref @struct + 3014) = 0;
		*(ref @struct + 3015) = 0;
		*(ref @struct + 3016) = 0;
		*(ref @struct + 3017) = 0;
		*(ref @struct + 3018) = 120;
		*(ref @struct + 3019) = 16;
		*(ref @struct + 3020) = 2;
		*(ref @struct + 3021) = 0;
		*(ref @struct + 3022) = 0;
		*(ref @struct + 3023) = 0;
		*(ref @struct + 3024) = 120;
		*(ref @struct + 3025) = 16;
		*(ref @struct + 3026) = 2;
		*(ref @struct + 3027) = 1;
		*(ref @struct + 3028) = 0;
		*(ref @struct + 3029) = 0;
		*(ref @struct + 3030) = 11;
		*(ref @struct + 3031) = 16;
		*(ref @struct + 3032) = 45;
		*(ref @struct + 3033) = 0;
		*(ref @struct + 3034) = 0;
		*(ref @struct + 3035) = 0;
		*(ref @struct + 3036) = 34;
		*(ref @struct + 3037) = 16;
		*(ref @struct + 3038) = 143;
		*(ref @struct + 3039) = 32;
		*(ref @struct + 3040) = 0;
		*(ref @struct + 3041) = 0;
		*(ref @struct + 3042) = 34;
		*(ref @struct + 3043) = 16;
		*(ref @struct + 3044) = 154;
		*(ref @struct + 3045) = 32;
		*(ref @struct + 3046) = 0;
		*(ref @struct + 3047) = 0;
		*(ref @struct + 3048) = 128;
		*(ref @struct + 3049) = 16;
		*(ref @struct + 3050) = 147;
		*(ref @struct + 3051) = 198;
		*(ref @struct + 3052) = 0;
		*(ref @struct + 3053) = 0;
		*(ref @struct + 3054) = 69;
		*(ref @struct + 3055) = 17;
		*(ref @struct + 3056) = 33;
		*(ref @struct + 3057) = 240;
		*(ref @struct + 3058) = 0;
		*(ref @struct + 3059) = 0;
		*(ref @struct + 3060) = 69;
		*(ref @struct + 3061) = 17;
		*(ref @struct + 3062) = 36;
		*(ref @struct + 3063) = 240;
		*(ref @struct + 3064) = 0;
		*(ref @struct + 3065) = 0;
		*(ref @struct + 3066) = 3;
		*(ref @struct + 3067) = 17;
		*(ref @struct + 3068) = 4;
		*(ref @struct + 3069) = 0;
		*(ref @struct + 3070) = 0;
		*(ref @struct + 3071) = 0;
		*(ref @struct + 3072) = 3;
		*(ref @struct + 3073) = 17;
		*(ref @struct + 3074) = 5;
		*(ref @struct + 3075) = 0;
		*(ref @struct + 3076) = 0;
		*(ref @struct + 3077) = 0;
		*(ref @struct + 3078) = 3;
		*(ref @struct + 3079) = 17;
		*(ref @struct + 3080) = 6;
		*(ref @struct + 3081) = 0;
		*(ref @struct + 3082) = 0;
		*(ref @struct + 3083) = 0;
		*(ref @struct + 3084) = 3;
		*(ref @struct + 3085) = 17;
		*(ref @struct + 3086) = 7;
		*(ref @struct + 3087) = 0;
		*(ref @struct + 3088) = 0;
		*(ref @struct + 3089) = 0;
		*(ref @struct + 3090) = 3;
		*(ref @struct + 3091) = 17;
		*(ref @struct + 3092) = 8;
		*(ref @struct + 3093) = 0;
		*(ref @struct + 3094) = 0;
		*(ref @struct + 3095) = 0;
		*(ref @struct + 3096) = 3;
		*(ref @struct + 3097) = 17;
		*(ref @struct + 3098) = 9;
		*(ref @struct + 3099) = 0;
		*(ref @struct + 3100) = 0;
		*(ref @struct + 3101) = 0;
		*(ref @struct + 3102) = 11;
		*(ref @struct + 3103) = 16;
		*(ref @struct + 3104) = 1;
		*(ref @struct + 3105) = 208;
		*(ref @struct + 3106) = 0;
		*(ref @struct + 3107) = 0;
		*(ref @struct + 3108) = 66;
		*(ref @struct + 3109) = 16;
		*(ref @struct + 3110) = 32;
		*(ref @struct + 3111) = 48;
		*(ref @struct + 3112) = 0;
		*(ref @struct + 3113) = 0;
		*(ref @struct + 3114) = 18;
		*(ref @struct + 3115) = 148;
		*(ref @struct + 3116) = 101;
		*(ref @struct + 3117) = 101;
		*(ref @struct + 3118) = 0;
		*(ref @struct + 3119) = 0;
		*(ref @struct + 3120) = 96;
		*(ref @struct + 3121) = 16;
		*(ref @struct + 3122) = 1;
		*(ref @struct + 3123) = 1;
		*(ref @struct + 3124) = 0;
		*(ref @struct + 3125) = 0;
		*(ref @struct + 3126) = 96;
		*(ref @struct + 3127) = 16;
		*(ref @struct + 3128) = 106;
		*(ref @struct + 3129) = 136;
		*(ref @struct + 3130) = 0;
		*(ref @struct + 3131) = 0;
		*(ref @struct + 3132) = 96;
		*(ref @struct + 3133) = 16;
		*(ref @struct + 3134) = 58;
		*(ref @struct + 3135) = 103;
		*(ref @struct + 3136) = 0;
		*(ref @struct + 3137) = 0;
		*(ref @struct + 3138) = 136;
		*(ref @struct + 3139) = 51;
		*(ref @struct + 3140) = 19;
		*(ref @struct + 3141) = 128;
		*(ref @struct + 3142) = 0;
		*(ref @struct + 3143) = 0;
		*(ref @struct + 3144) = 6;
		*(ref @struct + 3145) = 17;
		*(ref @struct + 3146) = 97;
		*(ref @struct + 3147) = 5;
		*(ref @struct + 3148) = 0;
		*(ref @struct + 3149) = 0;
		*(ref @struct + 3150) = 69;
		*(ref @struct + 3151) = 16;
		*(ref @struct + 3152) = 88;
		*(ref @struct + 3153) = 197;
		*(ref @struct + 3154) = 0;
		*(ref @struct + 3155) = 0;
		*(ref @struct + 3156) = 121;
		*(ref @struct + 3157) = 17;
		*(ref @struct + 3158) = 1;
		*(ref @struct + 3159) = 1;
		*(ref @struct + 3160) = 0;
		*(ref @struct + 3161) = 0;
		*(ref @struct + 3162) = 121;
		*(ref @struct + 3163) = 17;
		*(ref @struct + 3164) = 2;
		*(ref @struct + 3165) = 1;
		*(ref @struct + 3166) = 0;
		*(ref @struct + 3167) = 0;
		*(ref @struct + 3168) = 121;
		*(ref @struct + 3169) = 17;
		*(ref @struct + 3170) = 3;
		*(ref @struct + 3171) = 1;
		*(ref @struct + 3172) = 0;
		*(ref @struct + 3173) = 0;
		*(ref @struct + 3174) = 121;
		*(ref @struct + 3175) = 17;
		*(ref @struct + 3176) = 5;
		*(ref @struct + 3177) = 1;
		*(ref @struct + 3178) = 0;
		*(ref @struct + 3179) = 0;
		*(ref @struct + 3180) = 156;
		*(ref @struct + 3181) = 22;
		*(ref @struct + 3182) = 68;
		*(ref @struct + 3183) = 0;
		*(ref @struct + 3184) = 0;
		*(ref @struct + 3185) = 0;
		*(ref @struct + 3186) = 131;
		*(ref @struct + 3187) = 18;
		*(ref @struct + 3188) = 114;
		*(ref @struct + 3189) = 129;
		*(ref @struct + 3190) = 0;
		*(ref @struct + 3191) = 0;
		*(ref @struct + 3192) = 131;
		*(ref @struct + 3193) = 18;
		*(ref @struct + 3194) = 19;
		*(ref @struct + 3195) = 130;
		*(ref @struct + 3196) = 0;
		*(ref @struct + 3197) = 0;
		*(ref @struct + 3198) = 131;
		*(ref @struct + 3199) = 18;
		*(ref @struct + 3200) = 17;
		*(ref @struct + 3201) = 130;
		*(ref @struct + 3202) = 0;
		*(ref @struct + 3203) = 0;
		*(ref @struct + 3204) = 131;
		*(ref @struct + 3205) = 18;
		*(ref @struct + 3206) = 18;
		*(ref @struct + 3207) = 130;
		*(ref @struct + 3208) = 0;
		*(ref @struct + 3209) = 0;
		*(ref @struct + 3210) = 243;
		*(ref @struct + 3211) = 23;
		*(ref @struct + 3212) = 16;
		*(ref @struct + 3213) = 16;
		*(ref @struct + 3214) = 0;
		*(ref @struct + 3215) = 0;
		*(ref @struct + 3216) = 123;
		*(ref @struct + 3217) = 25;
		*(ref @struct + 3218) = 97;
		*(ref @struct + 3219) = 35;
		*(ref @struct + 3220) = 0;
		*(ref @struct + 3221) = 0;
		*(ref @struct + 3222) = 123;
		*(ref @struct + 3223) = 25;
		*(ref @struct + 3224) = 99;
		*(ref @struct + 3225) = 35;
		*(ref @struct + 3226) = 0;
		*(ref @struct + 3227) = 0;
		*(ref @struct + 3228) = 123;
		*(ref @struct + 3229) = 25;
		*(ref @struct + 3230) = 101;
		*(ref @struct + 3231) = 35;
		*(ref @struct + 3232) = 0;
		*(ref @struct + 3233) = 0;
		*(ref @struct + 3234) = 123;
		*(ref @struct + 3235) = 25;
		*(ref @struct + 3236) = 102;
		*(ref @struct + 3237) = 35;
		*(ref @struct + 3238) = 0;
		*(ref @struct + 3239) = 0;
		*(ref @struct + 3240) = 123;
		*(ref @struct + 3241) = 25;
		*(ref @struct + 3242) = 104;
		*(ref @struct + 3243) = 35;
		*(ref @struct + 3244) = 0;
		*(ref @struct + 3245) = 0;
		*(ref @struct + 3246) = 11;
		*(ref @struct + 3247) = 16;
		*(ref @struct + 3248) = 2;
		*(ref @struct + 3249) = 0;
		*(ref @struct + 3250) = 0;
		*(ref @struct + 3251) = 0;
		*(ref @struct + 3252) = 69;
		*(ref @struct + 3253) = 16;
		*(ref @struct + 3254) = 33;
		*(ref @struct + 3255) = 198;
		*(ref @struct + 3256) = 0;
		*(ref @struct + 3257) = 0;
		*(ref @struct + 3258) = 69;
		*(ref @struct + 3259) = 16;
		*(ref @struct + 3260) = 104;
		*(ref @struct + 3261) = 213;
		*(ref @struct + 3262) = 0;
		*(ref @struct + 3263) = 0;
		*(ref @struct + 3264) = 90;
		*(ref @struct + 3265) = 16;
		*(ref @struct + 3266) = 104;
		*(ref @struct + 3267) = 77;
		*(ref @struct + 3268) = 0;
		*(ref @struct + 3269) = 0;
		*(ref @struct + 3270) = 90;
		*(ref @struct + 3271) = 16;
		*(ref @struct + 3272) = 105;
		*(ref @struct + 3273) = 77;
		*(ref @struct + 3274) = 0;
		*(ref @struct + 3275) = 0;
		*(ref @struct + 3276) = 90;
		*(ref @struct + 3277) = 16;
		*(ref @struct + 3278) = 104;
		*(ref @struct + 3279) = 98;
		*(ref @struct + 3280) = 0;
		*(ref @struct + 3281) = 0;
		*(ref @struct + 3282) = 90;
		*(ref @struct + 3283) = 16;
		*(ref @struct + 3284) = 105;
		*(ref @struct + 3285) = 98;
		*(ref @struct + 3286) = 0;
		*(ref @struct + 3287) = 0;
		*(ref @struct + 3288) = 90;
		*(ref @struct + 3289) = 16;
		*(ref @struct + 3290) = 117;
		*(ref @struct + 3291) = 18;
		*(ref @struct + 3292) = 0;
		*(ref @struct + 3293) = 0;
		*(ref @struct + 3294) = 90;
		*(ref @struct + 3295) = 16;
		*(ref @struct + 3296) = 117;
		*(ref @struct + 3297) = 82;
		*(ref @struct + 3298) = 0;
		*(ref @struct + 3299) = 0;
		*(ref @struct + 3300) = 90;
		*(ref @struct + 3301) = 16;
		*(ref @struct + 3302) = 117;
		*(ref @struct + 3303) = 114;
		*(ref @struct + 3304) = 0;
		*(ref @struct + 3305) = 0;
		*(ref @struct + 3306) = 90;
		*(ref @struct + 3307) = 16;
		*(ref @struct + 3308) = 51;
		*(ref @struct + 3309) = 77;
		*(ref @struct + 3310) = 0;
		*(ref @struct + 3311) = 0;
		*(ref @struct + 3312) = 90;
		*(ref @struct + 3313) = 16;
		*(ref @struct + 3314) = 56;
		*(ref @struct + 3315) = 77;
		*(ref @struct + 3316) = 0;
		*(ref @struct + 3317) = 0;
		*(ref @struct + 3318) = 90;
		*(ref @struct + 3319) = 16;
		*(ref @struct + 3320) = 56;
		*(ref @struct + 3321) = 13;
		*(ref @struct + 3322) = 0;
		*(ref @struct + 3323) = 0;
		*(ref @struct + 3324) = 90;
		*(ref @struct + 3325) = 16;
		*(ref @struct + 3326) = 48;
		*(ref @struct + 3327) = 13;
		*(ref @struct + 3328) = 0;
		*(ref @struct + 3329) = 0;
		*(ref @struct + 3330) = 90;
		*(ref @struct + 3331) = 16;
		*(ref @struct + 3332) = 48;
		*(ref @struct + 3333) = 77;
		*(ref @struct + 3334) = 0;
		*(ref @struct + 3335) = 0;
		*(ref @struct + 3336) = 134;
		*(ref @struct + 3337) = 128;
		*(ref @struct + 3338) = 46;
		*(ref @struct + 3339) = 18;
		*(ref @struct + 3340) = 0;
		*(ref @struct + 3341) = 0;
		*(ref @struct + 3342) = 134;
		*(ref @struct + 3343) = 128;
		*(ref @struct + 3344) = 48;
		*(ref @struct + 3345) = 18;
		*(ref @struct + 3346) = 0;
		*(ref @struct + 3347) = 0;
		*(ref @struct + 3348) = 134;
		*(ref @struct + 3349) = 128;
		*(ref @struct + 3350) = 52;
		*(ref @struct + 3351) = 18;
		*(ref @struct + 3352) = 0;
		*(ref @struct + 3353) = 0;
		*(ref @struct + 3354) = 134;
		*(ref @struct + 3355) = 128;
		*(ref @struct + 3356) = 16;
		*(ref @struct + 3357) = 112;
		*(ref @struct + 3358) = 0;
		*(ref @struct + 3359) = 0;
		*(ref @struct + 3360) = 134;
		*(ref @struct + 3361) = 128;
		*(ref @struct + 3362) = 17;
		*(ref @struct + 3363) = 113;
		*(ref @struct + 3364) = 0;
		*(ref @struct + 3365) = 0;
		*(ref @struct + 3366) = 134;
		*(ref @struct + 3367) = 128;
		*(ref @struct + 3368) = 33;
		*(ref @struct + 3369) = 36;
		*(ref @struct + 3370) = 0;
		*(ref @struct + 3371) = 0;
		*(ref @struct + 3372) = 134;
		*(ref @struct + 3373) = 128;
		*(ref @struct + 3374) = 153;
		*(ref @struct + 3375) = 113;
		*(ref @struct + 3376) = 0;
		*(ref @struct + 3377) = 0;
		*(ref @struct + 3378) = 134;
		*(ref @struct + 3379) = 128;
		*(ref @struct + 3380) = 17;
		*(ref @struct + 3381) = 36;
		*(ref @struct + 3382) = 0;
		*(ref @struct + 3383) = 0;
		*(ref @struct + 3384) = 134;
		*(ref @struct + 3385) = 128;
		*(ref @struct + 3386) = 1;
		*(ref @struct + 3387) = 118;
		*(ref @struct + 3388) = 0;
		*(ref @struct + 3389) = 0;
		*(ref @struct + 3390) = 134;
		*(ref @struct + 3391) = 128;
		*(ref @struct + 3392) = 202;
		*(ref @struct + 3393) = 132;
		*(ref @struct + 3394) = 0;
		*(ref @struct + 3395) = 0;
		*(ref @struct + 3396) = 134;
		*(ref @struct + 3397) = 128;
		*(ref @struct + 3398) = 75;
		*(ref @struct + 3399) = 36;
		*(ref @struct + 3400) = 0;
		*(ref @struct + 3401) = 0;
		*(ref @struct + 3402) = 134;
		*(ref @struct + 3403) = 128;
		*(ref @struct + 3404) = 74;
		*(ref @struct + 3405) = 36;
		*(ref @struct + 3406) = 0;
		*(ref @struct + 3407) = 0;
		*(ref @struct + 3408) = 134;
		*(ref @struct + 3409) = 128;
		*(ref @struct + 3410) = 138;
		*(ref @struct + 3411) = 36;
		*(ref @struct + 3412) = 0;
		*(ref @struct + 3413) = 0;
		*(ref @struct + 3414) = 134;
		*(ref @struct + 3415) = 128;
		*(ref @struct + 3416) = 139;
		*(ref @struct + 3417) = 36;
		*(ref @struct + 3418) = 0;
		*(ref @struct + 3419) = 0;
		*(ref @struct + 3420) = 134;
		*(ref @struct + 3421) = 128;
		*(ref @struct + 3422) = 203;
		*(ref @struct + 3423) = 36;
		*(ref @struct + 3424) = 0;
		*(ref @struct + 3425) = 0;
		*(ref @struct + 3426) = 134;
		*(ref @struct + 3427) = 128;
		*(ref @struct + 3428) = 219;
		*(ref @struct + 3429) = 36;
		*(ref @struct + 3430) = 0;
		*(ref @struct + 3431) = 0;
		*(ref @struct + 3432) = 134;
		*(ref @struct + 3433) = 128;
		*(ref @struct + 3434) = 91;
		*(ref @struct + 3435) = 36;
		*(ref @struct + 3436) = 0;
		*(ref @struct + 3437) = 0;
		*(ref @struct + 3438) = 134;
		*(ref @struct + 3439) = 128;
		*(ref @struct + 3440) = 202;
		*(ref @struct + 3441) = 36;
		*(ref @struct + 3442) = 0;
		*(ref @struct + 3443) = 0;
		*(ref @struct + 3444) = 134;
		*(ref @struct + 3445) = 128;
		*(ref @struct + 3446) = 209;
		*(ref @struct + 3447) = 36;
		*(ref @struct + 3448) = 1;
		*(ref @struct + 3449) = 0;
		*(ref @struct + 3450) = 134;
		*(ref @struct + 3451) = 128;
		*(ref @struct + 3452) = 162;
		*(ref @struct + 3453) = 37;
		*(ref @struct + 3454) = 0;
		*(ref @struct + 3455) = 0;
		*(ref @struct + 3456) = 134;
		*(ref @struct + 3457) = 128;
		*(ref @struct + 3458) = 111;
		*(ref @struct + 3459) = 38;
		*(ref @struct + 3460) = 0;
		*(ref @struct + 3461) = 0;
		*(ref @struct + 3462) = 134;
		*(ref @struct + 3463) = 128;
		*(ref @struct + 3464) = 223;
		*(ref @struct + 3465) = 39;
		*(ref @struct + 3466) = 0;
		*(ref @struct + 3467) = 0;
		*(ref @struct + 3468) = 134;
		*(ref @struct + 3469) = 128;
		*(ref @struct + 3470) = 193;
		*(ref @struct + 3471) = 36;
		*(ref @struct + 3472) = 0;
		*(ref @struct + 3473) = 0;
		*(ref @struct + 3474) = 134;
		*(ref @struct + 3475) = 128;
		*(ref @struct + 3476) = 158;
		*(ref @struct + 3477) = 38;
		*(ref @struct + 3478) = 0;
		*(ref @struct + 3479) = 0;
		*(ref @struct + 3480) = 134;
		*(ref @struct + 3481) = 128;
		*(ref @struct + 3482) = 80;
		*(ref @struct + 3483) = 40;
		*(ref @struct + 3484) = 0;
		*(ref @struct + 3485) = 0;
		*(ref @struct + 3486) = 107;
		*(ref @struct + 3487) = 16;
		*(ref @struct + 3488) = 51;
		*(ref @struct + 3489) = 0;
		*(ref @struct + 3490) = 0;
		*(ref @struct + 3491) = 0;
		*(ref @struct + 3492) = 107;
		*(ref @struct + 3493) = 16;
		*(ref @struct + 3494) = 59;
		*(ref @struct + 3495) = 0;
		*(ref @struct + 3496) = 0;
		*(ref @struct + 3497) = 0;
		*(ref @struct + 3498) = 107;
		*(ref @struct + 3499) = 16;
		*(ref @struct + 3500) = 67;
		*(ref @struct + 3501) = 0;
		*(ref @struct + 3502) = 0;
		*(ref @struct + 3503) = 0;
		*(ref @struct + 3504) = 107;
		*(ref @struct + 3505) = 16;
		*(ref @struct + 3506) = 80;
		*(ref @struct + 3507) = 0;
		*(ref @struct + 3508) = 0;
		*(ref @struct + 3509) = 0;
		*(ref @struct + 3510) = 107;
		*(ref @struct + 3511) = 16;
		*(ref @struct + 3512) = 105;
		*(ref @struct + 3513) = 0;
		*(ref @struct + 3514) = 0;
		*(ref @struct + 3515) = 0;
		*(ref @struct + 3516) = 66;
		*(ref @struct + 3517) = 16;
		*(ref @struct + 3518) = 0;
		*(ref @struct + 3519) = 16;
		*(ref @struct + 3520) = 0;
		*(ref @struct + 3521) = 0;
		*(ref @struct + 3522) = 66;
		*(ref @struct + 3523) = 16;
		*(ref @struct + 3524) = 1;
		*(ref @struct + 3525) = 16;
		*(ref @struct + 3526) = 0;
		*(ref @struct + 3527) = 0;
		*(ref @struct + 3528) = 11;
		*(ref @struct + 3529) = 16;
		*(ref @struct + 3530) = 2;
		*(ref @struct + 3531) = 5;
		*(ref @struct + 3532) = 0;
		*(ref @struct + 3533) = 0;
		*(ref @struct + 3534) = 47;
		*(ref @struct + 3535) = 16;
		*(ref @struct + 3536) = 180;
		*(ref @struct + 3537) = 1;
		*(ref @struct + 3538) = 0;
		*(ref @struct + 3539) = 0;
		*(ref @struct + 3540) = 102;
		*(ref @struct + 3541) = 17;
		*(ref @struct + 3542) = 17;
		*(ref @struct + 3543) = 2;
		*(ref @struct + 3544) = 0;
		*(ref @struct + 3545) = 0;
		*(ref @struct + 3546) = 102;
		*(ref @struct + 3547) = 17;
		*(ref @struct + 3548) = 18;
		*(ref @struct + 3549) = 2;
		*(ref @struct + 3550) = 0;
		*(ref @struct + 3551) = 0;
		*(ref @struct + 3552) = 102;
		*(ref @struct + 3553) = 17;
		*(ref @struct + 3554) = 19;
		*(ref @struct + 3555) = 2;
		*(ref @struct + 3556) = 0;
		*(ref @struct + 3557) = 0;
		*(ref @struct + 3558) = 102;
		*(ref @struct + 3559) = 17;
		*(ref @struct + 3560) = 23;
		*(ref @struct + 3561) = 2;
		*(ref @struct + 3562) = 0;
		*(ref @struct + 3563) = 0;
		*(ref @struct + 3564) = 102;
		*(ref @struct + 3565) = 17;
		*(ref @struct + 3566) = 20;
		*(ref @struct + 3567) = 2;
		*(ref @struct + 3568) = 0;
		*(ref @struct + 3569) = 0;
		*(ref @struct + 3570) = 149;
		*(ref @struct + 3571) = 16;
		*(ref @struct + 3572) = 128;
		*(ref @struct + 3573) = 6;
		*(ref @struct + 3574) = 0;
		*(ref @struct + 3575) = 0;
		*(ref @struct + 3576) = 149;
		*(ref @struct + 3577) = 16;
		*(ref @struct + 3578) = 18;
		*(ref @struct + 3579) = 49;
		*(ref @struct + 3580) = 1;
		*(ref @struct + 3581) = 0;
		*(ref @struct + 3582) = 149;
		*(ref @struct + 3583) = 16;
		*(ref @struct + 3584) = 64;
		*(ref @struct + 3585) = 2;
		*(ref @struct + 3586) = 1;
		*(ref @struct + 3587) = 0;
		*(ref @struct + 3588) = 57;
		*(ref @struct + 3589) = 16;
		*(ref @struct + 3590) = 19;
		*(ref @struct + 3591) = 85;
		*(ref @struct + 3592) = 0;
		*(ref @struct + 3593) = 0;
		*(ref @struct + 3594) = 57;
		*(ref @struct + 3595) = 16;
		*(ref @struct + 3596) = 24;
		*(ref @struct + 3597) = 85;
		*(ref @struct + 3598) = 0;
		*(ref @struct + 3599) = 0;
		*(ref @struct + 3600) = 57;
		*(ref @struct + 3601) = 16;
		*(ref @struct + 3602) = 128;
		*(ref @struct + 3603) = 17;
		*(ref @struct + 3604) = 0;
		*(ref @struct + 3605) = 0;
		*(ref @struct + 3606) = 173;
		*(ref @struct + 3607) = 16;
		*(ref @struct + 3608) = 5;
		*(ref @struct + 3609) = 1;
		*(ref @struct + 3610) = 0;
		*(ref @struct + 3611) = 0;
		*(ref @struct + 3612) = 85;
		*(ref @struct + 3613) = 16;
		*(ref @struct + 3614) = 48;
		*(ref @struct + 3615) = 145;
		*(ref @struct + 3616) = 0;
		*(ref @struct + 3617) = 0;
		*(ref @struct + 3618) = 47;
		*(ref @struct + 3619) = 16;
		*(ref @struct + 3620) = 5;
		*(ref @struct + 3621) = 1;
		*(ref @struct + 3622) = 0;
		*(ref @struct + 3623) = 0;
		*(ref @struct + 3624) = 17;
		*(ref @struct + 3625) = 14;
		*(ref @struct + 3626) = 51;
		*(ref @struct + 3627) = 174;
		*(ref @struct + 3628) = 0;
		*(ref @struct + 3629) = 0;
		*(ref @struct + 3630) = 225;
		*(ref @struct + 3631) = 29;
		*(ref @struct + 3632) = 41;
		*(ref @struct + 3633) = 220;
		*(ref @struct + 3634) = 0;
		*(ref @struct + 3635) = 0;
		*(ref @struct + 3636) = 6;
		*(ref @struct + 3637) = 17;
		*(ref @struct + 3638) = 113;
		*(ref @struct + 3639) = 21;
		*(ref @struct + 3640) = 0;
		*(ref @struct + 3641) = 0;
		*(ref @struct + 3642) = 6;
		*(ref @struct + 3643) = 17;
		*(ref @struct + 3644) = 113;
		*(ref @struct + 3645) = 5;
		*(ref @struct + 3646) = 0;
		*(ref @struct + 3647) = 0;
		*(ref @struct + 3648) = 6;
		*(ref @struct + 3649) = 17;
		*(ref @struct + 3650) = 129;
		*(ref @struct + 3651) = 5;
		*(ref @struct + 3652) = 0;
		*(ref @struct + 3653) = 0;
		*(ref @struct + 3654) = 6;
		*(ref @struct + 3655) = 17;
		*(ref @struct + 3656) = 9;
		*(ref @struct + 3657) = 196;
		*(ref @struct + 3658) = 0;
		*(ref @struct + 3659) = 0;
		*(ref @struct + 3660) = 6;
		*(ref @struct + 3661) = 17;
		*(ref @struct + 3662) = 100;
		*(ref @struct + 3663) = 49;
		*(ref @struct + 3664) = 0;
		*(ref @struct + 3665) = 0;
		*(ref @struct + 3666) = 6;
		*(ref @struct + 3667) = 17;
		*(ref @struct + 3668) = 21;
		*(ref @struct + 3669) = 4;
		*(ref @struct + 3670) = 0;
		*(ref @struct + 3671) = 0;
		*(ref @struct + 3672) = 6;
		*(ref @struct + 3673) = 17;
		*(ref @struct + 3674) = 36;
		*(ref @struct + 3675) = 83;
		*(ref @struct + 3676) = 0;
		*(ref @struct + 3677) = 0;
		Struct37 struct2;
		<Module>.memset((void*)(&struct2), 0, 40U);
		uint num = 0U;
		int num2 = <Module>.smethod_157();
		for (int i = 0; i <= num2; i++)
		{
			for (int j = 0; j <= 31; j++)
			{
				for (int k = 0; k <= 7; k++)
				{
					<Module>.memset((void*)(&struct2), 0, 40U);
					for (uint num3 = 0U; num3 <= 36U; num3 += 4U)
					{
						int uint_ = (((i | -32768) * 32 | (int)((ushort)j)) * 8 | (int)((ushort)k)) << 8 | (int)(num3 & 4294967292U);
						<Module>.smethod_156((uint)uint_);
						*(ref struct2 + num3) = <Module>.smethod_153();
					}
					if (struct2 != 255 || *(ref struct2 + 1) != 255)
					{
						if (*(ref struct2 + 3) == 50 && *(ref struct2 + 2) == 73)
						{
							uint num4 = 0U;
							if ((*(ref struct2 + 14) & 127) == 0)
							{
								num4 = 6U;
							}
							if ((*(ref struct2 + 14) & 127) == 1)
							{
								num4 = 1U;
							}
							for (uint num3 = 0U; num3 < num4; num3 += 1U)
							{
								if ((*(ref struct2 + (num3 * 4U + 16U)) & 1) == 1)
								{
									uint num5 = (uint)((uint)(*(ref struct2 + (num3 * 4U + 17U))) << 8);
									num5 += (uint)(*(ref struct2 + (num3 * 4U + 16U)) & 252);
									if (num3 == 0U)
									{
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num5;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
										int_43++;
									}
									else if (num3 == 1U)
									{
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num5;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
										int_43++;
									}
									else if (num3 == 2U)
									{
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num5;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
										int_43++;
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num5;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 176;
										int_43++;
									}
								}
							}
						}
						if ((*(ref struct2 + 3) == 5 && *(ref struct2 + 2) == 145) || (*(ref struct2 + 3) == 49 && *(ref struct2 + 2) == 73) || (*(ref struct2 + 3) == 82 && *(ref struct2 + 2) == 135))
						{
							uint num6 = 0U;
							if ((*(ref struct2 + 14) & 127) == 0)
							{
								num6 = 6U;
							}
							if ((*(ref struct2 + 14) & 127) == 1)
							{
								num6 = 1U;
							}
							for (uint num3 = 0U; num3 < num6; num3 += 1U)
							{
								if ((*(ref struct2 + (num3 * 4U + 16U)) & 1) == 1)
								{
									uint num7 = (uint)((uint)(*(ref struct2 + (num3 * 4U + 17U))) << 8);
									num7 += (uint)(*(ref struct2 + (num3 * 4U + 16U)) & 252);
									if (num3 == 0U)
									{
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num7;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
									}
									else if (num3 == 2U)
									{
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num7;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
										int_43++;
									}
								}
							}
						}
						if (*(ref struct2 + 11) == 1 && *(ref struct2 + 10) == 1)
						{
							uint num3;
							for (num3 = 0U; num3 < 3678U; num3 += 6U)
							{
								if (struct2 == *(ref @struct + num3) && *(ref struct2 + 1) == *(ref @struct + (num3 + 1U)) && *(ref struct2 + 2) == *(ref @struct + (num3 + 2U)) && *(ref struct2 + 3) == *(ref @struct + (num3 + 3U)))
								{
									num = (uint)(*(ref @struct + (num3 + 4U)));
									break;
								}
							}
							if (num3 == 3678U)
							{
								num = 2U;
							}
							uint num8 = 1U;
							if ((*(ref struct2 + 9) & 1) == 0)
							{
								if (num != 0U)
								{
									if (num != 2U)
									{
										if (num != 1U)
										{
											goto IL_A34F;
										}
										if (int_43 <= (int)ushort_0)
										{
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 496;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											int_43++;
											num8 = 0U;
											goto IL_A34F;
										}
										return int_43;
									}
								}
								if (int_43 > (int)ushort_0)
								{
									return int_43;
								}
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
								*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 496;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
								int_43++;
								if (int_43 > (int)ushort_0)
								{
									return int_43;
								}
								*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 496;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 176;
								int_43++;
								num8 = 0U;
							}
							IL_A34F:
							if ((*(ref struct2 + 9) & 4) == 0)
							{
								if (num != 0U)
								{
									if (num != 2U)
									{
										if (num != 1U)
										{
											goto IL_A422;
										}
										if (int_43 <= (int)ushort_0)
										{
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 368;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											int_43++;
											num8 = 0U;
											goto IL_A422;
										}
										return int_43;
									}
								}
								if (int_43 > (int)ushort_0)
								{
									return int_43;
								}
								*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 368;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
								int_43++;
								if (int_43 > (int)ushort_0)
								{
									return int_43;
								}
								*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = 368;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
								*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 176;
								int_43++;
								num8 = 0U;
							}
							IL_A422:
							if (num8 == 1U)
							{
								uint num9 = 0U;
								if ((*(ref struct2 + 14) & 127) == 0)
								{
									num9 = 6U;
								}
								if ((*(ref struct2 + 14) & 127) == 1)
								{
									num9 = 1U;
								}
								num3 = 0U;
								while (num3 < num9 && *(ref struct2 + (num3 * 4U + 16U)) + *(ref struct2 + (num3 * 4U + 17U)) + *(ref struct2 + (num3 * 4U + 18U)) + *(ref struct2 + (num3 * 4U + 19U)) != 0)
								{
									if ((*(ref struct2 + (num3 * 4U + 16U)) & 1) == 1)
									{
										uint num10 = (uint)((uint)(*(ref struct2 + (num3 * 4U + 17U))) << 8);
										num10 += (uint)(*(ref struct2 + (num3 * 4U + 16U)) & 252);
										if (num3 == 0U && (num == 1U || num == 2U))
										{
											if (int_43 > (int)ushort_0)
											{
												return int_43;
											}
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num10;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											int_43++;
										}
										else if (num3 == 0U && num == 0U)
										{
											if (int_43 > (int)ushort_0)
											{
												return int_43;
											}
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num10;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											int_43++;
											if (int_43 > (int)ushort_0)
											{
												return int_43;
											}
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num10;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 176;
											int_43++;
										}
										else if (num3 == 2U && (num == 1U || num == 2U))
										{
											if (int_43 > (int)ushort_0)
											{
												return int_43;
											}
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num10;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											int_43++;
										}
										else if (num3 == 2U && num == 0U)
										{
											if (int_43 > (int)ushort_0)
											{
												return int_43;
											}
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num10;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
											int_43++;
											if (int_43 > (int)ushort_0)
											{
												return int_43;
											}
											*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num10;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 1;
											*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 176;
											int_43++;
										}
									}
									num3 += 1U;
								}
							}
						}
					}
				}
			}
		}
		return int_43;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x0034FA50 File Offset: 0x00297A50
	public unsafe static int smethod_86(GStruct86* pGstruct86_0, int int_43, ushort ushort_0)
	{
		Struct37 @struct;
		<Module>.memset((void*)(&@struct), 0, 40U);
		int num = <Module>.smethod_157();
		for (int i = 0; i <= num; i++)
		{
			for (int j = 0; j <= 31; j++)
			{
				for (int k = 0; k <= 7; k++)
				{
					<Module>.memset((void*)(&@struct), 0, 40U);
					for (uint num2 = 0U; num2 <= 36U; num2 += 4U)
					{
						int uint_ = (((i | -32768) * 32 | (int)((ushort)j)) * 8 | (int)((ushort)k)) << 8 | (int)(num2 & 4294967292U);
						<Module>.smethod_156((uint)uint_);
						*(ref @struct + num2) = <Module>.smethod_153();
					}
					if (@struct != 255 || *(ref @struct + 1) != 255)
					{
						if (*(ref @struct + 3) == 50 && *(ref @struct + 2) == 73)
						{
							uint num3 = 0U;
							if ((*(ref @struct + 14) & 127) == 0)
							{
								num3 = 6U;
							}
							if ((*(ref @struct + 14) & 127) == 1)
							{
								num3 = 1U;
							}
							for (uint num2 = 0U; num2 < num3; num2 += 1U)
							{
								if ((*(ref @struct + (num2 * 4U + 16U)) & 1) == 1)
								{
									uint num4 = (uint)((uint)(*(ref @struct + (num2 * 4U + 17U))) << 8);
									num4 += (uint)(*(ref @struct + (num2 * 4U + 16U)) & 252);
									if (num2 == 0U)
									{
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num4;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
										int_43++;
									}
									else if (num2 == 1U)
									{
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num4;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
										int_43++;
									}
									else if (num2 == 2U)
									{
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num4;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
										int_43++;
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num4;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 176;
										int_43++;
									}
								}
							}
						}
						if ((*(ref @struct + 3) == 5 && *(ref @struct + 2) == 145) || (*(ref @struct + 3) == 49 && *(ref @struct + 2) == 73) || (*(ref @struct + 3) == 82 && *(ref @struct + 2) == 135))
						{
							uint num5 = 0U;
							if ((*(ref @struct + 14) & 127) == 0)
							{
								num5 = 6U;
							}
							if ((*(ref @struct + 14) & 127) == 1)
							{
								num5 = 1U;
							}
							for (uint num2 = 0U; num2 < num5; num2 += 1U)
							{
								if ((*(ref @struct + (num2 * 4U + 16U)) & 1) == 1)
								{
									uint num6 = (uint)((uint)(*(ref @struct + (num2 * 4U + 17U))) << 8);
									num6 += (uint)(*(ref @struct + (num2 * 4U + 16U)) & 252);
									if (num2 == 0U)
									{
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num6;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
									}
									else if (num2 == 2U)
									{
										if (int_43 > (int)ushort_0)
										{
											return int_43;
										}
										*(short*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86)) = (short)num6;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 2 / sizeof(GStruct86)) = 1;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 3 / sizeof(GStruct86)) = 0;
										*(byte*)(pGstruct86_0 + int_43 * 72 / sizeof(GStruct86) + 4 / sizeof(GStruct86)) = 160;
										int_43++;
									}
								}
							}
						}
					}
				}
			}
		}
		return int_43;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00015328 File Offset: 0x00015328
	public unsafe static int smethod_87()
	{
		GStruct0 gstruct;
		<Module>.SetupDiClassGuidsFromNameA((sbyte*)(&<Module>.struct7_2), &gstruct, 1, null);
		int result;
		if (<Module>.smethod_80(ref gstruct, ref <Module>.gstruct0_1) != null)
		{
			result = 1;
		}
		else
		{
			void* ptr = <Module>.SetupDiGetClassDevsA((GStruct0*)(&gstruct), null, null, 2);
			if (ptr == -1)
			{
				result = 1;
			}
			else
			{
				GStruct87 gstruct2 = 28;
				uint num = 0U;
				uint num2 = 0U;
				uint num3 = <Module>.SetupDiEnumDeviceInfo(ptr, 0, &gstruct2);
				if (num3 == 0U)
				{
					<Module>.SetupDiDestroyDeviceInfoList(ptr);
					result = 2;
				}
				else
				{
					for (uint num4 = 0U; num4 < num3; num4 += 1U)
					{
						GStruct88 gstruct3 = 287;
						<Module>.SetupDiGetDeviceInfoListDetailA(ptr, &gstruct3);
						<Module>.CM_Get_DevNode_Status((uint*)(&num), (uint*)(&num2), *(ref gstruct2 + 20), 0);
					}
					<Module>.SetupDiDestroyDeviceInfoList(ptr);
					result = num2;
				}
			}
		}
		return result;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00156038 File Offset: 0x00156038
	public unsafe static uint smethod_88(sbyte* pSbyte_0)
	{
		return <Module>.strlen(pSbyte_0);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00155DB8 File Offset: 0x00155DB8
	public unsafe static int smethod_89(GStruct81* pGstruct81_0, GStruct81* pGstruct81_1, sbyte* pSbyte_0, int int_43)
	{
		Class0 @class = new Class0(new string((sbyte*)(&<Module>.struct118_0)));
		int result;
		if (@class.method_0())
		{
			GStruct11* ptr = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct12_6));
			if (ptr == null)
			{
				ptr = <Module>.FindWindowA((sbyte*)(&<Module>.struct9_29), null);
				if (ptr == null)
				{
					ptr = <Module>.FindWindowA((sbyte*)(&<Module>.struct26_1), null);
				}
			}
			GStruct11* pGstruct11_ = <Module>.FindWindowExA(ptr, null, null, (sbyte*)(&<Module>.struct16_5));
			GStruct11* pGstruct11_2 = <Module>.FindWindowExA(ptr, null, null, (sbyte*)(&<Module>.struct16_6));
			GStruct11* pGstruct11_3 = <Module>.FindWindowExA(ptr, null, null, (sbyte*)(&<Module>.struct16_7));
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			if (commandLineArgs.Length == 3)
			{
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(commandLineArgs[1]);
				IntPtr value = intPtr;
				int int_44 = (void*)value;
				if (string.Compare(commandLineArgs[2], "Source") == 0)
				{
					<Module>.SendMessageA(pGstruct11_, 12U, 0U, int_44);
				}
				else if (string.Compare(commandLineArgs[2], "Target") == 0)
				{
					<Module>.SendMessageA(pGstruct11_2, 12U, 0U, int_44);
				}
				else if (string.Compare(commandLineArgs[2], "DBupdate") == 0)
				{
					<Module>.SendMessageA(pGstruct11_3, 12U, 0U, int_44);
				}
			}
			else if (commandLineArgs.Length == 2)
			{
				IntPtr intPtr2 = Marshal.StringToHGlobalAnsi(commandLineArgs[1]);
				IntPtr value2 = intPtr2;
				int int_45 = (void*)value2;
				<Module>.SendMessageA(pGstruct11_, 12U, 0U, int_45);
			}
			<Module>.ShowWindow(ptr, 9);
			result = 0;
		}
		else
		{
			Thread.CurrentThread.ApartmentState = ApartmentState.STA;
			Application.Run(new Form1());
			result = 0;
		}
		return result;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00155F08 File Offset: 0x00155F08
	public unsafe static GStruct19* smethod_90(GStruct19* pGstruct19_0)
	{
		GStruct61 gstruct;
		<Module>.smethod_53(pGstruct19_0, <Module>.smethod_97(ref gstruct));
		<Module>.smethod_51(pGstruct19_0, false, 0U);
		return pGstruct19_0;
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00155F38 File Offset: 0x00155F38
	public unsafe static GStruct19* smethod_91(GStruct19* pGstruct19_0, sbyte* pSbyte_0)
	{
		GStruct61 gstruct;
		<Module>.smethod_53(pGstruct19_0, <Module>.smethod_97(ref gstruct));
		<Module>.smethod_51(pGstruct19_0, false, 0U);
		<Module>.smethod_96(pGstruct19_0, pSbyte_0);
		return pGstruct19_0;
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00155F78 File Offset: 0x00155F78
	public unsafe static void smethod_92(GStruct19* pGstruct19_0)
	{
		<Module>.smethod_51(pGstruct19_0, true, 0U);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00155F98 File Offset: 0x00155F98
	public unsafe static GStruct19* smethod_93(GStruct19* pGstruct19_0, GStruct19* pGstruct19_1)
	{
		return <Module>.smethod_95(pGstruct19_0, pGstruct19_1);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00155FB8 File Offset: 0x00155FB8
	public unsafe static sbyte* smethod_94(GStruct19* pGstruct19_0)
	{
		return <Module>.smethod_52(pGstruct19_0);
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00155FD8 File Offset: 0x00155FD8
	public unsafe static GStruct19* smethod_95(GStruct19* pGstruct19_0, GStruct19* pGstruct19_1)
	{
		return <Module>.smethod_50(pGstruct19_0, pGstruct19_1, 0U, <Module>.uint_0);
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00156008 File Offset: 0x00156008
	public unsafe static GStruct19* smethod_96(GStruct19* pGstruct19_0, sbyte* pSbyte_0)
	{
		return <Module>.smethod_98(pGstruct19_0, pSbyte_0, <Module>.smethod_88(pSbyte_0));
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00156058 File Offset: 0x00156058
	public unsafe static GStruct61* smethod_97(GStruct61* pGstruct61_0)
	{
		return pGstruct61_0;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00156078 File Offset: 0x00156078
	public unsafe static GStruct19* smethod_98(GStruct19* pGstruct19_0, sbyte* pSbyte_0, uint uint_2)
	{
		GStruct19* result;
		if (<Module>.smethod_99(pGstruct19_0, pSbyte_0) != null)
		{
			result = <Module>.smethod_50(pGstruct19_0, pGstruct19_0, pSbyte_0 - <Module>.smethod_62(pGstruct19_0) / sizeof(sbyte), uint_2);
		}
		else
		{
			if (<Module>.smethod_61(pGstruct19_0, uint_2, false) != null)
			{
				<Module>.smethod_37(<Module>.smethod_62(pGstruct19_0), pSbyte_0, uint_2);
				<Module>.smethod_60(pGstruct19_0, uint_2);
			}
			result = pGstruct19_0;
		}
		return result;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x001560D8 File Offset: 0x001560D8
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool smethod_99(GStruct19* pGstruct19_0, sbyte* pSbyte_0)
	{
		return (pSbyte_0 < <Module>.smethod_62(pGstruct19_0) || <Module>.smethod_62(pGstruct19_0) + *(pGstruct19_0 + 20) == pSbyte_0) ? 0 : 1;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00156118 File Offset: 0x00156118
	public unsafe static void smethod_100(GStruct102* pGstruct102_0, GStruct103* pGstruct103_0)
	{
		*(int*)(pGstruct103_0 + 20 / sizeof(GStruct103)) = 0;
		*(int*)(pGstruct103_0 + 16 / sizeof(GStruct103)) = 0;
		*(int*)pGstruct103_0 = 1732584193;
		*(int*)(pGstruct103_0 + 4 / sizeof(GStruct103)) = -271733879;
		*(int*)(pGstruct103_0 + 8 / sizeof(GStruct103)) = -1732584194;
		*(int*)(pGstruct103_0 + 12 / sizeof(GStruct103)) = 271733878;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00156154 File Offset: 0x00156154
	public unsafe static void smethod_101(GStruct102* pGstruct102_0, GStruct103* pGstruct103_0, byte* pByte_0, uint uint_2)
	{
		uint num = (uint)(*(int*)(pGstruct103_0 + 16 / sizeof(GStruct103))) >> 3 & 63U;
		*(int*)(pGstruct103_0 + 16 / sizeof(GStruct103)) = *(int*)(pGstruct103_0 + 16 / sizeof(GStruct103)) + (int)((int)uint_2 << 3);
		if (*(int*)(pGstruct103_0 + 16 / sizeof(GStruct103)) < (int)((int)uint_2 << 3))
		{
			*(int*)(pGstruct103_0 + 20 / sizeof(GStruct103)) = *(int*)(pGstruct103_0 + 20 / sizeof(GStruct103)) + 1;
		}
		*(int*)(pGstruct103_0 + 20 / sizeof(GStruct103)) = *(int*)(pGstruct103_0 + 20 / sizeof(GStruct103)) + (int)(uint_2 >> 29);
		uint num2 = 64U - num;
		uint num3;
		if (uint_2 >= num2)
		{
			<Module>.smethod_106(pGstruct102_0, (byte*)(pGstruct103_0 + 24 / sizeof(GStruct103) + num / (uint)sizeof(GStruct103)), pByte_0, num2);
			<Module>.smethod_103(pGstruct102_0, (uint*)pGstruct103_0, (byte*)(pGstruct103_0 + 24 / sizeof(GStruct103)));
			num3 = num2;
			while (num3 + 63U < uint_2)
			{
				<Module>.smethod_103(pGstruct102_0, (uint*)pGstruct103_0, pByte_0 + num3);
				num3 += 64U;
			}
			num = 0U;
		}
		else
		{
			num3 = 0U;
		}
		<Module>.smethod_106(pGstruct102_0, (byte*)(pGstruct103_0 + 24 / sizeof(GStruct103) + num / (uint)sizeof(GStruct103)), pByte_0 + num3, uint_2 - num3);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x001561F8 File Offset: 0x001561F8
	public unsafe static void smethod_102(GStruct102* pGstruct102_0, byte* pByte_0, GStruct103* pGstruct103_0)
	{
		Struct103 @struct;
		<Module>.smethod_104(pGstruct102_0, (byte*)(&@struct), (uint*)(pGstruct103_0 + 16 / sizeof(GStruct103)), 8U);
		uint num = (uint)(*(int*)(pGstruct103_0 + 16 / sizeof(GStruct103))) >> 3 & 63U;
		uint uint_ = (num >= 56U) ? (120U - num) : (56U - num);
		<Module>.smethod_101(pGstruct102_0, pGstruct103_0, (byte*)(&<Module>.struct4_1), uint_);
		<Module>.smethod_101(pGstruct102_0, pGstruct103_0, (byte*)(&@struct), 8U);
		<Module>.smethod_104(pGstruct102_0, pByte_0, (uint*)pGstruct103_0, 16U);
		<Module>.smethod_107(pGstruct102_0, (byte*)pGstruct103_0, 0, 88U);
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00156258 File Offset: 0x00156258
	public unsafe static void smethod_103(GStruct102* pGstruct102_0, uint* pUint_0, byte* pByte_0)
	{
		uint num = (uint)(*(int*)pUint_0);
		uint num2 = (uint)(*(int*)(pUint_0 + 4 / sizeof(uint)));
		uint num3 = (uint)(*(int*)(pUint_0 + 8 / sizeof(uint)));
		uint num4 = (uint)(*(int*)(pUint_0 + 12 / sizeof(uint)));
		Struct124 @struct;
		<Module>.smethod_105(pGstruct102_0, (uint*)(&@struct), pByte_0, 64U);
		num += ((num2 & num3) | (~num2 & num4)) + @struct + -680876936;
		num = (num << 7 | num >> 25);
		num += num2;
		num4 += ((num & num2) | (~num & num3)) + (uint)(*(ref @struct + 4)) + 3905402710U;
		num4 = (num4 << 12 | num4 >> 20);
		num4 += num;
		num3 += ((num4 & num) | (~num4 & num2)) + (uint)(*(ref @struct + 8)) + 606105819U;
		num3 = (num3 << 17 | num3 >> 15);
		num3 += num4;
		num2 += ((num3 & num4) | (~num3 & num)) + (uint)(*(ref @struct + 12)) + 3250441966U;
		num2 = (num2 << 22 | num2 >> 10);
		num2 += num3;
		num += ((num2 & num3) | (~num2 & num4)) + (uint)(*(ref @struct + 16)) + 4118548399U;
		num = (num << 7 | num >> 25);
		num += num2;
		num4 += ((num & num2) | (~num & num3)) + (uint)(*(ref @struct + 20)) + 1200080426U;
		num4 = (num4 << 12 | num4 >> 20);
		num4 += num;
		num3 += ((num4 & num) | (~num4 & num2)) + (uint)(*(ref @struct + 24)) + 2821735955U;
		num3 = (num3 << 17 | num3 >> 15);
		num3 += num4;
		num2 += ((num3 & num4) | (~num3 & num)) + (uint)(*(ref @struct + 28)) + 4249261313U;
		num2 = (num2 << 22 | num2 >> 10);
		num2 += num3;
		num += ((num2 & num3) | (~num2 & num4)) + (uint)(*(ref @struct + 32)) + 1770035416U;
		num = (num << 7 | num >> 25);
		num += num2;
		num4 += ((num & num2) | (~num & num3)) + (uint)(*(ref @struct + 36)) + 2336552879U;
		num4 = (num4 << 12 | num4 >> 20);
		num4 += num;
		num3 += ((num4 & num) | (~num4 & num2)) + (uint)(*(ref @struct + 40)) + 4294925233U;
		num3 = (num3 << 17 | num3 >> 15);
		num3 += num4;
		num2 += ((num3 & num4) | (~num3 & num)) + (uint)(*(ref @struct + 44)) + 2304563134U;
		num2 = (num2 << 22 | num2 >> 10);
		num2 += num3;
		num += ((num2 & num3) | (~num2 & num4)) + (uint)(*(ref @struct + 48)) + 1804603682U;
		num = (num << 7 | num >> 25);
		num += num2;
		num4 += ((num & num2) | (~num & num3)) + (uint)(*(ref @struct + 52)) + 4254626195U;
		num4 = (num4 << 12 | num4 >> 20);
		num4 += num;
		num3 += ((num4 & num) | (~num4 & num2)) + (uint)(*(ref @struct + 56)) + 2792965006U;
		num3 = (num3 << 17 | num3 >> 15);
		num3 += num4;
		num2 += ((num3 & num4) | (~num3 & num)) + (uint)(*(ref @struct + 60)) + 1236535329U;
		num2 = (num2 << 22 | num2 >> 10);
		num2 += num3;
		num += ((num2 & num4) | (num3 & ~num4)) + (uint)(*(ref @struct + 4)) + 4129170786U;
		num = (num << 5 | num >> 27);
		num += num2;
		num4 += ((num & num3) | (num2 & ~num3)) + (uint)(*(ref @struct + 24)) + 3225465664U;
		num4 = (num4 << 9 | num4 >> 23);
		num4 += num;
		num3 += ((num4 & num2) | (num & ~num2)) + (uint)(*(ref @struct + 44)) + 643717713U;
		num3 = (num3 << 14 | num3 >> 18);
		num3 += num4;
		num2 += ((num3 & num) | (num4 & ~num)) + @struct + -373897302;
		num2 = (num2 << 20 | num2 >> 12);
		num2 += num3;
		num += ((num2 & num4) | (num3 & ~num4)) + (uint)(*(ref @struct + 20)) + 3593408605U;
		num = (num << 5 | num >> 27);
		num += num2;
		num4 += ((num & num3) | (num2 & ~num3)) + (uint)(*(ref @struct + 40)) + 38016083U;
		num4 = (num4 << 9 | num4 >> 23);
		num4 += num;
		num3 += ((num4 & num2) | (num & ~num2)) + (uint)(*(ref @struct + 60)) + 3634488961U;
		num3 = (num3 << 14 | num3 >> 18);
		num3 += num4;
		num2 += ((num3 & num) | (num4 & ~num)) + (uint)(*(ref @struct + 16)) + 3889429448U;
		num2 = (num2 << 20 | num2 >> 12);
		num2 += num3;
		num += ((num2 & num4) | (num3 & ~num4)) + (uint)(*(ref @struct + 36)) + 568446438U;
		num = (num << 5 | num >> 27);
		num += num2;
		num4 += ((num & num3) | (num2 & ~num3)) + (uint)(*(ref @struct + 56)) + 3275163606U;
		num4 = (num4 << 9 | num4 >> 23);
		num4 += num;
		num3 += ((num4 & num2) | (num & ~num2)) + (uint)(*(ref @struct + 12)) + 4107603335U;
		num3 = (num3 << 14 | num3 >> 18);
		num3 += num4;
		num2 += ((num3 & num) | (num4 & ~num)) + (uint)(*(ref @struct + 32)) + 1163531501U;
		num2 = (num2 << 20 | num2 >> 12);
		num2 += num3;
		num += ((num2 & num4) | (num3 & ~num4)) + (uint)(*(ref @struct + 52)) + 2850285829U;
		num = (num << 5 | num >> 27);
		num += num2;
		num4 += ((num & num3) | (num2 & ~num3)) + (uint)(*(ref @struct + 8)) + 4243563512U;
		num4 = (num4 << 9 | num4 >> 23);
		num4 += num;
		num3 += ((num4 & num2) | (num & ~num2)) + (uint)(*(ref @struct + 28)) + 1735328473U;
		num3 = (num3 << 14 | num3 >> 18);
		num3 += num4;
		num2 += ((num3 & num) | (num4 & ~num)) + (uint)(*(ref @struct + 48)) + 2368359562U;
		num2 = (num2 << 20 | num2 >> 12);
		num2 += num3;
		num += (num2 ^ num3 ^ num4) + (uint)(*(ref @struct + 20)) + 4294588738U;
		num = (num << 4 | num >> 28);
		num += num2;
		num4 += (num ^ num2 ^ num3) + (uint)(*(ref @struct + 32)) + 2272392833U;
		num4 = (num4 << 11 | num4 >> 21);
		num4 += num;
		num3 += (num4 ^ num ^ num2) + (uint)(*(ref @struct + 44)) + 1839030562U;
		num3 = (num3 << 16 | num3 >> 16);
		num3 += num4;
		num2 += (num3 ^ num4 ^ num) + (uint)(*(ref @struct + 56)) + 4259657740U;
		num2 = (num2 << 23 | num2 >> 9);
		num2 += num3;
		num += (num2 ^ num3 ^ num4) + (uint)(*(ref @struct + 4)) + 2763975236U;
		num = (num << 4 | num >> 28);
		num += num2;
		num4 += (num ^ num2 ^ num3) + (uint)(*(ref @struct + 16)) + 1272893353U;
		num4 = (num4 << 11 | num4 >> 21);
		num4 += num;
		num3 += (num4 ^ num ^ num2) + (uint)(*(ref @struct + 28)) + 4139469664U;
		num3 = (num3 << 16 | num3 >> 16);
		num3 += num4;
		num2 += (num3 ^ num4 ^ num) + (uint)(*(ref @struct + 40)) + 3200236656U;
		num2 = (num2 << 23 | num2 >> 9);
		num2 += num3;
		num += (num2 ^ num3 ^ num4) + (uint)(*(ref @struct + 52)) + 681279174U;
		num = (num << 4 | num >> 28);
		num += num2;
		num4 += (num ^ num2 ^ num3) + @struct + -358537222;
		num4 = (num4 << 11 | num4 >> 21);
		num4 += num;
		num3 += (num4 ^ num ^ num2) + (uint)(*(ref @struct + 12)) + 3572445317U;
		num3 = (num3 << 16 | num3 >> 16);
		num3 += num4;
		num2 += (num3 ^ num4 ^ num) + (uint)(*(ref @struct + 24)) + 76029189U;
		num2 = (num2 << 23 | num2 >> 9);
		num2 += num3;
		num += (num2 ^ num3 ^ num4) + (uint)(*(ref @struct + 36)) + 3654602809U;
		num = (num << 4 | num >> 28);
		num += num2;
		num4 += (num ^ num2 ^ num3) + (uint)(*(ref @struct + 48)) + 3873151461U;
		num4 = (num4 << 11 | num4 >> 21);
		num4 += num;
		num3 += (num4 ^ num ^ num2) + (uint)(*(ref @struct + 60)) + 530742520U;
		num3 = (num3 << 16 | num3 >> 16);
		num3 += num4;
		num2 += (num3 ^ num4 ^ num) + (uint)(*(ref @struct + 8)) + 3299628645U;
		num2 = (num2 << 23 | num2 >> 9);
		num2 += num3;
		num += (num3 ^ (num2 | ~num4)) + @struct + -198630844;
		num = (num << 6 | num >> 26);
		num += num2;
		num4 += (num2 ^ (num | ~num3)) + (uint)(*(ref @struct + 28)) + 1126891415U;
		num4 = (num4 << 10 | num4 >> 22);
		num4 += num;
		num3 += (num ^ (num4 | ~num2)) + (uint)(*(ref @struct + 56)) + 2878612391U;
		num3 = (num3 << 15 | num3 >> 17);
		num3 += num4;
		num2 += (num4 ^ (num3 | ~num)) + (uint)(*(ref @struct + 20)) + 4237533241U;
		num2 = (num2 << 21 | num2 >> 11);
		num2 += num3;
		num += (num3 ^ (num2 | ~num4)) + (uint)(*(ref @struct + 48)) + 1700485571U;
		num = (num << 6 | num >> 26);
		num += num2;
		num4 += (num2 ^ (num | ~num3)) + (uint)(*(ref @struct + 12)) + 2399980690U;
		num4 = (num4 << 10 | num4 >> 22);
		num4 += num;
		num3 += (num ^ (num4 | ~num2)) + (uint)(*(ref @struct + 40)) + 4293915773U;
		num3 = (num3 << 15 | num3 >> 17);
		num3 += num4;
		num2 += (num4 ^ (num3 | ~num)) + (uint)(*(ref @struct + 4)) + 2240044497U;
		num2 = (num2 << 21 | num2 >> 11);
		num2 += num3;
		num += (num3 ^ (num2 | ~num4)) + (uint)(*(ref @struct + 32)) + 1873313359U;
		num = (num << 6 | num >> 26);
		num += num2;
		num4 += (num2 ^ (num | ~num3)) + (uint)(*(ref @struct + 60)) + 4264355552U;
		num4 = (num4 << 10 | num4 >> 22);
		num4 += num;
		num3 += (num ^ (num4 | ~num2)) + (uint)(*(ref @struct + 24)) + 2734768916U;
		num3 = (num3 << 15 | num3 >> 17);
		num3 += num4;
		num2 += (num4 ^ (num3 | ~num)) + (uint)(*(ref @struct + 52)) + 1309151649U;
		num2 = (num2 << 21 | num2 >> 11);
		num2 += num3;
		num += (num3 ^ (num2 | ~num4)) + (uint)(*(ref @struct + 16)) + 4149444226U;
		num = (num << 6 | num >> 26);
		num += num2;
		num4 += (num2 ^ (num | ~num3)) + (uint)(*(ref @struct + 44)) + 3174756917U;
		num4 = (num4 << 10 | num4 >> 22);
		num4 += num;
		num3 += (num ^ (num4 | ~num2)) + (uint)(*(ref @struct + 8)) + 718787259U;
		num3 = (num3 << 15 | num3 >> 17);
		num3 += num4;
		num2 += (num4 ^ (num3 | ~num)) + (uint)(*(ref @struct + 36)) + 3951481745U;
		num2 = (num2 << 21 | num2 >> 11);
		num2 += num3;
		*(int*)pUint_0 = *(int*)pUint_0 + (int)num;
		*(int*)(pUint_0 + 4 / sizeof(uint)) = *(int*)(pUint_0 + 4 / sizeof(uint)) + (int)num2;
		*(int*)(pUint_0 + 8 / sizeof(uint)) = *(int*)(pUint_0 + 8 / sizeof(uint)) + (int)num3;
		*(int*)(pUint_0 + 12 / sizeof(uint)) = *(int*)(pUint_0 + 12 / sizeof(uint)) + (int)num4;
		<Module>.smethod_107(pGstruct102_0, (byte*)(&@struct), 0, 64U);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00156BC0 File Offset: 0x00156BC0
	public unsafe static void smethod_104(GStruct102* pGstruct102_0, byte* pByte_0, uint* pUint_0, uint uint_2)
	{
		uint num = 0U;
		for (uint num2 = 0U; num2 < uint_2; num2 += 4U)
		{
			pByte_0[num2] = (byte)(*(int*)(pUint_0 + num * 4U / (uint)sizeof(uint)) & 255);
			pByte_0[num2 + 1U] = (byte)((uint)(*(int*)(pUint_0 + num * 4U / (uint)sizeof(uint))) >> 8 & 255U);
			pByte_0[num2 + 2U] = (byte)((uint)(*(int*)(pUint_0 + num * 4U / (uint)sizeof(uint))) >> 16 & 255U);
			pByte_0[num2 + 3U] = (byte)((uint)(*(int*)(pUint_0 + num * 4U / (uint)sizeof(uint))) >> 24 & 255U);
			num += 1U;
		}
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00156C30 File Offset: 0x00156C30
	public unsafe static void smethod_105(GStruct102* pGstruct102_0, uint* pUint_0, byte* pByte_0, uint uint_2)
	{
		uint num = 0U;
		for (uint num2 = 0U; num2 < uint_2; num2 += 4U)
		{
			*(int*)(pUint_0 + num * 4U / (uint)sizeof(uint)) = ((int)pByte_0[num2] | (int)pByte_0[num2 + 1U] << 8 | (int)pByte_0[num2 + 2U] << 16 | (int)pByte_0[num2 + 3U] << 24);
			num += 1U;
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00156C78 File Offset: 0x00156C78
	public unsafe static void smethod_106(GStruct102* pGstruct102_0, byte* pByte_0, byte* pByte_1, uint uint_2)
	{
		for (uint num = 0U; num < uint_2; num += 1U)
		{
			pByte_0[num] = pByte_1[num];
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00156C9C File Offset: 0x00156C9C
	public unsafe static void smethod_107(GStruct102* pGstruct102_0, byte* pByte_0, int int_43, uint uint_2)
	{
		for (uint num = 0U; num < uint_2; num += 1U)
		{
			pByte_0[num] = (byte)int_43;
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x001571D8 File Offset: 0x001571D8
	public unsafe static GStruct102* smethod_108(GStruct102* pGstruct102_0)
	{
		return pGstruct102_0;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00156D38 File Offset: 0x00156D38
	public unsafe static GStruct19* smethod_109(GStruct93* pGstruct93_0, GStruct19* pGstruct19_0, GStruct19* pGstruct19_1)
	{
		uint num = 0U;
		try
		{
			try
			{
				GStruct103 gstruct;
				<Module>.smethod_100(*pGstruct93_0, &gstruct);
				<Module>.smethod_101(*pGstruct93_0, &gstruct, <Module>.smethod_94(pGstruct19_1), <Module>.smethod_117(pGstruct19_1));
				Struct28 @struct;
				cpblk(ref @struct, ref <Module>.struct19_1, 1);
				initblk(ref @struct + 1, 0, 15);
				<Module>.smethod_102(*pGstruct93_0, (byte*)(&@struct), &gstruct);
				<Module>.smethod_110(pGstruct93_0, pGstruct19_0, (byte*)(&@struct));
				num |= 1U;
			}
			catch
			{
				<Module>.__CxxCallUnwindDtor(<Module>.ppInt_14, (void*)pGstruct19_1);
				throw;
			}
			<Module>.smethod_92(pGstruct19_1);
		}
		catch
		{
			if ((num & 1U) != 0U)
			{
				num &= 4294967294U;
				<Module>.__CxxCallUnwindDtor(<Module>.ppInt_14, (void*)pGstruct19_0);
			}
			throw;
		}
		return pGstruct19_0;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00156DF8 File Offset: 0x00156DF8
	public unsafe static GStruct19* smethod_110(GStruct93* pGstruct93_0, GStruct19* pGstruct19_0, byte* pByte_0)
	{
		uint num = 0U;
		int num2 = 0;
		Struct125 @struct;
		for (int i = 0; i < 16; i++)
		{
			<Module>.sprintf(ref @struct + num2, (sbyte*)(&<Module>.struct35_134), pByte_0[i]);
			num2 += 2;
		}
		*(ref @struct + 32) = 0;
		<Module>.smethod_91(pGstruct19_0, (sbyte*)(&@struct));
		num |= 1U;
		return pGstruct19_0;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00156E4C File Offset: 0x00156E4C
	public unsafe static GStruct93* smethod_111(GStruct93* pGstruct93_0)
	{
		GStruct102* ptr = <Module>.@new(1U);
		GStruct102* ptr2;
		try
		{
			ptr2 = ((ptr == null) ? null : <Module>.smethod_108(ptr));
		}
		catch
		{
			<Module>.delete((void*)ptr);
			throw;
		}
		*pGstruct93_0 = ptr2;
		return pGstruct93_0;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00156E98 File Offset: 0x00156E98
	public unsafe static void smethod_112(GStruct93* pGstruct93_0)
	{
		<Module>.delete(*pGstruct93_0);
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00156EAC File Offset: 0x00156EAC
	public unsafe static GStruct19* smethod_113(GStruct93* pGstruct93_0, GStruct19* pGstruct19_0, GStruct19* pGstruct19_1)
	{
		uint num = 0U;
		try
		{
			try
			{
				GStruct19 gstruct;
				GStruct19* pGstruct19_2 = <Module>.smethod_45(ref gstruct, pGstruct19_1);
				<Module>.smethod_109(pGstruct93_0, pGstruct19_0, (GStruct19*)pGstruct19_2);
				num |= 1U;
			}
			catch
			{
				<Module>.__CxxCallUnwindDtor(<Module>.ppInt_14, (void*)pGstruct19_1);
				throw;
			}
			<Module>.smethod_92(pGstruct19_1);
		}
		catch
		{
			if ((num & 1U) != 0U)
			{
				num &= 4294967294U;
				<Module>.__CxxCallUnwindDtor(<Module>.ppInt_14, (void*)pGstruct19_0);
			}
			throw;
		}
		return pGstruct19_0;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00156F38 File Offset: 0x00156F38
	public unsafe static GStruct19* smethod_114(GStruct93* pGstruct93_0, GStruct19* pGstruct19_0, GStruct19* pGstruct19_1)
	{
		uint num = 0U;
		try
		{
			try
			{
				GStruct5* ptr = <Module>.fopen(<Module>.smethod_94(pGstruct19_1), (sbyte*)(&<Module>.struct18_13));
				if (ptr != null)
				{
					goto IL_3E;
				}
				<Module>.smethod_91(pGstruct19_0, (sbyte*)(&<Module>.struct18_14));
				num |= 1U;
			}
			catch
			{
				<Module>.__CxxCallUnwindDtor(<Module>.ppInt_14, (void*)pGstruct19_1);
				throw;
			}
			<Module>.smethod_92(pGstruct19_1);
			return pGstruct19_0;
			try
			{
				IL_3E:
				GStruct103 gstruct;
				<Module>.smethod_100(*pGstruct93_0, &gstruct);
				GStruct5* ptr;
				for (;;)
				{
					Struct126 @struct;
					int num2 = <Module>.fread((void*)(&@struct), 1U, 1024U, ptr);
					if (num2 == 0)
					{
						break;
					}
					<Module>.smethod_101(*pGstruct93_0, &gstruct, (byte*)(&@struct), (uint)num2);
				}
				Struct28 struct2;
				<Module>.smethod_102(*pGstruct93_0, (byte*)(&struct2), &gstruct);
				<Module>.fclose(ptr);
				<Module>.smethod_110(pGstruct93_0, pGstruct19_0, (byte*)(&struct2));
				num |= 1U;
			}
			catch
			{
				<Module>.__CxxCallUnwindDtor(<Module>.ppInt_14, (void*)pGstruct19_1);
				throw;
			}
			<Module>.smethod_92(pGstruct19_1);
		}
		catch
		{
			if ((num & 1U) != 0U)
			{
				num &= 4294967294U;
				<Module>.__CxxCallUnwindDtor(<Module>.ppInt_14, (void*)pGstruct19_0);
			}
			throw;
		}
		return pGstruct19_0;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0015704C File Offset: 0x0015704C
	public unsafe static GStruct19* smethod_115(GStruct93* pGstruct93_0, GStruct19* pGstruct19_0, byte* pByte_0, uint uint_2)
	{
		uint num = 0U;
		GStruct103 gstruct;
		<Module>.smethod_100(*pGstruct93_0, &gstruct);
		int num2 = (int)(uint_2 / 1024U);
		int num3 = (int)(uint_2 % 1024U);
		Struct126 @struct;
		for (int i = 0; i < num2; i++)
		{
			<Module>.memcpy((void*)(&@struct), (void*)(pByte_0 + i * 1024), 1024U);
			<Module>.smethod_101(*pGstruct93_0, &gstruct, (byte*)(&@struct), 1024U);
		}
		if (num3 != 0)
		{
			<Module>.memcpy((void*)(&@struct), (void*)(pByte_0 + num2 * 1024), (uint)num3);
			<Module>.smethod_101(*pGstruct93_0, &gstruct, (byte*)(&@struct), (uint)num3);
		}
		Struct28 struct2;
		<Module>.smethod_102(*pGstruct93_0, (byte*)(&struct2), &gstruct);
		<Module>.smethod_110(pGstruct93_0, pGstruct19_0, (byte*)(&struct2));
		num |= 1U;
		return pGstruct19_0;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x001570EC File Offset: 0x001570EC
	public unsafe static void smethod_116(GStruct93* pGstruct93_0, GStruct19* pGstruct19_0, byte* pByte_0)
	{
		try
		{
			GStruct5* ptr = <Module>.fopen(<Module>.smethod_94(pGstruct19_0), (sbyte*)(&<Module>.struct18_15));
			if (ptr != null)
			{
				goto IL_2C;
			}
		}
		catch
		{
			<Module>.__CxxCallUnwindDtor(<Module>.ppInt_14, (void*)pGstruct19_0);
			throw;
		}
		<Module>.smethod_92(pGstruct19_0);
		return;
		try
		{
			IL_2C:
			GStruct103 gstruct;
			<Module>.smethod_100(*pGstruct93_0, &gstruct);
			GStruct5* ptr;
			for (;;)
			{
				Struct126 @struct;
				int num = <Module>.fread((void*)(&@struct), 1U, 1024U, ptr);
				if (num == 0)
				{
					break;
				}
				<Module>.smethod_101(*pGstruct93_0, &gstruct, (byte*)(&@struct), (uint)num);
			}
			<Module>.smethod_102(*pGstruct93_0, pByte_0, &gstruct);
			<Module>.fclose(ptr);
		}
		catch
		{
			<Module>.__CxxCallUnwindDtor(<Module>.ppInt_14, (void*)pGstruct19_0);
			throw;
		}
		<Module>.smethod_92(pGstruct19_0);
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00157248 File Offset: 0x00157248
	public unsafe static uint smethod_117(GStruct19* pGstruct19_0)
	{
		return *(pGstruct19_0 + 20);
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0034FDC4 File Offset: 0x00297DC4
	public unsafe static int smethod_118(GStruct99* pGstruct99_0, int int_43, ushort ushort_0)
	{
		void* ptr = <Module>.SetupDiGetClassDevsA((GStruct0*)(&<Module>.gstruct0_6), null, null, 18);
		int result;
		if (ptr == -1)
		{
			result = 1;
		}
		else
		{
			GStruct87 gstruct = 28;
			uint num = 0U;
			while (<Module>.SetupDiEnumDeviceInfo(ptr, num, &gstruct) != null)
			{
				GStruct88 gstruct2 = 287;
				uint num2 = 0U;
				uint num3 = 0U;
				uint num4 = 0U;
				if (<Module>.SetupDiGetDeviceInfoListDetailA(ptr, &gstruct2) == null && <Module>.CM_Get_DevNode_Status_Ex((uint*)(&num2), (uint*)(&num3), *(ref gstruct + 20), 0, null) != null)
				{
					return 2;
				}
				if (int_43 < (int)ushort_0)
				{
					Struct27 @struct;
					<Module>.memset((void*)(&@struct), 0, 1024U);
					uint num5 = 10U;
					GStruct106* pGstruct106_ = <Module>.SetupDiOpenDevRegKey(ptr, &gstruct, 1, 0, 1, 983103);
					<Module>.RegQueryValueExA(pGstruct106_, (sbyte*)(&<Module>.struct24_11), null, null, (byte*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99)), (uint*)(&num5));
					<Module>.RegCloseKey(pGstruct106_);
					<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 0, null, (byte*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 12 / sizeof(GStruct99)), 1024, null);
					<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 9, null, (byte*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 73 / sizeof(GStruct99)), 1024, null);
					<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 1, null, (byte*)(&@struct), 1024, null);
					<Module>._strlwr((sbyte*)(&@struct));
					if (<Module>.memcmp((void*)(&@struct), (void*)(&<Module>.struct25_12), 3U) == null)
					{
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 8 / sizeof(GStruct99)) = 0;
					}
					else
					{
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 8 / sizeof(GStruct99)) = 1;
					}
					if (<Module>.memcmp((void*)(&@struct), (void*)(&<Module>.struct98_2), 15U) == null)
					{
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 8 / sizeof(GStruct99)) = 0;
						<Module>.CM_Get_Parent((uint*)(&num4), *(ref gstruct + 20), 0);
						<Module>.smethod_120((int)num, num4);
					}
					if (<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_12)) != null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_13)) != null)
					{
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 8 / sizeof(GStruct99)) = 4;
						<Module>.CM_Get_Parent((uint*)(&num4), *(ref gstruct + 20), 0);
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 316 / sizeof(GStruct99)) = (int)num4;
					}
					if (<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_14)) != null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_15)) != null)
					{
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 8 / sizeof(GStruct99)) = 4;
						<Module>.CM_Get_Parent((uint*)(&num4), *(ref gstruct + 20), 0);
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 316 / sizeof(GStruct99)) = (int)num4;
					}
					if (<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_16)) != null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_17)) != null)
					{
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 8 / sizeof(GStruct99)) = 7;
						<Module>.CM_Get_Parent((uint*)(&num4), *(ref gstruct + 20), 0);
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 316 / sizeof(GStruct99)) = (int)num4;
					}
					if (<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_18)) != null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_19)) != null)
					{
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 8 / sizeof(GStruct99)) = 6;
						<Module>.CM_Get_Parent((uint*)(&num4), *(ref gstruct + 20), 0);
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 316 / sizeof(GStruct99)) = (int)num4;
					}
					if (<Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_20)) != null && <Module>.strstr((sbyte*)(&@struct), (sbyte*)(&<Module>.struct24_21)) != null)
					{
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 8 / sizeof(GStruct99)) = 9;
						<Module>.CM_Get_Parent((uint*)(&num4), *(ref gstruct + 20), 0);
						*(int*)(pGstruct99_0 + int_43 * 324 / sizeof(GStruct99) + 316 / sizeof(GStruct99)) = (int)num4;
					}
					int_43++;
				}
				num += 1U;
			}
			<Module>.SetupDiDestroyDeviceInfoList(ptr);
			result = int_43;
		}
		return result;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00157574 File Offset: 0x00157574
	public unsafe static int smethod_119(int int_43, uint uint_2)
	{
		void* ptr = <Module>.SetupDiGetClassDevsA((GStruct0*)(&<Module>.gstruct0_3), null, null, 2);
		int result;
		if (ptr == -1)
		{
			result = 1;
		}
		else
		{
			GStruct87 gstruct = 28;
			uint num = 0U;
			while (<Module>.SetupDiEnumDeviceInfo(ptr, num, &gstruct) != null)
			{
				GStruct88 gstruct2 = 287;
				uint num2 = 0U;
				uint num3 = 0U;
				if (<Module>.SetupDiGetDeviceInfoListDetailA(ptr, &gstruct2) == null && <Module>.CM_Get_DevNode_Status_Ex((uint*)(&num2), (uint*)(&num3), *(ref gstruct + 20), 0, null) != null)
				{
					return 2;
				}
				if (*(ref gstruct + 20) != uint_2)
				{
					num += 1U;
				}
				else
				{
					Struct27 @struct;
					<Module>.memset((void*)(&@struct), 0, 1024U);
					<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 13, null, (byte*)(&@struct), 1024, null);
					if (<Module>.memcmp((void*)(&@struct), (void*)(&<Module>.struct15_9), 12U) == null)
					{
						*(ref <Module>.struct122_0 + int_43 * 324 + 8) = 2;
						break;
					}
					if (<Module>.memcmp((void*)(&@struct), (void*)(&<Module>.struct15_10), 12U) == null)
					{
						*(ref <Module>.struct122_0 + int_43 * 324 + 8) = 3;
						break;
					}
					*(ref <Module>.struct122_0 + int_43 * 324 + 8) = 0;
					break;
				}
			}
			<Module>.SetupDiDestroyDeviceInfoList(ptr);
			result = 0;
		}
		return result;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00157674 File Offset: 0x00157674
	public unsafe static int smethod_120(int int_43, uint uint_2)
	{
		void* ptr = <Module>.SetupDiGetClassDevsA((GStruct0*)(&<Module>.gstruct0_3), null, null, 2);
		int result;
		if (ptr == -1)
		{
			result = 1;
		}
		else
		{
			GStruct87 gstruct = 28;
			uint num = 0U;
			while (<Module>.SetupDiEnumDeviceInfo(ptr, num, &gstruct) != null)
			{
				GStruct88 gstruct2 = 287;
				uint num2 = 0U;
				uint num3 = 0U;
				if (<Module>.SetupDiGetDeviceInfoListDetailA(ptr, &gstruct2) == null && <Module>.CM_Get_DevNode_Status_Ex((uint*)(&num2), (uint*)(&num3), *(ref gstruct + 20), 0, null) != null)
				{
					return 2;
				}
				if (*(ref gstruct + 20) == uint_2)
				{
					<Module>.SetupDiGetDeviceRegistryPropertyA(ptr, &gstruct, 9, null, ref <Module>.struct122_0 + int_43 * 324 + 73, 1024, null);
					break;
				}
				num += 1U;
			}
			<Module>.SetupDiDestroyDeviceInfoList(ptr);
			result = 0;
		}
		return result;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00157714 File Offset: 0x00157714
	public unsafe static int smethod_121()
	{
		uint uint_;
		return (<Module>.CM_Locate_DevNodeA((uint*)(&uint_), null, 0) == null) ? ((<Module>.CM_Reenumerate_DevNode(uint_, 0) == null) ? 0 : 1) : 1;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00157740 File Offset: 0x00157740
	public unsafe static int smethod_122(byte* pByte_0)
	{
		sbyte b = (sbyte)(*pByte_0);
		b &= -33;
		int result;
		if (b >= 65 && b <= 90)
		{
			Struct79 @struct = <Module>.struct25_13;
			@struct = b;
			Struct70 struct2 = <Module>.struct18_16;
			struct2 = b;
			Struct109 struct3;
			cpblk(ref struct3, ref <Module>.struct10_26, 7);
			*(ref struct3 + 4) = (byte)b;
			int num = -1;
			void* ptr = <Module>.CreateFileA((sbyte*)(&struct3), 0, 3, null, 3, 0, null);
			if (ptr == -1)
			{
				result = 1;
			}
			else
			{
				uint num2 = 0U;
				GStruct107 gstruct;
				int num3 = <Module>.DeviceIoControl(ptr, 2953344, null, 0, (void*)(&gstruct), 12, (uint*)(&num2), null);
				if (num3 != 0)
				{
					num = *(ref gstruct + 4);
				}
				<Module>.CloseHandle(ptr);
				if (num == -1)
				{
					result = 1;
				}
				else
				{
					uint driveTypeA = <Module>.GetDriveTypeA((sbyte*)(&@struct));
					Struct68 struct4;
					if (<Module>.QueryDosDeviceA((sbyte*)(&struct2), (sbyte*)(&struct4), 260) == null)
					{
						result = 1;
					}
					else
					{
						uint num4 = <Module>.smethod_123(num, driveTypeA, (sbyte*)(&struct4));
						if (num4 == 0U)
						{
							result = 1;
						}
						else
						{
							int num5 = 0;
							Struct127 struct5 = 0;
							bool flag = false;
							uint num6 = 0U;
							num3 = <Module>.CM_Get_Parent((uint*)(&num6), num4, 0);
							for (int i = 1; i <= 3; i++)
							{
								struct5 = 0;
								int num7;
								if (<Module>.CM_Query_And_Remove_SubTreeW(num4, &num5, (ushort*)(&struct5), 260, 2) == null && num5 == 0)
								{
									num7 = 1;
								}
								else
								{
									num7 = 0;
								}
								if (flag = (num7 != 0))
								{
									break;
								}
								<Module>.Sleep(500);
							}
							result = ((!flag) ? 1 : 0);
						}
					}
				}
			}
		}
		else
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0015787C File Offset: 0x0015787C
	public unsafe static uint smethod_123(int int_43, uint uint_2, sbyte* pSbyte_0)
	{
		bool flag = <Module>.strstr((sbyte*)pSbyte_0, (sbyte*)(&<Module>.struct22_6)) != 0;
		GStruct0* pGstruct0_;
		if (uint_2 != 2U)
		{
			if (uint_2 == 3U)
			{
				return 0;
			}
			if (uint_2 != 5U)
			{
				return 0;
			}
			pGstruct0_ = &<Module>.gstruct0_5;
		}
		else
		{
			if (flag)
			{
				return 0;
			}
			pGstruct0_ = &<Module>.gstruct0_7;
		}
		void* ptr = <Module>.SetupDiGetClassDevsA((GStruct0*)pGstruct0_, null, null, 18);
		uint result;
		if (ptr == -1)
		{
			result = 0;
		}
		else
		{
			uint num = 0U;
			GStruct108 gstruct = 28;
			while (<Module>.SetupDiEnumDeviceInterfaces(ptr, null, (GStruct0*)pGstruct0_, num, &gstruct) != null)
			{
				uint num2 = 0U;
				<Module>.SetupDiGetDeviceInterfaceDetailA(ptr, &gstruct, null, 0, (uint*)(&num2), null);
				if (num2 != 0U && num2 <= 1024U)
				{
					Struct126 @struct = 5;
					GStruct87 gstruct2;
					<Module>.memset((void*)(&gstruct2), 0, 28U);
					gstruct2 = 28;
					int num3 = <Module>.SetupDiGetDeviceInterfaceDetailA(ptr, &gstruct, (GStruct109*)(&@struct), num2, (uint*)(&num2), &gstruct2);
					if (num3 != 0)
					{
						void* ptr2 = <Module>.CreateFileA(ref @struct + 4, 0, 3, null, 3, 0, null);
						if (ptr2 != -1)
						{
							uint num4 = 0U;
							GStruct107 gstruct3;
							num3 = <Module>.DeviceIoControl(ptr2, 2953344, null, 0, (void*)(&gstruct3), 12, (uint*)(&num4), null);
							if (num3 != 0 && int_43 == *(ref gstruct3 + 4))
							{
								<Module>.CloseHandle(ptr2);
								<Module>.SetupDiDestroyDeviceInfoList(ptr);
								return *(ref gstruct2 + 20);
							}
							<Module>.CloseHandle(ptr2);
						}
					}
				}
				num += 1U;
			}
			<Module>.SetupDiDestroyDeviceInfoList(ptr);
			result = 0;
		}
		return result;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x003500D4 File Offset: 0x002980D4
	public unsafe static int smethod_124(byte* pByte_0)
	{
		sbyte b = (sbyte)(*pByte_0);
		b &= -33;
		int result;
		if (b >= 65 && b <= 90)
		{
			Struct79 @struct = <Module>.struct25_14;
			@struct = b;
			Struct70 struct2 = <Module>.struct18_17;
			struct2 = b;
			Struct109 struct3;
			cpblk(ref struct3, ref <Module>.struct10_27, 7);
			*(ref struct3 + 4) = (byte)b;
			int num = -1;
			void* ptr = <Module>.CreateFileA((sbyte*)(&struct3), 0, 3, null, 3, 0, null);
			if (ptr == -1)
			{
				result = 1;
			}
			else
			{
				uint num2 = 0U;
				GStruct107 gstruct;
				int num3 = <Module>.DeviceIoControl(ptr, 2953344, null, 0, (void*)(&gstruct), 12, (uint*)(&num2), null);
				if (num3 != 0)
				{
					num = *(ref gstruct + 4);
				}
				<Module>.CloseHandle(ptr);
				if (num == -1)
				{
					result = 1;
				}
				else
				{
					uint driveTypeA = <Module>.GetDriveTypeA((sbyte*)(&@struct));
					Struct68 struct4;
					if (<Module>.QueryDosDeviceA((sbyte*)(&struct2), (sbyte*)(&struct4), 260) == null)
					{
						result = 1;
					}
					else
					{
						uint num4 = <Module>.smethod_123(num, driveTypeA, (sbyte*)(&struct4));
						if (num4 == 0U)
						{
							result = 1;
						}
						else
						{
							void* ptr2 = <Module>.SetupDiGetClassDevsA((GStruct0*)(&<Module>.gstruct0_4), null, null, 2);
							if (ptr2 == -1)
							{
								result = 1;
							}
							else
							{
								GStruct87 gstruct2 = 28;
								uint num5 = 0U;
								while (<Module>.SetupDiEnumDeviceInfo(ptr2, num5, &gstruct2) != null)
								{
									if (*(ref gstruct2 + 20) == (int)num4)
									{
										GStruct110 gstruct3 = 0;
										initblk(ref gstruct3 + 4, 0, 16);
										gstruct3 = 8;
										*(ref gstruct3 + 4) = 18;
										*(ref gstruct3 + 12) = 1;
										*(ref gstruct3 + 8) = 2;
										if (<Module>.SetupDiSetClassInstallParamsA(ptr2, &gstruct2, (GStruct117*)(&gstruct3), 20) == null)
										{
											return 2;
										}
										if (<Module>.SetupDiCallClassInstaller(18U, ptr2, &gstruct2) == null)
										{
											return 3;
										}
									}
									num5 += 1U;
								}
								<Module>.SetupDiDestroyDeviceInfoList(ptr2);
								result = 0;
							}
						}
					}
				}
			}
		}
		else
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00157B30 File Offset: 0x00157B30
	public unsafe static int smethod_125()
	{
		void* ptr = <Module>.SetupDiGetClassDevsA((GStruct0*)(&<Module>.gstruct0_4), null, null, 2);
		int result;
		if (ptr == -1)
		{
			result = 1;
		}
		else
		{
			GStruct87 gstruct = 28;
			uint num = 0U;
			while (<Module>.SetupDiEnumDeviceInfo(ptr, num, &gstruct) != null)
			{
				GStruct110 gstruct2 = 0;
				initblk(ref gstruct2 + 4, 0, 16);
				gstruct2 = 8;
				*(ref gstruct2 + 4) = 18;
				*(ref gstruct2 + 12) = 1;
				*(ref gstruct2 + 8) = 1;
				if (<Module>.SetupDiSetClassInstallParamsA(ptr, &gstruct, (GStruct117*)(&gstruct2), 20) == null)
				{
					return 2;
				}
				if (<Module>.SetupDiCallClassInstaller(18U, ptr, &gstruct) == null)
				{
					return 3;
				}
				num += 1U;
			}
			<Module>.SetupDiDestroyDeviceInfoList(ptr);
			result = 0;
		}
		return result;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00157BBC File Offset: 0x00157BBC
	public unsafe static int smethod_126(byte byte_0)
	{
		void* ptr = <Module>.SetupDiGetClassDevsA((GStruct0*)(&<Module>.gstruct0_4), null, null, 2);
		int result;
		if (ptr == -1)
		{
			result = 1;
		}
		else
		{
			GStruct87 gstruct = 28;
			uint num = 0U;
			while (<Module>.SetupDiEnumDeviceInfo(ptr, num, &gstruct) != null)
			{
				GStruct110 gstruct2 = 0;
				initblk(ref gstruct2 + 4, 0, 16);
				gstruct2 = 8;
				*(ref gstruct2 + 4) = 18;
				*(ref gstruct2 + 12) = 1;
				if (byte_0 == 1)
				{
					*(ref gstruct2 + 8) = 1;
				}
				else if (byte_0 == 0)
				{
					*(ref gstruct2 + 8) = 2;
				}
				if (<Module>.SetupDiSetClassInstallParamsA(ptr, &gstruct, (GStruct117*)(&gstruct2), 20) == null)
				{
					return 2;
				}
				if (<Module>.SetupDiCallClassInstaller(18U, ptr, &gstruct) == null)
				{
					return 3;
				}
				num += 1U;
			}
			<Module>.SetupDiDestroyDeviceInfoList(ptr);
			result = 0;
		}
		return result;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00157C5C File Offset: 0x00157C5C
	public unsafe static ushort smethod_127(void* pVoid_0, uint uint_2, ushort ushort_0, byte byte_0, sbyte* pSbyte_0)
	{
		GStruct111 gstruct;
		uint num2;
		int num;
		if (ushort_0 == 0)
		{
			<Module>.memset((void*)(&gstruct), 0, 2060U);
			gstruct = uint_2;
			*(ref gstruct + 4) = 128;
			*(ref gstruct + 5) = 6;
			*(ref gstruct + 6) = 768;
			*(ref gstruct + 10) = 4;
			num = <Module>.DeviceIoControl(pVoid_0, 2229264, (void*)(&gstruct), 2060, (void*)(&gstruct), 2060, (uint*)(&num2), null);
			ushort_0 = (ushort)((int)(*(ref gstruct + 14)) + ((int)(*(ref gstruct + 15)) << 8));
			if (num == 0)
			{
				return 65535;
			}
		}
		<Module>.memset((void*)(&gstruct), 0, 2060U);
		gstruct = uint_2;
		*(ref gstruct + 4) = 128;
		*(ref gstruct + 5) = 6;
		*(ref gstruct + 6) = ((short)byte_0 | 768);
		*(ref gstruct + 8) = (short)(ushort_0 & ushort.MaxValue);
		*(ref gstruct + 10) = 255;
		num = <Module>.DeviceIoControl(pVoid_0, 2229264, (void*)(&gstruct), 2060, (void*)(&gstruct), 2060, (uint*)(&num2), null);
		<Module>.sprintf(pSbyte_0, (sbyte*)(&<Module>.struct25_15), ref gstruct + 12 + 2);
		return ushort_0;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00157D54 File Offset: 0x00157D54
	public unsafe static ushort smethod_128(void* pVoid_0, uint uint_2, ushort ushort_0, byte* pByte_0, int int_43)
	{
		pByte_0 += 14;
		if (*pByte_0 != 0)
		{
			ushort_0 = <Module>.smethod_127(pVoid_0, uint_2, ushort_0, *pByte_0, ref <Module>.struct122_0 + int_43 * 324 + 133);
		}
		ushort result;
		if (ushort_0 == 65535)
		{
			result = ushort_0;
		}
		else
		{
			pByte_0++;
			if (*pByte_0 != 0)
			{
				ushort_0 = <Module>.smethod_127(pVoid_0, uint_2, ushort_0, *pByte_0, ref <Module>.struct122_0 + int_43 * 324 + 193);
			}
			pByte_0++;
			if (*pByte_0 != 0)
			{
				ushort_0 = <Module>.smethod_127(pVoid_0, uint_2, ushort_0, *pByte_0, ref <Module>.struct122_0 + int_43 * 324 + 253);
			}
			result = ushort_0;
		}
		return result;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00157DEC File Offset: 0x00157DEC
	public unsafe static void smethod_129(void* pVoid_0, byte byte_0, int int_43)
	{
		int int_44 = 0;
		Struct128 @struct;
		cpblk(ref @struct, ref <Module>.struct35_135, 5);
		initblk(ref @struct + 5, 0, 251);
		for (uint num = 1U; num < (uint)(byte_0 + 1); num += 1U)
		{
			ushort ushort_ = 0;
			GStruct115 gstruct = num;
			uint num2;
			<Module>.DeviceIoControl(pVoid_0, 2229260, (void*)(&gstruct), 387, (void*)(&gstruct), 387, (uint*)(&num2), null);
			byte b = (byte)(*(ref gstruct + 31));
			GStruct114 gstruct2 = num;
			<Module>.DeviceIoControl(pVoid_0, 2229280, (void*)(&gstruct2), 520, (void*)(&gstruct2), 520, (uint*)(&num2), null);
			Struct27 struct2;
			<Module>.WideCharToMultiByte(0U, 0, ref gstruct2 + 8, *(ref gstruct2 + 4) / 2, (sbyte*)(&struct2), 252, null, null);
			<Module>.strlen((sbyte*)(&struct2));
			if (b == 1)
			{
				if (*(ref gstruct + 24) == 0)
				{
					for (int i = 0; i < 20; i++)
					{
						if (<Module>.memcmp((void*)(&struct2), ref <Module>.struct122_0 + i * 324 + 73, 43U) == null)
						{
							int_44 = i;
							*(ref <Module>.struct122_0 + i * 324 + 320) = (int)num;
							break;
						}
						int_44 = 20;
					}
					ushort_ = <Module>.smethod_128(pVoid_0, num, ushort_, ref gstruct + 4, int_44);
				}
				else
				{
					GStruct112 gstruct3 = num;
					<Module>.DeviceIoControl(pVoid_0, 2229268, (void*)(&gstruct3), 520, (void*)(&gstruct3), 520, (uint*)(&num2), null);
					<Module>.WideCharToMultiByte(0U, 0, ref gstruct3 + 8, *(ref gstruct3 + 4) / 2, ref @struct + 4, 252, null, null);
					void* pVoid_ = <Module>.CreateFileA((sbyte*)(&@struct), 1073741824, 2, &<Module>.gstruct100_0, 3, 0, null);
					GStruct113 gstruct4;
					<Module>.DeviceIoControl(pVoid_, 2229256, (void*)(&gstruct4), 76, (void*)(&gstruct4), 76, (uint*)(&num2), null);
					<Module>.smethod_129(pVoid_, *(ref gstruct4 + 6), int_43 + 1);
					<Module>.CloseHandle(pVoid_);
				}
			}
		}
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00157F98 File Offset: 0x00157F98
	public unsafe static uint smethod_130(void* pVoid_0)
	{
		Struct128 @struct;
		cpblk(ref @struct, ref <Module>.struct35_136, 5);
		initblk(ref @struct + 5, 0, 251);
		GStruct116 gstruct;
		uint num;
		uint result;
		if (<Module>.DeviceIoControl(pVoid_0, 2229284, (void*)(&gstruct), 516, (void*)(&gstruct), 516, (uint*)(&num), null) == null)
		{
			result = <Module>.GetLastError();
		}
		else
		{
			int num2 = <Module>.DeviceIoControl(pVoid_0, 2229256, (void*)(&gstruct), 516, (void*)(&gstruct), 516, (uint*)(&num), null);
			<Module>.WideCharToMultiByte(0U, 0, ref gstruct + 4, gstruct / 2, ref @struct + 4, 252, null, null);
			void* ptr = <Module>.CreateFileA((sbyte*)(&@struct), 1073741824, 2, &<Module>.gstruct100_0, 3, 0, null);
			GStruct113 gstruct2;
			if (ptr == -1)
			{
				result = <Module>.GetLastError();
			}
			else if (<Module>.DeviceIoControl(ptr, 2229256, (void*)(&gstruct2), 76, (void*)(&gstruct2), 76, (uint*)(&num), null) == null)
			{
				result = <Module>.GetLastError();
			}
			else
			{
				<Module>.smethod_129(ptr, *(ref gstruct2 + 6), 0);
				<Module>.CloseHandle(ptr);
				result = 0;
			}
		}
		return result;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00158078 File Offset: 0x00158078
	public unsafe static int smethod_131()
	{
		Struct129 @struct;
		cpblk(ref @struct, ref <Module>.struct24_22, 9);
		uint num = 0U;
		<Module>.gstruct100_0 = 12;
		*(ref <Module>.gstruct100_0 + 4) = 0;
		*(ref <Module>.gstruct100_0 + 8) = 0;
		for (int i = 0; i < 10; i++)
		{
			*(ref @struct + 7) = (byte)(i + 48);
			void* ptr = <Module>.CreateFileA((sbyte*)(&@struct), 1073741824, 2, &<Module>.gstruct100_0, 3, 0, null);
			if (ptr != -1 & num == 0U)
			{
				num = <Module>.smethod_130(ptr);
				<Module>.CloseHandle(ptr);
			}
		}
		return num;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x001580FC File Offset: 0x001580FC
	public unsafe static int smethod_132(void* pVoid_0, int int_43)
	{
		uint num;
		return <Module>.DeviceIoControl(pVoid_0, 2236496, (void*)(&int_43), 1, null, 0, (uint*)(&num), null);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00158120 File Offset: 0x00158120
	public unsafe static int smethod_133(void* pVoid_0, byte* pByte_0)
	{
		uint num;
		return <Module>.DeviceIoControl(pVoid_0, 2236512, null, 0, (void*)pByte_0, 1, (uint*)(&num), null);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00158144 File Offset: 0x00158144
	public unsafe static int smethod_134(void* pVoid_0, byte byte_0)
	{
		uint num;
		return <Module>.DeviceIoControl(pVoid_0, 2236504, (void*)(&byte_0), 1, null, 0, (uint*)(&num), null);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00158168 File Offset: 0x00158168
	public unsafe static int smethod_135(void* pVoid_0, int int_43)
	{
		uint num;
		return <Module>.DeviceIoControl(pVoid_0, 2236500, (void*)(&int_43), 1, null, 0, (uint*)(&num), null);
	}

	// Token: 0x06000089 RID: 137 RVA: 0x0015818C File Offset: 0x0015818C
	public unsafe static int smethod_136(void* pVoid_0, byte* pByte_0)
	{
		uint num;
		return <Module>.DeviceIoControl(pVoid_0, 2236516, null, 0, (void*)pByte_0, 1, (uint*)(&num), null);
	}

	// Token: 0x0600008A RID: 138 RVA: 0x001581B0 File Offset: 0x001581B0
	public unsafe static int smethod_137(void* pVoid_0, byte byte_0)
	{
		uint num;
		return <Module>.DeviceIoControl(pVoid_0, 2236508, (void*)(&byte_0), 1, null, 0, (uint*)(&num), null);
	}

	// Token: 0x0600008B RID: 139 RVA: 0x001581D4 File Offset: 0x001581D4
	public unsafe static int smethod_138(void* pVoid_0, byte byte_0)
	{
		Struct130 @struct = 0;
		*(ref @struct + 2) = 0;
		@struct = 13;
		*(ref @struct + 2) = (short)((ushort)byte_0);
		uint num;
		return <Module>.DeviceIoControl(pVoid_0, 2236428, (void*)(&@struct), 4, null, 0, (uint*)(&num), null);
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00158210 File Offset: 0x00158210
	public unsafe static int smethod_139(void* pVoid_0, byte* pByte_0)
	{
		Struct130 @struct = 0;
		*(ref @struct + 2) = 0;
		@struct = 141;
		uint num2;
		int num = <Module>.DeviceIoControl(pVoid_0, 2236568, (void*)(&@struct), 4, (void*)(&@struct), 4, (uint*)(&num2), null);
		if (num != 0)
		{
			*pByte_0 = @struct;
		}
		return num;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00158250 File Offset: 0x00158250
	public unsafe static int smethod_140(void* pVoid_0, ushort* pUshort_0)
	{
		ushort num2;
		uint num3;
		int num = <Module>.DeviceIoControl(pVoid_0, 2236560, null, 0, (void*)(&num2), 2, (uint*)(&num3), null);
		if (num != 0)
		{
			*pUshort_0 = num2;
		}
		return num;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x0015827C File Offset: 0x0015827C
	public unsafe static int smethod_141(void* pVoid_0, ushort ushort_0)
	{
		ushort num = ushort_0;
		uint num2;
		return <Module>.DeviceIoControl(pVoid_0, 2236556, (void*)(&num), 2, null, 0, (uint*)(&num2), null);
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00158428 File Offset: 0x00158428
	public unsafe static int smethod_142(uint* pUint_0, byte* pByte_0, int int_43)
	{
		int num = 0;
		*pUint_0 = ((<Module>._lrotl(*(int*)pByte_0, 8) & 16711935) | (<Module>._lrotr(*(int*)pByte_0, 8) & -16711936));
		pUint_0[1] = ((<Module>._lrotl(*(int*)(pByte_0 + 4 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 4 / sizeof(byte)), 8) & -16711936));
		pUint_0[2] = ((<Module>._lrotl(*(int*)(pByte_0 + 8 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 8 / sizeof(byte)), 8) & -16711936));
		pUint_0[3] = ((<Module>._lrotl(*(int*)(pByte_0 + 12 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 12 / sizeof(byte)), 8) & -16711936));
		int result;
		if (int_43 == 128)
		{
			for (;;)
			{
				uint num2 = pUint_0[3];
				pUint_0[4] = (*pUint_0 ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 16 & 255U) * 4U) & -16777216) ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 8 & 255U) * 4U) & 16711680) ^ (uint)(*(ref <Module>.struct131_2 + (num2 & 255U) * 4U) & 65280) ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 24) * 4U) & 255) ^ (uint)(*(ref <Module>.struct132_0 + num * 4)));
				pUint_0[5] = (pUint_0[1] ^ pUint_0[4]);
				pUint_0[6] = (pUint_0[2] ^ pUint_0[5]);
				pUint_0[7] = (pUint_0[3] ^ pUint_0[6]);
				num++;
				if (num == 10)
				{
					break;
				}
				pUint_0 += 4;
			}
			result = 10;
		}
		else
		{
			pUint_0[4] = ((<Module>._lrotl(*(int*)(pByte_0 + 16 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 16 / sizeof(byte)), 8) & -16711936));
			pUint_0[5] = ((<Module>._lrotl(*(int*)(pByte_0 + 20 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 20 / sizeof(byte)), 8) & -16711936));
			if (int_43 == 192)
			{
				for (;;)
				{
					uint num2 = pUint_0[5];
					pUint_0[6] = (*pUint_0 ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 16 & 255U) * 4U) & -16777216) ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 8 & 255U) * 4U) & 16711680) ^ (uint)(*(ref <Module>.struct131_2 + (num2 & 255U) * 4U) & 65280) ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 24) * 4U) & 255) ^ (uint)(*(ref <Module>.struct132_0 + num * 4)));
					pUint_0[7] = (pUint_0[1] ^ pUint_0[6]);
					pUint_0[8] = (pUint_0[2] ^ pUint_0[7]);
					pUint_0[9] = (pUint_0[3] ^ pUint_0[8]);
					num++;
					if (num == 8)
					{
						break;
					}
					pUint_0[10] = (pUint_0[4] ^ pUint_0[9]);
					pUint_0[11] = (pUint_0[5] ^ pUint_0[10]);
					pUint_0 += 6;
				}
				result = 12;
			}
			else
			{
				pUint_0[6] = ((<Module>._lrotl(*(int*)(pByte_0 + 24 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 24 / sizeof(byte)), 8) & -16711936));
				pUint_0[7] = ((<Module>._lrotl(*(int*)(pByte_0 + 28 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 28 / sizeof(byte)), 8) & -16711936));
				if (int_43 == 256)
				{
					for (;;)
					{
						uint num2 = pUint_0[7];
						pUint_0[8] = (*pUint_0 ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 16 & 255U) * 4U) & -16777216) ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 8 & 255U) * 4U) & 16711680) ^ (uint)(*(ref <Module>.struct131_2 + (num2 & 255U) * 4U) & 65280) ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 24) * 4U) & 255) ^ (uint)(*(ref <Module>.struct132_0 + num * 4)));
						pUint_0[9] = (pUint_0[1] ^ pUint_0[8]);
						pUint_0[10] = (pUint_0[2] ^ pUint_0[9]);
						pUint_0[11] = (pUint_0[3] ^ pUint_0[10]);
						num++;
						if (num == 7)
						{
							break;
						}
						num2 = pUint_0[11];
						pUint_0[12] = (pUint_0[4] ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 24) * 4U) & -16777216) ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 16 & 255U) * 4U) & 16711680) ^ (uint)(*(ref <Module>.struct131_2 + (num2 >> 8 & 255U) * 4U) & 65280) ^ (uint)(*(ref <Module>.struct131_2 + (num2 & 255U) * 4U) & 255));
						pUint_0[13] = (pUint_0[5] ^ pUint_0[12]);
						pUint_0[14] = (pUint_0[6] ^ pUint_0[13]);
						pUint_0[15] = (pUint_0[7] ^ pUint_0[14]);
						pUint_0 += 8;
					}
					result = 14;
				}
				else
				{
					result = 0;
				}
			}
		}
		return result;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00158888 File Offset: 0x00158888
	public unsafe static int smethod_143(uint* pUint_0, byte* pByte_0, int int_43)
	{
		int num = <Module>.smethod_142(pUint_0, pByte_0, int_43);
		int i = 0;
		int num2 = num * 4;
		while (i < num2)
		{
			uint num3 = pUint_0[i];
			pUint_0[i] = pUint_0[num2];
			pUint_0[num2] = num3;
			num3 = pUint_0[i + 1];
			pUint_0[i + 1] = pUint_0[num2 + 1];
			pUint_0[num2 + 1] = num3;
			num3 = pUint_0[i + 2];
			pUint_0[i + 2] = pUint_0[num2 + 2];
			pUint_0[num2 + 2] = num3;
			num3 = pUint_0[i + 3];
			pUint_0[i + 3] = pUint_0[num2 + 3];
			pUint_0[num2 + 3] = num3;
			i += 4;
			num2 -= 4;
		}
		for (i = 1; i < num; i++)
		{
			pUint_0 += 4;
			*pUint_0 = (uint)(*(ref <Module>.struct131_6 + (*(ref <Module>.struct131_2 + (*pUint_0 >> 24) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_4 + (*(ref <Module>.struct131_2 + (*pUint_0 >> 16 & 255U) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_7 + (*(ref <Module>.struct131_2 + (*pUint_0 >> 8 & 255U) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_5 + (*(ref <Module>.struct131_2 + (*pUint_0 & 255U) * 4U) & 255) * 4));
			pUint_0[1] = (uint)(*(ref <Module>.struct131_6 + (*(ref <Module>.struct131_2 + (pUint_0[1] >> 24) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_4 + (*(ref <Module>.struct131_2 + (pUint_0[1] >> 16 & 255U) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_7 + (*(ref <Module>.struct131_2 + (pUint_0[1] >> 8 & 255U) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_5 + (*(ref <Module>.struct131_2 + (pUint_0[1] & 255U) * 4U) & 255) * 4));
			pUint_0[2] = (uint)(*(ref <Module>.struct131_6 + (*(ref <Module>.struct131_2 + (pUint_0[2] >> 24) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_4 + (*(ref <Module>.struct131_2 + (pUint_0[2] >> 16 & 255U) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_7 + (*(ref <Module>.struct131_2 + (pUint_0[2] >> 8 & 255U) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_5 + (*(ref <Module>.struct131_2 + (pUint_0[2] & 255U) * 4U) & 255) * 4));
			pUint_0[3] = (uint)(*(ref <Module>.struct131_6 + (*(ref <Module>.struct131_2 + (pUint_0[3] >> 24) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_4 + (*(ref <Module>.struct131_2 + (pUint_0[3] >> 16 & 255U) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_7 + (*(ref <Module>.struct131_2 + (pUint_0[3] >> 8 & 255U) * 4U) & 255) * 4) ^ *(ref <Module>.struct131_5 + (*(ref <Module>.struct131_2 + (pUint_0[3] & 255U) * 4U) & 255) * 4));
		}
		return num;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00158B98 File Offset: 0x00158B98
	public unsafe static void smethod_144(uint* pUint_0, int int_43, byte* pByte_0, byte* pByte_1)
	{
		uint num = ((<Module>._lrotl(*(int*)pByte_0, 8) & 16711935) | (<Module>._lrotr(*(int*)pByte_0, 8) & -16711936)) ^ *(int*)pUint_0;
		uint num2 = ((<Module>._lrotl(*(int*)(pByte_0 + 4 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 4 / sizeof(byte)), 8) & -16711936)) ^ *(int*)(pUint_0 + 4 / sizeof(uint));
		uint num3 = ((<Module>._lrotl(*(int*)(pByte_0 + 8 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 8 / sizeof(byte)), 8) & -16711936)) ^ *(int*)(pUint_0 + 8 / sizeof(uint));
		uint num4 = ((<Module>._lrotl(*(int*)(pByte_0 + 12 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 12 / sizeof(byte)), 8) & -16711936)) ^ *(int*)(pUint_0 + 12 / sizeof(uint));
		int num5 = int_43 >> 1;
		uint num6;
		uint num7;
		uint num8;
		uint num9;
		for (;;)
		{
			num6 = (uint)(*(ref <Module>.struct131_1 + (num >> 24) * 4U) ^ *(ref <Module>.struct131_0 + (num2 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_3 + (num3 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_9 + (num4 & 255U) * 4U) ^ *(int*)(pUint_0 + 16 / sizeof(uint)));
			num7 = (uint)(*(ref <Module>.struct131_1 + (num2 >> 24) * 4U) ^ *(ref <Module>.struct131_0 + (num3 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_3 + (num4 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_9 + (num & 255U) * 4U) ^ *(int*)(pUint_0 + 20 / sizeof(uint)));
			num8 = (uint)(*(ref <Module>.struct131_1 + (num3 >> 24) * 4U) ^ *(ref <Module>.struct131_0 + (num4 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_3 + (num >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_9 + (num2 & 255U) * 4U) ^ *(int*)(pUint_0 + 24 / sizeof(uint)));
			num9 = (uint)(*(ref <Module>.struct131_1 + (num4 >> 24) * 4U) ^ *(ref <Module>.struct131_0 + (num >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_3 + (num2 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_9 + (num3 & 255U) * 4U) ^ *(int*)(pUint_0 + 28 / sizeof(uint)));
			pUint_0 += 32 / sizeof(uint);
			num5--;
			if (num5 == 0)
			{
				break;
			}
			num = (uint)(*(ref <Module>.struct131_1 + (num6 >> 24) * 4U) ^ *(ref <Module>.struct131_0 + (num7 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_3 + (num8 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_9 + (num9 & 255U) * 4U) ^ *(int*)pUint_0);
			num2 = (uint)(*(ref <Module>.struct131_1 + (num7 >> 24) * 4U) ^ *(ref <Module>.struct131_0 + (num8 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_3 + (num9 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_9 + (num6 & 255U) * 4U) ^ *(int*)(pUint_0 + 4 / sizeof(uint)));
			num3 = (uint)(*(ref <Module>.struct131_1 + (num8 >> 24) * 4U) ^ *(ref <Module>.struct131_0 + (num9 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_3 + (num6 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_9 + (num7 & 255U) * 4U) ^ *(int*)(pUint_0 + 8 / sizeof(uint)));
			num4 = (uint)(*(ref <Module>.struct131_1 + (num9 >> 24) * 4U) ^ *(ref <Module>.struct131_0 + (num6 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_3 + (num7 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_9 + (num8 & 255U) * 4U) ^ *(int*)(pUint_0 + 12 / sizeof(uint)));
		}
		num = (uint)((*(ref <Module>.struct131_2 + (num6 >> 24) * 4U) & -16777216) ^ (*(ref <Module>.struct131_2 + (num7 >> 16 & 255U) * 4U) & 16711680) ^ (*(ref <Module>.struct131_2 + (num8 >> 8 & 255U) * 4U) & 65280) ^ (*(ref <Module>.struct131_2 + (num9 & 255U) * 4U) & 255) ^ *(int*)pUint_0);
		*(int*)pByte_1 = ((<Module>._lrotl(num, 8) & 16711935) | (<Module>._lrotr(num, 8) & -16711936));
		num2 = (uint)((*(ref <Module>.struct131_2 + (num7 >> 24) * 4U) & -16777216) ^ (*(ref <Module>.struct131_2 + (num8 >> 16 & 255U) * 4U) & 16711680) ^ (*(ref <Module>.struct131_2 + (num9 >> 8 & 255U) * 4U) & 65280) ^ (*(ref <Module>.struct131_2 + (num6 & 255U) * 4U) & 255) ^ *(int*)(pUint_0 + 4 / sizeof(uint)));
		*(int*)(pByte_1 + 4) = ((<Module>._lrotl(num2, 8) & 16711935) | (<Module>._lrotr(num2, 8) & -16711936));
		num3 = (uint)((*(ref <Module>.struct131_2 + (num8 >> 24) * 4U) & -16777216) ^ (*(ref <Module>.struct131_2 + (num9 >> 16 & 255U) * 4U) & 16711680) ^ (*(ref <Module>.struct131_2 + (num6 >> 8 & 255U) * 4U) & 65280) ^ (*(ref <Module>.struct131_2 + (num7 & 255U) * 4U) & 255) ^ *(int*)(pUint_0 + 8 / sizeof(uint)));
		*(int*)(pByte_1 + 8) = ((<Module>._lrotl(num3, 8) & 16711935) | (<Module>._lrotr(num3, 8) & -16711936));
		num4 = (uint)((*(ref <Module>.struct131_2 + (num9 >> 24) * 4U) & -16777216) ^ (*(ref <Module>.struct131_2 + (num6 >> 16 & 255U) * 4U) & 16711680) ^ (*(ref <Module>.struct131_2 + (num7 >> 8 & 255U) * 4U) & 65280) ^ (*(ref <Module>.struct131_2 + (num8 & 255U) * 4U) & 255) ^ *(int*)(pUint_0 + 12 / sizeof(uint)));
		*(int*)(pByte_1 + 12) = ((<Module>._lrotl(num4, 8) & 16711935) | (<Module>._lrotr(num4, 8) & -16711936));
	}

	// Token: 0x06000092 RID: 146 RVA: 0x001590E4 File Offset: 0x001590E4
	public unsafe static void smethod_145(uint* pUint_0, int int_43, byte* pByte_0, byte* pByte_1)
	{
		uint num = ((<Module>._lrotl(*(int*)pByte_0, 8) & 16711935) | (<Module>._lrotr(*(int*)pByte_0, 8) & -16711936)) ^ *(int*)pUint_0;
		uint num2 = ((<Module>._lrotl(*(int*)(pByte_0 + 4 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 4 / sizeof(byte)), 8) & -16711936)) ^ *(int*)(pUint_0 + 4 / sizeof(uint));
		uint num3 = ((<Module>._lrotl(*(int*)(pByte_0 + 8 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 8 / sizeof(byte)), 8) & -16711936)) ^ *(int*)(pUint_0 + 8 / sizeof(uint));
		uint num4 = ((<Module>._lrotl(*(int*)(pByte_0 + 12 / sizeof(byte)), 8) & 16711935) | (<Module>._lrotr(*(int*)(pByte_0 + 12 / sizeof(byte)), 8) & -16711936)) ^ *(int*)(pUint_0 + 12 / sizeof(uint));
		int num5 = int_43 >> 1;
		uint num6;
		uint num7;
		uint num8;
		uint num9;
		for (;;)
		{
			num6 = (uint)(*(ref <Module>.struct131_6 + (num >> 24) * 4U) ^ *(ref <Module>.struct131_4 + (num4 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_7 + (num3 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_5 + (num2 & 255U) * 4U) ^ *(int*)(pUint_0 + 16 / sizeof(uint)));
			num7 = (uint)(*(ref <Module>.struct131_6 + (num2 >> 24) * 4U) ^ *(ref <Module>.struct131_4 + (num >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_7 + (num4 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_5 + (num3 & 255U) * 4U) ^ *(int*)(pUint_0 + 20 / sizeof(uint)));
			num8 = (uint)(*(ref <Module>.struct131_6 + (num3 >> 24) * 4U) ^ *(ref <Module>.struct131_4 + (num2 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_7 + (num >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_5 + (num4 & 255U) * 4U) ^ *(int*)(pUint_0 + 24 / sizeof(uint)));
			num9 = (uint)(*(ref <Module>.struct131_6 + (num4 >> 24) * 4U) ^ *(ref <Module>.struct131_4 + (num3 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_7 + (num2 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_5 + (num & 255U) * 4U) ^ *(int*)(pUint_0 + 28 / sizeof(uint)));
			pUint_0 += 32 / sizeof(uint);
			num5--;
			if (num5 == 0)
			{
				break;
			}
			num = (uint)(*(ref <Module>.struct131_6 + (num6 >> 24) * 4U) ^ *(ref <Module>.struct131_4 + (num9 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_7 + (num8 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_5 + (num7 & 255U) * 4U) ^ *(int*)pUint_0);
			num2 = (uint)(*(ref <Module>.struct131_6 + (num7 >> 24) * 4U) ^ *(ref <Module>.struct131_4 + (num6 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_7 + (num9 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_5 + (num8 & 255U) * 4U) ^ *(int*)(pUint_0 + 4 / sizeof(uint)));
			num3 = (uint)(*(ref <Module>.struct131_6 + (num8 >> 24) * 4U) ^ *(ref <Module>.struct131_4 + (num7 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_7 + (num6 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_5 + (num9 & 255U) * 4U) ^ *(int*)(pUint_0 + 8 / sizeof(uint)));
			num4 = (uint)(*(ref <Module>.struct131_6 + (num9 >> 24) * 4U) ^ *(ref <Module>.struct131_4 + (num8 >> 16 & 255U) * 4U) ^ *(ref <Module>.struct131_7 + (num7 >> 8 & 255U) * 4U) ^ *(ref <Module>.struct131_5 + (num6 & 255U) * 4U) ^ *(int*)(pUint_0 + 12 / sizeof(uint)));
		}
		num = (uint)((*(ref <Module>.struct131_8 + (num6 >> 24) * 4U) & -16777216) ^ (*(ref <Module>.struct131_8 + (num9 >> 16 & 255U) * 4U) & 16711680) ^ (*(ref <Module>.struct131_8 + (num8 >> 8 & 255U) * 4U) & 65280) ^ (*(ref <Module>.struct131_8 + (num7 & 255U) * 4U) & 255) ^ *(int*)pUint_0);
		*(int*)pByte_1 = ((<Module>._lrotl(num, 8) & 16711935) | (<Module>._lrotr(num, 8) & -16711936));
		num2 = (uint)((*(ref <Module>.struct131_8 + (num7 >> 24) * 4U) & -16777216) ^ (*(ref <Module>.struct131_8 + (num6 >> 16 & 255U) * 4U) & 16711680) ^ (*(ref <Module>.struct131_8 + (num9 >> 8 & 255U) * 4U) & 65280) ^ (*(ref <Module>.struct131_8 + (num8 & 255U) * 4U) & 255) ^ *(int*)(pUint_0 + 4 / sizeof(uint)));
		*(int*)(pByte_1 + 4) = ((<Module>._lrotl(num2, 8) & 16711935) | (<Module>._lrotr(num2, 8) & -16711936));
		num3 = (uint)((*(ref <Module>.struct131_8 + (num8 >> 24) * 4U) & -16777216) ^ (*(ref <Module>.struct131_8 + (num7 >> 16 & 255U) * 4U) & 16711680) ^ (*(ref <Module>.struct131_8 + (num6 >> 8 & 255U) * 4U) & 65280) ^ (*(ref <Module>.struct131_8 + (num9 & 255U) * 4U) & 255) ^ *(int*)(pUint_0 + 8 / sizeof(uint)));
		*(int*)(pByte_1 + 8) = ((<Module>._lrotl(num3, 8) & 16711935) | (<Module>._lrotr(num3, 8) & -16711936));
		num4 = (uint)((*(ref <Module>.struct131_8 + (num9 >> 24) * 4U) & -16777216) ^ (*(ref <Module>.struct131_8 + (num8 >> 16 & 255U) * 4U) & 16711680) ^ (*(ref <Module>.struct131_8 + (num7 >> 8 & 255U) * 4U) & 65280) ^ (*(ref <Module>.struct131_8 + (num6 & 255U) * 4U) & 255) ^ *(int*)(pUint_0 + 12 / sizeof(uint)));
		*(int*)(pByte_1 + 12) = ((<Module>._lrotl(num4, 8) & 16711935) | (<Module>._lrotr(num4, 8) & -16711936));
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00159668 File Offset: 0x00159668
	public unsafe static int smethod_146(sbyte* pSbyte_0)
	{
		<Module>.memset((void*)pSbyte_0, 0, 260U);
		int result;
		if (<Module>.GetModuleFileNameA(null, pSbyte_0, 260) == null)
		{
			result = 1;
		}
		else
		{
			sbyte* ptr = <Module>.strrchr((sbyte*)pSbyte_0, 92);
			*(byte*)ptr = 0;
			result = 0;
		}
		return result;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x001596A4 File Offset: 0x001596A4
	public unsafe static int smethod_147(sbyte* pSbyte_0, sbyte* pSbyte_1)
	{
		GStruct118* ptr = <Module>.OpenSCManagerA(null, (sbyte*)(&<Module>.struct65_12), 983103);
		int result;
		if (ptr == null)
		{
			result = 1;
		}
		else
		{
			GStruct118* ptr2 = <Module>.CreateServiceA(ptr, (sbyte*)pSbyte_1, (sbyte*)pSbyte_1, 983551, 1, 3, 1, (sbyte*)pSbyte_0, null, null, null, null, null);
			<Module>.CloseServiceHandle(ptr);
			if (ptr2 == null)
			{
				result = 2;
			}
			else if (<Module>.StartServiceA(ptr2, 0, null) == null)
			{
				<Module>.CloseServiceHandle(ptr2);
				result = 3;
			}
			else
			{
				<Module>.CloseServiceHandle(ptr2);
				result = 0;
			}
		}
		return result;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0015970C File Offset: 0x0015970C
	public unsafe static int smethod_148(sbyte* pSbyte_0)
	{
		GStruct118* ptr = <Module>.OpenSCManagerA(null, (sbyte*)(&<Module>.struct65_13), 983103);
		int result;
		if (ptr == null)
		{
			result = 1;
		}
		else
		{
			GStruct118* ptr2 = <Module>.OpenServiceA(ptr, (sbyte*)pSbyte_0, 983551);
			<Module>.CloseServiceHandle(ptr);
			if (ptr2 == null)
			{
				result = 2;
			}
			else
			{
				GStruct119 gstruct;
				<Module>.ControlService(ptr2, 1, &gstruct);
				if (<Module>.DeleteService(ptr2) == null)
				{
					<Module>.CloseServiceHandle(ptr2);
					result = 3;
				}
				else
				{
					<Module>.CloseServiceHandle(ptr2);
					result = 0;
				}
			}
		}
		return result;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00159770 File Offset: 0x00159770
	public unsafe static int smethod_149(void** ppVoid_0)
	{
		*ppVoid_0 = <Module>.CreateFileA((sbyte*)(&<Module>.struct74_6), int.MinValue, 0, null, 3, 128, null);
		return (*ppVoid_0 != -1) ? 0 : 1;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x001597A4 File Offset: 0x001597A4
	public unsafe static int smethod_150(void* pVoid_0)
	{
		<Module>.CloseHandle(pVoid_0);
		return 0;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x001597BC File Offset: 0x001597BC
	public unsafe static byte smethod_151(ushort ushort_0)
	{
		byte result = 0;
		uint num;
		<Module>.DeviceIoControl(*(ref <Module>.gstruct101_0 + 4), -1673501696, (void*)(&ushort_0), 4, (void*)(&result), 1, (uint*)(&num), null);
		return result;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x001597EC File Offset: 0x001597EC
	public unsafe static ushort smethod_152(ushort ushort_0)
	{
		ushort result = 0;
		uint num;
		<Module>.DeviceIoControl(*(ref <Module>.gstruct101_0 + 4), -1673501692, (void*)(&ushort_0), 4, (void*)(&result), 2, (uint*)(&num), null);
		return result;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0015981C File Offset: 0x0015981C
	public unsafe static uint smethod_153()
	{
		uint result = 0U;
		uint num = 3324U;
		uint num2;
		<Module>.DeviceIoControl(*(ref <Module>.gstruct101_0 + 4), -1673501688, (void*)(&num), 4, (void*)(&result), 4, (uint*)(&num2), null);
		return result;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00159850 File Offset: 0x00159850
	public unsafe static void smethod_154(ushort ushort_0, byte byte_0)
	{
		GStruct120 gstruct = ushort_0;
		*(ref gstruct + 4) = (byte)((sbyte)byte_0);
		uint num;
		<Module>.DeviceIoControl(*(ref <Module>.gstruct101_0 + 4), -1673518016, (void*)(&gstruct), 5, null, 0, (uint*)(&num), null);
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00159884 File Offset: 0x00159884
	public unsafe static void smethod_155(ushort ushort_0, ushort ushort_1)
	{
		GStruct120 gstruct = ushort_0;
		*(ref gstruct + 4) = (short)ushort_1;
		uint num;
		<Module>.DeviceIoControl(*(ref <Module>.gstruct101_0 + 4), -1673518012, (void*)(&gstruct), 6, null, 0, (uint*)(&num), null);
	}

	// Token: 0x0600009D RID: 157 RVA: 0x001598B8 File Offset: 0x001598B8
	public unsafe static void smethod_156(uint uint_2)
	{
		GStruct120 gstruct = 3320;
		*(ref gstruct + 4) = (int)uint_2;
		uint num;
		<Module>.DeviceIoControl(*(ref <Module>.gstruct101_0 + 4), -1673518008, (void*)(&gstruct), 8, null, 0, (uint*)(&num), null);
	}

	// Token: 0x0600009E RID: 158 RVA: 0x001598F0 File Offset: 0x001598F0
	public static uint smethod_157()
	{
		uint result = 255U;
		for (uint num = 0U; num < 255U; num += 1U)
		{
			for (uint num2 = 0U; num2 < 31U; num2 += 1U)
			{
				for (uint num3 = 0U; num3 < 8U; num3 += 1U)
				{
					<Module>.smethod_156((((num | 4294934528U) * 32U | (uint)((ushort)num2)) * 8U | (uint)((ushort)num3)) << 8);
					uint num4 = <Module>.smethod_153();
					if ((ushort)num4 != 65535)
					{
						result = num;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00159964 File Offset: 0x00159964
	public unsafe static void smethod_158(GStruct121* pGstruct121_0, short short_0)
	{
		*(short*)pGstruct121_0 = short_0;
		*(short*)(pGstruct121_0 + 4 / sizeof(GStruct121)) = short_0 + 1;
		*(short*)(pGstruct121_0 + 2 / sizeof(GStruct121)) = short_0 + 1;
		*(short*)(pGstruct121_0 + 6 / sizeof(GStruct121)) = short_0 + 2;
		*(short*)(pGstruct121_0 + 8 / sizeof(GStruct121)) = short_0 + 3;
		*(short*)(pGstruct121_0 + 10 / sizeof(GStruct121)) = short_0 + 4;
		*(short*)(pGstruct121_0 + 12 / sizeof(GStruct121)) = short_0 + 5;
		*(short*)(pGstruct121_0 + 14 / sizeof(GStruct121)) = short_0 + 6;
		*(short*)(pGstruct121_0 + 18 / sizeof(GStruct121)) = short_0 + 7;
		*(short*)(pGstruct121_0 + 16 / sizeof(GStruct121)) = short_0 + 7;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00163AE0 File Offset: 0x00163AE0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* memcpy(void* pVoid_0, void* pVoid_1, uint uint_2);

	// Token: 0x060000A1 RID: 161 RVA: 0x001740B8 File Offset: 0x001740B8
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern uint timeGetTime();

	// Token: 0x060000A2 RID: 162 RVA: 0x0017376C File Offset: 0x0017376C
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern void Sleep(uint uint_2);

	// Token: 0x060000A3 RID: 163 RVA: 0x00162920 File Offset: 0x00162920
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* memset(void* pVoid_0, int int_43, uint uint_2);

	// Token: 0x060000A4 RID: 164 RVA: 0x001742B0 File Offset: 0x001742B0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int fprintf(GStruct5* pGstruct5_0, sbyte* pSbyte_0, __arglist);

	// Token: 0x060000A5 RID: 165 RVA: 0x0017417E File Offset: 0x0017417E
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int usb_claim_interface(void** ppVoid_0, int int_43);

	// Token: 0x060000A6 RID: 166 RVA: 0x00174184 File Offset: 0x00174184
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int usb_close(void** ppVoid_0);

	// Token: 0x060000A7 RID: 167 RVA: 0x0017418A File Offset: 0x0017418A
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int usb_set_configuration(void** ppVoid_0, int int_43);

	// Token: 0x060000A8 RID: 168 RVA: 0x00174190 File Offset: 0x00174190
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void** usb_open(GStruct9* pGstruct9_0);

	// Token: 0x060000A9 RID: 169 RVA: 0x00174196 File Offset: 0x00174196
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern void usb_set_debug(int int_43);

	// Token: 0x060000AA RID: 170 RVA: 0x0017419C File Offset: 0x0017419C
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct8* usb_get_busses();

	// Token: 0x060000AB RID: 171 RVA: 0x001741A2 File Offset: 0x001741A2
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern int usb_find_devices();

	// Token: 0x060000AC RID: 172 RVA: 0x001741A8 File Offset: 0x001741A8
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern int usb_find_busses();

	// Token: 0x060000AD RID: 173 RVA: 0x001741AE File Offset: 0x001741AE
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern void usb_init();

	// Token: 0x060000AE RID: 174 RVA: 0x001741B4 File Offset: 0x001741B4
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int usb_bulk_read(void** ppVoid_0, int int_43, sbyte* pSbyte_0, int int_44, int int_45);

	// Token: 0x060000AF RID: 175 RVA: 0x001741BA File Offset: 0x001741BA
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int usb_bulk_write(void** ppVoid_0, int int_43, sbyte* pSbyte_0, int int_44, int int_45);

	// Token: 0x060000B0 RID: 176 RVA: 0x00174244 File Offset: 0x00174244
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int CallNextHookEx(GStruct14* pGstruct14_15, int int_43, uint uint_2, int int_44);

	// Token: 0x060000B1 RID: 177 RVA: 0x0017424A File Offset: 0x0017424A
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int UnhookWindowsHookEx(GStruct14* pGstruct14_15);

	// Token: 0x060000B2 RID: 178 RVA: 0x00174250 File Offset: 0x00174250
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int MoveWindow(GStruct11* pGstruct11_0, int int_43, int int_44, int int_45, int int_46, int int_47);

	// Token: 0x060000B3 RID: 179 RVA: 0x00174256 File Offset: 0x00174256
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct11* GetDesktopWindow();

	// Token: 0x060000B4 RID: 180 RVA: 0x0017425C File Offset: 0x0017425C
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int GetWindowRect(GStruct11* pGstruct11_0, GStruct12* pGstruct12_0);

	// Token: 0x060000B5 RID: 181 RVA: 0x00174262 File Offset: 0x00174262
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct11* FindWindowA(sbyte* pSbyte_0, sbyte* pSbyte_1);

	// Token: 0x060000B6 RID: 182 RVA: 0x00175590 File Offset: 0x00175590
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void __CxxCallUnwindDtor(method fnptr_0, void* pVoid_0);

	// Token: 0x060000B7 RID: 183 RVA: 0x00173310 File Offset: 0x00173310
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void __dtor(GStruct39* pGstruct39_0);

	// Token: 0x060000B8 RID: 184 RVA: 0x001732D0 File Offset: 0x001732D0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct39* __ctor(GStruct39* pGstruct39_0, int int_43);

	// Token: 0x060000B9 RID: 185 RVA: 0x00173628 File Offset: 0x00173628
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern uint GetCurrentThreadId();

	// Token: 0x060000BA RID: 186 RVA: 0x00174268 File Offset: 0x00174268
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct14* SetWindowsHookExA(int int_43, method fnptr_0, GStruct81* pGstruct81_0, uint uint_2);

	// Token: 0x060000BB RID: 187 RVA: 0x001678D0 File Offset: 0x001678D0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int sprintf(sbyte* pSbyte_0, sbyte* pSbyte_1, __arglist);

	// Token: 0x060000BC RID: 188 RVA: 0x00179F20 File Offset: 0x00179F20
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void _Xran(GStruct84* pGstruct84_0);

	// Token: 0x060000BD RID: 189 RVA: 0x00162980 File Offset: 0x00162980
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* memmove(void* pVoid_0, void* pVoid_1, uint uint_2);

	// Token: 0x060000BE RID: 190 RVA: 0x00179C90 File Offset: 0x00179C90
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void _Xlen(GStruct84* pGstruct84_0);

	// Token: 0x060000BF RID: 191 RVA: 0x00173D60 File Offset: 0x00173D60
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void delete(void* pVoid_0);

	// Token: 0x060000C0 RID: 192 RVA: 0x001754B0 File Offset: 0x001754B0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void __CxxUnregisterExceptionObject(void* pVoid_0, int int_43);

	// Token: 0x060000C1 RID: 193 RVA: 0x00173D10 File Offset: 0x00173D10
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void _CxxThrowException(void* pVoid_0, GStruct74* pGstruct74_0);

	// Token: 0x060000C2 RID: 194 RVA: 0x00175330 File Offset: 0x00175330
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int __CxxRegisterExceptionObject(void* pVoid_0, void* pVoid_1);

	// Token: 0x060000C3 RID: 195 RVA: 0x00175580 File Offset: 0x00175580
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern int __CxxQueryExceptionSize();

	// Token: 0x060000C4 RID: 196 RVA: 0x00175450 File Offset: 0x00175450
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int __CxxDetectRethrow(void* pVoid_0);

	// Token: 0x060000C5 RID: 197 RVA: 0x00175180 File Offset: 0x00175180
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int __CxxExceptionFilter(void* pVoid_0, void* pVoid_1, int int_43, void* pVoid_2);

	// Token: 0x060000C6 RID: 198 RVA: 0x00173380 File Offset: 0x00173380
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* smethod_159(uint uint_2, GStruct72* pGstruct72_0, sbyte* pSbyte_0, int int_43);

	// Token: 0x060000C7 RID: 199 RVA: 0x0015E440 File Offset: 0x0015E440
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void free(void* pVoid_0);

	// Token: 0x060000C8 RID: 200 RVA: 0x00175680 File Offset: 0x00175680
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* @new(uint uint_2);

	// Token: 0x060000C9 RID: 201 RVA: 0x0017426E File Offset: 0x0017426E
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SendMessageA(GStruct11* pGstruct11_0, uint uint_2, uint uint_3, int int_43);

	// Token: 0x060000CA RID: 202 RVA: 0x00174274 File Offset: 0x00174274
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct11* FindWindowExA(GStruct11* pGstruct11_0, GStruct11* pGstruct11_1, sbyte* pSbyte_0, sbyte* pSbyte_1);

	// Token: 0x060000CB RID: 203 RVA: 0x00171FA0 File Offset: 0x00171FA0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int fclose(GStruct5* pGstruct5_0);

	// Token: 0x060000CC RID: 204 RVA: 0x001756A0 File Offset: 0x001756A0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int fputs(sbyte* pSbyte_0, GStruct5* pGstruct5_0);

	// Token: 0x060000CD RID: 205 RVA: 0x001758D0 File Offset: 0x001758D0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct5* fopen(sbyte* pSbyte_0, sbyte* pSbyte_1);

	// Token: 0x060000CE RID: 206 RVA: 0x001758F0 File Offset: 0x001758F0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern sbyte* asctime(GStruct85* pGstruct85_0);

	// Token: 0x060000CF RID: 207 RVA: 0x00175AF0 File Offset: 0x00175AF0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct85* localtime(int* pInt_0);

	// Token: 0x060000D0 RID: 208 RVA: 0x00175D60 File Offset: 0x00175D60
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int time(int* pInt_0);

	// Token: 0x060000D1 RID: 209 RVA: 0x00175DB0 File Offset: 0x00175DB0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern sbyte* strtok(sbyte* pSbyte_0, sbyte* pSbyte_1);

	// Token: 0x060000D2 RID: 210 RVA: 0x00175EF0 File Offset: 0x00175EF0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern sbyte* fgets(sbyte* pSbyte_0, int int_43, GStruct5* pGstruct5_0);

	// Token: 0x060000D3 RID: 211 RVA: 0x0015D8C0 File Offset: 0x0015D8C0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* malloc(uint uint_2);

	// Token: 0x060000D4 RID: 212 RVA: 0x00176060 File Offset: 0x00176060
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint fread(void* pVoid_0, uint uint_2, uint uint_3, GStruct5* pGstruct5_0);

	// Token: 0x060000D5 RID: 213 RVA: 0x001762B0 File Offset: 0x001762B0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void rewind(GStruct5* pGstruct5_0);

	// Token: 0x060000D6 RID: 214 RVA: 0x001763D0 File Offset: 0x001763D0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int ftell(GStruct5* pGstruct5_0);

	// Token: 0x060000D7 RID: 215 RVA: 0x001766F0 File Offset: 0x001766F0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int fseek(GStruct5* pGstruct5_0, int int_43, int int_44);

	// Token: 0x060000D8 RID: 216 RVA: 0x001740BE File Offset: 0x001740BE
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetupDiDestroyDeviceInfoList(void* pVoid_0);

	// Token: 0x060000D9 RID: 217 RVA: 0x001740C4 File Offset: 0x001740C4
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern uint CM_Free_Log_Conf_Handle(uint uint_2);

	// Token: 0x060000DA RID: 218 RVA: 0x001768A0 File Offset: 0x001768A0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern sbyte* strstr(sbyte* pSbyte_0, sbyte* pSbyte_1);

	// Token: 0x060000DB RID: 219 RVA: 0x00176930 File Offset: 0x00176930
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern sbyte* _strlwr(sbyte* pSbyte_0);

	// Token: 0x060000DC RID: 220 RVA: 0x001740CA File Offset: 0x001740CA
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetupDiGetDeviceRegistryPropertyA(void* pVoid_0, GStruct87* pGstruct87_0, uint uint_2, uint* pUint_0, byte* pByte_0, uint uint_3, uint* pUint_1);

	// Token: 0x060000DD RID: 221 RVA: 0x001740D0 File Offset: 0x001740D0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint CM_Get_Res_Des_Data_Ex(uint uint_2, void* pVoid_0, uint uint_3, uint uint_4, void* pVoid_1);

	// Token: 0x060000DE RID: 222 RVA: 0x001740D6 File Offset: 0x001740D6
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint CM_Get_Res_Des_Data_Size_Ex(uint* pUint_0, uint uint_2, uint uint_3, void* pVoid_0);

	// Token: 0x060000DF RID: 223 RVA: 0x001740DC File Offset: 0x001740DC
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern uint CM_Free_Res_Des_Handle(uint uint_2);

	// Token: 0x060000E0 RID: 224 RVA: 0x001740E2 File Offset: 0x001740E2
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint CM_Get_Next_Res_Des_Ex(uint* pUint_0, uint uint_2, uint uint_3, uint* pUint_1, uint uint_4, void* pVoid_0);

	// Token: 0x060000E1 RID: 225 RVA: 0x001740E8 File Offset: 0x001740E8
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint CM_Get_First_Log_Conf_Ex(uint* pUint_0, uint uint_2, uint uint_3, void* pVoid_0);

	// Token: 0x060000E2 RID: 226 RVA: 0x001740EE File Offset: 0x001740EE
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint CM_Get_DevNode_Status_Ex(uint* pUint_0, uint* pUint_1, uint uint_2, uint uint_3, void* pVoid_0);

	// Token: 0x060000E3 RID: 227 RVA: 0x001740F4 File Offset: 0x001740F4
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetupDiGetDeviceInfoListDetailA(void* pVoid_0, GStruct88* pGstruct88_0);

	// Token: 0x060000E4 RID: 228 RVA: 0x001740FA File Offset: 0x001740FA
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetupDiEnumDeviceInfo(void* pVoid_0, uint uint_2, GStruct87* pGstruct87_0);

	// Token: 0x060000E5 RID: 229 RVA: 0x00174100 File Offset: 0x00174100
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* SetupDiGetClassDevsA(GStruct0* pGstruct0_0, sbyte* pSbyte_0, GStruct11* pGstruct11_0, uint uint_2);

	// Token: 0x060000E6 RID: 230 RVA: 0x00174106 File Offset: 0x00174106
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint CM_Get_DevNode_Status(uint* pUint_0, uint* pUint_1, uint uint_2, uint uint_3);

	// Token: 0x060000E7 RID: 231 RVA: 0x001741C6 File Offset: 0x001741C6
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* LocalAlloc(uint uint_2, uint uint_3);

	// Token: 0x060000E8 RID: 232 RVA: 0x001741CC File Offset: 0x001741CC
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* LocalFree(void* pVoid_0);

	// Token: 0x060000E9 RID: 233 RVA: 0x00173604 File Offset: 0x00173604
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern uint GetLastError();

	// Token: 0x060000EA RID: 234 RVA: 0x0017410C File Offset: 0x0017410C
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetupDiClassGuidsFromNameA(sbyte* pSbyte_0, GStruct0* pGstruct0_0, uint uint_2, uint* pUint_0);

	// Token: 0x060000EB RID: 235 RVA: 0x0016D920 File Offset: 0x0016D920
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int memcmp(void* pVoid_0, void* pVoid_1, uint uint_2);

	// Token: 0x060000EC RID: 236 RVA: 0x00176AF0 File Offset: 0x00176AF0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint fwrite(void* pVoid_0, uint uint_2, uint uint_3, GStruct5* pGstruct5_0);

	// Token: 0x060000ED RID: 237 RVA: 0x00160430 File Offset: 0x00160430
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint strlen(sbyte* pSbyte_0);

	// Token: 0x060000EE RID: 238 RVA: 0x0017427A File Offset: 0x0017427A
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int GetWindowLongA(GStruct11* pGstruct11_0, int int_43);

	// Token: 0x060000EF RID: 239 RVA: 0x001741D2 File Offset: 0x001741D2
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetCommMask(void* pVoid_0, uint uint_2);

	// Token: 0x060000F0 RID: 240 RVA: 0x00173736 File Offset: 0x00173736
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void GetSystemInfo(GStruct91* pGstruct91_0);

	// Token: 0x060000F1 RID: 241 RVA: 0x001735E0 File Offset: 0x001735E0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* GetCurrentProcess();

	// Token: 0x060000F2 RID: 242 RVA: 0x00173592 File Offset: 0x00173592
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct81* GetModuleHandleA(sbyte* pSbyte_0);

	// Token: 0x060000F3 RID: 243 RVA: 0x0017358C File Offset: 0x0017358C
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern method GetProcAddress(GStruct81* pGstruct81_0, sbyte* pSbyte_0);

	// Token: 0x060000F4 RID: 244 RVA: 0x00174298 File Offset: 0x00174298
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int GetDeviceCaps(GStruct92* pGstruct92_0, int int_43);

	// Token: 0x060000F5 RID: 245 RVA: 0x0017429E File Offset: 0x0017429E
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct92* CreateDCA(sbyte* pSbyte_0, sbyte* pSbyte_1, sbyte* pSbyte_2, GStruct98* pGstruct98_0);

	// Token: 0x060000F6 RID: 246 RVA: 0x00174280 File Offset: 0x00174280
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern int GetSystemMetrics(int int_43);

	// Token: 0x060000F7 RID: 247 RVA: 0x001741D8 File Offset: 0x001741D8
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int DeleteFileA(sbyte* pSbyte_0);

	// Token: 0x060000F8 RID: 248 RVA: 0x001605B0 File Offset: 0x001605B0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern sbyte* strcpy(sbyte* pSbyte_0, sbyte* pSbyte_1);

	// Token: 0x060000F9 RID: 249 RVA: 0x001741DE File Offset: 0x001741DE
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint GetTempFileNameA(sbyte* pSbyte_0, sbyte* pSbyte_1, uint uint_2, sbyte* pSbyte_2);

	// Token: 0x060000FA RID: 250 RVA: 0x001741E4 File Offset: 0x001741E4
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint GetTempPathA(uint uint_2, sbyte* pSbyte_0);

	// Token: 0x060000FB RID: 251 RVA: 0x001605C0 File Offset: 0x001605C0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern sbyte* strcat(sbyte* pSbyte_0, sbyte* pSbyte_1);

	// Token: 0x060000FC RID: 252 RVA: 0x001741EA File Offset: 0x001741EA
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint GetLongPathNameA(sbyte* pSbyte_0, sbyte* pSbyte_1, uint uint_2);

	// Token: 0x060000FD RID: 253 RVA: 0x00173754 File Offset: 0x00173754
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int CloseHandle(void* pVoid_0);

	// Token: 0x060000FE RID: 254 RVA: 0x001741F0 File Offset: 0x001741F0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int GetOverlappedResult(void* pVoid_0, GStruct95* pGstruct95_0, uint* pUint_0, int int_43);

	// Token: 0x060000FF RID: 255 RVA: 0x001741F6 File Offset: 0x001741F6
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int ReadFile(void* pVoid_0, void* pVoid_1, uint uint_2, uint* pUint_0, GStruct95* pGstruct95_0);

	// Token: 0x06000100 RID: 256 RVA: 0x001741FC File Offset: 0x001741FC
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetCommTimeouts(void* pVoid_0, GStruct94* pGstruct94_0);

	// Token: 0x06000101 RID: 257 RVA: 0x00174202 File Offset: 0x00174202
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetCommState(void* pVoid_0, GStruct96* pGstruct96_0);

	// Token: 0x06000102 RID: 258 RVA: 0x00174208 File Offset: 0x00174208
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int GetCommState(void* pVoid_0, GStruct96* pGstruct96_0);

	// Token: 0x06000103 RID: 259 RVA: 0x0017420E File Offset: 0x0017420E
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* CreateFileA(sbyte* pSbyte_0, uint uint_2, uint uint_3, GStruct100* pGstruct100_0, uint uint_4, uint uint_5, void* pVoid_0);

	// Token: 0x06000104 RID: 260 RVA: 0x00174214 File Offset: 0x00174214
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void* CreateEventA(GStruct100* pGstruct100_0, int int_43, int int_44, sbyte* pSbyte_0);

	// Token: 0x06000105 RID: 261 RVA: 0x00176D90 File Offset: 0x00176D90
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int fputc(int int_43, GStruct5* pGstruct5_0);

	// Token: 0x06000106 RID: 262 RVA: 0x00176F50 File Offset: 0x00176F50
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern int clock();

	// Token: 0x06000107 RID: 263 RVA: 0x00174286 File Offset: 0x00174286
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern short GetAsyncKeyState(int int_43);

	// Token: 0x06000108 RID: 264 RVA: 0x0017421A File Offset: 0x0017421A
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint WaitForSingleObject(void* pVoid_0, uint uint_2);

	// Token: 0x06000109 RID: 265 RVA: 0x00174220 File Offset: 0x00174220
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int WaitCommEvent(void* pVoid_0, uint* pUint_0, GStruct95* pGstruct95_0);

	// Token: 0x0600010A RID: 266 RVA: 0x00176FF0 File Offset: 0x00176FF0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern void _assert(sbyte* pSbyte_0, sbyte* pSbyte_1, uint uint_2);

	// Token: 0x0600010B RID: 267 RVA: 0x001735B6 File Offset: 0x001735B6
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int WriteFile(void* pVoid_0, void* pVoid_1, uint uint_2, uint* pUint_0, GStruct95* pGstruct95_0);

	// Token: 0x0600010C RID: 268 RVA: 0x00174226 File Offset: 0x00174226
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern int Beep(uint uint_2, uint uint_3);

	// Token: 0x0600010D RID: 269 RVA: 0x0017428C File Offset: 0x0017428C
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern int MessageBeep(uint uint_2);

	// Token: 0x0600010E RID: 270 RVA: 0x0017422C File Offset: 0x0017422C
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int DeviceIoControl(void* pVoid_0, uint uint_2, void* pVoid_1, uint uint_3, void* pVoid_2, uint uint_4, uint* pUint_0, GStruct95* pGstruct95_0);

	// Token: 0x0600010F RID: 271 RVA: 0x00174232 File Offset: 0x00174232
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint GetDriveTypeA(sbyte* pSbyte_0);

	// Token: 0x06000110 RID: 272 RVA: 0x00174238 File Offset: 0x00174238
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern uint GetLogicalDrives();

	// Token: 0x06000111 RID: 273 RVA: 0x001775F0 File Offset: 0x001775F0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int printf(sbyte* pSbyte_0, __arglist);

	// Token: 0x06000112 RID: 274 RVA: 0x001741C0 File Offset: 0x001741C0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int usb_release_interface(void** ppVoid_0, int int_43);

	// Token: 0x06000113 RID: 275 RVA: 0x00174292 File Offset: 0x00174292
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int ShowWindow(GStruct11* pGstruct11_0, int int_43);

	// Token: 0x06000114 RID: 276 RVA: 0x00174112 File Offset: 0x00174112
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint CM_Get_Parent(uint* pUint_0, uint uint_2, uint uint_3);

	// Token: 0x06000115 RID: 277 RVA: 0x00174148 File Offset: 0x00174148
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int RegCloseKey(GStruct106* pGstruct106_0);

	// Token: 0x06000116 RID: 278 RVA: 0x0017414E File Offset: 0x0017414E
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int RegQueryValueExA(GStruct106* pGstruct106_0, sbyte* pSbyte_0, uint* pUint_0, uint* pUint_1, byte* pByte_0, uint* pUint_2);

	// Token: 0x06000117 RID: 279 RVA: 0x00174118 File Offset: 0x00174118
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct106* SetupDiOpenDevRegKey(void* pVoid_0, GStruct87* pGstruct87_0, uint uint_2, uint uint_3, uint uint_4, uint uint_5);

	// Token: 0x06000118 RID: 280 RVA: 0x0017411E File Offset: 0x0017411E
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern uint CM_Reenumerate_DevNode(uint uint_2, uint uint_3);

	// Token: 0x06000119 RID: 281 RVA: 0x00174124 File Offset: 0x00174124
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint CM_Locate_DevNodeA(uint* pUint_0, sbyte* pSbyte_0, uint uint_2);

	// Token: 0x0600011A RID: 282 RVA: 0x0017412A File Offset: 0x0017412A
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint CM_Query_And_Remove_SubTreeW(uint uint_2, int* pInt_0, ushort* pUshort_0, uint uint_3, uint uint_4);

	// Token: 0x0600011B RID: 283 RVA: 0x0017423E File Offset: 0x0017423E
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint QueryDosDeviceA(sbyte* pSbyte_0, sbyte* pSbyte_1, uint uint_2);

	// Token: 0x0600011C RID: 284 RVA: 0x00174130 File Offset: 0x00174130
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetupDiGetDeviceInterfaceDetailA(void* pVoid_0, GStruct108* pGstruct108_0, GStruct109* pGstruct109_0, uint uint_2, uint* pUint_0, GStruct87* pGstruct87_0);

	// Token: 0x0600011D RID: 285 RVA: 0x00174136 File Offset: 0x00174136
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetupDiEnumDeviceInterfaces(void* pVoid_0, GStruct87* pGstruct87_0, GStruct0* pGstruct0_0, uint uint_2, GStruct108* pGstruct108_0);

	// Token: 0x0600011E RID: 286 RVA: 0x0017413C File Offset: 0x0017413C
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetupDiCallClassInstaller(uint uint_2, void* pVoid_0, GStruct87* pGstruct87_0);

	// Token: 0x0600011F RID: 287 RVA: 0x00174142 File Offset: 0x00174142
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int SetupDiSetClassInstallParamsA(void* pVoid_0, GStruct87* pGstruct87_0, GStruct117* pGstruct117_0, uint uint_2);

	// Token: 0x06000120 RID: 288 RVA: 0x001735FE File Offset: 0x001735FE
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int WideCharToMultiByte(uint uint_2, uint uint_3, ushort* pUshort_0, int int_43, sbyte* pSbyte_0, int int_44, sbyte* pSbyte_1, int* pInt_0);

	// Token: 0x06000121 RID: 289 RVA: 0x001776C0 File Offset: 0x001776C0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern uint _lrotr(uint uint_2, int int_43);

	// Token: 0x06000122 RID: 290 RVA: 0x00177770 File Offset: 0x00177770
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern uint _lrotl(uint uint_2, int int_43);

	// Token: 0x06000123 RID: 291 RVA: 0x00177820 File Offset: 0x00177820
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern sbyte* strrchr(sbyte* pSbyte_0, int int_43);

	// Token: 0x06000124 RID: 292 RVA: 0x001735CE File Offset: 0x001735CE
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern uint GetModuleFileNameA(GStruct81* pGstruct81_0, sbyte* pSbyte_0, uint uint_2);

	// Token: 0x06000125 RID: 293 RVA: 0x00174154 File Offset: 0x00174154
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int StartServiceA(GStruct118* pGstruct118_0, uint uint_2, sbyte** ppSbyte_0);

	// Token: 0x06000126 RID: 294 RVA: 0x0017415A File Offset: 0x0017415A
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int CloseServiceHandle(GStruct118* pGstruct118_0);

	// Token: 0x06000127 RID: 295 RVA: 0x00174160 File Offset: 0x00174160
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct118* CreateServiceA(GStruct118* pGstruct118_0, sbyte* pSbyte_0, sbyte* pSbyte_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, sbyte* pSbyte_2, sbyte* pSbyte_3, uint* pUint_0, sbyte* pSbyte_4, sbyte* pSbyte_5, sbyte* pSbyte_6);

	// Token: 0x06000128 RID: 296 RVA: 0x00174166 File Offset: 0x00174166
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct118* OpenSCManagerA(sbyte* pSbyte_0, sbyte* pSbyte_1, uint uint_2);

	// Token: 0x06000129 RID: 297 RVA: 0x0017416C File Offset: 0x0017416C
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int DeleteService(GStruct118* pGstruct118_0);

	// Token: 0x0600012A RID: 298 RVA: 0x00174172 File Offset: 0x00174172
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern int ControlService(GStruct118* pGstruct118_0, uint uint_2, GStruct119* pGstruct119_0);

	// Token: 0x0600012B RID: 299 RVA: 0x00174178 File Offset: 0x00174178
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public unsafe static extern GStruct118* OpenServiceA(GStruct118* pGstruct118_0, sbyte* pSbyte_0, uint uint_2);

	// Token: 0x0600012C RID: 300 RVA: 0x00159FD0 File Offset: 0x00159FD0
	[SuppressUnmanagedCodeSecurity]
	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig)]
	public static extern uint _WinMainCRTStartup();

	// Token: 0x04000001 RID: 1 RVA: 0x0017B334 File Offset: 0x0017B334
	public static Struct0 struct0_0;

	// Token: 0x04000002 RID: 2 RVA: 0x0017B348 File Offset: 0x0017B348
	public static Struct1 struct1_0;

	// Token: 0x04000003 RID: 3 RVA: 0x0017B360 File Offset: 0x0017B360
	public static Struct2 struct2_0;

	// Token: 0x04000004 RID: 4 RVA: 0x0017B388 File Offset: 0x0017B388
	public static Struct6 struct6_0;

	// Token: 0x04000005 RID: 5 RVA: 0x0017B38C File Offset: 0x0017B38C
	public static Struct7 struct7_0;

	// Token: 0x04000006 RID: 6 RVA: 0x0017B398 File Offset: 0x0017B398
	public static Struct1 struct1_1;

	// Token: 0x04000007 RID: 7 RVA: 0x0017B3B0 File Offset: 0x0017B3B0
	public static Struct8 struct8_0;

	// Token: 0x04000008 RID: 8 RVA: 0x0017B3D0 File Offset: 0x0017B3D0
	public static Struct9 struct9_0;

	// Token: 0x04000009 RID: 9 RVA: 0x0017B3F0 File Offset: 0x0017B3F0
	public static Struct6 struct6_1;

	// Token: 0x0400000A RID: 10 RVA: 0x0017B3F4 File Offset: 0x0017B3F4
	public static Struct6 struct6_2;

	// Token: 0x0400000B RID: 11 RVA: 0x0017B3F8 File Offset: 0x0017B3F8
	public static Struct10 struct10_0;

	// Token: 0x0400000C RID: 12 RVA: 0x0026B944 File Offset: 0x0026B944
	public static GStruct10 gstruct10_0;

	// Token: 0x0400000D RID: 13 RVA: 0x00260050 File Offset: 0x00260050
	public static Struct11 struct11_0;

	// Token: 0x0400000E RID: 14 RVA: 0x0017B400 File Offset: 0x0017B400
	public static Struct12 struct12_0;

	// Token: 0x0400000F RID: 15 RVA: 0x0026BB40 File Offset: 0x0026BB40
	public unsafe static GStruct14* pGstruct14_0;

	// Token: 0x04000010 RID: 16 RVA: 0x0017B41C File Offset: 0x0017B41C
	public static Struct12 struct12_1;

	// Token: 0x04000011 RID: 17 RVA: 0x0017B438 File Offset: 0x0017B438
	public static Struct13 struct13_0;

	// Token: 0x04000012 RID: 18 RVA: 0x0026BB74 File Offset: 0x0026BB74
	public unsafe static GStruct14* pGstruct14_1;

	// Token: 0x04000013 RID: 19 RVA: 0x0017B450 File Offset: 0x0017B450
	public static Struct12 struct12_2;

	// Token: 0x04000014 RID: 20 RVA: 0x0017B46C File Offset: 0x0017B46C
	public static Struct14 struct14_0;

	// Token: 0x04000015 RID: 21 RVA: 0x0026BBC4 File Offset: 0x0026BBC4
	public unsafe static GStruct14* pGstruct14_2;

	// Token: 0x04000016 RID: 22 RVA: 0x0017B480 File Offset: 0x0017B480
	public static Struct12 struct12_3;

	// Token: 0x04000017 RID: 23 RVA: 0x0017B49C File Offset: 0x0017B49C
	public static Struct15 struct15_0;

	// Token: 0x04000018 RID: 24 RVA: 0x0026BC40 File Offset: 0x0026BC40
	public unsafe static GStruct14* pGstruct14_3;

	// Token: 0x04000019 RID: 25 RVA: 0x0017B4AC File Offset: 0x0017B4AC
	public static Struct12 struct12_4;

	// Token: 0x0400001A RID: 26 RVA: 0x0017B4C8 File Offset: 0x0017B4C8
	public static Struct16 struct16_0;

	// Token: 0x0400001B RID: 27 RVA: 0x0026BC94 File Offset: 0x0026BC94
	public unsafe static GStruct14* pGstruct14_4;

	// Token: 0x0400001C RID: 28 RVA: 0x0017B594 File Offset: 0x0017B594
	public static Struct18 struct18_0;

	// Token: 0x0400001D RID: 29 RVA: 0x0017B590 File Offset: 0x0017B590
	public static Struct19 struct19_0;

	// Token: 0x0400001E RID: 30 RVA: 0x0017B5A0 File Offset: 0x0017B5A0
	public static Struct21 struct21_0;

	// Token: 0x0400001F RID: 31 RVA: 0x0026BCC4 File Offset: 0x0026BCC4
	public unsafe static GStruct14* pGstruct14_5;

	// Token: 0x04000020 RID: 32 RVA: 0x0017B4E8 File Offset: 0x0017B4E8
	public static int int_0;

	// Token: 0x04000021 RID: 33 RVA: 0x0017B508 File Offset: 0x0017B508
	public static int int_1;

	// Token: 0x04000022 RID: 34 RVA: 0x0017B514 File Offset: 0x0017B514
	public static int int_2;

	// Token: 0x04000023 RID: 35 RVA: 0x0017B4F8 File Offset: 0x0017B4F8
	public static int int_3;

	// Token: 0x04000024 RID: 36 RVA: 0x0017B55C File Offset: 0x0017B55C
	public static int int_4;

	// Token: 0x04000025 RID: 37 RVA: 0x0017B598 File Offset: 0x0017B598
	public static uint uint_0;

	// Token: 0x04000026 RID: 38 RVA: 0x0017B4F4 File Offset: 0x0017B4F4
	public static int int_5;

	// Token: 0x04000027 RID: 39 RVA: 0x0017B564 File Offset: 0x0017B564
	public static int int_6;

	// Token: 0x04000028 RID: 40 RVA: 0x0017B520 File Offset: 0x0017B520
	public static int int_7;

	// Token: 0x04000029 RID: 41 RVA: 0x0017B528 File Offset: 0x0017B528
	public static int int_8;

	// Token: 0x0400002A RID: 42 RVA: 0x0017B54C File Offset: 0x0017B54C
	public static int int_9;

	// Token: 0x0400002B RID: 43 RVA: 0x0017B550 File Offset: 0x0017B550
	public static int int_10;

	// Token: 0x0400002C RID: 44 RVA: 0x0017B524 File Offset: 0x0017B524
	public static int int_11;

	// Token: 0x0400002D RID: 45 RVA: 0x0017B50C File Offset: 0x0017B50C
	public static int int_12;

	// Token: 0x0400002E RID: 46 RVA: 0x0017B504 File Offset: 0x0017B504
	public static int int_13;

	// Token: 0x0400002F RID: 47 RVA: 0x0017B53C File Offset: 0x0017B53C
	public static int int_14;

	// Token: 0x04000030 RID: 48 RVA: 0x0017B538 File Offset: 0x0017B538
	public static int int_15;

	// Token: 0x04000031 RID: 49 RVA: 0x0017B558 File Offset: 0x0017B558
	public static int int_16;

	// Token: 0x04000032 RID: 50 RVA: 0x0017B554 File Offset: 0x0017B554
	public static int int_17;

	// Token: 0x04000033 RID: 51 RVA: 0x0017B584 File Offset: 0x0017B584
	public static int int_18;

	// Token: 0x04000034 RID: 52 RVA: 0x0017B4E4 File Offset: 0x0017B4E4
	public static int int_19;

	// Token: 0x04000035 RID: 53 RVA: 0x0017B510 File Offset: 0x0017B510
	public static int int_20;

	// Token: 0x04000036 RID: 54 RVA: 0x0017B560 File Offset: 0x0017B560
	public static int int_21;

	// Token: 0x04000037 RID: 55 RVA: 0x0017B548 File Offset: 0x0017B548
	public static int int_22;

	// Token: 0x04000038 RID: 56 RVA: 0x0017B580 File Offset: 0x0017B580
	public static int int_23;

	// Token: 0x04000039 RID: 57 RVA: 0x0017B500 File Offset: 0x0017B500
	public static int int_24;

	// Token: 0x0400003A RID: 58 RVA: 0x0017B544 File Offset: 0x0017B544
	public static int int_25;

	// Token: 0x0400003B RID: 59 RVA: 0x0017B518 File Offset: 0x0017B518
	public static int int_26;

	// Token: 0x0400003C RID: 60 RVA: 0x0017B59C File Offset: 0x0017B59C
	public static uint uint_1;

	// Token: 0x0400003D RID: 61 RVA: 0x0017B52C File Offset: 0x0017B52C
	public static int int_27;

	// Token: 0x0400003E RID: 62 RVA: 0x0017B4FC File Offset: 0x0017B4FC
	public static int int_28;

	// Token: 0x0400003F RID: 63 RVA: 0x0017B56C File Offset: 0x0017B56C
	public static int int_29;

	// Token: 0x04000040 RID: 64 RVA: 0x0017B578 File Offset: 0x0017B578
	public static int int_30;

	// Token: 0x04000041 RID: 65 RVA: 0x0017B4DC File Offset: 0x0017B4DC
	public static int int_31;

	// Token: 0x04000042 RID: 66 RVA: 0x0017B4EC File Offset: 0x0017B4EC
	public static int int_32;

	// Token: 0x04000043 RID: 67 RVA: 0x0017B4E0 File Offset: 0x0017B4E0
	public static int int_33;

	// Token: 0x04000044 RID: 68 RVA: 0x0017B574 File Offset: 0x0017B574
	public static int int_34;

	// Token: 0x04000045 RID: 69 RVA: 0x0017B570 File Offset: 0x0017B570
	public static int int_35;

	// Token: 0x04000046 RID: 70 RVA: 0x0017B530 File Offset: 0x0017B530
	public static int int_36;

	// Token: 0x04000047 RID: 71 RVA: 0x0017B568 File Offset: 0x0017B568
	public static int int_37;

	// Token: 0x04000048 RID: 72 RVA: 0x0017B51C File Offset: 0x0017B51C
	public static int int_38;

	// Token: 0x04000049 RID: 73 RVA: 0x0017B4F0 File Offset: 0x0017B4F0
	public static int int_39;

	// Token: 0x0400004A RID: 74 RVA: 0x0017B534 File Offset: 0x0017B534
	public static int int_40;

	// Token: 0x0400004B RID: 75 RVA: 0x0017B57C File Offset: 0x0017B57C
	public static int int_41;

	// Token: 0x0400004C RID: 76 RVA: 0x0017B540 File Offset: 0x0017B540
	public static int int_42;

	// Token: 0x0400004D RID: 77 RVA: 0x0017B588 File Offset: 0x0017B588
	unsafe static int** ppInt_0;

	// Token: 0x0400004E RID: 78 RVA: 0x0017B58C File Offset: 0x0017B58C
	unsafe static int** ppInt_1;

	// Token: 0x0400004F RID: 79 RVA: 0x0017B5E8 File Offset: 0x0017B5E8
	public static Struct22 struct22_0;

	// Token: 0x04000050 RID: 80 RVA: 0x0017B5F4 File Offset: 0x0017B5F4
	public static Struct23 struct23_0;

	// Token: 0x04000051 RID: 81 RVA: 0x0017B618 File Offset: 0x0017B618
	public static Struct18 struct18_1;

	// Token: 0x04000052 RID: 82 RVA: 0x0017B60C File Offset: 0x0017B60C
	public static Struct24 struct24_0;

	// Token: 0x04000053 RID: 83 RVA: 0x0017B608 File Offset: 0x0017B608
	public static Struct25 struct25_0;

	// Token: 0x04000054 RID: 84 RVA: 0x0017B600 File Offset: 0x0017B600
	public static Struct10 struct10_1;

	// Token: 0x04000055 RID: 85 RVA: 0x0017B5FC File Offset: 0x0017B5FC
	public static Struct25 struct25_1;

	// Token: 0x04000056 RID: 86 RVA: 0x0017B678 File Offset: 0x0017B678
	public static Struct12 struct12_5;

	// Token: 0x04000057 RID: 87 RVA: 0x0017B658 File Offset: 0x0017B658
	public static Struct9 struct9_1;

	// Token: 0x04000058 RID: 88 RVA: 0x0017B630 File Offset: 0x0017B630
	public static Struct26 struct26_0;

	// Token: 0x04000059 RID: 89 RVA: 0x0017B61C File Offset: 0x0017B61C
	public static Struct16 struct16_1;

	// Token: 0x0400005A RID: 90 RVA: 0x0017B694 File Offset: 0x0017B694
	public static Struct18 struct18_2;

	// Token: 0x0400005B RID: 91 RVA: 0x0017B6DC File Offset: 0x0017B6DC
	public static Struct6 struct6_3;

	// Token: 0x0400005C RID: 92 RVA: 0x0017B6D8 File Offset: 0x0017B6D8
	public static Struct6 struct6_4;

	// Token: 0x0400005D RID: 93 RVA: 0x0017B6D4 File Offset: 0x0017B6D4
	public static Struct6 struct6_5;

	// Token: 0x0400005E RID: 94 RVA: 0x0017B6D0 File Offset: 0x0017B6D0
	public static Struct18 struct18_3;

	// Token: 0x0400005F RID: 95 RVA: 0x0017B6CC File Offset: 0x0017B6CC
	public static Struct6 struct6_6;

	// Token: 0x04000060 RID: 96 RVA: 0x0017B6C0 File Offset: 0x0017B6C0
	public static Struct7 struct7_1;

	// Token: 0x04000061 RID: 97 RVA: 0x0017B6AC File Offset: 0x0017B6AC
	public static Struct16 struct16_2;

	// Token: 0x04000062 RID: 98 RVA: 0x0017B698 File Offset: 0x0017B698
	public static Struct16 struct16_3;

	// Token: 0x04000063 RID: 99 RVA: 0x0017B5F0 File Offset: 0x0017B5F0
	unsafe static int** ppInt_2;

	// Token: 0x04000064 RID: 100 RVA: 0x0017B6E8 File Offset: 0x0017B6E8
	public static Struct6 struct6_7;

	// Token: 0x04000065 RID: 101 RVA: 0x0017B6EC File Offset: 0x0017B6EC
	public static Struct18 struct18_4;

	// Token: 0x04000066 RID: 102 RVA: 0x0026D114 File Offset: 0x0026D114
	public unsafe static GStruct14* pGstruct14_6;

	// Token: 0x04000067 RID: 103 RVA: 0x0017B6E0 File Offset: 0x0017B6E0
	unsafe static int** ppInt_3;

	// Token: 0x04000068 RID: 104 RVA: 0x0017B6E4 File Offset: 0x0017B6E4
	unsafe static int** ppInt_4;

	// Token: 0x04000069 RID: 105 RVA: 0x0017B6F0 File Offset: 0x0017B6F0
	public static Struct10 struct10_2;

	// Token: 0x0400006A RID: 106 RVA: 0x0017B6F8 File Offset: 0x0017B6F8
	public static Struct35 struct35_0;

	// Token: 0x0400006B RID: 107 RVA: 0x0017B700 File Offset: 0x0017B700
	public static Struct35 struct35_1;

	// Token: 0x0400006C RID: 108 RVA: 0x0017B708 File Offset: 0x0017B708
	public static Struct10 struct10_3;

	// Token: 0x0400006D RID: 109 RVA: 0x0017B710 File Offset: 0x0017B710
	public static Struct35 struct35_2;

	// Token: 0x0400006E RID: 110 RVA: 0x0017B718 File Offset: 0x0017B718
	public static Struct35 struct35_3;

	// Token: 0x0400006F RID: 111 RVA: 0x0017B720 File Offset: 0x0017B720
	public static Struct23 struct23_1;

	// Token: 0x04000070 RID: 112 RVA: 0x0017B728 File Offset: 0x0017B728
	public static Struct35 struct35_4;

	// Token: 0x04000071 RID: 113 RVA: 0x0017B730 File Offset: 0x0017B730
	public static Struct35 struct35_5;

	// Token: 0x04000072 RID: 114 RVA: 0x0017B738 File Offset: 0x0017B738
	public static Struct23 struct23_2;

	// Token: 0x04000073 RID: 115 RVA: 0x0017B740 File Offset: 0x0017B740
	public static Struct35 struct35_6;

	// Token: 0x04000074 RID: 116 RVA: 0x0017B748 File Offset: 0x0017B748
	public static Struct35 struct35_7;

	// Token: 0x04000075 RID: 117 RVA: 0x0017B750 File Offset: 0x0017B750
	public static Struct23 struct23_3;

	// Token: 0x04000076 RID: 118 RVA: 0x0017B758 File Offset: 0x0017B758
	public static Struct35 struct35_8;

	// Token: 0x04000077 RID: 119 RVA: 0x0017B760 File Offset: 0x0017B760
	public static Struct35 struct35_9;

	// Token: 0x04000078 RID: 120 RVA: 0x0017B768 File Offset: 0x0017B768
	public static Struct23 struct23_4;

	// Token: 0x04000079 RID: 121 RVA: 0x0017B770 File Offset: 0x0017B770
	public static Struct35 struct35_10;

	// Token: 0x0400007A RID: 122 RVA: 0x0017B778 File Offset: 0x0017B778
	public static Struct35 struct35_11;

	// Token: 0x0400007B RID: 123 RVA: 0x0017B780 File Offset: 0x0017B780
	public static Struct23 struct23_5;

	// Token: 0x0400007C RID: 124 RVA: 0x0017B788 File Offset: 0x0017B788
	public static Struct35 struct35_12;

	// Token: 0x0400007D RID: 125 RVA: 0x0017B790 File Offset: 0x0017B790
	public static Struct35 struct35_13;

	// Token: 0x0400007E RID: 126 RVA: 0x0017B798 File Offset: 0x0017B798
	public static Struct23 struct23_6;

	// Token: 0x0400007F RID: 127 RVA: 0x0017B7A0 File Offset: 0x0017B7A0
	public static Struct35 struct35_14;

	// Token: 0x04000080 RID: 128 RVA: 0x0017B7A8 File Offset: 0x0017B7A8
	public static Struct35 struct35_15;

	// Token: 0x04000081 RID: 129 RVA: 0x0017B7B0 File Offset: 0x0017B7B0
	public static Struct23 struct23_7;

	// Token: 0x04000082 RID: 130 RVA: 0x0017B7B8 File Offset: 0x0017B7B8
	public static Struct35 struct35_16;

	// Token: 0x04000083 RID: 131 RVA: 0x0017B7C0 File Offset: 0x0017B7C0
	public static Struct35 struct35_17;

	// Token: 0x04000084 RID: 132 RVA: 0x0017B7C8 File Offset: 0x0017B7C8
	public static Struct23 struct23_8;

	// Token: 0x04000085 RID: 133 RVA: 0x0017B7D0 File Offset: 0x0017B7D0
	public static Struct35 struct35_18;

	// Token: 0x04000086 RID: 134 RVA: 0x0017B7D8 File Offset: 0x0017B7D8
	public static Struct35 struct35_19;

	// Token: 0x04000087 RID: 135 RVA: 0x0017B7E0 File Offset: 0x0017B7E0
	public static Struct23 struct23_9;

	// Token: 0x04000088 RID: 136 RVA: 0x0017B7E8 File Offset: 0x0017B7E8
	public static Struct35 struct35_20;

	// Token: 0x04000089 RID: 137 RVA: 0x0017B7F0 File Offset: 0x0017B7F0
	public static Struct35 struct35_21;

	// Token: 0x0400008A RID: 138 RVA: 0x0017B7F8 File Offset: 0x0017B7F8
	public static Struct23 struct23_10;

	// Token: 0x0400008B RID: 139 RVA: 0x0017B800 File Offset: 0x0017B800
	public static Struct35 struct35_22;

	// Token: 0x0400008C RID: 140 RVA: 0x0017B808 File Offset: 0x0017B808
	public static Struct35 struct35_23;

	// Token: 0x0400008D RID: 141 RVA: 0x0017B810 File Offset: 0x0017B810
	public static Struct23 struct23_11;

	// Token: 0x0400008E RID: 142 RVA: 0x0017B818 File Offset: 0x0017B818
	public static Struct35 struct35_24;

	// Token: 0x0400008F RID: 143 RVA: 0x0017B820 File Offset: 0x0017B820
	public static Struct35 struct35_25;

	// Token: 0x04000090 RID: 144 RVA: 0x0017B828 File Offset: 0x0017B828
	public static Struct23 struct23_12;

	// Token: 0x04000091 RID: 145 RVA: 0x0017B830 File Offset: 0x0017B830
	public static Struct35 struct35_26;

	// Token: 0x04000092 RID: 146 RVA: 0x0017B838 File Offset: 0x0017B838
	public static Struct35 struct35_27;

	// Token: 0x04000093 RID: 147 RVA: 0x0017B840 File Offset: 0x0017B840
	public static Struct23 struct23_13;

	// Token: 0x04000094 RID: 148 RVA: 0x0017B848 File Offset: 0x0017B848
	public static Struct35 struct35_28;

	// Token: 0x04000095 RID: 149 RVA: 0x0017B850 File Offset: 0x0017B850
	public static Struct35 struct35_29;

	// Token: 0x04000096 RID: 150 RVA: 0x0017B858 File Offset: 0x0017B858
	public static Struct23 struct23_14;

	// Token: 0x04000097 RID: 151 RVA: 0x0017B860 File Offset: 0x0017B860
	public static Struct35 struct35_30;

	// Token: 0x04000098 RID: 152 RVA: 0x0017B868 File Offset: 0x0017B868
	public static Struct35 struct35_31;

	// Token: 0x04000099 RID: 153 RVA: 0x0017B870 File Offset: 0x0017B870
	public static Struct23 struct23_15;

	// Token: 0x0400009A RID: 154 RVA: 0x0017B878 File Offset: 0x0017B878
	public static Struct35 struct35_32;

	// Token: 0x0400009B RID: 155 RVA: 0x0017B880 File Offset: 0x0017B880
	public static Struct35 struct35_33;

	// Token: 0x0400009C RID: 156 RVA: 0x0017B888 File Offset: 0x0017B888
	public static Struct23 struct23_16;

	// Token: 0x0400009D RID: 157 RVA: 0x0017B890 File Offset: 0x0017B890
	public static Struct35 struct35_34;

	// Token: 0x0400009E RID: 158 RVA: 0x0017B898 File Offset: 0x0017B898
	public static Struct35 struct35_35;

	// Token: 0x0400009F RID: 159 RVA: 0x0017B8A0 File Offset: 0x0017B8A0
	public static Struct23 struct23_17;

	// Token: 0x040000A0 RID: 160 RVA: 0x0017B8A8 File Offset: 0x0017B8A8
	public static Struct35 struct35_36;

	// Token: 0x040000A1 RID: 161 RVA: 0x0017B8B0 File Offset: 0x0017B8B0
	public static Struct35 struct35_37;

	// Token: 0x040000A2 RID: 162 RVA: 0x0017B8B8 File Offset: 0x0017B8B8
	public static Struct23 struct23_18;

	// Token: 0x040000A3 RID: 163 RVA: 0x0017B8C0 File Offset: 0x0017B8C0
	public static Struct35 struct35_38;

	// Token: 0x040000A4 RID: 164 RVA: 0x0017B8C8 File Offset: 0x0017B8C8
	public static Struct35 struct35_39;

	// Token: 0x040000A5 RID: 165 RVA: 0x0017B8D0 File Offset: 0x0017B8D0
	public static Struct23 struct23_19;

	// Token: 0x040000A6 RID: 166 RVA: 0x0017B8D8 File Offset: 0x0017B8D8
	public static Struct35 struct35_40;

	// Token: 0x040000A7 RID: 167 RVA: 0x0017B8E0 File Offset: 0x0017B8E0
	public static Struct35 struct35_41;

	// Token: 0x040000A8 RID: 168 RVA: 0x0017B8E8 File Offset: 0x0017B8E8
	public static Struct23 struct23_20;

	// Token: 0x040000A9 RID: 169 RVA: 0x0017B8F0 File Offset: 0x0017B8F0
	public static Struct35 struct35_42;

	// Token: 0x040000AA RID: 170 RVA: 0x0017B8F8 File Offset: 0x0017B8F8
	public static Struct35 struct35_43;

	// Token: 0x040000AB RID: 171 RVA: 0x0017B900 File Offset: 0x0017B900
	public static Struct10 struct10_4;

	// Token: 0x040000AC RID: 172 RVA: 0x0017B908 File Offset: 0x0017B908
	public static Struct35 struct35_44;

	// Token: 0x040000AD RID: 173 RVA: 0x0017B910 File Offset: 0x0017B910
	public static Struct35 struct35_45;

	// Token: 0x040000AE RID: 174 RVA: 0x0017B918 File Offset: 0x0017B918
	public static Struct10 struct10_5;

	// Token: 0x040000AF RID: 175 RVA: 0x0017B920 File Offset: 0x0017B920
	public static Struct35 struct35_46;

	// Token: 0x040000B0 RID: 176 RVA: 0x0017B928 File Offset: 0x0017B928
	public static Struct35 struct35_47;

	// Token: 0x040000B1 RID: 177 RVA: 0x0017B930 File Offset: 0x0017B930
	public static Struct10 struct10_6;

	// Token: 0x040000B2 RID: 178 RVA: 0x0017B938 File Offset: 0x0017B938
	public static Struct35 struct35_48;

	// Token: 0x040000B3 RID: 179 RVA: 0x0017B940 File Offset: 0x0017B940
	public static Struct35 struct35_49;

	// Token: 0x040000B4 RID: 180 RVA: 0x0017B948 File Offset: 0x0017B948
	public static Struct10 struct10_7;

	// Token: 0x040000B5 RID: 181 RVA: 0x0017B950 File Offset: 0x0017B950
	public static Struct35 struct35_50;

	// Token: 0x040000B6 RID: 182 RVA: 0x0017B958 File Offset: 0x0017B958
	public static Struct35 struct35_51;

	// Token: 0x040000B7 RID: 183 RVA: 0x0017B960 File Offset: 0x0017B960
	public static Struct10 struct10_8;

	// Token: 0x040000B8 RID: 184 RVA: 0x0017B968 File Offset: 0x0017B968
	public static Struct35 struct35_52;

	// Token: 0x040000B9 RID: 185 RVA: 0x0017B970 File Offset: 0x0017B970
	public static Struct35 struct35_53;

	// Token: 0x040000BA RID: 186 RVA: 0x0017B978 File Offset: 0x0017B978
	public static Struct10 struct10_9;

	// Token: 0x040000BB RID: 187 RVA: 0x0017B980 File Offset: 0x0017B980
	public static Struct35 struct35_54;

	// Token: 0x040000BC RID: 188 RVA: 0x0017B988 File Offset: 0x0017B988
	public static Struct35 struct35_55;

	// Token: 0x040000BD RID: 189 RVA: 0x0017B990 File Offset: 0x0017B990
	public static Struct10 struct10_10;

	// Token: 0x040000BE RID: 190 RVA: 0x0017B998 File Offset: 0x0017B998
	public static Struct35 struct35_56;

	// Token: 0x040000BF RID: 191 RVA: 0x0017B9A0 File Offset: 0x0017B9A0
	public static Struct35 struct35_57;

	// Token: 0x040000C0 RID: 192 RVA: 0x0017B9A8 File Offset: 0x0017B9A8
	public static Struct10 struct10_11;

	// Token: 0x040000C1 RID: 193 RVA: 0x0017B9B0 File Offset: 0x0017B9B0
	public static Struct35 struct35_58;

	// Token: 0x040000C2 RID: 194 RVA: 0x0017B9B8 File Offset: 0x0017B9B8
	public static Struct35 struct35_59;

	// Token: 0x040000C3 RID: 195 RVA: 0x0017B9C0 File Offset: 0x0017B9C0
	public static Struct10 struct10_12;

	// Token: 0x040000C4 RID: 196 RVA: 0x0017B9C8 File Offset: 0x0017B9C8
	public static Struct35 struct35_60;

	// Token: 0x040000C5 RID: 197 RVA: 0x0017B9D0 File Offset: 0x0017B9D0
	public static Struct35 struct35_61;

	// Token: 0x040000C6 RID: 198 RVA: 0x0017B9D8 File Offset: 0x0017B9D8
	public static Struct10 struct10_13;

	// Token: 0x040000C7 RID: 199 RVA: 0x0017B9E0 File Offset: 0x0017B9E0
	public static Struct35 struct35_62;

	// Token: 0x040000C8 RID: 200 RVA: 0x0017B9E8 File Offset: 0x0017B9E8
	public static Struct35 struct35_63;

	// Token: 0x040000C9 RID: 201 RVA: 0x0017B9F0 File Offset: 0x0017B9F0
	public static Struct10 struct10_14;

	// Token: 0x040000CA RID: 202 RVA: 0x0017B9F8 File Offset: 0x0017B9F8
	public static Struct35 struct35_64;

	// Token: 0x040000CB RID: 203 RVA: 0x0017BA00 File Offset: 0x0017BA00
	public static Struct35 struct35_65;

	// Token: 0x040000CC RID: 204 RVA: 0x0017BA08 File Offset: 0x0017BA08
	public static Struct10 struct10_15;

	// Token: 0x040000CD RID: 205 RVA: 0x0017BA10 File Offset: 0x0017BA10
	public static Struct35 struct35_66;

	// Token: 0x040000CE RID: 206 RVA: 0x0017BA18 File Offset: 0x0017BA18
	public static Struct35 struct35_67;

	// Token: 0x040000CF RID: 207 RVA: 0x0017BA20 File Offset: 0x0017BA20
	public static Struct10 struct10_16;

	// Token: 0x040000D0 RID: 208 RVA: 0x0017BA28 File Offset: 0x0017BA28
	public static Struct35 struct35_68;

	// Token: 0x040000D1 RID: 209 RVA: 0x0017BA30 File Offset: 0x0017BA30
	public static Struct35 struct35_69;

	// Token: 0x040000D2 RID: 210 RVA: 0x0017BA38 File Offset: 0x0017BA38
	public static Struct10 struct10_17;

	// Token: 0x040000D3 RID: 211 RVA: 0x0017BA40 File Offset: 0x0017BA40
	public static Struct35 struct35_70;

	// Token: 0x040000D4 RID: 212 RVA: 0x0017BA48 File Offset: 0x0017BA48
	public static Struct35 struct35_71;

	// Token: 0x040000D5 RID: 213 RVA: 0x0017BA50 File Offset: 0x0017BA50
	public static Struct23 struct23_21;

	// Token: 0x040000D6 RID: 214 RVA: 0x0017BA58 File Offset: 0x0017BA58
	public static Struct35 struct35_72;

	// Token: 0x040000D7 RID: 215 RVA: 0x0017BA60 File Offset: 0x0017BA60
	public static Struct35 struct35_73;

	// Token: 0x040000D8 RID: 216 RVA: 0x0017BA68 File Offset: 0x0017BA68
	public static Struct23 struct23_22;

	// Token: 0x040000D9 RID: 217 RVA: 0x0017BA70 File Offset: 0x0017BA70
	public static Struct35 struct35_74;

	// Token: 0x040000DA RID: 218 RVA: 0x0017BA78 File Offset: 0x0017BA78
	public static Struct35 struct35_75;

	// Token: 0x040000DB RID: 219 RVA: 0x0017BA80 File Offset: 0x0017BA80
	public static Struct23 struct23_23;

	// Token: 0x040000DC RID: 220 RVA: 0x0017BA88 File Offset: 0x0017BA88
	public static Struct35 struct35_76;

	// Token: 0x040000DD RID: 221 RVA: 0x0017BA90 File Offset: 0x0017BA90
	public static Struct35 struct35_77;

	// Token: 0x040000DE RID: 222 RVA: 0x0017BA98 File Offset: 0x0017BA98
	public static Struct23 struct23_24;

	// Token: 0x040000DF RID: 223 RVA: 0x0017BAA0 File Offset: 0x0017BAA0
	public static Struct35 struct35_78;

	// Token: 0x040000E0 RID: 224 RVA: 0x0017BAA8 File Offset: 0x0017BAA8
	public static Struct35 struct35_79;

	// Token: 0x040000E1 RID: 225 RVA: 0x0017BAB0 File Offset: 0x0017BAB0
	public static Struct23 struct23_25;

	// Token: 0x040000E2 RID: 226 RVA: 0x0017BAB8 File Offset: 0x0017BAB8
	public static Struct35 struct35_80;

	// Token: 0x040000E3 RID: 227 RVA: 0x0017BAC0 File Offset: 0x0017BAC0
	public static Struct35 struct35_81;

	// Token: 0x040000E4 RID: 228 RVA: 0x0017BAC8 File Offset: 0x0017BAC8
	public static Struct23 struct23_26;

	// Token: 0x040000E5 RID: 229 RVA: 0x0017BAD0 File Offset: 0x0017BAD0
	public static Struct35 struct35_82;

	// Token: 0x040000E6 RID: 230 RVA: 0x0017BAD8 File Offset: 0x0017BAD8
	public static Struct35 struct35_83;

	// Token: 0x040000E7 RID: 231 RVA: 0x0017BAE0 File Offset: 0x0017BAE0
	public static Struct23 struct23_27;

	// Token: 0x040000E8 RID: 232 RVA: 0x0017BAE8 File Offset: 0x0017BAE8
	public static Struct35 struct35_84;

	// Token: 0x040000E9 RID: 233 RVA: 0x0017BAF0 File Offset: 0x0017BAF0
	public static Struct35 struct35_85;

	// Token: 0x040000EA RID: 234 RVA: 0x0017BAF8 File Offset: 0x0017BAF8
	public static Struct23 struct23_28;

	// Token: 0x040000EB RID: 235 RVA: 0x0017BB00 File Offset: 0x0017BB00
	public static Struct35 struct35_86;

	// Token: 0x040000EC RID: 236 RVA: 0x0017BB08 File Offset: 0x0017BB08
	public static Struct35 struct35_87;

	// Token: 0x040000ED RID: 237 RVA: 0x0017BB10 File Offset: 0x0017BB10
	public static Struct23 struct23_29;

	// Token: 0x040000EE RID: 238 RVA: 0x0017BB18 File Offset: 0x0017BB18
	public static Struct35 struct35_88;

	// Token: 0x040000EF RID: 239 RVA: 0x0017BB20 File Offset: 0x0017BB20
	public static Struct35 struct35_89;

	// Token: 0x040000F0 RID: 240 RVA: 0x0017BB28 File Offset: 0x0017BB28
	public static Struct23 struct23_30;

	// Token: 0x040000F1 RID: 241 RVA: 0x0017BB30 File Offset: 0x0017BB30
	public static Struct35 struct35_90;

	// Token: 0x040000F2 RID: 242 RVA: 0x0017BB38 File Offset: 0x0017BB38
	public static Struct35 struct35_91;

	// Token: 0x040000F3 RID: 243 RVA: 0x0017BB40 File Offset: 0x0017BB40
	public static Struct23 struct23_31;

	// Token: 0x040000F4 RID: 244 RVA: 0x0017BB48 File Offset: 0x0017BB48
	public static Struct35 struct35_92;

	// Token: 0x040000F5 RID: 245 RVA: 0x0017BB50 File Offset: 0x0017BB50
	public static Struct35 struct35_93;

	// Token: 0x040000F6 RID: 246 RVA: 0x0017BB58 File Offset: 0x0017BB58
	public static Struct23 struct23_32;

	// Token: 0x040000F7 RID: 247 RVA: 0x0017BB60 File Offset: 0x0017BB60
	public static Struct35 struct35_94;

	// Token: 0x040000F8 RID: 248 RVA: 0x0017BB68 File Offset: 0x0017BB68
	public static Struct35 struct35_95;

	// Token: 0x040000F9 RID: 249 RVA: 0x0017BB70 File Offset: 0x0017BB70
	public static Struct23 struct23_33;

	// Token: 0x040000FA RID: 250 RVA: 0x0017BB78 File Offset: 0x0017BB78
	public static Struct35 struct35_96;

	// Token: 0x040000FB RID: 251 RVA: 0x0017BB80 File Offset: 0x0017BB80
	public static Struct35 struct35_97;

	// Token: 0x040000FC RID: 252 RVA: 0x0017BB88 File Offset: 0x0017BB88
	public static Struct23 struct23_34;

	// Token: 0x040000FD RID: 253 RVA: 0x0017BB90 File Offset: 0x0017BB90
	public static Struct35 struct35_98;

	// Token: 0x040000FE RID: 254 RVA: 0x0017BB98 File Offset: 0x0017BB98
	public static Struct35 struct35_99;

	// Token: 0x040000FF RID: 255 RVA: 0x0017BBA0 File Offset: 0x0017BBA0
	public static Struct23 struct23_35;

	// Token: 0x04000100 RID: 256 RVA: 0x0017BBA8 File Offset: 0x0017BBA8
	public static Struct35 struct35_100;

	// Token: 0x04000101 RID: 257 RVA: 0x0017BBB0 File Offset: 0x0017BBB0
	public static Struct35 struct35_101;

	// Token: 0x04000102 RID: 258 RVA: 0x0017BBB8 File Offset: 0x0017BBB8
	public static Struct23 struct23_36;

	// Token: 0x04000103 RID: 259 RVA: 0x0017BBC0 File Offset: 0x0017BBC0
	public static Struct35 struct35_102;

	// Token: 0x04000104 RID: 260 RVA: 0x0017BBC8 File Offset: 0x0017BBC8
	public static Struct35 struct35_103;

	// Token: 0x04000105 RID: 261 RVA: 0x0017BBD0 File Offset: 0x0017BBD0
	public static Struct23 struct23_37;

	// Token: 0x04000106 RID: 262 RVA: 0x0017BBD8 File Offset: 0x0017BBD8
	public static Struct35 struct35_104;

	// Token: 0x04000107 RID: 263 RVA: 0x0017BBE0 File Offset: 0x0017BBE0
	public static Struct35 struct35_105;

	// Token: 0x04000108 RID: 264 RVA: 0x0017BBE8 File Offset: 0x0017BBE8
	public static Struct23 struct23_38;

	// Token: 0x04000109 RID: 265 RVA: 0x0017BBF0 File Offset: 0x0017BBF0
	public static Struct35 struct35_106;

	// Token: 0x0400010A RID: 266 RVA: 0x0017BBF8 File Offset: 0x0017BBF8
	public static Struct35 struct35_107;

	// Token: 0x0400010B RID: 267 RVA: 0x0017BC00 File Offset: 0x0017BC00
	public static Struct24 struct24_1;

	// Token: 0x0400010C RID: 268 RVA: 0x0017BC0C File Offset: 0x0017BC0C
	public static Struct24 struct24_2;

	// Token: 0x0400010D RID: 269 RVA: 0x0017BC18 File Offset: 0x0017BC18
	public static Struct25 struct25_2;

	// Token: 0x0400010E RID: 270 RVA: 0x0017BC1C File Offset: 0x0017BC1C
	public static Struct35 struct35_108;

	// Token: 0x0400010F RID: 271 RVA: 0x0017BC24 File Offset: 0x0017BC24
	public static Struct35 struct35_109;

	// Token: 0x04000110 RID: 272 RVA: 0x0017BC2C File Offset: 0x0017BC2C
	public static Struct25 struct25_3;

	// Token: 0x04000111 RID: 273 RVA: 0x0017BC30 File Offset: 0x0017BC30
	public static Struct35 struct35_110;

	// Token: 0x04000112 RID: 274 RVA: 0x0017BC38 File Offset: 0x0017BC38
	public static Struct35 struct35_111;

	// Token: 0x04000113 RID: 275 RVA: 0x0017BC40 File Offset: 0x0017BC40
	public static Struct25 struct25_4;

	// Token: 0x04000114 RID: 276 RVA: 0x0017BC44 File Offset: 0x0017BC44
	public static Struct35 struct35_112;

	// Token: 0x04000115 RID: 277 RVA: 0x0017BC4C File Offset: 0x0017BC4C
	public static Struct35 struct35_113;

	// Token: 0x04000116 RID: 278 RVA: 0x0017BC54 File Offset: 0x0017BC54
	public static Struct25 struct25_5;

	// Token: 0x04000117 RID: 279 RVA: 0x0017BC58 File Offset: 0x0017BC58
	public static Struct35 struct35_114;

	// Token: 0x04000118 RID: 280 RVA: 0x0017BC60 File Offset: 0x0017BC60
	public static Struct35 struct35_115;

	// Token: 0x04000119 RID: 281 RVA: 0x0017BC68 File Offset: 0x0017BC68
	public static Struct25 struct25_6;

	// Token: 0x0400011A RID: 282 RVA: 0x0017BC6C File Offset: 0x0017BC6C
	public static Struct35 struct35_116;

	// Token: 0x0400011B RID: 283 RVA: 0x0017BC74 File Offset: 0x0017BC74
	public static Struct35 struct35_117;

	// Token: 0x0400011C RID: 284 RVA: 0x0017BC7C File Offset: 0x0017BC7C
	public static Struct25 struct25_7;

	// Token: 0x0400011D RID: 285 RVA: 0x0017BC80 File Offset: 0x0017BC80
	public static Struct35 struct35_118;

	// Token: 0x0400011E RID: 286 RVA: 0x0017BC88 File Offset: 0x0017BC88
	public static Struct35 struct35_119;

	// Token: 0x0400011F RID: 287 RVA: 0x0017BC90 File Offset: 0x0017BC90
	public static Struct24 struct24_3;

	// Token: 0x04000120 RID: 288 RVA: 0x0017BC9C File Offset: 0x0017BC9C
	public static Struct24 struct24_4;

	// Token: 0x04000121 RID: 289 RVA: 0x0017BCA8 File Offset: 0x0017BCA8
	public static Struct35 struct35_120;

	// Token: 0x04000122 RID: 290 RVA: 0x0017BCB0 File Offset: 0x0017BCB0
	public static Struct22 struct22_1;

	// Token: 0x04000123 RID: 291 RVA: 0x0017BCB8 File Offset: 0x0017BCB8
	public static Struct7 struct7_2;

	// Token: 0x04000124 RID: 292 RVA: 0x002AEDB0 File Offset: 0x002AEDB0
	public static Struct38 struct38_0;

	// Token: 0x04000125 RID: 293 RVA: 0x002B02A8 File Offset: 0x002B02A8
	public static Struct39 struct39_0;

	// Token: 0x04000126 RID: 294 RVA: 0x002B2808 File Offset: 0x002B2808
	public static Struct40 struct40_0;

	// Token: 0x04000127 RID: 295 RVA: 0x0017BCCC File Offset: 0x0017BCCC
	public static Struct18 struct18_5;

	// Token: 0x04000128 RID: 296 RVA: 0x002B2824 File Offset: 0x002B2824
	public unsafe static GStruct14* pGstruct14_7;

	// Token: 0x04000129 RID: 297 RVA: 0x0017BCC4 File Offset: 0x0017BCC4
	unsafe static int** ppInt_5;

	// Token: 0x0400012A RID: 298 RVA: 0x0017BCC8 File Offset: 0x0017BCC8
	unsafe static int** ppInt_6;

	// Token: 0x0400012B RID: 299 RVA: 0x0017BF34 File Offset: 0x0017BF34
	public static Struct35 struct35_121;

	// Token: 0x0400012C RID: 300 RVA: 0x0017BF3C File Offset: 0x0017BF3C
	public static Struct7 struct7_3;

	// Token: 0x0400012D RID: 301 RVA: 0x0017BF48 File Offset: 0x0017BF48
	public static Struct9 struct9_2;

	// Token: 0x0400012E RID: 302 RVA: 0x0017BF74 File Offset: 0x0017BF74
	public static Struct24 struct24_5;

	// Token: 0x0400012F RID: 303 RVA: 0x0017BFD0 File Offset: 0x0017BFD0
	public static Struct18 struct18_6;

	// Token: 0x04000130 RID: 304 RVA: 0x0017BFCC File Offset: 0x0017BFCC
	public static Struct6 struct6_8;

	// Token: 0x04000131 RID: 305 RVA: 0x0017BFC8 File Offset: 0x0017BFC8
	public static Struct18 struct18_7;

	// Token: 0x04000132 RID: 306 RVA: 0x0017BFC0 File Offset: 0x0017BFC0
	public static Struct22 struct22_2;

	// Token: 0x04000133 RID: 307 RVA: 0x0017BFA4 File Offset: 0x0017BFA4
	public static Struct65 struct65_0;

	// Token: 0x04000134 RID: 308 RVA: 0x0017BFB4 File Offset: 0x0017BFB4
	public static Struct24 struct24_6;

	// Token: 0x04000135 RID: 309 RVA: 0x0017BF94 File Offset: 0x0017BF94
	public static Struct15 struct15_1;

	// Token: 0x04000136 RID: 310 RVA: 0x0017BF80 File Offset: 0x0017BF80
	public static Struct66 struct66_0;

	// Token: 0x04000137 RID: 311 RVA: 0x0017BFF0 File Offset: 0x0017BFF0
	public static Struct67 struct67_0;

	// Token: 0x04000138 RID: 312 RVA: 0x0017BFEC File Offset: 0x0017BFEC
	public static Struct25 struct25_8;

	// Token: 0x04000139 RID: 313 RVA: 0x0017BFDC File Offset: 0x0017BFDC
	public static Struct67 struct67_1;

	// Token: 0x0400013A RID: 314 RVA: 0x0017BFD4 File Offset: 0x0017BFD4
	public static Struct10 struct10_18;

	// Token: 0x0400013B RID: 315 RVA: 0x0017C008 File Offset: 0x0017C008
	public static Struct18 struct18_8;

	// Token: 0x0400013C RID: 316 RVA: 0x0017C000 File Offset: 0x0017C000
	public static Struct35 struct35_122;

	// Token: 0x0400013D RID: 317 RVA: 0x0017C014 File Offset: 0x0017C014
	public static Struct10 struct10_19;

	// Token: 0x0400013E RID: 318 RVA: 0x0017C00C File Offset: 0x0017C00C
	public static Struct23 struct23_39;

	// Token: 0x0400013F RID: 319 RVA: 0x0017C044 File Offset: 0x0017C044
	public static Struct72 struct72_0;

	// Token: 0x04000140 RID: 320 RVA: 0x0017C03C File Offset: 0x0017C03C
	public static Struct22 struct22_3;

	// Token: 0x04000141 RID: 321 RVA: 0x0017C024 File Offset: 0x0017C024
	public static Struct13 struct13_1;

	// Token: 0x04000142 RID: 322 RVA: 0x0017C01C File Offset: 0x0017C01C
	public static Struct35 struct35_123;

	// Token: 0x04000143 RID: 323 RVA: 0x0017C050 File Offset: 0x0017C050
	public static Struct18 struct18_9;

	// Token: 0x04000144 RID: 324 RVA: 0x0017C084 File Offset: 0x0017C084
	public static Struct16 struct16_4;

	// Token: 0x04000145 RID: 325 RVA: 0x0017C06C File Offset: 0x0017C06C
	public static Struct1 struct1_2;

	// Token: 0x04000146 RID: 326 RVA: 0x0017C054 File Offset: 0x0017C054
	public static Struct1 struct1_3;

	// Token: 0x04000147 RID: 327 RVA: 0x0017C5AC File Offset: 0x0017C5AC
	public static Struct9 struct9_3;

	// Token: 0x04000148 RID: 328 RVA: 0x0017C58C File Offset: 0x0017C58C
	public static Struct9 struct9_4;

	// Token: 0x04000149 RID: 329 RVA: 0x0017C580 File Offset: 0x0017C580
	public static Struct74 struct74_0;

	// Token: 0x0400014A RID: 330 RVA: 0x0017C574 File Offset: 0x0017C574
	public static Struct74 struct74_1;

	// Token: 0x0400014B RID: 331 RVA: 0x0017C568 File Offset: 0x0017C568
	public static Struct74 struct74_2;

	// Token: 0x0400014C RID: 332 RVA: 0x0017C55C File Offset: 0x0017C55C
	public static Struct74 struct74_3;

	// Token: 0x0400014D RID: 333 RVA: 0x0017C554 File Offset: 0x0017C554
	public static Struct23 struct23_40;

	// Token: 0x0400014E RID: 334 RVA: 0x0017C534 File Offset: 0x0017C534
	public static Struct9 struct9_5;

	// Token: 0x0400014F RID: 335 RVA: 0x0017C514 File Offset: 0x0017C514
	public static Struct9 struct9_6;

	// Token: 0x04000150 RID: 336 RVA: 0x0017C4F4 File Offset: 0x0017C4F4
	public static Struct9 struct9_7;

	// Token: 0x04000151 RID: 337 RVA: 0x0017C4D4 File Offset: 0x0017C4D4
	public static Struct9 struct9_8;

	// Token: 0x04000152 RID: 338 RVA: 0x0017C4B4 File Offset: 0x0017C4B4
	public static Struct9 struct9_9;

	// Token: 0x04000153 RID: 339 RVA: 0x0017C494 File Offset: 0x0017C494
	public static Struct9 struct9_10;

	// Token: 0x04000154 RID: 340 RVA: 0x0017C474 File Offset: 0x0017C474
	public static Struct9 struct9_11;

	// Token: 0x04000155 RID: 341 RVA: 0x0017C454 File Offset: 0x0017C454
	public static Struct9 struct9_12;

	// Token: 0x04000156 RID: 342 RVA: 0x0017C444 File Offset: 0x0017C444
	public static Struct15 struct15_2;

	// Token: 0x04000157 RID: 343 RVA: 0x0017C434 File Offset: 0x0017C434
	public static Struct15 struct15_3;

	// Token: 0x04000158 RID: 344 RVA: 0x0017C424 File Offset: 0x0017C424
	public static Struct15 struct15_4;

	// Token: 0x04000159 RID: 345 RVA: 0x0017C414 File Offset: 0x0017C414
	public static Struct15 struct15_5;

	// Token: 0x0400015A RID: 346 RVA: 0x0017C3F4 File Offset: 0x0017C3F4
	public static Struct9 struct9_13;

	// Token: 0x0400015B RID: 347 RVA: 0x0017C3D4 File Offset: 0x0017C3D4
	public static Struct9 struct9_14;

	// Token: 0x0400015C RID: 348 RVA: 0x0017C3B4 File Offset: 0x0017C3B4
	public static Struct9 struct9_15;

	// Token: 0x0400015D RID: 349 RVA: 0x0017C394 File Offset: 0x0017C394
	public static Struct9 struct9_16;

	// Token: 0x0400015E RID: 350 RVA: 0x0017C374 File Offset: 0x0017C374
	public static Struct9 struct9_17;

	// Token: 0x0400015F RID: 351 RVA: 0x0017C354 File Offset: 0x0017C354
	public static Struct9 struct9_18;

	// Token: 0x04000160 RID: 352 RVA: 0x0017C334 File Offset: 0x0017C334
	public static Struct9 struct9_19;

	// Token: 0x04000161 RID: 353 RVA: 0x0017C314 File Offset: 0x0017C314
	public static Struct9 struct9_20;

	// Token: 0x04000162 RID: 354 RVA: 0x0017C2F4 File Offset: 0x0017C2F4
	public static Struct9 struct9_21;

	// Token: 0x04000163 RID: 355 RVA: 0x0017C2D4 File Offset: 0x0017C2D4
	public static Struct9 struct9_22;

	// Token: 0x04000164 RID: 356 RVA: 0x0017C2B4 File Offset: 0x0017C2B4
	public static Struct9 struct9_23;

	// Token: 0x04000165 RID: 357 RVA: 0x0017C2A4 File Offset: 0x0017C2A4
	public static Struct65 struct65_1;

	// Token: 0x04000166 RID: 358 RVA: 0x0017C294 File Offset: 0x0017C294
	public static Struct65 struct65_2;

	// Token: 0x04000167 RID: 359 RVA: 0x0017C28C File Offset: 0x0017C28C
	public static Struct22 struct22_4;

	// Token: 0x04000168 RID: 360 RVA: 0x0017C280 File Offset: 0x0017C280
	public static Struct72 struct72_1;

	// Token: 0x04000169 RID: 361 RVA: 0x0017C260 File Offset: 0x0017C260
	public static Struct9 struct9_24;

	// Token: 0x0400016A RID: 362 RVA: 0x0017C254 File Offset: 0x0017C254
	public static Struct72 struct72_2;

	// Token: 0x0400016B RID: 363 RVA: 0x0017C248 File Offset: 0x0017C248
	public static Struct72 struct72_3;

	// Token: 0x0400016C RID: 364 RVA: 0x0017C23C File Offset: 0x0017C23C
	public static Struct72 struct72_4;

	// Token: 0x0400016D RID: 365 RVA: 0x0017C21C File Offset: 0x0017C21C
	public static Struct9 struct9_25;

	// Token: 0x0400016E RID: 366 RVA: 0x0017C210 File Offset: 0x0017C210
	public static Struct24 struct24_7;

	// Token: 0x0400016F RID: 367 RVA: 0x0017C1F0 File Offset: 0x0017C1F0
	public static Struct9 struct9_26;

	// Token: 0x04000170 RID: 368 RVA: 0x0017C1D0 File Offset: 0x0017C1D0
	public static Struct9 struct9_27;

	// Token: 0x04000171 RID: 369 RVA: 0x0017C1B0 File Offset: 0x0017C1B0
	public static Struct9 struct9_28;

	// Token: 0x04000172 RID: 370 RVA: 0x0017C1A4 File Offset: 0x0017C1A4
	public static Struct7 struct7_4;

	// Token: 0x04000173 RID: 371 RVA: 0x0017C190 File Offset: 0x0017C190
	public static Struct0 struct0_1;

	// Token: 0x04000174 RID: 372 RVA: 0x0017C17C File Offset: 0x0017C17C
	public static Struct0 struct0_2;

	// Token: 0x04000175 RID: 373 RVA: 0x0017C158 File Offset: 0x0017C158
	public static Struct75 struct75_0;

	// Token: 0x04000176 RID: 374 RVA: 0x0017C134 File Offset: 0x0017C134
	public static Struct75 struct75_1;

	// Token: 0x04000177 RID: 375 RVA: 0x0017C110 File Offset: 0x0017C110
	public static Struct75 struct75_2;

	// Token: 0x04000178 RID: 376 RVA: 0x0017C100 File Offset: 0x0017C100
	public static Struct65 struct65_3;

	// Token: 0x04000179 RID: 377 RVA: 0x0017C0F0 File Offset: 0x0017C0F0
	public static Struct65 struct65_4;

	// Token: 0x0400017A RID: 378 RVA: 0x0017C0E0 File Offset: 0x0017C0E0
	public static Struct65 struct65_5;

	// Token: 0x0400017B RID: 379 RVA: 0x0017C0D0 File Offset: 0x0017C0D0
	public static Struct65 struct65_6;

	// Token: 0x0400017C RID: 380 RVA: 0x0017C0C0 File Offset: 0x0017C0C0
	public static Struct65 struct65_7;

	// Token: 0x0400017D RID: 381 RVA: 0x0017C0B0 File Offset: 0x0017C0B0
	public static Struct65 struct65_8;

	// Token: 0x0400017E RID: 382 RVA: 0x0017C0A8 File Offset: 0x0017C0A8
	public static Struct35 struct35_124;

	// Token: 0x0400017F RID: 383 RVA: 0x0017C0A4 File Offset: 0x0017C0A4
	public static Struct18 struct18_10;

	// Token: 0x04000180 RID: 384 RVA: 0x0017C0A0 File Offset: 0x0017C0A0
	public static Struct25 struct25_9;

	// Token: 0x04000181 RID: 385 RVA: 0x0017C098 File Offset: 0x0017C098
	public static Struct10 struct10_20;

	// Token: 0x04000182 RID: 386 RVA: 0x0017C5DC File Offset: 0x0017C5DC
	public static Struct35 struct35_125;

	// Token: 0x04000183 RID: 387 RVA: 0x0017C5D4 File Offset: 0x0017C5D4
	public static Struct10 struct10_21;

	// Token: 0x04000184 RID: 388 RVA: 0x0017C5E4 File Offset: 0x0017C5E4
	public static Struct18 struct18_11;

	// Token: 0x04000185 RID: 389 RVA: 0x0017C5E8 File Offset: 0x0017C5E8
	public static Struct10 struct10_22;

	// Token: 0x04000186 RID: 390 RVA: 0x0017C5F0 File Offset: 0x0017C5F0
	public static Struct10 struct10_23;

	// Token: 0x04000187 RID: 391 RVA: 0x0017C5F8 File Offset: 0x0017C5F8
	public static Struct96 struct96_0;

	// Token: 0x04000188 RID: 392 RVA: 0x0017C670 File Offset: 0x0017C670
	public static Struct24 struct24_8;

	// Token: 0x04000189 RID: 393 RVA: 0x0017C6D0 File Offset: 0x0017C6D0
	public static Struct66 struct66_1;

	// Token: 0x0400018A RID: 394 RVA: 0x0017C6B8 File Offset: 0x0017C6B8
	public static Struct13 struct13_2;

	// Token: 0x0400018B RID: 395 RVA: 0x0017C6A8 File Offset: 0x0017C6A8
	public static Struct15 struct15_6;

	// Token: 0x0400018C RID: 396 RVA: 0x0017C698 File Offset: 0x0017C698
	public static Struct65 struct65_9;

	// Token: 0x0400018D RID: 397 RVA: 0x0017C688 File Offset: 0x0017C688
	public static Struct15 struct15_7;

	// Token: 0x0400018E RID: 398 RVA: 0x0017C67C File Offset: 0x0017C67C
	public static Struct74 struct74_4;

	// Token: 0x0400018F RID: 399 RVA: 0x0017C79C File Offset: 0x0017C79C
	public static Struct25 struct25_10;

	// Token: 0x04000190 RID: 400 RVA: 0x0017C790 File Offset: 0x0017C790
	public static Struct24 struct24_9;

	// Token: 0x04000191 RID: 401 RVA: 0x0017C778 File Offset: 0x0017C778
	public static Struct97 struct97_0;

	// Token: 0x04000192 RID: 402 RVA: 0x0017C760 File Offset: 0x0017C760
	public static Struct97 struct97_1;

	// Token: 0x04000193 RID: 403 RVA: 0x0017C750 File Offset: 0x0017C750
	public static Struct98 struct98_0;

	// Token: 0x04000194 RID: 404 RVA: 0x0017C738 File Offset: 0x0017C738
	public static Struct1 struct1_4;

	// Token: 0x04000195 RID: 405 RVA: 0x0017C724 File Offset: 0x0017C724
	public static Struct66 struct66_2;

	// Token: 0x04000196 RID: 406 RVA: 0x0017C710 File Offset: 0x0017C710
	public static Struct66 struct66_3;

	// Token: 0x04000197 RID: 407 RVA: 0x0017C6F4 File Offset: 0x0017C6F4
	public static Struct99 struct99_0;

	// Token: 0x04000198 RID: 408 RVA: 0x0017C6E4 File Offset: 0x0017C6E4
	public static Struct15 struct15_8;

	// Token: 0x04000199 RID: 409 RVA: 0x0017C7A0 File Offset: 0x0017C7A0
	public static Struct72 struct72_5;

	// Token: 0x0400019A RID: 410 RVA: 0x0017C7C0 File Offset: 0x0017C7C0
	public static Struct67 struct67_2;

	// Token: 0x0400019B RID: 411 RVA: 0x0017C7AC File Offset: 0x0017C7AC
	public static Struct0 struct0_3;

	// Token: 0x0400019C RID: 412 RVA: 0x0017C808 File Offset: 0x0017C808
	public static Struct35 struct35_126;

	// Token: 0x0400019D RID: 413 RVA: 0x0017C800 File Offset: 0x0017C800
	public static Struct35 struct35_127;

	// Token: 0x0400019E RID: 414 RVA: 0x0017C7F8 File Offset: 0x0017C7F8
	public static Struct35 struct35_128;

	// Token: 0x0400019F RID: 415 RVA: 0x0017C7EC File Offset: 0x0017C7EC
	public static Struct7 struct7_5;

	// Token: 0x040001A0 RID: 416 RVA: 0x0017C7E0 File Offset: 0x0017C7E0
	public static Struct7 struct7_6;

	// Token: 0x040001A1 RID: 417 RVA: 0x0017C7D8 File Offset: 0x0017C7D8
	public static Struct10 struct10_24;

	// Token: 0x040001A2 RID: 418 RVA: 0x0017C7D0 File Offset: 0x0017C7D0
	public static Struct10 struct10_25;

	// Token: 0x040001A3 RID: 419 RVA: 0x0017C810 File Offset: 0x0017C810
	public static Struct6 struct6_9;

	// Token: 0x040001A4 RID: 420 RVA: 0x0017C814 File Offset: 0x0017C814
	public static Struct97 struct97_2;

	// Token: 0x040001A5 RID: 421 RVA: 0x0017C82C File Offset: 0x0017C82C
	public static Struct35 struct35_129;

	// Token: 0x040001A6 RID: 422 RVA: 0x0017C83C File Offset: 0x0017C83C
	public static Struct35 struct35_130;

	// Token: 0x040001A7 RID: 423 RVA: 0x0017C834 File Offset: 0x0017C834
	public static Struct35 struct35_131;

	// Token: 0x040001A8 RID: 424 RVA: 0x0017C84C File Offset: 0x0017C84C
	public static Struct35 struct35_132;

	// Token: 0x040001A9 RID: 425 RVA: 0x0017C844 File Offset: 0x0017C844
	public static Struct35 struct35_133;

	// Token: 0x040001AA RID: 426 RVA: 0x0017C854 File Offset: 0x0017C854
	public static Struct22 struct22_5;

	// Token: 0x040001AB RID: 427 RVA: 0x0017C85C File Offset: 0x0017C85C
	public static Struct14 struct14_1;

	// Token: 0x040001AC RID: 428 RVA: 0x0017C870 File Offset: 0x0017C870
	public static Struct14 struct14_2;

	// Token: 0x040001AD RID: 429 RVA: 0x0017C884 File Offset: 0x0017C884
	public static Struct25 struct25_11;

	// Token: 0x040001AE RID: 430 RVA: 0x0017C894 File Offset: 0x0017C894
	public static Struct18 struct18_12;

	// Token: 0x040001AF RID: 431 RVA: 0x0017C888 File Offset: 0x0017C888
	public static Struct24 struct24_10;

	// Token: 0x040001B0 RID: 432 RVA: 0x0017C898 File Offset: 0x0017C898
	public static Struct114 struct114_0;

	// Token: 0x040001B1 RID: 433 RVA: 0x0017C8F4 File Offset: 0x0017C8F4
	public static Struct74 struct74_5;

	// Token: 0x040001B2 RID: 434 RVA: 0x0017C910 File Offset: 0x0017C910
	public static Struct98 struct98_1;

	// Token: 0x040001B3 RID: 435 RVA: 0x0017C900 File Offset: 0x0017C900
	public static Struct65 struct65_10;

	// Token: 0x040001B4 RID: 436 RVA: 0x0017C930 File Offset: 0x0017C930
	public static Struct65 struct65_11;

	// Token: 0x040001B5 RID: 437 RVA: 0x0017C920 File Offset: 0x0017C920
	public static Struct67 struct67_3;

	// Token: 0x040001B6 RID: 438 RVA: 0x0017BE60 File Offset: 0x0017BE60
	public static Struct118 struct118_0;

	// Token: 0x040001B7 RID: 439 RVA: 0x0017BE88 File Offset: 0x0017BE88
	public static Struct12 struct12_6;

	// Token: 0x040001B8 RID: 440 RVA: 0x0017BEA4 File Offset: 0x0017BEA4
	public static Struct9 struct9_29;

	// Token: 0x040001B9 RID: 441 RVA: 0x0017BEC4 File Offset: 0x0017BEC4
	public static Struct26 struct26_1;

	// Token: 0x040001BA RID: 442 RVA: 0x0017BEEC File Offset: 0x0017BEEC
	public static Struct16 struct16_5;

	// Token: 0x040001BB RID: 443 RVA: 0x0017BF00 File Offset: 0x0017BF00
	public static Struct16 struct16_6;

	// Token: 0x040001BC RID: 444 RVA: 0x0017BF14 File Offset: 0x0017BF14
	public static Struct16 struct16_7;

	// Token: 0x040001BD RID: 445 RVA: 0x002626F0 File Offset: 0x002626F0
	public static Struct29 struct29_0;

	// Token: 0x040001BE RID: 446 RVA: 0x002B2FDC File Offset: 0x002B2FDC
	public unsafe static GStruct14* pGstruct14_8;

	// Token: 0x040001BF RID: 447 RVA: 0x00263518 File Offset: 0x00263518
	public static Struct52 struct52_0;

	// Token: 0x040001C0 RID: 448 RVA: 0x0026350C File Offset: 0x0026350C
	public static Struct52 struct52_1;

	// Token: 0x040001C1 RID: 449 RVA: 0x002611C8 File Offset: 0x002611C8
	public static Struct29 struct29_1;

	// Token: 0x040001C2 RID: 450 RVA: 0x00312E10 File Offset: 0x00312E10
	public static Struct119 struct119_0;

	// Token: 0x040001C3 RID: 451 RVA: 0x00260F98 File Offset: 0x00260F98
	public static Struct29 struct29_2;

	// Token: 0x040001C4 RID: 452 RVA: 0x002601C0 File Offset: 0x002601C0
	public static Struct46 struct46_0;

	// Token: 0x040001C5 RID: 453 RVA: 0x00260DC8 File Offset: 0x00260DC8
	public static Struct47 struct47_0;

	// Token: 0x040001C6 RID: 454 RVA: 0x002603F0 File Offset: 0x002603F0
	public static Struct46 struct46_1;

	// Token: 0x040001C7 RID: 455 RVA: 0x00260738 File Offset: 0x00260738
	public static Struct47 struct47_1;

	// Token: 0x040001C8 RID: 456 RVA: 0x00261A88 File Offset: 0x00261A88
	public static Struct29 struct29_3;

	// Token: 0x040001C9 RID: 457 RVA: 0x00312F98 File Offset: 0x00312F98
	public static Struct120 struct120_0;

	// Token: 0x040001CA RID: 458 RVA: 0x002650D8 File Offset: 0x002650D8
	public static Struct29 struct29_4;

	// Token: 0x040001CB RID: 459 RVA: 0x00262178 File Offset: 0x00262178
	public static Struct29 struct29_5;

	// Token: 0x040001CC RID: 460 RVA: 0x00265DF8 File Offset: 0x00265DF8
	public static Struct43 struct43_0;

	// Token: 0x040001CD RID: 461 RVA: 0x00264D18 File Offset: 0x00264D18
	public static Struct43 struct43_1;

	// Token: 0x040001CE RID: 462 RVA: 0x00262520 File Offset: 0x00262520
	public static Struct46 struct46_2;

	// Token: 0x040001CF RID: 463 RVA: 0x00262A38 File Offset: 0x00262A38
	public static Struct29 struct29_6;

	// Token: 0x040001D0 RID: 464 RVA: 0x00263380 File Offset: 0x00263380
	public static Struct45 struct45_0;

	// Token: 0x040001D1 RID: 465 RVA: 0x00263E28 File Offset: 0x00263E28
	public static Struct42 struct42_0;

	// Token: 0x040001D2 RID: 466 RVA: 0x002625D8 File Offset: 0x002625D8
	public static Struct29 struct29_7;

	// Token: 0x040001D3 RID: 467 RVA: 0x002658F8 File Offset: 0x002658F8
	public static Struct43 struct43_2;

	// Token: 0x040001D4 RID: 468 RVA: 0x002620C0 File Offset: 0x002620C0
	public static Struct46 struct46_3;

	// Token: 0x040001D5 RID: 469 RVA: 0x00260B98 File Offset: 0x00260B98
	public static Struct47 struct47_2;

	// Token: 0x040001D6 RID: 470 RVA: 0x00260278 File Offset: 0x00260278
	public static Struct29 struct29_8;

	// Token: 0x040001D7 RID: 471 RVA: 0x00262B50 File Offset: 0x00262B50
	public static Struct29 struct29_9;

	// Token: 0x040001D8 RID: 472 RVA: 0x00261858 File Offset: 0x00261858
	public static Struct29 struct29_10;

	// Token: 0x040001D9 RID: 473 RVA: 0x00264190 File Offset: 0x00264190
	public static Struct17 struct17_0;

	// Token: 0x040001DA RID: 474 RVA: 0x00263E4C File Offset: 0x00263E4C
	public static Struct60 struct60_0;

	// Token: 0x040001DB RID: 475 RVA: 0x00262F00 File Offset: 0x00262F00
	public static Struct45 struct45_1;

	// Token: 0x040001DC RID: 476 RVA: 0x00263524 File Offset: 0x00263524
	public static Struct48 struct48_0;

	// Token: 0x040001DD RID: 477 RVA: 0x002657F8 File Offset: 0x002657F8
	public static Struct43 struct43_3;

	// Token: 0x040001DE RID: 478 RVA: 0x00262BB0 File Offset: 0x00262BB0
	public static Struct46 struct46_4;

	// Token: 0x040001DF RID: 479 RVA: 0x00265CF8 File Offset: 0x00265CF8
	public static Struct43 struct43_4;

	// Token: 0x040001E0 RID: 480 RVA: 0x00261E90 File Offset: 0x00261E90
	public static Struct46 struct46_5;

	// Token: 0x040001E1 RID: 481 RVA: 0x00261458 File Offset: 0x00261458
	public static Struct47 struct47_3;

	// Token: 0x040001E2 RID: 482 RVA: 0x002656F8 File Offset: 0x002656F8
	public static Struct43 struct43_5;

	// Token: 0x040001E3 RID: 483 RVA: 0x002B6D8C File Offset: 0x002B6D8C
	public unsafe static GStruct14* pGstruct14_9;

	// Token: 0x040001E4 RID: 484 RVA: 0x00269C08 File Offset: 0x00269C08
	public static Struct49 struct49_0;

	// Token: 0x040001E5 RID: 485 RVA: 0x00261228 File Offset: 0x00261228
	public static Struct47 struct47_4;

	// Token: 0x040001E6 RID: 486 RVA: 0x00265AF8 File Offset: 0x00265AF8
	public static Struct43 struct43_6;

	// Token: 0x040001E7 RID: 487 RVA: 0x002646D8 File Offset: 0x002646D8
	public static Struct43 struct43_7;

	// Token: 0x040001E8 RID: 488 RVA: 0x00262638 File Offset: 0x00262638
	public static Struct46 struct46_6;

	// Token: 0x040001E9 RID: 489 RVA: 0x00260968 File Offset: 0x00260968
	public static Struct47 struct47_5;

	// Token: 0x040001EA RID: 490 RVA: 0x002604A8 File Offset: 0x002604A8
	public static Struct29 struct29_11;

	// Token: 0x040001EB RID: 491 RVA: 0x00264A58 File Offset: 0x00264A58
	public static Struct43 struct43_8;

	// Token: 0x040001EC RID: 492 RVA: 0x00263DE8 File Offset: 0x00263DE8
	public static Struct4 struct4_0;

	// Token: 0x040001ED RID: 493 RVA: 0x00265238 File Offset: 0x00265238
	public static Struct29 struct29_12;

	// Token: 0x040001EE RID: 494 RVA: 0x00265EF8 File Offset: 0x00265EF8
	public static Struct61 struct61_0;

	// Token: 0x040001EF RID: 495 RVA: 0x00266618 File Offset: 0x00266618
	public static Struct50 struct50_0;

	// Token: 0x040001F0 RID: 496 RVA: 0x00260508 File Offset: 0x00260508
	public static Struct47 struct47_6;

	// Token: 0x040001F1 RID: 497 RVA: 0x00263200 File Offset: 0x00263200
	public static Struct45 struct45_2;

	// Token: 0x040001F2 RID: 498 RVA: 0x00264E78 File Offset: 0x00264E78
	public static Struct43 struct43_9;

	// Token: 0x040001F3 RID: 499 RVA: 0x002649F8 File Offset: 0x002649F8
	public static Struct29 struct29_13;

	// Token: 0x040001F4 RID: 500 RVA: 0x00267018 File Offset: 0x00267018
	public static Struct53 struct53_0;

	// Token: 0x040001F5 RID: 501 RVA: 0x002659F8 File Offset: 0x002659F8
	public static Struct43 struct43_10;

	// Token: 0x040001F6 RID: 502 RVA: 0x00261F48 File Offset: 0x00261F48
	public static Struct47 struct47_7;

	// Token: 0x040001F7 RID: 503 RVA: 0x00265398 File Offset: 0x00265398
	public static Struct29 struct29_14;

	// Token: 0x040001F8 RID: 504 RVA: 0x00261570 File Offset: 0x00261570
	public static Struct46 struct46_7;

	// Token: 0x040001F9 RID: 505 RVA: 0x00262CC8 File Offset: 0x00262CC8
	public static Struct46 struct46_8;

	// Token: 0x040001FA RID: 506 RVA: 0x00265138 File Offset: 0x00265138
	public static Struct43 struct43_11;

	// Token: 0x040001FB RID: 507 RVA: 0x00260D68 File Offset: 0x00260D68
	public static Struct29 struct29_15;

	// Token: 0x040001FC RID: 508 RVA: 0x00262C68 File Offset: 0x00262C68
	public static Struct29 struct29_16;

	// Token: 0x040001FD RID: 509 RVA: 0x002602D8 File Offset: 0x002602D8
	public static Struct47 struct47_8;

	// Token: 0x040001FE RID: 510 RVA: 0x002653F8 File Offset: 0x002653F8
	public static Struct43 struct43_12;

	// Token: 0x040001FF RID: 511 RVA: 0x00262D80 File Offset: 0x00262D80
	public static Struct45 struct45_3;

	// Token: 0x04000200 RID: 512 RVA: 0x002643D8 File Offset: 0x002643D8
	public static Struct43 struct43_13;

	// Token: 0x04000201 RID: 513 RVA: 0x00264998 File Offset: 0x00264998
	public static Struct29 struct29_17;

	// Token: 0x04000202 RID: 514 RVA: 0x00261AE8 File Offset: 0x00261AE8
	public static Struct47 struct47_9;

	// Token: 0x04000203 RID: 515 RVA: 0x00260FF8 File Offset: 0x00260FF8
	public static Struct47 struct47_10;

	// Token: 0x04000204 RID: 516 RVA: 0x00260850 File Offset: 0x00260850
	public static Struct46 struct46_9;

	// Token: 0x04000205 RID: 517 RVA: 0x00264CB8 File Offset: 0x00264CB8
	public static Struct29 struct29_18;

	// Token: 0x04000206 RID: 518 RVA: 0x00266570 File Offset: 0x00266570
	public static Struct31 struct31_0;

	// Token: 0x04000207 RID: 519 RVA: 0x00261340 File Offset: 0x00261340
	public static Struct46 struct46_10;

	// Token: 0x04000208 RID: 520 RVA: 0x00262808 File Offset: 0x00262808
	public static Struct29 struct29_19;

	// Token: 0x04000209 RID: 521 RVA: 0x00264B58 File Offset: 0x00264B58
	public static Struct29 struct29_20;

	// Token: 0x0400020A RID: 522 RVA: 0x00261CB8 File Offset: 0x00261CB8
	public static Struct29 struct29_21;

	// Token: 0x0400020B RID: 523 RVA: 0x002647D8 File Offset: 0x002647D8
	public static Struct43 struct43_14;

	// Token: 0x0400020C RID: 524 RVA: 0x00301338 File Offset: 0x00301338
	public unsafe static GStruct14* pGstruct14_10;

	// Token: 0x0400020D RID: 525 RVA: 0x00301344 File Offset: 0x00301344
	public unsafe static GStruct14* pGstruct14_11;

	// Token: 0x0400020E RID: 526 RVA: 0x002645D8 File Offset: 0x002645D8
	public static Struct43 struct43_15;

	// Token: 0x0400020F RID: 527 RVA: 0x00264F78 File Offset: 0x00264F78
	public static Struct29 struct29_22;

	// Token: 0x04000210 RID: 528 RVA: 0x00264E18 File Offset: 0x00264E18
	public static Struct29 struct29_23;

	// Token: 0x04000211 RID: 529 RVA: 0x002618B8 File Offset: 0x002618B8
	public static Struct47 struct47_11;

	// Token: 0x04000212 RID: 530 RVA: 0x00261C00 File Offset: 0x00261C00
	public static Struct46 struct46_11;

	// Token: 0x04000213 RID: 531 RVA: 0x00262290 File Offset: 0x00262290
	public static Struct29 struct29_24;

	// Token: 0x04000214 RID: 532 RVA: 0x00263534 File Offset: 0x00263534
	public static Struct55 struct55_0;

	// Token: 0x04000215 RID: 533 RVA: 0x00263E3C File Offset: 0x00263E3C
	public static Struct28 struct28_0;

	// Token: 0x04000216 RID: 534 RVA: 0x00260908 File Offset: 0x00260908
	public static Struct29 struct29_25;

	// Token: 0x04000217 RID: 535 RVA: 0x00263558 File Offset: 0x00263558
	public static Struct54 struct54_0;

	// Token: 0x04000218 RID: 536 RVA: 0x002641D8 File Offset: 0x002641D8
	public static Struct43 struct43_16;

	// Token: 0x04000219 RID: 537 RVA: 0x002619D0 File Offset: 0x002619D0
	public static Struct46 struct46_12;

	// Token: 0x0400021A RID: 538 RVA: 0x00262750 File Offset: 0x00262750
	public static Struct46 struct46_13;

	// Token: 0x0400021B RID: 539 RVA: 0x00264938 File Offset: 0x00264938
	public static Struct29 struct29_26;

	// Token: 0x0400021C RID: 540 RVA: 0x002622F0 File Offset: 0x002622F0
	public static Struct46 struct46_14;

	// Token: 0x0400021D RID: 541 RVA: 0x00261628 File Offset: 0x00261628
	public static Struct29 struct29_27;

	// Token: 0x0400021E RID: 542 RVA: 0x00262408 File Offset: 0x00262408
	public static Struct46 struct46_15;

	// Token: 0x0400021F RID: 543 RVA: 0x00313798 File Offset: 0x00313798
	public static Struct120 struct120_1;

	// Token: 0x04000220 RID: 544 RVA: 0x00268218 File Offset: 0x00268218
	public static Struct58 struct58_0;

	// Token: 0x04000221 RID: 545 RVA: 0x00265BF8 File Offset: 0x00265BF8
	public static Struct43 struct43_17;

	// Token: 0x04000222 RID: 546 RVA: 0x00261688 File Offset: 0x00261688
	public static Struct47 struct47_12;

	// Token: 0x04000223 RID: 547 RVA: 0x00262868 File Offset: 0x00262868
	public static Struct46 struct46_16;

	// Token: 0x04000224 RID: 548 RVA: 0x00262920 File Offset: 0x00262920
	public static Struct29 struct29_28;

	// Token: 0x04000225 RID: 549 RVA: 0x00264FD8 File Offset: 0x00264FD8
	public static Struct43 struct43_18;

	// Token: 0x04000226 RID: 550 RVA: 0x00263E80 File Offset: 0x00263E80
	public static Struct51 struct51_0;

	// Token: 0x04000227 RID: 551 RVA: 0x00260CB0 File Offset: 0x00260CB0
	public static Struct46 struct46_17;

	// Token: 0x04000228 RID: 552 RVA: 0x002655F8 File Offset: 0x002655F8
	public static Struct43 struct43_19;

	// Token: 0x04000229 RID: 553 RVA: 0x00262980 File Offset: 0x00262980
	public static Struct46 struct46_18;

	// Token: 0x0400022A RID: 554 RVA: 0x002617A0 File Offset: 0x002617A0
	public static Struct46 struct46_19;

	// Token: 0x0400022B RID: 555 RVA: 0x0030CEA0 File Offset: 0x0030CEA0
	public unsafe static GStruct14* pGstruct14_12;

	// Token: 0x0400022C RID: 556 RVA: 0x00260EE0 File Offset: 0x00260EE0
	public static Struct46 struct46_20;

	// Token: 0x0400022D RID: 557 RVA: 0x002613F8 File Offset: 0x002613F8
	public static Struct29 struct29_29;

	// Token: 0x0400022E RID: 558 RVA: 0x00264BB8 File Offset: 0x00264BB8
	public static Struct43 struct43_20;

	// Token: 0x0400022F RID: 559 RVA: 0x00262A98 File Offset: 0x00262A98
	public static Struct46 struct46_21;

	// Token: 0x04000230 RID: 560 RVA: 0x00262060 File Offset: 0x00262060
	public static Struct29 struct29_30;

	// Token: 0x04000231 RID: 561 RVA: 0x00263080 File Offset: 0x00263080
	public static Struct45 struct45_4;

	// Token: 0x04000232 RID: 562 RVA: 0x002654F8 File Offset: 0x002654F8
	public static Struct43 struct43_21;

	// Token: 0x04000233 RID: 563 RVA: 0x002623A8 File Offset: 0x002623A8
	public static Struct29 struct29_31;

	// Token: 0x04000234 RID: 564 RVA: 0x00268E10 File Offset: 0x00268E10
	public static Struct56 struct56_0;

	// Token: 0x04000235 RID: 565 RVA: 0x002648D8 File Offset: 0x002648D8
	public static Struct29 struct29_32;

	// Token: 0x04000236 RID: 566 RVA: 0x00312C88 File Offset: 0x00312C88
	public static Struct119 struct119_1;

	// Token: 0x04000237 RID: 567 RVA: 0x00263E50 File Offset: 0x00263E50
	public static Struct34 struct34_0;

	// Token: 0x04000238 RID: 568 RVA: 0x002665C0 File Offset: 0x002665C0
	public static Struct59 struct59_0;

	// Token: 0x04000239 RID: 569 RVA: 0x00260620 File Offset: 0x00260620
	public static Struct46 struct46_22;

	// Token: 0x0400023A RID: 570 RVA: 0x002644D8 File Offset: 0x002644D8
	public static Struct43 struct43_22;

	// Token: 0x0400023B RID: 571 RVA: 0x00265298 File Offset: 0x00265298
	public static Struct43 struct43_23;

	// Token: 0x0400023C RID: 572 RVA: 0x00260A80 File Offset: 0x00260A80
	public static Struct46 struct46_23;

	// Token: 0x0400023D RID: 573 RVA: 0x002624C0 File Offset: 0x002624C0
	public static Struct29 struct29_33;

	// Token: 0x0400023E RID: 574 RVA: 0x002621D8 File Offset: 0x002621D8
	public static Struct46 struct46_24;

	// Token: 0x0400023F RID: 575 RVA: 0x00266518 File Offset: 0x00266518
	public static Struct59 struct59_1;

	// Token: 0x04000240 RID: 576 RVA: 0x002606D8 File Offset: 0x002606D8
	public static Struct29 struct29_34;

	// Token: 0x04000241 RID: 577 RVA: 0x002641A4 File Offset: 0x002641A4
	public static Struct34 struct34_1;

	// Token: 0x04000242 RID: 578 RVA: 0x00261110 File Offset: 0x00261110
	public static Struct46 struct46_25;

	// Token: 0x04000243 RID: 579 RVA: 0x002642D8 File Offset: 0x002642D8
	public static Struct43 struct43_24;

	// Token: 0x04000244 RID: 580 RVA: 0x00261E30 File Offset: 0x00261E30
	public static Struct29 struct29_35;

	// Token: 0x04000245 RID: 581 RVA: 0x00263500 File Offset: 0x00263500
	public static Struct52 struct52_2;

	// Token: 0x04000246 RID: 582 RVA: 0x002635A8 File Offset: 0x002635A8
	public static Struct44 struct44_0;

	// Token: 0x04000247 RID: 583 RVA: 0x00261D18 File Offset: 0x00261D18
	public static Struct47 struct47_13;

	// Token: 0x04000248 RID: 584 RVA: 0x00263A18 File Offset: 0x00263A18
	public static Struct57 struct57_0;

	// Token: 0x04000249 RID: 585 RVA: 0x00260B38 File Offset: 0x00260B38
	public static Struct29 struct29_36;

	// Token: 0x0400024A RID: 586 RVA: 0x0017BF28 File Offset: 0x0017BF28
	unsafe static int** ppInt_7;

	// Token: 0x0400024B RID: 587 RVA: 0x0017BF2C File Offset: 0x0017BF2C
	unsafe static int** ppInt_8;

	// Token: 0x0400024C RID: 588 RVA: 0x0017BF30 File Offset: 0x0017BF30
	unsafe static int** ppInt_9;

	// Token: 0x0400024D RID: 589 RVA: 0x0017BF68 File Offset: 0x0017BF68
	unsafe static int** ppInt_10;

	// Token: 0x0400024E RID: 590 RVA: 0x0017BF6C File Offset: 0x0017BF6C
	unsafe static int** ppInt_11;

	// Token: 0x0400024F RID: 591 RVA: 0x0017BF70 File Offset: 0x0017BF70
	unsafe static int** ppInt_12;

	// Token: 0x04000250 RID: 592 RVA: 0x0017C5CC File Offset: 0x0017C5CC
	unsafe static int** ppInt_13;

	// Token: 0x04000251 RID: 593 RVA: 0x0017C5D0 File Offset: 0x0017C5D0
	public unsafe static int** ppInt_14;

	// Token: 0x04000252 RID: 594 RVA: 0x00318A9C File Offset: 0x00318A9C
	public unsafe static GStruct14* pGstruct14_13;

	// Token: 0x04000253 RID: 595 RVA: 0x0017C940 File Offset: 0x0017C940
	unsafe static int** ppInt_15;

	// Token: 0x04000254 RID: 596 RVA: 0x0017C944 File Offset: 0x0017C944
	unsafe static int** ppInt_16;

	// Token: 0x04000255 RID: 597 RVA: 0x0031A3B0 File Offset: 0x0031A3B0
	public unsafe static GStruct14* pGstruct14_14;

	// Token: 0x04000256 RID: 598 RVA: 0x0017C948 File Offset: 0x0017C948
	unsafe static int** ppInt_17;

	// Token: 0x04000257 RID: 599 RVA: 0x0017C94C File Offset: 0x0017C94C
	unsafe static int** ppInt_18;

	// Token: 0x04000258 RID: 600 RVA: 0x0026A798 File Offset: 0x0026A798
	public static Struct4 struct4_1;

	// Token: 0x04000259 RID: 601 RVA: 0x0017C950 File Offset: 0x0017C950
	unsafe static int** ppInt_19;

	// Token: 0x0400025A RID: 602 RVA: 0x0017CAB8 File Offset: 0x0017CAB8
	public static Struct19 struct19_1;

	// Token: 0x0400025B RID: 603 RVA: 0x0017CABC File Offset: 0x0017CABC
	public static Struct35 struct35_134;

	// Token: 0x0400025C RID: 604 RVA: 0x0017CAC4 File Offset: 0x0017CAC4
	public static Struct18 struct18_13;

	// Token: 0x0400025D RID: 605 RVA: 0x0017CAC8 File Offset: 0x0017CAC8
	public static Struct18 struct18_14;

	// Token: 0x0400025E RID: 606 RVA: 0x0017CACC File Offset: 0x0017CACC
	public static Struct18 struct18_15;

	// Token: 0x0400025F RID: 607 RVA: 0x0017CAD0 File Offset: 0x0017CAD0
	unsafe static int** ppInt_20;

	// Token: 0x04000260 RID: 608 RVA: 0x0017CAD4 File Offset: 0x0017CAD4
	public static Struct24 struct24_11;

	// Token: 0x04000261 RID: 609 RVA: 0x0017CAE0 File Offset: 0x0017CAE0
	public static Struct25 struct25_12;

	// Token: 0x04000262 RID: 610 RVA: 0x0017CAE4 File Offset: 0x0017CAE4
	public static Struct98 struct98_2;

	// Token: 0x04000263 RID: 611 RVA: 0x0017CAF4 File Offset: 0x0017CAF4
	public static Struct24 struct24_12;

	// Token: 0x04000264 RID: 612 RVA: 0x0017CB00 File Offset: 0x0017CB00
	public static Struct24 struct24_13;

	// Token: 0x04000265 RID: 613 RVA: 0x0017CB0C File Offset: 0x0017CB0C
	public static Struct24 struct24_14;

	// Token: 0x04000266 RID: 614 RVA: 0x0017CB18 File Offset: 0x0017CB18
	public static Struct24 struct24_15;

	// Token: 0x04000267 RID: 615 RVA: 0x0017CB24 File Offset: 0x0017CB24
	public static Struct24 struct24_16;

	// Token: 0x04000268 RID: 616 RVA: 0x0017CB30 File Offset: 0x0017CB30
	public static Struct24 struct24_17;

	// Token: 0x04000269 RID: 617 RVA: 0x0017CB3C File Offset: 0x0017CB3C
	public static Struct24 struct24_18;

	// Token: 0x0400026A RID: 618 RVA: 0x0017CB48 File Offset: 0x0017CB48
	public static Struct24 struct24_19;

	// Token: 0x0400026B RID: 619 RVA: 0x0017CB54 File Offset: 0x0017CB54
	public static Struct24 struct24_20;

	// Token: 0x0400026C RID: 620 RVA: 0x0017CB60 File Offset: 0x0017CB60
	public static Struct24 struct24_21;

	// Token: 0x0400026D RID: 621 RVA: 0x0017CB6C File Offset: 0x0017CB6C
	public static Struct15 struct15_9;

	// Token: 0x0400026E RID: 622 RVA: 0x0017CB7C File Offset: 0x0017CB7C
	public static Struct15 struct15_10;

	// Token: 0x0400026F RID: 623 RVA: 0x0017CB8C File Offset: 0x0017CB8C
	public static Struct25 struct25_13;

	// Token: 0x04000270 RID: 624 RVA: 0x0017CB90 File Offset: 0x0017CB90
	public static Struct18 struct18_16;

	// Token: 0x04000271 RID: 625 RVA: 0x0017CB94 File Offset: 0x0017CB94
	public static Struct10 struct10_26;

	// Token: 0x04000272 RID: 626 RVA: 0x0017CB9C File Offset: 0x0017CB9C
	public static Struct22 struct22_6;

	// Token: 0x04000273 RID: 627 RVA: 0x0017CBA4 File Offset: 0x0017CBA4
	public static Struct25 struct25_14;

	// Token: 0x04000274 RID: 628 RVA: 0x0017CBA8 File Offset: 0x0017CBA8
	public static Struct18 struct18_17;

	// Token: 0x04000275 RID: 629 RVA: 0x0017CBAC File Offset: 0x0017CBAC
	public static Struct10 struct10_27;

	// Token: 0x04000276 RID: 630 RVA: 0x0017CBB4 File Offset: 0x0017CBB4
	public static Struct25 struct25_15;

	// Token: 0x04000277 RID: 631 RVA: 0x0017CBB8 File Offset: 0x0017CBB8
	public static Struct35 struct35_135;

	// Token: 0x04000278 RID: 632 RVA: 0x0017CBC0 File Offset: 0x0017CBC0
	public static Struct35 struct35_136;

	// Token: 0x04000279 RID: 633 RVA: 0x0017CBC8 File Offset: 0x0017CBC8
	public static Struct24 struct24_22;

	// Token: 0x0400027A RID: 634 RVA: 0x0031ED20 File Offset: 0x0031ED20
	public static Struct122 struct122_0;

	// Token: 0x0400027B RID: 635 RVA: 0x00320794 File Offset: 0x00320794
	public static GStruct100 gstruct100_0;

	// Token: 0x0400027C RID: 636 RVA: 0x0017CFD8 File Offset: 0x0017CFD8
	public static Struct131 struct131_0;

	// Token: 0x0400027D RID: 637 RVA: 0x0017F3D8 File Offset: 0x0017F3D8
	public static Struct132 struct132_0;

	// Token: 0x0400027E RID: 638 RVA: 0x0017CBD8 File Offset: 0x0017CBD8
	public static Struct131 struct131_1;

	// Token: 0x0400027F RID: 639 RVA: 0x0017DBD8 File Offset: 0x0017DBD8
	public static Struct131 struct131_2;

	// Token: 0x04000280 RID: 640 RVA: 0x0017D3D8 File Offset: 0x0017D3D8
	public static Struct131 struct131_3;

	// Token: 0x04000281 RID: 641 RVA: 0x0017E3D8 File Offset: 0x0017E3D8
	public static Struct131 struct131_4;

	// Token: 0x04000282 RID: 642 RVA: 0x0017EBD8 File Offset: 0x0017EBD8
	public static Struct131 struct131_5;

	// Token: 0x04000283 RID: 643 RVA: 0x0017DFD8 File Offset: 0x0017DFD8
	public static Struct131 struct131_6;

	// Token: 0x04000284 RID: 644 RVA: 0x0017E7D8 File Offset: 0x0017E7D8
	public static Struct131 struct131_7;

	// Token: 0x04000285 RID: 645 RVA: 0x0017EFD8 File Offset: 0x0017EFD8
	public static Struct131 struct131_8;

	// Token: 0x04000286 RID: 646 RVA: 0x0017D7D8 File Offset: 0x0017D7D8
	public static Struct131 struct131_9;

	// Token: 0x04000287 RID: 647 RVA: 0x0017F400 File Offset: 0x0017F400
	public static Struct65 struct65_12;

	// Token: 0x04000288 RID: 648 RVA: 0x0017F410 File Offset: 0x0017F410
	public static Struct65 struct65_13;

	// Token: 0x04000289 RID: 649 RVA: 0x0017F420 File Offset: 0x0017F420
	public static Struct74 struct74_6;

	// Token: 0x0400028A RID: 650 RVA: 0x003217D4 File Offset: 0x003217D4
	public static GStruct101 gstruct101_0;

	// Token: 0x0400028B RID: 651 RVA: 0x00183024 File Offset: 0x00183024
	public static GStruct72 gstruct72_0;

	// Token: 0x0400028C RID: 652 RVA: 0x0017F6BC File Offset: 0x0017F6BC
	public static GStruct0 gstruct0_0;

	// Token: 0x0400028D RID: 653 RVA: 0x0017FFAC File Offset: 0x0017FFAC
	public static GStruct0 gstruct0_1;

	// Token: 0x0400028E RID: 654 RVA: 0x0017F86C File Offset: 0x0017F86C
	public static GStruct0 gstruct0_2;

	// Token: 0x0400028F RID: 655 RVA: 0x002B02A8 File Offset: 0x002B02A8
	public static Struct121 struct121_0;

	// Token: 0x04000290 RID: 656 RVA: 0x002B2808 File Offset: 0x002B2808
	public static Struct123 struct123_0;

	// Token: 0x04000291 RID: 657 RVA: 0x0017F64C File Offset: 0x0017F64C
	public static GStruct0 gstruct0_3;

	// Token: 0x04000292 RID: 658 RVA: 0x0017F91C File Offset: 0x0017F91C
	public static GStruct0 gstruct0_4;

	// Token: 0x04000293 RID: 659 RVA: 0x0017F4CC File Offset: 0x0017F4CC
	public static GStruct0 gstruct0_5;

	// Token: 0x04000294 RID: 660 RVA: 0x0017F43C File Offset: 0x0017F43C
	public static GStruct0 gstruct0_6;

	// Token: 0x04000295 RID: 661 RVA: 0x0017F4DC File Offset: 0x0017F4DC
	public static GStruct0 gstruct0_7;
}

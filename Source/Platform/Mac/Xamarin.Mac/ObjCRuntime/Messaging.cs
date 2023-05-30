using System;
using System.Runtime.InteropServices;
using System.Text;
using AppKit;
using CoreAnimation;
using CoreGraphics;
using CoreLocation;
using CoreMedia;
using CoreVideo;
using Foundation;
using QTKit;
using Xamarin.System;

namespace ObjCRuntime;

public static class Messaging
{
	private const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern uint uint_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern int int_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_intptr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_bool(IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_rbool(IntPtr receiver, IntPtr selector, ref bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_rint(IntPtr receiver, IntPtr selector, ref int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_rfloat(IntPtr receiver, IntPtr selector, ref float arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_rdouble(IntPtr receiver, IntPtr selector, ref double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_rintptr(IntPtr receiver, IntPtr selector, ref IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_cgsize(IntPtr receiver, IntPtr selector, CGSize arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_cgpoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_cgrect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_nsrange(IntPtr receiver, IntPtr selector, NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_intptr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_cgpoint_intptr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_intptr_intptr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_intptr_intptr_float(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_intptr_intptr_double(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_intptr_intptr_nuint(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper(IntPtr[] super, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_intptr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_cgsize(IntPtr receiver, IntPtr selector, CGSize arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_cgrect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_intptr_intptr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_intptr_intptr_float(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_intptr_intptr_double(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void void_objc_msgSend_stret_rcgsize(ref CGSize stret, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void void_objc_msgSend_stret_rcgrect(ref CGRect stret, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void void_objc_msgSend_stret_rnsrange(ref NSRange stret, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void void_objc_msgSend_stret_rcgsize_cgpoint_intptr(ref CGSize stret, IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void void_objc_msgSendSuper_stret_rcgrect(ref CGRect stret, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr intptr_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr intptr_objc_msgSend_intptr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr intptr_objc_msgsend_intptr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr intptr_objc_msgSend_float(IntPtr receiver, IntPtr selector, float arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr intptr_objc_msgSend_cgrect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr intptr_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr intptr_objc_msgSendSuper_cgrect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr intptr_objc_msgSendSuper_intptr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_intptr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_intptr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize cgsize_objc_msgSend_cgpoint_intptr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize cgsize_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool Boolean_objc_msgSend_IntPtr_Double_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool Boolean_objc_msgSendSuper_IntPtr_Double_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3);

	internal static IntPtr NativeUtf8FromString(string managedString)
	{
		byte[] array = new byte[Encoding.UTF8.GetByteCount(managedString) + 1];
		Encoding.UTF8.GetBytes(managedString, 0, managedString.Length, array, 0);
		IntPtr intPtr = Marshal.AllocHGlobal(array.Length);
		Marshal.Copy(array, 0, intPtr, array.Length);
		return intPtr;
	}

	internal static string StringFromNativeUtf8(IntPtr nativeUtf8)
	{
		int i;
		for (i = 0; Marshal.ReadByte(nativeUtf8, i) != 0; i++)
		{
		}
		byte[] array = new byte[i];
		Marshal.Copy(nativeUtf8, array, 0, array.Length);
		return Encoding.UTF8.GetString(array);
	}

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double(IntPtr receiver, IntPtr selector, double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double(IntPtr receiver, IntPtr selector, double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Double_UInt64(IntPtr receiver, IntPtr selector, double arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Double_UInt64(IntPtr receiver, IntPtr selector, double arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_bool(IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGPoint_objc_msgSend_stret(out CGPoint retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGPoint_objc_msgSendSuper_stret(out CGPoint retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGPoint CGPoint_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGPoint CGPoint_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret(out CGRect retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret(out CGRect retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern int int_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGRect_Double_Double(IntPtr receiver, IntPtr selector, CGRect arg1, double arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_Double_Double(IntPtr receiver, IntPtr selector, CGRect arg1, double arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_CGPoint_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, CGPoint arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_CGPoint_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, CGPoint arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_out_Int64_out_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, out long arg2, out double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_out_Int64_out_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, out long arg2, out double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_Int64_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_Int64_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern int int_objc_msgSend_Int64_IntPtr(IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern int int_objc_msgSendSuper_Int64_IntPtr(IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern int int_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern int int_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_Double_Double_Double_bool(IntPtr receiver, IntPtr selector, CGPoint arg1, double arg2, double arg3, double arg4, bool arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_Double_Double_Double_bool(IntPtr receiver, IntPtr selector, CGPoint arg1, double arg2, double arg3, double arg4, bool arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_Double_Double_Double(IntPtr receiver, IntPtr selector, CGPoint arg1, double arg2, double arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_Double_Double_Double(IntPtr receiver, IntPtr selector, CGPoint arg1, double arg2, double arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_CGPoint_Double(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_CGPoint_Double(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_Double_Double(IntPtr receiver, IntPtr selector, CGRect arg1, double arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_Double_Double(IntPtr receiver, IntPtr selector, CGRect arg1, double arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_Int64_Int64_Int64_bool_bool_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4, long arg5, bool arg6, bool arg7, IntPtr arg8, long arg9, long arg10);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64_Int64_Int64_bool_bool_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4, long arg5, bool arg6, bool arg7, IntPtr arg8, long arg9, long arg10);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_Int64_Int64_Int64_bool_bool_IntPtr_UInt64_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4, long arg5, bool arg6, bool arg7, IntPtr arg8, ulong arg9, long arg10, long arg11);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64_Int64_Int64_bool_bool_IntPtr_UInt64_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4, long arg5, bool arg6, bool arg7, IntPtr arg8, ulong arg9, long arg10, long arg11);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_out_NSTiffCompression_out_Double(IntPtr receiver, IntPtr selector, out NSTiffCompression arg1, out double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_out_NSTiffCompression_out_Double(IntPtr receiver, IntPtr selector, out NSTiffCompression arg1, out double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_Double(IntPtr receiver, IntPtr selector, ulong arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_Double(IntPtr receiver, IntPtr selector, ulong arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_Double(IntPtr receiver, IntPtr selector, ulong arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_Double(IntPtr receiver, IntPtr selector, ulong arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Int64_Int64(IntPtr receiver, IntPtr selector, long arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_Int64(IntPtr receiver, IntPtr selector, long arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret(out CGSize retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret(out CGSize retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGSize(IntPtr receiver, IntPtr selector, CGSize arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGSize(IntPtr receiver, IntPtr selector, CGSize arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64_Int64(IntPtr receiver, IntPtr selector, long arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64_Int64(IntPtr receiver, IntPtr selector, long arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_Int64(out CGRect retval, IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_Int64(out CGRect retval, IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64_CGRect(IntPtr receiver, IntPtr selector, long arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64_CGRect(IntPtr receiver, IntPtr selector, long arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_Int64_Int64(out CGRect retval, IntPtr receiver, IntPtr selector, long arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_Int64_Int64(out CGRect retval, IntPtr receiver, IntPtr selector, long arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_out_Int64_out_Int64_CGPoint(IntPtr receiver, IntPtr selector, out long arg1, out long arg2, CGPoint arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_out_Int64_out_Int64_CGPoint(IntPtr receiver, IntPtr selector, out long arg1, out long arg2, CGPoint arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_Double(IntPtr receiver, IntPtr selector, double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_Double(IntPtr receiver, IntPtr selector, double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double_Int64(IntPtr receiver, IntPtr selector, double arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double_Int64(IntPtr receiver, IntPtr selector, double arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_bool(IntPtr receiver, IntPtr selector, ulong arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_bool(IntPtr receiver, IntPtr selector, ulong arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_IntPtr_Int64_bool_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_IntPtr_Int64_bool_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr_IntPtr_out_Int64_out_Int64_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, out long arg3, out long arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr_IntPtr_out_Int64_out_Int64_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, out long arg3, out long arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_Int64_Int64_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_Int64_Int64_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_Int64_Int64_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_Int64_Int64_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_float_float(IntPtr receiver, IntPtr selector, float arg1, float arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_float_float(IntPtr receiver, IntPtr selector, float arg1, float arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_out_Single_out_Single(IntPtr receiver, IntPtr selector, out float arg1, out float arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_out_Single_out_Single(IntPtr receiver, IntPtr selector, out float arg1, out float arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_CGRect_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_CGRect_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr_CGRect_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGSize_Int64_bool_bool(IntPtr receiver, IntPtr selector, CGSize arg1, long arg2, bool arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGSize_Int64_bool_bool(IntPtr receiver, IntPtr selector, CGSize arg1, long arg2, bool arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern float float_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern float float_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_float(IntPtr receiver, IntPtr selector, float arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_float(IntPtr receiver, IntPtr selector, float arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_Int64(IntPtr receiver, IntPtr selector, ulong arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_Int64(IntPtr receiver, IntPtr selector, ulong arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_CGRect(out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_CGRect(out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_CGRect(out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_CGRect(out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGRect_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_bool_CGRect_IntPtr(IntPtr receiver, IntPtr selector, bool arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_bool_CGRect_IntPtr(IntPtr receiver, IntPtr selector, bool arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_out_Double_out_Double(IntPtr receiver, IntPtr selector, out double arg1, out double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_out_Double_out_Double(IntPtr receiver, IntPtr selector, out double arg1, out double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CGPoint_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CGPoint_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_CGPoint_IntPtr_bool(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_CGPoint_IntPtr_bool(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CGRect_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr_IntPtr_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, long arg5, long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr_IntPtr_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, long arg5, long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGRect_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr_CGRect_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr_CGRect_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_CGRect_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_CGRect_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGPoint_objc_msgSend_stret_CGPoint(out CGPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGPoint_objc_msgSendSuper_stret_CGPoint(out CGPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGPoint CGPoint_objc_msgSend_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGPoint CGPoint_objc_msgSendSuper_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_bool(IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_bool(IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_CGPoint_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_CGPoint_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_CGPoint_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_CGPoint_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr_IntPtr_out_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, out long arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr_IntPtr_out_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, out long arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Double_Double(IntPtr receiver, IntPtr selector, double arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Double_Double(IntPtr receiver, IntPtr selector, double arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Double_Double_Double_Double(IntPtr receiver, IntPtr selector, double arg1, double arg2, double arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Double_Double_Double_Double(IntPtr receiver, IntPtr selector, double arg1, double arg2, double arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Double_Double_Double_Double_Double(IntPtr receiver, IntPtr selector, double arg1, double arg2, double arg3, double arg4, double arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Double_Double_Double_Double_Double(IntPtr receiver, IntPtr selector, double arg1, double arg2, double arg3, double arg4, double arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Double(IntPtr receiver, IntPtr selector, double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Double(IntPtr receiver, IntPtr selector, double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Double_IntPtr(IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Double_IntPtr(IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_out_Double_out_Double_out_Double_out_Double(IntPtr receiver, IntPtr selector, out double arg1, out double arg2, out double arg3, out double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_out_Double_out_Double_out_Double_out_Double(IntPtr receiver, IntPtr selector, out double arg1, out double arg2, out double arg3, out double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_out_Double_out_Double_out_Double_out_Double_out_Double(IntPtr receiver, IntPtr selector, out double arg1, out double arg2, out double arg3, out double arg4, out double arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_out_Double_out_Double_out_Double_out_Double_out_Double(IntPtr receiver, IntPtr selector, out double arg1, out double arg2, out double arg3, out double arg4, out double arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_int_IntPtr(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_int_IntPtr(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern int int_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern int int_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern uint UInt32_objc_msgSend_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern uint UInt32_objc_msgSendSuper_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CGPoint arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CGPoint arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_bool_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_bool_IntPtr(IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_bool_IntPtr(IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_bool_IntPtr(IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_bool_IntPtr(IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGSize_int(IntPtr receiver, IntPtr selector, CGSize arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGSize_int(IntPtr receiver, IntPtr selector, CGSize arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_IntPtr_CGSize(out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_CGSize(out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_IntPtr_CGSize(IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_CGSize(IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern uint UInt32_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern uint UInt32_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern uint UInt32_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern uint UInt32_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_UInt32(out CGRect retval, IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_UInt32(out CGRect retval, IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_UInt32(out CGSize retval, IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_UInt32(out CGSize retval, IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_UInt32(IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_UInt32(IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_bool(IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_bool(IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_Int64_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, long arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_Int64_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, long arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGRect_int_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, CGRect arg1, int arg2, IntPtr arg3, long arg4, long arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_int_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, CGRect arg1, int arg2, IntPtr arg3, long arg4, long arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt64_out_UInt64_out_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, out ulong arg3, out ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt64_out_UInt64_out_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, out ulong arg3, out ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_CGPoint_UInt64(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_CGPoint_UInt64(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_Double(IntPtr receiver, IntPtr selector, CGRect arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_Double(IntPtr receiver, IntPtr selector, CGRect arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_Double_CGPoint_Double_UInt64(IntPtr receiver, IntPtr selector, CGPoint arg1, double arg2, CGPoint arg3, double arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_Double_CGPoint_Double_UInt64(IntPtr receiver, IntPtr selector, CGPoint arg1, double arg2, CGPoint arg3, double arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_CGPoint(IntPtr receiver, IntPtr selector, CGRect arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_CGPoint(IntPtr receiver, IntPtr selector, CGRect arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_out_Double_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, out double arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_out_Double_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, out double arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ushort UInt16_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ushort UInt16_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern short short_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern short short_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double_Double(IntPtr receiver, IntPtr selector, double arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double_Double(IntPtr receiver, IntPtr selector, double arg1, double arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_Int64_Int64_Double(IntPtr receiver, IntPtr selector, ulong arg1, CGPoint arg2, ulong arg3, double arg4, long arg5, IntPtr arg6, long arg7, long arg8, double arg9);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_Int64_Int64_Double(IntPtr receiver, IntPtr selector, ulong arg1, CGPoint arg2, ulong arg3, double arg4, long arg5, IntPtr arg6, long arg7, long arg8, double arg9);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_IntPtr_IntPtr_bool_UInt16(IntPtr receiver, IntPtr selector, ulong arg1, CGPoint arg2, ulong arg3, double arg4, long arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, bool arg9, ushort arg10);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_IntPtr_IntPtr_bool_UInt16(IntPtr receiver, IntPtr selector, ulong arg1, CGPoint arg2, ulong arg3, double arg4, long arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, bool arg9, ushort arg10);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_Int64_Int64_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, CGPoint arg2, ulong arg3, double arg4, long arg5, IntPtr arg6, long arg7, long arg8, IntPtr arg9);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_Int64_Int64_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, CGPoint arg2, ulong arg3, double arg4, long arg5, IntPtr arg6, long arg7, long arg8, IntPtr arg9);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_short_Int64_Int64(IntPtr receiver, IntPtr selector, ulong arg1, CGPoint arg2, ulong arg3, double arg4, long arg5, IntPtr arg6, short arg7, long arg8, long arg9);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_short_Int64_Int64(IntPtr receiver, IntPtr selector, ulong arg1, CGPoint arg2, ulong arg3, double arg4, long arg5, IntPtr arg6, short arg7, long arg8, long arg9);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_Double_Double_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, double arg2, double arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_Double_Double_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, double arg2, double arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_Int64_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_Int64_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGPoint_objc_msgSend_stret_IntPtr(out CGPoint retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGPoint_objc_msgSendSuper_stret_IntPtr(out CGPoint retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGPoint CGPoint_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGPoint CGPoint_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr_int_Int64(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr_int_Int64(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_out_Int32_int_int(IntPtr receiver, IntPtr selector, out int arg1, int arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_out_Int32_int_int(IntPtr receiver, IntPtr selector, out int arg1, int arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_int_int_int_int_int(IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, int arg4, int arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_int_int_int_int_int(IntPtr receiver, IntPtr selector, int arg1, int arg2, int arg3, int arg4, int arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_int_int_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_int_int_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_int_IntPtr_int(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_int_IntPtr_int(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_bool(IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_bool(IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_out_CGRect_IntPtr_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, out CGRect arg3, IntPtr arg4, IntPtr arg5, CGPoint arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_out_CGRect_IntPtr_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, out CGRect arg3, IntPtr arg4, IntPtr arg5, CGPoint arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGSize(IntPtr receiver, IntPtr selector, CGSize arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGSize(IntPtr receiver, IntPtr selector, CGSize arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_CGRect_UInt64_Double(IntPtr receiver, IntPtr selector, CGPoint arg1, CGRect arg2, ulong arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_CGRect_UInt64_Double(IntPtr receiver, IntPtr selector, CGPoint arg1, CGRect arg2, ulong arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_CGRect_UInt64_Double(IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, ulong arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_CGRect_UInt64_Double(IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, ulong arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_CGRect_UInt64_Double_bool_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, ulong arg3, double arg4, bool arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_CGRect_UInt64_Double_bool_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, ulong arg3, double arg4, bool arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGSize(IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGSize(IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_out_CGRect_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, out CGRect arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_out_CGRect_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, out CGRect arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CGRect_CGRect_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, IntPtr arg3, IntPtr arg4, bool arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CGRect_CGRect_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, IntPtr arg3, IntPtr arg4, bool arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_IntPtr(out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_IntPtr(out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CGRect_CGRect_UInt64_Double_bool_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, ulong arg3, double arg4, bool arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CGRect_CGRect_UInt64_Double_bool_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, ulong arg3, double arg4, bool arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64_Int64_Int64_bool(IntPtr receiver, IntPtr selector, long arg1, long arg2, long arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64_Int64_Int64_bool(IntPtr receiver, IntPtr selector, long arg1, long arg2, long arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64_Int64_Int64(IntPtr receiver, IntPtr selector, long arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64_Int64_Int64(IntPtr receiver, IntPtr selector, long arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_out_Int64_out_Int64(IntPtr receiver, IntPtr selector, out long arg1, out long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_out_Int64_out_Int64(IntPtr receiver, IntPtr selector, out long arg1, out long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_out_Int64_out_Int64_IntPtr(IntPtr receiver, IntPtr selector, out long arg1, out long arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_out_Int64_out_Int64_IntPtr(IntPtr receiver, IntPtr selector, out long arg1, out long arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64_IntPtr(IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64_IntPtr(IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_bool_Int64_Int64(IntPtr receiver, IntPtr selector, bool arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_bool_Int64_Int64(IntPtr receiver, IntPtr selector, bool arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_Int64_IntPtr_Int64_Double_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, IntPtr arg4, long arg5, double arg6, double arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64_IntPtr_Int64_Double_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, IntPtr arg4, long arg5, double arg6, double arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_NSRange(IntPtr receiver, IntPtr selector, NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_NSRange(IntPtr receiver, IntPtr selector, NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt64_NSRange_Int64_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, long arg4, NSRange arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt64_NSRange_Int64_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, long arg4, NSRange arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_Int64_Int64(IntPtr receiver, IntPtr selector, ulong arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_Int64_Int64(IntPtr receiver, IntPtr selector, ulong arg1, long arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64_UInt64(IntPtr receiver, IntPtr selector, long arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64_UInt64(IntPtr receiver, IntPtr selector, long arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_UInt64_out_Boolean(IntPtr receiver, IntPtr selector, ulong arg1, out bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_UInt64_out_Boolean(IntPtr receiver, IntPtr selector, ulong arg1, out bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_Int64_Int64(IntPtr receiver, IntPtr selector, long arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_Int64_Int64(IntPtr receiver, IntPtr selector, long arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_NSRange_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1, NSRange arg2, CGRect arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_NSRange_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1, NSRange arg2, CGRect arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_CGRect_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_CGRect_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_NSRange(IntPtr receiver, IntPtr selector, CGPoint arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_NSRange(IntPtr receiver, IntPtr selector, CGPoint arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_bool_Int64(IntPtr receiver, IntPtr selector, bool arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_bool_Int64(IntPtr receiver, IntPtr selector, bool arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGSize_NSRange(IntPtr receiver, IntPtr selector, CGSize arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGSize_NSRange(IntPtr receiver, IntPtr selector, CGSize arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_out_UInt64_out_UInt64(IntPtr receiver, IntPtr selector, out ulong arg1, out ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_out_UInt64_out_UInt64(IntPtr receiver, IntPtr selector, out ulong arg1, out ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGPoint_objc_msgSend_stret_Int64(out CGPoint retval, IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGPoint_objc_msgSendSuper_stret_Int64(out CGPoint retval, IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGPoint CGPoint_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGPoint CGPoint_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_Int64(out CGSize retval, IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_Int64(out CGSize retval, IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr_NSRange(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr_NSRange(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr_NSRange(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_NSRange(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_IntPtr(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_IntPtr(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_Int64(out NSRange retval, IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_Int64(out NSRange retval, IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_NSRange_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_NSRange_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_CGRect_IntPtr(out NSRange retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_CGRect_IntPtr(out NSRange retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_CGRect_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_CGRect_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_CGPoint_IntPtr_out_Double(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2, out double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_CGPoint_IntPtr_out_Double(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2, out double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_UInt64_bool_bool_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, bool arg2, bool arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_UInt64_bool_bool_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, bool arg2, bool arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_bool_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3, long arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3, long arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, NSRange arg4, long arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_NSRange_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, NSRange arg4, long arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGPoint_CGRect_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_CGRect_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr_int(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr_int(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGRect_bool(IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_bool(IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern float float_objc_msgSend_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern float float_objc_msgSendSuper_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern int int_objc_msgSend_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern int int_objc_msgSendSuper_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_IntPtr_IntPtr(out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_IntPtr(out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret(out NSRange retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret(out NSRange retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGRect_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Double_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3, CGPoint arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3, CGPoint arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_Double_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Double_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_CGRect_UInt64(out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_CGRect_UInt64(out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_UInt64(out CGRect retval, IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_UInt64(out CGRect retval, IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_bool(IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_bool(IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_UInt64_Int64(IntPtr receiver, IntPtr selector, ulong arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_UInt64_Int64(IntPtr receiver, IntPtr selector, ulong arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_CGSize_bool_bool_UInt64(out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1, bool arg2, bool arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_CGSize_bool_bool_UInt64(out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1, bool arg2, bool arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_CGSize_bool_bool_UInt64(IntPtr receiver, IntPtr selector, CGSize arg1, bool arg2, bool arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_CGSize_bool_bool_UInt64(IntPtr receiver, IntPtr selector, CGSize arg1, bool arg2, bool arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_CGSize_IntPtr_IntPtr_UInt64_UInt64_Int64(out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2, IntPtr arg3, ulong arg4, ulong arg5, long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_CGSize_IntPtr_IntPtr_UInt64_UInt64_Int64(out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2, IntPtr arg3, ulong arg4, ulong arg5, long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_CGSize_IntPtr_IntPtr_UInt64_UInt64_Int64(IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2, IntPtr arg3, ulong arg4, ulong arg5, long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_CGSize_IntPtr_IntPtr_UInt64_UInt64_Int64(IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2, IntPtr arg3, ulong arg4, ulong arg5, long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64_CGRect_IntPtr(IntPtr receiver, IntPtr selector, long arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64_CGRect_IntPtr(IntPtr receiver, IntPtr selector, long arg1, CGRect arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_bool(out CGRect retval, IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_bool(out CGRect retval, IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_NSRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_NSRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_short(IntPtr receiver, IntPtr selector, IntPtr arg1, short arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_short(IntPtr receiver, IntPtr selector, IntPtr arg1, short arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt32_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt32_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_IntPtr_Int64_IntPtr_bool_Int64_out_Int64(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, bool arg4, long arg5, out long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_IntPtr_Int64_IntPtr_bool_Int64_out_Int64(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, bool arg4, long arg5, out long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_IntPtr_Int64_IntPtr_bool_Int64_out_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, bool arg4, long arg5, out long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_IntPtr_Int64_IntPtr_bool_Int64_out_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, bool arg4, long arg5, out long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_IntPtr_Int64(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_IntPtr_Int64(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_IntPtr_int_IntPtr_bool_Int64_IntPtr(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, long arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_IntPtr_int_IntPtr_bool_Int64_IntPtr(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, long arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_IntPtr_int_IntPtr_bool_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, long arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_IntPtr_int_IntPtr_bool_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, bool arg4, long arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_Int64_IntPtr_out_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, ulong arg3, IntPtr arg4, long arg5, IntPtr arg6, out long arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_Int64_IntPtr_out_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, ulong arg3, IntPtr arg4, long arg5, IntPtr arg6, out long arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CGPoint arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CGPoint arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_IntPtr_Double_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_IntPtr_Double_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_CGSize(IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_CGSize(IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr_CGRect_CGRect_Int64(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGRect arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_CGRect_Int64(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGRect arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr_Int64(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_Int64(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSEdgeInsets_objc_msgSend_stret(out NSEdgeInsets retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSEdgeInsets_objc_msgSendSuper_stret(out NSEdgeInsets retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGPoint_objc_msgSend_stret_CGPoint_IntPtr(out CGPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGPoint_objc_msgSendSuper_stret_CGPoint_IntPtr(out CGPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGPoint CGPoint_objc_msgSend_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGPoint CGPoint_objc_msgSendSuper_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_CGSize_IntPtr(out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_CGSize_IntPtr(out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_CGSize_IntPtr(IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_CGSize_IntPtr(IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_CGSize(out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_CGSize(out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_CGSize(IntPtr receiver, IntPtr selector, CGSize arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_CGSize(IntPtr receiver, IntPtr selector, CGSize arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_CGSize(IntPtr receiver, IntPtr selector, CGRect arg1, CGSize arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_CGSize(IntPtr receiver, IntPtr selector, CGRect arg1, CGSize arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CGPoint_CGRect(IntPtr receiver, IntPtr selector, CGPoint arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CGPoint_CGRect(IntPtr receiver, IntPtr selector, CGPoint arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_CGRect_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_CGRect_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_CGRect_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_CGRect_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_CGPoint_CGSize_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGSize arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, bool arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_CGPoint_CGSize_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGSize arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, bool arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CGRect_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, bool arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CGRect_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, bool arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CGRect_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, bool arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, bool arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern float float_objc_msgSend_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern float float_objc_msgSendSuper_Int64(IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_float_Int64(IntPtr receiver, IntPtr selector, float arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_float_Int64(IntPtr receiver, IntPtr selector, float arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_out_Double_Double_Double_Double(IntPtr receiver, IntPtr selector, out double arg1, double arg2, double arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_out_Double_Double_Double_Double(IntPtr receiver, IntPtr selector, out double arg1, double arg2, double arg3, double arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_out_NSRange(IntPtr receiver, IntPtr selector, out NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_out_NSRange(IntPtr receiver, IntPtr selector, out NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGPoint_objc_msgSend_stret_CGRect(out CGPoint retval, IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGPoint_objc_msgSendSuper_stret_CGRect(out CGPoint retval, IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGPoint CGPoint_objc_msgSend_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGPoint CGPoint_objc_msgSendSuper_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_CGRect(out NSRange retval, IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_CGRect(out NSRange retval, IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64_Int64_IntPtr_bool(IntPtr receiver, IntPtr selector, long arg1, long arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64_Int64_IntPtr_bool(IntPtr receiver, IntPtr selector, long arg1, long arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Int64_Int64_bool(IntPtr receiver, IntPtr selector, long arg1, long arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_Int64_bool(IntPtr receiver, IntPtr selector, long arg1, long arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Int64_bool(IntPtr receiver, IntPtr selector, long arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_bool(IntPtr receiver, IntPtr selector, long arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_Int64_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_Int64_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr_IntPtr_Int64_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr_IntPtr_Int64_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_Int64_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_Int64_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_CGPoint_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_CGPoint_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr_bool_Int64(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, bool arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr_bool_Int64(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, bool arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_bool_CGRect(IntPtr receiver, IntPtr selector, bool arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_bool_CGRect(IntPtr receiver, IntPtr selector, bool arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_bool(out CGSize retval, IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_bool(out CGSize retval, IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_bool(IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_bool(IntPtr receiver, IntPtr selector, bool arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_NSRange_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_NSRange_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_NSRange(IntPtr receiver, IntPtr selector, NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange(IntPtr receiver, IntPtr selector, NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr_UInt64(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr_UInt64(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CGRect_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CGRect_IntPtr_UInt64_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, ulong arg4, bool arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_UInt64_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, ulong arg4, bool arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr_CGRect_CGPoint_UInt64(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGPoint arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_CGPoint_UInt64(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGPoint arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double_UInt64_UInt64(IntPtr receiver, IntPtr selector, double arg1, ulong arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double_UInt64_UInt64(IntPtr receiver, IntPtr selector, double arg1, ulong arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double_UInt64(IntPtr receiver, IntPtr selector, double arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double_UInt64(IntPtr receiver, IntPtr selector, double arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double_UInt64_Int64_int(IntPtr receiver, IntPtr selector, double arg1, ulong arg2, long arg3, int arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double_UInt64_Int64_int(IntPtr receiver, IntPtr selector, double arg1, ulong arg2, long arg3, int arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double_UInt64_Int64(IntPtr receiver, IntPtr selector, double arg1, ulong arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double_UInt64_Int64(IntPtr receiver, IntPtr selector, double arg1, ulong arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_Int64_int(IntPtr receiver, IntPtr selector, long arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_Int64_int(IntPtr receiver, IntPtr selector, long arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_Int64_int(IntPtr receiver, IntPtr selector, long arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_Int64_int(IntPtr receiver, IntPtr selector, long arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_CGPoint_CGRect_IntPtr_NSRange(out CGRect retval, IntPtr receiver, IntPtr selector, CGPoint arg1, CGRect arg2, IntPtr arg3, NSRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_CGPoint_CGRect_IntPtr_NSRange(out CGRect retval, IntPtr receiver, IntPtr selector, CGPoint arg1, CGRect arg2, IntPtr arg3, NSRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_CGRect_CGRect_IntPtr_NSRange(out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, IntPtr arg3, NSRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_CGRect_CGRect_IntPtr_NSRange(out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, IntPtr arg3, NSRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr_NSRange_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, NSRange arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr_NSRange_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, NSRange arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_Int64_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4, long arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4, long arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr_CGPoint_CGRect_IntPtr_NSRange(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGRect arg3, IntPtr arg4, NSRange arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_CGPoint_CGRect_IntPtr_NSRange(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGRect arg3, IntPtr arg4, NSRange arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr_CGRect_CGRect_IntPtr_NSRange(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGRect arg3, IntPtr arg4, NSRange arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_CGRect_IntPtr_NSRange(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGRect arg3, IntPtr arg4, NSRange arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_CGRect_IntPtr_NSRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, NSRange arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_CGRect_IntPtr_NSRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, IntPtr arg3, NSRange arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_NSRange_Int64(IntPtr receiver, IntPtr selector, ulong arg1, NSRange arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_NSRange_Int64(IntPtr receiver, IntPtr selector, ulong arg1, NSRange arg2, long arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_Double_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, double arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_Double_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, double arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_NSRange(IntPtr receiver, IntPtr selector, ulong arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_NSRange(IntPtr receiver, IntPtr selector, ulong arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64_NSRange(IntPtr receiver, IntPtr selector, long arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64_NSRange(IntPtr receiver, IntPtr selector, long arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_IntPtr_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_IntPtr_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_IntPtr_bool(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_IntPtr_bool(IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_NSRange_UInt64(out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_NSRange_UInt64(out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_NSRange_UInt64(IntPtr receiver, IntPtr selector, NSRange arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_NSRange_UInt64(IntPtr receiver, IntPtr selector, NSRange arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern uint UInt32_objc_msgSend_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern uint UInt32_objc_msgSendSuper_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_NSRange_out_Int64(IntPtr receiver, IntPtr selector, NSRange arg1, out long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange_out_Int64(IntPtr receiver, IntPtr selector, NSRange arg1, out long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_NSRange_Int64_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, long arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_NSRange_Int64_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, long arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt64_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt64_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_NSRange_UInt64_bool(IntPtr receiver, IntPtr selector, NSRange arg1, ulong arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_NSRange_UInt64_bool(IntPtr receiver, IntPtr selector, NSRange arg1, ulong arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_NSRange_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_NSRange_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_NSRange(out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_NSRange(out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_NSRange(IntPtr receiver, IntPtr selector, NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_NSRange(IntPtr receiver, IntPtr selector, NSRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_NSRange_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_NSRange_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_NSRange_UInt64_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_NSRange_UInt64_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, ulong arg3, IntPtr arg4, IntPtr arg5, long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, ulong arg3, IntPtr arg4, IntPtr arg5, long arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_CGRect_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_CGRect_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_IntPtr_NSRange_NSRange(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_IntPtr_NSRange_NSRange(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_IntPtr_NSRange_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_IntPtr_NSRange_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_NSRange_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_NSRange_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_NSRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_NSRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_Int64_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_Int64_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_NSRange_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_NSRange_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, ulong arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, long arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_IntPtr_IntPtr_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, ulong arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, long arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_CGRect_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_CGRect_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGRect_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGRect_UInt64_UInt64_bool(IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, ulong arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_UInt64_UInt64_bool(IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, ulong arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGRect_UInt64_UInt64_bool_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, ulong arg3, bool arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_UInt64_UInt64_bool_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, ulong arg3, bool arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_CGRect(IntPtr receiver, IntPtr selector, CGRect arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_bool_bool(IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_bool_bool(IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double_int(IntPtr receiver, IntPtr selector, double arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double_int(IntPtr receiver, IntPtr selector, double arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_bool_int(IntPtr receiver, IntPtr selector, bool arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_bool_int(IntPtr receiver, IntPtr selector, bool arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_UInt64(IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_UInt64(IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_CGPoint_Int64(IntPtr receiver, IntPtr selector, CGPoint arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_CGPoint_Int64(IntPtr receiver, IntPtr selector, CGPoint arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr_CGRect(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_CGRect(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_IntPtr_IntPtr_CGRect(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_IntPtr_CGRect(out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGSize_objc_msgSend_stret_IntPtr_CGSize_CGSize(out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, CGSize arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_CGSize_CGSize(out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, CGSize arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CGSize CGSize_objc_msgSend_IntPtr_CGSize_CGSize(IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, CGSize arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_CGSize_CGSize(IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, CGSize arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_bool_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_bool_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_out_Boolean_out_Boolean_out_Boolean_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, out bool arg2, out bool arg3, out bool arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_out_Boolean_out_Boolean_out_Boolean_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, out bool arg2, out bool arg3, out bool arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_out_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, out long arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_out_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, out long arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_UInt64_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, IntPtr arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_UInt64_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, IntPtr arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Int64_UInt64_Int64_bool(IntPtr receiver, IntPtr selector, long arg1, ulong arg2, long arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Int64_UInt64_Int64_bool(IntPtr receiver, IntPtr selector, long arg1, ulong arg2, long arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_bool_IntPtr(IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_bool_IntPtr(IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_UInt32_IntPtr(IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_UInt32_IntPtr(IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGAffineTransform_objc_msgSend_stret(out CGAffineTransform retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGAffineTransform_objc_msgSendSuper_stret(out CGAffineTransform retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGAffineTransform(IntPtr receiver, IntPtr selector, CGAffineTransform arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGAffineTransform(IntPtr receiver, IntPtr selector, CGAffineTransform arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt32(IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32(IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt32(IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt32(IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern uint UInt32_objc_msgSend_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern uint UInt32_objc_msgSendSuper_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, uint arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, uint arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt32_UInt32(IntPtr receiver, IntPtr selector, uint arg1, uint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt32_UInt32(IntPtr receiver, IntPtr selector, uint arg1, uint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_int_int(IntPtr receiver, IntPtr selector, int arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_int_int(IntPtr receiver, IntPtr selector, int arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern int int_objc_msgSend_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern int int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_int_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_int_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double_CGPoint(IntPtr receiver, IntPtr selector, double arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double_CGPoint(IntPtr receiver, IntPtr selector, double arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_int_IntPtr(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_int_IntPtr(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void QTTime_objc_msgSend_stret(out QTTime retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void QTTime_objc_msgSendSuper_stret(out QTTime retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern QTTime QTTime_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern QTTime QTTime_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_QTTime(IntPtr receiver, IntPtr selector, QTTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_QTTime(IntPtr receiver, IntPtr selector, QTTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_QTTimeRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTimeRange arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTimeRange arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_QTTimeRange_IntPtr(IntPtr receiver, IntPtr selector, QTTimeRange arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_QTTimeRange_IntPtr(IntPtr receiver, IntPtr selector, QTTimeRange arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_QTTime(IntPtr receiver, IntPtr selector, QTTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_QTTime(IntPtr receiver, IntPtr selector, QTTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_QTTime_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, QTTime arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_QTTime_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, QTTime arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_QTTimeRange(IntPtr receiver, IntPtr selector, QTTimeRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_QTTimeRange(IntPtr receiver, IntPtr selector, QTTimeRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_QTTimeRange_QTTime(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTimeRange arg2, QTTime arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTime(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTimeRange arg2, QTTime arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_QTTimeRange_QTTimeRange(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTimeRange arg2, QTTimeRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_QTTimeRange_QTTimeRange(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTimeRange arg2, QTTimeRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_QTTimeRange_QTTime(IntPtr receiver, IntPtr selector, QTTimeRange arg1, QTTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_QTTimeRange_QTTime(IntPtr receiver, IntPtr selector, QTTimeRange arg1, QTTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_QTTime_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTime arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_QTTime_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTime arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_QTTimeRange_QTTime(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTimeRange arg2, QTTime arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_QTTime(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTimeRange arg2, QTTime arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_QTTimeRange_QTTimeRange(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTimeRange arg2, QTTimeRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_QTTimeRange_QTTimeRange(IntPtr receiver, IntPtr selector, IntPtr arg1, QTTimeRange arg2, QTTimeRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void QTTime_objc_msgSend_stret_int(out QTTime retval, IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void QTTime_objc_msgSendSuper_stret_int(out QTTime retval, IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern QTTime QTTime_objc_msgSend_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern QTTime QTTime_objc_msgSendSuper_int(IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern int int_objc_msgSend_QTTime(IntPtr receiver, IntPtr selector, QTTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern int int_objc_msgSendSuper_QTTime(IntPtr receiver, IntPtr selector, QTTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGSize_IntPtr(IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGSize_IntPtr(IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_int_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, int arg1, CGPoint arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_int_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, int arg1, CGPoint arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGPoint_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, IntPtr arg3, CGPoint arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGPoint_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, IntPtr arg3, CGPoint arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, int arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, int arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_int(out CGRect retval, IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_int(out CGRect retval, IntPtr receiver, IntPtr selector, int arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_int(IntPtr receiver, IntPtr selector, CGRect arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_int(IntPtr receiver, IntPtr selector, CGRect arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGPoint_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_CGPoint(IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_int_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_int_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_bool_int(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_bool_int(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGPoint_bool(IntPtr receiver, IntPtr selector, CGPoint arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_bool(IntPtr receiver, IntPtr selector, CGPoint arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern float float_objc_msgSend_IntPtr_float(IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern float float_objc_msgSendSuper_IntPtr_float(IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern uint UInt32_objc_msgSend_IntPtr_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern uint UInt32_objc_msgSendSuper_IntPtr_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern int int_objc_msgSend_IntPtr_IntPtr_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern int int_objc_msgSendSuper_IntPtr_IntPtr_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ushort UInt16_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ushort UInt16_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern short short_objc_msgSend_UInt16_IntPtr(IntPtr receiver, IntPtr selector, ushort arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern short short_objc_msgSendSuper_UInt16_IntPtr(IntPtr receiver, IntPtr selector, ushort arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern short short_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern short short_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern short short_objc_msgSend_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern short short_objc_msgSendSuper_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt32_UInt32(IntPtr receiver, IntPtr selector, uint arg1, uint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32(IntPtr receiver, IntPtr selector, uint arg1, uint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt32_IntPtr(IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt32_IntPtr(IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt32_UInt32_IntPtr(IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt32_UInt32_IntPtr(IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_int_int(IntPtr receiver, IntPtr selector, int arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_int_int(IntPtr receiver, IntPtr selector, int arg1, int arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_bool_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_bool_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Double(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_int_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt32_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt32_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern ulong UInt64_objc_msgSend_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern ulong UInt64_objc_msgSendSuper_IntPtr_CGPoint(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt32_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, CGPoint arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt32_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, CGPoint arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern float float_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern float float_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_int_IntPtr(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_int_IntPtr(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_bool_bool_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_bool_bool_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern float float_objc_msgSend_UInt32(IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern float float_objc_msgSendSuper_UInt32(IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_Double(IntPtr receiver, IntPtr selector, double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_Double(IntPtr receiver, IntPtr selector, double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CMTime_objc_msgSend_stret(out CMTime retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CMTime_objc_msgSendSuper_stret(out CMTime retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CMTime(IntPtr receiver, IntPtr selector, CMTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CMTime(IntPtr receiver, IntPtr selector, CMTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CMTime_out_CMTime_IntPtr(IntPtr receiver, IntPtr selector, CMTime arg1, out CMTime arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CMTime_out_CMTime_IntPtr(IntPtr receiver, IntPtr selector, CMTime arg1, out CMTime arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CMTimeRange_objc_msgSend_stret(out CMTimeRange retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CMTimeRange_objc_msgSendSuper_stret(out CMTimeRange retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CMTimeRange(IntPtr receiver, IntPtr selector, CMTimeRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CMTimeRange(IntPtr receiver, IntPtr selector, CMTimeRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CMTime(IntPtr receiver, IntPtr selector, IntPtr arg1, CMTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CMTime(IntPtr receiver, IntPtr selector, IntPtr arg1, CMTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CMTime(IntPtr receiver, IntPtr selector, CMTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CMTime(IntPtr receiver, IntPtr selector, CMTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CMTime_objc_msgSend_stret_CMTime(out CMTime retval, IntPtr receiver, IntPtr selector, CMTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CMTime_objc_msgSendSuper_stret_CMTime(out CMTime retval, IntPtr receiver, IntPtr selector, CMTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CMTimeRange_IntPtr_CMTime_IntPtr(IntPtr receiver, IntPtr selector, CMTimeRange arg1, IntPtr arg2, CMTime arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CMTimeRange_IntPtr_CMTime_IntPtr(IntPtr receiver, IntPtr selector, CMTimeRange arg1, IntPtr arg2, CMTime arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CMTimeRange_CMTime(IntPtr receiver, IntPtr selector, CMTimeRange arg1, CMTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CMTimeRange_CMTime(IntPtr receiver, IntPtr selector, CMTimeRange arg1, CMTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_CMTime_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CMTime arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_CMTime_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CMTime arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CMTimeMapping_objc_msgSend_stret(out CMTimeMapping retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CMTimeMapping_objc_msgSendSuper_stret(out CMTimeMapping retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_CMTimeRange_CMTimeRange(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, CMTimeRange arg3, CMTimeRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_CMTimeRange_CMTimeRange(IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, CMTimeRange arg3, CMTimeRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CMTimeRange(IntPtr receiver, IntPtr selector, CMTimeRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CMTimeRange(IntPtr receiver, IntPtr selector, CMTimeRange arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CMTime_out_Single_out_Single_out_CMTimeRange(IntPtr receiver, IntPtr selector, CMTime arg1, out float arg2, out float arg3, out CMTimeRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CMTime_out_Single_out_Single_out_CMTimeRange(IntPtr receiver, IntPtr selector, CMTime arg1, out float arg2, out float arg3, out CMTimeRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_float_float_CMTimeRange(IntPtr receiver, IntPtr selector, float arg1, float arg2, CMTimeRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_float_float_CMTimeRange(IntPtr receiver, IntPtr selector, float arg1, float arg2, CMTimeRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_float_CMTime(IntPtr receiver, IntPtr selector, float arg1, CMTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_float_CMTime(IntPtr receiver, IntPtr selector, float arg1, CMTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CMTimeRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CMTimeRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_CMTimeRange(IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_CMTimeRange(IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CMTime_out_CGAffineTransform_out_CGAffineTransform_out_CMTimeRange(IntPtr receiver, IntPtr selector, CMTime arg1, out CGAffineTransform arg2, out CGAffineTransform arg3, out CMTimeRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CMTime_out_CGAffineTransform_out_CGAffineTransform_out_CMTimeRange(IntPtr receiver, IntPtr selector, CMTime arg1, out CGAffineTransform arg2, out CGAffineTransform arg3, out CMTimeRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGAffineTransform_CGAffineTransform_CMTimeRange(IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CGAffineTransform arg2, CMTimeRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGAffineTransform_CGAffineTransform_CMTimeRange(IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CGAffineTransform arg2, CMTimeRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGAffineTransform_CMTime(IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CMTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGAffineTransform_CMTime(IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CMTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CMTime_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CMTime_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CMTime_CMTime_CMTime(IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CMTime_CMTime_CMTime(IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CMTime_IntPtr(IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CMTime_IntPtr(IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CMTime_CMTime_CMTime_IntPtr(IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CMTime_CMTime_CMTime_IntPtr(IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_float_CMTime_CMTime(IntPtr receiver, IntPtr selector, float arg1, CMTime arg2, CMTime arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_float_CMTime_CMTime(IntPtr receiver, IntPtr selector, float arg1, CMTime arg2, CMTime arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_float_IntPtr(IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_float_IntPtr(IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CMTimeRange(IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CMTimeRange(IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CMTime_objc_msgSend_stret_Double(out CMTime retval, IntPtr receiver, IntPtr selector, double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CMTime_objc_msgSendSuper_stret_Double(out CMTime retval, IntPtr receiver, IntPtr selector, double arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CMTime_objc_msgSend_stret_Int64(out CMTime retval, IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CMTime_objc_msgSendSuper_stret_Int64(out CMTime retval, IntPtr receiver, IntPtr selector, long arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_CMTime(IntPtr receiver, IntPtr selector, CMTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_CMTime(IntPtr receiver, IntPtr selector, CMTime arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CMTime_out_CMTime(IntPtr receiver, IntPtr selector, CMTime arg1, out CMTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CMTime_out_CMTime(IntPtr receiver, IntPtr selector, CMTime arg1, out CMTime arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_out_NSRange(IntPtr receiver, IntPtr selector, ulong arg1, out NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_out_NSRange(IntPtr receiver, IntPtr selector, ulong arg1, out NSRange arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_out_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, out NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_out_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, out NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_out_NSRange_NSRange(IntPtr receiver, IntPtr selector, ulong arg1, out NSRange arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_out_NSRange_NSRange(IntPtr receiver, IntPtr selector, ulong arg1, out NSRange arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_out_NSRange_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, out NSRange arg3, NSRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_out_NSRange_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, out NSRange arg3, NSRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_UInt64(IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_UInt64(IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_Char(IntPtr receiver, IntPtr selector, char arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_Char(IntPtr receiver, IntPtr selector, char arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_byte(IntPtr receiver, IntPtr selector, byte arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_byte(IntPtr receiver, IntPtr selector, byte arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_UInt32(IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_UInt32(IntPtr receiver, IntPtr selector, uint arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_Double_IntPtr(IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_Double_IntPtr(IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ulong arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_UInt64_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ulong arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSRange_objc_msgSend_stret_IntPtr_UInt64_NSRange(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSRange_objc_msgSendSuper_stret_IntPtr_UInt64_NSRange(out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern NSRange NSRange_objc_msgSend_IntPtr_UInt64_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern NSRange NSRange_objc_msgSendSuper_IntPtr_UInt64_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_int_bool(IntPtr receiver, IntPtr selector, int arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_int_bool(IntPtr receiver, IntPtr selector, int arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_NSRange_Int64(IntPtr receiver, IntPtr selector, NSRange arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_NSRange_Int64(IntPtr receiver, IntPtr selector, NSRange arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_NSRange_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_NSRange_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_out_NSRange_out_NSRange(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, out NSRange arg3, out NSRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_out_NSRange_out_NSRange(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, out NSRange arg3, out NSRange arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_out_NSRange_out_NSRange_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, out NSRange arg3, out NSRange arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_out_NSRange_out_NSRange_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, out NSRange arg3, out NSRange arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Double_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, bool arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Double_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, bool arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, bool arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, bool arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_out_Boolean_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, out bool arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_out_Boolean_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, out bool arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_UInt64_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_UInt64_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_Int64_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_Int64_Int64_Int64(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CGRect_objc_msgSend_stret_CGSize_UInt64_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, CGSize arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CGRect_objc_msgSendSuper_stret_CGSize_UInt64_IntPtr(out CGRect retval, IntPtr receiver, IntPtr selector, CGSize arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CGRect_UInt64_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CGRect_UInt64_IntPtr(IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern char Char_objc_msgSend_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern char Char_objc_msgSendSuper_UInt64(IntPtr receiver, IntPtr selector, ulong arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_UInt32(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_UInt32_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_UInt32_NSRange(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_UInt32_NSRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_UInt32_NSRange_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_NSRange_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr(IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_Double_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Double_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern long Int64_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern long Int64_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, ulong arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt64_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt64_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CMTimeMapping(IntPtr receiver, IntPtr selector, CMTimeMapping arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CMTimeMapping(IntPtr receiver, IntPtr selector, CMTimeMapping arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern sbyte SByte_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern sbyte SByte_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern byte byte_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern byte byte_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void NSDecimal_objc_msgSend_stret(out NSDecimal retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void NSDecimal_objc_msgSendSuper_stret(out NSDecimal retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_SByte(IntPtr receiver, IntPtr selector, sbyte arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_SByte(IntPtr receiver, IntPtr selector, sbyte arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_byte(IntPtr receiver, IntPtr selector, byte arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_byte(IntPtr receiver, IntPtr selector, byte arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_short(IntPtr receiver, IntPtr selector, short arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_short(IntPtr receiver, IntPtr selector, short arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt16(IntPtr receiver, IntPtr selector, ushort arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt16(IntPtr receiver, IntPtr selector, ushort arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_float(IntPtr receiver, IntPtr selector, float arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_float(IntPtr receiver, IntPtr selector, float arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Int64_short_bool(IntPtr receiver, IntPtr selector, long arg1, short arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_short_bool(IntPtr receiver, IntPtr selector, long arg1, short arg2, bool arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_NSDecimal(IntPtr receiver, IntPtr selector, NSDecimal arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_NSDecimal(IntPtr receiver, IntPtr selector, NSDecimal arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_short_IntPtr(IntPtr receiver, IntPtr selector, short arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_short_IntPtr(IntPtr receiver, IntPtr selector, short arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt32_UInt64(IntPtr receiver, IntPtr selector, uint arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt64(IntPtr receiver, IntPtr selector, uint arg1, ulong arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_UInt64_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, ulong arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, ulong arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_bool_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_out_Boolean(IntPtr receiver, IntPtr selector, IntPtr arg1, out bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_out_Boolean(IntPtr receiver, IntPtr selector, IntPtr arg1, out bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_UInt64_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3, bool arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_UInt64_IntPtr_bool_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3, bool arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4, IntPtr arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_bool_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_bool_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern int int_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ulong arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern int int_objc_msgSendSuper_IntPtr_IntPtr_UInt64_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ulong arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_out_NSPropertyListFormat_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, out NSPropertyListFormat arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_out_NSPropertyListFormat_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, out NSPropertyListFormat arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_int_IntPtr_int_float_float(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3, float arg4, float arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_int_float_float(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3, float arg4, float arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_int_IntPtr_int_float(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3, float arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_int_float(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3, float arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_int_IntPtr_int(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_int(IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, int arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CATransform3D_objc_msgSend_stret(out CATransform3D retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CATransform3D_objc_msgSendSuper_stret(out CATransform3D retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_CATransform3D(IntPtr receiver, IntPtr selector, CATransform3D arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_CATransform3D(IntPtr receiver, IntPtr selector, CATransform3D arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern double Double_objc_msgSend_Double_IntPtr(IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern double Double_objc_msgSendSuper_Double_IntPtr(IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_float_float_float_float(IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_float_float_float_float(IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_Double_out_CVTimeStamp(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, out CVTimeStamp arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_Double_out_CVTimeStamp(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, out CVTimeStamp arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_Double_out_CVTimeStamp(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, out CVTimeStamp arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Double_out_CVTimeStamp(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, out CVTimeStamp arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_UInt32_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_UInt32_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3, IntPtr arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Double_Double_Double(IntPtr receiver, IntPtr selector, double arg1, double arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Double_Double_Double(IntPtr receiver, IntPtr selector, double arg1, double arg2, double arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_CGPoint_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGRect arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_CGPoint_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGRect arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_CGRect_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGRect arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_CGRect_CGRect(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGRect arg3);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGRect_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, long arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGRect_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, long arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGSize_IntPtr(IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGSize_IntPtr(IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern void void_objc_msgSend_IntPtr_IntPtr_Int64_CGRect_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, CGRect arg4, long arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Int64_CGRect_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, CGRect arg4, long arg5, IntPtr arg6);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGAffineTransform_bool(IntPtr receiver, IntPtr selector, CGAffineTransform arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGAffineTransform_bool(IntPtr receiver, IntPtr selector, CGAffineTransform arg1, bool arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_CGSize_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, CGSize arg3, long arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_CGSize_Int64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, CGSize arg3, long arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_UInt64_CGSize_bool_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, CGSize arg2, bool arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_CGSize_bool_IntPtr(IntPtr receiver, IntPtr selector, ulong arg1, CGSize arg2, bool arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_Int64_CGSize_bool_IntPtr(IntPtr receiver, IntPtr selector, long arg1, CGSize arg2, bool arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_CGSize_bool_IntPtr(IntPtr receiver, IntPtr selector, long arg1, CGSize arg2, bool arg3, IntPtr arg4);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGAffineTransform(IntPtr receiver, IntPtr selector, CGAffineTransform arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGAffineTransform(IntPtr receiver, IntPtr selector, CGAffineTransform arg1);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CGRect_Int64(IntPtr receiver, IntPtr selector, CGRect arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_Int64(IntPtr receiver, IntPtr selector, CGRect arg1, long arg2);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
	public static extern void CLLocationCoordinate2D_objc_msgSend_stret(out CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
	public static extern void CLLocationCoordinate2D_objc_msgSendSuper_stret(out CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern CLLocationCoordinate2D CLLocationCoordinate2D_objc_msgSend(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern CLLocationCoordinate2D CLLocationCoordinate2D_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_IntPtr(IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, double arg3, double arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_IntPtr(IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, double arg3, double arg4, IntPtr arg5);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	public static extern IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr(IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, double arg3, double arg4, double arg5, double arg6, IntPtr arg7);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
	public static extern IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr(IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, double arg3, double arg4, double arg5, double arg6, IntPtr arg7);

    #region
    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern nfloat nfloat_objc_msgSend(IntPtr receiver, IntPtr selector);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern nfloat nfloat_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern void void_objc_msgSend_nfloat(IntPtr receiver, IntPtr selector, nfloat arg1);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern void void_objc_msgSendSuper_nfloat(IntPtr receiver, IntPtr selector, nfloat arg1);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern IntPtr IntPtr_objc_msgSend_long(IntPtr receiver, IntPtr selector, long arg1);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern IntPtr IntPtr_objc_msgSendSuper_long(IntPtr receiver, IntPtr selector, long arg1);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_bool(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern long long_objc_msgSend(IntPtr receiver, IntPtr selector);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern long long_objc_msgSendSuper(IntPtr receiver, IntPtr selector);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern bool bool_objc_msgSend_IntPtr_ref_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern bool bool_objc_msgSendSuper_IntPtr_ref_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern bool bool_objc_msgSend_IntPtr_UInt32_ref_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref IntPtr arg3);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern bool bool_objc_msgSendSuper_IntPtr_UInt32_ref_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref IntPtr arg3);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4, IntPtr arg5);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4, IntPtr arg5);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern IntPtr IntPtr_objc_msgSend_IntPtr_ref_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern nuint nuint_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern nuint nuint_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern IntPtr IntPtr_objc_msgSend_nuint(IntPtr receiver, IntPtr selector, nuint arg1);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern IntPtr IntPtr_objc_msgSendSuper_nuint(IntPtr receiver, IntPtr selector, nuint arg1);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern IntPtr IntPtr_objc_msgSend_IntPtr_long(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_long(IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern void void_objc_msgSend_IntPtr_nuint(IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern void void_objc_msgSendSuper_IntPtr_nuint(IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern IntPtr IntPtr_objc_msgSend_UInt32_IntPtr(IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr(IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern IntPtr IntPtr_objc_msgSend_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_IntPtr(IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern void void_objc_msgSend_nfloat_CGPoint(IntPtr receiver, IntPtr selector, nfloat arg1, CGPoint arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern void void_objc_msgSendSuper_nfloat_CGPoint(IntPtr receiver, IntPtr selector, nfloat arg1, CGPoint arg2);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_long(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

    [DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
    public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_long(IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

 

    //[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
    //public static extern IntPtr IntPtr_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);
    #endregion

}

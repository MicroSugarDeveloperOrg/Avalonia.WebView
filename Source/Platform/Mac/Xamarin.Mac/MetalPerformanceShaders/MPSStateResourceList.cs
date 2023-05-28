using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSStateResourceList", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
public class MPSStateResourceList : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendBuffer_ = "appendBuffer:";

	private static readonly IntPtr selAppendBuffer_Handle = Selector.GetHandle("appendBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendTexture_ = "appendTexture:";

	private static readonly IntPtr selAppendTexture_Handle = Selector.GetHandle("appendTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceList = "resourceList";

	private static readonly IntPtr selResourceListHandle = Selector.GetHandle("resourceList");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSStateResourceList");

	public override IntPtr ClassHandle => class_ptr;

	public static MPSStateResourceList Create(params MTLTextureDescriptor[] descriptors)
	{
		if (descriptors == null)
		{
			throw new ArgumentNullException("descriptors");
		}
		if (descriptors.Length > 10)
		{
			throw new ArgumentException("Only 10 parameters are currently supported.");
		}
		IntPtr[] array = new IntPtr[10];
		for (int i = 0; i < descriptors.Length; i++)
		{
			if (descriptors[i] == null)
			{
				throw new ArgumentException(string.Format("'{0}[{1}]' was null.", "descriptors", i));
			}
			array[i] = descriptors[i].Handle;
		}
		return Runtime.GetNSObject<MPSStateResourceList>(IntPtr_objc_msgSend_IntPtrx13(class_ptr, Selector.GetHandle("resourceListWithTextureDescriptors:"), array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9], IntPtr.Zero));
	}

	public unsafe static MPSStateResourceList Create(params nuint[] bufferSizes)
	{
		if (bufferSizes == null)
		{
			throw new ArgumentNullException("bufferSizes");
		}
		if (bufferSizes.Length > 10)
		{
			throw new ArgumentException("Only 10 parameters are currently supported.");
		}
		IntPtr[] array = new IntPtr[10];
		fixed (nuint* ptr = bufferSizes)
		{
			Marshal.Copy((IntPtr)ptr, array, 0, bufferSizes.Length);
		}
		return Runtime.GetNSObject<MPSStateResourceList>(IntPtr_objc_msgSend_IntPtrx13(class_ptr, Selector.GetHandle("resourceListWithBufferSizes:"), array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9], IntPtr.Zero));
	}

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
	private static extern IntPtr IntPtr_objc_msgSend_IntPtrx13(IntPtr receiver, IntPtr selector, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MPSStateResourceList()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSStateResourceList(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSStateResourceList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("appendTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Append(MTLTextureDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendTexture_Handle, descriptor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendTexture_Handle, descriptor.Handle);
		}
	}

	[Export("appendBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Append(nuint bufferSize)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selAppendBuffer_Handle, bufferSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selAppendBuffer_Handle, bufferSize);
		}
	}

	[Export("resourceList")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSStateResourceList Create()
	{
		return Runtime.GetNSObject<MPSStateResourceList>(Messaging.IntPtr_objc_msgSend(class_ptr, selResourceListHandle));
	}
}

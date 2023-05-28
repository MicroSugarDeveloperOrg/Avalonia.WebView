using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewCompositionalLayout", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionViewCompositionalLayout : NSCollectionViewLayout
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfiguration = "configuration";

	private static readonly IntPtr selConfigurationHandle = Selector.GetHandle("configuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSection_ = "initWithSection:";

	private static readonly IntPtr selInitWithSection_Handle = Selector.GetHandle("initWithSection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSection_Configuration_ = "initWithSection:configuration:";

	private static readonly IntPtr selInitWithSection_Configuration_Handle = Selector.GetHandle("initWithSection:configuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSectionProvider_ = "initWithSectionProvider:";

	private static readonly IntPtr selInitWithSectionProvider_Handle = Selector.GetHandle("initWithSectionProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSectionProvider_Configuration_ = "initWithSectionProvider:configuration:";

	private static readonly IntPtr selInitWithSectionProvider_Configuration_Handle = Selector.GetHandle("initWithSectionProvider:configuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConfiguration_ = "setConfiguration:";

	private static readonly IntPtr selSetConfiguration_Handle = Selector.GetHandle("setConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewCompositionalLayout");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewCompositionalLayoutConfiguration Configuration
	{
		[Export("configuration", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionViewCompositionalLayoutConfiguration>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationHandle));
			}
			return Runtime.GetNSObject<NSCollectionViewCompositionalLayoutConfiguration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationHandle));
		}
		[Export("setConfiguration:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConfiguration_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConfiguration_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCollectionViewCompositionalLayout(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionViewCompositionalLayout(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewCompositionalLayout(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCollectionViewCompositionalLayout(NSCollectionLayoutSection section)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (section == null)
		{
			throw new ArgumentNullException("section");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSection_Handle, section.Handle), "initWithSection:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSection_Handle, section.Handle), "initWithSection:");
		}
	}

	[Export("initWithSection:configuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCollectionViewCompositionalLayout(NSCollectionLayoutSection section, NSCollectionViewCompositionalLayoutConfiguration configuration)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (section == null)
		{
			throw new ArgumentNullException("section");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSection_Configuration_Handle, section.Handle, configuration.Handle), "initWithSection:configuration:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSection_Configuration_Handle, section.Handle, configuration.Handle), "initWithSection:configuration:");
		}
	}

	[Export("initWithSectionProvider:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSCollectionViewCompositionalLayout([BlockProxy(typeof(Trampolines.NIDNSCollectionViewCompositionalLayoutSectionProvider))] NSCollectionViewCompositionalLayoutSectionProvider sectionProvider)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (sectionProvider == null)
		{
			throw new ArgumentNullException("sectionProvider");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSCollectionViewCompositionalLayoutSectionProvider.Handler, sectionProvider);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSectionProvider_Handle, (IntPtr)ptr), "initWithSectionProvider:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSectionProvider_Handle, (IntPtr)ptr), "initWithSectionProvider:");
		}
		ptr->CleanupBlock();
	}

	[Export("initWithSectionProvider:configuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSCollectionViewCompositionalLayout([BlockProxy(typeof(Trampolines.NIDNSCollectionViewCompositionalLayoutSectionProvider))] NSCollectionViewCompositionalLayoutSectionProvider sectionProvider, NSCollectionViewCompositionalLayoutConfiguration configuration)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (sectionProvider == null)
		{
			throw new ArgumentNullException("sectionProvider");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSCollectionViewCompositionalLayoutSectionProvider.Handler, sectionProvider);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSectionProvider_Configuration_Handle, (IntPtr)ptr, configuration.Handle), "initWithSectionProvider:configuration:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSectionProvider_Configuration_Handle, (IntPtr)ptr, configuration.Handle), "initWithSectionProvider:configuration:");
		}
		ptr->CleanupBlock();
	}
}

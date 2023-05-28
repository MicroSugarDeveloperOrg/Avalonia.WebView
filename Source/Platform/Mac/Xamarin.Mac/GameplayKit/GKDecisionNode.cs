using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

[Register("GKDecisionNode", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKDecisionNode : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateBranchWithPredicate_Attribute_ = "createBranchWithPredicate:attribute:";

	private static readonly IntPtr selCreateBranchWithPredicate_Attribute_Handle = Selector.GetHandle("createBranchWithPredicate:attribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateBranchWithValue_Attribute_ = "createBranchWithValue:attribute:";

	private static readonly IntPtr selCreateBranchWithValue_Attribute_Handle = Selector.GetHandle("createBranchWithValue:attribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateBranchWithWeight_Attribute_ = "createBranchWithWeight:attribute:";

	private static readonly IntPtr selCreateBranchWithWeight_Attribute_Handle = Selector.GetHandle("createBranchWithWeight:attribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKDecisionNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKDecisionNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKDecisionNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("createBranchWithValue:attribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKDecisionNode CreateBranch(NSNumber value, NSObject attribute)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GKDecisionNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateBranchWithValue_Attribute_Handle, value.Handle, attribute.Handle));
		}
		return Runtime.GetNSObject<GKDecisionNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateBranchWithValue_Attribute_Handle, value.Handle, attribute.Handle));
	}

	[Export("createBranchWithPredicate:attribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKDecisionNode CreateBranch(NSPredicate predicate, NSObject attribute)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GKDecisionNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateBranchWithPredicate_Attribute_Handle, predicate.Handle, attribute.Handle));
		}
		return Runtime.GetNSObject<GKDecisionNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateBranchWithPredicate_Attribute_Handle, predicate.Handle, attribute.Handle));
	}

	[Export("createBranchWithWeight:attribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKDecisionNode CreateBranch(nint weight, NSObject attribute)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GKDecisionNode>(Messaging.IntPtr_objc_msgSend_nint_IntPtr(base.Handle, selCreateBranchWithWeight_Attribute_Handle, weight, attribute.Handle));
		}
		return Runtime.GetNSObject<GKDecisionNode>(Messaging.IntPtr_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selCreateBranchWithWeight_Attribute_Handle, weight, attribute.Handle));
	}
}

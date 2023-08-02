using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace JavaScriptCore;

[Register("JSVirtualMachine", true)]
public class JSVirtualMachine : NSObject
{
    private const string selAddManagedReference_WithOwner_ = "addManagedReference:withOwner:";
    private static readonly IntPtr selAddManagedReference_WithOwner_Handle = Selector.GetHandle("addManagedReference:withOwner:");

    private const string selInit = "init";
    private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

    private const string selRemoveManagedReference_WithOwner_ = "removeManagedReference:withOwner:";
    private static readonly IntPtr selRemoveManagedReference_WithOwner_Handle = Selector.GetHandle("removeManagedReference:withOwner:");

    private static readonly IntPtr class_ptr =  Class.GetHandle("JSVirtualMachine");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected JSVirtualMachine(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal JSVirtualMachine(IntPtr handle)
        : base(handle)
    {
    }

    [Export("init")]
    public JSVirtualMachine()
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [Export("addManagedReference:withOwner:")]
    public virtual void AddManagedReference(NSObject obj, NSObject owner)
    {
        if (obj == null)
        {
            throw new ArgumentNullException("obj");
        }
        if (owner == null)
        {
            throw new ArgumentNullException("owner");
        }
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddManagedReference_WithOwner_Handle, obj.Handle, owner.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddManagedReference_WithOwner_Handle, obj.Handle, owner.Handle);
        }
    }

    [Export("removeManagedReference:withOwner:")]
    public virtual void RemoveManagedReference(NSObject obj, NSObject owner)
    {
        if (obj == null)
        {
            throw new ArgumentNullException("obj");
        }
        if (owner == null)
        {
            throw new ArgumentNullException("owner");
        }
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveManagedReference_WithOwner_Handle, obj.Handle, owner.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveManagedReference_WithOwner_Handle, obj.Handle, owner.Handle);
        }
    }
}

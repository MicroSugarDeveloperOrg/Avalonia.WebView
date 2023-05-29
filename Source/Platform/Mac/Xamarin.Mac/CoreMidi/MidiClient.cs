using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CoreMidi;

public class MidiClient : MidiObject
{
	private struct MidiObjectAddRemoveNotification
	{
		public MidiNotificationMessageId id;

		public int MessageSize;

		public IntPtr Parent;

		public MidiObjectType ParentType;

		public IntPtr Child;

		public MidiObjectType ChildType;
	}

	private struct MidiObjectPropertyChangeNotification
	{
		public MidiNotificationMessageId id;

		public int MessageSize;

		public IntPtr ObjectHandle;

		public MidiObjectType ObjectType;

		public IntPtr PropertyName;
	}

	private struct MidiIOErrorNotification
	{
		public MidiNotificationMessageId id;

		public int MessageSize;

		public IntPtr DeviceRef;

		public int ErrorCode;
	}

	private GCHandle gch;

	public string Name { get; private set; }

	public event EventHandler SetupChanged;

	public event EventHandler<ObjectAddedOrRemovedEventArgs> ObjectAdded;

	public event EventHandler<ObjectAddedOrRemovedEventArgs> ObjectRemoved;

	public event EventHandler<ObjectPropertyChangedEventArgs> PropertyChanged;

	public event EventHandler ThruConnectionsChanged;

	public event EventHandler SerialPortOwnerChanged;

	public event EventHandler<IOErrorEventArgs> IOError;

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIClientCreate(IntPtr str, MidiNotifyProc callback, IntPtr context, out IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIClientDispose(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDISourceCreate(IntPtr handle, IntPtr name, out IntPtr endpoint);

	internal override void DisposeHandle()
	{
		if (handle != IntPtr.Zero)
		{
			if (owns)
			{
				MIDIClientDispose(handle);
			}
			handle = IntPtr.Zero;
			gch.Free();
		}
	}

	public MidiClient(string name)
	{
		using NSString nSString = new NSString(name);
		gch = GCHandle.Alloc(this);
		int num = MIDIClientCreate(nSString.Handle, ClientCallback, GCHandle.ToIntPtr(gch), out handle);
		if (num != 0)
		{
			gch.Free();
			handle = IntPtr.Zero;
			throw new MidiException((MidiError)num);
		}
		Name = name;
	}

	public override string ToString()
	{
		return Name;
	}

	public MidiEndpoint CreateVirtualSource(string name)
	{
		using NSString nSString = new NSString(name);
		if (MIDISourceCreate(handle, nSString.Handle, out var endpoint) != 0)
		{
			return null;
		}
		return new MidiEndpoint(endpoint, owns: true);
	}

	public MidiPort CreateInputPort(string name)
	{
		return new MidiPort(this, name, input: true);
	}

	public MidiPort CreateOutputPort(string name)
	{
		return new MidiPort(this, name, input: false);
	}

	private static void ClientCallback(IntPtr message, IntPtr context)
	{
		MidiClient midiClient = (MidiClient)GCHandle.FromIntPtr(context).Target;
		switch ((MidiNotificationMessageId)Marshal.ReadInt32(message))
		{
		case MidiNotificationMessageId.SetupChanged:
			midiClient.SetupChanged?.Invoke(midiClient, EventArgs.Empty);
			break;
		case MidiNotificationMessageId.ObjectAdded:
		{
			EventHandler<ObjectAddedOrRemovedEventArgs> objectAdded = midiClient.ObjectAdded;
			if (objectAdded != null)
			{
				MidiObjectAddRemoveNotification midiObjectAddRemoveNotification = (MidiObjectAddRemoveNotification)Marshal.PtrToStructure(message, typeof(MidiObjectAddRemoveNotification));
				objectAdded(midiClient, new ObjectAddedOrRemovedEventArgs(MidiObject.MidiObjectFromType(midiObjectAddRemoveNotification.ParentType, midiObjectAddRemoveNotification.Parent), MidiObject.MidiObjectFromType(midiObjectAddRemoveNotification.ChildType, midiObjectAddRemoveNotification.Child)));
			}
			break;
		}
		case MidiNotificationMessageId.ObjectRemoved:
		{
			EventHandler<ObjectAddedOrRemovedEventArgs> objectRemoved = midiClient.ObjectRemoved;
			if (objectRemoved != null)
			{
				MidiObjectAddRemoveNotification midiObjectAddRemoveNotification2 = (MidiObjectAddRemoveNotification)Marshal.PtrToStructure(message, typeof(MidiObjectAddRemoveNotification));
				objectRemoved(midiClient, new ObjectAddedOrRemovedEventArgs(MidiObject.MidiObjectFromType(midiObjectAddRemoveNotification2.ParentType, midiObjectAddRemoveNotification2.Parent), MidiObject.MidiObjectFromType(midiObjectAddRemoveNotification2.ChildType, midiObjectAddRemoveNotification2.Child)));
			}
			break;
		}
		case MidiNotificationMessageId.PropertyChanged:
		{
			EventHandler<ObjectPropertyChangedEventArgs> propertyChanged = midiClient.PropertyChanged;
			if (propertyChanged != null)
			{
				MidiObjectPropertyChangeNotification midiObjectPropertyChangeNotification = (MidiObjectPropertyChangeNotification)Marshal.PtrToStructure(message, typeof(MidiObjectPropertyChangeNotification));
				propertyChanged(midiClient, new ObjectPropertyChangedEventArgs(MidiObject.MidiObjectFromType(midiObjectPropertyChangeNotification.ObjectType, midiObjectPropertyChangeNotification.ObjectHandle), NSString.FromHandle(midiObjectPropertyChangeNotification.PropertyName)));
			}
			break;
		}
		case MidiNotificationMessageId.ThruConnectionsChanged:
			midiClient.ThruConnectionsChanged?.Invoke(midiClient, EventArgs.Empty);
			break;
		case MidiNotificationMessageId.SerialPortOwnerChanged:
			midiClient.SerialPortOwnerChanged?.Invoke(midiClient, EventArgs.Empty);
			break;
		case MidiNotificationMessageId.IOError:
		{
			EventHandler<IOErrorEventArgs> iOError = midiClient.IOError;
			if (iOError != null)
			{
				MidiIOErrorNotification midiIOErrorNotification = (MidiIOErrorNotification)Marshal.PtrToStructure(message, typeof(MidiIOErrorNotification));
				iOError(midiClient, new IOErrorEventArgs(new MidiDevice(midiIOErrorNotification.DeviceRef), midiIOErrorNotification.ErrorCode));
			}
			break;
		}
		}
	}

	public override void Dispose(bool disposing)
	{
		this.SetupChanged = null;
		this.ObjectAdded = null;
		this.ObjectRemoved = null;
		this.PropertyChanged = null;
		this.ThruConnectionsChanged = null;
		this.SerialPortOwnerChanged = null;
		this.IOError = null;
		base.Dispose(disposing);
	}
}

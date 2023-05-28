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

		public int Parent;

		public MidiObjectType ParentType;

		public int Child;

		public MidiObjectType ChildType;
	}

	private struct MidiObjectPropertyChangeNotification
	{
		public MidiNotificationMessageId id;

		public int MessageSize;

		public int ObjectHandle;

		public MidiObjectType ObjectType;

		public IntPtr PropertyName;
	}

	private struct MidiIOErrorNotification
	{
		public MidiNotificationMessageId id;

		public int MessageSize;

		public int DeviceRef;

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
	private static extern int MIDIClientCreate(IntPtr str, MidiNotifyProc callback, IntPtr context, out int handle);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDIClientDispose(int handle);

	[DllImport("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI")]
	private static extern int MIDISourceCreate(int handle, IntPtr name, out int endpoint);

	internal override void DisposeHandle()
	{
		if (handle != 0)
		{
			if (owns)
			{
				MIDIClientDispose(handle);
			}
			handle = 0;
		}
		if (gch.IsAllocated)
		{
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
			handle = 0;
			throw new MidiException((MidiError)num);
		}
		Name = name;
	}

	public override string ToString()
	{
		return Name;
	}

	public MidiEndpoint CreateVirtualSource(string name, out MidiError statusCode)
	{
		using NSString nSString = new NSString(name);
		int endpoint;
		int num = MIDISourceCreate(handle, nSString.Handle, out endpoint);
		if (num != 0)
		{
			statusCode = (MidiError)num;
			return null;
		}
		statusCode = MidiError.Ok;
		return new MidiEndpoint(endpoint, owns: true);
	}

	public MidiEndpoint CreateVirtualDestination(string name, out MidiError status)
	{
		MidiEndpoint midiEndpoint = new MidiEndpoint(this, name, out status);
		if (status == MidiError.Ok)
		{
			return midiEndpoint;
		}
		midiEndpoint.Dispose();
		return null;
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

	protected override void Dispose(bool disposing)
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

using System;
using Foundation;
using ObjCRuntime;

namespace iTunesLibrary;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class ITLibPlaylistPropertyExtensions
{
	private static IntPtr[] values = new IntPtr[8];

	[Field("ITLibPlaylistPropertyName", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibPlaylistPropertyName
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyName", storage);
			}
		}
	}

	[Field("ITLibPlaylistPropertyAllItemsPlaylist", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibPlaylistPropertyAllItemsPlaylist
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyAllItemsPlaylist", storage);
			}
		}
	}

	[Field("ITLibPlaylistPropertyDistinguisedKind", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibPlaylistPropertyDistinguisedKind
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyDistinguisedKind", storage);
			}
		}
	}

	[Field("ITLibPlaylistPropertyMaster", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibPlaylistPropertyMaster
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyMaster", storage);
			}
		}
	}

	[Field("ITLibPlaylistPropertyParentPersistentID", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibPlaylistPropertyParentPersistentID
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyParentPersistentID", storage);
			}
		}
	}

	[Field("ITLibPlaylistPropertyVisible", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibPlaylistPropertyVisible
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyVisible", storage);
			}
		}
	}

	[Field("ITLibPlaylistPropertyItems", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibPlaylistPropertyItems
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyItems", storage);
			}
		}
	}

	[Field("ITLibPlaylistPropertyKind", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibPlaylistPropertyKind
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyKind", storage);
			}
		}
	}

	public static NSString? GetConstant(this ITLibPlaylistProperty self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = ITLibPlaylistPropertyName;
			break;
		case 1:
			ptr = ITLibPlaylistPropertyAllItemsPlaylist;
			break;
		case 2:
			ptr = ITLibPlaylistPropertyDistinguisedKind;
			break;
		case 3:
			ptr = ITLibPlaylistPropertyMaster;
			break;
		case 4:
			ptr = ITLibPlaylistPropertyParentPersistentID;
			break;
		case 5:
			ptr = ITLibPlaylistPropertyVisible;
			break;
		case 6:
			ptr = ITLibPlaylistPropertyItems;
			break;
		case 7:
			ptr = ITLibPlaylistPropertyKind;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static ITLibPlaylistProperty GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(ITLibPlaylistPropertyName))
		{
			return ITLibPlaylistProperty.Name;
		}
		if (constant.IsEqualTo(ITLibPlaylistPropertyAllItemsPlaylist))
		{
			return ITLibPlaylistProperty.AllItemsPlaylist;
		}
		if (constant.IsEqualTo(ITLibPlaylistPropertyDistinguisedKind))
		{
			return ITLibPlaylistProperty.DistinguisedKind;
		}
		if (constant.IsEqualTo(ITLibPlaylistPropertyMaster))
		{
			return ITLibPlaylistProperty.Master;
		}
		if (constant.IsEqualTo(ITLibPlaylistPropertyParentPersistentID))
		{
			return ITLibPlaylistProperty.ParentPersistentId;
		}
		if (constant.IsEqualTo(ITLibPlaylistPropertyVisible))
		{
			return ITLibPlaylistProperty.Visible;
		}
		if (constant.IsEqualTo(ITLibPlaylistPropertyItems))
		{
			return ITLibPlaylistProperty.Items;
		}
		if (constant.IsEqualTo(ITLibPlaylistPropertyKind))
		{
			return ITLibPlaylistProperty.Kind;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

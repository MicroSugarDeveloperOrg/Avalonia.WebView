using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Security;

public class Authorization : INativeObject, IDisposable
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private unsafe static extern int AuthorizationCreate(AuthorizationItemSet* rights, AuthorizationItemSet* environment, AuthorizationFlags flags, out IntPtr auth);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern int AuthorizationExecuteWithPrivileges(IntPtr handle, string pathToTool, AuthorizationFlags flags, string[] args, IntPtr FILEPtr);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern int AuthorizationFree(IntPtr handle, AuthorizationFlags flags);

	internal Authorization(IntPtr handle)
	{
		this.handle = handle;
	}

	public int ExecuteWithPrivileges(string pathToTool, AuthorizationFlags flags, string[] args)
	{
		return AuthorizationExecuteWithPrivileges(handle, pathToTool, flags, args, IntPtr.Zero);
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
		Dispose(AuthorizationFlags.Defaults, disposing: true);
	}

	~Authorization()
	{
		Dispose(AuthorizationFlags.Defaults, disposing: false);
	}

	public virtual void Dispose(AuthorizationFlags flags, bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			AuthorizationFree(handle, flags);
			handle = IntPtr.Zero;
		}
	}

	public static Authorization Create(AuthorizationFlags flags)
	{
		return Create(null, null, flags);
	}

	private static void EncodeString(ref AuthorizationItem item, string key, string value)
	{
		item.name = Messaging.NativeUtf8FromString(key);
		if (value != null)
		{
			item.value = Messaging.NativeUtf8FromString(value);
			item.valueLen = (IntPtr)value.Length;
		}
	}

	public unsafe static Authorization Create(AuthorizationParameters parameters, AuthorizationEnvironment environment, AuthorizationFlags flags)
	{
		AuthorizationItemSet authorizationItemSet = default(AuthorizationItemSet);
		AuthorizationItemSet* ptr = null;
		AuthorizationItem* ptr2 = null;
		AuthorizationItemSet authorizationItemSet2 = default(AuthorizationItemSet);
		AuthorizationItemSet* ptr3 = null;
		AuthorizationItem* ptr4 = null;
		try
		{
			if (parameters != null)
			{
				ptr = &authorizationItemSet;
				authorizationItemSet.ptrToAuthorization = (AuthorizationItem*)(void*)Marshal.AllocHGlobal(sizeof(AuthorizationItem) * 3);
				if (parameters.PathToSystemPrivilegeTool != null)
				{
					EncodeString(ref authorizationItemSet.ptrToAuthorization[authorizationItemSet.count++], "system.privilege.admin", parameters.PathToSystemPrivilegeTool);
				}
				if (parameters.Prompt != null)
				{
					EncodeString(ref authorizationItemSet.ptrToAuthorization[authorizationItemSet.count++], "prompt", parameters.Prompt);
				}
				if (parameters.IconPath != null)
				{
					EncodeString(ref authorizationItemSet.ptrToAuthorization[authorizationItemSet.count++], "prompt", parameters.IconPath);
				}
			}
			if (environment != null)
			{
				ptr3 = &authorizationItemSet2;
				authorizationItemSet2.ptrToAuthorization = (AuthorizationItem*)(void*)Marshal.AllocHGlobal(sizeof(AuthorizationItem) * 3);
				if (environment.Username != null)
				{
					EncodeString(ref authorizationItemSet2.ptrToAuthorization[authorizationItemSet2.count++], "username", environment.Username);
				}
				if (environment.Password != null)
				{
					EncodeString(ref authorizationItemSet2.ptrToAuthorization[authorizationItemSet2.count++], "password", environment.Password);
				}
				if (environment.AddToSharedCredentialPool)
				{
					EncodeString(ref authorizationItemSet2.ptrToAuthorization[authorizationItemSet2.count++], "shared", null);
				}
			}
			if (AuthorizationCreate(ptr, ptr3, flags, out var auth) != 0)
			{
				return null;
			}
			return new Authorization(auth);
		}
		finally
		{
			if (ptr != null)
			{
				for (int i = 0; i < authorizationItemSet.count; i++)
				{
					Marshal.FreeHGlobal(authorizationItemSet.ptrToAuthorization[i].name);
					Marshal.FreeHGlobal(authorizationItemSet.ptrToAuthorization[i].value);
				}
				Marshal.FreeHGlobal((IntPtr)authorizationItemSet.ptrToAuthorization);
			}
			if (ptr3 != null)
			{
				for (int j = 0; j < authorizationItemSet2.count; j++)
				{
					Marshal.FreeHGlobal(authorizationItemSet2.ptrToAuthorization[j].name);
					if (authorizationItemSet2.ptrToAuthorization[j].value != IntPtr.Zero)
					{
						Marshal.FreeHGlobal(authorizationItemSet2.ptrToAuthorization[j].value);
					}
				}
				Marshal.FreeHGlobal((IntPtr)authorizationItemSet2.ptrToAuthorization);
			}
		}
	}
}

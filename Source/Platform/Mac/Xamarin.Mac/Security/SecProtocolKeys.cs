using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

internal static class SecProtocolKeys
{
	[Field("kSecAttrProtocolAFP", "Security")]
	public static IntPtr AFP => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolAFP");

	[Field("kSecAttrProtocolAppleTalk", "Security")]
	public static IntPtr AppleTalk => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolAppleTalk");

	[Field("kSecAttrProtocolDAAP", "Security")]
	public static IntPtr DAAP => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolDAAP");

	[Field("kSecAttrProtocolEPPC", "Security")]
	public static IntPtr EPPC => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolEPPC");

	[Field("kSecAttrProtocolFTP", "Security")]
	public static IntPtr FTP => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolFTP");

	[Field("kSecAttrProtocolFTPAccount", "Security")]
	public static IntPtr FTPAccount => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolFTPAccount");

	[Field("kSecAttrProtocolFTPProxy", "Security")]
	public static IntPtr FTPProxy => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolFTPProxy");

	[Field("kSecAttrProtocolFTPS", "Security")]
	public static IntPtr FTPS => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolFTPS");

	[Field("kSecAttrProtocolHTTP", "Security")]
	public static IntPtr HTTP => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolHTTP");

	[Field("kSecAttrProtocolHTTPProxy", "Security")]
	public static IntPtr HTTPProxy => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolHTTPProxy");

	[Field("kSecAttrProtocolHTTPS", "Security")]
	public static IntPtr HTTPS => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolHTTPS");

	[Field("kSecAttrProtocolHTTPSProxy", "Security")]
	public static IntPtr HTTPSProxy => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolHTTPSProxy");

	[Field("kSecAttrProtocolIMAP", "Security")]
	public static IntPtr IMAP => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolIMAP");

	[Field("kSecAttrProtocolIMAPS", "Security")]
	public static IntPtr IMAPS => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolIMAPS");

	[Field("kSecAttrProtocolIPP", "Security")]
	public static IntPtr IPP => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolIPP");

	[Field("kSecAttrProtocolIRC", "Security")]
	public static IntPtr IRC => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolIRC");

	[Field("kSecAttrProtocolIRCS", "Security")]
	public static IntPtr IRCS => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolIRCS");

	[Field("kSecAttrProtocolLDAP", "Security")]
	public static IntPtr LDAP => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolLDAP");

	[Field("kSecAttrProtocolLDAPS", "Security")]
	public static IntPtr LDAPS => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolLDAPS");

	[Field("kSecAttrProtocolNNTP", "Security")]
	public static IntPtr NNTP => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolNNTP");

	[Field("kSecAttrProtocolNNTPS", "Security")]
	public static IntPtr NNTPS => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolNNTPS");

	[Field("kSecAttrProtocolPOP3", "Security")]
	public static IntPtr POP3 => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolPOP3");

	[Field("kSecAttrProtocolPOP3S", "Security")]
	public static IntPtr POP3S => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolPOP3S");

	[Field("kSecAttrProtocolRTSP", "Security")]
	public static IntPtr RTSP => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolRTSP");

	[Field("kSecAttrProtocolRTSPProxy", "Security")]
	public static IntPtr RTSPProxy => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolRTSPProxy");

	[Field("kSecAttrProtocolSMB", "Security")]
	public static IntPtr SMB => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolSMB");

	[Field("kSecAttrProtocolSMTP", "Security")]
	public static IntPtr SMTP => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolSMTP");

	[Field("kSecAttrProtocolSOCKS", "Security")]
	public static IntPtr SOCKS => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolSOCKS");

	[Field("kSecAttrProtocolSSH", "Security")]
	public static IntPtr SSH => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolSSH");

	[Field("kSecAttrProtocolTelnet", "Security")]
	public static IntPtr Telnet => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolTelnet");

	[Field("kSecAttrProtocolTelnetS", "Security")]
	public static IntPtr TelnetS => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocolTelnetS");

	public static IntPtr FromSecProtocol(SecProtocol protocol)
	{
		return protocol switch
		{
			SecProtocol.Ftp => FTP, 
			SecProtocol.FtpAccount => FTPAccount, 
			SecProtocol.Http => HTTP, 
			SecProtocol.Irc => IRC, 
			SecProtocol.Nntp => NNTP, 
			SecProtocol.Pop3 => POP3, 
			SecProtocol.Smtp => SMTP, 
			SecProtocol.Socks => SOCKS, 
			SecProtocol.Imap => IMAP, 
			SecProtocol.Ldap => LDAP, 
			SecProtocol.AppleTalk => AppleTalk, 
			SecProtocol.Afp => AFP, 
			SecProtocol.Telnet => Telnet, 
			SecProtocol.Ssh => SSH, 
			SecProtocol.Ftps => FTPS, 
			SecProtocol.Https => HTTPS, 
			SecProtocol.HttpProxy => HTTPProxy, 
			SecProtocol.HttpsProxy => HTTPSProxy, 
			SecProtocol.FtpProxy => FTPProxy, 
			SecProtocol.Smb => SMB, 
			SecProtocol.Rtsp => RTSP, 
			SecProtocol.RtspProxy => RTSPProxy, 
			SecProtocol.Daap => DAAP, 
			SecProtocol.Eppc => EPPC, 
			SecProtocol.Ipp => IPP, 
			SecProtocol.Nntps => NNTPS, 
			SecProtocol.Ldaps => LDAPS, 
			SecProtocol.Telnets => TelnetS, 
			SecProtocol.Imaps => IMAPS, 
			SecProtocol.Ircs => IRCS, 
			SecProtocol.Pop3s => POP3S, 
			_ => throw new ArgumentException("protocol"), 
		};
	}

	public static SecProtocol ToSecProtocol(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return SecProtocol.Invalid;
		}
		if (CFType.Equal(handle, FTP))
		{
			return SecProtocol.Ftp;
		}
		if (CFType.Equal(handle, FTPAccount))
		{
			return SecProtocol.FtpAccount;
		}
		if (CFType.Equal(handle, HTTP))
		{
			return SecProtocol.Http;
		}
		if (CFType.Equal(handle, IRC))
		{
			return SecProtocol.Irc;
		}
		if (CFType.Equal(handle, NNTP))
		{
			return SecProtocol.Nntp;
		}
		if (CFType.Equal(handle, POP3))
		{
			return SecProtocol.Pop3;
		}
		if (CFType.Equal(handle, SMTP))
		{
			return SecProtocol.Smtp;
		}
		if (CFType.Equal(handle, SOCKS))
		{
			return SecProtocol.Socks;
		}
		if (CFType.Equal(handle, IMAP))
		{
			return SecProtocol.Imap;
		}
		if (CFType.Equal(handle, LDAP))
		{
			return SecProtocol.Ldap;
		}
		if (CFType.Equal(handle, AppleTalk))
		{
			return SecProtocol.AppleTalk;
		}
		if (CFType.Equal(handle, AFP))
		{
			return SecProtocol.Afp;
		}
		if (CFType.Equal(handle, Telnet))
		{
			return SecProtocol.Telnet;
		}
		if (CFType.Equal(handle, SSH))
		{
			return SecProtocol.Ssh;
		}
		if (CFType.Equal(handle, FTPS))
		{
			return SecProtocol.Ftps;
		}
		if (CFType.Equal(handle, HTTPS))
		{
			return SecProtocol.Https;
		}
		if (CFType.Equal(handle, HTTPProxy))
		{
			return SecProtocol.HttpProxy;
		}
		if (CFType.Equal(handle, HTTPSProxy))
		{
			return SecProtocol.HttpsProxy;
		}
		if (CFType.Equal(handle, FTPProxy))
		{
			return SecProtocol.FtpProxy;
		}
		if (CFType.Equal(handle, SMB))
		{
			return SecProtocol.Smb;
		}
		if (CFType.Equal(handle, RTSP))
		{
			return SecProtocol.Rtsp;
		}
		if (CFType.Equal(handle, RTSPProxy))
		{
			return SecProtocol.RtspProxy;
		}
		if (CFType.Equal(handle, DAAP))
		{
			return SecProtocol.Daap;
		}
		if (CFType.Equal(handle, EPPC))
		{
			return SecProtocol.Eppc;
		}
		if (CFType.Equal(handle, IPP))
		{
			return SecProtocol.Ipp;
		}
		if (CFType.Equal(handle, NNTPS))
		{
			return SecProtocol.Nntps;
		}
		if (CFType.Equal(handle, LDAPS))
		{
			return SecProtocol.Ldaps;
		}
		if (CFType.Equal(handle, TelnetS))
		{
			return SecProtocol.Telnets;
		}
		if (CFType.Equal(handle, IMAPS))
		{
			return SecProtocol.Imaps;
		}
		if (CFType.Equal(handle, IRCS))
		{
			return SecProtocol.Ircs;
		}
		if (CFType.Equal(handle, POP3S))
		{
			return SecProtocol.Pop3s;
		}
		return SecProtocol.Invalid;
	}
}

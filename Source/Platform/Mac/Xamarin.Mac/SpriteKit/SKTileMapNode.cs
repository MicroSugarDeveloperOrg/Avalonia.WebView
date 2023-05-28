using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using GameplayKit;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SpriteKit;

[Register("SKTileMapNode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class SKTileMapNode : SKNode, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorPoint = "anchorPoint";

	private static readonly IntPtr selAnchorPointHandle = Selector.GetHandle("anchorPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeValues = "attributeValues";

	private static readonly IntPtr selAttributeValuesHandle = Selector.GetHandle("attributeValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendMode = "blendMode";

	private static readonly IntPtr selBlendModeHandle = Selector.GetHandle("blendMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterOfTileAtColumn_Row_ = "centerOfTileAtColumn:row:";

	private static readonly IntPtr selCenterOfTileAtColumn_Row_Handle = Selector.GetHandle("centerOfTileAtColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor = "color";

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorBlendFactor = "colorBlendFactor";

	private static readonly IntPtr selColorBlendFactorHandle = Selector.GetHandle("colorBlendFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableAutomapping = "enableAutomapping";

	private static readonly IntPtr selEnableAutomappingHandle = Selector.GetHandle("enableAutomapping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillWithTileGroup_ = "fillWithTileGroup:";

	private static readonly IntPtr selFillWithTileGroup_Handle = Selector.GetHandle("fillWithTileGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTileSet_Columns_Rows_TileSize_ = "initWithTileSet:columns:rows:tileSize:";

	private static readonly IntPtr selInitWithTileSet_Columns_Rows_TileSize_Handle = Selector.GetHandle("initWithTileSet:columns:rows:tileSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_ = "initWithTileSet:columns:rows:tileSize:fillWithTileGroup:";

	private static readonly IntPtr selInitWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_Handle = Selector.GetHandle("initWithTileSet:columns:rows:tileSize:fillWithTileGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTileSet_Columns_Rows_TileSize_TileGroupLayout_ = "initWithTileSet:columns:rows:tileSize:tileGroupLayout:";

	private static readonly IntPtr selInitWithTileSet_Columns_Rows_TileSize_TileGroupLayout_Handle = Selector.GetHandle("initWithTileSet:columns:rows:tileSize:tileGroupLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightingBitMask = "lightingBitMask";

	private static readonly IntPtr selLightingBitMaskHandle = Selector.GetHandle("lightingBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapSize = "mapSize";

	private static readonly IntPtr selMapSizeHandle = Selector.GetHandle("mapSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfColumns = "numberOfColumns";

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfRows = "numberOfRows";

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorPoint_ = "setAnchorPoint:";

	private static readonly IntPtr selSetAnchorPoint_Handle = Selector.GetHandle("setAnchorPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeValues_ = "setAttributeValues:";

	private static readonly IntPtr selSetAttributeValues_Handle = Selector.GetHandle("setAttributeValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendMode_ = "setBlendMode:";

	private static readonly IntPtr selSetBlendMode_Handle = Selector.GetHandle("setBlendMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor_ = "setColor:";

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorBlendFactor_ = "setColorBlendFactor:";

	private static readonly IntPtr selSetColorBlendFactor_Handle = Selector.GetHandle("setColorBlendFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnableAutomapping_ = "setEnableAutomapping:";

	private static readonly IntPtr selSetEnableAutomapping_Handle = Selector.GetHandle("setEnableAutomapping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLightingBitMask_ = "setLightingBitMask:";

	private static readonly IntPtr selSetLightingBitMask_Handle = Selector.GetHandle("setLightingBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfColumns_ = "setNumberOfColumns:";

	private static readonly IntPtr selSetNumberOfColumns_Handle = Selector.GetHandle("setNumberOfColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfRows_ = "setNumberOfRows:";

	private static readonly IntPtr selSetNumberOfRows_Handle = Selector.GetHandle("setNumberOfRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShader_ = "setShader:";

	private static readonly IntPtr selSetShader_Handle = Selector.GetHandle("setShader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTileGroup_AndTileDefinition_ForColumn_Row_ = "setTileGroup:andTileDefinition:forColumn:row:";

	private static readonly IntPtr selSetTileGroup_AndTileDefinition_ForColumn_Row_Handle = Selector.GetHandle("setTileGroup:andTileDefinition:forColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTileGroup_ForColumn_Row_ = "setTileGroup:forColumn:row:";

	private static readonly IntPtr selSetTileGroup_ForColumn_Row_Handle = Selector.GetHandle("setTileGroup:forColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTileSet_ = "setTileSet:";

	private static readonly IntPtr selSetTileSet_Handle = Selector.GetHandle("setTileSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTileSize_ = "setTileSize:";

	private static readonly IntPtr selSetTileSize_Handle = Selector.GetHandle("setTileSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForAttributeNamed_ = "setValue:forAttributeNamed:";

	private static readonly IntPtr selSetValue_ForAttributeNamed_Handle = Selector.GetHandle("setValue:forAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShader = "shader";

	private static readonly IntPtr selShaderHandle = Selector.GetHandle("shader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileColumnIndexFromPosition_ = "tileColumnIndexFromPosition:";

	private static readonly IntPtr selTileColumnIndexFromPosition_Handle = Selector.GetHandle("tileColumnIndexFromPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileDefinitionAtColumn_Row_ = "tileDefinitionAtColumn:row:";

	private static readonly IntPtr selTileDefinitionAtColumn_Row_Handle = Selector.GetHandle("tileDefinitionAtColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileGroupAtColumn_Row_ = "tileGroupAtColumn:row:";

	private static readonly IntPtr selTileGroupAtColumn_Row_Handle = Selector.GetHandle("tileGroupAtColumn:row:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileMapNodeWithTileSet_Columns_Rows_TileSize_ = "tileMapNodeWithTileSet:columns:rows:tileSize:";

	private static readonly IntPtr selTileMapNodeWithTileSet_Columns_Rows_TileSize_Handle = Selector.GetHandle("tileMapNodeWithTileSet:columns:rows:tileSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileMapNodeWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_ = "tileMapNodeWithTileSet:columns:rows:tileSize:fillWithTileGroup:";

	private static readonly IntPtr selTileMapNodeWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_Handle = Selector.GetHandle("tileMapNodeWithTileSet:columns:rows:tileSize:fillWithTileGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileMapNodeWithTileSet_Columns_Rows_TileSize_TileGroupLayout_ = "tileMapNodeWithTileSet:columns:rows:tileSize:tileGroupLayout:";

	private static readonly IntPtr selTileMapNodeWithTileSet_Columns_Rows_TileSize_TileGroupLayout_Handle = Selector.GetHandle("tileMapNodeWithTileSet:columns:rows:tileSize:tileGroupLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileMapNodesWithTileSet_Columns_Rows_TileSize_FromNoiseMap_TileTypeNoiseMapThresholds_ = "tileMapNodesWithTileSet:columns:rows:tileSize:fromNoiseMap:tileTypeNoiseMapThresholds:";

	private static readonly IntPtr selTileMapNodesWithTileSet_Columns_Rows_TileSize_FromNoiseMap_TileTypeNoiseMapThresholds_Handle = Selector.GetHandle("tileMapNodesWithTileSet:columns:rows:tileSize:fromNoiseMap:tileTypeNoiseMapThresholds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileRowIndexFromPosition_ = "tileRowIndexFromPosition:";

	private static readonly IntPtr selTileRowIndexFromPosition_Handle = Selector.GetHandle("tileRowIndexFromPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileSet = "tileSet";

	private static readonly IntPtr selTileSetHandle = Selector.GetHandle("tileSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileSize = "tileSize";

	private static readonly IntPtr selTileSizeHandle = Selector.GetHandle("tileSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForAttributeNamed_ = "valueForAttributeNamed:";

	private static readonly IntPtr selValueForAttributeNamed_Handle = Selector.GetHandle("valueForAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKTileMapNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_TileSet_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint AnchorPoint
	{
		[Export("anchorPoint", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selAnchorPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selAnchorPointHandle);
		}
		[Export("setAnchorPoint:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetAnchorPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetAnchorPoint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public new virtual NSDictionary<NSString, SKAttributeValue> AttributeValues
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("attributeValues", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeValuesHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeValuesHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAttributeValues:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributeValues_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeValues_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKBlendMode BlendMode
	{
		[Export("blendMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKBlendMode)Messaging.Int64_objc_msgSend(base.Handle, selBlendModeHandle);
			}
			return (SKBlendMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBlendModeHandle);
		}
		[Export("setBlendMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBlendMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBlendMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor Color
	{
		[Export("color", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle));
		}
		[Export("setColor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ColorBlendFactor
	{
		[Export("colorBlendFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selColorBlendFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selColorBlendFactorHandle);
		}
		[Export("setColorBlendFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetColorBlendFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetColorBlendFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EnableAutomapping
	{
		[Export("enableAutomapping")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnableAutomappingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnableAutomappingHandle);
		}
		[Export("setEnableAutomapping:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnableAutomapping_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnableAutomapping_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint LightingBitMask
	{
		[Export("lightingBitMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selLightingBitMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selLightingBitMaskHandle);
		}
		[Export("setLightingBitMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetLightingBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetLightingBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MapSize
	{
		[Export("mapSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMapSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMapSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfColumns
	{
		[Export("numberOfColumns")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfColumnsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfColumnsHandle);
		}
		[Export("setNumberOfColumns:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetNumberOfColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetNumberOfColumns_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfRows
	{
		[Export("numberOfRows")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfRowsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfRowsHandle);
		}
		[Export("setNumberOfRows:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetNumberOfRows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetNumberOfRows_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKShader? Shader
	{
		[Export("shader", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSend(base.Handle, selShaderHandle));
			}
			return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShaderHandle));
		}
		[Export("setShader:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTileSet TileSet
	{
		[Export("tileSet", ArgumentSemantic.Assign)]
		get
		{
			SKTileSet sKTileSet = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKTileSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTileSetHandle)) : Runtime.GetNSObject<SKTileSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selTileSetHandle)));
			MarkDirty();
			__mt_TileSet_var = sKTileSet;
			return sKTileSet;
		}
		[Export("setTileSet:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTileSet_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTileSet_Handle, value.Handle);
			}
			MarkDirty();
			__mt_TileSet_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize TileSize
	{
		[Export("tileSize", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selTileSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selTileSizeHandle);
		}
		[Export("setTileSize:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetTileSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetTileSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKTileMapNode()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKTileMapNode(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected SKTileMapNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKTileMapNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTileSet:columns:rows:tileSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKTileMapNode(SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize)
		: base(NSObjectFlag.Empty)
	{
		if (tileSet == null)
		{
			throw new ArgumentNullException("tileSet");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_CGSize(base.Handle, selInitWithTileSet_Columns_Rows_TileSize_Handle, tileSet.Handle, columns, rows, tileSize), "initWithTileSet:columns:rows:tileSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_CGSize(base.SuperHandle, selInitWithTileSet_Columns_Rows_TileSize_Handle, tileSet.Handle, columns, rows, tileSize), "initWithTileSet:columns:rows:tileSize:");
		}
	}

	[Export("initWithTileSet:columns:rows:tileSize:fillWithTileGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKTileMapNode(SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup tileGroup)
		: base(NSObjectFlag.Empty)
	{
		if (tileSet == null)
		{
			throw new ArgumentNullException("tileSet");
		}
		if (tileGroup == null)
		{
			throw new ArgumentNullException("tileGroup");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_CGSize_IntPtr(base.Handle, selInitWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_Handle, tileSet.Handle, columns, rows, tileSize, tileGroup.Handle), "initWithTileSet:columns:rows:tileSize:fillWithTileGroup:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_CGSize_IntPtr(base.SuperHandle, selInitWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_Handle, tileSet.Handle, columns, rows, tileSize, tileGroup.Handle), "initWithTileSet:columns:rows:tileSize:fillWithTileGroup:");
		}
	}

	[Export("initWithTileSet:columns:rows:tileSize:tileGroupLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKTileMapNode(SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup[] tileGroupLayout)
		: base(NSObjectFlag.Empty)
	{
		if (tileSet == null)
		{
			throw new ArgumentNullException("tileSet");
		}
		if (tileGroupLayout == null)
		{
			throw new ArgumentNullException("tileGroupLayout");
		}
		NSArray nSArray = NSArray.FromNSObjects(tileGroupLayout);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_CGSize_IntPtr(base.Handle, selInitWithTileSet_Columns_Rows_TileSize_TileGroupLayout_Handle, tileSet.Handle, columns, rows, tileSize, nSArray.Handle), "initWithTileSet:columns:rows:tileSize:tileGroupLayout:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_CGSize_IntPtr(base.SuperHandle, selInitWithTileSet_Columns_Rows_TileSize_TileGroupLayout_Handle, tileSet.Handle, columns, rows, tileSize, nSArray.Handle), "initWithTileSet:columns:rows:tileSize:tileGroupLayout:");
		}
		nSArray.Dispose();
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public new virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("tileMapNodeWithTileSet:columns:rows:tileSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileMapNode Create(SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize)
	{
		if (tileSet == null)
		{
			throw new ArgumentNullException("tileSet");
		}
		return Runtime.GetNSObject<SKTileMapNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_CGSize(class_ptr, selTileMapNodeWithTileSet_Columns_Rows_TileSize_Handle, tileSet.Handle, columns, rows, tileSize));
	}

	[Export("tileMapNodeWithTileSet:columns:rows:tileSize:fillWithTileGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileMapNode Create(SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup tileGroup)
	{
		if (tileSet == null)
		{
			throw new ArgumentNullException("tileSet");
		}
		if (tileGroup == null)
		{
			throw new ArgumentNullException("tileGroup");
		}
		return Runtime.GetNSObject<SKTileMapNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_CGSize_IntPtr(class_ptr, selTileMapNodeWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_Handle, tileSet.Handle, columns, rows, tileSize, tileGroup.Handle));
	}

	[Export("tileMapNodeWithTileSet:columns:rows:tileSize:tileGroupLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileMapNode Create(SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup[] tileGroupLayout)
	{
		if (tileSet == null)
		{
			throw new ArgumentNullException("tileSet");
		}
		if (tileGroupLayout == null)
		{
			throw new ArgumentNullException("tileGroupLayout");
		}
		NSArray nSArray = NSArray.FromNSObjects(tileGroupLayout);
		SKTileMapNode nSObject = Runtime.GetNSObject<SKTileMapNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_CGSize_IntPtr(class_ptr, selTileMapNodeWithTileSet_Columns_Rows_TileSize_TileGroupLayout_Handle, tileSet.Handle, columns, rows, tileSize, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("fillWithTileGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Fill(SKTileGroup? tileGroup)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFillWithTileGroup_Handle, tileGroup?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFillWithTileGroup_Handle, tileGroup?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("tileMapNodesWithTileSet:columns:rows:tileSize:fromNoiseMap:tileTypeNoiseMapThresholds:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileMapNode[] FromTileSet(SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, GKNoiseMap noiseMap, NSNumber[] thresholds)
	{
		if (tileSet == null)
		{
			throw new ArgumentNullException("tileSet");
		}
		if (noiseMap == null)
		{
			throw new ArgumentNullException("noiseMap");
		}
		if (thresholds == null)
		{
			throw new ArgumentNullException("thresholds");
		}
		NSArray nSArray = NSArray.FromNSObjects(thresholds);
		SKTileMapNode[] result = NSArray.ArrayFromHandle<SKTileMapNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_CGSize_IntPtr_IntPtr(class_ptr, selTileMapNodesWithTileSet_Columns_Rows_TileSize_FromNoiseMap_TileTypeNoiseMapThresholds_Handle, tileSet.Handle, columns, rows, tileSize, noiseMap.Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("centerOfTileAtColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint GetCenterOfTile(nuint column, nuint row)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_nuint_nuint(base.Handle, selCenterOfTileAtColumn_Row_Handle, column, row);
		}
		return Messaging.CGPoint_objc_msgSendSuper_nuint_nuint(base.SuperHandle, selCenterOfTileAtColumn_Row_Handle, column, row);
	}

	[Export("tileColumnIndexFromPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetTileColumnIndex(CGPoint position)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_CGPoint(base.Handle, selTileColumnIndexFromPosition_Handle, position);
		}
		return Messaging.nuint_objc_msgSendSuper_CGPoint(base.SuperHandle, selTileColumnIndexFromPosition_Handle, position);
	}

	[Export("tileDefinitionAtColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTileDefinition? GetTileDefinition(nuint column, nuint row)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKTileDefinition>(Messaging.IntPtr_objc_msgSend_nuint_nuint(base.Handle, selTileDefinitionAtColumn_Row_Handle, column, row));
		}
		return Runtime.GetNSObject<SKTileDefinition>(Messaging.IntPtr_objc_msgSendSuper_nuint_nuint(base.SuperHandle, selTileDefinitionAtColumn_Row_Handle, column, row));
	}

	[Export("tileGroupAtColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTileGroup? GetTileGroup(nuint column, nuint row)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKTileGroup>(Messaging.IntPtr_objc_msgSend_nuint_nuint(base.Handle, selTileGroupAtColumn_Row_Handle, column, row));
		}
		return Runtime.GetNSObject<SKTileGroup>(Messaging.IntPtr_objc_msgSendSuper_nuint_nuint(base.SuperHandle, selTileGroupAtColumn_Row_Handle, column, row));
	}

	[Export("tileRowIndexFromPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetTileRowIndex(CGPoint position)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_CGPoint(base.Handle, selTileRowIndexFromPosition_Handle, position);
		}
		return Messaging.nuint_objc_msgSendSuper_CGPoint(base.SuperHandle, selTileRowIndexFromPosition_Handle, position);
	}

	[Export("valueForAttributeNamed:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual SKAttributeValue? GetValue(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		SKAttributeValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKAttributeValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForAttributeNamed_Handle, arg)) : Runtime.GetNSObject<SKAttributeValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForAttributeNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setTileGroup:forColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTileGroup(SKTileGroup? tileGroup, nuint column, nuint row)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_nuint(base.Handle, selSetTileGroup_ForColumn_Row_Handle, tileGroup?.Handle ?? IntPtr.Zero, column, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_nuint(base.SuperHandle, selSetTileGroup_ForColumn_Row_Handle, tileGroup?.Handle ?? IntPtr.Zero, column, row);
		}
	}

	[Export("setTileGroup:andTileDefinition:forColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTileGroup(SKTileGroup tileGroup, SKTileDefinition tileDefinition, nuint column, nuint row)
	{
		if (tileGroup == null)
		{
			throw new ArgumentNullException("tileGroup");
		}
		if (tileDefinition == null)
		{
			throw new ArgumentNullException("tileDefinition");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_nuint(base.Handle, selSetTileGroup_AndTileDefinition_ForColumn_Row_Handle, tileGroup.Handle, tileDefinition.Handle, column, row);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_nuint(base.SuperHandle, selSetTileGroup_AndTileDefinition_ForColumn_Row_Handle, tileGroup.Handle, tileDefinition.Handle, column, row);
		}
	}

	[Export("setValue:forAttributeNamed:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void SetValue(SKAttributeValue value, string key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValue_ForAttributeNamed_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValue_ForAttributeNamed_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TileSet_var = null;
		}
	}
}

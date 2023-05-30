using Foundation;
using ObjCRuntime;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Xamarin.Utiles;

namespace Registrar;

internal abstract class Registrar
{
    internal class ObjCType
    {
        public Registrar Registrar;

        public RegisterAttribute RegisterAttribute;

        public CategoryAttribute CategoryAttribute;

        public Type Type;

        public ObjCType BaseType;

        public ObjCType[] Protocols;

        public string[] AdoptedProtocols;

        public bool IsModel;

        public bool IsProtocol;

        public bool IsInformalProtocol;

        public bool IsWrapper;

        public bool IsGeneric;

        public IntPtr Handle;

        public Dictionary<string, ObjCField> Fields;

        public List<ObjCMethod> Methods;

        public List<ObjCProperty> Properties;

        private Dictionary<string, ObjCMember> Map = new Dictionary<string, ObjCMember>();

        private ObjCType superType;

        private static readonly char[] invalidSelectorCharacters = new char[27]
        {
            ' ', '\t', '?', '\\', '!', '|', '@', '"', '\'', '%',
            '&', '/', '(', ')', '=', '^', '[', ']', '{', '}',
            ',', '.', ';', '-', '\n', '<', '>'
        };

        public bool IsCategory => CategoryAttribute != null;

        public string Name
        {
            get
            {
                if (RegisterAttribute == null || RegisterAttribute.Name == null)
                {
                    return Registrar.GetTypeFullName(Type);
                }
                return RegisterAttribute.Name;
            }
        }

        public string CategoryName
        {
            get
            {
                if (!IsCategory)
                {
                    throw new InvalidOperationException();
                }
                return SanitizeObjectiveCName(CategoryAttribute.Name ?? Registrar.GetTypeFullName(Type));
            }
        }

        public string ProtocolName
        {
            get
            {
                if (!IsProtocol)
                {
                    throw new InvalidOperationException();
                }
                return SanitizeObjectiveCName(Registrar.GetProtocolAttribute(Type).Name ?? Registrar.GetTypeFullName(Type));
            }
        }

        public string ExportedName => Registrar.GetExportedTypeName(Type, RegisterAttribute);

        public bool IsFakeProtocol
        {
            get
            {
                if (RegisterAttribute == null || IsProtocol || IsModel)
                {
                    return false;
                }
                return Registrar.HasProtocolAttribute(Type);
            }
        }

        public ObjCType SuperType
        {
            get
            {
                if (superType != null)
                {
                    return superType;
                }
                ObjCType baseType = BaseType;
                while (baseType != null && (baseType.IsModel || baseType.IsFakeProtocol))
                {
                    baseType = baseType.BaseType;
                }
                superType = baseType;
                return superType;
            }
        }

        public void VerifyRegisterAttribute(ref List<Exception> exceptions)
        {
            if (RegisterAttribute == null)
            {
                return;
            }
            string name = RegisterAttribute.Name;
            if (string.IsNullOrEmpty(name))
            {
                return;
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsWhiteSpace(name[i]))
                {
                    continue;
                }
                bool error = false;
                string text = name.Trim();
                for (int j = 0; j < text.Length; j++)
                {
                    if (char.IsWhiteSpace(text[j]))
                    {
                        error = true;
                        break;
                    }
                }
                AddException(ref exceptions, new RuntimeException(4146, error, "The Name parameter of the Registrar attribute on the class '{0}' ('{3}') contains an invalid character: '{1}' (0x{2}).", Registrar.GetTypeFullName(Type), name[i], ((int)name[i]).ToString("x"), name));
                break;
            }
        }

        private void VerifySelector(ObjCMethod method, ref List<Exception> exceptions)
        {
            if (!(method.Method == null))
            {
                int num = method.Selector.Split(':').Length - 1;
                if (method.IsVariadic)
                {
                    num++;
                }
                Type[] parameters = method.Parameters;
                int num2 = ((parameters != null) ? parameters.Length : 0);
                if (method.IsCategoryInstance)
                {
                    num2--;
                }
                if (num != num2)
                {
                    Exception mex = ((!method.IsVariadic) ? Registrar.CreateException(4117, method, "The registrar found a signature mismatch in the method '{0}.{1}' - the selector '{4}' indicates the method takes {2} parameters, while the managed method has {3} parameters.", method.Method.DeclaringType.FullName, method.MethodName, num, num2, method.Selector) : Registrar.CreateException(4140, method, "The registrar found a signature mismatch in the method '{0}.{1}' - the selector '{4}' indicates the variadic method takes {2} parameters, while the managed method has {3} parameters.", method.Method.DeclaringType.FullName, method.MethodName, num, num2, method.Selector));
                    AddException(ref exceptions, mex);
                }
                if (method.IsVariadic && parameters != null && Registrar.GetTypeFullName(parameters[num2 - 1]) != "System.IntPtr")
                {
                    AddException(ref exceptions, Registrar.CreateException(4123, method, "The type of the variadic parameter in the variadic function '{0}' must be System.IntPtr.", Registrar.GetDescriptiveMethodName(method.Method)));
                }
                int num3 = method.Selector.IndexOfAny(invalidSelectorCharacters);
                if (num3 != -1)
                {
                    char c = method.Selector[num3];
                    Registrar registrar = Registrar;
                    object[] obj = new object[5] { c, null, null, null, null };
                    int num4 = c;
                    obj[1] = num4.ToString("x");
                    obj[2] = method.Selector;
                    obj[3] = Registrar.GetTypeFullName(Type);
                    obj[4] = Registrar.GetDescriptiveMethodName(method.Method);
                    AddException(ref exceptions, registrar.CreateException(4160, method, "Invalid character '{0}' (0x{1}) found in selector '{2}' for '{3}.{4}'", obj));
                }
            }
        }

        public void VerifyAdoptedProtocolsNames(ref List<Exception> exceptions)
        {
            if (AdoptedProtocols == null)
            {
                return;
            }
            string[] adoptedProtocols = AdoptedProtocols;
            foreach (string text in adoptedProtocols)
            {
                int num = text.IndexOfAny(invalidSelectorCharacters);
                string text2 = text;
                if (num != -1)
                {
                    char c = text[num];
                    string arg = c.ToString();
                    switch (c)
                    {
                        case '{':
                            arg = "{{";
                            text2 = text2.Insert(num, "{");
                            break;
                        case '}':
                            arg = "}}";
                            text2 = text2.Insert(num, "}");
                            break;
                    }
                    string message = $"The 'ProtocolType' parameter of the 'Adopts' attribute used in class '{Registrar.GetTypeFullName(Type)}' contains an invalid character. Value used: '{text2}' Invalid Char: '{arg}'";
                    object[] args = new string[0];
                    AddException(ref exceptions, new RuntimeException(4177, error: true, message, args));
                }
            }
        }

        public void Add(ObjCField field, ref List<Exception> exceptions)
        {
            ObjCType baseType = BaseType;
            string key = (field.IsStatic ? "+" : "-") + field.Name;
            while (baseType != null)
            {
                if (baseType.Fields != null && baseType.Fields.ContainsKey(key))
                {
                    return;
                }
                if (baseType == baseType.BaseType)
                {
                    break;
                }
                baseType = baseType.BaseType;
            }
            if (Fields == null)
            {
                Fields = new Dictionary<string, ObjCField>();
            }
            Fields.Add(key, field);
        }

        public bool Add(ObjCMethod method, ref List<Exception> exceptions)
        {
            if (Methods == null)
            {
                Methods = new List<ObjCMethod>();
            }
            VerifySelector(method, ref exceptions);
            method.ValidateSignature(ref exceptions);
            if (!method.IsPropertyAccessor && !method.DeclaringType.IsProtocol)
            {
                Registrar.VerifyInSdk(ref exceptions, method);
            }
            bool result = AddToMap(method, ref exceptions);
            Methods.Add(method);
            return result;
        }

        public void Add(ObjCProperty property, ref List<Exception> exceptions)
        {
            if (Properties == null)
            {
                Properties = new List<ObjCProperty>();
            }
            Properties.Add(property);
            if (!property.DeclaringType.IsProtocol)
            {
                Registrar.VerifyInSdk(ref exceptions, property);
            }
            VerifyIsNotKeyword(ref exceptions, property);
        }

        public static bool IsObjectiveCKeyword(string name)
        {
            switch (name)
            {
                case "auto":
                case "break":
                case "case":
                case "char":
                case "const":
                case "continue":
                case "default":
                case "do":
                case "double":
                case "else":
                case "enum":
                case "export":
                case "extern":
                case "float":
                case "for":
                case "goto":
                case "if":
                case "inline":
                case "int":
                case "long":
                case "register":
                case "restrict":
                case "return":
                case "short":
                case "signed":
                case "sizeof":
                case "static":
                case "struct":
                case "switch":
                case "template":
                case "typedef":
                case "union":
                case "unsigned":
                case "void":
                case "volatile":
                case "while":
                case "_Bool":
                case "_Complex":
                case "_Imaginery":
                    return true;
                default:
                    return false;
            }
        }

        private void VerifyIsNotKeyword(ref List<Exception> exceptions, ObjCProperty property)
        {
            if (IsObjectiveCKeyword(property.Selector))
            {
                AddException(ref exceptions, CreateException(4164, property, "Cannot export the property '{0}' because its selector '{1}' is an Objective-C keyword. Please use a different name.", property.Name, property.Selector));
            }
        }

        public bool TryGetMember(string selector, bool is_static, out ObjCMember member)
        {
            selector = ((!is_static) ? ("-" + selector) : ("+" + selector));
            return Map.TryGetValue(selector, out member);
        }

        private bool AddToMap(ObjCMember member, ref List<Exception> exceptions)
        {
            bool result = true;
            if (TryGetMember(member.Selector, member.IsNativeStatic, out var member2))
            {
                if (member2.IsImplicit)
                {
                    AddException(ref exceptions, CreateException(4141, member, "Cannot register the selector '{0}' on the member '{1}.{2}' because Xamarin.iOS implicitly registers this selector.", member.Selector, Registrar.GetTypeFullName(Type), Registrar.GetMemberName(member)));
                }
                else
                {
                    AddException(ref exceptions, CreateException(4119, member, "Could not register the selector '{0}' of the member '{1}.{2}' because the selector is already registered on the member '{3}'.", member.Selector, Registrar.GetTypeFullName(Type), Registrar.GetMemberName(member), Registrar.GetMemberName(member2)));
                }
                result = false;
            }
            Map[(member.IsNativeStatic ? "+" : "-") + member.Selector] = member;
            return result;
        }

        private Exception CreateException(int code, ObjCMember member, string message, params object[] args)
        {
            if (member is ObjCMethod objCMethod)
            {
                return Registrar.CreateException(code, objCMethod.Method, message, args);
            }
            if (member is ObjCProperty objCProperty && objCProperty.Property != null)
            {
                return Registrar.CreateException(code, objCProperty.Property.GetMethod ?? objCProperty.Property.SetMethod, message, args);
            }
            return Registrar.CreateException(code, message, args);
        }
    }

    internal abstract class ObjCMember
    {
        public Registrar Registrar;

        public ObjCType DeclaringType;

        public string Name;

        public ObjCType CategoryType;

        public ArgumentSemantic ArgumentSemantic = ArgumentSemantic.None;

        public bool IsVariadic;

        public bool IsOptional;

        private string selector;

        public string Selector
        {
            get
            {
                return selector;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw Registrar.CreateException(4135, this, "The member '{0}' has an Export attribute without a selector. A selector is required.", FullName);
                }
                selector = value;
            }
        }

        public abstract string FullName { get; }

        public abstract bool IsNativeStatic { get; }

        public virtual bool IsImplicit => false;

        public bool SetExportAttribute(ExportAttribute ea, ref List<Exception> exceptions)
        {
            if (string.IsNullOrEmpty(ea.Selector))
            {
                AddException(ref exceptions, Registrar.CreateException(4135, this, "The member '{0}' has an Export attribute without a selector. A selector is required.", FullName));
                return false;
            }
            Selector = ea.Selector;
            ArgumentSemantic = ea.ArgumentSemantic;
            IsVariadic = ea.IsVariadic;
            return true;
        }

        public ObjCMember()
        {
        }

        public ObjCMember(Registrar registrar, ObjCType declaringType)
        {
            Registrar = registrar;
            DeclaringType = declaringType;
        }

        protected string ToSignature(Type type, ref bool success)
        {
            return Registrar.ToSignature(type, this, ref success);
        }
    }

    internal class ObjCMethod : ObjCMember
    {
        public readonly MethodBase Method;

        private string signature;

        private Trampoline trampoline;

        private bool? is_static;

        private bool? is_ctor;

        private Type[] parameters;

        private Type[] native_parameters;

        private Type return_type;

        private Type native_return_type;

        private const int RetainReturnValueFlag = 1024;

        private const int InstanceCategoryFlag = 2048;

        public string MethodName => Name ?? Registrar.GetMethodName(Method);

        public override bool IsImplicit
        {
            get
            {
                if (Method != null)
                {
                    return false;
                }
                Trampoline trampoline = this.trampoline;
                if ((uint)(trampoline - 5) <= 1u || (uint)(trampoline - 18) <= 3u)
                {
                    return true;
                }
                return false;
            }
        }

        public bool IsConstructor
        {
            get
            {
                if (!is_ctor.HasValue)
                {
                    is_ctor = Registrar.IsConstructor(Method);
                }
                return is_ctor.Value;
            }
            set
            {
                is_ctor = value;
            }
        }

        internal bool IsInstanceCategory => DynamicRegistrar.HasThisAttributeImpl(Method);

        public bool HasParameters => parameters != null;

        public Type[] Parameters
        {
            get
            {
                if (parameters == null)
                {
                    parameters = Registrar.GetParameters(Method);
                }
                return parameters;
            }
            set
            {
                parameters = value;
                native_parameters = null;
            }
        }

        public Type[] NativeParameters
        {
            get
            {
                if (native_parameters == null && Parameters != null)
                {
                    Type[] array = new Type[parameters.Length];
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Type type = Registrar.GetBindAsAttribute(this, i)?.OriginalType;
                        if (type != null)
                        {
                            if (!IsValidToManagedTypeConversion(type, parameters[i]))
                            {
                                throw Registrar.CreateException(4172, Method, "The registrar can't convert from '{0}' to '{1}' for the parameter '{2}' in the method {3}.", Registrar.GetTypeFullName(parameters[i]), type.FullName, Registrar.GetParameterName(Method, i), DescriptiveMethodName);
                            }
                            array[i] = type;
                        }
                        else
                        {
                            array[i] = parameters[i];
                        }
                    }
                    native_parameters = array;
                }
                return native_parameters;
            }
        }

        public bool HasReturnType => return_type != null;

        public Type ReturnType
        {
            get
            {
                if (return_type == null)
                {
                    return_type = Registrar.GetReturnType(Method);
                }
                return return_type;
            }
            set
            {
                return_type = value;
                native_return_type = null;
            }
        }

        public Type NativeReturnType
        {
            get
            {
                if (native_return_type == null)
                {
                    if (Registrar.Is(ReturnType, "System", "Void"))
                    {
                        native_return_type = ReturnType;
                    }
                    else
                    {
                        Type type = Registrar.GetBindAsAttribute(this, -1)?.OriginalType;
                        if (type != null)
                        {
                            if (!IsValidToManagedTypeConversion(type, ReturnType))
                            {
                                throw Registrar.CreateException(4170, Method, "The registrar can't convert from '{0}' to '{1}' for the return value in the method {2}.", Registrar.GetTypeFullName(ReturnType), type.FullName, DescriptiveMethodName);
                            }
                            native_return_type = type;
                        }
                        else
                        {
                            native_return_type = ReturnType;
                        }
                    }
                }
                return native_return_type;
            }
        }

        public bool IsStatic
        {
            get
            {
                if (!is_static.HasValue)
                {
                    return Registrar.IsStatic(Method);
                }
                return is_static.Value;
            }
            set
            {
                is_static = value;
            }
        }

        public override bool IsNativeStatic
        {
            get
            {
                if (IsStatic)
                {
                    return !IsCategoryInstance;
                }
                return false;
            }
        }

        public bool IsCategoryInstance
        {
            get
            {
                if (IsCategory)
                {
                    return Registrar.HasThisAttribute(Method);
                }
                return false;
            }
        }

        public bool IsCategory => CategoryType != null;

        public bool RetainReturnValue => Registrar.HasReleaseAttribute(Method);

        public Trampoline CurrentTrampoline => trampoline;

        public Trampoline Trampoline
        {
            get
            {
                if (trampoline != 0)
                {
                    return trampoline;
                }
                _ = (MethodInfo)Method;
                bool flag = !RuntimeEx.IsARM64CallingConvention && ((IntPtr.Size == 8) ? Stret.X86_64NeedStret(NativeReturnType, null) : Stret.X86NeedStret(NativeReturnType, null));
                bool flag2 = IsStatic && !IsCategoryInstance;
                if (Registrar.IsValueType(NativeReturnType) && !Registrar.IsEnum(NativeReturnType) && Registrar.IsGenericType(NativeReturnType))
                {
                    throw Registrar.CreateException(4104, Method, "The registrar cannot marshal the return value of type `{0}` in the method `{1}.{2}`.", Registrar.GetTypeFullName(NativeReturnType), Registrar.GetTypeFullName(DeclaringType.Type), Registrar.GetDescriptiveMethodName(Method));
                }
                if (flag)
                {
                    if (Registrar.IsSimulatorOrDesktop && !Registrar.Is64Bits)
                    {
                        trampoline = (flag2 ? Trampoline.X86_DoubleABI_StaticStretTrampoline : Trampoline.X86_DoubleABI_StretTrampoline);
                    }
                    else
                    {
                        trampoline = (flag2 ? Trampoline.StaticStret : Trampoline.Stret);
                    }
                }
                else
                {
                    switch (Signature[0])
                    {
                        case 'Q':
                        case 'q':
                            trampoline = (flag2 ? Trampoline.StaticLong : Trampoline.Long);
                            break;
                        case 'f':
                            trampoline = (flag2 ? Trampoline.StaticSingle : Trampoline.Single);
                            break;
                        case 'd':
                            trampoline = (flag2 ? Trampoline.StaticDouble : Trampoline.Double);
                            break;
                        default:
                            trampoline = ((!flag2) ? Trampoline.Normal : Trampoline.Static);
                            break;
                    }
                }
                return trampoline;
            }
            set
            {
                trampoline = value;
            }
        }

        public string Signature
        {
            get
            {
                if (signature == null)
                {
                    signature = ComputeSignature();
                }
                return signature;
            }
            set
            {
                signature = value;
            }
        }

        public string DescriptiveMethodName => Registrar.GetTypeFullName(DeclaringType.Type) + "." + ((Method == null) ? Name : Registrar.GetMethodName(Method));

        public override string FullName => DescriptiveMethodName;

        public bool IsPropertyAccessor
        {
            get
            {
                if (Method == null)
                {
                    return false;
                }
                if (Method.IsSpecialName)
                {
                    if (!Method.Name.StartsWith("get_", StringComparison.Ordinal))
                    {
                        return Method.Name.StartsWith("set_", StringComparison.Ordinal);
                    }
                    return true;
                }
                return false;
            }
        }

        public ObjCMethod(Registrar registrar, ObjCType declaringType, MethodBase method)
            : base(registrar, declaringType)
        {
            Method = method;
        }

        internal void WriteUnmanagedDescription(IntPtr desc)
        {
            WriteUnmanagedDescription(desc, Method);
        }

        internal void WriteUnmanagedDescription(IntPtr desc, MethodBase method_base)
        {
            ArgumentSemantic argumentSemantic = ArgumentSemantic;
            MethodInfo methodInfo = method_base as MethodInfo;
            bool num = methodInfo != null && methodInfo.GetBaseDefinition().ReturnTypeCustomAttributes.IsDefined(typeof(ReleaseAttribute), inherit: false);
            bool flag = methodInfo != null && DynamicRegistrar.HasThisAttributeImpl(methodInfo);
            if (argumentSemantic == ArgumentSemantic.None)
            {
                argumentSemantic = ArgumentSemantic.Assign;
            }
            if (num)
            {
                argumentSemantic |= (ArgumentSemantic)1024;
            }
            if (flag)
            {
                argumentSemantic |= (ArgumentSemantic)2048;
            }
            int num2 = Marshal.ReadInt32((nint)desc + IntPtr.Size + 4);
            if (num2 < 1 + Parameters.Length)
            {
                throw ErrorHelper.CreateError(8018, $"Internal consistency error: BindAs array is not big enough (expected at least {1 + parameters.Length} elements, got {num2} elements) for {method_base.DeclaringType.FullName + "." + method_base.Name}. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new.");
            }
            Marshal.WriteIntPtr(desc, RuntimeEx.AllocGCHandle(method_base));
            Marshal.WriteInt32((nint)desc + IntPtr.Size, (int)argumentSemantic);
            if (!IsConstructor && ReturnType != NativeReturnType)
            {
                Marshal.WriteIntPtr((nint)desc + IntPtr.Size + 8, RuntimeEx.AllocGCHandle(NativeReturnType));
            }
            for (int i = 0; i < NativeParameters.Length; i++)
            {
                if (!(parameters[i] == native_parameters[i]))
                {
                    Marshal.WriteIntPtr((nint)desc + IntPtr.Size + 8 + IntPtr.Size * (i + 1), RuntimeEx.AllocGCHandle(native_parameters[i]));
                }
            }
        }

        private bool IsValidToManagedTypeConversion(Type inputType, Type outputType)
        {
            Type nullableType = Registrar.GetNullableType(outputType);
            bool num = nullableType != null;
            int rank = 0;
            bool flag = Registrar.IsArray(outputType, out rank);
            Type type = outputType;
            Type type2 = inputType;
            if (num)
            {
                type = nullableType;
            }
            else if (flag)
            {
                if (rank != 1)
                {
                    return false;
                }
                if (!Registrar.IsArray(inputType))
                {
                    return false;
                }
                type = Registrar.GetElementType(outputType);
                type2 = Registrar.GetElementType(inputType);
            }
            string typeFullName = Registrar.GetTypeFullName(type);
            if (Registrar.Is(type2, Foundation, "NSNumber"))
            {
                switch (typeFullName)
                {
                    case "System.Byte":
                    case "System.SByte":
                    case "System.Int16":
                    case "System.UInt16":
                    case "System.Int32":
                    case "System.UInt32":
                    case "System.Int64":
                    case "System.UInt64":
                    case "System.IntPtr":
                    case "System.UIntPtr":
                    case "System.nint":
                    case "System.nuint":
                    case "System.Single":
                    case "System.Double":
                    case "System.Boolean":
                        return true;
                    default:
                        if (typeFullName == "System.Runtime.InteropServices.NFloat")
                        {
                            return true;
                        }
                        return Registrar.IsEnum(type);
                }
            }
            if (Registrar.Is(type2, Foundation, "NSValue"))
            {
                switch (typeFullName)
                {
                    case "CoreAnimation.CATransform3D":
                    case "CoreGraphics.CGAffineTransform":
                    case "CoreGraphics.CGPoint":
                    case "CoreGraphics.CGRect":
                    case "CoreGraphics.CGSize":
                    case "CoreGraphics.CGVector":
                    case "CoreLocation.CLLocationCoordinate2D":
                    case "CoreMedia.CMTime":
                    case "CoreMedia.CMTimeMapping":
                    case "CoreMedia.CMTimeRange":
                    case "MapKit.MKCoordinateSpan":
                    case "Foundation.NSRange":
                    case "SceneKit.SCNMatrix4":
                    case "SceneKit.SCNVector3":
                    case "SceneKit.SCNVector4":
                    case "UIKit.UIEdgeInsets":
                    case "UIKit.UIOffset":
                    case "UIKit.NSDirectionalEdgeInsets":
                        return true;
                    default:
                        return false;
                }
            }
            if (Registrar.Is(type2, Foundation, "NSString"))
            {
                return Registrar.IsSmartEnum(type);
            }
            return false;
        }

        private bool IsValidToNativeTypeConversion(Type inputType, Type outputType)
        {
            return IsValidToManagedTypeConversion(outputType, inputType);
        }

        public bool ValidateSignature(ref List<Exception> exceptions)
        {
            if (Registrar.LaxMode)
            {
                return true;
            }
            if (signature == null)
            {
                try
                {
                    signature = ComputeSignature();
                }
                catch (RuntimeException mex)
                {
                    AddException(ref exceptions, mex);
                    return false;
                }
            }
            return true;
        }

        private string ComputeSignature()
        {
            return Registrar.ComputeSignature(DeclaringType.Type, null, this, IsCategoryInstance);
        }

        public override string ToString()
        {
            return string.Format("[ObjCMethod: Name={0}, IsStatic={1}, Trampoline={2}, Signature={3}]", (Method != null) ? Registrar.GetMethodName(Method) : "null", IsStatic, Trampoline, "");
        }
    }

    internal class ObjCProperty : ObjCMember
    {
        private bool? is_static;

        public PropertyInfo Property;

        private Type property_type;

        private bool? is_read_only;

        public string GetterSelector;

        public string SetterSelector;

        public Type PropertyType
        {
            get
            {
                if (property_type == null)
                {
                    property_type = Property.PropertyType;
                }
                return property_type;
            }
            set
            {
                property_type = value;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                if (!is_read_only.HasValue)
                {
                    is_read_only = Registrar.GetSetMethod(Property) == null;
                }
                return is_read_only.Value;
            }
            set
            {
                is_read_only = value;
            }
        }

        public bool IsStatic
        {
            get
            {
                if (!is_static.HasValue)
                {
                    return Registrar.IsStatic(Property);
                }
                return is_static.Value;
            }
            set
            {
                is_static = value;
            }
        }

        public override bool IsNativeStatic => IsStatic;

        public override string FullName => Registrar.GetTypeFullName(DeclaringType.Type) + "." + ((Property != null) ? Registrar.GetPropertyName(Property) : Name);
    }

    internal class ObjCField : ObjCMember
    {
        public int Size;

        public byte Alignment;

        public string FieldType;

        public bool IsProperty;

        private bool is_static;

        public override string FullName => Registrar.GetTypeFullName(DeclaringType.Type) + "." + Name;

        public bool IsStatic
        {
            get
            {
                return is_static;
            }
            set
            {
                is_static = value;
            }
        }

        public override bool IsNativeStatic => IsStatic;
    }

    internal static class StringConstants
    {
        internal const string ExportAttribute = "ExportAttribute";

        internal const string ModelAttribute = "ModelAttribute";

        internal const string RegisterAttribute = "RegisterAttribute";

        internal const string ConnectAttribute = "ConnectAttribute";

        internal const string ProtocolAttribute = "ProtocolAttribute";

        internal const string ProtocolMemberAttribute = "ProtocolMemberAttribute";

        internal const string TransientAttribute = "TransientAttribute";

        internal const string ReleaseAttribute = "ReleaseAttribute";

        internal const string NativeAttribute = "NativeAttribute";

        internal const string CategoryAttribute = "CategoryAttribute";

        internal const string INativeObject = "INativeObject";
    }

    private const string NFloatTypeName = "System.Runtime.InteropServices.NFloat";

    private Dictionary<Assembly, object> assemblies = new Dictionary<Assembly, object>();

    private Dictionary<Type, ObjCType> types = new Dictionary<Type, ObjCType>();

    private Dictionary<string, Type> type_map = new Dictionary<string, Type>();

    private Dictionary<string, Type> protocol_map = new Dictionary<string, Type>();

    private Dictionary<string, Type> categories_map = new Dictionary<string, Type>();

    private MethodBase conforms_to_protocol;

    private MethodBase invoke_conforms_to_protocol;

    internal const string AssemblyName = "Xamarin.Mac";

    private static StringBuilder trace;

    protected abstract bool IsSimulatorOrDesktop { get; }

    protected abstract bool Is64Bits { get; }

    protected abstract bool IsARM64 { get; }

    protected abstract string PlatformName { get; }

    protected virtual bool LaxMode => false;

    internal static string Foundation => "Foundation";

    internal static string ObjCRuntime => "ObjCRuntime";

    internal static string CoreAnimation => "CoreAnimation";

    public string PlatformAssembly => "Xamarin.Mac";

    internal static string CreateSetterSelector(string getterSelector)
    {
        if (string.IsNullOrEmpty(getterSelector))
        {
            return getterSelector;
        }
        int num = getterSelector[0];
        if (num >= 97 && num <= 122)
        {
            num = (ushort)(num - 32);
        }
        return "set" + (char)num + getterSelector.Substring(1) + ":";
    }

    public static string SanitizeObjectiveCName(string name)
    {
        StringBuilder stringBuilder = null;
        for (int i = 0; i < name.Length; i++)
        {
            char c = name[i];
            switch (c)
            {
                case '$':
                case '+':
                case '-':
                case '.':
                case '/':
                case '<':
                case '>':
                case '@':
                case '`':
                    if (stringBuilder == null)
                    {
                        stringBuilder = new StringBuilder(name, 0, i, name.Length);
                    }
                    stringBuilder.Append('_');
                    break;
                default:
                    stringBuilder?.Append(c);
                    break;
            }
        }
        if (stringBuilder != null)
        {
            return stringBuilder.ToString();
        }
        return name;
    }

    public IEnumerable<Assembly> GetAssemblies()
    {
        return assemblies.Keys;
    }

    protected virtual void OnRegisterType(ObjCType type)
    {
    }

    protected virtual void OnSkipType(Type type, ObjCType registered_type)
    {
    }

    protected virtual void OnReloadType(ObjCType type)
    {
    }

    protected virtual void OnRegisterProtocol(ObjCType type)
    {
    }

    protected virtual void OnRegisterCategory(ObjCType type, ref List<Exception> exceptions)
    {
    }

    protected virtual bool SkipRegisterAssembly(Assembly assembly)
    {
        return false;
    }

    protected abstract IEnumerable<Type> CollectTypes(Assembly assembly);

    protected abstract IEnumerable<MethodBase> CollectMethods(Type type);

    protected abstract IEnumerable<PropertyInfo> CollectProperties(Type type);

    protected abstract IEnumerable<MethodBase> CollectConstructors(Type type);

    protected abstract bool ContainsPlatformReference(Assembly assembly);

    protected abstract Type GetBaseType(Type type);

    protected abstract Type[] GetInterfaces(Type type);

    protected virtual Type[] GetLinkedAwayInterfaces(Type type)
    {
        return null;
    }

    protected abstract MethodBase GetBaseMethod(MethodBase method);

    protected abstract Type[] GetParameters(MethodBase method);

    protected abstract string GetParameterName(MethodBase method, int parameter_index);

    protected abstract MethodBase GetGetMethod(PropertyInfo property);

    protected abstract MethodBase GetSetMethod(PropertyInfo property);

    protected abstract Type GetSystemVoidType();

    protected abstract bool IsVirtual(MethodBase method);

    protected abstract bool IsByRef(Type type);

    protected abstract bool IsStatic(PropertyInfo property);

    protected abstract bool IsStatic(FieldInfo field);

    protected abstract bool IsStatic(MethodBase method);

    protected abstract Type MakeByRef(Type type);

    protected abstract bool HasThisAttribute(MethodBase method);

    protected abstract bool IsConstructor(MethodBase method);

    protected abstract Type GetElementType(Type type);

    protected abstract Type GetReturnType(MethodBase method);

    protected abstract void GetNamespaceAndName(Type type, out string @namespace, out string name);

    protected abstract bool TryGetAttribute(Type type, string attributeNamespace, string attributeType, out object attribute);

    protected abstract ExportAttribute GetExportAttribute(PropertyInfo property);

    protected abstract ExportAttribute GetExportAttribute(MethodBase method);

    protected abstract Dictionary<MethodBase, List<MethodBase>> PrepareMethodMapping(Type type);

    public abstract RegisterAttribute GetRegisterAttribute(Type type);

    protected abstract CategoryAttribute GetCategoryAttribute(Type type);

    protected abstract ConnectAttribute GetConnectAttribute(PropertyInfo property);

    public abstract ProtocolAttribute GetProtocolAttribute(Type type);

    protected abstract IEnumerable<ProtocolMemberAttribute> GetProtocolMemberAttributes(Type type);

    protected virtual Version GetSdkIntroducedVersion(Type obj, out string message)
    {
        message = null;
        return null;
    }

    protected abstract Version GetSDKVersion();

    protected abstract Type GetProtocolAttributeWrapperType(Type type);

    protected abstract BindAsAttribute GetBindAsAttribute(MethodBase method, int parameter_index);

    protected abstract BindAsAttribute GetBindAsAttribute(PropertyInfo property);

    protected abstract IList<AdoptsAttribute> GetAdoptsAttributes(Type type);

    public abstract Type GetNullableType(Type type);

    protected abstract bool HasReleaseAttribute(MethodBase method);

    protected abstract bool IsINativeObject(Type type);

    protected abstract bool IsValueType(Type type);

    protected abstract bool IsArray(Type type, out int rank);

    protected abstract bool IsEnum(Type type, out bool isNativeEnum);

    protected abstract bool IsNullable(Type type);

    protected abstract bool IsDelegate(Type type);

    protected abstract bool IsGenericType(Type type);

    protected abstract bool IsGenericMethod(MethodBase method);

    protected abstract bool IsInterface(Type type);

    protected abstract bool IsAbstract(Type type);

    protected abstract Type GetGenericTypeDefinition(Type type);

    protected abstract bool VerifyIsConstrainedToNSObject(Type type, out Type constrained_type);

    protected abstract Type GetEnumUnderlyingType(Type type);

    protected abstract IEnumerable<FieldInfo> GetFields(Type type);

    protected abstract Type GetFieldType(FieldInfo field);

    protected abstract int GetValueTypeSize(Type type);

    protected abstract Exception CreateExceptionImpl(int code, bool error, Exception innerException, MethodBase method, string message, params object[] args);

    protected abstract Exception CreateExceptionImpl(int code, bool error, Exception innerException, Type type, string message, params object[] args);

    public abstract Type FindType(Type relative, string @namespace, string name);

    protected abstract IEnumerable<MethodBase> FindMethods(Type type, string name);

    protected abstract PropertyInfo FindProperty(Type type, string name);

    protected abstract string GetAssemblyName(Assembly assembly);

    protected abstract string GetTypeFullName(Type type);

    protected abstract string GetAssemblyQualifiedName(Type type);

    protected abstract string GetTypeName(Type type);

    protected abstract string GetPropertyName(PropertyInfo property);

    protected abstract Type GetPropertyType(PropertyInfo property);

    protected abstract string GetMethodName(MethodBase method);

    protected abstract string GetFieldName(FieldInfo field);

    public Registrar()
    {
    }

    protected bool IsArray(Type type)
    {
        int rank;
        return IsArray(type, out rank);
    }

    protected bool IsEnum(Type type)
    {
        bool isNativeEnum;
        return IsEnum(type, out isNativeEnum);
    }

    public BindAsAttribute GetBindAsAttribute(ObjCMethod method, int parameter_index)
    {
        BindAsAttribute bindAsAttribute = GetBindAsAttribute(method.Method, parameter_index);
        if (bindAsAttribute != null)
        {
            if (parameter_index != -1)
            {
                _ = GetParameters(method.Method)[parameter_index];
            }
            else
            {
                GetReturnType(method.Method);
            }
            if (parameter_index == -1)
            {
                Type returnType = GetReturnType(method.Method);
                if (!AreEqual(returnType, bindAsAttribute.Type))
                {
                    throw CreateException(4171, method.Method, "The BindAs attribute on the return value of the method {0} is invalid: the BindAs type {1} is different from the return type {2}.", method.DescriptiveMethodName, GetTypeFullName(bindAsAttribute.Type), GetTypeFullName(returnType));
                }
            }
            else
            {
                Type type = GetParameters(method.Method)[parameter_index];
                if (IsByRef(type))
                {
                    type = GetElementType(type);
                }
                if (!AreEqual(type, bindAsAttribute.Type))
                {
                    throw CreateException(4171, method.Method, "The BindAs attribute on the parameter #{0} is invalid: the BindAs type {1} is different from the parameter type {2}.", parameter_index + 1, GetTypeFullName(bindAsAttribute.Type), GetTypeFullName(type));
                }
            }
            return bindAsAttribute;
        }
        if (!method.IsPropertyAccessor)
        {
            return null;
        }
        PropertyInfo property = FindProperty(method.DeclaringType.Type, method.MethodName.Substring(4));
        bindAsAttribute = GetBindAsAttribute(property);
        if (bindAsAttribute != null)
        {
            Type propertyType = GetPropertyType(property);
            if (!AreEqual(propertyType, bindAsAttribute.Type))
            {
                throw CreateException(4171, property, "The BindAs attribute on the property {0}.{1} is invalid: the BindAs type {2} is different from the property type {1}.", GetTypeFullName(method.DeclaringType.Type), GetPropertyName(property), GetTypeFullName(bindAsAttribute.Type), GetTypeFullName(propertyType));
            }
        }
        return bindAsAttribute;
    }

    private bool IsSmartEnum(Type type)
    {
        MethodBase getConstantMethod;
        MethodBase getValueMethod;
        return IsSmartEnum(type, out getConstantMethod, out getValueMethod);
    }

    public bool IsSmartEnum(Type type, out MethodBase getConstantMethod, out MethodBase getValueMethod)
    {
        getConstantMethod = null;
        getValueMethod = null;
        if (!IsEnum(type))
        {
            return false;
        }
        Type type2 = FindType(type, type.Namespace, type.Name + "Extensions");
        if (type2 == null)
        {
            return false;
        }
        foreach (MethodBase item in FindMethods(type2, "GetConstant"))
        {
            if (Is(GetReturnType(item), Foundation, "NSString"))
            {
                Type[] parameters = GetParameters(item);
                if (parameters != null && parameters.Length == 1 && AreEqual(parameters[0], type))
                {
                    getConstantMethod = item;
                    break;
                }
            }
        }
        if (getConstantMethod == null)
        {
            return false;
        }
        foreach (MethodBase item2 in FindMethods(type2, "GetValue"))
        {
            if (AreEqual(GetReturnType(item2), type))
            {
                Type[] parameters2 = GetParameters(item2);
                if (parameters2 != null && parameters2.Length == 1 && Is(parameters2[0], Foundation, "NSString"))
                {
                    getValueMethod = item2;
                    break;
                }
            }
        }
        if (getValueMethod == null)
        {
            return false;
        }
        return true;
    }

    protected string GetMemberName(ObjCMember member)
    {
        if (member is ObjCMethod objCMethod)
        {
            if (objCMethod.Method != null)
            {
                return GetMethodName(objCMethod.Method);
            }
            return objCMethod.MethodName ?? "<implicit>";
        }
        if (member is ObjCProperty objCProperty)
        {
            return GetPropertyName(objCProperty.Property);
        }
        return ((ObjCField)member).Name;
    }

    protected Exception CreateException(int code, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error: true, message, args);
    }

    protected Exception CreateException(int code, MethodBase method, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error: true, method, message, args);
    }

    protected Exception CreateException(int code, PropertyInfo property, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error: true, property, message, args);
    }

    protected Exception CreateException(int code, Type type, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error: true, type, message, args);
    }

    protected Exception CreateException(int code, Exception innerException, PropertyInfo property, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error: true, innerException, property, message, args);
    }

    private Exception CreateExceptionImpl(int code, bool error, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error, (MethodBase)null, message, args);
    }

    private Exception CreateExceptionImpl(int code, bool error, MethodBase method, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error, null, method, message, args);
    }

    private Exception CreateExceptionImpl(int code, bool error, PropertyInfo property, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error, null, property, message, args);
    }

    private Exception CreateExceptionImpl(int code, bool error, Type type, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error, null, type, message, args);
    }

    private Exception CreateExceptionImpl(int code, bool error, Exception innerException, PropertyInfo property, string message, params object[] args)
    {
        if (property == null)
        {
            return CreateExceptionImpl(code, error, innerException, (MethodBase)null, message, args);
        }
        MethodBase getMethod = GetGetMethod(property);
        if (getMethod != null)
        {
            return CreateExceptionImpl(code, error, innerException, getMethod, message, args);
        }
        return CreateExceptionImpl(code, error, innerException, GetSetMethod(property), message, args);
    }

    private Exception CreateException(int code, ObjCMember member, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error: true, member, message, args);
    }

    private Exception CreateExceptionImpl(int code, bool error, ObjCMember member, string message, params object[] args)
    {
        if (member is ObjCMethod objCMethod)
        {
            return CreateExceptionImpl(code, error, objCMethod.Method, message, args);
        }
        if (member is ObjCProperty objCProperty)
        {
            return CreateExceptionImpl(code, error, objCProperty.Property, message, args);
        }
        return CreateExceptionImpl(code, error, message, args);
    }

    private Exception CreateWarning(int code, ObjCMember member, string message, params object[] args)
    {
        return CreateExceptionImpl(code, error: false, member, message, args);
    }

    protected string GetDescriptiveMethodName(MethodBase method)
    {
        if (method == null)
        {
            return string.Empty;
        }
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(GetMethodName(method));
        stringBuilder.Append("(");
        Type[] parameters = GetParameters(method);
        if (parameters != null && parameters.Length != 0)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (i > 0)
                {
                    stringBuilder.Append(",");
                }
                stringBuilder.Append(GetTypeFullName(parameters[i]));
            }
        }
        stringBuilder.Append(")");
        return stringBuilder.ToString();
    }

    private string GetDescriptiveMethodName(Type type, MethodBase method)
    {
        return GetTypeFullName(type) + "." + GetDescriptiveMethodName(method);
    }

    protected virtual bool IsNSObject(Type type)
    {
        GetNamespaceAndName(type, out var @namespace, out var name);
        if (@namespace == Foundation && name == "NSObject")
        {
            return true;
        }
        Type baseType = GetBaseType(type);
        if (baseType != null)
        {
            return IsNSObject(baseType);
        }
        return false;
    }

    protected virtual bool AreEqual(Type a, Type b)
    {
        return a == b;
    }

    protected bool Is(Type type, string @namespace, string name)
    {
        GetNamespaceAndName(type, out var namespace2, out var name2);
        if (namespace2 == @namespace)
        {
            return name2 == name;
        }
        return false;
    }

    protected virtual bool HasModelAttribute(Type type)
    {
        object attribute;
        return TryGetAttribute(type, Foundation, "ModelAttribute", out attribute);
    }

    public virtual bool HasProtocolAttribute(Type type)
    {
        object attribute;
        return TryGetAttribute(type, Foundation, "ProtocolAttribute", out attribute);
    }

    public ObjCType RegisterType(Type type)
    {
        List<Exception> exceptions = null;
        ObjCType value;
        lock (types)
        {
            if (types.TryGetValue(type, out value))
            {
                return value;
            }
            value = RegisterTypeUnsafe(type, ref exceptions);
        }
        if (exceptions != null && exceptions.Count > 0)
        {
            throw new AggregateException(exceptions);
        }
        return value;
    }

    public ObjCType RegisterType(Type type, ref List<Exception> exceptions)
    {
        lock (types)
        {
            return RegisterTypeUnsafe(type, ref exceptions);
        }
    }

    private bool VerifyNonGenericMethod(ref List<Exception> exceptions, Type declaringType, MethodBase method)
    {
        if (!IsGenericMethod(method))
        {
            return true;
        }
        AddException(ref exceptions, CreateException(4113, method, "The registrar found a generic method: '{0}'. Exporting generic methods is not supported, and will lead to random behavior and/or crashes", GetDescriptiveMethodName(declaringType, method)));
        return false;
    }

    private void VerifyInSdk(ref List<Exception> exceptions, ObjCMethod method)
    {
        if (method.HasReturnType || (method.Method != null && !method.IsConstructor && method.NativeReturnType != null))
        {
            VerifyTypeInSDK(ref exceptions, method.NativeReturnType, null, method);
        }
        if (method.HasParameters || (method.Method != null && method.Parameters != null))
        {
            Type[] parameters = method.Parameters;
            foreach (Type type in parameters)
            {
                VerifyTypeInSDK(ref exceptions, type, method);
            }
        }
    }

    private void VerifyInSdk(ref List<Exception> exceptions, ObjCProperty property)
    {
        VerifyTypeInSDK(ref exceptions, property.PropertyType, null, null, property);
    }

    private void VerifyTypeInSDK(ref List<Exception> exceptions, Type type, ObjCMethod parameterIn = null, ObjCMethod returnTypeOf = null, ObjCProperty propertyTypeOf = null, Type baseTypeOf = null)
    {
        string message;
        Version sdkIntroducedVersion = GetSdkIntroducedVersion(type, out message);
        if ((object)sdkIntroducedVersion == null)
        {
            return;
        }
        Version sDKVersion = GetSDKVersion();
        if (!(sdkIntroducedVersion <= sDKVersion))
        {
            string typeFullName = GetTypeFullName(type);
            string text = string.Empty;
            string platformName = PlatformName;
            string text2 = sDKVersion.ToString();
            string text3 = sdkIntroducedVersion.ToString();
            string text4 = (string.IsNullOrEmpty(message) ? "." : (": '" + message + "'."));
            string format;
            if (baseTypeOf != null)
            {
                format = "The type '{0}' (used as a base type of {1}) is not available in {2} {3} (it was introduced in {2} {4}){5} Please build with a newer {2} SDK (usually done by using the most recent version of Xcode).";
                text = GetTypeFullName(baseTypeOf);
            }
            else if (parameterIn != null)
            {
                format = "The type '{0}' (used as a parameter in {1}) is not available in {2} {3} (it was introduced in {2} {4}){5} Please build with a newer {2} SDK (usually done by using the most recent version of Xcode).";
                text = parameterIn.DescriptiveMethodName;
            }
            else if (returnTypeOf != null)
            {
                format = "The type '{0}' (used as a return type in {1}) is not available in {2} {3} (it was introduced in {2} {4}){5} Please build with a newer {2} SDK (usually done by using the most recent version of Xcode).";
                text = returnTypeOf.DescriptiveMethodName;
            }
            else if (propertyTypeOf != null)
            {
                format = "The type '{0}' (used as the property type of {1}) is not available in {2} {3} (it was introduced in {2} {4}){5} Please build with a newer {2} SDK (usually done by using the most recent version of Xcode).";
                text = propertyTypeOf.FullName;
            }
            else
            {
                format = "The type '{0}' is not available in {3} {4} (it was introduced in {3} {5}){6} Please build with a newer {3} SDK (usually done by using the most recent version of Xcode).";
            }
            format = string.Format(format, typeFullName, text, platformName, text2, text3, text4);
            Exception mex = ((baseTypeOf != null) ? CreateException(4162, baseTypeOf, format) : ((parameterIn != null) ? CreateException(4162, parameterIn, format) : ((returnTypeOf != null) ? CreateException(4162, returnTypeOf, format) : ((propertyTypeOf == null) ? CreateException(4162, format) : CreateException(4162, propertyTypeOf, format)))));
            AddException(ref exceptions, mex);
        }
    }

    protected static void AddException(ref List<Exception> exceptions, Exception mex)
    {
        if (exceptions == null)
        {
            exceptions = new List<Exception>();
        }
        exceptions.Add(mex);
    }

    private bool IsSubClassOf(Type type, string @namespace, string name)
    {
        while ((type = GetBaseType(type)) != null)
        {
            GetNamespaceAndName(type, out var namespace2, out var name2);
            if (namespace2 == @namespace && name2 == name)
            {
                return true;
            }
        }
        return false;
    }

    private bool VerifyIsConstrainedToNSObject(ref List<Exception> exceptions, Type type, ObjCMethod method)
    {
        Type constrained_type = null;
        if (!VerifyIsConstrainedToNSObject(method.ReturnType, out constrained_type))
        {
            AddException(ref exceptions, CreateException(4129, method.Method, "The registrar found an invalid generic return type '{0}' in the method '{1}'. The generic return type must have an 'NSObject' constraint.", GetTypeFullName(method.ReturnType), GetDescriptiveMethodName(type, method.Method)));
            return false;
        }
        if (constrained_type != null)
        {
            method.ReturnType = constrained_type;
        }
        Type[] parameters = method.Parameters;
        if (parameters == null)
        {
            return true;
        }
        List<Type> list = null;
        for (int i = 0; i < parameters.Length; i++)
        {
            Type type2 = parameters[i];
            if (!VerifyIsConstrainedToNSObject(type2, out constrained_type))
            {
                AddException(ref exceptions, CreateException(4128, method.Method, "The registrar found an invalid generic parameter type '{0}' in the parameter {2} of the method '{1}'. The generic parameter must have an 'NSObject' constraint.", GetTypeFullName(type2), GetDescriptiveMethodName(type, method.Method), GetParameterName(method.Method, i)));
                return false;
            }
            if (constrained_type != null)
            {
                if (list == null)
                {
                    list = new List<Type>();
                    for (int j = 0; j < i; j++)
                    {
                        list.Add(parameters[j]);
                    }
                }
                list.Add(constrained_type);
            }
            else
            {
                list?.Add(type2);
            }
        }
        if (list != null)
        {
            method.Parameters = list.ToArray();
        }
        return true;
    }

    private void FlattenInterfaces(Type[] ifaces)
    {
        if (ifaces.Length == 1)
        {
            return;
        }
        for (int i = 0; i < ifaces.Length; i++)
        {
            Type type = ifaces[i];
            if (type == null)
            {
                continue;
            }
            Type[] interfaces = GetInterfaces(type);
            if (interfaces == null)
            {
                continue;
            }
            for (int j = 0; j < interfaces.Length; j++)
            {
                for (int k = 0; k < ifaces.Length; k++)
                {
                    if (k != i && !(ifaces[k] == null) && ifaces[k] == interfaces[j])
                    {
                        ifaces[k] = null;
                    }
                }
            }
        }
    }

    private Type[] GetInterfacesImpl(ObjCType objcType)
    {
        Type type = objcType.Type;
        Type[] array = GetInterfaces(type);
        if (array == null || array.Length == 0)
        {
            return array;
        }
        FlattenInterfaces(array);
        ObjCType superType = objcType.SuperType;
        if (superType == null || superType.Type == null)
        {
            return array;
        }
        Type[] interfaces = GetInterfaces(superType.Type);
        if (interfaces == null || interfaces.Length == 0)
        {
            return array;
        }
        FlattenInterfaces(interfaces);
        int newSize = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Array.IndexOf(interfaces, array[i]) < 0)
            {
                array[newSize++] = array[i];
            }
        }
        Array.Resize(ref array, newSize);
        return array;
    }

    private ObjCType[] GetProtocols(ObjCType type, ref List<Exception> exceptions)
    {
        Type[] interfacesImpl = GetInterfacesImpl(type);
        List<ObjCType> list = null;
        if (interfacesImpl != null && interfacesImpl.Length != 0)
        {
            List<Type> list2 = new List<Type>(interfacesImpl);
            list = new List<ObjCType>(interfacesImpl.Length);
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i] == null)
                {
                    continue;
                }
                ObjCType objCType = RegisterTypeUnsafe(list2[i], ref exceptions);
                if (objCType == null)
                {
                    continue;
                }
                if (objCType.IsInformalProtocol)
                {
                    Type[] interfacesImpl2 = GetInterfacesImpl(objCType);
                    if (interfacesImpl2 != null)
                    {
                        list2.AddRange(interfacesImpl2);
                    }
                }
                else
                {
                    list.Add(objCType);
                }
            }
        }
        List<Type> list3 = new List<Type>();
        Type[] linkedAwayInterfaces = GetLinkedAwayInterfaces(type.Type);
        ObjCType baseType = type.BaseType;
        if (linkedAwayInterfaces != null)
        {
            list3.AddRange(linkedAwayInterfaces);
        }
        while (baseType != null && baseType.IsModel)
        {
            linkedAwayInterfaces = GetLinkedAwayInterfaces(baseType.Type);
            if (linkedAwayInterfaces != null)
            {
                list3.AddRange(linkedAwayInterfaces);
            }
            baseType = baseType.BaseType;
        }
        if (list3.Count > 0)
        {
            if (list == null)
            {
                list = new List<ObjCType>();
            }
            for (int j = 0; j < list3.Count; j++)
            {
                Type type2 = list3[j];
                ProtocolAttribute protocolAttribute = GetProtocolAttribute(type2);
                if (protocolAttribute == null)
                {
                    continue;
                }
                if (protocolAttribute.IsInformal)
                {
                    linkedAwayInterfaces = GetLinkedAwayInterfaces(type2);
                    if (linkedAwayInterfaces != null)
                    {
                        list3.AddRange(linkedAwayInterfaces);
                    }
                }
                else
                {
                    ObjCType item = new ObjCType
                    {
                        Registrar = this,
                        Type = type2,
                        IsProtocol = true
                    };
                    list.Add(item);
                }
            }
        }
        if (list == null || list.Count == 0)
        {
            return null;
        }
        return list.ToArray();
    }

    private string[] GetAdoptedProtocols(ObjCType type)
    {
        IList<AdoptsAttribute> adoptsAttributes = GetAdoptsAttributes(type.Type);
        if (adoptsAttributes == null || adoptsAttributes.Count == 0)
        {
            return null;
        }
        string[] array = new string[adoptsAttributes.Count];
        for (int i = 0; i < adoptsAttributes.Count; i++)
        {
            array[i] = adoptsAttributes[i].ProtocolType;
        }
        return array;
    }

    private ObjCType RegisterCategory(Type type, CategoryAttribute attrib, ref List<Exception> exceptions)
    {
        if (IsINativeObject(type))
        {
            AddException(ref exceptions, ErrorHelper.CreateError(4152, "Cannot register the type '{0}' as a category because it implements INativeObject or subclasses NSObject.", GetTypeFullName(type)));
            return null;
        }
        if (IsGenericType(type))
        {
            AddException(ref exceptions, ErrorHelper.CreateError(4153, "Cannot register the type '{0}' as a category because it's generic.", GetTypeFullName(type)));
            return null;
        }
        if (attrib.Type == null)
        {
            AddException(ref exceptions, ErrorHelper.CreateError(4151, "Cannot register the type '{0}' because the Type property in its Category attribute isn't set.", GetTypeFullName(type)));
            return null;
        }
        ObjCType objCType = RegisterType(attrib.Type, ref exceptions);
        if (objCType == null)
        {
            AddException(ref exceptions, ErrorHelper.CreateError(4150, "Cannot register the type '{0}' because the category type '{1}' in its Category attribute does not inherit from NSObject.", GetTypeFullName(type), GetTypeFullName(attrib.Type)));
            return null;
        }
        ObjCType objCType2 = new ObjCType
        {
            Registrar = this,
            Type = type,
            BaseType = objCType,
            CategoryAttribute = attrib
        };
        lock (categories_map)
        {
            if (categories_map.TryGetValue(objCType2.CategoryName, out var value))
            {
                AddException(ref exceptions, ErrorHelper.CreateError(4156, "Cannot register two categories ('{0}' and '{1}') with the same native name ('{2}')", GetAssemblyQualifiedName(type), GetAssemblyQualifiedName(value), objCType2.CategoryName));
                return null;
            }
            categories_map.Add(objCType2.CategoryName, type);
        }
        types.Add(type, objCType2);
        foreach (MethodBase item in CollectConstructors(type))
        {
            if (GetExportAttribute(item) != null)
            {
                AddException(ref exceptions, CreateException(4158, item, "Cannot register the constructor {0}.{1} in the category {0} because constructors in categories are not supported.", GetTypeFullName(type), GetDescriptiveMethodName(item)));
            }
        }
        foreach (MethodBase item2 in CollectMethods(type))
        {
            ExportAttribute exportAttribute = GetExportAttribute(item2);
            if (exportAttribute == null)
            {
                continue;
            }
            if (!IsStatic(item2))
            {
                AddException(ref exceptions, CreateException(4159, item2, "Cannot register the method '{0}.{1}' as a category method because category methods must be static.", GetTypeFullName(type), GetMethodName(item2)));
                return null;
            }
            if (HasThisAttribute(item2))
            {
                Type[] parameters = GetParameters(item2);
                if (parameters == null || parameters.Length == 0)
                {
                    AddException(ref exceptions, CreateException(4157, item2, "Cannot register the category method '{0}.{1}' because at least one parameter is required for extension methods (and its type must match the category type '{2}').", GetTypeFullName(type), GetMethodName(item2), GetTypeFullName(objCType.Type)));
                    continue;
                }
                if (GetTypeFullName(parameters[0]) != GetTypeFullName(objCType.Type))
                {
                    AddException(ref exceptions, CreateException(4149, item2, "Cannot register the extension method '{0}.{1}' because the type of the first parameter ('{2}') does not match the category type ('{3}').", GetTypeFullName(type), GetMethodName(item2), GetTypeFullName(parameters[0]), GetTypeFullName(objCType.Type)));
                    continue;
                }
            }
            if (IsGenericMethod(item2))
            {
                AddException(ref exceptions, CreateException(4154, item2, "Cannot register the method '{0}.{1}' as a category method because it's generic.", GetTypeFullName(type), GetMethodName(item2)));
                continue;
            }
            ObjCMethod objCMethod = new ObjCMethod(this, objCType, item2)
            {
                CategoryType = objCType2
            };
            if (objCMethod.SetExportAttribute(exportAttribute, ref exceptions))
            {
                objCType2.Add(objCMethod, ref exceptions);
                objCType.Add(objCMethod, ref exceptions);
            }
        }
        OnRegisterCategory(objCType2, ref exceptions);
        return objCType2;
    }

    private ObjCType RegisterTypeUnsafe(Type type, ref List<Exception> exceptions)
    {
        bool flag = false;
        bool flag2 = false;
        bool flag3 = false;
        if (IsGenericType(type))
        {
            type = GetGenericTypeDefinition(type);
            flag = true;
        }
        if (types.TryGetValue(type, out var value))
        {
            OnReloadType(value);
            return value;
        }
        CategoryAttribute categoryAttribute = GetCategoryAttribute(type);
        if (categoryAttribute != null)
        {
            return RegisterCategory(type, categoryAttribute, ref exceptions);
        }
        if (!IsNSObject(type))
        {
            if (!IsInterface(type))
            {
                return null;
            }
            if (!HasProtocolAttribute(type))
            {
                return null;
            }
            if (flag)
            {
                exceptions.Add(ErrorHelper.CreateError(4148, "The registrar found a generic protocol: '{0}'. Exporting generic protocols is not supported.", GetTypeFullName(type)));
                return null;
            }
            flag3 = GetProtocolAttribute(type).IsInformal;
            flag2 = true;
        }
        Type baseType = GetBaseType(type);
        ObjCType objCType = null;
        if (baseType != null)
        {
            objCType = RegisterTypeUnsafe(baseType, ref exceptions);
        }
        RegisterAttribute registerAttribute = GetRegisterAttribute(type);
        if (registerAttribute != null && registerAttribute.SkipRegistration)
        {
            OnSkipType(type, objCType);
            return objCType;
        }
        value = new ObjCType
        {
            Registrar = this,
            RegisterAttribute = GetRegisterAttribute(type),
            Type = type,
            IsModel = HasModelAttribute(type),
            IsProtocol = flag2,
            IsInformalProtocol = flag3,
            IsGeneric = flag
        };
        value.VerifyRegisterAttribute(ref exceptions);
        value.AdoptedProtocols = GetAdoptedProtocols(value);
        value.VerifyAdoptedProtocolsNames(ref exceptions);
        value.BaseType = (flag2 ? null : (objCType ?? value));
        value.Protocols = GetProtocols(value, ref exceptions);
        value.IsWrapper = ((flag2 && !flag3) ? (GetProtocolAttributeWrapperType(value.Type) != null) : (value.RegisterAttribute != null && value.RegisterAttribute.IsWrapper));
        if (!value.IsWrapper && value.BaseType != null)
        {
            VerifyTypeInSDK(ref exceptions, value.BaseType.Type, null, null, null, value.Type);
        }
        if (ObjCType.IsObjectiveCKeyword(value.ExportedName))
        {
            AddException(ref exceptions, ErrorHelper.CreateError(4168, "Cannot register the type '{0}' because its Objective-C name '{1}' is an Objective-C keyword. Please use a different name.", GetTypeFullName(type), value.ExportedName));
        }
        if (value.Protocols != null)
        {
            ObjCType[] protocols = value.Protocols;
            foreach (ObjCType type2 in protocols)
            {
                OnRegisterProtocol(type2);
            }
        }
        Type value2;
        if (value.IsProtocol)
        {
            lock (protocol_map)
            {
                if (protocol_map.TryGetValue(value.ExportedName, out value2))
                {
                    throw ErrorHelper.CreateError(4126, "Cannot register two managed protocols ('{0}' and '{1}') with the same native name ('{2}').", GetAssemblyQualifiedName(type), GetAssemblyQualifiedName(value2), value.ExportedName);
                }
                protocol_map.Add(value.ExportedName, type);
            }
        }
        else
        {
            lock (type_map)
            {
                if (type_map.TryGetValue(value.ExportedName, out value2))
                {
                    throw ErrorHelper.CreateError(4118, "Cannot register two managed types ('{0}' and '{1}') with the same native name ('{2}').", GetAssemblyQualifiedName(type), GetAssemblyQualifiedName(value2), value.ExportedName);
                }
                type_map.Add(value.ExportedName, type);
            }
        }
        types.Add(type, value);
        bool flag4 = false;
        List<MethodBase> list = new List<MethodBase>(CollectMethods(type));
        if (!flag2)
        {
            flag4 = !value.IsWrapper && !value.IsModel && (value.BaseType.IsWrapper || value.BaseType.IsModel);
            if (flag4)
            {
                if (!IsSubClassOf(value.Type, CoreAnimation, "CALayer"))
                {
                    value.Add(new ObjCMethod(this, value, null)
                    {
                        Selector = "release",
                        Trampoline = Trampoline.Release,
                        Signature = "v@:",
                        IsStatic = false
                    }, ref exceptions);
                    value.Add(new ObjCMethod(this, value, null)
                    {
                        Selector = "retain",
                        Trampoline = Trampoline.Retain,
                        Signature = "@@:",
                        IsStatic = false
                    }, ref exceptions);
                }
                value.Add(new ObjCMethod(this, value, null)
                {
                    Selector = "xamarinGetGCHandle",
                    Trampoline = Trampoline.GetGCHandle,
                    Signature = "i@:",
                    IsStatic = false
                }, ref exceptions);
                value.Add(new ObjCMethod(this, value, null)
                {
                    Selector = "xamarinSetGCHandle:flags:",
                    Trampoline = Trampoline.SetGCHandle,
                    Signature = "v@:^vi",
                    IsStatic = false
                }, ref exceptions);
                value.Add(new ObjCMethod(this, value, null)
                {
                    Selector = "xamarinGetFlags",
                    Trampoline = Trampoline.GetFlags,
                    Signature = "i@:",
                    IsStatic = false
                }, ref exceptions);
                value.Add(new ObjCMethod(this, value, null)
                {
                    Selector = "xamarinSetFlags:",
                    Trampoline = Trampoline.SetFlags,
                    Signature = "v@:i",
                    IsStatic = false
                }, ref exceptions);
            }
            if (conforms_to_protocol == null && Is(type, Foundation, "NSObject"))
            {
                foreach (MethodBase item in list)
                {
                    string methodName = GetMethodName(item);
                    if (!(methodName == "InvokeConformsToProtocol"))
                    {
                        if (methodName == "ConformsToProtocol")
                        {
                            conforms_to_protocol = item;
                        }
                    }
                    else
                    {
                        invoke_conforms_to_protocol = item;
                    }
                    if (invoke_conforms_to_protocol != null && conforms_to_protocol != null)
                    {
                        break;
                    }
                }
            }
        }
        List<PropertyInfo> list2 = new List<PropertyInfo>(CollectProperties(type));
        bool flag5 = false;
        if (flag2 && !flag3)
        {
            foreach (ProtocolMemberAttribute protocolMemberAttribute in GetProtocolMemberAttributes(type))
            {
                flag5 = true;
                if (protocolMemberAttribute.IsProperty)
                {
                    if (protocolMemberAttribute.IsStatic)
                    {
                        ObjCMethod objCMethod = new ObjCMethod(this, value, null);
                        objCMethod.Name = protocolMemberAttribute.Name;
                        objCMethod.Selector = protocolMemberAttribute.GetterSelector;
                        objCMethod.Parameters = new Type[0];
                        objCMethod.ReturnType = protocolMemberAttribute.PropertyType;
                        objCMethod.IsStatic = protocolMemberAttribute.IsStatic;
                        objCMethod.IsOptional = !protocolMemberAttribute.IsRequired;
                        objCMethod.IsConstructor = false;
                        ObjCMethod method = objCMethod;
                        value.Add(method, ref exceptions);
                        if (!string.IsNullOrEmpty(protocolMemberAttribute.SetterSelector))
                        {
                            objCMethod = new ObjCMethod(this, value, null);
                            objCMethod.Name = protocolMemberAttribute.Name;
                            objCMethod.Selector = protocolMemberAttribute.SetterSelector;
                            objCMethod.Parameters = new Type[1] { protocolMemberAttribute.PropertyType };
                            objCMethod.ReturnType = GetSystemVoidType();
                            objCMethod.IsStatic = protocolMemberAttribute.IsStatic;
                            objCMethod.IsOptional = !protocolMemberAttribute.IsRequired;
                            objCMethod.IsConstructor = false;
                            ObjCMethod method2 = objCMethod;
                            value.Add(method2, ref exceptions);
                        }
                    }
                    else
                    {
                        ObjCProperty property = new ObjCProperty
                        {
                            Registrar = this,
                            DeclaringType = value,
                            Property = null,
                            Name = protocolMemberAttribute.Name,
                            Selector = protocolMemberAttribute.Selector,
                            ArgumentSemantic = protocolMemberAttribute.ArgumentSemantic,
                            IsReadOnly = string.IsNullOrEmpty(protocolMemberAttribute.SetterSelector),
                            IsStatic = protocolMemberAttribute.IsStatic,
                            IsOptional = !protocolMemberAttribute.IsRequired,
                            GetterSelector = protocolMemberAttribute.GetterSelector,
                            SetterSelector = protocolMemberAttribute.SetterSelector,
                            PropertyType = protocolMemberAttribute.PropertyType
                        };
                        value.Add(property, ref exceptions);
                    }
                    continue;
                }
                MethodBase method3 = null;
                ObjCMethod objCMethod2 = new ObjCMethod(this, value, method3)
                {
                    Name = protocolMemberAttribute.Name,
                    Selector = protocolMemberAttribute.Selector,
                    ArgumentSemantic = protocolMemberAttribute.ArgumentSemantic,
                    IsVariadic = protocolMemberAttribute.IsVariadic,
                    ReturnType = (protocolMemberAttribute.ReturnType ?? GetSystemVoidType()),
                    IsStatic = protocolMemberAttribute.IsStatic,
                    IsOptional = !protocolMemberAttribute.IsRequired,
                    IsConstructor = false
                };
                if (protocolMemberAttribute.ParameterType != null)
                {
                    Type[] array = new Type[protocolMemberAttribute.ParameterType.Length];
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (protocolMemberAttribute.ParameterByRef[j])
                        {
                            array[j] = MakeByRef(protocolMemberAttribute.ParameterType[j]);
                        }
                        else
                        {
                            array[j] = protocolMemberAttribute.ParameterType[j];
                        }
                    }
                    objCMethod2.Parameters = array;
                }
                else
                {
                    objCMethod2.Parameters = new Type[0];
                }
                value.Add(objCMethod2, ref exceptions);
            }
        }
        foreach (PropertyInfo item2 in list2)
        {
            if (flag5)
            {
                continue;
            }
            if (!flag2)
            {
                ConnectAttribute connectAttribute = GetConnectAttribute(item2);
                if (connectAttribute != null)
                {
                    if (!IsINativeObject(GetPropertyType(item2)))
                    {
                        AddException(ref exceptions, CreateException(4139, item2, "The registrar cannot marshal the property type '{0}' of the property '{1}.{2}'. Properties with the [Connect] attribute must have a property type of NSObject (or a subclass of NSObject).", GetTypeFullName(GetPropertyType(item2)), GetTypeFullName(type), GetPropertyName(item2)));
                        continue;
                    }
                    value.Add(new ObjCField
                    {
                        DeclaringType = value,
                        Name = (connectAttribute.Name ?? GetPropertyName(item2)),
                        Size = (Is64Bits ? 8 : 4),
                        Alignment = (byte)(Is64Bits ? 3u : 2u),
                        FieldType = "@",
                        IsProperty = true,
                        IsStatic = IsStatic(item2)
                    }, ref exceptions);
                }
            }
            ExportAttribute exportAttribute = GetExportAttribute(item2);
            if (exportAttribute == null || (IsStatic(item2) && (value.IsWrapper || value.IsModel)))
            {
                continue;
            }
            if (IsStatic(item2) && flag)
            {
                AddException(ref exceptions, CreateException(4131, item2, "The registrar cannot export static properties in generic classes ('{0}.{1}').", GetTypeFullName(type), GetPropertyName(item2)));
                continue;
            }
            Type constrained_type = null;
            if (flag && !VerifyIsConstrainedToNSObject(GetPropertyType(item2), out constrained_type))
            {
                AddException(ref exceptions, CreateException(4132, item2, "The registrar found an invalid generic return type '{0}' in the property '{1}.{2}'. The return type must have an 'NSObject' constraint.", GetTypeFullName(GetPropertyType(item2)), GetTypeFullName(type), GetPropertyName(item2)));
                continue;
            }
            if (constrained_type == null)
            {
                constrained_type = GetPropertyType(item2);
            }
            ObjCProperty property2 = new ObjCProperty
            {
                Registrar = this,
                DeclaringType = value,
                Property = item2,
                Name = item2.Name,
                Selector = (exportAttribute.Selector ?? GetPropertyName(item2)),
                ArgumentSemantic = exportAttribute.ArgumentSemantic,
                PropertyType = constrained_type
            };
            MethodBase getMethod = GetGetMethod(item2);
            MethodBase setMethod = GetSetMethod(item2);
            if (getMethod != null && VerifyNonGenericMethod(ref exceptions, type, getMethod))
            {
                ObjCMethod objCMethod3 = new ObjCMethod(this, value, getMethod)
                {
                    Selector = (exportAttribute.Selector ?? GetPropertyName(item2)),
                    ArgumentSemantic = exportAttribute.ArgumentSemantic,
                    ReturnType = constrained_type
                };
                List<Exception> exceptions2 = null;
                if (!objCMethod3.ValidateSignature(ref exceptions2))
                {
                    exceptions.Add(CreateException(4138, exceptions2[0], item2, "The registrar cannot marshal the property type '{0}' of the property '{1}.{2}'.", GetTypeFullName(item2.PropertyType), item2.DeclaringType.FullName, item2.Name));
                    continue;
                }
                if (!value.Add(objCMethod3, ref exceptions))
                {
                    continue;
                }
            }
            if (setMethod != null && VerifyNonGenericMethod(ref exceptions, type, setMethod))
            {
                string getterSelector = exportAttribute.Selector ?? GetPropertyName(item2);
                ObjCMethod objCMethod = new ObjCMethod(this, value, setMethod);
                objCMethod.Selector = CreateSetterSelector(getterSelector);
                objCMethod.ArgumentSemantic = exportAttribute.ArgumentSemantic;
                objCMethod.Parameters = new Type[1] { constrained_type };
                ObjCMethod objCMethod4 = objCMethod;
                List<Exception> exceptions3 = null;
                if (!objCMethod4.ValidateSignature(ref exceptions3))
                {
                    exceptions.Add(CreateException(4138, exceptions3[0], item2, "The registrar cannot marshal the property type '{0}' of the property '{1}.{2}'.", GetTypeFullName(item2.PropertyType), item2.DeclaringType.FullName, item2.Name));
                    continue;
                }
                if (!value.Add(objCMethod4, ref exceptions))
                {
                    continue;
                }
            }
            value.Add(property2, ref exceptions);
        }
        bool flag6 = !flag4;
        Dictionary<MethodBase, List<MethodBase>> dictionary = null;
        if (!flag2)
        {
            dictionary = PrepareMethodMapping(type);
        }
        foreach (MethodBase item3 in list)
        {
            if (flag5)
            {
                continue;
            }
            ExportAttribute exportAttribute2 = GetExportAttribute(item3);
            if (exportAttribute2 == null && dictionary != null && dictionary.TryGetValue(item3, out var value3))
            {
                if (value3.Count != 1)
                {
                    foreach (RuntimeException item4 in Shared.GetMT4127(item3, value3))
                    {
                        AddException(ref exceptions, item4);
                    }
                    continue;
                }
                exportAttribute2 = GetExportAttribute(value3[0]);
            }
            if (exportAttribute2 == null || (IsStatic(item3) && (value.IsWrapper || value.IsModel) && (!value.IsProtocol || value.IsFakeProtocol)) || (value.IsModel && IsVirtual(item3)))
            {
                continue;
            }
            if (!flag6 && item3.DeclaringType == type && GetBaseMethod(item3) == conforms_to_protocol)
            {
                flag6 = true;
            }
            if (!VerifyNonGenericMethod(ref exceptions, type, item3))
            {
                continue;
            }
            ObjCMethod objCMethod5 = new ObjCMethod(this, value, item3);
            if (!objCMethod5.SetExportAttribute(exportAttribute2, ref exceptions))
            {
                continue;
            }
            if (IsStatic(item3) && flag)
            {
                AddException(ref exceptions, CreateException(4130, item3, "The registrar cannot export static methods in generic classes ('{0}').", GetDescriptiveMethodName(type, item3)));
            }
            else if (!flag || VerifyIsConstrainedToNSObject(ref exceptions, type, objCMethod5))
            {
                try
                {
                    value.Add(objCMethod5, ref exceptions);
                }
                catch (Exception mex)
                {
                    AddException(ref exceptions, mex);
                }
            }
        }
        if (!flag2 && !flag6)
        {
            value.Add(new ObjCMethod(this, value, invoke_conforms_to_protocol)
            {
                Selector = "conformsToProtocol:",
                Trampoline = Trampoline.Normal,
                Signature = "B@:^v",
                IsStatic = false
            }, ref exceptions);
        }
        foreach (MethodBase item5 in CollectConstructors(type))
        {
            if (IsStatic(item5))
            {
                continue;
            }
            Type[] parameters = GetParameters(item5);
            if (parameters == null || parameters.Length == 0)
            {
                value.Add(new ObjCMethod(this, value, item5)
                {
                    Selector = "init",
                    Trampoline = Trampoline.Constructor
                }, ref exceptions);
                continue;
            }
            ExportAttribute exportAttribute3 = GetExportAttribute(item5);
            if (exportAttribute3 != null && VerifyNonGenericMethod(ref exceptions, type, item5))
            {
                ObjCMethod objCMethod6 = new ObjCMethod(this, value, item5)
                {
                    Trampoline = Trampoline.Constructor
                };
                if (objCMethod6.SetExportAttribute(exportAttribute3, ref exceptions))
                {
                    value.Add(objCMethod6, ref exceptions);
                }
            }
        }
        if (value.IsProtocol)
        {
            OnRegisterProtocol(value);
        }
        else
        {
            OnRegisterType(value);
        }
        return value;
    }

    public void RegisterAssembly(Assembly assembly)
    {
        if (assembly == null)
        {
            throw new ArgumentNullException("assembly");
        }
        if (assemblies.ContainsKey(assembly) || SkipRegisterAssembly(assembly))
        {
            return;
        }
        if (!ContainsPlatformReference(assembly))
        {
            assemblies.Add(assembly, null);
            return;
        }
        List<Exception> exceptions = new List<Exception>();
        try
        {
            IEnumerable<Type> enumerable = CollectTypes(assembly);
            lock (types)
            {
                foreach (Type item in enumerable)
                {
                    RegisterTypeUnsafe(item, ref exceptions);
                }
            }
            assemblies.Add(assembly, null);
        }
        catch (Exception ex)
        {
            ReportError(4116, "Could not register the assembly '{0}': {1}", GetAssemblyName(assembly), ex);
        }
        if (exceptions.Count <= 0)
        {
            return;
        }
        Exception obj = ((exceptions.Count == 1) ? exceptions[0] : new AggregateException(exceptions));
        LogHelper.NSLog(obj.ToString());
        throw obj;
    }

    public string ComputeSignature(Type DeclaringType, MethodBase Method, ObjCMember member = null, bool isCategoryInstance = false, bool isBlockSignature = false)
    {
        ObjCMethod objCMethod = member as ObjCMethod;
        Type return_type = null;
        bool flag = ((!(Method != null)) ? objCMethod.IsConstructor : IsConstructor(Method));
        if (!flag)
        {
            return_type = ((Method != null) ? GetReturnType(Method) : objCMethod.NativeReturnType);
        }
        Type[] parameters = ((!(Method != null)) ? objCMethod.NativeParameters : GetParameters(Method));
        return ComputeSignature(DeclaringType, flag, return_type, parameters, Method, member, isCategoryInstance, isBlockSignature);
    }

    public string ComputeSignature(Type declaring_type, bool is_ctor, Type return_type, Type[] parameters, MethodBase mi = null, ObjCMember member = null, bool isCategoryInstance = false, bool isBlockSignature = false)
    {
        bool success = true;
        StringBuilder stringBuilder = new StringBuilder();
        if (mi == null)
        {
            mi = (member as ObjCMethod)?.Method;
        }
        if (is_ctor)
        {
            stringBuilder.Append('@');
        }
        else
        {
            stringBuilder.Append(ToSignature(return_type, member, ref success));
            if (!success)
            {
                throw CreateException(4104, mi, "The registrar cannot marshal the return value of type `{0}` in the method `{1}.{2}`.", GetTypeFullName(return_type), GetTypeFullName(declaring_type), GetDescriptiveMethodName(mi));
            }
        }
        stringBuilder.Append(isBlockSignature ? "@?" : "@:");
        if (parameters != null)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (i == 0 && isCategoryInstance)
                {
                    continue;
                }
                Type type = parameters[i];
                if (IsByRef(type))
                {
                    stringBuilder.Append("^");
                    Type elementType = GetElementType(type);
                    if (IsNullable(elementType))
                    {
                        stringBuilder.Append(ToSignature(GetNullableType(elementType), member, ref success));
                    }
                    else
                    {
                        stringBuilder.Append(ToSignature(elementType, member, ref success));
                    }
                }
                else
                {
                    stringBuilder.Append(ToSignature(type, member, ref success));
                }
                if (!success)
                {
                    if (mi != null)
                    {
                        parameters = GetParameters(mi);
                    }
                    throw CreateException(4136, mi, "The registrar cannot marshal the parameter type '{0}' of the parameter '{1}' in the method '{2}.{3}'", GetTypeFullName(parameters[i]), GetParameterName(mi, i), GetTypeFullName(declaring_type), GetDescriptiveMethodName(mi));
                }
            }
        }
        return stringBuilder.ToString();
    }

    protected string ToSignature(Type type, ObjCMember member, bool forProperty = false)
    {
        bool success = true;
        string result = ToSignature(type, member, ref success, forProperty);
        if (success)
        {
            return result;
        }
        if (member is ObjCMethod objCMethod)
        {
            throw ErrorHelper.CreateError(4111, "The registrar cannot build a signature for type `{0}' in method `{1}`.", GetTypeFullName(type), GetTypeFullName(objCMethod.DeclaringType.Type) + "." + objCMethod.MethodName);
        }
        throw ErrorHelper.CreateError(4101, "The registrar cannot build a signature for type `{0}`.", GetTypeFullName(type));
    }

    public string GetExportedTypeName(Type type, RegisterAttribute register_attribute)
    {
        string text = null;
        if (register_attribute != null)
        {
            if (register_attribute.SkipRegistration)
            {
                return GetExportedTypeName(GetBaseType(type));
            }
            text = register_attribute.Name;
        }
        if (text == null)
        {
            text = GetTypeFullName(type);
        }
        return SanitizeObjectiveCName(text);
    }

    protected string GetExportedTypeName(Type type)
    {
        return GetExportedTypeName(type, GetRegisterAttribute(type));
    }

    protected string ToSignature(Type type, ObjCMember member, ref bool success, bool forProperty = false)
    {
        string typeFullName = GetTypeFullName(type);
        switch (typeFullName)
        {
            case "System.UIntPtr":
            case "System.IntPtr":
                return "^v";
            case "System.SByte":
                return "c";
            case "System.Byte":
                return "C";
            case "System.Char":
                return "s";
            case "System.Int16":
                return "s";
            case "System.UInt16":
                return "S";
            case "System.Int32":
                return "i";
            case "System.UInt32":
                return "I";
            case "System.Int64":
                return "q";
            case "System.UInt64":
                return "Q";
            case "System.Single":
                return "f";
            case "System.Double":
                return "d";
            case "System.Boolean":
                if (!Is64Bits)
                {
                    return "c";
                }
                return "B";
            case "System.Void":
                return "v";
            case "System.String":
                if (!forProperty)
                {
                    return "@";
                }
                return "@\"NSString\"";
            case "System.nint":
                if (!Is64Bits)
                {
                    return "i";
                }
                return "q";
            case "System.nuint":
                if (!Is64Bits)
                {
                    return "I";
                }
                return "Q";
            case "System.DateTime":
                throw CreateException(4102, member, "The registrar found an invalid type `{0}` in signature for method `{2}`. Use `{1}` instead.", "System.DateTime", "Foundation.NSDate", member.FullName);
            default:
                {
                    if (typeFullName == "System.Runtime.InteropServices.NFloat")
                    {
                        if (!Is64Bits)
                        {
                            return "f";
                        }
                        return "d";
                    }
                    if (Is(type, ObjCRuntime, "Selector"))
                    {
                        return ":";
                    }
                    if (Is(type, ObjCRuntime, "Class"))
                    {
                        return "#";
                    }
                    if (IsINativeObject(type))
                    {
                        if (!IsGenericType(type) && !IsInterface(type) && !IsNSObject(type) && IsAbstract(type))
                        {
                            ErrorHelper.Show(CreateWarning(4179, member, "The registrar found the abstract type '{0}' in the signature for '{1}'. Abstract types should not be used in the signature for a member exported to Objective-C.", type.FullName, member.FullName));
                        }
                        if (IsNSObject(type) && forProperty)
                        {
                            return "@\"" + GetExportedTypeName(type) + "\"";
                        }
                        return "@";
                    }
                    if (IsDelegate(type))
                    {
                        return "^v";
                    }
                    if (IsEnum(type, out var isNativeEnum))
                    {
                        if (isNativeEnum && !Is64Bits)
                        {
                            string fullName = GetEnumUnderlyingType(type).FullName;
                            if (!(fullName == "System.Int64"))
                            {
                                if (fullName == "System.UInt64")
                                {
                                    return "I";
                                }
                                throw CreateException(4145, "Invalid enum '{0}': enums with the [Native] attribute must have a underlying enum type of either 'long' or 'ulong'.", GetTypeFullName(type));
                            }
                            return "i";
                        }
                        return ToSignature(GetEnumUnderlyingType(type), member, ref success);
                    }
                    if (IsValueType(type))
                    {
                        return ValueTypeSignature(type, member, ref success);
                    }
                    if (IsArray(type))
                    {
                        ToSignature(GetElementType(type), member, ref success);
                        return "@";
                    }
                    success = false;
                    return string.Empty;
                }
        }
    }

    private string ValueTypeSignature(Type type, ObjCMember member)
    {
        bool success = true;
        return ValueTypeSignature(type, member, ref success);
    }

    private string ValueTypeSignature(Type type, ObjCMember member, ref bool success)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("{");
        stringBuilder.AppendFormat("{0}=", GetTypeName(type));
        foreach (FieldInfo field in GetFields(type))
        {
            if (!IsStatic(field))
            {
                stringBuilder.Append(ToSignature(GetFieldType(field), member, ref success));
            }
        }
        stringBuilder.Append("}");
        return stringBuilder.ToString();
    }

    protected void LockRegistrar(ref bool lockTaken)
    {
        Monitor.Enter(types, ref lockTaken);
    }

    protected void UnlockRegistrar()
    {
        Monitor.Exit(types);
    }

    protected virtual void ReportError(int code, string message, params object[] args)
    {
        LogHelper.NSLog(string.Format(message, args));
    }

    protected virtual void ReportWarning(int code, string message, params object[] args)
    {
        LogHelper.NSLog(ErrorHelper.CreateWarning(code, message, args).ToString());
    }

    [Conditional("VERBOSE_REGISTRAR")]
    public static void FlushTrace()
    {
        if (trace != null)
        {
            trace.Insert(0, '\n');
            LogHelper.NSLog(trace.ToString());
            trace.Clear();
        }
    }

    [Conditional("VERBOSE_REGISTRAR")]
    public static void Trace(string msg, params object[] args)
    {
        if (trace == null)
        {
            trace = new StringBuilder();
        }
        trace.AppendFormat(msg, args);
        trace.AppendLine();
    }
}

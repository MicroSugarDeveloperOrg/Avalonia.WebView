using System.Reflection;
using System.Runtime.InteropServices;
using Xamarin.System;

namespace Xamarin.Utiles;
internal class Stret
{
    private static bool IsHomogeneousAggregateSmallEnough_Armv7k(Type t, int members)
    {
        return members <= 4;
    }

    private static bool IsHomogeneousAggregateBaseType_Armv7k(Type t, object generator)
    {
        if (t == typeof(float) || t == typeof(double) || t == typeof(nfloat))
        {
            return true;
        }
        return false;
    }

    private static bool IsHomogeneousAggregate_Armv7k(List<Type> fieldTypes, object generator)
    {
        if (fieldTypes.Count == 0)
        {
            return false;
        }
        if (!IsHomogeneousAggregateSmallEnough_Armv7k(fieldTypes[0], fieldTypes.Count))
        {
            return false;
        }
        if (!IsHomogeneousAggregateBaseType_Armv7k(fieldTypes[0], generator))
        {
            return false;
        }
        for (int i = 1; i < fieldTypes.Count; i++)
        {
            if (fieldTypes[0] != fieldTypes[i])
            {
                return false;
            }
        }
        return true;
    }

    public static bool ArmNeedStret(Type returnType, object generator)
    {
        if (0 == 0)
        {
            return false;
        }
        if (!returnType.IsValueType || returnType.IsEnum || IsBuiltInType(returnType))
        {
            return false;
        }
        List<Type> list = new List<Type>();
        int valueTypeSize = GetValueTypeSize(returnType, list, is_64_bits: false, generator);
        if (false)
        {
            if (valueTypeSize <= 16)
            {
                return false;
            }
            if (IsHomogeneousAggregate_Armv7k(list, generator))
            {
                return false;
            }
        }
        if (false && valueTypeSize <= 4 && list.Count == 1)
        {
            switch (list[0].FullName)
            {
                case "System.Char":
                case "System.Byte":
                case "System.SByte":
                case "System.UInt16":
                case "System.Int16":
                case "System.UInt32":
                case "System.Int32":
                case "System.IntPtr":
                case "System.nuint":
                case "System.uint":
                    return false;
            }
        }
        return true;
    }

    public static bool X86NeedStret(Type returnType, object generator)
    {
        if (!returnType.IsValueType || returnType.IsEnum || IsBuiltInType(returnType))
        {
            return false;
        }
        List<Type> list = new List<Type>();
        int valueTypeSize = GetValueTypeSize(returnType, list, is_64_bits: false, generator);
        if (valueTypeSize > 8)
        {
            return true;
        }
        if (list.Count == 3)
        {
            return true;
        }
        return false;
    }

    public static bool X86_64NeedStret(Type returnType, object generator)
    {
        if (!returnType.IsValueType || returnType.IsEnum || IsBuiltInType(returnType))
        {
            return false;
        }
        List<Type> fieldTypes = new List<Type>();
        return GetValueTypeSize(returnType, fieldTypes, is_64_bits: true, generator) > 16;
    }

    private static int GetValueTypeSize(Type type, List<Type> fieldTypes, bool is_64_bits, object generator)
    {
        int size = 0;
        int max_element_size = 1;
        if (type.IsExplicitLayout)
        {
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (FieldInfo fieldInfo in fields)
            {
                FieldOffsetAttribute fieldOffsetAttribute = (FieldOffsetAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(FieldOffsetAttribute));
                int size2 = 0;
                GetValueTypeSize(type, fieldInfo.FieldType, fieldTypes, is_64_bits, ref size2, ref max_element_size, generator);
                size = Math.Max(size, size2 + fieldOffsetAttribute.Value);
            }
        }
        else
        {
            GetValueTypeSize(type, type, fieldTypes, is_64_bits, ref size, ref max_element_size, generator);
        }
        if (size % max_element_size != 0)
        {
            size += max_element_size - size % max_element_size;
        }
        return size;
    }

    private static int AlignAndAdd(Type original_type, int size, int add, ref int max_element_size)
    {
        max_element_size = Math.Max(max_element_size, add);
        if (size % add != 0)
        {
            size += add - size % add;
        }
        return size += add;
    }

    private static bool IsBuiltInType(Type type)
    {
        int type_size;
        return IsBuiltInType(type, is_64_bits: true, out type_size);
    }

    private static bool IsBuiltInType(Type type, bool is_64_bits, out int type_size)
    {
        type_size = 0;
        if (type.IsNested)
        {
            return false;
        }
        if (type.Namespace != "System")
        {
            return false;
        }
        switch (type.Name)
        {
            case "Char":
            case "Boolean":
            case "SByte":
            case "Byte":
                type_size = 1;
                return true;
            case "Int16":
            case "UInt16":
                type_size = 2;
                return true;
            case "Single":
            case "Int32":
            case "UInt32":
                type_size = 4;
                return true;
            case "Double":
            case "Int64":
            case "UInt64":
                type_size = 8;
                return true;
            case "IntPtr":
            case "nfloat":
            case "nuint":
            case "nint":
                type_size = (is_64_bits ? 8 : 4);
                return true;
            case "Void":
                return true;
            default:
                return false;
        }
    }

    private static void GetValueTypeSize(Type original_type, Type type, List<Type> field_types, bool is_64_bits, ref int size, ref int max_element_size, object generator)
    {
        if (IsBuiltInType(type, is_64_bits, out var type_size) && type_size > 0)
        {
            field_types.Add(type);
            size = AlignAndAdd(original_type, size, type_size, ref max_element_size);
            return;
        }
        FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (FieldInfo fieldInfo in fields)
        {
            MarshalAsAttribute marshalAsAttribute = (MarshalAsAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(MarshalAsAttribute));
            if (marshalAsAttribute == null)
            {
                GetValueTypeSize(original_type, fieldInfo.FieldType, field_types, is_64_bits, ref size, ref max_element_size, generator);
                continue;
            }
            int num = 1;
            switch (marshalAsAttribute.Value)
            {
                case UnmanagedType.ByValArray:
                    {
                        List<Type> field_types2 = new List<Type>();
                        GetValueTypeSize(original_type, fieldInfo.FieldType.GetElementType(), field_types2, is_64_bits, ref type_size, ref max_element_size, generator);
                        num = marshalAsAttribute.SizeConst;
                        break;
                    }
                case UnmanagedType.I1:
                case UnmanagedType.U1:
                    type_size = 1;
                    break;
                case UnmanagedType.I2:
                case UnmanagedType.U2:
                    type_size = 2;
                    break;
                case UnmanagedType.I4:
                case UnmanagedType.U4:
                case UnmanagedType.R4:
                    type_size = 4;
                    break;
                case UnmanagedType.I8:
                case UnmanagedType.U8:
                case UnmanagedType.R8:
                    type_size = 8;
                    break;
                default:
                    throw new Exception($"Unhandled MarshalAs attribute: {marshalAsAttribute.Value} on field {fieldInfo.DeclaringType.FullName}.{fieldInfo.Name}");
            }
            field_types.Add(fieldInfo.FieldType);
            size = AlignAndAdd(original_type, size, type_size, ref max_element_size);
            size += (num - 1) * size;
        }
    }

    public static bool NeedStret(Type returnType, object generator)
    {
        if (X86NeedStret(returnType, generator))
        {
            return true;
        }
        if (X86_64NeedStret(returnType, generator))
        {
            return true;
        }
        if (ArmNeedStret(returnType, generator))
        {
            return true;
        }
        return false;
    }
}
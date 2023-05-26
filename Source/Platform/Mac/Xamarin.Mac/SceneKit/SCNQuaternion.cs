using OpenTK;
using System.Xml.Serialization;

namespace SceneKit;

[Serializable]
public struct SCNQuaternion : IEquatable<SCNQuaternion>
{
    private SCNVector3 xyz;

    private nfloat w;

    public static readonly SCNQuaternion Identity = new SCNQuaternion(0, 0, 0, 1);

    public SCNVector3 Xyz
    {
        get
        {
            return xyz;
        }
        set
        {
            xyz = value;
        }
    }

    [XmlIgnore]
    public nfloat X
    {
        get
        {
            return xyz.X;
        }
        set
        {
            xyz.X = value;
        }
    }

    [XmlIgnore]
    public nfloat Y
    {
        get
        {
            return xyz.Y;
        }
        set
        {
            xyz.Y = value;
        }
    }

    [XmlIgnore]
    public nfloat Z
    {
        get
        {
            return xyz.Z;
        }
        set
        {
            xyz.Z = value;
        }
    }

    public nfloat W
    {
        get
        {
            return w;
        }
        set
        {
            w = value;
        }
    }

    public float Length => (float)Math.Sqrt(W * W + Xyz.LengthSquared);

    public float LengthSquared => (float)(W * W + Xyz.LengthSquared);

    public SCNQuaternion(SCNVector3 v, nfloat w)
    {
        xyz = v;
        this.w = w;
    }

    public SCNQuaternion(nfloat x, nfloat y, nfloat z, nfloat w)
        : this(new SCNVector3(x, y, z), w)
    {
    }

    public SCNQuaternion(ref Matrix3 matrix)
    {
        double num = Math.Pow(matrix.Determinant, 1.0 / 3.0);
        w = (float)(Math.Sqrt(Math.Max(0.0, num + (double)matrix[0, 0] + (double)matrix[1, 1] + (double)matrix[2, 2])) / 2.0);
        float x = (float)(Math.Sqrt(Math.Max(0.0, num + (double)matrix[0, 0] - (double)matrix[1, 1] - (double)matrix[2, 2])) / 2.0);
        float y = (float)(Math.Sqrt(Math.Max(0.0, num - (double)matrix[0, 0] + (double)matrix[1, 1] - (double)matrix[2, 2])) / 2.0);
        float z = (float)(Math.Sqrt(Math.Max(0.0, num - (double)matrix[0, 0] - (double)matrix[1, 1] + (double)matrix[2, 2])) / 2.0);
        xyz = new Vector3(x, y, z);
        if (matrix[2, 1] - matrix[1, 2] < 0f)
        {
            X = -X;
        }
        if (matrix[0, 2] - matrix[2, 0] < 0f)
        {
            Y = -Y;
        }
        if (matrix[1, 0] - matrix[0, 1] < 0f)
        {
            Z = -Z;
        }
    }

    public SCNQuaternion(Quaternion openTkQuaternion)
        : this(new SCNVector3(openTkQuaternion.XYZ), openTkQuaternion.W)
    {
    }

    public void ToAxisAngle(out SCNVector3 axis, out nfloat angle)
    {
        SCNVector4 sCNVector = ToAxisAngle();
        axis = sCNVector.Xyz;
        angle = sCNVector.W;
    }

    public SCNVector4 ToAxisAngle()
    {
        SCNQuaternion sCNQuaternion = this;
        if (sCNQuaternion.W > 1f)
        {
            sCNQuaternion.Normalize();
        }
        SCNVector4 result = default(SCNVector4);
        result.W = 2f * (nfloat)Math.Acos(sCNQuaternion.W);
        nfloat nfloat = (nfloat)Math.Sqrt(1.0 - (double)(sCNQuaternion.W * sCNQuaternion.W));
        if (nfloat > 0.0001f)
        {
            result.Xyz = sCNQuaternion.Xyz / nfloat;
        }
        else
        {
            result.Xyz = SCNVector3.UnitX;
        }
        return result;
    }

    public void Normalize()
    {
        float num = 1f / Length;
        Xyz *= (nfloat)num;
        W *= (nfloat)num;
    }

    public void Conjugate()
    {
        Xyz = -Xyz;
    }

    public static SCNQuaternion Add(SCNQuaternion left, SCNQuaternion right)
    {
        return new SCNQuaternion(left.Xyz + right.Xyz, left.W + right.W);
    }

    public static void Add(ref SCNQuaternion left, ref SCNQuaternion right, out SCNQuaternion result)
    {
        result = new SCNQuaternion(left.Xyz + right.Xyz, left.W + right.W);
    }

    public static SCNQuaternion Sub(SCNQuaternion left, SCNQuaternion right)
    {
        return new SCNQuaternion(left.Xyz - right.Xyz, left.W - right.W);
    }

    public static void Sub(ref SCNQuaternion left, ref SCNQuaternion right, out SCNQuaternion result)
    {
        result = new SCNQuaternion(left.Xyz - right.Xyz, left.W - right.W);
    }

    public static SCNQuaternion Multiply(SCNQuaternion left, SCNQuaternion right)
    {
        Multiply(ref left, ref right, out var result);
        return result;
    }

    public static void Multiply(ref SCNQuaternion left, ref SCNQuaternion right, out SCNQuaternion result)
    {
        result = new SCNQuaternion(right.W * left.Xyz + left.W * right.Xyz + SCNVector3.Cross(left.Xyz, right.Xyz), left.W * right.W - SCNVector3.Dot(left.Xyz, right.Xyz));
    }

    public static void Multiply(ref SCNQuaternion quaternion, float scale, out SCNQuaternion result)
    {
        result = new SCNQuaternion(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
    }

    public static SCNQuaternion Multiply(SCNQuaternion quaternion, float scale)
    {
        return new SCNQuaternion(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
    }

    public static SCNQuaternion Conjugate(SCNQuaternion q)
    {
        return new SCNQuaternion(-q.Xyz, q.W);
    }

    public static void Conjugate(ref SCNQuaternion q, out SCNQuaternion result)
    {
        result = new SCNQuaternion(-q.Xyz, q.W);
    }

    public static SCNQuaternion Invert(SCNQuaternion q)
    {
        Invert(ref q, out var result);
        return result;
    }

    public static void Invert(ref SCNQuaternion q, out SCNQuaternion result)
    {
        float lengthSquared = q.LengthSquared;
        if ((double)lengthSquared != 0.0)
        {
            float num = 1f / lengthSquared;
            result = new SCNQuaternion(q.Xyz * (0f - num), q.W * num);
        }
        else
        {
            result = q;
        }
    }

    public static SCNQuaternion Normalize(SCNQuaternion q)
    {
        Normalize(ref q, out var result);
        return result;
    }

    public static void Normalize(ref SCNQuaternion q, out SCNQuaternion result)
    {
        float num = 1f / q.Length;
        result = new SCNQuaternion(q.Xyz * num, q.W * num);
    }

    public static SCNQuaternion FromAxisAngle(SCNVector3 axis, float angle)
    {
        if (axis.LengthSquared == 0f)
        {
            return Identity;
        }
        SCNQuaternion identity = Identity;
        angle *= 0.5f;
        axis.Normalize();
        identity.Xyz = axis * (float)Math.Sin(angle);
        identity.W = (float)Math.Cos(angle);
        return Normalize(identity);
    }

    public static SCNQuaternion Slerp(SCNQuaternion q1, SCNQuaternion q2, float blend)
    {
        if (q1.LengthSquared == 0f)
        {
            if (q2.LengthSquared == 0f)
            {
                return Identity;
            }
            return q2;
        }
        if (q2.LengthSquared == 0f)
        {
            return q1;
        }
        nfloat nfloat = q1.W * q2.W + SCNVector3.Dot(q1.Xyz, q2.Xyz);
        if (nfloat >= 1f || nfloat <= -1f)
        {
            return q1;
        }
        if (nfloat < 0f)
        {
            q2.Xyz = -q2.Xyz;
            q2.W = -q2.W;
            nfloat = -nfloat;
        }
        float num4;
        float num5;
        if (nfloat < 0.99f)
        {
            float num = (float)Math.Acos(nfloat);
            float num2 = (float)Math.Sin(num);
            float num3 = 1f / num2;
            num4 = (float)Math.Sin(num * (1f - blend)) * num3;
            num5 = (float)Math.Sin(num * blend) * num3;
        }
        else
        {
            num4 = 1f - blend;
            num5 = blend;
        }
        SCNQuaternion q3 = new SCNQuaternion(num4 * q1.Xyz + num5 * q2.Xyz, num4 * q1.W + num5 * q2.W);
        if (q3.LengthSquared > 0f)
        {
            return Normalize(q3);
        }
        return Identity;
    }

    public static SCNQuaternion operator +(SCNQuaternion left, SCNQuaternion right)
    {
        left.Xyz += right.Xyz;
        left.W += right.W;
        return left;
    }

    public static SCNQuaternion operator -(SCNQuaternion left, SCNQuaternion right)
    {
        left.Xyz -= right.Xyz;
        left.W -= right.W;
        return left;
    }

    public static SCNQuaternion operator *(SCNQuaternion left, SCNQuaternion right)
    {
        Multiply(ref left, ref right, out left);
        return left;
    }

    public static SCNQuaternion operator *(SCNQuaternion quaternion, float scale)
    {
        Multiply(ref quaternion, scale, out quaternion);
        return quaternion;
    }

    public static SCNQuaternion operator *(float scale, SCNQuaternion quaternion)
    {
        return new SCNQuaternion(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
    }

    public static bool operator ==(SCNQuaternion left, SCNQuaternion right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(SCNQuaternion left, SCNQuaternion right)
    {
        return !left.Equals(right);
    }

    public override string ToString()
    {
        return $"V: {Xyz}, W: {W}";
    }

    public override bool Equals(object other)
    {
        if (!(other is SCNQuaternion))
        {
            return false;
        }
        return this == (SCNQuaternion)other;
    }

    public override int GetHashCode()
    {
        return Xyz.GetHashCode() ^ W.GetHashCode();
    }

    public bool Equals(SCNQuaternion other)
    {
        return Xyz == other.Xyz && W == other.W;
    }
}
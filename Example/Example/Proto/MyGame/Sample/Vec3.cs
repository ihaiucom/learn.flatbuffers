// automatically generated by the FlatBuffers compiler, do not modify

namespace MyGame.Sample
{

using System;
using FlatBuffers;

public struct Vec3 : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Vec3 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
  public void MutateX(float x) { __p.bb.PutFloat(__p.bb_pos + 0, x); }
  public float Y { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }
  public void MutateY(float y) { __p.bb.PutFloat(__p.bb_pos + 4, y); }
  public float Z { get { return __p.bb.GetFloat(__p.bb_pos + 8); } }
  public void MutateZ(float z) { __p.bb.PutFloat(__p.bb_pos + 8, z); }

  public static Offset<Vec3> CreateVec3(FlatBufferBuilder builder, float X, float Y, float Z) {
    builder.Prep(4, 12);
    builder.PutFloat(Z);
    builder.PutFloat(Y);
    builder.PutFloat(X);
    return new Offset<Vec3>(builder.Offset);
  }
};


}

// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Game.Engine.Networking.FlatBuffers
{

using global::System;
using global::Google.FlatBuffers;

public enum AllMessages : byte
{
 NONE = 0,
 NetWorldView = 1,
 NetHello = 2,
 NetSpawn = 3,
 NetControlInput = 4,
 NetPing = 5,
 NetLeaderboard = 6,
};

public struct NetLeaderboard : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static NetLeaderboard GetRootAsNetLeaderboard(ByteBuffer _bb) { return GetRootAsNetLeaderboard(_bb, new NetLeaderboard()); }
  public static NetLeaderboard GetRootAsNetLeaderboard(ByteBuffer _bb, NetLeaderboard obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public NetLeaderboard __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Type { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetTypeBytes() { return __p.__vector_as_arraysegment(4); }
  public NetLeaderboardEntry? Entries(int j) { int o = __p.__offset(6); return o != 0 ? (NetLeaderboardEntry?)(new NetLeaderboardEntry()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int EntriesLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public NetLeaderboardEntry? Record { get { int o = __p.__offset(8); return o != 0 ? (NetLeaderboardEntry?)(new NetLeaderboardEntry()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<NetLeaderboard> CreateNetLeaderboard(FlatBufferBuilder builder,
      StringOffset typeOffset = default(StringOffset),
      VectorOffset entriesOffset = default(VectorOffset),
      Offset<NetLeaderboardEntry> recordOffset = default(Offset<NetLeaderboardEntry>)) {
    builder.StartObject(3);
    NetLeaderboard.AddRecord(builder, recordOffset);
    NetLeaderboard.AddEntries(builder, entriesOffset);
    NetLeaderboard.AddType(builder, typeOffset);
    return NetLeaderboard.EndNetLeaderboard(builder);
  }

  public static void StartNetLeaderboard(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset) { builder.AddOffset(0, typeOffset.Value, 0); }
  public static void AddEntries(FlatBufferBuilder builder, VectorOffset entriesOffset) { builder.AddOffset(1, entriesOffset.Value, 0); }
  public static VectorOffset CreateEntriesVector(FlatBufferBuilder builder, Offset<NetLeaderboardEntry>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartEntriesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRecord(FlatBufferBuilder builder, Offset<NetLeaderboardEntry> recordOffset) { builder.AddOffset(2, recordOffset.Value, 0); }
  public static Offset<NetLeaderboard> EndNetLeaderboard(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NetLeaderboard>(o);
  }
};

public struct NetLeaderboardEntry : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static NetLeaderboardEntry GetRootAsNetLeaderboardEntry(ByteBuffer _bb) { return GetRootAsNetLeaderboardEntry(_bb, new NetLeaderboardEntry()); }
  public static NetLeaderboardEntry GetRootAsNetLeaderboardEntry(ByteBuffer _bb, NetLeaderboardEntry obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public NetLeaderboardEntry __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
  public int Score { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Color { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetColorBytes() { return __p.__vector_as_arraysegment(8); }
  public Vec2? Position { get { int o = __p.__offset(10); return o != 0 ? (Vec2?)(new Vec2()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartNetLeaderboardEntry(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddScore(FlatBufferBuilder builder, int score) { builder.AddInt(1, score, 0); }
  public static void AddColor(FlatBufferBuilder builder, StringOffset colorOffset) { builder.AddOffset(2, colorOffset.Value, 0); }
  public static void AddPosition(FlatBufferBuilder builder, Offset<Vec2> positionOffset) { builder.AddStruct(3, positionOffset.Value, 0); }
  public static Offset<NetLeaderboardEntry> EndNetLeaderboardEntry(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NetLeaderboardEntry>(o);
  }
};

public struct NetHello : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static NetHello GetRootAsNetHello(ByteBuffer _bb) { return GetRootAsNetHello(_bb, new NetHello()); }
  public static NetHello GetRootAsNetHello(ByteBuffer _bb, NetHello obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public NetHello __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Time { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<NetHello> CreateNetHello(FlatBufferBuilder builder,
      long time = 0) {
    builder.StartObject(1);
    NetHello.AddTime(builder, time);
    return NetHello.EndNetHello(builder);
  }

  public static void StartNetHello(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddTime(FlatBufferBuilder builder, long time) { builder.AddLong(0, time, 0); }
  public static Offset<NetHello> EndNetHello(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NetHello>(o);
  }
};

public struct NetSpawn : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static NetSpawn GetRootAsNetSpawn(ByteBuffer _bb) { return GetRootAsNetSpawn(_bb, new NetSpawn()); }
  public static NetSpawn GetRootAsNetSpawn(ByteBuffer _bb, NetSpawn obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public NetSpawn __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
  public string Ship { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetShipBytes() { return __p.__vector_as_arraysegment(6); }
  public string Color { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetColorBytes() { return __p.__vector_as_arraysegment(8); }

  public static Offset<NetSpawn> CreateNetSpawn(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      StringOffset shipOffset = default(StringOffset),
      StringOffset colorOffset = default(StringOffset)) {
    builder.StartObject(3);
    NetSpawn.AddColor(builder, colorOffset);
    NetSpawn.AddShip(builder, shipOffset);
    NetSpawn.AddName(builder, nameOffset);
    return NetSpawn.EndNetSpawn(builder);
  }

  public static void StartNetSpawn(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddShip(FlatBufferBuilder builder, StringOffset shipOffset) { builder.AddOffset(1, shipOffset.Value, 0); }
  public static void AddColor(FlatBufferBuilder builder, StringOffset colorOffset) { builder.AddOffset(2, colorOffset.Value, 0); }
  public static Offset<NetSpawn> EndNetSpawn(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NetSpawn>(o);
  }
};

public struct NetControlInput : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static NetControlInput GetRootAsNetControlInput(ByteBuffer _bb) { return GetRootAsNetControlInput(_bb, new NetControlInput()); }
  public static NetControlInput GetRootAsNetControlInput(ByteBuffer _bb, NetControlInput obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public NetControlInput __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float Angle { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float X { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Y { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool Boost { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Shoot { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<NetControlInput> CreateNetControlInput(FlatBufferBuilder builder,
      float angle = 0.0f,
      float x = 0.0f,
      float y = 0.0f,
      bool boost = false,
      bool shoot = false) {
    builder.StartObject(5);
    NetControlInput.AddY(builder, y);
    NetControlInput.AddX(builder, x);
    NetControlInput.AddAngle(builder, angle);
    NetControlInput.AddShoot(builder, shoot);
    NetControlInput.AddBoost(builder, boost);
    return NetControlInput.EndNetControlInput(builder);
  }

  public static void StartNetControlInput(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddAngle(FlatBufferBuilder builder, float angle) { builder.AddFloat(0, angle, 0.0f); }
  public static void AddX(FlatBufferBuilder builder, float x) { builder.AddFloat(1, x, 0.0f); }
  public static void AddY(FlatBufferBuilder builder, float y) { builder.AddFloat(2, y, 0.0f); }
  public static void AddBoost(FlatBufferBuilder builder, bool boost) { builder.AddBool(3, boost, false); }
  public static void AddShoot(FlatBufferBuilder builder, bool shoot) { builder.AddBool(4, shoot, false); }
  public static Offset<NetControlInput> EndNetControlInput(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NetControlInput>(o);
  }
};

public struct NetPing : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static NetPing GetRootAsNetPing(ByteBuffer _bb) { return GetRootAsNetPing(_bb, new NetPing()); }
  public static NetPing GetRootAsNetPing(ByteBuffer _bb, NetPing obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public NetPing __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Time { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<NetPing> CreateNetPing(FlatBufferBuilder builder,
      long time = 0) {
    builder.StartObject(1);
    NetPing.AddTime(builder, time);
    return NetPing.EndNetPing(builder);
  }

  public static void StartNetPing(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddTime(FlatBufferBuilder builder, long time) { builder.AddLong(0, time, 0); }
  public static Offset<NetPing> EndNetPing(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NetPing>(o);
  }
};

public struct NetWorldView : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static NetWorldView GetRootAsNetWorldView(ByteBuffer _bb) { return GetRootAsNetWorldView(_bb, new NetWorldView()); }
  public static NetWorldView GetRootAsNetWorldView(ByteBuffer _bb, NetWorldView obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public NetWorldView __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Time { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public short PlayerCount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public bool IsAlive { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)true; } }
  public NetBody? Updates(int j) { int o = __p.__offset(10); return o != 0 ? (NetBody?)(new NetBody()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int UpdatesLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int Deletes(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int DeletesLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetDeletesBytes() { return __p.__vector_as_arraysegment(12); }
  public NetAnnouncement? Announcements(int j) { int o = __p.__offset(14); return o != 0 ? (NetAnnouncement?)(new NetAnnouncement()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int AnnouncementsLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public NetBody? Camera { get { int o = __p.__offset(16); return o != 0 ? (NetBody?)(new NetBody()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<NetWorldView> CreateNetWorldView(FlatBufferBuilder builder,
      long time = 0,
      short playerCount = 0,
      bool isAlive = true,
      VectorOffset updatesOffset = default(VectorOffset),
      VectorOffset deletesOffset = default(VectorOffset),
      VectorOffset announcementsOffset = default(VectorOffset),
      Offset<NetBody> cameraOffset = default(Offset<NetBody>)) {
    builder.StartObject(7);
    NetWorldView.AddTime(builder, time);
    NetWorldView.AddCamera(builder, cameraOffset);
    NetWorldView.AddAnnouncements(builder, announcementsOffset);
    NetWorldView.AddDeletes(builder, deletesOffset);
    NetWorldView.AddUpdates(builder, updatesOffset);
    NetWorldView.AddPlayerCount(builder, playerCount);
    NetWorldView.AddIsAlive(builder, isAlive);
    return NetWorldView.EndNetWorldView(builder);
  }

  public static void StartNetWorldView(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddTime(FlatBufferBuilder builder, long time) { builder.AddLong(0, time, 0); }
  public static void AddPlayerCount(FlatBufferBuilder builder, short playerCount) { builder.AddShort(1, playerCount, 0); }
  public static void AddIsAlive(FlatBufferBuilder builder, bool isAlive) { builder.AddBool(2, isAlive, true); }
  public static void AddUpdates(FlatBufferBuilder builder, VectorOffset updatesOffset) { builder.AddOffset(3, updatesOffset.Value, 0); }
  public static VectorOffset CreateUpdatesVector(FlatBufferBuilder builder, Offset<NetBody>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartUpdatesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDeletes(FlatBufferBuilder builder, VectorOffset deletesOffset) { builder.AddOffset(4, deletesOffset.Value, 0); }
  public static VectorOffset CreateDeletesVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDeletesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAnnouncements(FlatBufferBuilder builder, VectorOffset announcementsOffset) { builder.AddOffset(5, announcementsOffset.Value, 0); }
  public static VectorOffset CreateAnnouncementsVector(FlatBufferBuilder builder, Offset<NetAnnouncement>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartAnnouncementsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCamera(FlatBufferBuilder builder, Offset<NetBody> cameraOffset) { builder.AddOffset(6, cameraOffset.Value, 0); }
  public static Offset<NetWorldView> EndNetWorldView(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NetWorldView>(o);
  }
};

public struct NetBody : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static NetBody GetRootAsNetBody(ByteBuffer _bb) { return GetRootAsNetBody(_bb, new NetBody()); }
  public static NetBody GetRootAsNetBody(ByteBuffer _bb, NetBody obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public NetBody __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long DefinitionTime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Size { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)-1; } }
  public string Sprite { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetSpriteBytes() { return __p.__vector_as_arraysegment(10); }
  public string Color { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetColorBytes() { return __p.__vector_as_arraysegment(12); }
  public string Caption { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetCaptionBytes() { return __p.__vector_as_arraysegment(14); }
  public float OriginalAngle { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)-999.0f; } }
  public float AngularVelocity { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)-999.0f; } }
  public Vec2? Momentum { get { int o = __p.__offset(20); return o != 0 ? (Vec2?)(new Vec2()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public Vec2? OriginalPosition { get { int o = __p.__offset(22); return o != 0 ? (Vec2?)(new Vec2()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartNetBody(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddDefinitionTime(FlatBufferBuilder builder, long definitionTime) { builder.AddLong(1, definitionTime, 0); }
  public static void AddSize(FlatBufferBuilder builder, int size) { builder.AddInt(2, size, -1); }
  public static void AddSprite(FlatBufferBuilder builder, StringOffset spriteOffset) { builder.AddOffset(3, spriteOffset.Value, 0); }
  public static void AddColor(FlatBufferBuilder builder, StringOffset colorOffset) { builder.AddOffset(4, colorOffset.Value, 0); }
  public static void AddCaption(FlatBufferBuilder builder, StringOffset captionOffset) { builder.AddOffset(5, captionOffset.Value, 0); }
  public static void AddOriginalAngle(FlatBufferBuilder builder, float originalAngle) { builder.AddFloat(6, originalAngle, -999.0f); }
  public static void AddAngularVelocity(FlatBufferBuilder builder, float angularVelocity) { builder.AddFloat(7, angularVelocity, -999.0f); }
  public static void AddMomentum(FlatBufferBuilder builder, Offset<Vec2> momentumOffset) { builder.AddStruct(8, momentumOffset.Value, 0); }
  public static void AddOriginalPosition(FlatBufferBuilder builder, Offset<Vec2> originalPositionOffset) { builder.AddStruct(9, originalPositionOffset.Value, 0); }
  public static Offset<NetBody> EndNetBody(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NetBody>(o);
  }
};

public struct NetAnnouncement : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static NetAnnouncement GetRootAsNetAnnouncement(ByteBuffer _bb) { return GetRootAsNetAnnouncement(_bb, new NetAnnouncement()); }
  public static NetAnnouncement GetRootAsNetAnnouncement(ByteBuffer _bb, NetAnnouncement obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public NetAnnouncement __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Text { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetTextBytes() { return __p.__vector_as_arraysegment(4); }

  public static Offset<NetAnnouncement> CreateNetAnnouncement(FlatBufferBuilder builder,
      StringOffset TextOffset = default(StringOffset)) {
    builder.StartObject(1);
    NetAnnouncement.AddText(builder, TextOffset);
    return NetAnnouncement.EndNetAnnouncement(builder);
  }

  public static void StartNetAnnouncement(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddText(FlatBufferBuilder builder, StringOffset TextOffset) { builder.AddOffset(0, TextOffset.Value, 0); }
  public static Offset<NetAnnouncement> EndNetAnnouncement(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NetAnnouncement>(o);
  }
};

public struct Vec2 : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Vec2 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
  public float Y { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }

  public static Offset<Vec2> CreateVec2(FlatBufferBuilder builder, float X, float Y) {
    builder.Prep(4, 8);
    builder.PutFloat(Y);
    builder.PutFloat(X);
    return new Offset<Vec2>(builder.Offset);
  }
};

public struct NetQuantum : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static NetQuantum GetRootAsNetQuantum(ByteBuffer _bb) { return GetRootAsNetQuantum(_bb, new NetQuantum()); }
  public static NetQuantum GetRootAsNetQuantum(ByteBuffer _bb, NetQuantum obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public NetQuantum __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public AllMessages MessageType { get { int o = __p.__offset(4); return o != 0 ? (AllMessages)__p.bb.Get(o + __p.bb_pos) : AllMessages.NONE; } }
  public TTable? Message<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o) : null; }

  public static Offset<NetQuantum> CreateNetQuantum(FlatBufferBuilder builder,
      AllMessages message_type = AllMessages.NONE,
      int messageOffset = 0) {
    builder.StartObject(2);
    NetQuantum.AddMessage(builder, messageOffset);
    NetQuantum.AddMessageType(builder, message_type);
    return NetQuantum.EndNetQuantum(builder);
  }

  public static void StartNetQuantum(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddMessageType(FlatBufferBuilder builder, AllMessages messageType) { builder.AddByte(0, (byte)messageType, 0); }
  public static void AddMessage(FlatBufferBuilder builder, int messageOffset) { builder.AddOffset(1, messageOffset, 0); }
  public static Offset<NetQuantum> EndNetQuantum(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NetQuantum>(o);
  }
  public static void FinishNetQuantumBuffer(FlatBufferBuilder builder, Offset<NetQuantum> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedNetQuantumBuffer(FlatBufferBuilder builder, Offset<NetQuantum> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}
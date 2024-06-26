//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System;


namespace ET
{

public sealed partial class StartProcessConfig: Bright.Config.BeanBase
{
    public StartProcessConfig(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        MachineId = _buf.ReadInt();
        Port = _buf.ReadInt();
        PostInit();
    }

    public static StartProcessConfig DeserializeStartProcessConfig(ByteBuf _buf)
    {
        return new StartProcessConfig(_buf);
    }

    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 所属机器
    /// </summary>
    public int MachineId { get; private set; }
    /// <summary>
    /// 内网端口
    /// </summary>
    public int Port { get; private set; }

    public const int __ID__ = 2140444015;
    public override int GetTypeId() => __ID__;

    public  void Resolve(ConcurrentDictionary<Type, IConfigSingleton> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "MachineId:" + MachineId + ","
        + "Port:" + Port + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
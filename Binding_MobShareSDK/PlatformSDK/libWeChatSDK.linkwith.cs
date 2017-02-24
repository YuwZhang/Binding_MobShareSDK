using System;
using ObjCRuntime;

[assembly: LinkWith ("libWeChatSDK.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, LinkerFlags = "-licucore -lz -lstdc++ -lsqlite3 -ObjC")]

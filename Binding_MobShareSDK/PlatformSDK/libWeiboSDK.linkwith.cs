using System;
using ObjCRuntime;

[assembly: LinkWith ("libWeiboSDK.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, LinkerFlags = "-licucore -lz -lstdc++ -lsqlite3 -ObjC")]

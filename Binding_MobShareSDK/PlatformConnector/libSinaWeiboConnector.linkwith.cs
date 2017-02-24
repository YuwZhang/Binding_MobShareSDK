using System;
using ObjCRuntime;

[assembly: LinkWith ("libSinaWeiboConnector.a", LinkTarget.Simulator | LinkTarget.ArmV7s | LinkTarget.ArmV7, ForceLoad = true)]

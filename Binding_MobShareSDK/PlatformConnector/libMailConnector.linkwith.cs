using System;
using ObjCRuntime;

[assembly: LinkWith ("libMailConnector.a", LinkTarget.Simulator | LinkTarget.ArmV7s | LinkTarget.ArmV7, ForceLoad = true)]

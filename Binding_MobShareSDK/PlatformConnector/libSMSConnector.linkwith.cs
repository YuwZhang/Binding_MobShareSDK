using System;
using ObjCRuntime;

[assembly: LinkWith ("libSMSConnector.a", LinkTarget.Simulator | LinkTarget.ArmV7s | LinkTarget.ArmV7, ForceLoad = true)]

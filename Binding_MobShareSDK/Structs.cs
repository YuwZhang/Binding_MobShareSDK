using System;

namespace Binding_MobShareSDK
{
    public enum SSDKPlatformType : uint
    {
        SSDKPlatformTypeUnknown = 0,             // 未知
        SSDKPlatformTypeSinaWeibo = 1,           // 新浪微博
        SSDKPlatformSubTypeQZone = 6,            // QQ空间
        SSDKPlatformTypeMail = 18,               // 邮件
        SSDKPlatformTypeSMS = 19,                // 短信
        SSDKPlatformSubTypeWechatSession = 22,   // 微信好友
        SSDKPlatformSubTypeWechatTimeline = 23,  // 微信朋友圈
        SSDKPlatformSubTypeQQFriend = 24,        // QQ好友
        SSDKPlatformSubTypeWechatFav = 37,       // 微信收藏
        SSDKPlatformTypeWechat = 997,            // 微信平台
        SSDKPlatformTypeQQ = 998,                // QQ平台
        SSDKPlatformTypeAny = 999                // 任意平台
    }

    public enum SSDKEvernoteHostType : ulong
    {
        Sandbox = 0,
        Cn = 1,
        Us = 2
    }

    public enum SSDKResponseState : ulong
    {
        Begin = 0,
        Success = 1,
        Fail = 2,
        Cancel = 3
    }

    public enum SSDKContentType : ulong
    {
        Auto = 0,
        Text = 1,
        Image = 2,
        WebPage = 3,
        App = 4,
        Audio = 5,
        Video = 6,
        File = 7
    }

    public enum SSDKGender : ulong
    {
        Male = 0,
        Female = 1,
        Unknown = 2
    }

    public enum SSDKCredentialType : ulong
    {
        Unknown = 0,
        OAuth1x = 1,
        OAuth2 = 2
    }
}
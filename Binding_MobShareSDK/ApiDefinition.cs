using System;
using CoreGraphics;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace Binding_MobShareSDK
{
    // @interface ShareSDKConnector : NSObject
    [BaseType(typeof(NSObject))]
    interface ShareSDKConnector
    {
        // +(void)connectWeChat:(Class)wxApiClass;
        [Static]
        [Export("connectWeChat:")]
        void ConnectWeChat(Class wxApiClass);

        // +(void)connectWeChat:(Class)wxApiClass delegate:(id)delegate;
        [Static]
        [Export("connectWeChat:delegate:")]
        void ConnectWeChat(Class wxApiClass, NSObject @delegate);

        // +(void)connectWeibo:(Class)weiboSDKClass;
        [Static]
        [Export("connectWeibo:")]
        void ConnectWeibo(Class weiboSDKClass);

        // +(void)connectQQ:(Class)qqApiInterfaceClass tencentOAuthClass:(Class)tencentOAuthClass;
        [Static]
        [Export("connectQQ:tencentOAuthClass:")]
        void ConnectQQ(Class qqApiInterfaceClass, Class tencentOAuthClass);
    }

    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const SSDKAuthTypeBoth;
        [Field("SSDKAuthTypeBoth", "__Internal")]
        NSString SSDKAuthTypeBoth { get; }

        // extern NSString *const SSDKAuthTypeSSO;
        [Field("SSDKAuthTypeSSO", "__Internal")]
        NSString SSDKAuthTypeSSO { get; }

        // extern NSString *const SSDKAuthTypeWeb;
        [Field("SSDKAuthTypeWeb", "__Internal")]
        NSString SSDKAuthTypeWeb { get; }

        // extern NSString *const SSDKHttpMethodGet;
        [Field("SSDKHttpMethodGet", "__Internal")]
        NSString SSDKHttpMethodGet { get; }

        // extern NSString *const SSDKHttpMethodPost;
        [Field("SSDKHttpMethodPost", "__Internal")]
        NSString SSDKHttpMethodPost { get; }

        // extern NSString *const SSDKHttpMethodDelete;
        [Field("SSDKHttpMethodDelete", "__Internal")]
        NSString SSDKHttpMethodDelete { get; }

        // extern NSString *const SSDKHttpMethodPut;
        [Field("SSDKHttpMethodPut", "__Internal")]
        NSString SSDKHttpMethodPut { get; }

        // extern NSString *const SSDKHttpMethodHead;
        [Field("SSDKHttpMethodHead", "__Internal")]
        NSString SSDKHttpMethodHead { get; }

        // extern NSString *const SSDKAuthSettingKeyScopes;
        [Field("SSDKAuthSettingKeyScopes", "__Internal")]
        NSString SSDKAuthSettingKeyScopes { get; }
    }

    // typedef void (^SSDKConfigurationHandler)(SSDKPlatformType, NSMutableDictionary *);
    delegate void SSDKConfigurationHandler(SSDKPlatformType arg0, NSMutableDictionary arg1);

    // typedef void (^SSDKImportHandler)(SSDKPlatformType);
    delegate void SSDKImportHandler(SSDKPlatformType arg0);

    // typedef void (^SSDKShareStateChangedHandler)(SSDKResponseState, NSDictionary *, SSDKContentEntity *, NSError *);
    delegate void SSDKShareStateChangedHandler(SSDKResponseState arg0, NSDictionary arg1, SSDKContentEntity arg2, NSError arg3);

    // @interface SSDKInit (NSMutableDictionary)
    [Category]
    [BaseType(typeof(NSMutableDictionary))]
    interface NSMutableDictionary_SSDKInit
    {
        // -(void)SSDKSetAuthSettings:(NSArray *)authSettings;
        [Export("SSDKSetAuthSettings:")]
        //[Verify(StronglyTypedNSArray)]
        void SSDKSetAuthSettings(NSObject[] authSettings);

        // -(void)SSDKSetupSinaWeiboByAppKey:(NSString *)appKey appSecret:(NSString *)appSecret redirectUri:(NSString *)redirectUri authType:(NSString *)authType;
        [Export("SSDKSetupSinaWeiboByAppKey:appSecret:redirectUri:authType:")]
        void SSDKSetupSinaWeiboByAppKey(string appKey, string appSecret, string redirectUri, string authType);

        // -(void)SSDKSetupWeChatByAppId:(NSString *)appId appSecret:(NSString *)appSecret;
        [Export("SSDKSetupWeChatByAppId:appSecret:")]
        void SSDKSetupWeChatByAppId(string appId, string appSecret);

        // -(void)SSDKSetupQQByAppId:(NSString *)appId appKey:(NSString *)appKey authType:(NSString *)authType;
        [Export("SSDKSetupQQByAppId:appKey:authType:")]
        void SSDKSetupQQByAppId(string appId, string appKey, string authType);
    }

    // @interface SSDKShare (NSMutableDictionary)
    [Category]
    [BaseType(typeof(NSMutableDictionary))]
    interface NSMutableDictionary_SSDKShare
    {
        // -(void)SSDKSetShareFlags:(NSArray *)flags;
        [Export("SSDKSetShareFlags:")]
        //[Verify(StronglyTypedNSArray)]
        void SSDKSetShareFlags(NSObject[] flags);

        // -(void)SSDKEnableUseClientShare;
        [Export("SSDKEnableUseClientShare")]
        void SSDKEnableUseClientShare();

        // -(void)SSDKSetupShareParamsByText:(NSString *)text images:(id)images url:(NSURL *)url title:(NSString *)title type:(SSDKContentType)type;
        [Export("SSDKSetupShareParamsByText:images:url:title:type:")]
        void SSDKSetupShareParamsByText(string text, NSObject images, NSUrl url, string title, SSDKContentType type);

        // -(void)SSDKSetupSinaWeiboShareParamsByText:(NSString *)text title:(NSString *)title image:(id)image url:(NSURL *)url latitude:(double)latitude longitude:(double)longitude objectID:(NSString *)objectID type:(SSDKContentType)type;
        [Export("SSDKSetupSinaWeiboShareParamsByText:title:image:url:latitude:longitude:objectID:type:")]
        void SSDKSetupSinaWeiboShareParamsByText(string text, string title, NSObject image, NSUrl url, double latitude, double longitude, string objectID, SSDKContentType type);

        // -(void)SSDKSetupWeChatParamsByText:(NSString *)text title:(NSString *)title url:(NSURL *)url thumbImage:(id)thumbImage image:(id)image musicFileURL:(NSURL *)musicFileURL extInfo:(NSString *)extInfo fileData:(id)fileData emoticonData:(id)emoticonData type:(SSDKContentType)type forPlatformSubType:(SSDKPlatformType)platformSubType;
        [Export("SSDKSetupWeChatParamsByText:title:url:thumbImage:image:musicFileURL:extInfo:fileData:emoticonData:type:forPlatformSubType:")]
        void SSDKSetupWeChatParamsByText(string text, string title, NSUrl url, NSObject thumbImage, NSObject image, NSUrl musicFileURL, string extInfo, NSObject fileData, NSObject emoticonData, SSDKContentType type, SSDKPlatformType platformSubType);

        // -(void)SSDKSetupWeChatParamsByText:(NSString *)text title:(NSString *)title url:(NSURL *)url thumbImage:(id)thumbImage image:(id)image musicFileURL:(NSURL *)musicFileURL extInfo:(NSString *)extInfo fileData:(id)fileData emoticonData:(id)emoticonData sourceFileExtension:(NSString *)fileExtension sourceFileData:(id)sourceFileData type:(SSDKContentType)type forPlatformSubType:(SSDKPlatformType)platformSubType;
        [Export("SSDKSetupWeChatParamsByText:title:url:thumbImage:image:musicFileURL:extInfo:fileData:emoticonData:sourceFileExtension:sourceFileData:type:forPlatformSubType:")]
        void SSDKSetupWeChatParamsByText(string text, string title, NSUrl url, NSObject thumbImage, NSObject image, NSUrl musicFileURL, string extInfo, NSObject fileData, NSObject emoticonData, string fileExtension, NSObject sourceFileData, SSDKContentType type, SSDKPlatformType platformSubType);

        // -(void)SSDKSetupQQParamsByText:(NSString *)text title:(NSString *)title url:(NSURL *)url thumbImage:(id)thumbImage image:(id)image type:(SSDKContentType)type forPlatformSubType:(SSDKPlatformType)platformSubType;
        [Export("SSDKSetupQQParamsByText:title:url:thumbImage:image:type:forPlatformSubType:")]
        void SSDKSetupQQParamsByText(string text, string title, NSUrl url, NSObject thumbImage, NSObject image, SSDKContentType type, SSDKPlatformType platformSubType);

        // -(void)SSDKSetupQQParamsByText:(NSString *)text title:(NSString *)title url:(NSURL *)url audioFlashURL:(NSURL *)audioFlashURL videoFlashURL:(NSURL *)videoFlashURL thumbImage:(id)thumbImage images:(id)images type:(SSDKContentType)type forPlatformSubType:(SSDKPlatformType)platformSubType;
        [Export("SSDKSetupQQParamsByText:title:url:audioFlashURL:videoFlashURL:thumbImage:images:type:forPlatformSubType:")]
        void SSDKSetupQQParamsByText(string text, string title, NSUrl url, NSUrl audioFlashURL, NSUrl videoFlashURL, NSObject thumbImage, NSObject images, SSDKContentType type, SSDKPlatformType platformSubType);

        // -(void)SSDKSetupSMSParamsByText:(NSString *)text title:(NSString *)title images:(id)images attachments:(id)attachments recipients:(NSArray *)recipients type:(SSDKContentType)type;
        [Export("SSDKSetupSMSParamsByText:title:images:attachments:recipients:type:")]
        //[Verify(StronglyTypedNSArray)]
        void SSDKSetupSMSParamsByText(string text, string title, NSObject images, NSObject attachments, NSObject[] recipients, SSDKContentType type);

        // -(void)SSDKSetupMailParamsByText:(NSString *)text title:(NSString *)title images:(id)images attachments:(id)attachments recipients:(NSArray *)recipients ccRecipients:(NSArray *)ccRecipients bccRecipients:(NSArray *)bccRecipients type:(SSDKContentType)type;
        [Export("SSDKSetupMailParamsByText:title:images:attachments:recipients:ccRecipients:bccRecipients:type:")]
        //[Verify(StronglyTypedNSArray), Verify(StronglyTypedNSArray), Verify(StronglyTypedNSArray)]
        void SSDKSetupMailParamsByText(string text, string title, NSObject images, NSObject attachments, NSObject[] recipients, NSObject[] ccRecipients, NSObject[] bccRecipients, SSDKContentType type);
    }

    // @interface SSDKContentEntity : NSObject
    [BaseType(typeof(NSObject))]
    interface SSDKContentEntity
    {
        // @property (copy, nonatomic) NSString * cid;
        [Export("cid")]
        string Cid { get; set; }

        // @property (copy, nonatomic) NSString * text;
        [Export("text")]
        string Text { get; set; }

        // @property (retain, nonatomic) NSArray * images;
        [Export("images", ArgumentSemantic.Retain)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] Images { get; set; }

        // @property (retain, nonatomic) NSArray * urls;
        [Export("urls", ArgumentSemantic.Retain)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] Urls { get; set; }

        // @property (retain, nonatomic) id rawData;
        [Export("rawData", ArgumentSemantic.Retain)]
        NSObject RawData { get; set; }
    }

    // @interface ShareSDK : NSObject
    [BaseType(typeof(NSObject))]
    interface ShareSDK
    {
        // +(void)registerApp:(NSString *)appKey activePlatforms:(NSArray *)activePlatforms onImport:(SSDKImportHandler)importHandler onConfiguration:(SSDKConfigurationHandler)configurationHandler;
        [Static]
        [Export("registerApp:activePlatforms:onImport:onConfiguration:")]
        //[Verify(StronglyTypedNSArray)]
        void RegisterApp(string appKey, NSObject[] activePlatforms, SSDKImportHandler importHandler, SSDKConfigurationHandler configurationHandler);

        //// +(void)authorize:(SSDKPlatformType)platformType settings:(NSDictionary *)settings onStateChanged:(SSDKAuthorizeStateChangedHandler)stateChangedHandler;
        //[Static]
        //[Export("authorize:settings:onStateChanged:")]
        //void Authorize(SSDKPlatformType platformType, NSDictionary settings, SSDKAuthorizeStateChangedHandler stateChangedHandler);

        //// +(BOOL)hasAuthorized:(SSDKPlatformType)platformTypem;
        //[Static]
        //[Export("hasAuthorized:")]
        //bool HasAuthorized(SSDKPlatformType platformTypem);

        //// +(void)cancelAuthorize:(SSDKPlatformType)platformType;
        //[Static]
        //[Export("cancelAuthorize:")]
        //void CancelAuthorize(SSDKPlatformType platformType);

        //// +(void)getUserInfo:(SSDKPlatformType)platformType onStateChanged:(SSDKGetUserStateChangedHandler)stateChangedHandler;
        //[Static]
        //[Export("getUserInfo:onStateChanged:")]
        //void GetUserInfo(SSDKPlatformType platformType, SSDKGetUserStateChangedHandler stateChangedHandler);

        //// +(void)getUserInfo:(SSDKPlatformType)platformType conditional:(SSDKUserQueryConditional *)conditional onStateChanged:(SSDKGetUserStateChangedHandler)stateChangedHandler;
        //[Static]
        //[Export("getUserInfo:conditional:onStateChanged:")]
        //void GetUserInfo(SSDKPlatformType platformType, SSDKUserQueryConditional conditional, SSDKGetUserStateChangedHandler stateChangedHandler);

        //// +(void)share:(SSDKPlatformType)platformType parameters:(NSMutableDictionary *)parameters onStateChanged:(SSDKShareStateChangedHandler)stateChangedHandler;
        //[Static]
        //[Export("share:parameters:onStateChanged:")]
        //void Share(SSDKPlatformType platformType, NSMutableDictionary parameters, SSDKShareStateChangedHandler stateChangedHandler);
    }

    //typedef void (^SSUIShareStateChangedHandler) (SSDKResponseState state, SSDKPlatformType platformType, NSDictionary* userData, SSDKContentEntity * contentEntity, NSError * error,BOOL end);
    delegate void SSUIShareStateChangedHandler(SSDKResponseState state, SSDKPlatformType platformType, NSDictionary userData, SSDKContentEntity contentEntity, NSError error, bool end);

    [Category]
    [BaseType(typeof(ShareSDK))]
    interface ShareSDK_SSUI
    {
        // +(SSUIShareActionSheetController *)showShareActionSheet:(UIView *)view items:(NSArray *)items shareParams:(NSMutableDictionary *)shareParams onShareStateChanged:(SSUIShareStateChangedHandler)shareStateChangedHandler;
        [Static]
        [Export("showShareActionSheet:items:shareParams:onShareStateChanged:")]
        //[Verify(StronglyTypedNSArray)]
        SSUIShareActionSheetController ShowShareActionSheet(UIView view, NSObject[] items, NSMutableDictionary shareParams, SSUIShareStateChangedHandler shareStateChangedHandler);
    }

    //// typedef void (^SSUIShareActionSheetItemClickHandler)(NSInteger, SSUIShareActionSheetItem *);
    //delegate void SSUIShareActionSheetItemClickHandler(nint arg0, SSUIShareActionSheetItem arg1);

    // typedef void (^SSUIShareActionSheetCancelHandler)();
    delegate void SSUIShareActionSheetCancelHandler();

    // @interface SSUIShareActionSheetController : NSObject
    [BaseType(typeof(NSObject))]
    interface SSUIShareActionSheetController
    {
        // @property (nonatomic, strong) NSMutableSet * directSharePlatforms;
        [Export("directSharePlatforms", ArgumentSemantic.Strong)]
        NSMutableSet DirectSharePlatforms { get; set; }

        // -(instancetype)initWithItems:(NSArray *)items;
        [Export("initWithItems:")]
        //[Verify(StronglyTypedNSArray)]
        IntPtr Constructor(NSObject[] items);

        // -(void)showInView:(UIView *)view;
        [Export("showInView:")]
        void ShowInView(UIView view);

        // -(void)dismiss;
        [Export("dismiss")]
        void Dismiss();

        //// -(void)onItemClick:(SSUIShareActionSheetItemClickHandler)itemClickHandler;
        //[Export("onItemClick:")]
        //void OnItemClick(SSUIShareActionSheetItemClickHandler itemClickHandler);

        // -(void)onCancel:(SSUIShareActionSheetCancelHandler)cancelHandler;
        [Export("onCancel:")]
        void OnCancel(SSUIShareActionSheetCancelHandler cancelHandler);
    }
}
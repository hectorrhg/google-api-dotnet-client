// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.HangoutsChat.v1
{
    /// <summary>The HangoutsChat Service.</summary>
    public class HangoutsChatService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public HangoutsChatService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public HangoutsChatService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Media = new MediaResource(this);
            Spaces = new SpacesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://chat.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://chat.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "chat";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Chat API.</summary>
        public class Scope
        {
            /// <summary>Private Service: https://www.googleapis.com/auth/chat.bot</summary>
            public static string ChatBot = "https://www.googleapis.com/auth/chat.bot";

            /// <summary>
            /// Delete conversations and spaces &amp;amp; remove access to associated files in Google Chat
            /// </summary>
            public static string ChatDelete = "https://www.googleapis.com/auth/chat.delete";

            /// <summary>Import spaces, messages, and memberships into Google Chat.</summary>
            public static string ChatImport = "https://www.googleapis.com/auth/chat.import";

            /// <summary>View, add, and remove members from conversations in Google Chat</summary>
            public static string ChatMemberships = "https://www.googleapis.com/auth/chat.memberships";

            /// <summary>Add and remove itself from conversations in Google Chat</summary>
            public static string ChatMembershipsApp = "https://www.googleapis.com/auth/chat.memberships.app";

            /// <summary>View members in Google Chat conversations.</summary>
            public static string ChatMembershipsReadonly = "https://www.googleapis.com/auth/chat.memberships.readonly";

            /// <summary>
            /// View, compose, send, update, and delete messages, and add, view, and delete reactions to messages.
            /// </summary>
            public static string ChatMessages = "https://www.googleapis.com/auth/chat.messages";

            /// <summary>Compose and send messages in Google Chat</summary>
            public static string ChatMessagesCreate = "https://www.googleapis.com/auth/chat.messages.create";

            /// <summary>View, add, and delete reactions to messages in Google Chat</summary>
            public static string ChatMessagesReactions = "https://www.googleapis.com/auth/chat.messages.reactions";

            /// <summary>Add reactions to messages in Google Chat</summary>
            public static string ChatMessagesReactionsCreate = "https://www.googleapis.com/auth/chat.messages.reactions.create";

            /// <summary>View reactions to messages in Google Chat</summary>
            public static string ChatMessagesReactionsReadonly = "https://www.googleapis.com/auth/chat.messages.reactions.readonly";

            /// <summary>View messages and reactions in Google Chat</summary>
            public static string ChatMessagesReadonly = "https://www.googleapis.com/auth/chat.messages.readonly";

            /// <summary>
            /// Create conversations and spaces and see or edit metadata (including history settings and access
            /// settings) in Google Chat
            /// </summary>
            public static string ChatSpaces = "https://www.googleapis.com/auth/chat.spaces";

            /// <summary>Create new conversations in Google Chat</summary>
            public static string ChatSpacesCreate = "https://www.googleapis.com/auth/chat.spaces.create";

            /// <summary>View chat and spaces in Google Chat</summary>
            public static string ChatSpacesReadonly = "https://www.googleapis.com/auth/chat.spaces.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Chat API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Private Service: https://www.googleapis.com/auth/chat.bot</summary>
            public const string ChatBot = "https://www.googleapis.com/auth/chat.bot";

            /// <summary>
            /// Delete conversations and spaces &amp;amp; remove access to associated files in Google Chat
            /// </summary>
            public const string ChatDelete = "https://www.googleapis.com/auth/chat.delete";

            /// <summary>Import spaces, messages, and memberships into Google Chat.</summary>
            public const string ChatImport = "https://www.googleapis.com/auth/chat.import";

            /// <summary>View, add, and remove members from conversations in Google Chat</summary>
            public const string ChatMemberships = "https://www.googleapis.com/auth/chat.memberships";

            /// <summary>Add and remove itself from conversations in Google Chat</summary>
            public const string ChatMembershipsApp = "https://www.googleapis.com/auth/chat.memberships.app";

            /// <summary>View members in Google Chat conversations.</summary>
            public const string ChatMembershipsReadonly = "https://www.googleapis.com/auth/chat.memberships.readonly";

            /// <summary>
            /// View, compose, send, update, and delete messages, and add, view, and delete reactions to messages.
            /// </summary>
            public const string ChatMessages = "https://www.googleapis.com/auth/chat.messages";

            /// <summary>Compose and send messages in Google Chat</summary>
            public const string ChatMessagesCreate = "https://www.googleapis.com/auth/chat.messages.create";

            /// <summary>View, add, and delete reactions to messages in Google Chat</summary>
            public const string ChatMessagesReactions = "https://www.googleapis.com/auth/chat.messages.reactions";

            /// <summary>Add reactions to messages in Google Chat</summary>
            public const string ChatMessagesReactionsCreate = "https://www.googleapis.com/auth/chat.messages.reactions.create";

            /// <summary>View reactions to messages in Google Chat</summary>
            public const string ChatMessagesReactionsReadonly = "https://www.googleapis.com/auth/chat.messages.reactions.readonly";

            /// <summary>View messages and reactions in Google Chat</summary>
            public const string ChatMessagesReadonly = "https://www.googleapis.com/auth/chat.messages.readonly";

            /// <summary>
            /// Create conversations and spaces and see or edit metadata (including history settings and access
            /// settings) in Google Chat
            /// </summary>
            public const string ChatSpaces = "https://www.googleapis.com/auth/chat.spaces";

            /// <summary>Create new conversations in Google Chat</summary>
            public const string ChatSpacesCreate = "https://www.googleapis.com/auth/chat.spaces.create";

            /// <summary>View chat and spaces in Google Chat</summary>
            public const string ChatSpacesReadonly = "https://www.googleapis.com/auth/chat.spaces.readonly";
        }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }

        /// <summary>Gets the Spaces resource.</summary>
        public virtual SpacesResource Spaces { get; }
    }

    /// <summary>A base abstract class for HangoutsChat requests.</summary>
    public abstract class HangoutsChatBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new HangoutsChatBaseServiceRequest instance.</summary>
        protected HangoutsChatBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes HangoutsChat parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Downloads media. Download is supported on the URI `/v1/media/{+name}?alt=media`.</summary>
        /// <param name="resourceName">
        /// Name of the media that is being downloaded. See ReadRequest.resource_name.
        /// </param>
        public virtual DownloadRequest Download(string resourceName)
        {
            return new DownloadRequest(this.service, resourceName);
        }

        /// <summary>Downloads media. Download is supported on the URI `/v1/media/{+name}?alt=media`.</summary>
        public class DownloadRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Media>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string resourceName) : base(service)
            {
                ResourceName = resourceName;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>Name of the media that is being downloaded. See ReadRequest.resource_name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/media/{+resourceName}";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resourceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
        }

        /// <summary>
        /// Uploads an attachment. For an example, see [Upload media as a file
        /// attachment](https://developers.google.com/workspace/chat/upload-media-attachments). Requires user
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). You can
        /// upload attachments up to 200 MB. Certain file types aren't supported. For details, see [File types blocked
        /// by Google
        /// Chat](https://support.google.com/chat/answer/7651457?&amp;amp;co=GENIE.Platform%3DDesktop#File%20types%20blocked%20in%20Google%20Chat).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Resource name of the Chat space in which the attachment is uploaded. Format "spaces/{space}".
        /// </param>
        public virtual UploadRequest Upload(Google.Apis.HangoutsChat.v1.Data.UploadAttachmentRequest body, string parent)
        {
            return new UploadRequest(this.service, body, parent);
        }

        /// <summary>
        /// Uploads an attachment. For an example, see [Upload media as a file
        /// attachment](https://developers.google.com/workspace/chat/upload-media-attachments). Requires user
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). You can
        /// upload attachments up to 200 MB. Certain file types aren't supported. For details, see [File types blocked
        /// by Google
        /// Chat](https://support.google.com/chat/answer/7651457?&amp;amp;co=GENIE.Platform%3DDesktop#File%20types%20blocked%20in%20Google%20Chat).
        /// </summary>
        public class UploadRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.UploadAttachmentResponse>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.UploadAttachmentRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the Chat space in which the attachment is uploaded. Format "spaces/{space}".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.UploadAttachmentRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}/attachments:upload";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^spaces/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Uploads an attachment. For an example, see [Upload media as a file
        /// attachment](https://developers.google.com/workspace/chat/upload-media-attachments). Requires user
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). You can
        /// upload attachments up to 200 MB. Certain file types aren't supported. For details, see [File types blocked
        /// by Google
        /// Chat](https://support.google.com/chat/answer/7651457?&amp;amp;co=GENIE.Platform%3DDesktop#File%20types%20blocked%20in%20Google%20Chat).
        /// </summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
        /// </description>
        /// </item>
        /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
        /// </list>
        /// </remarks>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Resource name of the Chat space in which the attachment is uploaded. Format "spaces/{space}".
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.HangoutsChat.v1.Data.UploadAttachmentRequest body, string parent, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, parent, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.HangoutsChat.v1.Data.UploadAttachmentRequest, Google.Apis.HangoutsChat.v1.Data.UploadAttachmentResponse>
        {
            /// <summary>V1 error format.</summary>
            [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

            /// <summary>V1 error format.</summary>
            public enum XgafvEnum
            {
                /// <summary>v1 error format</summary>
                [Google.Apis.Util.StringValueAttribute("1")]
                Value1 = 0,

                /// <summary>v2 error format</summary>
                [Google.Apis.Util.StringValueAttribute("2")]
                Value2 = 1,
            }

            /// <summary>OAuth access token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AccessToken { get; set; }

            /// <summary>Data format for response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<AltEnum> Alt { get; set; }

            /// <summary>Data format for response.</summary>
            public enum AltEnum
            {
                /// <summary>Responses with Content-Type of application/json</summary>
                [Google.Apis.Util.StringValueAttribute("json")]
                Json = 0,

                /// <summary>Media download with context-dependent Content-Type</summary>
                [Google.Apis.Util.StringValueAttribute("media")]
                Media = 1,

                /// <summary>Responses with Content-Type of application/x-protobuf</summary>
                [Google.Apis.Util.StringValueAttribute("proto")]
                Proto = 2,
            }

            /// <summary>JSONP</summary>
            [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Callback { get; set; }

            /// <summary>Selector specifying which fields to include in a partial response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fields { get; set; }

            /// <summary>
            /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
            /// Required unless you provide an OAuth 2.0 token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Key { get; set; }

            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OauthToken { get; set; }

            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint { get; set; }

            /// <summary>
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>
            /// Required. Resource name of the Chat space in which the attachment is uploaded. Format "spaces/{space}".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Constructs a new Upload media upload instance.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.UploadAttachmentRequest body, string parent, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v1/{+parent}/attachments:upload"), "POST", stream, contentType)
            {
                Parent = parent;
                Body = body;
            }
        }
    }

    /// <summary>The "spaces" collection of methods.</summary>
    public class SpacesResource
    {
        private const string Resource = "spaces";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SpacesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Members = new MembersResource(service);
            Messages = new MessagesResource(service);
            SpaceEvents = new SpaceEventsResource(service);
        }

        /// <summary>Gets the Members resource.</summary>
        public virtual MembersResource Members { get; }

        /// <summary>The "members" collection of methods.</summary>
        public class MembersResource
        {
            private const string Resource = "members";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MembersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a human membership or app membership for the calling app. Creating memberships for other apps
            /// isn't supported. For an example, see [Invite or add a user or a Google Chat app to a
            /// space](https://developers.google.com/workspace/chat/create-members). When creating a membership, if the
            /// specified member has their auto-accept policy turned off, then they're invited, and must accept the
            /// space invitation before joining. Otherwise, creating a membership adds the member directly to the
            /// specified space. Requires [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). To
            /// specify the member to add, set the `membership.member.name` in the `CreateMembershipRequest`: - To add
            /// the calling app to a space or a direct message between two human users, use `users/app`. Unable to add
            /// other apps to the space. - To add a human user, use `users/{user}`, where `{user}` can be the email
            /// address for the user. For users in the same Workspace organization `{user}` can also be the `id` for the
            /// person from the People API, or the `id` for the user in the Directory API. For example, if the People
            /// API Person profile ID for `user@example.com` is `123456789`, you can add the user to the space by
            /// setting the `membership.member.name` to `users/user@example.com` or `users/123456789`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the space for which to create the membership. Format: spaces/{space}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.HangoutsChat.v1.Data.Membership body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a human membership or app membership for the calling app. Creating memberships for other apps
            /// isn't supported. For an example, see [Invite or add a user or a Google Chat app to a
            /// space](https://developers.google.com/workspace/chat/create-members). When creating a membership, if the
            /// specified member has their auto-accept policy turned off, then they're invited, and must accept the
            /// space invitation before joining. Otherwise, creating a membership adds the member directly to the
            /// specified space. Requires [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). To
            /// specify the member to add, set the `membership.member.name` in the `CreateMembershipRequest`: - To add
            /// the calling app to a space or a direct message between two human users, use `users/app`. Unable to add
            /// other apps to the space. - To add a human user, use `users/{user}`, where `{user}` can be the email
            /// address for the user. For users in the same Workspace organization `{user}` can also be the `id` for the
            /// person from the People API, or the `id` for the user in the Directory API. For example, if the People
            /// API Person profile ID for `user@example.com` is `123456789`, you can add the user to the space by
            /// setting the `membership.member.name` to `users/user@example.com` or `users/123456789`.
            /// </summary>
            public class CreateRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Membership>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Membership body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the space for which to create the membership. Format: spaces/{space}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Membership Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/members";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a membership. For an example, see [Remove a user or a Google Chat app from a
            /// space](https://developers.google.com/workspace/chat/delete-members). Requires [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the membership to delete. Chat apps can delete human users' or their own
            /// memberships. Chat apps can't delete other apps' memberships. When deleting a human membership, requires
            /// the `chat.memberships` scope and `spaces/{space}/members/{member}` format. You can use the email as an
            /// alias for `{member}`. For example, `spaces/{space}/members/example@gmail.com` where `example@gmail.com`
            /// is the email of the Google Chat user. When deleting an app membership, requires the
            /// `chat.memberships.app` scope and `spaces/{space}/members/app` format. Format:
            /// `spaces/{space}/members/{member}` or `spaces/{space}/members/app`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a membership. For an example, see [Remove a user or a Google Chat app from a
            /// space](https://developers.google.com/workspace/chat/delete-members). Requires [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
            /// </summary>
            public class DeleteRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Membership>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the membership to delete. Chat apps can delete human users' or their own
                /// memberships. Chat apps can't delete other apps' memberships. When deleting a human membership,
                /// requires the `chat.memberships` scope and `spaces/{space}/members/{member}` format. You can use the
                /// email as an alias for `{member}`. For example, `spaces/{space}/members/example@gmail.com` where
                /// `example@gmail.com` is the email of the Google Chat user. When deleting an app membership, requires
                /// the `chat.memberships.app` scope and `spaces/{space}/members/app` format. Format:
                /// `spaces/{space}/members/{member}` or `spaces/{space}/members/app`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/members/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns details about a membership. For an example, see [Get details about a user's or Google Chat app's
            /// membership](https://developers.google.com/workspace/chat/get-members). Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the membership to retrieve. To get the app's own membership, you can
            /// optionally use `spaces/{space}/members/app`. Format: `spaces/{space}/members/{member}` or
            /// `spaces/{space}/members/app` When [authenticated as a
            /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), you can use the
            /// user's email as an alias for `{member}`. For example, `spaces/{space}/members/example@gmail.com` where
            /// `example@gmail.com` is the email of the Google Chat user.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Returns details about a membership. For an example, see [Get details about a user's or Google Chat app's
            /// membership](https://developers.google.com/workspace/chat/get-members). Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
            /// </summary>
            public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Membership>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the membership to retrieve. To get the app's own membership, you can
                /// optionally use `spaces/{space}/members/app`. Format: `spaces/{space}/members/{member}` or
                /// `spaces/{space}/members/app` When [authenticated as a
                /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), you can use
                /// the user's email as an alias for `{member}`. For example, `spaces/{space}/members/example@gmail.com`
                /// where `example@gmail.com` is the email of the Google Chat user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/members/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists memberships in a space. For an example, see [List users and Google Chat apps in a
            /// space](https://developers.google.com/workspace/chat/list-members). Listing memberships with [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) lists
            /// memberships in spaces that the Chat app has access to, but excludes Chat app memberships, including its
            /// own. Listing memberships with [User
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user) lists
            /// memberships in spaces that the authenticated user has access to. Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](hhttps://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the space for which to fetch a membership list. Format: spaces/{space}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists memberships in a space. For an example, see [List users and Google Chat apps in a
            /// space](https://developers.google.com/workspace/chat/list-members). Listing memberships with [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) lists
            /// memberships in spaces that the Chat app has access to, but excludes Chat app memberships, including its
            /// own. Listing memberships with [User
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user) lists
            /// memberships in spaces that the authenticated user has access to. Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](hhttps://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
            /// </summary>
            public class ListRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.ListMembershipsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the space for which to fetch a membership list. Format:
                /// spaces/{space}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. A query filter. You can filter memberships by a member's role
                /// ([`role`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.members#membershiprole))
                /// and type
                /// ([`member.type`](https://developers.google.com/workspace/chat/api/reference/rest/v1/User#type)). To
                /// filter by role, set `role` to `ROLE_MEMBER` or `ROLE_MANAGER`. To filter by type, set `member.type`
                /// to `HUMAN` or `BOT`. To filter by both role and type, use the `AND` operator. To filter by either
                /// role or type, use the `OR` operator. For example, the following queries are valid:
                /// ```
                /// role =
                /// "ROLE_MANAGER" OR role = "ROLE_MEMBER" member.type = "HUMAN" AND role = "ROLE_MANAGER"
                /// ```
                /// The
                /// following queries are invalid:
                /// ```
                /// member.type = "HUMAN" AND member.type = "BOT" role =
                /// "ROLE_MANAGER" AND role = "ROLE_MEMBER"
                /// ```
                /// Invalid queries are rejected by the server with an
                /// `INVALID_ARGUMENT` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The maximum number of memberships to return. The service might return fewer than this
                /// value. If unspecified, at most 100 memberships are returned. The maximum value is 1000. If you use a
                /// value more than 1000, it's automatically changed to 1000. Negative values return an
                /// `INVALID_ARGUMENT` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous call to list memberships. Provide this parameter to
                /// retrieve the subsequent page. When paginating, all other parameters provided should match the call
                /// that provided the page token. Passing different values to the other parameters might lead to
                /// unexpected results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. When `true`, also returns memberships associated with a Google Group, in addition to other
                /// types of memberships. If a filter is set, Google Group memberships that don't match the filter
                /// criteria aren't returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showGroups", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowGroups { get; set; }

                /// <summary>
                /// Optional. When `true`, also returns memberships associated with invited members, in addition to
                /// other types of memberships. If a filter is set, invited memberships that don't match the filter
                /// criteria aren't returned. Currently requires [user
                /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showInvited", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowInvited { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/members";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("showGroups", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showGroups",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("showInvited", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showInvited",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Messages resource.</summary>
        public virtual MessagesResource Messages { get; }

        /// <summary>The "messages" collection of methods.</summary>
        public class MessagesResource
        {
            private const string Resource = "messages";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MessagesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Attachments = new AttachmentsResource(service);
                Reactions = new ReactionsResource(service);
            }

            /// <summary>Gets the Attachments resource.</summary>
            public virtual AttachmentsResource Attachments { get; }

            /// <summary>The "attachments" collection of methods.</summary>
            public class AttachmentsResource
            {
                private const string Resource = "attachments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AttachmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets the metadata of a message attachment. The attachment data is fetched using the [media
                /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download). For an
                /// example, see [Get metadata about a message
                /// attachment](https://developers.google.com/workspace/chat/get-media-attachments). Requires [app
                /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app).
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the attachment, in the form `spaces/*/messages/*/attachments/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the metadata of a message attachment. The attachment data is fetched using the [media
                /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download). For an
                /// example, see [Get metadata about a message
                /// attachment](https://developers.google.com/workspace/chat/get-media-attachments). Requires [app
                /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app).
                /// </summary>
                public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Attachment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the attachment, in the form `spaces/*/messages/*/attachments/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^spaces/[^/]+/messages/[^/]+/attachments/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Reactions resource.</summary>
            public virtual ReactionsResource Reactions { get; }

            /// <summary>The "reactions" collection of methods.</summary>
            public class ReactionsResource
            {
                private const string Resource = "reactions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReactionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a reaction and adds it to a message. Only unicode emojis are supported.For an example, see
                /// [Add a reaction to a reaction](https://developers.google.com/workspace/chat/create-reactions).
                /// Requires [user
                /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The message where the reaction is created. Format: `spaces/{space}/messages/{message}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.HangoutsChat.v1.Data.Reaction body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a reaction and adds it to a message. Only unicode emojis are supported.For an example, see
                /// [Add a reaction to a reaction](https://developers.google.com/workspace/chat/create-reactions).
                /// Requires [user
                /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
                /// </summary>
                public class CreateRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Reaction>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Reaction body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The message where the reaction is created. Format: `spaces/{space}/messages/{message}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.HangoutsChat.v1.Data.Reaction Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/reactions";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a reaction to a message. Only unicode emojis are supported. For an example, see [Delete a
                /// reaction](https://developers.google.com/workspace/chat/delete-reactions). Requires [user
                /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
                /// </summary>
                /// <param name="name">
                /// Required. Name of the reaction to delete. Format:
                /// `spaces/{space}/messages/{message}/reactions/{reaction}`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a reaction to a message. Only unicode emojis are supported. For an example, see [Delete a
                /// reaction](https://developers.google.com/workspace/chat/delete-reactions). Requires [user
                /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
                /// </summary>
                public class DeleteRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the reaction to delete. Format:
                    /// `spaces/{space}/messages/{message}/reactions/{reaction}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^spaces/[^/]+/messages/[^/]+/reactions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists reactions to a message. For an example, see [List reactions for a
                /// message](https://developers.google.com/workspace/chat/list-reactions). Requires [user
                /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
                /// </summary>
                /// <param name="parent">
                /// Required. The message users reacted to. Format: `spaces/{space}/messages/{message}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists reactions to a message. For an example, see [List reactions for a
                /// message](https://developers.google.com/workspace/chat/list-reactions). Requires [user
                /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
                /// </summary>
                public class ListRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.ListReactionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The message users reacted to. Format: `spaces/{space}/messages/{message}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A query filter. You can filter reactions by
                    /// [emoji](https://developers.google.com/workspace/chat/api/reference/rest/v1/Emoji) (either
                    /// `emoji.unicode` or `emoji.custom_emoji.uid`) and
                    /// [user](https://developers.google.com/workspace/chat/api/reference/rest/v1/User) (`user.name`).
                    /// To filter reactions for multiple emojis or users, join similar fields with the `OR` operator,
                    /// such as `emoji.unicode = "🙂" OR emoji.unicode = "👍"` and `user.name = "users/AAAAAA" OR
                    /// user.name = "users/BBBBBB"`. To filter reactions by emoji and user, use the `AND` operator, such
                    /// as `emoji.unicode = "🙂" AND user.name = "users/AAAAAA"`. If your query uses both `AND` and
                    /// `OR`, group them with parentheses. For example, the following queries are valid:
                    /// ```
                    /// user.name =
                    /// "users/{user}" emoji.unicode = "🙂" emoji.custom_emoji.uid = "{uid}" emoji.unicode = "🙂" OR
                    /// emoji.unicode = "👍" emoji.unicode = "🙂" OR emoji.custom_emoji.uid = "{uid}" emoji.unicode =
                    /// "🙂" AND user.name = "users/{user}" (emoji.unicode = "🙂" OR emoji.custom_emoji.uid = "{uid}")
                    /// AND user.name = "users/{user}"
                    /// ```
                    /// The following queries are invalid:
                    /// ```
                    /// emoji.unicode = "🙂"
                    /// AND emoji.unicode = "👍" emoji.unicode = "🙂" AND emoji.custom_emoji.uid = "{uid}" emoji.unicode
                    /// = "🙂" OR user.name = "users/{user}" emoji.unicode = "🙂" OR emoji.custom_emoji.uid = "{uid}" OR
                    /// user.name = "users/{user}" emoji.unicode = "🙂" OR emoji.custom_emoji.uid = "{uid}" AND
                    /// user.name = "users/{user}"
                    /// ```
                    /// Invalid queries are rejected by the server with an
                    /// `INVALID_ARGUMENT` error.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of reactions returned. The service can return fewer reactions than
                    /// this value. If unspecified, the default value is 25. The maximum value is 200; values above 200
                    /// are changed to 200.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. (If resuming from a previous query.) A page token received from a previous list
                    /// reactions call. Provide this to retrieve the subsequent page. When paginating, the filter value
                    /// should match the call that provided the page token. Passing a different value might lead to
                    /// unexpected results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/reactions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>
            /// Creates a message in a Google Chat space. For an example, see [Send a
            /// message](https://developers.google.com/workspace/chat/create-messages). Calling this method requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize) and supports the
            /// following authentication types: - For text messages, user authentication or app authentication are
            /// supported. - For card messages, only app authentication is supported. (Only Chat apps can create card
            /// messages.)
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The resource name of the space in which to create a message. Format: `spaces/{space}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.HangoutsChat.v1.Data.Message body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a message in a Google Chat space. For an example, see [Send a
            /// message](https://developers.google.com/workspace/chat/create-messages). Calling this method requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize) and supports the
            /// following authentication types: - For text messages, user authentication or app authentication are
            /// supported. - For card messages, only app authentication is supported. (Only Chat apps can create card
            /// messages.)
            /// </summary>
            public class CreateRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the space in which to create a message. Format: `spaces/{space}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. A custom ID for a message. Lets Chat apps get, update, or delete a message without needing
                /// to store the system-assigned ID in the message's resource name (represented in the message `name`
                /// field). The value for this field must meet the following requirements: * Begins with `client-`. For
                /// example, `client-custom-name` is a valid custom ID, but `custom-name` is not. * Contains up to 63
                /// characters and only lowercase letters, numbers, and hyphens. * Is unique within a space. A Chat app
                /// can't use the same custom ID for different messages. For details, see [Name a
                /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("messageId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MessageId { get; set; }

                /// <summary>
                /// Optional. Specifies whether a message starts a thread or replies to one. Only supported in named
                /// spaces.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("messageReplyOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<MessageReplyOptionEnum> MessageReplyOption { get; set; }

                /// <summary>
                /// Optional. Specifies whether a message starts a thread or replies to one. Only supported in named
                /// spaces.
                /// </summary>
                public enum MessageReplyOptionEnum
                {
                    /// <summary>
                    /// Default. Starts a new thread. Using this option ignores any thread ID or `thread_key` that's
                    /// included.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("MESSAGE_REPLY_OPTION_UNSPECIFIED")]
                    MESSAGEREPLYOPTIONUNSPECIFIED = 0,

                    /// <summary>
                    /// Creates the message as a reply to the thread specified by thread ID or `thread_key`. If it
                    /// fails, the message starts a new thread instead.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REPLY_MESSAGE_FALLBACK_TO_NEW_THREAD")]
                    REPLYMESSAGEFALLBACKTONEWTHREAD = 1,

                    /// <summary>
                    /// Creates the message as a reply to the thread specified by thread ID or `thread_key`. If a new
                    /// `thread_key` is used, a new thread is created. If the message creation fails, a `NOT_FOUND`
                    /// error is returned instead.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REPLY_MESSAGE_OR_FAIL")]
                    REPLYMESSAGEORFAIL = 2,
                }

                /// <summary>
                /// Optional. A unique request ID for this message. Specifying an existing request ID returns the
                /// message created with that ID instead of creating a new message.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RequestId { get; set; }

                /// <summary>
                /// Optional. Deprecated: Use thread.thread_key instead. ID for the thread. Supports up to 4000
                /// characters. To start or add to a thread, create a message and specify a `threadKey` or the
                /// thread.name. For example usage, see [Start or reply to a message
                /// thread](https://developers.google.com/workspace/chat/create-messages#create-message-thread).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("threadKey", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ThreadKey { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/messages";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+$",
                    });
                    RequestParameters.Add("messageId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "messageId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("messageReplyOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "messageReplyOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "requestId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("threadKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "threadKey",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a message. For an example, see [Delete a
            /// message](https://developers.google.com/workspace/chat/delete-messages). Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). When
            /// using app authentication, requests can only delete messages created by the calling Chat app.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the message. Format: `spaces/{space}/messages/{message}` If you've set a
            /// custom ID for your message, you can use the value from the `clientAssignedMessageId` field for
            /// `{message}`. For details, see [Name a message]
            /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a message. For an example, see [Delete a
            /// message](https://developers.google.com/workspace/chat/delete-messages). Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). When
            /// using app authentication, requests can only delete messages created by the calling Chat app.
            /// </summary>
            public class DeleteRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the message. Format: `spaces/{space}/messages/{message}` If you've set a
                /// custom ID for your message, you can use the value from the `clientAssignedMessageId` field for
                /// `{message}`. For details, see [Name a message]
                /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// When `true`, deleting a message also deletes its threaded replies. When `false`, if a message has
                /// threaded replies, deletion fails. Only applies when [authenticating as a
                /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). Has no effect
                /// when [authenticating as a Chat app]
                /// (https://developers.google.com/workspace/chat/authenticate-authorize-chat-app).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Force { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                    });
                    RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                    {
                        Name = "force",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns details about a message. For an example, see [Get details about a
            /// message](https://developers.google.com/workspace/chat/get-messages). Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). Note:
            /// Might return a message from a blocked member or space.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the message. Format: `spaces/{space}/messages/{message}` If you've set a
            /// custom ID for your message, you can use the value from the `clientAssignedMessageId` field for
            /// `{message}`. For details, see [Name a message]
            /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Returns details about a message. For an example, see [Get details about a
            /// message](https://developers.google.com/workspace/chat/get-messages). Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). Note:
            /// Might return a message from a blocked member or space.
            /// </summary>
            public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the message. Format: `spaces/{space}/messages/{message}` If you've set a
                /// custom ID for your message, you can use the value from the `clientAssignedMessageId` field for
                /// `{message}`. For details, see [Name a message]
                /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists messages in a space that the caller is a member of, including messages from blocked members and
            /// spaces. For an example, see [List messages](/chat/api/guides/v1/messages/list). Requires [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
            /// </summary>
            /// <param name="parent">
            /// Required. The resource name of the space to list messages from. Format: `spaces/{space}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists messages in a space that the caller is a member of, including messages from blocked members and
            /// spaces. For an example, see [List messages](/chat/api/guides/v1/messages/list). Requires [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
            /// </summary>
            public class ListRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.ListMessagesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the space to list messages from. Format: `spaces/{space}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// A query filter. You can filter messages by date (`create_time`) and thread (`thread.name`). To
                /// filter messages by the date they were created, specify the `create_time` with a timestamp in
                /// [RFC-3339](https://www.rfc-editor.org/rfc/rfc3339) format and double quotation marks. For example,
                /// `"2023-04-21T11:30:00-04:00"`. You can use the greater than operator `&amp;gt;` to list messages
                /// that were created after a timestamp, or the less than operator `&amp;lt;` to list messages that were
                /// created before a timestamp. To filter messages within a time interval, use the `AND` operator
                /// between two timestamps. To filter by thread, specify the `thread.name`, formatted as
                /// `spaces/{space}/threads/{thread}`. You can only specify one `thread.name` per query. To filter by
                /// both thread and date, use the `AND` operator in your query. For example, the following queries are
                /// valid:
                /// ```
                /// create_time &amp;gt; "2012-04-21T11:30:00-04:00" create_time &amp;gt;
                /// "2012-04-21T11:30:00-04:00" AND thread.name = spaces/AAAAAAAAAAA/threads/123 create_time &amp;gt;
                /// "2012-04-21T11:30:00+00:00" AND create_time &amp;lt; "2013-01-01T00:00:00+00:00" AND thread.name =
                /// spaces/AAAAAAAAAAA/threads/123 thread.name = spaces/AAAAAAAAAAA/threads/123
                /// ```
                /// Invalid queries are
                /// rejected by the server with an `INVALID_ARGUMENT` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional, if resuming from a previous query. How the list of messages is ordered. Specify a value to
                /// order by an ordering operation. Valid ordering operation values are as follows: - `ASC` for
                /// ascending. - `DESC` for descending. The default ordering is `create_time ASC`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// The maximum number of messages returned. The service might return fewer messages than this value. If
                /// unspecified, at most 25 are returned. The maximum value is 1000. If you use a value more than 1000,
                /// it's automatically changed to 1000. Negative values return an `INVALID_ARGUMENT` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional, if resuming from a previous query. A page token received from a previous list messages
                /// call. Provide this parameter to retrieve the subsequent page. When paginating, all other parameters
                /// provided should match the call that provided the page token. Passing different values to the other
                /// parameters might lead to unexpected results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Whether to include deleted messages. Deleted messages include deleted time and metadata about their
                /// deletion, but message content is unavailable.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeleted { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/messages";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showDeleted",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates a message. There's a difference between the `patch` and `update` methods. The `patch` method
            /// uses a `patch` request while the `update` method uses a `put` request. We recommend using the `patch`
            /// method. For an example, see [Update a
            /// message](https://developers.google.com/workspace/chat/update-messages). Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). When
            /// using app authentication, requests can only update messages created by the calling Chat app.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Resource name of the message. Format: `spaces/{space}/messages/{message}` Where `{space}` is the ID of
            /// the space where the message is posted and `{message}` is a system-assigned ID for the message. For
            /// example, `spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB`. If you set a custom ID when you create a
            /// message, you can use this ID to specify the message in a request by replacing `{message}` with the value
            /// from the `clientAssignedMessageId` field. For example, `spaces/AAAAAAAAAAA/messages/client-custom-name`.
            /// For details, see [Name a
            /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.HangoutsChat.v1.Data.Message body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a message. There's a difference between the `patch` and `update` methods. The `patch` method
            /// uses a `patch` request while the `update` method uses a `put` request. We recommend using the `patch`
            /// method. For an example, see [Update a
            /// message](https://developers.google.com/workspace/chat/update-messages). Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). When
            /// using app authentication, requests can only update messages created by the calling Chat app.
            /// </summary>
            public class PatchRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Resource name of the message. Format: `spaces/{space}/messages/{message}` Where `{space}` is the ID
                /// of the space where the message is posted and `{message}` is a system-assigned ID for the message.
                /// For example, `spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB`. If you set a custom ID when you
                /// create a message, you can use this ID to specify the message in a request by replacing `{message}`
                /// with the value from the `clientAssignedMessageId` field. For example,
                /// `spaces/AAAAAAAAAAA/messages/client-custom-name`. For details, see [Name a
                /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. If `true` and the message isn't found, a new message is created and `updateMask` is
                /// ignored. The specified message ID must be
                /// [client-assigned](https://developers.google.com/workspace/chat/create-messages#name_a_created_message)
                /// or the request fails.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> AllowMissing { get; set; }

                /// <summary>
                /// Required. The field paths to update. Separate multiple values with commas or use `*` to update all
                /// field paths. Currently supported field paths: - `text` - `attachment` - `cards` (Requires [app
                /// authentication](/chat/api/guides/auth/service-accounts).) - `cards_v2` (Requires [app
                /// authentication](/chat/api/guides/auth/service-accounts).) - `accessory_widgets` (Requires [app
                /// authentication](/chat/api/guides/auth/service-accounts).)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                    });
                    RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                    {
                        Name = "allowMissing",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates a message. There's a difference between the `patch` and `update` methods. The `patch` method
            /// uses a `patch` request while the `update` method uses a `put` request. We recommend using the `patch`
            /// method. For an example, see [Update a
            /// message](https://developers.google.com/workspace/chat/update-messages). Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). When
            /// using app authentication, requests can only update messages created by the calling Chat app.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Resource name of the message. Format: `spaces/{space}/messages/{message}` Where `{space}` is the ID of
            /// the space where the message is posted and `{message}` is a system-assigned ID for the message. For
            /// example, `spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB`. If you set a custom ID when you create a
            /// message, you can use this ID to specify the message in a request by replacing `{message}` with the value
            /// from the `clientAssignedMessageId` field. For example, `spaces/AAAAAAAAAAA/messages/client-custom-name`.
            /// For details, see [Name a
            /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.HangoutsChat.v1.Data.Message body, string name)
            {
                return new UpdateRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a message. There's a difference between the `patch` and `update` methods. The `patch` method
            /// uses a `patch` request while the `update` method uses a `put` request. We recommend using the `patch`
            /// method. For an example, see [Update a
            /// message](https://developers.google.com/workspace/chat/update-messages). Requires
            /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). When
            /// using app authentication, requests can only update messages created by the calling Chat app.
            /// </summary>
            public class UpdateRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Message>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Message body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Resource name of the message. Format: `spaces/{space}/messages/{message}` Where `{space}` is the ID
                /// of the space where the message is posted and `{message}` is a system-assigned ID for the message.
                /// For example, `spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB`. If you set a custom ID when you
                /// create a message, you can use this ID to specify the message in a request by replacing `{message}`
                /// with the value from the `clientAssignedMessageId` field. For example,
                /// `spaces/AAAAAAAAAAA/messages/client-custom-name`. For details, see [Name a
                /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. If `true` and the message isn't found, a new message is created and `updateMask` is
                /// ignored. The specified message ID must be
                /// [client-assigned](https://developers.google.com/workspace/chat/create-messages#name_a_created_message)
                /// or the request fails.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> AllowMissing { get; set; }

                /// <summary>
                /// Required. The field paths to update. Separate multiple values with commas or use `*` to update all
                /// field paths. Currently supported field paths: - `text` - `attachment` - `cards` (Requires [app
                /// authentication](/chat/api/guides/auth/service-accounts).) - `cards_v2` (Requires [app
                /// authentication](/chat/api/guides/auth/service-accounts).) - `accessory_widgets` (Requires [app
                /// authentication](/chat/api/guides/auth/service-accounts).)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.HangoutsChat.v1.Data.Message Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/messages/[^/]+$",
                    });
                    RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                    {
                        Name = "allowMissing",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the SpaceEvents resource.</summary>
        public virtual SpaceEventsResource SpaceEvents { get; }

        /// <summary>The "spaceEvents" collection of methods.</summary>
        public class SpaceEventsResource
        {
            private const string Resource = "spaceEvents";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SpaceEventsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns an event from a Google Chat space. The [event
            /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
            /// contains the most recent version of the resource that changed. For example, if you request an event
            /// about a new message but the message was later updated, the server returns the updated `Message` resource
            /// in the event payload. Requires [user
            /// authentication](hhttps://developers.google.com/workspace/chat/authenticate-authorize-chat-user). To get
            /// an event, the authenticated user must be a member of the space. For an example, see [Get details about
            /// an event from a Google Chat space](https://developers.google.com/workspace/chat/get-space-event).
            /// </summary>
            /// <param name="name">
            /// Required. The resource name of the space event. Format: `spaces/{space}/spaceEvents/{spaceEvent}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Returns an event from a Google Chat space. The [event
            /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
            /// contains the most recent version of the resource that changed. For example, if you request an event
            /// about a new message but the message was later updated, the server returns the updated `Message` resource
            /// in the event payload. Requires [user
            /// authentication](hhttps://developers.google.com/workspace/chat/authenticate-authorize-chat-user). To get
            /// an event, the authenticated user must be a member of the space. For an example, see [Get details about
            /// an event from a Google Chat space](https://developers.google.com/workspace/chat/get-space-event).
            /// </summary>
            public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.SpaceEvent>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the space event. Format: `spaces/{space}/spaceEvents/{spaceEvent}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+/spaceEvents/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists events from a Google Chat space. For each event, the
            /// [payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
            /// contains the most recent version of the Chat resource. For example, if you list events about new space
            /// members, the server returns `Membership` resources that contain the latest membership details. If new
            /// members were removed during the requested period, the event payload contains an empty `Membership`
            /// resource. Requires [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). To list
            /// events, the authenticated user must be a member of the space. For an example, see [List events from a
            /// Google Chat space](https://developers.google.com/workspace/chat/list-space-events).
            /// </summary>
            /// <param name="parent">
            /// Required. Resource name of the [Google Chat
            /// space](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces) where the events
            /// occurred. Format: `spaces/{space}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists events from a Google Chat space. For each event, the
            /// [payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
            /// contains the most recent version of the Chat resource. For example, if you list events about new space
            /// members, the server returns `Membership` resources that contain the latest membership details. If new
            /// members were removed during the requested period, the event payload contains an empty `Membership`
            /// resource. Requires [user
            /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). To list
            /// events, the authenticated user must be a member of the space. For an example, see [List events from a
            /// Google Chat space](https://developers.google.com/workspace/chat/list-space-events).
            /// </summary>
            public class ListRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.ListSpaceEventsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the [Google Chat
                /// space](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces) where the events
                /// occurred. Format: `spaces/{space}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. A query filter. You must specify at least one event type (`event_type`) using the has `:`
                /// operator. To filter by multiple event types, use the `OR` operator. Omit batch event types in your
                /// filter. The request automatically returns any related batch events. For example, if you filter by
                /// new reactions (`google.workspace.chat.reaction.v1.created`), the server also returns batch new
                /// reactions events (`google.workspace.chat.reaction.v1.batchCreated`). For a list of supported event
                /// types, see the [`SpaceEvents` reference
                /// documentation](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.event_type).
                /// Optionally, you can also filter by start time (`start_time`) and end time (`end_time`): *
                /// `start_time`: Exclusive timestamp from which to start listing space events. You can list events that
                /// occurred up to 28 days ago. If unspecified, lists space events from the past 28 days. * `end_time`:
                /// Inclusive timestamp until which space events are listed. If unspecified, lists events up to the time
                /// of the request. To specify a start or end time, use the equals `=` operator and format in
                /// [RFC-3339](https://www.rfc-editor.org/rfc/rfc3339). To filter by both `start_time` and `end_time`,
                /// use the `AND` operator. For example, the following queries are valid:
                /// ```
                /// start_time="2023-08-23T19:20:33+00:00" AND end_time="2023-08-23T19:21:54+00:00"
                /// ```
                /// ```
                /// start_time="2023-08-23T19:20:33+00:00" AND (event_types:"google.workspace.chat.space.v1.updated" OR
                /// event_types:"google.workspace.chat.message.v1.created")
                /// ```
                /// The following queries are invalid:
                /// ```
                /// start_time="2023-08-23T19:20:33+00:00" OR end_time="2023-08-23T19:21:54+00:00"
                /// ```
                /// ```
                /// event_types:"google.workspace.chat.space.v1.updated" AND
                /// event_types:"google.workspace.chat.message.v1.created"
                /// ```
                /// Invalid queries are rejected by the
                /// server with an `INVALID_ARGUMENT` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The maximum number of space events returned. The service might return fewer than this
                /// value. Negative values return an `INVALID_ARGUMENT` error.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous list space events call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to list space events must match the
                /// call that provided the page token. Passing different values to the other parameters might lead to
                /// unexpected results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/spaceEvents";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^spaces/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Completes the [import process](https://developers.google.com/workspace/chat/import-data) for the specified
        /// space and makes it visible to users. Requires app authentication and domain-wide delegation. For more
        /// information, see [Authorize Google Chat apps to import
        /// data](https://developers.google.com/workspace/chat/authorize-import).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. Resource name of the import mode space. Format: `spaces/{space}`</param>
        public virtual CompleteImportRequest CompleteImport(Google.Apis.HangoutsChat.v1.Data.CompleteImportSpaceRequest body, string name)
        {
            return new CompleteImportRequest(this.service, body, name);
        }

        /// <summary>
        /// Completes the [import process](https://developers.google.com/workspace/chat/import-data) for the specified
        /// space and makes it visible to users. Requires app authentication and domain-wide delegation. For more
        /// information, see [Authorize Google Chat apps to import
        /// data](https://developers.google.com/workspace/chat/authorize-import).
        /// </summary>
        public class CompleteImportRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.CompleteImportSpaceResponse>
        {
            /// <summary>Constructs a new CompleteImport request.</summary>
            public CompleteImportRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.CompleteImportSpaceRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Resource name of the import mode space. Format: `spaces/{space}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.CompleteImportSpaceRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "completeImport";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:completeImport";

            /// <summary>Initializes CompleteImport parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^spaces/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Creates a named space. Spaces grouped by topics aren't supported. For an example, see [Create a
        /// space](https://developers.google.com/workspace/chat/create-spaces). If you receive the error message
        /// `ALREADY_EXISTS` when creating a space, try a different `displayName`. An existing space within the Google
        /// Workspace organization might already use this display name. Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.HangoutsChat.v1.Data.Space body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Creates a named space. Spaces grouped by topics aren't supported. For an example, see [Create a
        /// space](https://developers.google.com/workspace/chat/create-spaces). If you receive the error message
        /// `ALREADY_EXISTS` when creating a space, try a different `displayName`. An existing space within the Google
        /// Workspace organization might already use this display name. Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// </summary>
        public class CreateRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Space>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Space body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Optional. A unique identifier for this request. A random UUID is recommended. Specifying an existing
            /// request ID returns the space created with that ID instead of creating a new space. Specifying an
            /// existing request ID from the same Chat app with a different authenticated user returns an error.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Space Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/spaces";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means that the space's child resources—like
        /// messages posted in the space and memberships in the space—are also deleted. For an example, see [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces). Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user) from a user
        /// who has permission to delete the space.
        /// </summary>
        /// <param name="name">Required. Resource name of the space to delete. Format: `spaces/{space}`</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means that the space's child resources—like
        /// messages posted in the space and memberships in the space—are also deleted. For an example, see [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces). Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user) from a user
        /// who has permission to delete the space.
        /// </summary>
        public class DeleteRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Resource name of the space to delete. Format: `spaces/{space}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^spaces/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns the existing direct message with the specified user. If no direct message space is found, returns a
        /// `404 NOT_FOUND` error. For an example, see [Find a direct
        /// message](/chat/api/guides/v1/spaces/find-direct-message). With [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), returns the
        /// direct message space between the specified user and the authenticated user. With [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app), returns the
        /// direct message space between the specified user and the calling Chat app. Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user) or [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app).
        /// </summary>
        public virtual FindDirectMessageRequest FindDirectMessage()
        {
            return new FindDirectMessageRequest(this.service);
        }

        /// <summary>
        /// Returns the existing direct message with the specified user. If no direct message space is found, returns a
        /// `404 NOT_FOUND` error. For an example, see [Find a direct
        /// message](/chat/api/guides/v1/spaces/find-direct-message). With [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), returns the
        /// direct message space between the specified user and the authenticated user. With [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app), returns the
        /// direct message space between the specified user and the calling Chat app. Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user) or [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app).
        /// </summary>
        public class FindDirectMessageRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Space>
        {
            /// <summary>Constructs a new FindDirectMessage request.</summary>
            public FindDirectMessageRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the user to find direct message with. Format: `users/{user}`, where `{user}`
            /// is either the `id` for the [person](https://developers.google.com/people/api/rest/v1/people) from the
            /// People API, or the `id` for the
            /// [user](https://developers.google.com/admin-sdk/directory/reference/rest/v1/users) in the Directory API.
            /// For example, if the People API profile ID is `123456789`, you can find a direct message with that person
            /// by using `users/123456789` as the `name`. When [authenticated as a
            /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), you can use the
            /// email as an alias for `{user}`. For example, `users/example@gmail.com` where `example@gmail.com` is the
            /// email of the Google Chat user.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Name { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "findDirectMessage";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/spaces:findDirectMessage";

            /// <summary>Initializes FindDirectMessage parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns details about a space. For an example, see [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces). Requires
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space, in the form "spaces/*". Format: `spaces/{space}`
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Returns details about a space. For an example, see [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces). Requires
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// </summary>
        public class GetRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Space>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the space, in the form "spaces/*". Format: `spaces/{space}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^spaces/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists spaces the caller is a member of. Group chats and DMs aren't listed until the first message is sent.
        /// For an example, see [List spaces](https://developers.google.com/workspace/chat/list-spaces). Requires
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). Lists spaces
        /// visible to the caller or authenticated user. Group chats and DMs aren't listed until the first message is
        /// sent.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists spaces the caller is a member of. Group chats and DMs aren't listed until the first message is sent.
        /// For an example, see [List spaces](https://developers.google.com/workspace/chat/list-spaces). Requires
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize). Supports [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app) and [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user). Lists spaces
        /// visible to the caller or authenticated user. Group chats and DMs aren't listed until the first message is
        /// sent.
        /// </summary>
        public class ListRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.ListSpacesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. A query filter. You can filter spaces by the space type
            /// ([`space_type`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces#spacetype)).
            /// To filter by space type, you must specify valid enum value, such as `SPACE` or `GROUP_CHAT` (the
            /// `space_type` can't be `SPACE_TYPE_UNSPECIFIED`). To query for multiple space types, use the `OR`
            /// operator. For example, the following queries are valid:
            /// ```
            /// space_type = "SPACE" spaceType =
            /// "GROUP_CHAT" OR spaceType = "DIRECT_MESSAGE"
            /// ```
            /// Invalid queries are rejected by the server with an
            /// `INVALID_ARGUMENT` error.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. The maximum number of spaces to return. The service might return fewer than this value. If
            /// unspecified, at most 100 spaces are returned. The maximum value is 1000. If you use a value more than
            /// 1000, it's automatically changed to 1000. Negative values return an `INVALID_ARGUMENT` error.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous list spaces call. Provide this parameter to retrieve
            /// the subsequent page. When paginating, the filter value should match the call that provided the page
            /// token. Passing a different value may lead to unexpected results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/spaces";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a space. For an example, see [Update a
        /// space](https://developers.google.com/workspace/chat/update-spaces). If you're updating the `displayName`
        /// field and receive the error message `ALREADY_EXISTS`, try a different display name.. An existing space
        /// within the Google Workspace organization might already use this display name. Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Resource name of the space. Format: `spaces/{space}`</param>
        public virtual PatchRequest Patch(Google.Apis.HangoutsChat.v1.Data.Space body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>
        /// Updates a space. For an example, see [Update a
        /// space](https://developers.google.com/workspace/chat/update-spaces). If you're updating the `displayName`
        /// field and receive the error message `ALREADY_EXISTS`, try a different display name.. An existing space
        /// within the Google Workspace organization might already use this display name. Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// </summary>
        public class PatchRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Space>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.Space body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Resource name of the space. Format: `spaces/{space}`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Required. The updated field paths, comma separated if there are multiple. Currently supported field
            /// paths: - `display_name` (Only supports changing the display name of a space with the `SPACE` type, or
            /// when also including the `space_type` mask to change a `GROUP_CHAT` space type to `SPACE`. Trying to
            /// update the display name of a `GROUP_CHAT` or a `DIRECT_MESSAGE` space results in an invalid argument
            /// error. If you receive the error message `ALREADY_EXISTS` when updating the `displayName`, try a
            /// different `displayName`. An existing space within the Google Workspace organization might already use
            /// this display name.) - `space_type` (Only supports changing a `GROUP_CHAT` space type to `SPACE`. Include
            /// `display_name` together with `space_type` in the update mask and ensure that the specified space has a
            /// non-empty display name and the `SPACE` space type. Including the `space_type` mask and the `SPACE` type
            /// in the specified space when updating the display name is optional if the existing space already has the
            /// `SPACE` type. Trying to update the space type in other ways results in an invalid argument error). -
            /// `space_details` - `space_history_state` (Supports [turning history on or off for the
            /// space](https://support.google.com/chat/answer/7664687) if [the organization allows users to change their
            /// history setting](https://support.google.com/a/answer/7664184). Warning: mutually exclusive with all
            /// other field paths.) - Developer Preview: `access_settings.audience` (Supports changing the [access
            /// setting](https://support.google.com/chat/answer/11971020) of a space. If no audience is specified in the
            /// access setting, the space's access setting is updated to restricted. Warning: mutually exclusive with
            /// all other field paths.)
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.Space Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^spaces/[^/]+$",
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates a space and adds specified users to it. The calling user is automatically added to the space, and
        /// shouldn't be specified as a membership in the request. For an example, see [Set up a space with initial
        /// members](https://developers.google.com/workspace/chat/set-up-spaces). To specify the human members to add,
        /// add memberships with the appropriate `member.name` in the `SetUpSpaceRequest`. To add a human user, use
        /// `users/{user}`, where `{user}` can be the email address for the user. For users in the same Workspace
        /// organization `{user}` can also be the `id` for the person from the People API, or the `id` for the user in
        /// the Directory API. For example, if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name` to `users/user@example.com` or
        /// `users/123456789`. For a space or group chat, if the caller blocks or is blocked by some members, then those
        /// members aren't added to the created space. To create a direct message (DM) between the calling user and
        /// another human user, specify exactly one membership to represent the human user. If one user blocks the
        /// other, the request fails and the DM isn't created. To create a DM between the calling user and the calling
        /// app, set `Space.singleUserBotDm` to `true` and don't specify any memberships. You can only use this method
        /// to set up a DM with the calling app. To add the calling app as a member of a space or an existing DM between
        /// two human users, see [Invite or add a user or app to a
        /// space](https://developers.google.com/workspace/chat/create-members). If a DM already exists between two
        /// users, even when one user blocks the other at the time a request is made, then the existing DM is returned.
        /// Spaces with threaded replies aren't supported. If you receive the error message `ALREADY_EXISTS` when
        /// setting up a space, try a different `displayName`. An existing space within the Google Workspace
        /// organization might already use this display name. Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SetupRequest Setup(Google.Apis.HangoutsChat.v1.Data.SetUpSpaceRequest body)
        {
            return new SetupRequest(this.service, body);
        }

        /// <summary>
        /// Creates a space and adds specified users to it. The calling user is automatically added to the space, and
        /// shouldn't be specified as a membership in the request. For an example, see [Set up a space with initial
        /// members](https://developers.google.com/workspace/chat/set-up-spaces). To specify the human members to add,
        /// add memberships with the appropriate `member.name` in the `SetUpSpaceRequest`. To add a human user, use
        /// `users/{user}`, where `{user}` can be the email address for the user. For users in the same Workspace
        /// organization `{user}` can also be the `id` for the person from the People API, or the `id` for the user in
        /// the Directory API. For example, if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name` to `users/user@example.com` or
        /// `users/123456789`. For a space or group chat, if the caller blocks or is blocked by some members, then those
        /// members aren't added to the created space. To create a direct message (DM) between the calling user and
        /// another human user, specify exactly one membership to represent the human user. If one user blocks the
        /// other, the request fails and the DM isn't created. To create a DM between the calling user and the calling
        /// app, set `Space.singleUserBotDm` to `true` and don't specify any memberships. You can only use this method
        /// to set up a DM with the calling app. To add the calling app as a member of a space or an existing DM between
        /// two human users, see [Invite or add a user or app to a
        /// space](https://developers.google.com/workspace/chat/create-members). If a DM already exists between two
        /// users, even when one user blocks the other at the time a request is made, then the existing DM is returned.
        /// Spaces with threaded replies aren't supported. If you receive the error message `ALREADY_EXISTS` when
        /// setting up a space, try a different `displayName`. An existing space within the Google Workspace
        /// organization might already use this display name. Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// </summary>
        public class SetupRequest : HangoutsChatBaseServiceRequest<Google.Apis.HangoutsChat.v1.Data.Space>
        {
            /// <summary>Constructs a new Setup request.</summary>
            public SetupRequest(Google.Apis.Services.IClientService service, Google.Apis.HangoutsChat.v1.Data.SetUpSpaceRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.HangoutsChat.v1.Data.SetUpSpaceRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setup";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/spaces:setup";

            /// <summary>Initializes Setup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.HangoutsChat.v1.Data
{
    /// <summary>
    /// One or more interactive widgets that appear at the bottom of a message. For details, see [Add interactive
    /// widgets at the bottom of a
    /// message](https://developers.google.com/workspace/chat/create-messages#add-accessory-widgets).
    /// </summary>
    public class AccessoryWidget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of buttons.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttonList")]
        public virtual GoogleAppsCardV1ButtonList ButtonList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// List of string parameters to supply when the action method is invoked. For example, consider three snooze
    /// buttons: snooze now, snooze one day, snooze next week. You might use `action method = snooze()`, passing the
    /// snooze type and snooze time in the list of string parameters.
    /// </summary>
    public class ActionParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the parameter for the action script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters that a Chat app can use to configure how its response is posted.</summary>
    public class ActionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. A response to an interaction event related to a
        /// [dialog](https://developers.google.com/workspace/chat/dialogs). Must be accompanied by
        /// `ResponseType.Dialog`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogAction")]
        public virtual DialogAction DialogAction { get; set; }

        /// <summary>Input only. The type of Chat app response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Input only. The response of the updated widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedWidget")]
        public virtual UpdatedWidget UpdatedWidget { get; set; }

        /// <summary>
        /// Input only. URL for users to authenticate or configure. (Only for `REQUEST_CONFIG` response types.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the status for a request to either invoke or submit a
    /// [dialog](https://developers.google.com/workspace/chat/dialogs).
    /// </summary>
    public class ActionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusCode")]
        public virtual string StatusCode { get; set; }

        /// <summary>
        /// The message to send users about the status of their request. If unset, a generic message based on the
        /// `status_code` is sent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userFacingMessage")]
        public virtual string UserFacingMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Output only. Annotations associated with the plain-text body of the message. To add basic formatting to a text
    /// message, see [Format text messages](https://developers.google.com/workspace/chat/format-messages). Example
    /// plain-text message body:
    /// ```
    /// Hello @FooBot how are you!"
    /// ```
    /// The corresponding annotations metadata:
    /// ```
    /// "annotations":[{ "type":"USER_MENTION", "startIndex":6, "length":7, "userMention": { "user": {
    /// "name":"users/{user}", "displayName":"FooBot", "avatarUrl":"https://goo.gl/aeDtrS", "type":"BOT" },
    /// "type":"MENTION" } }]
    /// ```
    /// </summary>
    public class Annotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Length of the substring in the plain-text message body this annotation corresponds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<int> Length { get; set; }

        /// <summary>The metadata for a rich link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("richLinkMetadata")]
        public virtual RichLinkMetadata RichLinkMetadata { get; set; }

        /// <summary>The metadata for a slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slashCommand")]
        public virtual SlashCommandMetadata SlashCommand { get; set; }

        /// <summary>
        /// Start index (0-based, inclusive) in the plain-text message body this annotation corresponds to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>The type of this annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The metadata of user mention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userMention")]
        public virtual UserMentionMetadata UserMention { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A GIF image that's specified by a URL.</summary>
    public class AttachedGif : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The URL that hosts the GIF image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An attachment in Google Chat.</summary>
    public class Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A reference to the attachment data. This field is used with the media API to download the attachment data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentDataRef")]
        public virtual AttachmentDataRef AttachmentDataRef { get; set; }

        /// <summary>Output only. The original file name for the content, not the full path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentName")]
        public virtual string ContentName { get; set; }

        /// <summary>Output only. The content type (MIME type) of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>
        /// Output only. The download URL which should be used to allow a human user to download the attachment. Chat
        /// apps shouldn't use this URL to download attachment content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUri")]
        public virtual string DownloadUri { get; set; }

        /// <summary>
        /// Output only. A reference to the Google Drive attachment. This field is used with the Google Drive API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveDataRef")]
        public virtual DriveDataRef DriveDataRef { get; set; }

        /// <summary>Resource name of the attachment, in the form `spaces/*/messages/*/attachments/*`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The source of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// Output only. The thumbnail URL which should be used to preview the attachment to a human user. Chat apps
        /// shouldn't use this URL to download attachment content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUri")]
        public virtual string ThumbnailUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AttachmentDataRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Opaque token containing a reference to an uploaded attachment. Treated by clients as an opaque string and
        /// used to create or update Chat messages with attachments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentUploadToken")]
        public virtual string AttachmentUploadToken { get; set; }

        /// <summary>
        /// The resource name of the attachment data. This field is used with the media API to download the attachment
        /// data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A button. Can be a text button or an image button.</summary>
    public class Button : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A button with image and `onclick` action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageButton")]
        public virtual ImageButton ImageButton { get; set; }

        /// <summary>A button with text and `onclick` action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textButton")]
        public virtual TextButton TextButton { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A card is a UI element that can contain UI widgets such as text and images.</summary>
    public class Card : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The actions of this card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardActions")]
        public virtual System.Collections.Generic.IList<CardAction> CardActions { get; set; }

        /// <summary>The header of the card. A header usually contains a title and an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual CardHeader Header { get; set; }

        /// <summary>Name of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Sections are separated by a line divider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sections")]
        public virtual System.Collections.Generic.IList<Section> Sections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A card action is the action associated with the card. For an invoice card, a typical action would be: delete
    /// invoice, email invoice or open the invoice in browser. Not supported by Google Chat apps.
    /// </summary>
    public class CardAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label used to be displayed in the action menu item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionLabel")]
        public virtual string ActionLabel { get; set; }

        /// <summary>The onclick action for this action item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CardHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The image's type (for example, square border or circular border).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageStyle")]
        public virtual string ImageStyle { get; set; }

        /// <summary>The URL of the image in the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The subtitle of the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>
        /// The title must be specified. The header has a fixed height: if both a title and subtitle is specified, each
        /// takes up one line. If only the title is specified, it takes up both lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A [card](https://developers.google.com/workspace/chat/api/reference/rest/v1/cards) in a Google Chat message.
    /// Only Chat apps can create cards. If your Chat app [authenticates as a
    /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), the message can't contain
    /// cards. [Card builder](https://addons.gsuite.google.com/uikit/builder)
    /// </summary>
    public class CardWithId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A card. Maximum size is 32 KB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("card")]
        public virtual GoogleAppsCardV1Card Card { get; set; }

        /// <summary>
        /// Required if the message contains multiple cards. A unique identifier for a card in a message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardId")]
        public virtual string CardId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSON payload of error messages. If the Cloud Logging API is enabled, these error messages are logged to [Google
    /// Cloud Logging](https://cloud.google.com/logging/docs).
    /// </summary>
    public class ChatAppLogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The deployment that caused the error. For Chat apps built in Apps Script, this is the deployment ID defined
        /// by Apps Script.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual string Deployment { get; set; }

        /// <summary>The unencrypted `callback_method` name that was running when the error was encountered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentFunction")]
        public virtual string DeploymentFunction { get; set; }

        /// <summary>The error code and message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For a `SelectionInput` widget that uses a multiselect menu, a data source from Google Chat. The data source
    /// populates selection items for the multiselect menu. For example, a user can select Google Chat spaces that
    /// they're a member of. [Google Chat apps](https://developers.google.com/workspace/chat):
    /// </summary>
    public class ChatClientDataSourceMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Chat spaces that the user is a member of.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceDataSource")]
        public virtual SpaceDataSource SpaceDataSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to and
    /// from color representations in various languages over compactness. For example, the fields of this representation
    /// can be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't have information about the
    /// absolute color space that should be used to interpret the RGB value—for example, sRGB, Adobe RGB, DCI-P3, and
    /// BT.2020. By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most `1e-5`. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class Color : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents information about the user's client, such as locale, host app, and platform. For Chat apps,
    /// `CommonEventObject` includes data submitted by users interacting with cards, like data entered in
    /// [dialogs](https://developers.google.com/chat/how-tos/dialogs).
    /// </summary>
    public class CommonEventObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A map containing the values that a user inputs in a widget from a card or dialog. The map keys are the
        /// string IDs assigned to each widget, and the values represent inputs to the widget. For details, see [Process
        /// information inputted by users](https://developers.google.com/chat/ui/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formInputs")]
        public virtual System.Collections.Generic.IDictionary<string, Inputs> FormInputs { get; set; }

        /// <summary>
        /// The hostApp enum which indicates the app the add-on is invoked from. Always `CHAT` for Chat apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostApp")]
        public virtual string HostApp { get; set; }

        /// <summary>Name of the invoked function associated with the widget. Only set for Chat apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invokedFunction")]
        public virtual string InvokedFunction { get; set; }

        /// <summary>
        /// Custom [parameters](/chat/api/reference/rest/v1/cards#ActionParameter) passed to the invoked function. Both
        /// keys and values must be strings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// The platform enum which indicates the platform where the event originates (`WEB`, `IOS`, or `ANDROID`). Not
        /// supported by Chat apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>
        /// The timezone ID and offset from Coordinated Universal Time (UTC). Only supported for the event types
        /// [`CARD_CLICKED`](https://developers.google.com/chat/api/reference/rest/v1/EventType#ENUM_VALUES.CARD_CLICKED)
        /// and
        /// [`SUBMIT_DIALOG`](https://developers.google.com/chat/api/reference/rest/v1/DialogEventType#ENUM_VALUES.SUBMIT_DIALOG).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>
        /// The full `locale.displayName` in the format of [ISO 639 language code]-[ISO 3166 country/region code] such
        /// as "en-US".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLocale")]
        public virtual string UserLocale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for completing the import process for a space.</summary>
    public class CompleteImportSpaceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CompleteImportSpaceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The import mode space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual Space Space { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a custom emoji.</summary>
    public class CustomEmoji : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique key for the custom emoji resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Date input values.</summary>
    public class DateInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time since epoch time, in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("msSinceEpoch")]
        public virtual System.Nullable<long> MsSinceEpoch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Date and time input values.</summary>
    public class DateTimeInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the `datetime` input includes a calendar date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDate")]
        public virtual System.Nullable<bool> HasDate { get; set; }

        /// <summary>Whether the `datetime` input includes a timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasTime")]
        public virtual System.Nullable<bool> HasTime { get; set; }

        /// <summary>Time since epoch time, in milliseconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("msSinceEpoch")]
        public virtual System.Nullable<long> MsSinceEpoch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a deleted message. A message is deleted when `delete_time` is set.</summary>
    public class DeletionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates who deleted the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionType")]
        public virtual string DeletionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Google Chat app interaction event. To learn about interaction events, see [Receive and respond to interactions
    /// with your Google Chat app](https://developers.google.com/workspace/chat/api/guides/message-formats). To learn
    /// about event types and for example event payloads, see [Types of Google Chat app interaction
    /// events](https://developers.google.com/workspace/chat/events). In addition to receiving events from user
    /// interactions, Chat apps can receive events about changes to spaces, such as when a new member is added to a
    /// space. To learn about space events, see [Work with events from Google
    /// Chat](https://developers.google.com/workspace/chat/events-overview).
    /// </summary>
    public class DeprecatedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For `CARD_CLICKED` interaction events, the form action data associated when a user clicks a card or dialog.
        /// To learn more, see [Read form data input by users on
        /// cards](https://developers.google.com/workspace/chat/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual FormAction Action { get; set; }

        /// <summary>
        /// Represents information about the user's client, such as locale, host app, and platform. For Chat apps,
        /// `CommonEventObject` includes information submitted by users interacting with
        /// [dialogs](https://developers.google.com/workspace/chat/dialogs), like data entered on a card.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("common")]
        public virtual CommonEventObject Common { get; set; }

        /// <summary>
        /// The URL the Chat app should redirect the user to after they have completed an authorization or configuration
        /// flow outside of Google Chat. For more information, see [Connect a Chat app with other services &amp;amp;
        /// tools](https://developers.google.com/workspace/chat/connect-web-services-tools).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configCompleteRedirectUrl")]
        public virtual string ConfigCompleteRedirectUrl { get; set; }

        /// <summary>
        /// The type of [dialog](https://developers.google.com/workspace/chat/dialogs) interaction event received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialogEventType")]
        public virtual string DialogEventType { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>The timestamp indicating when the interaction event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// For `CARD_CLICKED` interaction events, whether the user interacted with a
        /// [dialog](https://developers.google.com/workspace/chat/dialogs).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDialogEvent")]
        public virtual System.Nullable<bool> IsDialogEvent { get; set; }

        /// <summary>The message that triggered the interaction event, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The space in which the interaction event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual Space Space { get; set; }

        /// <summary>
        /// The Chat app-defined key for the thread related to the interaction event. See
        /// [`spaces.messages.thread.threadKey`](/chat/api/reference/rest/v1/spaces.messages#Thread.FIELDS.thread_key)
        /// for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadKey")]
        public virtual string ThreadKey { get; set; }

        /// <summary>
        /// A secret value that legacy Chat apps can use to verify if a request is from Google. Google randomly
        /// generates the token, and its value remains static. You can obtain, revoke, or regenerate the token from the
        /// [Chat API configuration page](https://console.cloud.google.com/apis/api/chat.googleapis.com/hangouts-chat)
        /// in the Google Cloud Console. Modern Chat apps don't use this field. It is absent from API responses and the
        /// [Chat API configuration page](https://console.cloud.google.com/apis/api/chat.googleapis.com/hangouts-chat).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>
        /// The type of interaction event. For details, see [Types of Google Chat app interaction
        /// events](https://developers.google.com/workspace/chat/events).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The user that triggered the interaction event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper around the card body of the dialog.</summary>
    public class Dialog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. Body of the dialog, which is rendered in a modal. Google Chat apps don't support the following
        /// card entities: `DateTimePicker`, `OnChangeAction`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual GoogleAppsCardV1Card Body { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains a [dialog](https://developers.google.com/workspace/chat/dialogs) and request status code.
    /// </summary>
    public class DialogAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. Status for a request to either invoke or submit a
        /// [dialog](https://developers.google.com/workspace/chat/dialogs). Displays a status and message to users, if
        /// necessary. For example, in case of an error or success.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionStatus")]
        public virtual ActionStatus ActionStatus { get; set; }

        /// <summary>
        /// Input only. [Dialog](https://developers.google.com/workspace/chat/dialogs) for the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dialog")]
        public virtual Dialog Dialog { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to the data of a drive attachment.</summary>
    public class DriveDataRef : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID for the drive file. Use with the Drive API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFileId")]
        public virtual string DriveFileId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for Google Drive links.</summary>
    public class DriveLinkData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A
        /// [DriveDataRef](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.messages.attachments#drivedataref)
        /// which references a Google Drive file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveDataRef")]
        public virtual DriveDataRef DriveDataRef { get; set; }

        /// <summary>The mime type of the linked Google Drive resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An emoji that is used as a reaction to a message.</summary>
    public class Emoji : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A custom emoji.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customEmoji")]
        public virtual CustomEmoji CustomEmoji { get; set; }

        /// <summary>A basic emoji represented by a unicode string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unicode")]
        public virtual string Unicode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The number of people who reacted to a message with a specific emoji.</summary>
    public class EmojiReactionSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Emoji associated with the reactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emoji")]
        public virtual Emoji Emoji { get; set; }

        /// <summary>The total number of reactions using the associated emoji.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactionCount")]
        public virtual System.Nullable<int> ReactionCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A form action describes the behavior when the form is submitted. For example, you can invoke Apps Script to
    /// handle the form.
    /// </summary>
    public class FormAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The method name is used to identify which part of the form triggered the form submission. This information
        /// is echoed back to the Chat app as part of the card click event. You can use the same method name for several
        /// elements that trigger a common behavior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionMethodName")]
        public virtual string ActionMethodName { get; set; }

        /// <summary>List of action parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<ActionParameter> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An action that describes the behavior when the form is submitted. For example, you can invoke an Apps Script
    /// script to handle the form. If the action is triggered, the form values are sent to the server. [Google Workspace
    /// Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A custom function to invoke when the containing element is clicked or othrwise activated. For example usage,
        /// see [Read form data](https://developers.google.com/workspace/chat/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>
        /// Optional. Required when opening a [dialog](https://developers.google.com/workspace/chat/dialogs). What to do
        /// in response to an interaction with a user, such as a user clicking a button in a card message. If
        /// unspecified, the app responds by executing an `action`—like opening a link or running a function—as normal.
        /// By specifying an `interaction`, the app can respond in special interactive ways. For example, by setting
        /// `interaction` to `OPEN_DIALOG`, the app can open a
        /// [dialog](https://developers.google.com/workspace/chat/dialogs). When specified, a loading indicator isn't
        /// shown. If specified for an add-on, the entire card is stripped and nothing is shown in the client. [Google
        /// Chat apps](https://developers.google.com/workspace/chat):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interaction")]
        public virtual string Interaction { get; set; }

        /// <summary>
        /// Specifies the loading indicator that the action displays while making the call to the action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadIndicator")]
        public virtual string LoadIndicator { get; set; }

        /// <summary>List of action parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1ActionParameter> Parameters { get; set; }

        /// <summary>
        /// Indicates whether form values persist after the action. The default value is `false`. If `true`, form values
        /// remain after the action is triggered. To let the user make changes while the action is being processed, set
        /// [`LoadIndicator`](https://developers.google.com/workspace/add-ons/reference/rpc/google.apps.card.v1#loadindicator)
        /// to `NONE`. For [card
        /// messages](https://developers.google.com/workspace/chat/api/guides/v1/messages/create#create) in Chat apps,
        /// you must also set the action's
        /// [`ResponseType`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.messages#responsetype)
        /// to `UPDATE_MESSAGE` and use the same
        /// [`card_id`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.messages#CardWithId)
        /// from the card that contained the action. If `false`, the form values are cleared when the action is
        /// triggered. To prevent the user from making changes while the action is being processed, set
        /// [`LoadIndicator`](https://developers.google.com/workspace/add-ons/reference/rpc/google.apps.card.v1#loadindicator)
        /// to `SPINNER`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistValues")]
        public virtual System.Nullable<bool> PersistValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// List of string parameters to supply when the action method is invoked. For example, consider three snooze
    /// buttons: snooze now, snooze one day, or snooze next week. You might use `action method = snooze()`, passing the
    /// snooze type and snooze time in the list of string parameters. To learn more, see
    /// [`CommonEventObject`](https://developers.google.com/workspace/chat/api/reference/rest/v1/Event#commoneventobject).
    /// [Google Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1ActionParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the parameter for the action script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The style options for the border of a card or widget, including the border type and color. [Google Workspace
    /// Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1BorderStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The corner radius for the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cornerRadius")]
        public virtual System.Nullable<int> CornerRadius { get; set; }

        /// <summary>The colors to use when the type is `BORDER_TYPE_STROKE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strokeColor")]
        public virtual Color StrokeColor { get; set; }

        /// <summary>The border type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A text, icon, or text and icon button that users can click. For an example in Google Chat apps, see [Add a
    /// button](https://developers.google.com/workspace/chat/design-interactive-card-dialog#add_a_button). To make an
    /// image a clickable button, specify an `Image` (not an `ImageComponent`) and set an `onClick` action. [Google
    /// Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1Button : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The alternative text that's used for accessibility. Set descriptive text that lets users know what the
        /// button does. For example, if a button opens a hyperlink, you might write: "Opens a new browser tab and
        /// navigates to the Google Chat developer documentation at https://developers.google.com/workspace/chat".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>
        /// If set, the button is filled with a solid background color and the font color changes to maintain contrast
        /// with the background color. For example, setting a blue background likely results in white text. If unset,
        /// the image background is white and the font color is blue. For red, green, and blue, the value of each field
        /// is a `float` number that you can express in either of two ways: as a number between 0 and 255 divided by 255
        /// (153/255), or as a value between 0 and 1 (0.6). 0 represents the absence of a color and 1 or 255/255
        /// represent the full presence of that color on the RGB scale. Optionally set `alpha`, which sets a level of
        /// transparency using this equation:
        /// ```
        /// pixel color = alpha * (this color) + (1.0 - alpha) * (background
        /// color)
        /// ```
        /// For `alpha`, a value of `1` corresponds with a solid color, and a value of `0` corresponds with a
        /// completely transparent color. For example, the following color represents a half transparent red:
        /// ```
        /// "color": { "red": 1, "green": 0, "blue": 0, "alpha": 0.5 }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>
        /// If `true`, the button is displayed in an inactive state and doesn't respond to user actions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>The icon image. If both `icon` and `text` are set, then the icon appears before the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual GoogleAppsCardV1Icon Icon { get; set; }

        /// <summary>
        /// Required. The action to perform when a user clicks the button, such as opening a hyperlink or running a
        /// custom function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleAppsCardV1OnClick OnClick { get; set; }

        /// <summary>The text displayed inside the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A list of buttons layed out horizontally. For an example in Google Chat apps, see [Add a
    /// button](https://developers.google.com/workspace/chat/design-interactive-card-dialog#add_a_button). [Google
    /// Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1ButtonList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of buttons.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1Button> Buttons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A card interface displayed in a Google Chat message or Google Workspace Add-on. Cards support a defined layout,
    /// interactive UI elements like buttons, and rich media like images. Use cards to present detailed information,
    /// gather information from users, and guide users to take a next step. [Card
    /// builder](https://addons.gsuite.google.com/uikit/builder) To learn how to build cards, see the following
    /// documentation: * For Google Chat apps, see [Design the components of a card or
    /// dialog](https://developers.google.com/workspace/chat/design-components-card-dialog). * For Google Workspace
    /// Add-ons, see [Card-based interfaces](https://developers.google.com/apps-script/add-ons/concepts/cards).
    /// **Example: Card message for a Google Chat app** ![Example contact
    /// card](https://developers.google.com/workspace/chat/images/card_api_reference.png) To create the sample card
    /// message in Google Chat, use the following JSON:
    /// ```
    /// { "cardsV2": [ { "cardId": "unique-card-id", "card": {
    /// "header": { "title": "Sasha", "subtitle": "Software Engineer", "imageUrl":
    /// "https://developers.google.com/workspace/chat/images/quickstart-app-avatar.png", "imageType": "CIRCLE",
    /// "imageAltText": "Avatar for Sasha" }, "sections": [ { "header": "Contact Info", "collapsible": true,
    /// "uncollapsibleWidgetsCount": 1, "widgets": [ { "decoratedText": { "startIcon": { "knownIcon": "EMAIL" }, "text":
    /// "sasha@example.com" } }, { "decoratedText": { "startIcon": { "knownIcon": "PERSON" }, "text": "Online" } }, {
    /// "decoratedText": { "startIcon": { "knownIcon": "PHONE" }, "text": "+1 (555) 555-1234" } }, { "buttonList": {
    /// "buttons": [ { "text": "Share", "onClick": { "openLink": { "url": "https://example.com/share" } } }, { "text":
    /// "Edit", "onClick": { "action": { "function": "goToView", "parameters": [ { "key": "viewType", "value": "EDIT" }
    /// ] } } } ] } } ] } ] } } ] }
    /// ```
    /// </summary>
    public class GoogleAppsCardV1Card : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The card's actions. Actions are added to the card's toolbar menu. [Google Workspace
        /// Add-ons](https://developers.google.com/workspace/add-ons): For example, the following JSON constructs a card
        /// action menu with `Settings` and `Send Feedback` options:
        /// ```
        /// "card_actions": [ { "actionLabel": "Settings",
        /// "onClick": { "action": { "functionName": "goToView", "parameters": [ { "key": "viewType", "value": "SETTING"
        /// } ], "loadIndicator": "LoadIndicator.SPINNER" } } }, { "actionLabel": "Send Feedback", "onClick": {
        /// "openLink": { "url": "https://example.com/feedback" } } } ]
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardActions")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1CardAction> CardActions { get; set; }

        /// <summary>
        /// In Google Workspace Add-ons, sets the display properties of the `peekCardHeader`. [Google Workspace
        /// Add-ons](https://developers.google.com/workspace/add-ons):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayStyle")]
        public virtual string DisplayStyle { get; set; }

        /// <summary>
        /// The fixed footer shown at the bottom of this card. Setting `fixedFooter` without specifying a
        /// `primaryButton` or a `secondaryButton` causes an error. For Chat apps, you can use fixed footers in
        /// [dialogs](https://developers.google.com/workspace/chat/dialogs), but not [card
        /// messages](https://developers.google.com/workspace/chat/create-messages#create). [Google Workspace Add-ons
        /// and Chat apps](https://developers.google.com/workspace/extend):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedFooter")]
        public virtual GoogleAppsCardV1CardFixedFooter FixedFooter { get; set; }

        /// <summary>
        /// The header of the card. A header usually contains a leading image and a title. Headers always appear at the
        /// top of a card.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual GoogleAppsCardV1CardHeader Header { get; set; }

        /// <summary>
        /// Name of the card. Used as a card identifier in card navigation. [Google Workspace
        /// Add-ons](https://developers.google.com/workspace/add-ons):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// When displaying contextual content, the peek card header acts as a placeholder so that the user can navigate
        /// forward between the homepage cards and the contextual cards. [Google Workspace
        /// Add-ons](https://developers.google.com/workspace/add-ons):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peekCardHeader")]
        public virtual GoogleAppsCardV1CardHeader PeekCardHeader { get; set; }

        /// <summary>The divider style between sections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionDividerStyle")]
        public virtual string SectionDividerStyle { get; set; }

        /// <summary>
        /// Contains a collection of widgets. Each section has its own, optional header. Sections are visually separated
        /// by a line divider. For an example in Google Chat apps, see [Define a section of a
        /// card](https://developers.google.com/workspace/chat/design-components-card-dialog#define_a_section_of_a_card).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sections")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1Section> Sections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A card action is the action associated with the card. For example, an invoice card might include actions such as
    /// delete invoice, email invoice, or open the invoice in a browser. [Google Workspace
    /// Add-ons](https://developers.google.com/workspace/add-ons):
    /// </summary>
    public class GoogleAppsCardV1CardAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label that displays as the action menu item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionLabel")]
        public virtual string ActionLabel { get; set; }

        /// <summary>The `onClick` action for this action item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleAppsCardV1OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A persistent (sticky) footer that that appears at the bottom of the card. Setting `fixedFooter` without
    /// specifying a `primaryButton` or a `secondaryButton` causes an error. For Chat apps, you can use fixed footers in
    /// [dialogs](https://developers.google.com/workspace/chat/dialogs), but not [card
    /// messages](https://developers.google.com/workspace/chat/create-messages#create). For an example in Google Chat
    /// apps, see [Add a persistent
    /// footer](https://developers.google.com/workspace/chat/design-components-card-dialog#add_a_persistent_footer).
    /// [Google Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1CardFixedFooter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The primary button of the fixed footer. The button must be a text button with text and color set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryButton")]
        public virtual GoogleAppsCardV1Button PrimaryButton { get; set; }

        /// <summary>
        /// The secondary button of the fixed footer. The button must be a text button with text and color set. If
        /// `secondaryButton` is set, you must also set `primaryButton`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryButton")]
        public virtual GoogleAppsCardV1Button SecondaryButton { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a card header. For an example in Google Chat apps, see [Add a
    /// header](https://developers.google.com/workspace/chat/design-components-card-dialog#add_a_header). [Google
    /// Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1CardHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text of this image that's used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageAltText")]
        public virtual string ImageAltText { get; set; }

        /// <summary>
        /// The shape used to crop the image. [Google Workspace Add-ons and Chat
        /// apps](https://developers.google.com/workspace/extend):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>The HTTPS URL of the image in the card header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The subtitle of the card header. If specified, appears on its own line below the `title`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>
        /// Required. The title of the card header. The header has a fixed height: if both a title and subtitle are
        /// specified, each takes up one line. If only the title is specified, it takes up both lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A column. [Google Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend): Columns for
    /// Google Workspace Add-ons are in Developer Preview.
    /// </summary>
    public class GoogleAppsCardV1Column : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies whether widgets align to the left, right, or center of a column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; }

        /// <summary>Specifies how a column fills the width of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalSizeStyle")]
        public virtual string HorizontalSizeStyle { get; set; }

        /// <summary>Specifies whether widgets align to the top, bottom, or center of a column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verticalAlignment")]
        public virtual string VerticalAlignment { get; set; }

        /// <summary>
        /// An array of widgets included in a column. Widgets appear in the order that they are specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1Widgets> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Columns` widget displays up to 2 columns in a card or dialog. You can add widgets to each column; the
    /// widgets appear in the order that they are specified. For an example in Google Chat apps, see [Display cards and
    /// dialogs in
    /// columns](https://developers.google.com/workspace/chat/format-structure-card-dialog#display_cards_and_dialogs_in_columns).
    /// The height of each column is determined by the taller column. For example, if the first column is taller than
    /// the second column, both columns have the height of the first column. Because each column can contain a different
    /// number of widgets, you can't define rows or align widgets between the columns. Columns are displayed
    /// side-by-side. You can customize the width of each column using the `HorizontalSizeStyle` field. If the user's
    /// screen width is too narrow, the second column wraps below the first: * On web, the second column wraps if the
    /// screen width is less than or equal to 480 pixels. * On iOS devices, the second column wraps if the screen width
    /// is less than or equal to 300 pt. * On Android devices, the second column wraps if the screen width is less than
    /// or equal to 320 dp. To include more than 2 columns, or to use rows, use the `Grid` widget. [Google Workspace
    /// Add-ons and Chat apps](https://developers.google.com/workspace/extend): Columns for Google Workspace Add-ons are
    /// in Developer Preview.
    /// </summary>
    public class GoogleAppsCardV1Columns : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of columns. You can include up to 2 columns in a card or dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnItems")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1Column> ColumnItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Lets users input a date, a time, or both a date and a time. For an example in Google Chat apps, see [Let a user
    /// pick a date and
    /// time](https://developers.google.com/workspace/chat/design-interactive-card-dialog#let_a_user_pick_a_date_and_time).
    /// Users can input text or use the picker to select dates and times. If users input an invalid date or time, the
    /// picker shows an error that prompts users to input the information correctly. [Google Workspace Add-ons and Chat
    /// apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1DateTimePicker : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The text that prompts users to input a date, a time, or a date and time. For example, if users are
        /// scheduling an appointment, use a label such as `Appointment date` or `Appointment date and time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The name by which the `DateTimePicker` is identified in a form input event. For details about working with
        /// form inputs, see [Receive form data](https://developers.google.com/workspace/chat/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Triggered when the user clicks **Save** or **Clear** from the `DateTimePicker` interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual GoogleAppsCardV1Action OnChangeAction { get; set; }

        /// <summary>
        /// The number representing the time zone offset from UTC, in minutes. If set, the `value_ms_epoch` is displayed
        /// in the specified time zone. If unset, the value defaults to the user's time zone setting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezoneOffsetDate")]
        public virtual System.Nullable<int> TimezoneOffsetDate { get; set; }

        /// <summary>Whether the widget supports inputting a date, a time, or the date and time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The default value displayed in the widget, in milliseconds since [Unix epoch
        /// time](https://en.wikipedia.org/wiki/Unix_time). Specify the value based on the type of picker
        /// (`DateTimePickerType`): * `DATE_AND_TIME`: a calendar date and time in UTC. For example, to represent
        /// January 1, 2023 at 12:00 PM UTC, use `1672574400000`. * `DATE_ONLY`: a calendar date at 00:00:00 UTC. For
        /// example, to represent January 1, 2023, use `1672531200000`. * `TIME_ONLY`: a time in UTC. For example, to
        /// represent 12:00 PM, use `43200000` (or `12 * 60 * 60 * 1000`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueMsEpoch")]
        public virtual System.Nullable<long> ValueMsEpoch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A widget that displays text with optional decorations such as a label above or below the text, an icon in front
    /// of the text, a selection widget, or a button after the text. For an example in Google Chat apps, see [Display
    /// text with decorative
    /// text](https://developers.google.com/workspace/chat/add-text-image-card-dialog#display_text_with_decorative_elements).
    /// [Google Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1DecoratedText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text that appears below `text`. Always wraps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomLabel")]
        public virtual string BottomLabel { get; set; }

        /// <summary>A button that a user can click to trigger an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("button")]
        public virtual GoogleAppsCardV1Button Button { get; set; }

        /// <summary>
        /// An icon displayed after the text. Supports
        /// [built-in](https://developers.google.com/workspace/chat/format-messages#builtinicons) and
        /// [custom](https://developers.google.com/workspace/chat/format-messages#customicons) icons.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIcon")]
        public virtual GoogleAppsCardV1Icon EndIcon { get; set; }

        /// <summary>Deprecated in favor of `startIcon`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual GoogleAppsCardV1Icon Icon { get; set; }

        /// <summary>This action is triggered when users click `topLabel` or `bottomLabel`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleAppsCardV1OnClick OnClick { get; set; }

        /// <summary>The icon displayed in front of the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIcon")]
        public virtual GoogleAppsCardV1Icon StartIcon { get; set; }

        /// <summary>A switch widget that a user can click to change its state and trigger an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("switchControl")]
        public virtual GoogleAppsCardV1SwitchControl SwitchControl { get; set; }

        /// <summary>
        /// Required. The primary text. Supports simple formatting. For more information about formatting text, see
        /// [Formatting text in Google Chat
        /// apps](https://developers.google.com/workspace/chat/format-messages#card-formatting) and [Formatting text in
        /// Google Workspace
        /// Add-ons](https://developers.google.com/apps-script/add-ons/concepts/widgets#text_formatting).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The text that appears above `text`. Always truncates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLabel")]
        public virtual string TopLabel { get; set; }

        /// <summary>
        /// The wrap text setting. If `true`, the text wraps and displays on multiple lines. Otherwise, the text is
        /// truncated. Only applies to `text`, not `topLabel` and `bottomLabel`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wrapText")]
        public virtual System.Nullable<bool> WrapText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Displays a divider between widgets as a horizontal line. For an example in Google Chat apps, see [Add a
    /// horizontal divider between
    /// widgets](https://developers.google.com/workspace/chat/format-structure-card-dialog#add_a_horizontal_divider_between_widgets).
    /// [Google Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend): For example, the
    /// following JSON creates a divider:
    /// ```
    /// "divider": {}
    /// ```
    /// </summary>
    public class GoogleAppsCardV1Divider : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Displays a grid with a collection of items. Items can only include text or images. For responsive columns, or to
    /// include more than text or images, use `Columns`. For an example in Google Chat apps, see [Display a Grid with a
    /// collection of
    /// items](https://developers.google.com/workspace/chat/format-structure-card-dialog#display_a_grid_with_a_collection_of_items).
    /// A grid supports any number of columns and items. The number of rows is determined by items divided by columns. A
    /// grid with 10 items and 2 columns has 5 rows. A grid with 11 items and 2 columns has 6 rows. [Google Workspace
    /// Add-ons and Chat apps](https://developers.google.com/workspace/extend): For example, the following JSON creates
    /// a 2 column grid with a single item:
    /// ```
    /// "grid": { "title": "A fine collection of items", "columnCount": 2,
    /// "borderStyle": { "type": "STROKE", "cornerRadius": 4 }, "items": [ { "image": { "imageUri":
    /// "https://www.example.com/image.png", "cropStyle": { "type": "SQUARE" }, "borderStyle": { "type": "STROKE" } },
    /// "title": "An item", "textAlignment": "CENTER" } ], "onClick": { "openLink": { "url": "https://www.example.com" }
    /// } }
    /// ```
    /// </summary>
    public class GoogleAppsCardV1Grid : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The border style to apply to each grid item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderStyle")]
        public virtual GoogleAppsCardV1BorderStyle BorderStyle { get; set; }

        /// <summary>
        /// The number of columns to display in the grid. A default value is used if this field isn't specified, and
        /// that default value is different depending on where the grid is shown (dialog versus companion).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnCount")]
        public virtual System.Nullable<int> ColumnCount { get; set; }

        /// <summary>The items to display in the grid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1GridItem> Items { get; set; }

        /// <summary>
        /// This callback is reused by each individual grid item, but with the item's identifier and index in the items
        /// list added to the callback's parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleAppsCardV1OnClick OnClick { get; set; }

        /// <summary>The text that displays in the grid header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an item in a grid layout. Items can contain text, an image, or both text and an image. [Google
    /// Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1GridItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A user-specified identifier for this grid item. This identifier is returned in the parent grid's `onClick`
        /// callback parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The image that displays in the grid item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleAppsCardV1ImageComponent Image { get; set; }

        /// <summary>The layout to use for the grid item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("layout")]
        public virtual string Layout { get; set; }

        /// <summary>The grid item's subtitle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>The grid item's title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An icon displayed in a widget on a card. For an example in Google Chat apps, see [Add an
    /// icon](https://developers.google.com/workspace/chat/add-text-image-card-dialog#add_an_icon). Supports
    /// [built-in](https://developers.google.com/workspace/chat/format-messages#builtinicons) and
    /// [custom](https://developers.google.com/workspace/chat/format-messages#customicons) icons. [Google Workspace
    /// Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1Icon : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A description of the icon used for accessibility. If unspecified, the default value `Button` is
        /// provided. As a best practice, you should set a helpful description for what the icon displays, and if
        /// applicable, what it does. For example, `A user's account portrait`, or `Opens a new browser tab and
        /// navigates to the Google Chat developer documentation at https://developers.google.com/workspace/chat`. If
        /// the icon is set in a `Button`, the `altText` appears as helper text when the user hovers over the button.
        /// However, if the button also sets `text`, the icon's `altText` is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>
        /// Display a custom icon hosted at an HTTPS URL. For example:
        /// ```
        /// "iconUrl":
        /// "https://developers.google.com/workspace/chat/images/quickstart-app-avatar.png"
        /// ```
        /// Supported file types
        /// include `.png` and `.jpg`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// The crop style applied to the image. In some cases, applying a `CIRCLE` crop causes the image to be drawn
        /// larger than a built-in icon.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>
        /// Display one of the built-in icons provided by Google Workspace. For example, to display an airplane icon,
        /// specify `AIRPLANE`. For a bus, specify `BUS`. For a full list of supported icons, see [built-in
        /// icons](https://developers.google.com/workspace/chat/format-messages#builtinicons).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("knownIcon")]
        public virtual string KnownIcon { get; set; }

        /// <summary>
        /// Display one of the [Google Material Icons](https://fonts.google.com/icons). For example, to display a
        /// [checkbox
        /// icon](https://fonts.google.com/icons?selected=Material%20Symbols%20Outlined%3Acheck_box%3AFILL%400%3Bwght%40400%3BGRAD%400%3Bopsz%4048),
        /// use
        /// ```
        /// "material_icon": { "name": "check_box" }
        /// ```
        /// [Google Chat
        /// apps](https://developers.google.com/workspace/chat):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materialIcon")]
        public virtual GoogleAppsCardV1MaterialIcon MaterialIcon { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An image that is specified by a URL and can have an `onClick` action. For an example, see [Add an
    /// image](https://developers.google.com/workspace/chat/add-text-image-card-dialog#add_an_image). [Google Workspace
    /// Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text of this image that's used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>
        /// The HTTPS URL that hosts the image. For example:
        /// ```
        /// https://developers.google.com/workspace/chat/images/quickstart-app-avatar.png
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>When a user clicks the image, the click triggers this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual GoogleAppsCardV1OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an image. [Google Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1ImageComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accessibility label for the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>The border style to apply to the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borderStyle")]
        public virtual GoogleAppsCardV1BorderStyle BorderStyle { get; set; }

        /// <summary>The crop style to apply to the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cropStyle")]
        public virtual GoogleAppsCardV1ImageCropStyle CropStyle { get; set; }

        /// <summary>The image URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the crop style applied to an image. [Google Workspace Add-ons and Chat
    /// apps](https://developers.google.com/workspace/extend): For example, here's how to apply a 16:9 aspect ratio:
    /// ```
    /// cropStyle { "type": "RECTANGLE_CUSTOM", "aspectRatio": 16/9 }
    /// ```
    /// </summary>
    public class GoogleAppsCardV1ImageCropStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The aspect ratio to use if the crop type is `RECTANGLE_CUSTOM`. For example, here's how to apply a 16:9
        /// aspect ratio:
        /// ```
        /// cropStyle { "type": "RECTANGLE_CUSTOM", "aspectRatio": 16/9 }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual System.Nullable<double> AspectRatio { get; set; }

        /// <summary>The crop type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A [Google Material Icon](https://fonts.google.com/icons), which includes over 2500+ options. For example, to
    /// display a [checkbox
    /// icon](https://fonts.google.com/icons?selected=Material%20Symbols%20Outlined%3Acheck_box%3AFILL%400%3Bwght%40400%3BGRAD%400%3Bopsz%4048)
    /// with customized weight and grade, write the following:
    /// ```
    /// { "name": "check_box", "fill": true, "weight": 300,
    /// "grade": -25 }
    /// ```
    /// [Google Chat apps](https://developers.google.com/workspace/chat):
    /// </summary>
    public class GoogleAppsCardV1MaterialIcon : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the icon renders as filled. Default value is false. To preview different icon settings, go to
        /// [Google Font Icons](https://fonts.google.com/icons) and adjust the settings under **Customize**.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fill")]
        public virtual System.Nullable<bool> Fill { get; set; }

        /// <summary>
        /// Weight and grade affect a symbol’s thickness. Adjustments to grade are more granular than adjustments to
        /// weight and have a small impact on the size of the symbol. Choose from {-25, 0, 200}. If absent, default
        /// value is 0. If any other value is specified, the default value is used. To preview different icon settings,
        /// go to [Google Font Icons](https://fonts.google.com/icons) and adjust the settings under **Customize**.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grade")]
        public virtual System.Nullable<int> Grade { get; set; }

        /// <summary>
        /// The icon name defined in the [Google Material Icon](https://fonts.google.com/icons), for example,
        /// `check_box`. Any invalid names are abandoned and replaced with empty string and results in the icon failing
        /// to render.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The stroke weight of the icon. Choose from {100, 200, 300, 400, 500, 600, 700}. If absent, default value is
        /// 400. If any other value is specified, the default value is used. To preview different icon settings, go to
        /// [Google Font Icons](https://fonts.google.com/icons) and adjust the settings under **Customize**.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<int> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents how to respond when users click an interactive element on a card, such as a button. [Google Workspace
    /// Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1OnClick : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If specified, an action is triggered by this `onClick`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual GoogleAppsCardV1Action Action { get; set; }

        /// <summary>
        /// A new card is pushed to the card stack after clicking if specified. [Google Workspace
        /// Add-ons](https://developers.google.com/workspace/add-ons):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("card")]
        public virtual GoogleAppsCardV1Card Card { get; set; }

        /// <summary>
        /// An add-on triggers this action when the action needs to open a link. This differs from the `open_link` above
        /// in that this needs to talk to server to get the link. Thus some preparation work is required for web client
        /// to do before the open link action response comes back. [Google Workspace
        /// Add-ons](https://developers.google.com/workspace/add-ons):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openDynamicLinkAction")]
        public virtual GoogleAppsCardV1Action OpenDynamicLinkAction { get; set; }

        /// <summary>If specified, this `onClick` triggers an open link action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openLink")]
        public virtual GoogleAppsCardV1OpenLink OpenLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an `onClick` event that opens a hyperlink. [Google Workspace Add-ons and Chat
    /// apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1OpenLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the client forgets about a link after opening it, or observes it until the window closes. [Google
        /// Workspace Add-ons](https://developers.google.com/workspace/add-ons):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClose")]
        public virtual string OnClose { get; set; }

        /// <summary>
        /// How to open a link. [Google Workspace Add-ons](https://developers.google.com/workspace/add-ons):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openAs")]
        public virtual string OpenAs { get; set; }

        /// <summary>The URL to open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For a `SelectionInput` widget that uses a multiselect menu, a data source from Google Workspace. Used to
    /// populate items in a multiselect menu. [Google Chat apps](https://developers.google.com/workspace/chat):
    /// </summary>
    public class GoogleAppsCardV1PlatformDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A data source shared by all Google Workspace applications, such as users in a Google Workspace organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonDataSource")]
        public virtual string CommonDataSource { get; set; }

        /// <summary>
        /// A data source that's unique to a Google Workspace host application, such spaces in Google Chat.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostAppDataSource")]
        public virtual HostAppDataSourceMarkup HostAppDataSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A section contains a collection of widgets that are rendered vertically in the order that they're specified.
    /// [Google Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1Section : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether this section is collapsible. Collapsible sections hide some or all widgets, but users can
        /// expand the section to reveal the hidden widgets by clicking **Show more**. Users can hide the widgets again
        /// by clicking **Show less**. To determine which widgets are hidden, specify `uncollapsibleWidgetsCount`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collapsible")]
        public virtual System.Nullable<bool> Collapsible { get; set; }

        /// <summary>
        /// Text that appears at the top of a section. Supports simple HTML formatted text. For more information about
        /// formatting text, see [Formatting text in Google Chat
        /// apps](https://developers.google.com/workspace/chat/format-messages#card-formatting) and [Formatting text in
        /// Google Workspace
        /// Add-ons](https://developers.google.com/apps-script/add-ons/concepts/widgets#text_formatting).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>
        /// The number of uncollapsible widgets which remain visible even when a section is collapsed. For example, when
        /// a section contains five widgets and the `uncollapsibleWidgetsCount` is set to `2`, the first two widgets are
        /// always shown and the last three are collapsed by default. The `uncollapsibleWidgetsCount` is taken into
        /// account only when `collapsible` is `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uncollapsibleWidgetsCount")]
        public virtual System.Nullable<int> UncollapsibleWidgetsCount { get; set; }

        /// <summary>All the widgets in the section. Must contain at least one widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1Widget> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A widget that creates one or more UI items that users can select. For example, a dropdown menu or checkboxes.
    /// You can use this widget to collect data that can be predicted or enumerated. For an example in Google Chat apps,
    /// see [Add selectable UI elements](/workspace/chat/design-interactive-card-dialog#add_selectable_ui_elements).
    /// Chat apps can process the value of items that users select or input. For details about working with form inputs,
    /// see [Receive form data](https://developers.google.com/workspace/chat/read-form-data). To collect undefined or
    /// abstract data from users, use the TextInput widget. [Google Workspace Add-ons and Chat
    /// apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1SelectionInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An external data source, such as a relational data base.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDataSource")]
        public virtual GoogleAppsCardV1Action ExternalDataSource { get; set; }

        /// <summary>
        /// An array of selectable items. For example, an array of radio buttons or checkboxes. Supports up to 100
        /// items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1SelectionItem> Items { get; set; }

        /// <summary>
        /// The text that appears above the selection input field in the user interface. Specify text that helps the
        /// user enter the information your app needs. For example, if users are selecting the urgency of a work ticket
        /// from a drop-down menu, the label might be "Urgency" or "Select urgency".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// For multiselect menus, the maximum number of items that a user can select. Minimum value is 1 item. If
        /// unspecified, defaults to 3 items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiSelectMaxSelectedItems")]
        public virtual System.Nullable<int> MultiSelectMaxSelectedItems { get; set; }

        /// <summary>
        /// For multiselect menus, the number of text characters that a user inputs before the app queries autocomplete
        /// and displays suggested items in the menu. If unspecified, defaults to 0 characters for static data sources
        /// and 3 characters for external data sources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiSelectMinQueryLength")]
        public virtual System.Nullable<int> MultiSelectMinQueryLength { get; set; }

        /// <summary>
        /// The name that identifies the selection input in a form input event. For details about working with form
        /// inputs, see [Receive form data](https://developers.google.com/workspace/chat/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If specified, the form is submitted when the selection changes. If not specified, you must specify a
        /// separate button that submits the form. For details about working with form inputs, see [Receive form
        /// data](https://developers.google.com/workspace/chat/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual GoogleAppsCardV1Action OnChangeAction { get; set; }

        /// <summary>A data source from Google Workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformDataSource")]
        public virtual GoogleAppsCardV1PlatformDataSource PlatformDataSource { get; set; }

        /// <summary>
        /// The type of items that are displayed to users in a `SelectionInput` widget. Selection types support
        /// different types of interactions. For example, users can select one or more checkboxes, but they can only
        /// select one value from a dropdown menu.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An item that users can select in a selection input, such as a checkbox or switch. [Google Workspace Add-ons and
    /// Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1SelectionItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For multiselect menus, a text description or label that's displayed below the item's `text` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomText")]
        public virtual string BottomText { get; set; }

        /// <summary>
        /// Whether the item is selected by default. If the selection input only accepts one value (such as for radio
        /// buttons or a dropdown menu), only set this field for one item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selected")]
        public virtual System.Nullable<bool> Selected { get; set; }

        /// <summary>
        /// For multiselect menus, the URL for the icon displayed next to the item's `text` field. Supports PNG and JPEG
        /// files. Must be an `HTTPS` URL. For example,
        /// `https://developers.google.com/workspace/chat/images/quickstart-app-avatar.png`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIconUri")]
        public virtual string StartIconUri { get; set; }

        /// <summary>The text that identifies or describes the item to users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// The value associated with this item. The client should use this as a form input value. For details about
        /// working with form inputs, see [Receive form
        /// data](https://developers.google.com/workspace/chat/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// One suggested value that users can enter in a text input field. [Google Workspace Add-ons and Chat
    /// apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1SuggestionItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The value of a suggested input to a text input field. This is equivalent to what users enter themselves.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Suggested values that users can enter. These values appear when users click inside the text input field. As
    /// users type, the suggested values dynamically filter to match what the users have typed. For example, a text
    /// input field for programming language might suggest Java, JavaScript, Python, and C++. When users start typing
    /// `Jav`, the list of suggestions filters to show `Java` and `JavaScript`. Suggested values help guide users to
    /// enter values that your app can make sense of. When referring to JavaScript, some users might enter `javascript`
    /// and others `java script`. Suggesting `JavaScript` can standardize how users interact with your app. When
    /// specified, `TextInput.type` is always `SINGLE_LINE`, even if it's set to `MULTIPLE_LINE`. [Google Workspace
    /// Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1Suggestions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of suggestions used for autocomplete recommendations in text input fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1SuggestionItem> Items { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Either a toggle-style switch or a checkbox inside a `decoratedText` widget. [Google Workspace Add-ons and Chat
    /// apps](https://developers.google.com/workspace/extend): Only supported in the `decoratedText` widget.
    /// </summary>
    public class GoogleAppsCardV1SwitchControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How the switch appears in the user interface. [Google Workspace Add-ons and Chat
        /// apps](https://developers.google.com/workspace/extend):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlType")]
        public virtual string ControlType { get; set; }

        /// <summary>
        /// The name by which the switch widget is identified in a form input event. For details about working with form
        /// inputs, see [Receive form data](https://developers.google.com/workspace/chat/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The action to perform when the switch state is changed, such as what function to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual GoogleAppsCardV1Action OnChangeAction { get; set; }

        /// <summary>When `true`, the switch is selected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selected")]
        public virtual System.Nullable<bool> Selected { get; set; }

        /// <summary>
        /// The value entered by a user, returned as part of a form input event. For details about working with form
        /// inputs, see [Receive form data](https://developers.google.com/workspace/chat/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A field in which users can enter text. Supports suggestions and on-change actions. For an example in Google Chat
    /// apps, see [Add a field in which a user can enter
    /// text](https://developers.google.com/workspace/chat/design-interactive-card-dialog#add_a_field_in_which_a_user_can_enter_text).
    /// Chat apps receive and can process the value of entered text during form input events. For details about working
    /// with form inputs, see [Receive form data](https://developers.google.com/workspace/chat/read-form-data). When you
    /// need to collect undefined or abstract data from users, use a text input. To collect defined or enumerated data
    /// from users, use the SelectionInput widget. [Google Workspace Add-ons and Chat
    /// apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1TextInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specify what action to take when the text input field provides suggestions to users who interact
        /// with it. If unspecified, the suggestions are set by `initialSuggestions` and are processed by the client. If
        /// specified, the app takes the action specified here, such as running a custom function. [Google Workspace
        /// Add-ons](https://developers.google.com/workspace/add-ons):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoCompleteAction")]
        public virtual GoogleAppsCardV1Action AutoCompleteAction { get; set; }

        /// <summary>
        /// Text that appears below the text input field meant to assist users by prompting them to enter a certain
        /// value. This text is always visible. Required if `label` is unspecified. Otherwise, optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hintText")]
        public virtual string HintText { get; set; }

        /// <summary>
        /// Suggested values that users can enter. These values appear when users click inside the text input field. As
        /// users type, the suggested values dynamically filter to match what the users have typed. For example, a text
        /// input field for programming language might suggest Java, JavaScript, Python, and C++. When users start
        /// typing `Jav`, the list of suggestions filters to show just `Java` and `JavaScript`. Suggested values help
        /// guide users to enter values that your app can make sense of. When referring to JavaScript, some users might
        /// enter `javascript` and others `java script`. Suggesting `JavaScript` can standardize how users interact with
        /// your app. When specified, `TextInput.type` is always `SINGLE_LINE`, even if it's set to `MULTIPLE_LINE`.
        /// [Google Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialSuggestions")]
        public virtual GoogleAppsCardV1Suggestions InitialSuggestions { get; set; }

        /// <summary>
        /// The text that appears above the text input field in the user interface. Specify text that helps the user
        /// enter the information your app needs. For example, if you are asking someone's name, but specifically need
        /// their surname, write `surname` instead of `name`. Required if `hintText` is unspecified. Otherwise,
        /// optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The name by which the text input is identified in a form input event. For details about working with form
        /// inputs, see [Receive form data](https://developers.google.com/workspace/chat/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// What to do when a change occurs in the text input field. For example, a user adding to the field or deleting
        /// text. Examples of actions to take include running a custom function or opening a
        /// [dialog](https://developers.google.com/workspace/chat/dialogs) in Google Chat.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onChangeAction")]
        public virtual GoogleAppsCardV1Action OnChangeAction { get; set; }

        /// <summary>
        /// Text that appears in the text input field when the field is empty. Use this text to prompt users to enter a
        /// value. For example, `Enter a number from 0 to 100`. [Google Chat
        /// apps](https://developers.google.com/workspace/chat):
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeholderText")]
        public virtual string PlaceholderText { get; set; }

        /// <summary>
        /// How a text input field appears in the user interface. For example, whether the field is single or
        /// multi-line.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The value entered by a user, returned as part of a form input event. For details about working with form
        /// inputs, see [Receive form data](https://developers.google.com/workspace/chat/read-form-data).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A paragraph of text that supports formatting. For an example in Google Chat apps, see [Add a paragraph of
    /// formatted
    /// text](https://developers.google.com/workspace/chat/add-text-image-card-dialog#add_a_paragraph_of_formatted_text).
    /// For more information about formatting text, see [Formatting text in Google Chat
    /// apps](https://developers.google.com/workspace/chat/format-messages#card-formatting) and [Formatting text in
    /// Google Workspace Add-ons](https://developers.google.com/apps-script/add-ons/concepts/widgets#text_formatting).
    /// [Google Workspace Add-ons and Chat apps](https://developers.google.com/workspace/extend):
    /// </summary>
    public class GoogleAppsCardV1TextParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text that's shown in the widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Each card is made up of widgets. A widget is a composite object that can represent one of text, images, buttons,
    /// and other object types.
    /// </summary>
    public class GoogleAppsCardV1Widget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of buttons. For example, the following JSON creates two buttons. The first is a blue text button and
        /// the second is an image button that opens a link:
        /// ```
        /// "buttonList": { "buttons": [ { "text": "Edit", "color":
        /// { "red": 0, "green": 0, "blue": 1, "alpha": 1 }, "disabled": true, }, { "icon": { "knownIcon": "INVITE",
        /// "altText": "check calendar" }, "onClick": { "openLink": { "url": "https://example.com/calendar" } } } ] }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttonList")]
        public virtual GoogleAppsCardV1ButtonList ButtonList { get; set; }

        /// <summary>
        /// Displays up to 2 columns. To include more than 2 columns, or to use rows, use the `Grid` widget. For
        /// example, the following JSON creates 2 columns that each contain text paragraphs:
        /// ```
        /// "columns": {
        /// "columnItems": [ { "horizontalSizeStyle": "FILL_AVAILABLE_SPACE", "horizontalAlignment": "CENTER",
        /// "verticalAlignment": "CENTER", "widgets": [ { "textParagraph": { "text": "First column text paragraph" } } ]
        /// }, { "horizontalSizeStyle": "FILL_AVAILABLE_SPACE", "horizontalAlignment": "CENTER", "verticalAlignment":
        /// "CENTER", "widgets": [ { "textParagraph": { "text": "Second column text paragraph" } } ] } ] }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual GoogleAppsCardV1Columns Columns { get; set; }

        /// <summary>
        /// Displays a widget that lets users input a date, time, or date and time. For example, the following JSON
        /// creates a date time picker to schedule an appointment:
        /// ```
        /// "dateTimePicker": { "name": "appointment_time",
        /// "label": "Book your appointment at:", "type": "DATE_AND_TIME", "valueMsEpoch": "796435200000" }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimePicker")]
        public virtual GoogleAppsCardV1DateTimePicker DateTimePicker { get; set; }

        /// <summary>
        /// Displays a decorated text item. For example, the following JSON creates a decorated text widget showing
        /// email address:
        /// ```
        /// "decoratedText": { "icon": { "knownIcon": "EMAIL" }, "topLabel": "Email Address", "text":
        /// "sasha@example.com", "bottomLabel": "This is a new Email address!", "switchControl": { "name":
        /// "has_send_welcome_email_to_sasha", "selected": false, "controlType": "CHECKBOX" } }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decoratedText")]
        public virtual GoogleAppsCardV1DecoratedText DecoratedText { get; set; }

        /// <summary>
        /// Displays a horizontal line divider between widgets. For example, the following JSON creates a divider:
        /// ```
        /// "divider": { }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("divider")]
        public virtual GoogleAppsCardV1Divider Divider { get; set; }

        /// <summary>
        /// Displays a grid with a collection of items. A grid supports any number of columns and items. The number of
        /// rows is determined by the upper bounds of the number items divided by the number of columns. A grid with 10
        /// items and 2 columns has 5 rows. A grid with 11 items and 2 columns has 6 rows. [Google Workspace Add-ons and
        /// Chat apps](https://developers.google.com/workspace/extend): For example, the following JSON creates a 2
        /// column grid with a single item:
        /// ```
        /// "grid": { "title": "A fine collection of items", "columnCount": 2,
        /// "borderStyle": { "type": "STROKE", "cornerRadius": 4 }, "items": [ { "image": { "imageUri":
        /// "https://www.example.com/image.png", "cropStyle": { "type": "SQUARE" }, "borderStyle": { "type": "STROKE" }
        /// }, "title": "An item", "textAlignment": "CENTER" } ], "onClick": { "openLink": { "url":
        /// "https://www.example.com" } } }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grid")]
        public virtual GoogleAppsCardV1Grid Grid { get; set; }

        /// <summary>Specifies whether widgets align to the left, right, or center of a column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; }

        /// <summary>
        /// Displays an image. For example, the following JSON creates an image with alternative text:
        /// ```
        /// "image": {
        /// "imageUrl": "https://developers.google.com/workspace/chat/images/quickstart-app-avatar.png", "altText":
        /// "Chat app avatar" }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleAppsCardV1Image Image { get; set; }

        /// <summary>
        /// Displays a selection control that lets users select items. Selection controls can be checkboxes, radio
        /// buttons, switches, or dropdown menus. For example, the following JSON creates a dropdown menu that lets
        /// users choose a size:
        /// ```
        /// "selectionInput": { "name": "size", "label": "Size" "type": "DROPDOWN", "items": [
        /// { "text": "S", "value": "small", "selected": false }, { "text": "M", "value": "medium", "selected": true },
        /// { "text": "L", "value": "large", "selected": false }, { "text": "XL", "value": "extra_large", "selected":
        /// false } ] }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionInput")]
        public virtual GoogleAppsCardV1SelectionInput SelectionInput { get; set; }

        /// <summary>
        /// Displays a text box that users can type into. For example, the following JSON creates a text input for an
        /// email address:
        /// ```
        /// "textInput": { "name": "mailing_address", "label": "Mailing Address" }
        /// ```
        /// As another
        /// example, the following JSON creates a text input for a programming language with static suggestions:
        /// ```
        /// "textInput": { "name": "preferred_programing_language", "label": "Preferred Language", "initialSuggestions":
        /// { "items": [ { "text": "C++" }, { "text": "Java" }, { "text": "JavaScript" }, { "text": "Python" } ] } }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textInput")]
        public virtual GoogleAppsCardV1TextInput TextInput { get; set; }

        /// <summary>
        /// Displays a text paragraph. Supports simple HTML formatted text. For more information about formatting text,
        /// see [Formatting text in Google Chat
        /// apps](https://developers.google.com/workspace/chat/format-messages#card-formatting) and [Formatting text in
        /// Google Workspace
        /// Add-ons](https://developers.google.com/apps-script/add-ons/concepts/widgets#text_formatting). For example,
        /// the following JSON creates a bolded text:
        /// ```
        /// "textParagraph": { "text": " *bold text*" }
        /// ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textParagraph")]
        public virtual GoogleAppsCardV1TextParagraph TextParagraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The supported widgets that you can include in a column. [Google Workspace Add-ons and Chat
    /// apps](https://developers.google.com/workspace/extend): Columns for Google Workspace Add-ons are in Developer
    /// Preview.
    /// </summary>
    public class GoogleAppsCardV1Widgets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ButtonList widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttonList")]
        public virtual GoogleAppsCardV1ButtonList ButtonList { get; set; }

        /// <summary>DateTimePicker widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimePicker")]
        public virtual GoogleAppsCardV1DateTimePicker DateTimePicker { get; set; }

        /// <summary>DecoratedText widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decoratedText")]
        public virtual GoogleAppsCardV1DecoratedText DecoratedText { get; set; }

        /// <summary>Image widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleAppsCardV1Image Image { get; set; }

        /// <summary>SelectionInput widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionInput")]
        public virtual GoogleAppsCardV1SelectionInput SelectionInput { get; set; }

        /// <summary>TextInput widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textInput")]
        public virtual GoogleAppsCardV1TextInput TextInput { get; set; }

        /// <summary>TextParagraph widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textParagraph")]
        public virtual GoogleAppsCardV1TextParagraph TextParagraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Google Group in Google Chat.</summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name for a Google Group. Represents a
        /// [group](https://cloud.google.com/identity/docs/reference/rest/v1/groups) in Cloud Identity Groups API.
        /// Format: groups/{group}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For a `SelectionInput` widget that uses a multiselect menu, a data source from a Google Workspace application.
    /// The data source populates selection items for the multiselect menu. [Google Chat
    /// apps](https://developers.google.com/workspace/chat):
    /// </summary>
    public class HostAppDataSourceMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A data source from Google Chat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatDataSource")]
        public virtual ChatClientDataSourceMarkup ChatDataSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image that's specified by a URL and can have an `onclick` action.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The aspect ratio of this image (width and height). This field lets you reserve the right height for the
        /// image while waiting for it to load. It's not meant to override the built-in aspect ratio of the image. If
        /// unset, the server fills it by prefetching the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aspectRatio")]
        public virtual System.Nullable<double> AspectRatio { get; set; }

        /// <summary>The URL of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUrl")]
        public virtual string ImageUrl { get; set; }

        /// <summary>The `onclick` action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image button with an `onclick` action.</summary>
    public class ImageButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The icon specified by an `enum` that indices to an icon provided by Chat API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>The icon specified by a URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// The name of this `image_button` that's used for accessibility. Default value is provided if this name isn't
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The `onclick` action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Types of data that users can [input on cards or dialogs](https://developers.google.com/chat/ui/read-form-data).
    /// The input type depends on the type of values that the widget accepts.
    /// </summary>
    public class Inputs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Date input values from a
        /// [`DateTimePicker`](https://developers.google.com/chat/api/reference/rest/v1/cards#DateTimePicker) widget
        /// that only accepts date values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateInput")]
        public virtual DateInput DateInput { get; set; }

        /// <summary>
        /// Date and time input values from a
        /// [`DateTimePicker`](https://developers.google.com/chat/api/reference/rest/v1/cards#DateTimePicker) widget
        /// that accepts both a date and time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimeInput")]
        public virtual DateTimeInput DateTimeInput { get; set; }

        /// <summary>
        /// A list of strings that represent the values that the user inputs in a widget. If the widget only accepts one
        /// value, such as a [`TextInput`](https://developers.google.com/chat/api/reference/rest/v1/cards#TextInput)
        /// widget, the list contains one string object. If the widget accepts multiple values, such as a
        /// [`SelectionInput`](https://developers.google.com/chat/api/reference/rest/v1/cards#selectioninput) widget of
        /// checkboxes, the list contains a string object for each value that the user inputs or selects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringInputs")]
        public virtual StringInputs StringInputs { get; set; }

        /// <summary>
        /// Time input values from a
        /// [`DateTimePicker`](https://developers.google.com/chat/api/reference/rest/v1/cards#DateTimePicker) widget
        /// that only accepts time values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeInput")]
        public virtual TimeInput TimeInput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A UI element contains a key (label) and a value (content). This element can also contain some actions such as
    /// `onclick` button.
    /// </summary>
    public class KeyValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The text of the bottom label. Formatted text supported. For more information about formatting text, see
        /// [Formatting text in Google Chat
        /// apps](https://developers.google.com/workspace/chat/format-messages#card-formatting) and [Formatting text in
        /// Google Workspace
        /// Add-ons](https://developers.google.com/apps-script/add-ons/concepts/widgets#text_formatting).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottomLabel")]
        public virtual string BottomLabel { get; set; }

        /// <summary>A button that can be clicked to trigger an action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("button")]
        public virtual Button Button { get; set; }

        /// <summary>
        /// The text of the content. Formatted text supported and always required. For more information about formatting
        /// text, see [Formatting text in Google Chat
        /// apps](https://developers.google.com/workspace/chat/format-messages#card-formatting) and [Formatting text in
        /// Google Workspace
        /// Add-ons](https://developers.google.com/apps-script/add-ons/concepts/widgets#text_formatting).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>If the content should be multiline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentMultiline")]
        public virtual System.Nullable<bool> ContentMultiline { get; set; }

        /// <summary>An enum value that's replaced by the Chat API with the corresponding icon image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual string Icon { get; set; }

        /// <summary>The icon specified by a URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUrl")]
        public virtual string IconUrl { get; set; }

        /// <summary>The `onclick` action. Only the top label, bottom label, and content region are clickable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>
        /// The text of the top label. Formatted text supported. For more information about formatting text, see
        /// [Formatting text in Google Chat
        /// apps](https://developers.google.com/workspace/chat/format-messages#card-formatting) and [Formatting text in
        /// Google Workspace
        /// Add-ons](https://developers.google.com/apps-script/add-ons/concepts/widgets#text_formatting).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLabel")]
        public virtual string TopLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListMembershipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unordered list. List of memberships in the requested (or first) page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<Membership> Memberships { get; set; }

        /// <summary>
        /// A token that you can send as `pageToken` to retrieve the next page of results. If empty, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListMessagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// You can send a token as `pageToken` to retrieve the next page of results. If empty, there are no subsequent
        /// pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListReactionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token to retrieve the next page of results. It's empty for the last page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of reactions in the requested (or first) page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactions")]
        public virtual System.Collections.Generic.IList<Reaction> Reactions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing space events.</summary>
    public class ListSpaceEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Continuation token used to fetch more events. If this field is omitted, there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Results are returned in chronological order (oldest event first).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceEvents")]
        public virtual System.Collections.Generic.IList<SpaceEvent> SpaceEvents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListSpacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// You can send a token as `pageToken` to retrieve the next page of results. If empty, there are no subsequent
        /// pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of spaces in the requested (or first) page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaces")]
        public virtual System.Collections.Generic.IList<Space> Spaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A matched URL in a Chat message. Chat apps can preview matched URLs. For more information, see [Preview
    /// links](https://developers.google.com/chat/how-tos/preview-links).
    /// </summary>
    public class MatchedUrl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The URL that was matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Media resource.</summary>
    public class Media : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the media resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a membership relation in Google Chat, such as whether a user or Chat app is invited to, part of, or
    /// absent from a space.
    /// </summary>
    public class Membership : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Optional. Immutable. The creation time of the membership, such as when a member joined or was invited to
        /// join a space. This field is output only, except when used to import historical memberships in import mode
        /// spaces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Optional. Immutable. The deletion time of the membership, such as when a member left or was removed from a
        /// space. This field is output only, except when used to import historical memberships in import mode spaces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The Google Group the membership corresponds to. Only supports read operations. Other operations, like
        /// creating or updating a membership, aren't currently supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupMember")]
        public virtual Group GroupMember { get; set; }

        /// <summary>
        /// The Google Chat user or app the membership corresponds to. If your Chat app [authenticates as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), the output populates
        /// the [user](https://developers.google.com/workspace/chat/api/reference/rest/v1/User) `name` and `type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual User Member { get; set; }

        /// <summary>
        /// Resource name of the membership, assigned by the server. Format: `spaces/{space}/members/{member}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. User's role within a Chat space, which determines their permitted actions in the space. [Developer
        /// Preview](https://developers.google.com/workspace/preview): This field can only be used as input in
        /// `UpdateMembership`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>Output only. State of the membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for multiple new memberships. Event type: `google.workspace.chat.membership.v1.batchCreated`
    /// </summary>
    public class MembershipBatchCreatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of new memberships.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<MembershipCreatedEventData> Memberships { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for multiple deleted memberships. Event type: `google.workspace.chat.membership.v1.batchDeleted`
    /// </summary>
    public class MembershipBatchDeletedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of deleted memberships.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<MembershipDeletedEventData> Memberships { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for multiple updated memberships. Event type: `google.workspace.chat.membership.v1.batchUpdated`
    /// </summary>
    public class MembershipBatchUpdatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of updated memberships.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<MembershipUpdatedEventData> Memberships { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for a new membership. Event type: `google.workspace.chat.membership.v1.created`.
    /// </summary>
    public class MembershipCreatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual Membership Membership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for a deleted membership. Event type: `google.workspace.chat.membership.v1.deleted`
    /// </summary>
    public class MembershipDeletedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deleted membership. Only the `name` and `state` fields are populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual Membership Membership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for an updated membership. Event type: `google.workspace.chat.membership.v1.updated`
    /// </summary>
    public class MembershipUpdatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual Membership Membership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message in a Google Chat space.</summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// One or more interactive widgets that appear at the bottom of a message. You can add accessory widgets to
        /// messages that contain text, cards, or both text and cards. Not supported for messages that contain dialogs.
        /// For details, see [Add interactive widgets at the bottom of a
        /// message](https://developers.google.com/workspace/chat/create-messages#add-accessory-widgets). Creating a
        /// message with accessory widgets requires [app authentication]
        /// (https://developers.google.com/workspace/chat/authenticate-authorize-chat-app).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessoryWidgets")]
        public virtual System.Collections.Generic.IList<AccessoryWidget> AccessoryWidgets { get; set; }

        /// <summary>Input only. Parameters that a Chat app can use to configure how its response is posted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionResponse")]
        public virtual ActionResponse ActionResponse { get; set; }

        /// <summary>Output only. Annotations associated with the `text` in this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<Annotation> Annotations { get; set; }

        /// <summary>Output only. Plain-text body of the message with all Chat app mentions stripped out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argumentText")]
        public virtual string ArgumentText { get; set; }

        /// <summary>Output only. GIF images that are attached to the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachedGifs")]
        public virtual System.Collections.Generic.IList<AttachedGif> AttachedGifs { get; set; }

        /// <summary>User-uploaded attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachment")]
        public virtual System.Collections.Generic.IList<Attachment> Attachment { get; set; }

        /// <summary>
        /// Deprecated: Use `cards_v2` instead. Rich, formatted, and interactive cards that you can use to display UI
        /// elements such as: formatted texts, buttons, and clickable images. Cards are normally displayed below the
        /// plain-text body of the message. `cards` and `cards_v2` can have a maximum size of 32 KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cards")]
        public virtual System.Collections.Generic.IList<Card> Cards { get; set; }

        /// <summary>
        /// An array of [cards](https://developers.google.com/workspace/chat/api/reference/rest/v1/cards). Only Chat
        /// apps can create cards. If your Chat app [authenticates as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), the messages can't
        /// contain cards. To learn about cards and how to create them, see [Send card
        /// messages](https://developers.google.com/workspace/chat/create-messages#create). [Card
        /// builder](https://addons.gsuite.google.com/uikit/builder)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardsV2")]
        public virtual System.Collections.Generic.IList<CardWithId> CardsV2 { get; set; }

        /// <summary>
        /// Optional. A custom ID for the message. You can use field to identify a message, or to get, delete, or update
        /// a message. To set a custom ID, specify the
        /// [`messageId`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.messages/create#body.QUERY_PARAMETERS.message_id)
        /// field when you create the message. For details, see [Name a
        /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientAssignedMessageId")]
        public virtual string ClientAssignedMessageId { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Optional. Immutable. For spaces created in Chat, the time at which the message was created. This field is
        /// output only, except when used in import mode spaces. For import mode spaces, set this field to the
        /// historical timestamp at which the message was created in the source in order to preserve the original
        /// creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Output only. The time at which the message was deleted in Google Chat. If the message is never deleted, this
        /// field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Information about a deleted message. A message is deleted when `delete_time` is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionMetadata")]
        public virtual DeletionMetadata DeletionMetadata { get; set; }

        /// <summary>Output only. The list of emoji reaction summaries on the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emojiReactionSummaries")]
        public virtual System.Collections.Generic.IList<EmojiReactionSummary> EmojiReactionSummaries { get; set; }

        /// <summary>
        /// A plain-text description of the message's cards, used when the actual cards can't be displayed—for example,
        /// mobile notifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fallbackText")]
        public virtual string FallbackText { get; set; }

        /// <summary>
        /// Output only. Contains the message `text` with markups added to communicate formatting. This field might not
        /// capture all formatting visible in the UI, but includes the following: * [Markup
        /// syntax](https://developers.google.com/workspace/chat/format-messages) for bold, italic, strikethrough,
        /// monospace, monospace block, and bulleted list. * [User
        /// mentions](https://developers.google.com/workspace/chat/format-messages#messages-@mention) using the format
        /// ``. * Custom hyperlinks using the format `&amp;lt;{url}|{rendered_text}&amp;gt;` where the first string is
        /// the URL and the second is the rendered text—for example, ``. * Custom emoji using the format
        /// `:{emoji_name}:`—for example, `:smile:`. This doesn't apply to Unicode emoji, such as `U+1F600` for a
        /// grinning face emoji. For more information, see [View text formatting sent in a
        /// message](https://developers.google.com/workspace/chat/format-messages#view_text_formatting_sent_in_a_message)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedText")]
        public virtual string FormattedText { get; set; }

        private string _lastUpdateTimeRaw;

        private object _lastUpdateTime;

        /// <summary>
        /// Output only. The time at which the message was last edited by a user. If the message has never been edited,
        /// this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual string LastUpdateTimeRaw
        {
            get => _lastUpdateTimeRaw;
            set
            {
                _lastUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateTimeDateTimeOffset instead.")]
        public virtual object LastUpdateTime
        {
            get => _lastUpdateTime;
            set
            {
                _lastUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateTimeRaw);
            set => LastUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. A URL in `spaces.messages.text` that matches a link preview pattern. For more information, see
        /// [Preview links](https://developers.google.com/workspace/chat/preview-links).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedUrl")]
        public virtual MatchedUrl MatchedUrl { get; set; }

        /// <summary>
        /// Resource name of the message. Format: `spaces/{space}/messages/{message}` Where `{space}` is the ID of the
        /// space where the message is posted and `{message}` is a system-assigned ID for the message. For example,
        /// `spaces/AAAAAAAAAAA/messages/BBBBBBBBBBB.BBBBBBBBBBB`. If you set a custom ID when you create a message, you
        /// can use this ID to specify the message in a request by replacing `{message}` with the value from the
        /// `clientAssignedMessageId` field. For example, `spaces/AAAAAAAAAAA/messages/client-custom-name`. For details,
        /// see [Name a message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. Input for creating a message, otherwise output only. The user that can view the message. When
        /// set, the message is private and only visible to the specified user and the Chat app. Link previews and
        /// attachments aren't supported for private messages. Only Chat apps can send private messages. If your Chat
        /// app [authenticates as a user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// to send a message, the message can't be private and must omit this field. For details, see [Send private
        /// messages to Google Chat users](https://developers.google.com/workspace/chat/private-messages).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateMessageViewer")]
        public virtual User PrivateMessageViewer { get; set; }

        /// <summary>
        /// Output only. Information about a message that's quoted by a Google Chat user in a space. Google Chat users
        /// can quote a message to reply to it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotedMessageMetadata")]
        public virtual QuotedMessageMetadata QuotedMessageMetadata { get; set; }

        /// <summary>
        /// Output only. The user who created the message. If your Chat app [authenticates as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), the output populates
        /// the [user](https://developers.google.com/workspace/chat/api/reference/rest/v1/User) `name` and `type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sender")]
        public virtual User Sender { get; set; }

        /// <summary>Output only. Slash command information, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slashCommand")]
        public virtual SlashCommand SlashCommand { get; set; }

        /// <summary>
        /// If your Chat app [authenticates as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), the output populates
        /// the [space](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces) `name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual Space Space { get; set; }

        /// <summary>
        /// Plain-text body of the message. The first link to an image, video, or web page generates a [preview
        /// chip](https://developers.google.com/workspace/chat/preview-links). You can also [@mention a Google Chat
        /// user](https://developers.google.com/workspace/chat/format-messages#messages-@mention), or everyone in the
        /// space. To learn about creating text messages, see [Send a text
        /// message](https://developers.google.com/workspace/chat/create-messages#create-text-messages).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>
        /// The thread the message belongs to. For example usage, see [Start or reply to a message
        /// thread](https://developers.google.com/workspace/chat/create-messages#create-message-thread).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thread")]
        public virtual Thread Thread { get; set; }

        /// <summary>
        /// Output only. When `true`, the message is a response in a reply thread. When `false`, the message is visible
        /// in the space's top-level conversation as either the first message of a thread or a message with no threaded
        /// replies. If the space doesn't support reply in threads, this field is always `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadReply")]
        public virtual System.Nullable<bool> ThreadReply { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for multiple new messages. Event type: `google.workspace.chat.message.v1.batchCreated`
    /// </summary>
    public class MessageBatchCreatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of new messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<MessageCreatedEventData> Messages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for multiple deleted messages. Event type: `google.workspace.chat.message.v1.batchDeleted`
    /// </summary>
    public class MessageBatchDeletedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of deleted messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<MessageDeletedEventData> Messages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for multiple updated messages. Event type: `google.workspace.chat.message.v1.batchUpdated`
    /// </summary>
    public class MessageBatchUpdatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of updated messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<MessageUpdatedEventData> Messages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event payload for a new message. Event type: `google.workspace.chat.message.v1.created`</summary>
    public class MessageCreatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event payload for a deleted message. Event type: `google.workspace.chat.message.v1.deleted`</summary>
    public class MessageDeletedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The deleted message. Only the `name`, `createTime`, `deleteTime`, and `deletionMetadata` fields are
        /// populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event payload for an updated message. Event type: `google.workspace.chat.message.v1.updated`</summary>
    public class MessageUpdatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An `onclick` action (for example, open a link).</summary>
    public class OnClick : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A form action is triggered by this `onclick` action if specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual FormAction Action { get; set; }

        /// <summary>This `onclick` action triggers an open link action if specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openLink")]
        public virtual OpenLink OpenLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A link that opens a new window.</summary>
    public class OpenLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URL to open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a quoted message.</summary>
    public class QuotedMessageMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastUpdateTimeRaw;

        private object _lastUpdateTime;

        /// <summary>
        /// Output only. The timestamp when the quoted message was created or when the quoted message was last updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual string LastUpdateTimeRaw
        {
            get => _lastUpdateTimeRaw;
            set
            {
                _lastUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateTimeDateTimeOffset instead.")]
        public virtual object LastUpdateTime
        {
            get => _lastUpdateTime;
            set
            {
                _lastUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateTimeRaw);
            set => LastUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Resource name of the quoted message. Format: `spaces/{space}/messages/{message}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reaction to a message.</summary>
    public class Reaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The emoji used in the reaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emoji")]
        public virtual Emoji Emoji { get; set; }

        /// <summary>
        /// The resource name of the reaction. Format: `spaces/{space}/messages/{message}/reactions/{reaction}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The user who created the reaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for multiple new reactions. Event type: `google.workspace.chat.reaction.v1.batchCreated`
    /// </summary>
    public class ReactionBatchCreatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of new reactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactions")]
        public virtual System.Collections.Generic.IList<ReactionCreatedEventData> Reactions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for multiple deleted reactions. Event type: `google.workspace.chat.reaction.v1.batchDeleted`
    /// </summary>
    public class ReactionBatchDeletedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of deleted reactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactions")]
        public virtual System.Collections.Generic.IList<ReactionDeletedEventData> Reactions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event payload for a new reaction. Event type: `google.workspace.chat.reaction.v1.created`</summary>
    public class ReactionCreatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new reaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reaction")]
        public virtual Reaction Reaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event payload for a deleted reaction. Type: `google.workspace.chat.reaction.v1.deleted`</summary>
    public class ReactionDeletedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deleted reaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reaction")]
        public virtual Reaction Reaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A rich link to a resource.</summary>
    public class RichLinkMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data for a drive link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveLinkData")]
        public virtual DriveLinkData DriveLinkData { get; set; }

        /// <summary>The rich link type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("richLinkType")]
        public virtual string RichLinkType { get; set; }

        /// <summary>The URI of this link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A section contains a collection of widgets that are rendered (vertically) in the order that they are specified.
    /// Across all platforms, cards have a narrow fixed width, so there's currently no need for layout properties (for
    /// example, float).
    /// </summary>
    public class Section : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The header of the section. Formatted text is supported. For more information about formatting text, see
        /// [Formatting text in Google Chat
        /// apps](https://developers.google.com/workspace/chat/format-messages#card-formatting) and [Formatting text in
        /// Google Workspace
        /// Add-ons](https://developers.google.com/apps-script/add-ons/concepts/widgets#text_formatting).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>A section must contain at least one widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<WidgetMarkup> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of widget autocomplete results.</summary>
    public class SelectionItems : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of the SelectionItem objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleAppsCardV1SelectionItem> Items { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SetUpSpaceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The Google Chat users to invite to join the space. Omit the calling user, as they are added
        /// automatically. The set currently allows up to 20 memberships (in addition to the caller). The
        /// `Membership.member` field must contain a `user` with `name` populated (format: `users/{user}`) and `type`
        /// set to `User.Type.HUMAN`. You can only add human users when setting up a space (adding Chat apps is only
        /// supported for direct message setup with the calling app). You can also add members using the user's email as
        /// an alias for {user}. For example, the `user.name` can be `users/example@gmail.com`." To invite Gmail users
        /// or users from external Google Workspace domains, user's email must be used for `{user}`. Optional when
        /// setting `Space.spaceType` to `SPACE`. Required when setting `Space.spaceType` to `GROUP_CHAT`, along with at
        /// least two memberships. Required when setting `Space.spaceType` to `DIRECT_MESSAGE` with a human user, along
        /// with exactly one membership. Must be empty when creating a 1:1 conversation between a human and the calling
        /// Chat app (when setting `Space.spaceType` to `DIRECT_MESSAGE` and `Space.singleUserBotDm` to `true`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<Membership> Memberships { get; set; }

        /// <summary>
        /// Optional. A unique identifier for this request. A random UUID is recommended. Specifying an existing request
        /// ID returns the space created with that ID instead of creating a new space. Specifying an existing request ID
        /// from the same Chat app with a different authenticated user returns an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Required. The `Space.spaceType` field is required. To create a space, set `Space.spaceType` to `SPACE` and
        /// set `Space.displayName`. If you receive the error message `ALREADY_EXISTS` when setting up a space, try a
        /// different `displayName`. An existing space within the Google Workspace organization might already use this
        /// display name. To create a group chat, set `Space.spaceType` to `GROUP_CHAT`. Don't set `Space.displayName`.
        /// To create a 1:1 conversation between humans, set `Space.spaceType` to `DIRECT_MESSAGE` and set
        /// `Space.singleUserBotDm` to `false`. Don't set `Space.displayName` or `Space.spaceDetails`. To create an 1:1
        /// conversation between a human and the calling Chat app, set `Space.spaceType` to `DIRECT_MESSAGE` and
        /// `Space.singleUserBotDm` to `true`. Don't set `Space.displayName` or `Space.spaceDetails`. If a
        /// `DIRECT_MESSAGE` space already exists, that space is returned instead of creating a new space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual Space Space { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A [slash command](https://developers.google.com/workspace/chat/slash-commands) in Google Chat.
    /// </summary>
    public class SlashCommand : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the slash command invoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandId")]
        public virtual System.Nullable<long> CommandId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for slash commands (/).</summary>
    public class SlashCommandMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Chat app whose command was invoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bot")]
        public virtual User Bot { get; set; }

        /// <summary>The command ID of the invoked slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandId")]
        public virtual System.Nullable<long> CommandId { get; set; }

        /// <summary>The name of the invoked slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandName")]
        public virtual string CommandName { get; set; }

        /// <summary>Indicates whether the slash command is for a dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggersDialog")]
        public virtual System.Nullable<bool> TriggersDialog { get; set; }

        /// <summary>The type of slash command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A space in Google Chat. Spaces are conversations between two or more users or 1:1 messages between a user and a
    /// Chat app.
    /// </summary>
    public class Space : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Whether the Chat app was installed by a Google Workspace administrator. Administrators can
        /// install a Chat app for their domain, organizational unit, or a group of users. Administrators can only
        /// install Chat apps for direct messaging between users and the app. To support admin install, your app must
        /// feature direct messaging.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminInstalled")]
        public virtual System.Nullable<bool> AdminInstalled { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Optional. Immutable. For spaces created in Chat, the time the space was created. This field is output only,
        /// except when used in import mode spaces. For import mode spaces, set this field to the historical timestamp
        /// at which the space was created in the source in order to preserve the original creation time. Only populated
        /// in the output when `spaceType` is `GROUP_CHAT` or `SPACE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The space's display name. Required when [creating a
        /// space](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces/create). If you receive the
        /// error message `ALREADY_EXISTS` when creating a space or updating the `displayName`, try a different
        /// `displayName`. An existing space within the Google Workspace organization might already use this display
        /// name. For direct messages, this field might be empty. Supports up to 128 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Immutable. Whether this space permits any Google Chat user as a member. Input when creating a space in a
        /// Google Workspace organization. Omit this field when creating spaces in the following conditions: * The
        /// authenticated user uses a consumer account (unmanaged user account). By default, a space created by a
        /// consumer account permits any Google Chat user. * The space is used to [import data to Google Chat]
        /// (https://developers.google.com/workspace/chat/import-data). Import mode spaces must only permit members from
        /// the same Google Workspace organization. For existing spaces, this field is output only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUserAllowed")]
        public virtual System.Nullable<bool> ExternalUserAllowed { get; set; }

        /// <summary>
        /// Optional. Whether this space is created in `Import Mode` as part of a data migration into Google Workspace.
        /// While spaces are being imported, they aren't visible to users until the import is complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importMode")]
        public virtual System.Nullable<bool> ImportMode { get; set; }

        /// <summary>Resource name of the space. Format: `spaces/{space}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Whether the space is a DM between a Chat app and a single human.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleUserBotDm")]
        public virtual System.Nullable<bool> SingleUserBotDm { get; set; }

        /// <summary>Details about the space including description and rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceDetails")]
        public virtual SpaceDetails SpaceDetails { get; set; }

        /// <summary>The message history state for messages and threads in this space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceHistoryState")]
        public virtual string SpaceHistoryState { get; set; }

        /// <summary>Output only. The threading state in the Chat space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceThreadingState")]
        public virtual string SpaceThreadingState { get; set; }

        /// <summary>
        /// The type of space. Required when creating a space or updating the space type of a space. Output only for
        /// other usage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceType")]
        public virtual string SpaceType { get; set; }

        /// <summary>
        /// Output only. Deprecated: Use `spaceThreadingState` instead. Whether messages are threaded in this space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threaded")]
        public virtual System.Nullable<bool> Threaded { get; set; }

        /// <summary>Output only. Deprecated: Use `space_type` instead. The type of a space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event payload for multiple updates to a space. Event type: `google.workspace.chat.space.v1.batchUpdated`
    /// </summary>
    public class SpaceBatchUpdatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of updated spaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaces")]
        public virtual System.Collections.Generic.IList<SpaceUpdatedEventData> Spaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A data source that populates Google Chat spaces as selection items for a multiselect menu. Only populates spaces
    /// that the user is a member of. [Google Chat apps](https://developers.google.com/workspace/chat):
    /// </summary>
    public class SpaceDataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set to `true`, the multiselect menu selects the current Google Chat space as an item by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultToCurrentSpace")]
        public virtual System.Nullable<bool> DefaultToCurrentSpace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the space including description and rules.</summary>
    public class SpaceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A description of the space. For example, describe the space's discussion topic, functional
        /// purpose, or participants. Supports up to 150 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. The space's rules, expectations, and etiquette. Supports up to 5,000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guidelines")]
        public virtual string Guidelines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event that represents a change or activity in a Google Chat space. To learn more, see [Work with events from
    /// Google Chat](https://developers.google.com/workspace/chat/events-overview).
    /// </summary>
    public class SpaceEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Time when the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Type of space event. Each event type has a batch version, which represents multiple instances of the event
        /// type that occur in a short period of time. For `spaceEvents.list()` requests, omit batch event types in your
        /// query filter. By default, the server returns both event type and its batch version. Supported event types
        /// for [messages](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.messages): * New
        /// message: `google.workspace.chat.message.v1.created` * Updated message:
        /// `google.workspace.chat.message.v1.updated` * Deleted message: `google.workspace.chat.message.v1.deleted` *
        /// Multiple new messages: `google.workspace.chat.message.v1.batchCreated` * Multiple updated messages:
        /// `google.workspace.chat.message.v1.batchUpdated` * Multiple deleted messages:
        /// `google.workspace.chat.message.v1.batchDeleted` Supported event types for
        /// [memberships](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.members): * New
        /// membership: `google.workspace.chat.membership.v1.created` * Updated membership:
        /// `google.workspace.chat.membership.v1.updated` * Deleted membership:
        /// `google.workspace.chat.membership.v1.deleted` * Multiple new memberships:
        /// `google.workspace.chat.membership.v1.batchCreated` * Multiple updated memberships:
        /// `google.workspace.chat.membership.v1.batchUpdated` * Multiple deleted memberships:
        /// `google.workspace.chat.membership.v1.batchDeleted` Supported event types for
        /// [reactions](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.messages.reactions): *
        /// New reaction: `google.workspace.chat.reaction.v1.created` * Deleted reaction:
        /// `google.workspace.chat.reaction.v1.deleted` * Multiple new reactions:
        /// `google.workspace.chat.reaction.v1.batchCreated` * Multiple deleted reactions:
        /// `google.workspace.chat.reaction.v1.batchDeleted` Supported event types about the
        /// [space](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces): * Updated space:
        /// `google.workspace.chat.space.v1.updated` * Multiple space updates:
        /// `google.workspace.chat.space.v1.batchUpdated`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>
        /// Event payload for multiple new memberships. Event type: `google.workspace.chat.membership.v1.batchCreated`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipBatchCreatedEventData")]
        public virtual MembershipBatchCreatedEventData MembershipBatchCreatedEventData { get; set; }

        /// <summary>
        /// Event payload for multiple deleted memberships. Event type:
        /// `google.workspace.chat.membership.v1.batchDeleted`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipBatchDeletedEventData")]
        public virtual MembershipBatchDeletedEventData MembershipBatchDeletedEventData { get; set; }

        /// <summary>
        /// Event payload for multiple updated memberships. Event type:
        /// `google.workspace.chat.membership.v1.batchUpdated`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipBatchUpdatedEventData")]
        public virtual MembershipBatchUpdatedEventData MembershipBatchUpdatedEventData { get; set; }

        /// <summary>
        /// Event payload for a new membership. Event type: `google.workspace.chat.membership.v1.created`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipCreatedEventData")]
        public virtual MembershipCreatedEventData MembershipCreatedEventData { get; set; }

        /// <summary>
        /// Event payload for a deleted membership. Event type: `google.workspace.chat.membership.v1.deleted`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipDeletedEventData")]
        public virtual MembershipDeletedEventData MembershipDeletedEventData { get; set; }

        /// <summary>
        /// Event payload for an updated membership. Event type: `google.workspace.chat.membership.v1.updated`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipUpdatedEventData")]
        public virtual MembershipUpdatedEventData MembershipUpdatedEventData { get; set; }

        /// <summary>
        /// Event payload for multiple new messages. Event type: `google.workspace.chat.message.v1.batchCreated`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageBatchCreatedEventData")]
        public virtual MessageBatchCreatedEventData MessageBatchCreatedEventData { get; set; }

        /// <summary>
        /// Event payload for multiple deleted messages. Event type: `google.workspace.chat.message.v1.batchDeleted`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageBatchDeletedEventData")]
        public virtual MessageBatchDeletedEventData MessageBatchDeletedEventData { get; set; }

        /// <summary>
        /// Event payload for multiple updated messages. Event type: `google.workspace.chat.message.v1.batchUpdated`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageBatchUpdatedEventData")]
        public virtual MessageBatchUpdatedEventData MessageBatchUpdatedEventData { get; set; }

        /// <summary>Event payload for a new message. Event type: `google.workspace.chat.message.v1.created`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageCreatedEventData")]
        public virtual MessageCreatedEventData MessageCreatedEventData { get; set; }

        /// <summary>
        /// Event payload for a deleted message. Event type: `google.workspace.chat.message.v1.deleted`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageDeletedEventData")]
        public virtual MessageDeletedEventData MessageDeletedEventData { get; set; }

        /// <summary>
        /// Event payload for an updated message. Event type: `google.workspace.chat.message.v1.updated`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageUpdatedEventData")]
        public virtual MessageUpdatedEventData MessageUpdatedEventData { get; set; }

        /// <summary>Resource name of the space event. Format: `spaces/{space}/spaceEvents/{spaceEvent}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Event payload for multiple new reactions. Event type: `google.workspace.chat.reaction.v1.batchCreated`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactionBatchCreatedEventData")]
        public virtual ReactionBatchCreatedEventData ReactionBatchCreatedEventData { get; set; }

        /// <summary>
        /// Event payload for multiple deleted reactions. Event type: `google.workspace.chat.reaction.v1.batchDeleted`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactionBatchDeletedEventData")]
        public virtual ReactionBatchDeletedEventData ReactionBatchDeletedEventData { get; set; }

        /// <summary>Event payload for a new reaction. Event type: `google.workspace.chat.reaction.v1.created`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactionCreatedEventData")]
        public virtual ReactionCreatedEventData ReactionCreatedEventData { get; set; }

        /// <summary>
        /// Event payload for a deleted reaction. Event type: `google.workspace.chat.reaction.v1.deleted`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reactionDeletedEventData")]
        public virtual ReactionDeletedEventData ReactionDeletedEventData { get; set; }

        /// <summary>
        /// Event payload for multiple updates to a space. Event type: `google.workspace.chat.space.v1.batchUpdated`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceBatchUpdatedEventData")]
        public virtual SpaceBatchUpdatedEventData SpaceBatchUpdatedEventData { get; set; }

        /// <summary>Event payload for a space update. Event type: `google.workspace.chat.space.v1.updated`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceUpdatedEventData")]
        public virtual SpaceUpdatedEventData SpaceUpdatedEventData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event payload for an updated space. Event type: `google.workspace.chat.space.v1.updated`</summary>
    public class SpaceUpdatedEventData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual Space Space { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Input parameter for regular widgets. For single-valued widgets, it is a single value list. For multi-valued
    /// widgets, such as checkbox, all the values are presented.
    /// </summary>
    public class StringInputs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An list of strings entered by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<string> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A button with text and `onclick` action.</summary>
    public class TextButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `onclick` action of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onClick")]
        public virtual OnClick OnClick { get; set; }

        /// <summary>The text of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A paragraph of text. Formatted text supported. For more information about formatting text, see [Formatting text
    /// in Google Chat apps](https://developers.google.com/workspace/chat/format-messages#card-formatting) and
    /// [Formatting text in Google Workspace
    /// Add-ons](https://developers.google.com/apps-script/add-ons/concepts/widgets#text_formatting).
    /// </summary>
    public class TextParagraph : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A thread in a Google Chat space. For example usage, see [Start or reply to a message
    /// thread](https://developers.google.com/workspace/chat/create-messages#create-message-thread). If you specify a
    /// thread when creating a message, you can set the
    /// [`messageReplyOption`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.messages/create#messagereplyoption)
    /// field to determine what happens if no matching thread is found.
    /// </summary>
    public class Thread : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Resource name of the thread. Example: `spaces/{space}/threads/{thread}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Input for creating or updating a thread. Otherwise, output only. ID for the thread. Supports up to
        /// 4000 characters. This ID is unique to the Chat app that sets it. For example, if multiple Chat apps create a
        /// message using the same thread key, the messages are posted in different threads. To reply in a thread
        /// created by a person or another Chat app, specify the thread `name` field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadKey")]
        public virtual string ThreadKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time input values.</summary>
    public class TimeInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The hour on a 24-hour clock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>The number of minutes past the hour. Valid values are 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The timezone ID and offset from Coordinated Universal Time (UTC). Only supported for the event types
    /// [`CARD_CLICKED`](https://developers.google.com/chat/api/reference/rest/v1/EventType#ENUM_VALUES.CARD_CLICKED)
    /// and
    /// [`SUBMIT_DIALOG`](https://developers.google.com/chat/api/reference/rest/v1/DialogEventType#ENUM_VALUES.SUBMIT_DIALOG).
    /// </summary>
    public class TimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [IANA TZ](https://www.iana.org/time-zones) time zone database code, such as "America/Toronto".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The user timezone offset, in milliseconds, from Coordinated Universal Time (UTC).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<int> Offset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response of the updated widget. Used to provide autocomplete options for a widget.</summary>
    public class UpdatedWidget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of widget autocomplete results</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestions")]
        public virtual SelectionItems Suggestions { get; set; }

        /// <summary>
        /// The ID of the updated widget. The ID must match the one for the widget that triggered the update request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widget")]
        public virtual string Widget { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UploadAttachmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The filename of the attachment, including the file extension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UploadAttachmentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reference to the uploaded attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentDataRef")]
        public virtual AttachmentDataRef AttachmentDataRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A user in Google Chat. When returned as an output from a request, if your Chat app [authenticates as a
    /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user), the output for a `User`
    /// resource only populates the user's `name` and `type`.
    /// </summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The user's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Unique identifier of the user's Google Workspace domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainId")]
        public virtual string DomainId { get; set; }

        /// <summary>Output only. When `true`, the user is deleted or their profile is not visible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAnonymous")]
        public virtual System.Nullable<bool> IsAnonymous { get; set; }

        /// <summary>
        /// Resource name for a Google Chat user. Format: `users/{user}`. `users/app` can be used as an alias for the
        /// calling app bot user. For human users, `{user}` is the same user identifier as: - the `id` for the
        /// [Person](https://developers.google.com/people/api/rest/v1/people) in the People API. For example,
        /// `users/123456789` in Chat API represents the same person as the `123456789` Person profile ID in People API.
        /// - the `id` for a [user](https://developers.google.com/admin-sdk/directory/reference/rest/v1/users) in the
        /// Admin SDK Directory API. - the user's email address can be used as an alias for `{user}` in API requests.
        /// For example, if the People API Person profile ID for `user@example.com` is `123456789`, you can use
        /// `users/user@example.com` as an alias to reference `users/123456789`. Only the canonical resource name (for
        /// example `users/123456789`) will be returned from the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Annotation metadata for user mentions (@).</summary>
    public class UserMentionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of user mention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The user mentioned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A widget is a UI element that presents text and images.</summary>
    public class WidgetMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of buttons. Buttons is also `oneof data` and only one of these fields should be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<Button> Buttons { get; set; }

        /// <summary>Display an image in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>Display a key value item in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValue")]
        public virtual KeyValue KeyValue { get; set; }

        /// <summary>Display a text paragraph in this widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textParagraph")]
        public virtual TextParagraph TextParagraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}

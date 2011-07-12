//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Pagespeedonline.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Result : Google.Apis.Requests.ISchemaResponse {
        
        private Result.FormattedResultsData formattedResults;
        
        private string id;
        
        private IList<System.String> invalidRules;
        
        private string kind;
        
        private Result.PageStatsData pageStats;
        
        private long responseCode;
        
        private long score;
        
        private string title;
        
        private Result.VersionData version;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>Localized Page Speed results. Contains a ruleResults entry for each Page Speed rule instantiated and run by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedResults")]
        public virtual Result.FormattedResultsData FormattedResults {
            get {
                return this.formattedResults;
            }
            set {
                this.formattedResults = value;
            }
        }
        
        /// <summary>Canonicalized and final URL for the document, after following page redirects (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        /// <summary>List of rules that were specified in the request, but which the server did not know how to instantiate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidRules")]
        public virtual IList<System.String> InvalidRules {
            get {
                return this.invalidRules;
            }
            set {
                this.invalidRules = value;
            }
        }
        
        /// <summary>Kind of result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Summary statistics for the page, such as number of JavaScript bytes, number of HTML bytes, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageStats")]
        public virtual Result.PageStatsData PageStats {
            get {
                return this.pageStats;
            }
            set {
                this.pageStats = value;
            }
        }
        
        /// <summary>Response code for the document. 200 indicates a normal page load. 4xx/5xx indicates an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseCode")]
        public virtual long ResponseCode {
            get {
                return this.responseCode;
            }
            set {
                this.responseCode = value;
            }
        }
        
        /// <summary>The Page Speed Score (0-100), which indicates how much faster a page could be. A high score indicates little room for improvement, while a lower score indicates more room for improvement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual long Score {
            get {
                return this.score;
            }
            set {
                this.score = value;
            }
        }
        
        /// <summary>Title of the page, as displayed in the browser&apos;s title bar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title {
            get {
                return this.title;
            }
            set {
                this.title = value;
            }
        }
        
        /// <summary>The version of the Page Speed SDK used to generate these results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Result.VersionData Version {
            get {
                return this.version;
            }
            set {
                this.version = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
        
        /// <summary>Localized Page Speed results. Contains a ruleResults entry for each Page Speed rule instantiated and run by the server.</summary>
        public class FormattedResultsData {
            
            private string locale;
            
            private FormattedResultsData.RuleResultsData ruleResults;
            
            /// <summary>The locale of the formattedResults, e.g. &quot;en_US&quot;.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("locale")]
            public virtual string Locale {
                get {
                    return this.locale;
                }
                set {
                    this.locale = value;
                }
            }
            
            /// <summary>Dictionary of formatted rule results, with one entry for each Page Speed rule instantiated and run by the server.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("ruleResults")]
            public virtual FormattedResultsData.RuleResultsData RuleResults {
                get {
                    return this.ruleResults;
                }
                set {
                    this.ruleResults = value;
                }
            }
            
            /// <summary>Dictionary of formatted rule results, with one entry for each Page Speed rule instantiated and run by the server.</summary>
            public class RuleResultsData : System.Collections.Generic.Dictionary<string, RuleResultsData.RuleResultsDataSchema> {
                
                /// <summary>The enum-like identifier for this rule. For instance &quot;EnableKeepAlive&quot; or &quot;AvoidCssImport&quot;. Not localized.</summary>
                public class RuleResultsDataSchema {
                    
                    private string localizedRuleName;
                    
                    private double ruleImpact;
                    
                    private long ruleScore;
                    
                    private IList<RuleResultsDataSchema.UrlBlocksData> urlBlocks;
                    
                    /// <summary>Localized name of the rule, intended for presentation to a user.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("localizedRuleName")]
                    public virtual string LocalizedRuleName {
                        get {
                            return this.localizedRuleName;
                        }
                        set {
                            this.localizedRuleName = value;
                        }
                    }
                    
                    /// <summary>The impact (unbounded floating point value) that implementing the suggestions for this rule would have on making the page faster.  Impact is comparable between rules to determine which rule&apos;s suggestions would have a higher or lower impact on making a page faster. For instance, if enabling compression would save 1MB, while optimizing images would save 500kB, the enable compression rule would have 2x the impact of the image optimization rule, all other things being equal.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("ruleImpact")]
                    public virtual double RuleImpact {
                        get {
                            return this.ruleImpact;
                        }
                        set {
                            this.ruleImpact = value;
                        }
                    }
                    
                    /// <summary>The score (0-100) for this rule. The rule score indicates how well a page implements the recommendations for the given rule. For instance, if none of the compressible resources on a page are compressed, the rule score would be 0, while if all of the compressible resources on a page are compressed, the rule score would be 100.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("ruleScore")]
                    public virtual long RuleScore {
                        get {
                            return this.ruleScore;
                        }
                        set {
                            this.ruleScore = value;
                        }
                    }
                    
                    /// <summary>List of blocks of URLs. Each block may contain a heading and a list of URLs. Each URL may optionally include additional details.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("urlBlocks")]
                    public virtual IList<RuleResultsDataSchema.UrlBlocksData> UrlBlocks {
                        get {
                            return this.urlBlocks;
                        }
                        set {
                            this.urlBlocks = value;
                        }
                    }
                    
                    public class UrlBlocksData {
                        
                        private UrlBlocksData.HeaderData header;
                        
                        private IList<UrlBlocksData.UrlsData> urls;
                        
                        /// <summary>Heading to be displayed with the list of URLs.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("header")]
                        public virtual UrlBlocksData.HeaderData Header {
                            get {
                                return this.header;
                            }
                            set {
                                this.header = value;
                            }
                        }
                        
                        /// <summary>List of entries that provide information about URLs in the url block. Optional.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("urls")]
                        public virtual IList<UrlBlocksData.UrlsData> Urls {
                            get {
                                return this.urls;
                            }
                            set {
                                this.urls = value;
                            }
                        }
                        
                        /// <summary>Heading to be displayed with the list of URLs.</summary>
                        public class HeaderData {
                            
                            private IList<HeaderData.ArgsData> args;
                            
                            private string format;
                            
                            /// <summary>List of arguments for the format string.</summary>
                            [Newtonsoft.Json.JsonPropertyAttribute("args")]
                            public virtual IList<HeaderData.ArgsData> Args {
                                get {
                                    return this.args;
                                }
                                set {
                                    this.args = value;
                                }
                            }
                            
                            /// <summary>A localized format string with $N placeholders, where N is the 1-indexed argument number, e.g. &apos;Minifying the following $1 resources would save a total of $2 bytes&apos;.</summary>
                            [Newtonsoft.Json.JsonPropertyAttribute("format")]
                            public virtual string Format {
                                get {
                                    return this.format;
                                }
                                set {
                                    this.format = value;
                                }
                            }
                            
                            public class ArgsData {
                                
                                private string type;
                                
                                private string value;
                                
                                /// <summary>Type of argument. One of URL, STRING_LITERAL, INT_LITERAL, BYTES, or DURATION.</summary>
                                [Newtonsoft.Json.JsonPropertyAttribute("type")]
                                public virtual string Type {
                                    get {
                                        return this.type;
                                    }
                                    set {
                                        this.type = value;
                                    }
                                }
                                
                                /// <summary>Argument value, as a localized string.</summary>
                                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                                public virtual string Value {
                                    get {
                                        return this.value;
                                    }
                                    set {
                                        this.value = value;
                                    }
                                }
                            }
                        }
                        
                        public class UrlsData {
                            
                            private IList<UrlsData.DetailsData> details;
                            
                            private UrlsData.ResultData result;
                            
                            /// <summary>List of entries that provide additional details about a single URL. Optional.</summary>
                            [Newtonsoft.Json.JsonPropertyAttribute("details")]
                            public virtual IList<UrlsData.DetailsData> Details {
                                get {
                                    return this.details;
                                }
                                set {
                                    this.details = value;
                                }
                            }
                            
                            /// <summary>A format string that gives information about the URL, and a list of arguments for that format string.</summary>
                            [Newtonsoft.Json.JsonPropertyAttribute("result")]
                            public virtual UrlsData.ResultData Result {
                                get {
                                    return this.result;
                                }
                                set {
                                    this.result = value;
                                }
                            }
                            
                            public class DetailsData {
                                
                                private IList<DetailsData.ArgsData> args;
                                
                                private string format;
                                
                                /// <summary>List of arguments for the format string.</summary>
                                [Newtonsoft.Json.JsonPropertyAttribute("args")]
                                public virtual IList<DetailsData.ArgsData> Args {
                                    get {
                                        return this.args;
                                    }
                                    set {
                                        this.args = value;
                                    }
                                }
                                
                                /// <summary>A localized format string with $N placeholders, where N is the 1-indexed argument number, e.g. &apos;Unnecessary metadata for this resource adds an additional $1 bytes to its download size&apos;.</summary>
                                [Newtonsoft.Json.JsonPropertyAttribute("format")]
                                public virtual string Format {
                                    get {
                                        return this.format;
                                    }
                                    set {
                                        this.format = value;
                                    }
                                }
                                
                                public class ArgsData {
                                    
                                    private string type;
                                    
                                    private string value;
                                    
                                    /// <summary>Type of argument. One of URL, STRING_LITERAL, INT_LITERAL, BYTES, or DURATION.</summary>
                                    [Newtonsoft.Json.JsonPropertyAttribute("type")]
                                    public virtual string Type {
                                        get {
                                            return this.type;
                                        }
                                        set {
                                            this.type = value;
                                        }
                                    }
                                    
                                    /// <summary>Argument value, as a localized string.</summary>
                                    [Newtonsoft.Json.JsonPropertyAttribute("value")]
                                    public virtual string Value {
                                        get {
                                            return this.value;
                                        }
                                        set {
                                            this.value = value;
                                        }
                                    }
                                }
                            }
                            
                            /// <summary>A format string that gives information about the URL, and a list of arguments for that format string.</summary>
                            public class ResultData {
                                
                                private IList<ResultData.ArgsData> args;
                                
                                private string format;
                                
                                /// <summary>List of arguments for the format string.</summary>
                                [Newtonsoft.Json.JsonPropertyAttribute("args")]
                                public virtual IList<ResultData.ArgsData> Args {
                                    get {
                                        return this.args;
                                    }
                                    set {
                                        this.args = value;
                                    }
                                }
                                
                                /// <summary>A localized format string with $N placeholders, where N is the 1-indexed argument number, e.g. &apos;Minifying the resource at URL $1 can save $2 bytes&apos;.</summary>
                                [Newtonsoft.Json.JsonPropertyAttribute("format")]
                                public virtual string Format {
                                    get {
                                        return this.format;
                                    }
                                    set {
                                        this.format = value;
                                    }
                                }
                                
                                public class ArgsData {
                                    
                                    private string type;
                                    
                                    private string value;
                                    
                                    /// <summary>Type of argument. One of URL, STRING_LITERAL, INT_LITERAL, BYTES, or DURATION.</summary>
                                    [Newtonsoft.Json.JsonPropertyAttribute("type")]
                                    public virtual string Type {
                                        get {
                                            return this.type;
                                        }
                                        set {
                                            this.type = value;
                                        }
                                    }
                                    
                                    /// <summary>Argument value, as a localized string.</summary>
                                    [Newtonsoft.Json.JsonPropertyAttribute("value")]
                                    public virtual string Value {
                                        get {
                                            return this.value;
                                        }
                                        set {
                                            this.value = value;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
        /// <summary>Summary statistics for the page, such as number of JavaScript bytes, number of HTML bytes, etc.</summary>
        public class PageStatsData {
            
            private string cssResponseBytes;
            
            private string flashResponseBytes;
            
            private string htmlResponseBytes;
            
            private string imageResponseBytes;
            
            private string javascriptResponseBytes;
            
            private long numberCssResources;
            
            private long numberHosts;
            
            private long numberJsResources;
            
            private long numberResources;
            
            private long numberStaticResources;
            
            private string otherResponseBytes;
            
            private string textResponseBytes;
            
            private string totalRequestBytes;
            
            /// <summary>Number of uncompressed response bytes for CSS resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("cssResponseBytes")]
            public virtual string CssResponseBytes {
                get {
                    return this.cssResponseBytes;
                }
                set {
                    this.cssResponseBytes = value;
                }
            }
            
            /// <summary>Number of response bytes for flash resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("flashResponseBytes")]
            public virtual string FlashResponseBytes {
                get {
                    return this.flashResponseBytes;
                }
                set {
                    this.flashResponseBytes = value;
                }
            }
            
            /// <summary>Number of uncompressed response bytes for the main HTML document and all iframes on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("htmlResponseBytes")]
            public virtual string HtmlResponseBytes {
                get {
                    return this.htmlResponseBytes;
                }
                set {
                    this.htmlResponseBytes = value;
                }
            }
            
            /// <summary>Number of response bytes for image resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("imageResponseBytes")]
            public virtual string ImageResponseBytes {
                get {
                    return this.imageResponseBytes;
                }
                set {
                    this.imageResponseBytes = value;
                }
            }
            
            /// <summary>Number of uncompressed response bytes for JS resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("javascriptResponseBytes")]
            public virtual string JavascriptResponseBytes {
                get {
                    return this.javascriptResponseBytes;
                }
                set {
                    this.javascriptResponseBytes = value;
                }
            }
            
            /// <summary>Number of CSS resources referenced by the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberCssResources")]
            public virtual long NumberCssResources {
                get {
                    return this.numberCssResources;
                }
                set {
                    this.numberCssResources = value;
                }
            }
            
            /// <summary>Number of unique hosts referenced by the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberHosts")]
            public virtual long NumberHosts {
                get {
                    return this.numberHosts;
                }
                set {
                    this.numberHosts = value;
                }
            }
            
            /// <summary>Number of JavaScript resources referenced by the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberJsResources")]
            public virtual long NumberJsResources {
                get {
                    return this.numberJsResources;
                }
                set {
                    this.numberJsResources = value;
                }
            }
            
            /// <summary>Number of HTTP resources loaded by the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberResources")]
            public virtual long NumberResources {
                get {
                    return this.numberResources;
                }
                set {
                    this.numberResources = value;
                }
            }
            
            /// <summary>Number of static (i.e. cacheable) resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberStaticResources")]
            public virtual long NumberStaticResources {
                get {
                    return this.numberStaticResources;
                }
                set {
                    this.numberStaticResources = value;
                }
            }
            
            /// <summary>Number of response bytes for other resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("otherResponseBytes")]
            public virtual string OtherResponseBytes {
                get {
                    return this.otherResponseBytes;
                }
                set {
                    this.otherResponseBytes = value;
                }
            }
            
            /// <summary>Number of uncompressed response bytes for text resources not covered by other statistics (i.e non-HTML, non-script, non-CSS resources) on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("textResponseBytes")]
            public virtual string TextResponseBytes {
                get {
                    return this.textResponseBytes;
                }
                set {
                    this.textResponseBytes = value;
                }
            }
            
            /// <summary>Total size of all request bytes sent by the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("totalRequestBytes")]
            public virtual string TotalRequestBytes {
                get {
                    return this.totalRequestBytes;
                }
                set {
                    this.totalRequestBytes = value;
                }
            }
        }
        
        /// <summary>The version of the Page Speed SDK used to generate these results.</summary>
        public class VersionData {
            
            private long major;
            
            private long minor;
            
            /// <summary>The major version number of the Page Speed SDK used to generate these results.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("major")]
            public virtual long Major {
                get {
                    return this.major;
                }
                set {
                    this.major = value;
                }
            }
            
            /// <summary>The minor version number of the Page Speed SDK used to generate these results.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("minor")]
            public virtual long Minor {
                get {
                    return this.minor;
                }
                set {
                    this.minor = value;
                }
            }
        }
    }
}
namespace Google.Apis.Pagespeedonline.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class PagespeedonlineService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1";
        
        private const string Name = "pagespeedonline";
        
        private const string BaseUri = "https://www.googleapis.com/pagespeedonline/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string developerKey;
        
        private PagespeedapiResource pagespeedapi;
        
        public PagespeedonlineService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.pagespeedapi = new PagespeedapiResource(this);
        }
        
        public PagespeedonlineService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.CachedWebDiscoveryDevice(new System.Uri(string.Format("https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest", PagespeedonlineService.Name, PagespeedonlineService.Version)))).GetService(PagespeedonlineService.Version, PagespeedonlineService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(PagespeedonlineService.BaseUri))), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
        }
        
        /// <summary>Sets the DeveloperKey which this service uses for all requests</summary>
        public virtual string DeveloperKey {
            get {
                return this.developerKey;
            }
            set {
                this.developerKey = value;
            }
        }
        
        public virtual PagespeedapiResource Pagespeedapi {
            get {
                return this.pagespeedapi;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (string.IsNullOrEmpty(DeveloperKey) == false) {
                request = request.WithDeveloperKey(this.DeveloperKey);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
    }
    
    public class PagespeedapiResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "pagespeedapi";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(PagespeedapiResource));
        
        public PagespeedapiResource(PagespeedonlineService service) {
            this.service = service;
        }
        
        /// <summary>Runs Page Speed analysis on the page at the specified URL, and returns a Page Speed score, a list of suggestions to make that page faster, and other information.</summary>
        /// <param name="url">Required - Must match pattern http(s)?://.* - The URL to fetch and analyze</param>
        public virtual RunpagespeedRequest Runpagespeed(string url) {
            return new RunpagespeedRequest(service, url);
        }
        
        /// <summary>Runs Page Speed analysis on the page at the specified URL, and returns a Page Speed score, a list of suggestions to make that page faster, and other information.</summary>
        /// <param name="url">Required - Must match pattern http(s)?://.* - The URL to fetch and analyze</param>
        /// <param name="locale">Optional - Must match pattern [a-zA-Z]+(_[a-zA-Z]+)? - The locale used to localize formatted results</param>
        /// <param name="rule">Optional - Must match pattern [a-zA-Z]+ - A Page Speed rule to run; if none are given, all rules are run</param>
        /// <param name="strategy">Optional - Must be one of the following values [desktop, mobile] - The analysis strategy to use</param>
        public virtual RunpagespeedRequest Runpagespeed(string url, [System.Runtime.InteropServices.OptionalAttribute()] string locale, [System.Runtime.InteropServices.OptionalAttribute()] Google.Apis.Util.Repeatable<string> rule, [System.Runtime.InteropServices.OptionalAttribute()] Strategy? strategy) {
            return new RunpagespeedRequest(service, url, locale, rule, strategy);
        }
        
        /// <summary>The analysis strategy to use</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Strategy {
            
            /// <summary>Fetch and analyze the URL for desktop browsers</summary>
            [Google.Apis.Util.StringValueAttribute("desktop")]
            Desktop,
            
            /// <summary>Fetch and analyze the URL for mobile devices</summary>
            [Google.Apis.Util.StringValueAttribute("mobile")]
            Mobile,
        }
        
        public class RunpagespeedRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Pagespeedonline.v1.Data.Result> {
            
            private string locale;
            
            private Google.Apis.Util.Repeatable<string> rule;
            
            private Strategy? strategy;
            
            private string url;
            
            public RunpagespeedRequest(Google.Apis.Discovery.IRequestProvider service, string url) : 
                    base(service) {
                this.url = url;
            }
            
            public RunpagespeedRequest(Google.Apis.Discovery.IRequestProvider service, string url, [System.Runtime.InteropServices.OptionalAttribute()] string locale, [System.Runtime.InteropServices.OptionalAttribute()] Google.Apis.Util.Repeatable<string> rule, [System.Runtime.InteropServices.OptionalAttribute()] Strategy? strategy) : 
                    base(service) {
                this.url = url;
                this.locale = locale;
                this.rule = rule;
                this.strategy = strategy;
            }
            
            /// <summary>The locale used to localize formatted results</summary>
            [Google.Apis.Util.RequestParameterAttribute("locale")]
            public virtual string Locale {
                get {
                    return this.locale;
                }
                set {
                    this.locale = value;
                }
            }
            
            /// <summary>A Page Speed rule to run; if none are given, all rules are run</summary>
            [Google.Apis.Util.RequestParameterAttribute("rule")]
            public virtual Google.Apis.Util.Repeatable<string> Rule {
                get {
                    return this.rule;
                }
                set {
                    this.rule = value;
                }
            }
            
            /// <summary>The analysis strategy to use</summary>
            [Google.Apis.Util.RequestParameterAttribute("strategy")]
            public virtual Strategy? Strategy {
                get {
                    return this.strategy;
                }
                set {
                    this.strategy = value;
                }
            }
            
            /// <summary>The URL to fetch and analyze</summary>
            [Google.Apis.Util.RequestParameterAttribute("url")]
            public virtual string Url {
                get {
                    return this.url;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "pagespeedapi";
                }
            }
            
            protected override string MethodName {
                get {
                    return "runpagespeed";
                }
            }
        }
    }
}

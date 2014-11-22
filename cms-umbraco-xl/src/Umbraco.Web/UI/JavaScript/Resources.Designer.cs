﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Umbraco.Web.UI.JavaScript {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Umbraco.Web.UI.JavaScript.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///    &apos;lib/jquery/jquery-2.0.3.min.js&apos;,
        ///    &apos;lib/angular/1.1.5/angular.min.js&apos;,
        ///    &apos;lib/underscore/underscore.js&apos;,
        ///
        ///    &apos;lib/jquery/jquery-ui-1.10.3.custom.min.js&apos;,
        ///
        ///    &apos;lib/angular/1.1.5/angular-cookies.min.js&apos;,
        ///    &apos;lib/angular/1.1.5/angular-mobile.js&apos;,
        ///    &apos;lib/angular/1.1.5/angular-sanitize.min.js&apos;,
        ///
        ///    &apos;lib/angular/angular-ui-sortable.js&apos;,
        ///    
        ///    &apos;lib/jquery/jquery.upload/js/jquery.fileupload.js&apos;,
        ///    &apos;lib/jquery/jquery.upload/js/load-image.min.js&apos;,
        ///    &apos;lib/jquery/jquery.upload/js/ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string JsInitialize {
            get {
                return ResourceManager.GetString("JsInitialize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LazyLoad.js(&quot;##JsInitialize##&quot;, function () {
        ///    //we need to set the legacy UmbClientMgr path
        ///    UmbClientMgr.setUmbracoPath(&apos;&quot;##UmbracoPath##&quot;&apos;);
        ///
        ///    jQuery(document).ready(function () {
        ///        angular.bootstrap(document, [&apos;umbraco&apos;]);
        ///    });
        ///});.
        /// </summary>
        internal static string Main {
            get {
                return ResourceManager.GetString("Main", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //TODO: This would be nicer as an angular module so it can be injected into stuff... that&apos;d be heaps nicer, but
        ///// how to do that when this is not a regular JS file, it is a server side JS file and RequireJS seems to only want
        ///// to force load JS files ?
        ///
        /////create the namespace (NOTE: This loads before any dependencies so we don&apos;t have a namespace mgr so we just create it manually)
        ///var Umbraco = {};
        ///Umbraco.Sys = {};
        /////define a global static object
        ///Umbraco.Sys.ServerVariables = ##Variables## ;.
        /// </summary>
        internal static string ServerVariables {
            get {
                return ResourceManager.GetString("ServerVariables", resourceCulture);
            }
        }
    }
}

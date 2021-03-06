﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.authright.saml2.Properties {
    using System;
    
    
    /// <summary>
    /// A strongly-typed resource class, for looking up localized strings, formatting them, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilderEx class via the ResXFileCodeGeneratorEx custom tool.
    // To add or remove a member, edit your .ResX file then rerun the ResXFileCodeGeneratorEx custom tool or rebuild your VS.NET project.
    // Copyright (c) Dmytro Kryvko 2006-2017 (http://dmytro.kryvko.googlepages.com/)
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("DMKSoftware.CodeGenerators.Tools.StronglyTypedResourceBuilderEx", "2.6.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
#if !SILVERLIGHT
    [global::System.Reflection.ObfuscationAttribute(Exclude=true, ApplyToMembers=true)]
#endif
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
    public partial class Saml20Resources {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        /// <summary>
        /// Initializes a Saml20Resources object.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public Saml20Resources() {
        }
        
        /// <summary>
        /// Thread safe lock object used by this class.
        /// </summary>
        public static object InternalSyncObject {
            get {
                if (object.ReferenceEquals(_internalSyncObject, null)) {
                    global::System.Threading.Interlocked.CompareExchange(ref _internalSyncObject, new object(), null);
                }
                return _internalSyncObject;
            }
        }
        
        /// <summary>
        /// Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(_resourceManager, null)) {
                    global::System.Threading.Monitor.Enter(InternalSyncObject);
                    try {
                        if (object.ReferenceEquals(_resourceManager, null)) {
                            global::System.Threading.Interlocked.Exchange(ref _resourceManager, new global::System.Resources.ResourceManager("com.authright.saml2.Properties.Saml20Resources", typeof(Saml20Resources).Assembly));
                        }
                    }
                    finally {
                        global::System.Threading.Monitor.Exit(InternalSyncObject);
                    }
                }
                return _resourceManager;
            }
        }
        
        /// <summary>
        /// Overrides the current thread's CurrentUICulture property for all
        /// resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return _resourceCulture;
            }
            set {
                _resourceCulture = value;
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Action SAMLRequest requires you to set the Request property.'.
        /// </summary>
        public static string ActionRequestMismatch {
            get {
                return ResourceManager.GetString(ResourceNames.ActionRequestMismatch, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Action SAMLResponse requires you to set the Response property.'.
        /// </summary>
        public static string ActionResponseMismatch {
            get {
                return ResourceManager.GetString(ResourceNames.ActionResponseMismatch, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'The IDPEndPoint with id &quot;{0}&quot; was not found in configuration file.'.
        /// </summary>
        public static string InvalidIdpEndPointId {
            get {
                return ResourceManager.GetString(ResourceNames.InvalidIdpEndPointId, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Missing &lt;IDPEndPoints&gt; element under &lt;Safewhere.SAML20Federation&gt; in configuration file.'.
        /// </summary>
        public static string MissingIDPEndpoints {
            get {
                return ResourceManager.GetString(ResourceNames.MissingIDPEndpoints, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Metadata not found for idpEndpoint with id {0}'.
        /// </summary>
        public static string MissingMetadata {
            get {
                return ResourceManager.GetString(ResourceNames.MissingMetadata, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'The &quot;metadata&quot; attribute on the &lt;IDPEndPoints&gt; tag must contain the path to a directory holding metadata descriptions of your federation partners.'.
        /// </summary>
        public static string MissingMetadataLocation {
            get {
                return ResourceManager.GetString(ResourceNames.MissingMetadataLocation, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Missing &lt;Safewhere.SAML20Federation&gt; element in configuration file.'.
        /// </summary>
        public static string MissingSaml20Federation {
            get {
                return ResourceManager.GetString(ResourceNames.MissingSaml20Federation, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Missing &lt;ServiceProvider&gt; element under &lt;Safewhere.SAML20Federation&gt; element in configuration file.'.
        /// </summary>
        public static string MissingServiceProvider {
            get {
                return ResourceManager.GetString(ResourceNames.MissingServiceProvider, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Missing id attribute on the &lt;ServiceProvider&gt; element in configuration file.'.
        /// </summary>
        public static string MissingServiceProviderId {
            get {
                return ResourceManager.GetString(ResourceNames.MissingServiceProviderId, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Missing &lt;SigningCertificate&gt; element under &lt;ServiceProvider&gt; element in configuration file.'.
        /// </summary>
        public static string MissingSigningCertificate {
            get {
                return ResourceManager.GetString(ResourceNames.MissingSigningCertificate, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Missing &lt;SLO&gt; element or missing attribute under &lt;IDPEndPoints&gt; in configuration file.'.
        /// </summary>
        public static string MissingSLO {
            get {
                return ResourceManager.GetString(ResourceNames.MissingSLO, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Missing &lt;SSO&gt; element or missing attribute under &lt;IDPEndPoints&gt; in configuration file.'.
        /// </summary>
        public static string MissingSSO {
            get {
                return ResourceManager.GetString(ResourceNames.MissingSSO, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Unable to load the certificate specified in &lt;SigningCertificate&gt; element in configuration file.'.
        /// </summary>
        public static string SigningCertficateLoadError {
            get {
                return ResourceManager.GetString(ResourceNames.SigningCertficateLoadError, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Missing access to private key for signing certificate.'.
        /// </summary>
        public static string SigningCertificateMissingPrivateKey {
            get {
                return ResourceManager.GetString(ResourceNames.SigningCertificateMissingPrivateKey, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Type of request (&quot;{0}&quot;) is not supported.'.
        /// </summary>
        public static string UnsupportedRequestType {
            get {
                return ResourceManager.GetString(ResourceNames.UnsupportedRequestType, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Type of response (&quot;{0}&quot;) is not supported.'.
        /// </summary>
        public static string UnsupportedResponseType {
            get {
                return ResourceManager.GetString(ResourceNames.UnsupportedResponseType, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Formats a localized string similar to 'The IDPEndPoint with id &quot;{0}&quot; was not found in configuration file.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string InvalidIdpEndPointIdFormat(object arg0) {
            return string.Format(_resourceCulture, InvalidIdpEndPointId, arg0);
        }
        
        /// <summary>
        /// Formats a localized string similar to 'Metadata not found for idpEndpoint with id {0}'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string MissingMetadataFormat(object arg0) {
            return string.Format(_resourceCulture, MissingMetadata, arg0);
        }
        
        /// <summary>
        /// Formats a localized string similar to 'Type of request (&quot;{0}&quot;) is not supported.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string UnsupportedRequestTypeFormat(object arg0) {
            return string.Format(_resourceCulture, UnsupportedRequestType, arg0);
        }
        
        /// <summary>
        /// Formats a localized string similar to 'Type of response (&quot;{0}&quot;) is not supported.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string UnsupportedResponseTypeFormat(object arg0) {
            return string.Format(_resourceCulture, UnsupportedResponseType, arg0);
        }
        
        /// <summary>
        /// Lists all the resource names as constant string fields.
        /// </summary>
        public class ResourceNames {
            
            /// <summary>
            /// Stores the resource name 'ActionRequestMismatch'.
            /// </summary>
            public const string ActionRequestMismatch = "ActionRequestMismatch";
            
            /// <summary>
            /// Stores the resource name 'ActionResponseMismatch'.
            /// </summary>
            public const string ActionResponseMismatch = "ActionResponseMismatch";
            
            /// <summary>
            /// Stores the resource name 'InvalidIdpEndPointId'.
            /// </summary>
            public const string InvalidIdpEndPointId = "InvalidIdpEndPointId";
            
            /// <summary>
            /// Stores the resource name 'MissingIDPEndpoints'.
            /// </summary>
            public const string MissingIDPEndpoints = "MissingIDPEndpoints";
            
            /// <summary>
            /// Stores the resource name 'MissingMetadata'.
            /// </summary>
            public const string MissingMetadata = "MissingMetadata";
            
            /// <summary>
            /// Stores the resource name 'MissingMetadataLocation'.
            /// </summary>
            public const string MissingMetadataLocation = "MissingMetadataLocation";
            
            /// <summary>
            /// Stores the resource name 'MissingSaml20Federation'.
            /// </summary>
            public const string MissingSaml20Federation = "MissingSaml20Federation";
            
            /// <summary>
            /// Stores the resource name 'MissingServiceProvider'.
            /// </summary>
            public const string MissingServiceProvider = "MissingServiceProvider";
            
            /// <summary>
            /// Stores the resource name 'MissingServiceProviderId'.
            /// </summary>
            public const string MissingServiceProviderId = "MissingServiceProviderId";
            
            /// <summary>
            /// Stores the resource name 'MissingSigningCertificate'.
            /// </summary>
            public const string MissingSigningCertificate = "MissingSigningCertificate";
            
            /// <summary>
            /// Stores the resource name 'MissingSLO'.
            /// </summary>
            public const string MissingSLO = "MissingSLO";
            
            /// <summary>
            /// Stores the resource name 'MissingSSO'.
            /// </summary>
            public const string MissingSSO = "MissingSSO";
            
            /// <summary>
            /// Stores the resource name 'SigningCertficateLoadError'.
            /// </summary>
            public const string SigningCertficateLoadError = "SigningCertficateLoadError";
            
            /// <summary>
            /// Stores the resource name 'SigningCertificateMissingPrivateKey'.
            /// </summary>
            public const string SigningCertificateMissingPrivateKey = "SigningCertificateMissingPrivateKey";
            
            /// <summary>
            /// Stores the resource name 'UnsupportedRequestType'.
            /// </summary>
            public const string UnsupportedRequestType = "UnsupportedRequestType";
            
            /// <summary>
            /// Stores the resource name 'UnsupportedResponseType'.
            /// </summary>
            public const string UnsupportedResponseType = "UnsupportedResponseType";
        }
    }
}

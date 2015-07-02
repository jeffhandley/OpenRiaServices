﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenRiaServices.DomainControllers.Server {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenRiaServices.DomainControllers.Server.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to The specified entity does not exist in the ChangeSet..
        /// </summary>
        internal static string ChangeSet_ChangeSetEntryNotFound {
            get {
                return ResourceManager.GetString("ChangeSet_ChangeSetEntryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GetOriginal cannot be called for a new entity being inserted..
        /// </summary>
        internal static string ChangeSet_OriginalNotValidForInsert {
            get {
                return ResourceManager.GetString("ChangeSet_OriginalNotValidForInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MetadataTypeAttribute on type &apos;{0}&apos; results in a cyclic metadata provider chain. Either remove the attribute or remove the cycle..
        /// </summary>
        internal static string CyclicMetadataTypeAttributesFound {
            get {
                return ResourceManager.GetString("CyclicMetadataTypeAttributesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more associated objects were passed for collection property &apos;{1}&apos; on type &apos;{0}&apos;, but the target collection is null..
        /// </summary>
        internal static string DomainController_AssociationCollectionPropertyIsNull {
            get {
                return ResourceManager.GetString("DomainController_AssociationCollectionPropertyIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This DomainController does not support operation &apos;{0}&apos; for entity &apos;{1}&apos;..
        /// </summary>
        internal static string DomainController_InvalidAction {
            get {
                return ResourceManager.GetString("DomainController_InvalidAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Association collection member &apos;{0}&apos; does not implement IList and does not have an Add method..
        /// </summary>
        internal static string DomainController_InvalidCollectionMember {
            get {
                return ResourceManager.GetString("DomainController_InvalidCollectionMember", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Action &apos;{0}.{1}&apos; has one or more filters applied that do not derive from AuthorizationFilterAttribute. Only authorization filters are supported on DomainController Insert/Update/Delete actions..
        /// </summary>
        internal static string InvalidAction_UnsupportedFilterType {
            get {
                return ResourceManager.GetString("InvalidAction_UnsupportedFilterType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid ChangeSet: {0}.
        /// </summary>
        internal static string InvalidChangeSet {
            get {
                return ResourceManager.GetString("InvalidChangeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Id &apos;{0}&apos; specified for association member &apos;{0}.{1}&apos; is invalid..
        /// </summary>
        internal static string InvalidChangeSet_AssociatedIdNotInChangeset {
            get {
                return ResourceManager.GetString("InvalidChangeSet_AssociatedIdNotInChangeset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Associated Ids for member &apos;{0}.{1}&apos; cannot be null..
        /// </summary>
        internal static string InvalidChangeSet_AssociatedIdsCannotBeNull {
            get {
                return ResourceManager.GetString("InvalidChangeSet_AssociatedIdsCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one entry for a given entity instance can exist in the ChangeSet..
        /// </summary>
        internal static string InvalidChangeSet_DuplicateEntity {
            get {
                return ResourceManager.GetString("InvalidChangeSet_DuplicateEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Id must be unique for each entry..
        /// </summary>
        internal static string InvalidChangeSet_DuplicateId {
            get {
                return ResourceManager.GetString("InvalidChangeSet_DuplicateId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OriginalEntity cannot be specified for an Insert operation..
        /// </summary>
        internal static string InvalidChangeSet_InsertsCantHaveOriginal {
            get {
                return ResourceManager.GetString("InvalidChangeSet_InsertsCantHaveOriginal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Association member &apos;{0}.{1}&apos; specified in the ChangeSet does not exist or is not marked with AssociationAttribute..
        /// </summary>
        internal static string InvalidChangeSet_InvalidAssociationMember {
            get {
                return ResourceManager.GetString("InvalidChangeSet_InvalidAssociationMember", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity and OriginalEntity must be of the same type..
        /// </summary>
        internal static string InvalidChangeSet_MustBeSameType {
            get {
                return ResourceManager.GetString("InvalidChangeSet_MustBeSameType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity cannot be null..
        /// </summary>
        internal static string InvalidChangeSet_NullEntity {
            get {
                return ResourceManager.GetString("InvalidChangeSet_NullEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; must derive from &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidType {
            get {
                return ResourceManager.GetString("InvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MetadataProvider type &apos;{0}&apos; must have a constructor with a single parameter of type &apos;MetadataProvider&apos;..
        /// </summary>
        internal static string MetadataProviderAttribute_MissingConstructor {
            get {
                return ResourceManager.GetString("MetadataProviderAttribute_MissingConstructor", resourceCulture);
            }
        }
    }
}

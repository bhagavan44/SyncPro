﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyncPro.UI {
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
    internal class LocalizableStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizableStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SyncPro.UI.LocalizableStrings", typeof(LocalizableStrings).Assembly);
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
        ///   Looks up a localized string similar to The property does not have any validation rules to evaluate..
        /// </summary>
        internal static string Exception_NoRulesForProperty {
            get {
                return ResourceManager.GetString("Exception_NoRulesForProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No validation attributes were declared for the property {0} on class {1}..
        /// </summary>
        internal static string Exception_NoValidationAttributesFound {
            get {
                return ResourceManager.GetString("Exception_NoValidationAttributesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The declared type of the ShouldValidation property {0} on class {1} is not &apos;bool&apos;..
        /// </summary>
        internal static string Exception_ShouldValidatePropertyNotBool {
            get {
                return ResourceManager.GetString("Exception_ShouldValidatePropertyNotBool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A ShouldValidate property with name {0} was not found on the object type {1}..
        /// </summary>
        internal static string Exception_ShouldValidatePropertyNotFound {
            get {
                return ResourceManager.GetString("Exception_ShouldValidatePropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to None of the validation rules have been evaluated..
        /// </summary>
        internal static string Exception_StateIsNotEvaluated {
            get {
                return ResourceManager.GetString("Exception_StateIsNotEvaluated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more validation states are undefined..
        /// </summary>
        internal static string Exception_StateIsUndefined {
            get {
                return ResourceManager.GetString("Exception_StateIsUndefined", resourceCulture);
            }
        }
    }
}
